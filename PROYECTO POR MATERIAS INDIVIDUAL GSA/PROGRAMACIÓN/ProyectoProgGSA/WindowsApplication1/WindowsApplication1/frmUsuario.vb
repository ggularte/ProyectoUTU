Public Class frmUsuario

    Private Sub txtContrasena_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContrasena.KeyPress
        If Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("No se permite ingresar una contraseña con espacios.", "ADVERTENCIA - S.I.BI.M - GSA")
        Else
            e.Handled = False
        End If
    End Sub


    Private Sub txtContrasena_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtContrasena.TextChanged
        If txtContrasena.Text.Length < 8 Then
            lblContraseniaMSG.Visible = True
            cmdIngresar.Enabled = False
            cmdIngresarM.Enabled = False
        ElseIf txtContrasena.Text.Length > 24 Then
            lblContraseniaMSG.Visible = True
            cmdIngresar.Enabled = False
            cmdIngresarM.Enabled = False
        Else
            lblContraseniaMSG.Visible = False
            If lblCContrasena.Visible = False And lblUsuarioMSG.Visible = False Then
                cmdIngresar.Enabled = True
                cmdIngresarM.Enabled = True
            End If
        End If
    End Sub

    Private Sub txtCContrasena_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCContrasena.KeyPress
        If Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("No se permite ingresar una contraseña con espacios.", "ADVERTENCIA - S.I.BI.M - GSA")
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub txtCContrasena_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCContrasena.TextChanged
        If txtContrasena.Text.Equals(txtCContrasena.Text) Then
            lblCContrasena.Visible = False
            If lblContraseniaMSG.Visible = False And lblUsuarioMSG.Visible = False Then
                cmdIngresar.Enabled = True
                cmdIngresarM.Enabled = True
            End If
        Else
            lblCContrasena.Visible = True
            cmdIngresar.Enabled = False
            cmdIngresarM.Enabled = False
        End If
    End Sub
    
    Private Sub cmdIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIngresar.Click
        Dim p As New Pacientes
        p.usuario = txtUsuario.Text
        p.contrasena = txtContrasena.Text
        p.ci = Val(frmIngresoPacientes.txtBCI.Text)
        p.cn = cn
        Select Case p.adduser(1)
            Case 0
                MsgBox("Usuario ingresado éxitosamente.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
                frmIngresoPacientes.Enabled = True
                frmPaciente.Enabled = True
                Me.Close()
            Case 1 : MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
            Case Else : MsgBox("Hubo errores al ingresar el usuario. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
        End Select
        p = Nothing
    End Sub

    Private Sub txtUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsuario.KeyPress
        If Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("No se permite ingresar un usuario con espacios.", "ADVERTENCIA - S.I.BI.M - GSA")
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub cmdIngresarM_Click(sender As Object, e As EventArgs) Handles cmdIngresarM.Click
        Dim m As New PersonalMedico
        m.usuario = txtUsuario.Text
        m.contrasena = txtContrasena.Text
        m.ci = Val(frmAdmPersonalMedico.txtCI.Text)
        m.cn = cn
        If rbAuxiliarMedico.Checked = False And rbMedico.Checked = False Then
            MsgBox("Debe seleccionar el tipo de usuario. (Médico o Auxiliar)", MessageBoxIcon.Warning, "S.I.BI.M - GSA")
        Else
            If rbMedico.Checked = True Then
                Select Case m.addusermed(1)
                    Case 0
                        MsgBox("Usuario ingresado éxitosamente.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
                        frmAdmPersonalMedico.Enabled = True
                        frmAdmPersonalMedico.rbMedico.Checked = True
                        frmMedico.rbMedico.Checked = True
                        frmMedico.Enabled = True
                        Me.Close()
                    Case 1 : MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                    Case Else : MsgBox("Hubo errores al ingresar el usuario. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                End Select
            ElseIf rbAuxiliarMedico.Checked = True Then
                Select Case m.adduseraux(1)
                    Case 0
                        MsgBox("Usuario ingresado éxitosamente.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
                        frmAdmPersonalMedico.Enabled = True
                        frmAdmPersonalMedico.rbAuxiliarMedico.Checked = True
                        frmMedico.rbMedico.Checked = True
                        frmMedico.Enabled = True
                        Me.Close()
                    Case 1 : MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                    Case Else : MsgBox("Hubo errores al ingresar el usuario. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                End Select
            End If
        End If
        m = Nothing
    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged
        If txtUsuario.Text.Length < 4 Then
            lblUsuarioMSG.Visible = True
            cmdIngresar.Enabled = False
            cmdIngresarM.Enabled = False
        ElseIf txtUsuario.Text.Length > 16 Then
            lblUsuarioMSG.Visible = True
            cmdIngresar.Enabled = False
            cmdIngresarM.Enabled = False
        Else
            lblUsuarioMSG.Visible = False
            If lblContraseniaMSG.Visible = False And lblCContrasena.Visible = False Then
                cmdIngresar.Enabled = True
                cmdIngresarM.Enabled = True
            Else
                cmdIngresar.Enabled = False
                cmdIngresarM.Enabled = False
            End If
        End If
    End Sub
End Class