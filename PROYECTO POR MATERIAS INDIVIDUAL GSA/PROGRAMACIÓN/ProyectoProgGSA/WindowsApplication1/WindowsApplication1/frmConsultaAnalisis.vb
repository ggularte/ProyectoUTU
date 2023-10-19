Public Class frmConsultaAnalisis

    Private Sub txtCI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCI.KeyPress
       permitirNumerosSE(e)
    End Sub

    Private Sub frmConsultaAnalisis_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Me.Close()
    End Sub

    Private Sub frmConsultaAnalisis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFecha.Format = DateTimePickerFormat.Custom
        dtpFecha.CustomFormat = "yyyy/MM/dd HH:mm:ss"
    End Sub

    Private Sub cboID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboID.SelectedIndexChanged
        Dim a As New Analisis
        a.ci = Val(txtCI.Text)
        a.tipo = txtTipo.Text
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
            Case 3 'No encontré
                txtCI.Clear()
                txtResultado.Clear()
                txtTipo.Clear()
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
                    MsgBox("No puede consultar la siguiente información debido a que usted está dado de baja, para que se realice el alta de vuelta debe de contactar con la institución médica.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                Else
                    Select Case a.getci()
                        Case 0
                            If a.ci = Val(txtCI.Text) Then
                                For Each ida In lista
                                    cboID.Items.Add(ida)
                                Next
                                gbBuscar.Enabled = False
                                gbDatos.Enabled = True
                                gbDatos.Visible = True
                            Else
                                MsgBox("Solo puedes buscar registros de tu propiedad, por favor ingresa tu CI.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                            End If
                        Case Else : MsgBox("Solo puedes buscar registros de tu propiedad, por favor ingresa tu CI.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                    End Select
                End If
            Case 3 'No encontré
                MsgBox("El paciente no existe, o no tiene analisis clínicos existentes,asegurese de que ingreso correctamente la CI.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                cboID.Items.Clear()
                txtCI.Clear()
                txtResultado.Clear()
                txtTipo.Clear()
            Case Else
                MsgBox("Hubo error al efectuar la busqueda. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
        End Select
        a = Nothing
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        cboID.Items.Clear()
        cboID.ResetText()
        txtCI.Clear()
        txtTipo.Clear()
        dtpFecha.ResetText()
        txtResultado.Clear()
        gbBuscar.Enabled = True
        gbDatos.Visible = False
    End Sub

    Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha.ValueChanged
        If dtpFecha.Value > Now Then
            MsgBox("Error, no se permite ingresar una fecha mayor a la fecha actual.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
            dtpFecha.ResetText()
        End If
    End Sub
End Class