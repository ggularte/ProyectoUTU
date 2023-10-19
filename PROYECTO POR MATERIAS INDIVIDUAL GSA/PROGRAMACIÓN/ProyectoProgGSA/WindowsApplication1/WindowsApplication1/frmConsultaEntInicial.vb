Public Class frmConsultaEntInicial
    Private Sub txtBCI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCI.KeyPress
        permitirNumerosSE(e)
    End Sub
    Private Sub cbFecha_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFecha.SelectedIndexChanged
        Dim i As New EntrevistaInicial
        i.ci = Val(txtCI.Text)
        i.fechacb = cbFecha.SelectedItem
        i.antecedentes = txtAntecedentes.Text
        i.enfermedad = txtEnfermedadActual.Text
        i.enfermedadf = txtEnfermedadFamiliar.Text
        i.estadoc = txtEstadoConciencia.Text
        i.frecuenciac = txtFrecuenciaCardiaca.Text
        i.frecuenciar = txtFrecuenciaResp.Text
        i.gradoc = txtGradoDeColab.Text
        i.gradoh = txtGradoDeHidratacion.Text
        i.motivoconsulta = txtMotivo.Text
        i.movilidad = txtMovilidad.Text
        i.nombreacompañante = txtNombreAcompañante.Text
        i.otro = txtOtro.Text
        i.temperatura = Val(txtTemperatura.Text)
        i.cimedico = Val(txtCIMedico.Text)
        i.pulso = txtPulso.Text
        i.actitud = txtActitud.Text
        i.estadon = txtEstadoNutricion.Text
        i.cn = cn
        Select Case i.Buscar()
            Case 0 'Encontré
                txtAntecedentes.Text = i.antecedentes
                txtEnfermedadActual.Text = i.enfermedad
                txtTipoEnfActual.Text = i.tipoenfactual
                txtTipoEnfAnt.Text = i.tipoenfanterior
                txtEnfermedadFamiliar.Text = i.enfermedadf
                txtEstadoConciencia.Text = i.estadoc
                txtFrecuenciaCardiaca.Text = i.frecuenciac
                txtFrecuenciaResp.Text = i.frecuenciar
                txtGradoDeColab.Text = i.gradoc
                txtGradoDeHidratacion.Text = i.gradoh
                txtMotivo.Text = i.motivoconsulta
                txtMovilidad.Text = i.movilidad
                txtNombreAcompañante.Text = i.nombreacompañante
                txtTemperatura.Text = i.temperatura
                txtCIMedico.Text = i.cimedico
                txtPulso.Text = i.pulso
                txtActitud.Text = i.actitud
                txtEstadoNutricion.Text = i.estadon
                If i.fiebre = 1 Then
                    CheckBoxFiebre.Checked = True
                Else
                    CheckBoxFiebre.Checked = False
                End If
                If i.malestar = 1 Then
                    CheckBoxMalestar.Checked = True
                Else
                    CheckBoxMalestar.Checked = False
                End If
                If i.dolor = 1 Then
                    CheckBoxDolor.Checked = True
                Else
                    CheckBoxDolor.Checked = False
                End If
                If i.otro = "" Then
                    CheckBoxOtroS.Checked = False
                    txtOtro.Clear()
                Else
                    CheckBoxOtroS.Checked = True
                    txtOtro.Text = i.otro
                End If
                gbBuscar.Enabled = False
                gbDatos.Enabled = True
                gbDatos.Visible = True
            Case Else : MsgBox("Hubo errores al efectuar operación. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
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
        Select Case i.verifyci2()
            Case 0 'Encontré
                If i.estadoborradop = 1 Then
                    If MsgBox("El paciente se dió de baja, ¿Desaea darle de alta?", MsgBoxStyle.YesNo, "S.I.BI.M - GSA") = MsgBoxResult.Yes Then
                        Select Case i.estadop()
                            Case 0
                                MsgBox("Operación efectuada con éxito.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
                            Case 1
                                MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                            Case Else
                                MsgBox("Hubo errores al efectuar operación. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                        End Select
                    End If
                Else
                    Dim lista As List(Of String)
                    lista = i.fechafunc()
                    For Each Fecha In lista
                        cbFecha.Items.Add(Fecha)
                    Next
                    gbBuscar.Enabled = False
                    gbDatos.Enabled = True
                    gbDatos.Visible = True
                End If
            Case 3 'No encontré
                MsgBox("El paciente no existe, o no se le ha realizado ninguna entrevista, asegurese de que ingreso correctamente la CI.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                txtCI.Clear()
        End Select
        i = Nothing
    End Sub
   
    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        txtCI.Clear()
        txtCIMedico.Clear()
        txtEstadoConciencia.Clear()
        txtGradoDeColab.Clear()
        cbFecha.ResetText()
        txtMovilidad.Clear()
        txtPulso.Clear()
        txtActitud.Clear()
        txtEstadoNutricion.Clear()
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
        cbFecha.Items.Clear()
    End Sub

    Private Sub frmConsultaEntInicial_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Me.Close()
    End Sub
    
    Private Sub CheckBoxDolor_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxDolor.CheckedChanged
        If CheckBoxDolor.Checked = True Then
            cmdConsultar.Visible = True
        Else
            cmdConsultar.Visible = False
        End If
    End Sub

    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs) Handles cmdConsultar.Click
        Dim i As New EntrevistaInicial
        i.ci = Val(txtCI.Text)
        i.fecha = cbFecha.SelectedItem
        i.cn = cn
        Select Case i.buscardolor()
            Case 0 'Encontré
                frmPartesCuerpo.Show()
                frmPartesCuerpo.cmdIngresar.Enabled = False
                If i.boca = 1 Then
                    frmPartesCuerpo.cbBoca.Checked = True
                Else
                    frmPartesCuerpo.cbBoca.Checked = False
                End If
                If i.brazo = 1 Then
                    frmPartesCuerpo.cbBrazo.Checked = True
                Else
                    frmPartesCuerpo.cbBrazo.Checked = False
                End If
                If i.cabeza = 1 Then
                    frmPartesCuerpo.cbCabeza.Checked = True
                Else
                    frmPartesCuerpo.cbCabeza.Checked = False
                End If
                If i.cuello = 1 Then
                    frmPartesCuerpo.cbCuello.Checked = True
                Else
                    frmPartesCuerpo.cbCuello.Checked = False
                End If
                If i.dedo = 1 Then
                    frmPartesCuerpo.cbDedo.Checked = True
                Else
                    frmPartesCuerpo.cbDedo.Checked = False
                End If
                If i.espalda = 1 Then
                    frmPartesCuerpo.cbEspalda.Checked = True
                Else
                    frmPartesCuerpo.cbEspalda.Checked = False
                End If
                If i.estomago = 1 Then
                    frmPartesCuerpo.cbEstomago.Checked = True
                Else
                    frmPartesCuerpo.cbEstomago.Checked = False
                End If
                If i.frente = 1 Then
                    frmPartesCuerpo.cbFrente.Checked = True
                Else
                    frmPartesCuerpo.cbFrente.Checked = False
                End If
                If i.garganta = 1 Then
                    frmPartesCuerpo.cbGarganta.Checked = True
                Else
                    frmPartesCuerpo.cbGarganta.Checked = False
                End If
                If i.hombro = 1 Then
                    frmPartesCuerpo.cbHombro.Checked = True
                Else
                    frmPartesCuerpo.cbHombro.Checked = False
                End If
                If i.mano = 1 Then
                    frmPartesCuerpo.cbMano.Checked = True
                Else
                    frmPartesCuerpo.cbMano.Checked = False
                End If
                If i.muslo = 1 Then
                    frmPartesCuerpo.cbMuslo.Checked = True
                Else
                    frmPartesCuerpo.cbMuslo.Checked = False
                End If
                If i.munieca = 1 Then
                    frmPartesCuerpo.cbMunieca.Checked = True
                Else
                    frmPartesCuerpo.cbMunieca.Checked = False
                End If
                If i.nariz = 1 Then
                    frmPartesCuerpo.cbNariz.Checked = True
                Else
                    frmPartesCuerpo.cbNariz.Checked = False
                End If
                If i.ojo = 1 Then
                    frmPartesCuerpo.cbOjo.Checked = True
                Else
                    frmPartesCuerpo.cbOjo.Checked = False
                End If
                If i.oreja = 1 Then
                    frmPartesCuerpo.cbOreja.Checked = True
                Else
                    frmPartesCuerpo.cbOreja.Checked = False
                End If
                If i.pantorrilla = 1 Then
                    frmPartesCuerpo.cbPantorrilla.Checked = True
                Else
                    frmPartesCuerpo.cbPantorrilla.Checked = False
                End If
                If i.pecho = 1 Then
                    frmPartesCuerpo.cbPecho.Checked = True
                Else
                    frmPartesCuerpo.cbPecho.Checked = False
                End If
                If i.pie = 1 Then
                    frmPartesCuerpo.cbPie.Checked = True
                Else
                    frmPartesCuerpo.cbPie.Checked = False
                End If
                If i.pierna = 1 Then
                    frmPartesCuerpo.cbPierna.Checked = True
                Else
                    frmPartesCuerpo.cbPierna.Checked = False
                End If
                If i.rodilla = 1 Then
                    frmPartesCuerpo.cbRodilla.Checked = True
                Else
                    frmPartesCuerpo.cbRodilla.Checked = False
                End If
                If i.tobillo = 1 Then
                    frmPartesCuerpo.cbTobillo.Checked = True
                Else
                    frmPartesCuerpo.cbTobillo.Checked = False
                End If
                If i.trasero = 1 Then
                    frmPartesCuerpo.cbTrasero.Checked = True
                Else
                    frmPartesCuerpo.cbTrasero.Checked = False
                End If
            Case Else 'No encontré
                MsgBox("Hubo errores al consultar las partes del cuerpo. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
        End Select
    End Sub
End Class