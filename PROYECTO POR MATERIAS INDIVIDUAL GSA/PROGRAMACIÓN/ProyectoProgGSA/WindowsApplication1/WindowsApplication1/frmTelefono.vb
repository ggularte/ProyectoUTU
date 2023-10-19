Public Class frmTelefono

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Dim p As New Pacientes
        p.ci = Val(frmIngresoPacientes.txtBCI.Text)
        p.telefono = cbTelefono.Text
        p.cn = cn
        Select Case p.GuardarT(1)
            Case 0
                MsgBox("Teléfono ingresado éxitosamente.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
                cbTelefono.Items.Clear()
                Dim lista2 As List(Of String)
                lista2 = p.patelefono()
                For Each Telefono In lista2
                    cbTelefono.Items.Add(Telefono)
                Next
            Case 1 : MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
            Case Else : MsgBox("Hubo errores al ingresar el teléfono. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
        End Select
        p = Nothing
    End Sub

    Private Sub cmdQuitar_Click(sender As Object, e As EventArgs) Handles cmdQuitar.Click
        Dim p As New Pacientes
        p.ci = Val(frmIngresoPacientes.txtBCI.Text)
        p.telefono = cbTelefono.Text
        p.cn = cn
        Select Case p.EliminarT(1)
            Case 0
                MsgBox("Teléfono eliminado éxitosamente.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
                cbTelefono.Items.Clear()
                Dim lista2 As List(Of String)
                lista2 = p.patelefono()
                For Each Telefono In lista2
                    cbTelefono.Items.Add(Telefono)
                Next
            Case 1 : MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
            Case Else : MsgBox("Hubo errores al eliminar el teléfono. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
        End Select
        p = Nothing
    End Sub

    Private Sub cmdQuitar2_Click(sender As Object, e As EventArgs) Handles cmdQuitar2.Click
        Dim p As New Pacientes
        p.ci = Val(frmAdmPersonalMedico.txtCI.Text)
        p.telefono = cbTelefono.Text
        p.cn = cn
        Select Case p.EliminarT(1)
            Case 0
                MsgBox("Teléfono eliminado éxitosamente.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
                cbTelefono.Items.Clear()
                Dim lista2 As List(Of String)
                lista2 = p.patelefono()
                For Each Telefono In lista2
                    cbTelefono.Items.Add(Telefono)
                Next
            Case 1 : MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
            Case Else : MsgBox("Hubo errores al eliminar el teléfono. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
        End Select
        p = Nothing
    End Sub

    Private Sub cmdAgregar2_Click(sender As Object, e As EventArgs) Handles cmdAgregar2.Click
        Dim p As New Pacientes
        p.ci = Val(frmAdmPersonalMedico.txtCI.Text)
        p.telefono = cbTelefono.Text
        p.cn = cn
        Select Case p.GuardarT(1)
            Case 0
                MsgBox("Teléfono ingresado éxitosamente.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
                cbTelefono.Items.Clear()
                Dim lista2 As List(Of String)
                lista2 = p.patelefono()
                For Each Telefono In lista2
                    cbTelefono.Items.Add(Telefono)
                Next
            Case 1 : MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
            Case Else : MsgBox("Hubo errores al ingresar el teléfono. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
        End Select
        p = Nothing
    End Sub

    Private Sub cbTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbTelefono.KeyPress
        permitirNumerosSE(e)
    End Sub
End Class