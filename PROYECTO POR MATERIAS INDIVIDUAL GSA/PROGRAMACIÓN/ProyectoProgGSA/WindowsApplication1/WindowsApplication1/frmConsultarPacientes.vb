Public Class frmConsultarPacientes

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        txtPnombre.Clear()
        txtSnombre.Clear()
        txtPapellido.Clear()
        txtSapellido.Clear()
        cbTelefono.ResetText()
        dtpFechaNac.ResetText()
        txtEdad.Clear()
        txtCalle.Clear()
        txtEcivil.Clear()
        txtSexo.Clear()
        cbTelefono.Items.Clear()
        txtCorreo.Clear()
        txtNpuerta.Clear()
        txtEsquina.Clear()
        gbBuscar.Enabled = True
        gbDatos.Visible = False
    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Dim p As New Pacientes
        p.ci = Val(txtBCI.Text)
        p.cn = cn
        Select Case p.Buscar()
            Case 0 'Encontré
                If p.estadoborradop = 1 Then
                    If MsgBox("El paciente se dió de baja, ¿Desaea darle de alta?", MsgBoxStyle.YesNo, "S.I.BI.M - GSA") = MsgBoxResult.Yes Then
                        Select Case p.estadop()
                            Case 0
                                MsgBox("El alta del paciente se realizó éxitosamente", MessageBoxIcon.Information, "S.I.BI.M - GSA")
                            Case 1
                                MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                            Case Else
                                MsgBox("Hubo errores al realizar el alta. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                        End Select
                    End If
                Else
                    txtPnombre.Text = p.pnombre
                    txtSnombre.Text = p.snombre
                    txtPapellido.Text = p.papellido
                    txtSapellido.Text = p.sapellido
                    dtpFechaNac.Text = p.fechanac
                    txtEdad.Text = p.edad
                    txtEcivil.Text = p.estadocivil
                    txtSexo.Text = p.sexo
                    txtCalle.Text = p.calle
                    txtCorreo.Text = p.correo
                    txtNpuerta.Text = p.nropuerta
                    txtEsquina.Text = p.esquina
                    Dim lista2 As List(Of String)
                    lista2 = p.patelefono()
                    For Each Telefono In lista2
                        cbTelefono.Items.Add(Telefono)
                    Next
                    gbBuscar.Enabled = False
                    gbDatos.Visible = True
                End If
            Case 3
                MsgBox("No se encontró al paciente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
            Case Else : MsgBox("Hubo errores al buscar el paciente. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
        End Select
        p = Nothing
    End Sub

    Private Sub frmConsultarPacientes_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Me.Close()
    End Sub
End Class