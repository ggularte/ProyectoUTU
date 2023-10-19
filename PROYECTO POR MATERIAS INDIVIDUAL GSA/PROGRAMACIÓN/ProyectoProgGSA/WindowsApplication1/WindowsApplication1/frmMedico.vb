Public Class frmMedico

    Private Sub cmdIngresar_Click(sender As Object, e As EventArgs) Handles cmdIngresar.Click
        Dim m As New PersonalMedico
        m.ci = Val(frmAdmPersonalMedico.txtCI.Text)
        m.especialidad = txtEspecialidad.Text
        m.cn = cn
        If rbAuxiliarMedico.Checked = False And rbMedico.Checked = False Then
            MsgBox("Debe seleccionar el tipo de personal. (Médico o Auxiliar)", MessageBoxIcon.Warning, "S.I.BI.M - GSA")
        Else
            If rbMedico.Checked = True Then
                Select Case m.Guardar3(1)
                    Case 0
                        MsgBox("Se ha ingresado éxitosamente al médico.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
                        Me.Close()
                    Case 1 : MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.")
                    Case Else : MsgBox("Hubo errores al ingresar el médico. En caso de persistir, consulte al adm. del sistema.")
                End Select
            ElseIf rbAuxiliarMedico.Checked = True Then
                Select Case m.Guardar4(1)
                    Case 0
                        MsgBox("Se ha ingresado éxitosamente al auxiliar médico.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
                        Me.Close()
                    Case 1 : MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                    Case Else : MsgBox("Hubo errores al ingresar el auxiliar médico. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                End Select
            End If
        End If
        m = Nothing
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        txtEspecialidad.Clear()
        rbAuxiliarMedico.Checked = False
        rbMedico.Checked = False
        Me.Close()
    End Sub

    Private Sub rbMedico_CheckedChanged(sender As Object, e As EventArgs) Handles rbMedico.CheckedChanged
        lblEspecialidad.Visible = True
        txtEspecialidad.Visible = True
    End Sub

    Private Sub rbAuxiliarMedico_CheckedChanged(sender As Object, e As EventArgs) Handles rbAuxiliarMedico.CheckedChanged
        lblEspecialidad.Visible = False
        txtEspecialidad.Visible = False
        txtEspecialidad.Clear()
    End Sub
End Class