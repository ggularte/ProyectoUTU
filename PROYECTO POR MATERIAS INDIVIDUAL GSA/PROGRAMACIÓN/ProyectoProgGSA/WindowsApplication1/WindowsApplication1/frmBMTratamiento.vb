Public Class frmBMTratamiento

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Dim t As New Tratamientos
        t.ci = Val(txtCI.Text)
        t.cn = cn
        Dim lista As List(Of Integer)
        lista = t.idtratamiento()
        Select Case t.verifyci()
            Case 0 'Encontré
                If t.estadoborradop = 1 Then
                    If MsgBox("El paciente se dió de baja, ¿Desaea darle de alta?", MsgBoxStyle.YesNo, "S.I.BI.M - GSA") = MsgBoxResult.Yes Then
                        Select Case t.estadop()
                            Case 0
                                MsgBox("El alta del paciente se realizó éxitosamente.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
                            Case 1
                                MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                            Case Else
                                MsgBox("Hubo errores al realizar el alta. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                        End Select
                    End If
                Else
                    For Each ida In lista
                        cboID.Items.Add(ida)
                    Next
                    gbBuscar.Enabled = False
                    gbDatos.Enabled = True
                    gbDatos.Visible = True
                End If
            Case 3 'No encontré
                MsgBox("El paciente no existe, o no tiene tratamientos existentes,asegurese de que ingreso correctamente la CI.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                txtCI.Clear()
                txtDescripcion.Clear()
                txtNombre.Clear()
                dtpFinal.ResetText()
                dtpInicio.ResetText()
        End Select
        t = Nothing
    End Sub

    Private Sub cboID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboID.SelectedIndexChanged
        Dim t As New Tratamientos
        t.ci = Val(txtCI.Text)
        t.descripcion = txtDescripcion.Text
        t.nombre = txtNombre.Text
        t.fechafinal = dtpFinal.Value
        t.fechainicio = dtpInicio.Value
        t.id = cboID.SelectedItem()
        t.cn = cn
        Select Case t.Buscar()
            Case 0 'Encontré
                txtCI.Text = t.ci
                txtNombre.Text = t.nombre
                txtDescripcion.Text = t.descripcion
                dtpFinal.Value = t.fechafinal
                dtpInicio.Value = t.fechainicio
                cmdEliminar.Enabled = True
                cmdModificar.Enabled = True
            Case 3 'No encontré
                txtCI.Clear()
                txtNombre.Clear()
                txtDescripcion.Clear()
                dtpFinal.ResetText()
                dtpInicio.ResetText()
        End Select
        t = Nothing
    End Sub

    Private Sub cmdEliminar_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        Dim t As New Tratamientos
        t.id = Val(cboID.SelectedItem)
        t.ci = Val(txtCI.Text)
        t.cn = cn
        Select Case t.Eliminar()
            Case 0
                cboID.Items.Clear()
                cboID.ResetText()
                txtNombre.Clear()
                txtDescripcion.Clear()
                dtpFinal.ResetText()
                dtpInicio.ResetText()
                Dim lista As List(Of Integer)
                lista = t.idtratamiento()
                For Each ida In lista
                    cboID.Items.Add(ida)
                Next
                MsgBox("Tratamiento eliminado éxitosamente.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
            Case 1 : MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
            Case Else : MsgBox("Hubo errores al eliminar el tratamiento. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
        End Select
       
        t = Nothing
    End Sub
    Private Sub cmdModificar_Click(sender As Object, e As EventArgs) Handles cmdModificar.Click
        Dim t As New Tratamientos
        t.id = cboID.SelectedItem()
        t.descripcion = txtDescripcion.Text
        t.nombre = txtNombre.Text
        t.fechafinal = dtpFinal.Value
        t.fechainicio = dtpInicio.Value
        t.cn = cn
        Select Case t.Guardar(0)
            Case 0
                MsgBox("Tratamiento modificado éxitosamente.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
            Case 1 : MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
            Case Else : MsgBox("Hubo errores al modificar el tratamiento. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
        End Select
        t = Nothing
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        cboID.Items.Clear()
        cboID.ResetText()
        txtCI.Clear()
        txtNombre.Clear()
        txtDescripcion.Clear()
        dtpFinal.ResetText()
        dtpInicio.ResetText()
        cmdEliminar.Enabled = False
        cmdModificar.Enabled = False
        gbBuscar.Enabled = True
        gbDatos.Visible = False
    End Sub

    Private Sub frmBMTratamiento_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Me.Close()
    End Sub

    Private Sub frmBMTratamiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFinal.Format = DateTimePickerFormat.Custom
        dtpFinal.CustomFormat = "yyyy/MM/dd HH:mm:ss"
        dtpInicio.Format = DateTimePickerFormat.Custom
        dtpInicio.CustomFormat = "yyyy/MM/dd HH:mm:ss"
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