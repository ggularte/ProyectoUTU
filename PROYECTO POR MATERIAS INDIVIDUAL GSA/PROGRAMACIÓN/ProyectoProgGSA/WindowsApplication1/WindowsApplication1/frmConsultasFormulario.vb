Public Class frmConsultasFormulario
    Private Sub txtCI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCI.KeyPress
        permitirNumerosSE(e)
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdCancelar.Click
        txtCI.Clear()
        cboID.Items.Clear()
        cboID.ResetText()
        cboTipo.Items.Clear()
        cboTipo.ResetText()
        dgv_Form.Columns.Clear()
        gbFormulario.Enabled = False
        gbFormulario.Visible = False
        gbFiltros.Visible = False
        gbFiltros.Enabled = False
        gbBuscar.Enabled = True
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        Dim f As New Formularios
        f.tipo = cboTipo.SelectedItem()
        f.cn = cn
        f.ci = txtCI.Text
        cboTipo.Items.Clear()
        Dim lista As List(Of String)
        lista = f.tipoform2()
        Select Case f.verifyci()
            Case 0 'Encontré
                If f.estadoborradop = 1 Then
                    If MsgBox("El paciente se dió de baja, ¿Desaea darle de alta?", MsgBoxStyle.YesNo, "S.I.BI.M - GSA") = MsgBoxResult.Yes Then
                        Select Case f.estadop()
                            Case 0
                                MsgBox("El alta del paciente se realizó éxitosamente.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
                            Case 1
                                MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                            Case Else
                                MsgBox("Hubo errores al realizar el alta. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                        End Select
                    End If
                Else
                    For Each Diagnostico In lista
                        cboTipo.Items.Add(Diagnostico)
                    Next
                    gbBuscar.Enabled = False
                    gbFiltros.Enabled = True
                    gbFiltros.Visible = True
                    gbFormulario.Enabled = True
                    gbFormulario.Visible = True
                End If
            Case 3 'No encontré
                MsgBox("El paciente no existe, o no tiene formularios respondidos, asegurese de que ingreso correctamente la CI.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                cboID.Items.Clear()
                txtCI.Clear()
        End Select
        f = Nothing
    End Sub

    Private Sub cboTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipo.SelectedIndexChanged
        Dim f As New Formularios
        f.tipo = cboTipo.SelectedItem()
        f.cn = cn
        Dim lista As List(Of Integer)
        lista = f.idform()
        cboID.Items.Clear()
        cboID.ResetText()
        For Each id In lista
            cboID.Items.Add(id)
        Next
    End Sub

    Private Sub cboID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboID.SelectedIndexChanged
        Dim f As New Formularios
        f.idf = cboID.SelectedItem()
        f.cn = cn
        dgv_Form.DataSource = f.tablaform()
        f = Nothing
    End Sub

    Private Sub frmConsultasFormulario_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Me.Close()
    End Sub
End Class