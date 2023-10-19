Public Class frmTratamiento
    Private Sub cmdBuscarCI_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Dim t As New Tratamientos
        t.ci = Val(txtCI.Text)
        t.cn = cn
        Select Case t.verifyci2()
            Case 0 'Encontré
                If t.estadoborradop = 1 Then
                    If MsgBox("El paciente se dió de baja, ¿Desaea darle de alta?", MsgBoxStyle.YesNo, "S.I.BI.M - GSA") = MsgBoxResult.Yes Then
                        Select Case t.estadop()
                            Case 0
                                MsgBox("Paciente dado de alta éxitosamente.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
                            Case 1
                                MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                            Case Else
                                MsgBox("Hubo errores al realizar el alta del paciente. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                        End Select
                    End If
                Else
                    If MsgBox("¿Desea ingresar los datos de un tratamiento perteneciente a un paciente con C.I " & (txtCI.Text) & "?", MsgBoxStyle.YesNo, "S.I.BI.M - GSA") = MsgBoxResult.Yes Then
                        gbBuscar.Enabled = False
                        gbDatos.Enabled = True
                        gbDatos.Visible = True
                    End If
                End If
            Case 3 'No encontré
                MsgBox("El paciente no existe, asegurese de que ingreso correctamente la CI.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
            Case 1 : MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
            Case Else : MsgBox("Hubo errores al buscar el paciente. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
        End Select
        t = Nothing
    End Sub

    Private Sub cmdIngresar_Click(sender As Object, e As EventArgs) Handles cmdIngresar.Click
        Dim t As New Tratamientos
        t.ci = Val(txtCI.Text)
        t.nombre = txtNombre.Text
        t.fechainicio = dtpInicio.Text
        t.fechafinal = dtpFinal.Text
        t.descripcion = txtDescripción.Text
        t.cn = cn
        Select Case t.Guardar(1)
            Case 0
                t.ci = txtCI.Text
                t.nombre = txtNombre.Text
                t.fechainicio = dtpInicio.Text
                t.fechafinal = dtpFinal.Text
                t.descripcion = txtDescripción.Text
                MsgBox("Tratamiento ingresado éxitosamente.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
            Case 1 : MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
            Case Else : MsgBox("Hubo errores al ingresar el tratamiento. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
        End Select
        t = Nothing
    End Sub

    Private Sub frmTratamiento_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Me.Close()
    End Sub

    Private Sub frmTratamiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpInicio.Format = DateTimePickerFormat.Custom
        dtpInicio.CustomFormat = "yyyy/MM/dd HH:mm:ss"
        dtpFinal.Format = DateTimePickerFormat.Custom
        dtpFinal.CustomFormat = "yyyy/MM/dd HH:mm:ss"
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        txtNombre.Clear()
        dtpFinal.ResetText()
        dtpInicio.ResetText()
        txtDescripción.Clear()
        gbBuscar.Enabled = True
        gbDatos.Visible = False
    End Sub

    Private Sub txtCI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCI.KeyPress
        permitirNumerosSE(e)
    End Sub

    Private Sub dtpInicio_ValueChanged(sender As Object, e As EventArgs) Handles dtpInicio.ValueChanged
        If dtpInicio.Value > Now Then
            MsgBox("Error, no se permite ingresar una fecha mayor a la fecha actual.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
            dtpInicio.ResetText()
        End If
    End Sub

    Private Sub dtpFinal_ValueChanged(sender As Object, e As EventArgs) Handles dtpFinal.ValueChanged
        If dtpFinal.Value < dtpInicio.Value Then
            MsgBox("Error, no se permite ingresar una fecha final que sea menor a la fecha inicial.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
            dtpFinal.ResetText()
        End If
        If dtpFinal.Value = ("31/12/9998") Then
            cbFechaFinal.Checked = True
        Else
            cbFechaFinal.Checked = False
        End If
    End Sub

    Private Sub cbFechaFinal_CheckedChanged(sender As Object, e As EventArgs) Handles cbFechaFinal.CheckedChanged
        If cbFechaFinal.Checked = True Then
            dtpFinal.Value = "9998-12-31 00:00:00"
            dtpFinal.Enabled = False
            dtpFinal.Visible = False
            txtNula.Visible = True
        Else
            txtNula.Visible = False
            dtpFinal.ResetText()
            dtpFinal.Visible = True
            dtpFinal.Enabled = True
        End If
    End Sub
End Class