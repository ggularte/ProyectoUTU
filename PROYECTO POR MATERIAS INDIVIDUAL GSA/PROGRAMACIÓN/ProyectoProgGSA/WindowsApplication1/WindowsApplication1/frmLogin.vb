Public Class frmLogin

    Private Sub txtUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsuario.KeyPress
        If Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("No se permite ingresar un usuario con espacios.", "ADVERTENCIA - S.I.BI.M - GSA")
        Else
            e.Handled = False
        End If
    End Sub


    Private Sub cmdIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIngresar.Click
        Try
            cn.Open("MIODBC", txtUsuario.Text, txtContrasenia.Text)
        Catch ex As Exception
            MsgBox("Usuario y/o contraseña incorrectos.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
            Exit Sub
        End Try
        cn.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        doyPermisos(txtUsuario.Text)
        cipub = txtUsuario.Text
        Me.Close()
    End Sub

    Private Sub txtContrasenia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContrasenia.KeyPress
        If Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("No se permite ingresar una contraseña con espacios.", "ADVERTENCIA - S.I.BI.M - GSA")
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub txtContrasenia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtContrasenia.TextChanged
        If txtContrasenia.Text.Length < 8 Then
            lblContraseniaMSG.Visible = True
            cmdIngresar.Enabled = False
        ElseIf txtContrasenia.Text.Length > 24 Then
            lblContraseniaMSG.Visible = True
            cmdIngresar.Enabled = False
        Else
            lblContraseniaMSG.Visible = False
            If lblUsuarioMSG.Visible = False And lblUsuarioMSG.Visible = False Then
                cmdIngresar.Enabled = True
            Else
                cmdIngresar.Enabled = False
            End If
        End If
    End Sub

    Private Sub txtUsuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsuario.TextChanged
        If txtUsuario.Text.Length < 4 Then
            lblUsuarioMSG.Visible = True
            cmdIngresar.Enabled = False
        ElseIf txtUsuario.Text.Length > 16 Then
            lblUsuarioMSG.Visible = True
            cmdIngresar.Enabled = False
        Else
            lblUsuarioMSG.Visible = False
            If lblContraseniaMSG.Visible = False And lblUsuarioMSG.Visible = False Then
                cmdIngresar.Enabled = True
            Else
                cmdIngresar.Enabled = False
            End If
        End If
    End Sub

    Private Sub frmLogin_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Me.Close()
    End Sub

End Class