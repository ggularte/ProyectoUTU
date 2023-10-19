Public Class frmEntrevistaInicial

    Private Sub txtBCI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCI.KeyPress
        permitirNumerosSE(e)
    End Sub

    Private Sub txtTemperatura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTemperatura.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("No se permite ingresar espacios.", "ADVERTENCIA")
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        Else
            MessageBox.Show("No se permite ingresar letras a excepción de puntos o números.", "ADVERTENCIA")
            e.Handled = True
        End If
    End Sub

    Private Sub cmdIngresar_Click(ByVal sender As Object, e As EventArgs) Handles cmdIngresar.Click
        Dim i As New EntrevistaInicial
        i.ci = Val(txtCI.Text)
        i.cimedico = Val(txtCIMedico.Text)
        i.estadoc = txtEstadoConciencia.Text
        i.gradoc = txtGradoDeColab.Text
        i.fecha = dtpFecha.Value
        i.movilidad = txtMovilidad.Text
        i.actitud = cbActitud.SelectedItem()
        i.pulso = cbPulso.SelectedItem()
        i.estadon = cbEstadoNutricion.SelectedItem()
        i.gradoh = txtGradoDeHidratacion.Text
        i.estadoc = txtEstadoConciencia.Text
        i.motivoconsulta = txtMotivo.Text
        i.temperatura = txtTemperatura.Text
        i.frecuenciac = txtFrecuenciaCardiaca.Text
        i.frecuenciar = txtFrecuenciaResp.Text
        i.enfermedad = txtEnfermedadActual.Text
        i.nombreacompañante = txtNombreAcompañante.Text
        i.enfermedadf = txtEnfermedadFamiliar.Text
        i.antecedentes = txtAntecedentes.Text
        i.tipoenfanterior = txtTipoEnfAnt.Text
        i.tipoenfactual = txtTipoEnfActual.Text
        i.otro = txtOtro.Text
        i.cn = cn
        If CheckBoxFiebre.Checked = True Then
            i.fiebre = 1
        Else
            i.fiebre = 0
        End If
        If CheckBoxDolor.Checked = True Then
            i.dolor = 1
        Else
            i.dolor = 0
        End If
        If CheckBoxMalestar.Checked = True Then
            i.malestar = 1
        Else
            i.malestar = 0
        End If
        Select Case i.Guardar(1)
            Case 0
                MsgBox("Entrevista inicial ingresada éxitosamente.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
                If CheckBoxDolor.Checked = True Then
                    frmPartesCuerpo.Show()
                Else
                    frmPrediccion.Show()
                End If
            Case 1 : MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
            Case Else : MsgBox("Hubo errores al ingresar la entrevista inicial. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
        End Select
        i = Nothing
    End Sub

    Private Sub CheckBoxOtroS_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxOtroS.CheckedChanged
        If CheckBoxOtroS.Checked = True Then
            txtOtro.Visible = True
        Else
            txtOtro.Clear()
            txtOtro.Visible = False
        End If
    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Dim i As New EntrevistaInicial
        i.ci = Val(txtCI.Text)
        i.cn = cn
        Select Case i.verifyci()
            Case 0 'Encontré
                If i.estadoborradop = 1 Then
                    If MsgBox("El paciente se dió de baja, ¿Desaea darle de alta?", MsgBoxStyle.YesNo, "S.I.BI.M - GSA") = MsgBoxResult.Yes Then
                        Select Case i.estadop()
                            Case 0
                                MsgBox("El alta del paciente se realizó éxitosamente.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
                            Case 1
                                MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                            Case Else
                                MsgBox("Hubo errores al realizar el alta. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                        End Select
                    End If
                Else
                    For Each tipo In i.actitudE
                        cbActitud.Items.Add(tipo)
                    Next
                    For Each tipo In i.estadonE
                        cbEstadoNutricion.Items.Add(tipo)
                    Next
                    For Each tipo In i.pulsoE
                        cbPulso.Items.Add(tipo)
                    Next
                    gbBuscar.Enabled = False
                    gbDatos.Enabled = True
                    gbDatos.Visible = True
                End If
            Case 3 'No encontré
                MsgBox("El paciente no existe, asegurese de que ingreso correctamente la CI.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                txtCI.Clear()
        End Select
        i = Nothing
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        txtCI.Clear()
        txtCIMedico.Clear()
        txtEstadoConciencia.Clear()
        txtGradoDeColab.Clear()
        dtpFecha.ResetText()
        txtMovilidad.Clear()
        cbActitud.ResetText()
        cbPulso.ResetText()
        cbEstadoNutricion.ResetText()
        txtGradoDeHidratacion.Clear()
        txtEstadoConciencia.Clear()
        txtMotivo.Clear()
        txtFrecuenciaResp.Clear()
        txtTemperatura.Clear()
        txtFrecuenciaCardiaca.Clear()
        txtEnfermedadActual.Clear()
        txtNombreAcompañante.Clear()
        txtEnfermedadFamiliar.Clear()
        txtAntecedentes.Clear()
        txtTipoEnfActual.Clear()
        txtTipoEnfAnt.Clear()
        txtOtro.Clear()
        CheckBoxDolor.Checked = False
        CheckBoxFiebre.Checked = False
        CheckBoxOtroS.Checked = False
        CheckBoxMalestar.Checked = False
        gbBuscar.Enabled = True
        gbDatos.Visible = False
    End Sub

    Private Sub frmEntrevistaInicial_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Me.Close()
    End Sub

    Private Sub frmEntrevistaInicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFecha.Format = DateTimePickerFormat.Custom
        dtpFecha.CustomFormat = "yyyy/MM/dd HH:mm:ss"
    End Sub

    Private Sub txtGradoDeColab_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGradoDeColab.KeyPress
        permitirLetrasCE(e)
    End Sub

    Private Sub txtMovilidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMovilidad.KeyPress
        permitirLetrasCE(e)
    End Sub

    Private Sub txtEstadoConciencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEstadoConciencia.KeyPress
        permitirLetrasCE(e)
    End Sub

    Private Sub txtNombreAcompañante_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreAcompañante.KeyPress
        permitirLetrasCE(e)
    End Sub

    Private Sub txtCIMedico_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCIMedico.KeyPress
        permitirNumerosSE(e)
        If txtCIMedico.Text.Equals(txtCI.Text) Then
            MsgBox("Error, no se permite ingresar un médico que se atienda a sí mismo.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
            txtCIMedico.Clear()
        End If
    End Sub

    Private Sub txtTipoEnfActual_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTipoEnfActual.KeyPress
        permitirLetrasCE(e)
    End Sub

    Private Sub txtTipoEnfAnt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTipoEnfAnt.KeyPress
        permitirLetrasCE(e)
    End Sub

    Private Sub txtGradoDeHidratacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGradoDeHidratacion.KeyPress
        permitirLetrasCE(e)
    End Sub

    Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha.ValueChanged
        If dtpFecha.Value > Now Then
            MsgBox("Error, no se permite ingresar una fecha mayor a la fecha actual.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
            dtpFecha.ResetText()
        End If
    End Sub

    Private Sub txtTemperatura_TextChanged(sender As Object, e As EventArgs) Handles txtTemperatura.TextChanged
        If Val(txtTemperatura.Text) >= 37.5 Then
            CheckBoxFiebre.Checked = True
        Else
            CheckBoxFiebre.Checked = False
        End If
    End Sub
End Class