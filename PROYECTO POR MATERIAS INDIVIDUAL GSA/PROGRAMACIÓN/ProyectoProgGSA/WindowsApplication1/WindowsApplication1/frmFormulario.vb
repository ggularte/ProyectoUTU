Public Class frmFormulario

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Dim f As New Formularios
        f.ci = Val(txtCI.Text)
        f.cn = cn
        Select Case f.verifyci2()
            Case 0 'Encontré
                If f.estadoborradop = 1 Then
                    If MsgBox("El paciente se dió de baja, ¿Desaea darle de alta?", MsgBoxStyle.YesNo, "S.I.BI.M - GSA") = MsgBoxResult.Yes Then
                        Select Case f.estadop()
                            Case 0
                                MsgBox("El alta del paciente se realizó éxitosamente.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
                            Case 1
                                MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                            Case Else
                                MsgBox("Hubo errores al realizar el alta. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                        End Select
                    End If
                Else
                    Select Case f.comprobarFecha()
                        Case 0
                            Dim lista As List(Of String)
                            lista = f.fechafunc()
                            For Each Fecha In lista
                                cbFecha.Items.Add(Fecha)
                            Next
                            Dim lista2 As List(Of String)
                            lista2 = f.tipoform()
                            For Each Diagnostico In lista2
                                cboTipo.Items.Add(Diagnostico)
                            Next
                            gbBuscar.Enabled = False
                            gbDatos.Enabled = True
                            gbDatos.Visible = True
                            gbIngPreg.Enabled = True
                            gbIngPreg.Visible = True
                            gbSelecPreg.Enabled = True
                            gbSelecPreg.Visible = True
                            gbIngResp.Enabled = True
                            gbIngResp.Visible = True
                        Case Else
                            MsgBox("El paciente no tiene consultas con un médico, para contestar un formulario es necesario previamente que se atienda con un médico.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                    End Select
                End If
                        Case 3 'No encontré
                            MsgBox("El paciente no existe, asegurese de que ingreso correctamente la CI.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                        Case 1 : MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                        Case Else : MsgBox("Hubo errores al buscar el paciente. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                    End Select
                    f = Nothing
    End Sub

    Private Sub cbFecha_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFecha.SelectedIndexChanged
        Dim f As New Formularios
        f.fecha = cbFecha.SelectedItem()
        f.cn = cn
        Dim lista As List(Of String)
        lista = f.cifunc()
        For Each CI In lista
            cbCIMedico.Items.Add(CI)
        Next
    End Sub

    Private Sub cboTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipo.SelectedIndexChanged
        Dim f As New Formularios
        f.tipo = cboTipo.SelectedItem()
        f.cn = cn
        Dim lista As List(Of Integer)
        lista = f.idform()
        cboPregunta.Items.Clear()
        cboPregunta.ResetText()
        cboID.Items.Clear()
        cboID.ResetText()
        For Each id In lista
            cboID.Items.Add(id)
        Next
    End Sub

    Private Sub cboID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboID.SelectedIndexChanged
        Dim f As New Formularios
        f.idf = cboID.SelectedItem()
        f.cn = cn
        cboPregunta.Items.Clear()
        cboPregunta.ResetText()
        Dim lista1 As List(Of String)
        lista1 = f.preg2()
        For Each Pregunta In lista1
            cboPregunta.Items.Add(Pregunta)
        Next
    End Sub

    Private Sub cmdIngresar_Click(sender As Object, e As EventArgs) Handles cmdIngresar.Click
        Dim f As New Formularios
        f.idf = cboID.SelectedItem()
        f.ci = txtCI.Text
        f.respuesta = txtRespuesta.Text
        f.pregunta = cboPregunta.SelectedItem()
        f.fecha = cbFecha.SelectedItem()
        f.cimedico = cbCIMedico.SelectedItem()
        f.cn = cn
        Select Case f.Guardar3(1)
            Case 0
                MsgBox("Respuesta ingresada éxitosamente.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
            Case 1 : MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
            Case Else : MsgBox("Hubo errores al ingresar la respuesta. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
        End Select
        f = Nothing
    End Sub

    Private Sub frmFormulario_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Me.Close()
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        txtCI.Clear()
        txtRespuesta.Clear()
        cbCIMedico.ResetText()
        cbFecha.ResetText()
        cboID.ResetText()
        cboPregunta.ResetText()
        cboTipo.ResetText()
        gbBuscar.Enabled = True
        gbDatos.Enabled = False
        gbDatos.Visible = False
        gbIngPreg.Enabled = False
        gbIngPreg.Visible = False
        gbSelecPreg.Enabled = False
        gbSelecPreg.Visible = False
        gbIngResp.Enabled = False
        gbIngResp.Visible = False
    End Sub

End Class