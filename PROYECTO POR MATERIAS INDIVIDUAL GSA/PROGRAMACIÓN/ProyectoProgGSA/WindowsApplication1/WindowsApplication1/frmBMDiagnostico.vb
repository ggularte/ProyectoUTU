Public Class frmBMDiagnostico

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Dim d As New Diagnosticos
        d.ci = Val(txtCI.Text)
        d.cn = cn
        Dim lista As List(Of Integer)
        lista = d.iddiag()
        Select Case d.verifyci()
            Case 0 'Encontré
                If d.estadoborradop = 1 Then
                    If MsgBox("El paciente se dió de baja, ¿Desaea darle de alta?", MsgBoxStyle.YesNo, "S.I.BI.M - GSA") = MsgBoxResult.Yes Then
                        Select Case d.estadop()
                            Case 0
                                MsgBox("El alta del paciente se realizó éxitosamente.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
                            Case 1
                                MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                            Case Else
                                MsgBox("Hubo errores al realizar el alta del paciente. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
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
                MsgBox("El paciente no existe, o no titene diagnosticos existentes,asegurese de que ingreso correctamente la CI.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                cboID.Items.Clear()
                txtCI.Clear()
                txtDescripcion.Clear()
                cboTipo.Items.Clear()
        End Select
        d = Nothing
    End Sub

    Private Sub cmdModificar_Click(sender As Object, e As EventArgs) Handles cmdModificar.Click
        Dim d As New Diagnosticos
        d.ci = Val(txtCI.Text)
        d.id = Val(cboID.Text)
        d.fecha = dtpFecha.Text
        d.tipo = cboTipo.SelectedItem()
        d.descripcion = txtDescripcion.Text
        d.cn = cn
        Select Case d.Guardar(0)
            Case 0
                MsgBox("Diagnóstico modificado éxitosamente.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
            Case 1 : MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
            Case Else : MsgBox("Hubo errores al modicar el diagnóstico. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
        End Select
        d = Nothing
    End Sub

    Private Sub frmBMDiagnostico_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Me.Close()
    End Sub

    Private Sub frmBMDiagnostico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFecha.Format = DateTimePickerFormat.Custom
        dtpFecha.CustomFormat = "yyyy/MM/dd HH:mm:ss"
        Dim d As New Diagnosticos
        d.cn = cn
        Dim lista As List(Of String)
        lista = d.tipodiag()
        For Each Diagnostico In lista
            cboTipo.Items.Add(Diagnostico)
        Next
    End Sub

    Private Sub cboID_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cboID.SelectedIndexChanged
        Dim d As New Diagnosticos
        d.ci = Val(txtCI.Text)
        d.id = Val(cboID.Text)
        d.cn = cn
        Select Case d.Buscar()
            Case 0 'Encontré
                txtCI.Text = d.ci
                cboTipo.SelectedItem = d.tipo
                cboTipo.Text = d.nombreD
                dtpFecha.Value = d.fecha
                txtDescripcion.Text = d.descripcion
                cmdEliminar.Enabled = True
                cmdModificar.Enabled = True
            Case 3 'No encontré
                txtCI.Clear()
                cboID.ResetText()
                txtDescripcion.Clear()
            Case Else : MsgBox("Hubo errores al buscar el diagnóstico. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
        End Select
        d = Nothing
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        cboID.Items.Clear()
        cboID.ResetText()
        cboTipo.ResetText()
        txtCI.Clear()
        dtpFecha.ResetText()
        txtDescripcion.Clear()
        cmdEliminar.Enabled = False
        cmdModificar.Enabled = False
        gbBuscar.Enabled = True
        gbDatos.Visible = False
    End Sub

    Private Sub cmdEliminar_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        Dim d As New Diagnosticos
        d.id = Val(cboID.SelectedItem)
        d.ci = Val(txtCI.Text)
        d.cn = cn
        Select Case d.Eliminar()
            Case 0
                cboID.Items.Clear()
                cboID.ResetText()
                cboTipo.ResetText()
                txtDescripcion.Clear()
                dtpFecha.ResetText()
                Dim lista As List(Of Integer)
                lista = d.iddiag()
                For Each ida In lista
                    cboID.Items.Add(ida)
                Next
                MsgBox("Diagnóstico eliminado éxitosamente.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
            Case 1 : MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
            Case Else : MsgBox("Hubo errores al eliminar el diagnóstico. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
        End Select
        d = Nothing
    End Sub

    Private Sub txtCI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCI.KeyPress
        permitirNumerosSE(e)
    End Sub

    Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha.ValueChanged
        If dtpFecha.Value > Now Then
            MsgBox("Error, no se permite ingresar una fecha mayor a la fecha actual.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
            dtpFecha.ResetText()
        End If
    End Sub

End Class