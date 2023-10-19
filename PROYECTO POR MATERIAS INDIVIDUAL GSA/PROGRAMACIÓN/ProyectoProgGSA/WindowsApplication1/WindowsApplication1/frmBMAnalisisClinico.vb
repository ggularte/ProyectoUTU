Public Class frmBMAnalisisClinico
    Private Sub cboID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboID.SelectedIndexChanged
        Dim a As New Analisis
        a.ci = Val(txtCI.Text)
        a.tipo = Val(txtTipo.Text)
        a.resultado = txtResultado.Text
        a.fecha = dtpFecha.Value
        a.id = cboID.SelectedItem()
        a.cn = cn
        Select Case a.Buscar()
            Case 0 'Encontré
                txtCI.Text = a.ci
                txtTipo.Text = a.tipo
                dtpFecha.Value = a.fecha
                txtResultado.Text = a.resultado
                cmdEliminar.Enabled = True
                cmdModificar.Enabled = True
            Case 3 'No encontré
                txtCI.Clear()
                txtResultado.Clear()
                txtTipo.Clear()
            Case Else : MsgBox("Hubo errores al buscar el análisis clínico. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
        End Select
        a = Nothing
    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Dim a As New Analisis
        a.ci = Val(txtCI.Text)
        a.cn = cn
        Dim lista As List(Of Integer)
        lista = a.idanalisis()
        Select Case a.verifyci()
            Case 0 'Encontré
                If a.estadoborradop = 1 Then
                    If MsgBox("El paciente se dió de baja, ¿Desaea darle de alta?", MsgBoxStyle.YesNo, "S.I.BI.M - GSA") = MsgBoxResult.Yes Then
                        Select Case a.estadop()
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
                MsgBox("El paciente no existe, o no tiene análisis clínicos existentes,asegurese de que ingreso correctamente la CI.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                cboID.Items.Clear()
                txtCI.Clear()
                txtResultado.Clear()
                txtTipo.Clear()
            Case Else : MsgBox("Hubo errores al encontrar al paciente. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
        End Select
        a = Nothing
    End Sub

    Private Sub cmdModificar_Click(sender As Object, e As EventArgs) Handles cmdModificar.Click
        Dim a As New Analisis
        a.id = cboID.SelectedItem()
        a.fecha = dtpFecha.Text
        a.resultado = txtResultado.Text
        a.tipo = txtTipo.Text
        a.cn = cn
        Select Case a.Guardar(0)
            Case 0
                MsgBox("Análisis clínico modificado con éxito.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
            Case 1 : MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
            Case Else : MsgBox("Hubo errores al realizar la modificación. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
        End Select
        a = Nothing
    End Sub

    Private Sub cmdCancelar_Click_1(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        cboID.Items.Clear()
        cboID.ResetText()
        txtCI.Clear()
        txtTipo.Clear()
        dtpFecha.ResetText()
        txtResultado.Clear()
        cmdEliminar.Enabled = False
        cmdModificar.Enabled = False
        gbBuscar.Enabled = True
        gbDatos.Visible = False
    End Sub

    Private Sub cmdEliminar_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        Dim a As New Analisis
        a.id = Val(cboID.SelectedItem)
        a.ci = Val(txtCI.Text)
        a.cn = cn
        Select Case a.Eliminar()
            Case 0
                cboID.Items.Clear()
                cboID.ResetText()
                txtTipo.Clear()
                dtpFecha.ResetText()
                txtResultado.Clear()
                Dim lista As List(Of Integer)
                lista = a.idanalisis()
                For Each ida In lista
                    cboID.Items.Add(ida)
                Next
                MsgBox("Analísis clínico eliminado éxitosamente.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
            Case 1 : MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
            Case Else : MsgBox("Hubo errores al eliminar el análisis clínico. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
        End Select
        
        a = Nothing
    End Sub

    Private Sub frmBMAnalisisClinico_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Me.Close()
    End Sub

    Private Sub frmBMAnalisisClinico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFecha.Format = DateTimePickerFormat.Custom
        dtpFecha.CustomFormat = "yyyy/MM/dd HH:mm:ss"
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