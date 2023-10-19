Public Class frmPaciente

    Private Sub frmPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim p As New Pacientes
        p.cn = cn
        Dim lista As List(Of String)
        lista = p.ecivil()
        For Each EstadoCivil In lista
            cbECivil.Items.Add(EstadoCivil)
        Next
        Dim lista1 As List(Of Char)
        lista1 = p.csexo()
        For Each Sexo In lista1
            cbSexo.Items.Add(Sexo)
        Next
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdIngresar2_Click(sender As Object, e As EventArgs) Handles cmdIngresar2.Click
        Dim p As New Pacientes
        p.ci = Val(frmIngresoPacientes.txtBCI.Text)
        p.estadocivil = cbECivil.SelectedItem
        p.sexo = cbSexo.SelectedItem
        p.cn = cn
        Select Case p.Guardar1(1)
            Case 0
                MsgBox("Paciente ingresado éxitosamente.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
                Me.Close()
            Case 1 : MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
            Case Else : MsgBox("Hubo errores al ingresar el paciente. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
        End Select
        p = Nothing
    End Sub
End Class