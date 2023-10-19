Public Class frmConsultaDiagnostico

    Private Sub txtCI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCI.KeyPress
        permitirNumerosSE(e)
    End Sub

    Private Sub cmdBuscarCI_Click(sender As Object, e As EventArgs) Handles cmdBuscarCI.Click
        Dim d As New Diagnosticos
        d.ci = Val(txtCI.Text)
        d.cn = cn
        Dim lista As List(Of Integer)
        lista = d.iddiag()
        Select Case d.verifyci()
            Case 0 'Encontré
                If d.estadoborradop = 1 Then
                    MsgBox("No puede consultar la siguiente información debido a que usted está dado de baja, para que se realice el alta de vuelta debe de contactar con la institución médica.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                Else
                    Select Case d.getci()
                        Case 0
                            If d.ci = Val(txtCI.Text) Then
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
                MsgBox("El paciente no existe, o no tiene un diagnostico existente, asegurese de que ingreso correctamente la CI.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                cboID.Items.Clear()
                txtCI.Clear()
                txtDescripcion.Clear()
                txtNombreD.Clear()
        End Select
        d = Nothing
    End Sub
    Private Sub cboID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboID.SelectedIndexChanged
        Dim d As New Diagnosticos
        d.ci = Val(txtCI.Text)
        d.id = Val(cboID.Text)
        d.cn = cn
        Select Case d.Buscar()
            Case 0 'Encontré
                txtCI.Text = d.ci
                txtNombreD.Text = d.nombreD
                dtpFecha.Value = d.fecha
                txtDescripcion.Text = d.descripcion
            Case 3 'No encontré
                txtCI.Clear()
                txtNombreD.Clear()
                txtDescripcion.Clear()
            Case Else : MsgBox("Hubo errores al efectuar operación. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
        End Select
        d = Nothing
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        cboID.Items.Clear()
        cboID.ResetText()
        txtCI.Clear()
        dtpFecha.ResetText()
        txtDescripcion.Clear()
        gbBuscar.Enabled = True
        gbDatos.Visible = False
    End Sub

    Private Sub frmConsultaDiagnostico_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Me.Close()
    End Sub

    Private Sub frmConsultaDiagnostico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFecha.Format = DateTimePickerFormat.Custom
        dtpFecha.CustomFormat = "yyyy/MM/dd HH:mm:ss"
    End Sub

    Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha.ValueChanged
        If dtpFecha.Value > Now Then
            MsgBox("Error, no se permite ingresar una fecha mayor a la fecha actual.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
            dtpFecha.ResetText()
        End If
    End Sub

End Class