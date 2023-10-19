Public Class frmDiagnostico
    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Dim d As New Diagnosticos
        d.ci = Val(txtCI.Text)
        d.cn = cn
        Select Case d.verifyci2()
            Case 0 'Encontré
                If d.estadoborradop = 1 Then
                    If MsgBox("El paciente se dió de baja, ¿Desaea darle de alta?", MsgBoxStyle.YesNo, "S.I.BI.M - GSA") = MsgBoxResult.Yes Then
                        Select Case d.estadop()
                            Case 0
                                MsgBox("El alta del paciente se realizó éxitosamente.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
                            Case 1
                                MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                            Case Else
                                MsgBox("Hubo errores al realizar el alta. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                        End Select
                    End If
                Else
                    Select Case d.comprobarFecha()
                        Case 0
                            If MsgBox("¿Desea ingresar los datos de un diagnóstico perteneciente a un paciente con C.I " & (txtCI.Text) & "?", MsgBoxStyle.YesNo, "S.I.BI.M - GSA") = MsgBoxResult.Yes Then
                                gbBuscar.Enabled = False
                                gbDatos.Enabled = True
                                gbDatos.Visible = True
                            End If
                        Case Else
                            MsgBox("El paciente no tiene consultas con un médico, para ingresar un diagnóstico es necesario previamente que se atienda con un médico.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                    End Select
                End If
            Case 3 'No encontré
                MsgBox("El paciente no existe, asegurese de que ingreso correctamente la CI.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
            Case 1 : MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
            Case Else : MsgBox("Hubo errores al buscar el paciente. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
        End Select
        d = Nothing
    End Sub

    Private Sub cmdIngresar_Click(sender As Object, e As EventArgs) Handles cmdIngresar.Click
        Dim d As New Diagnosticos
        d.ci = txtCI.Text
        d.tipo = cboTipo.SelectedItem()
        d.fecha = dtpFecha.Value
        d.descripcion = txtDescripcion.Text
        d.cn = cn
        Select Case d.Guardar(1)
            Case 0
                MsgBox("Diagnóstigo ingresado éxitosamente.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
                Dim myValue As String = InputBox("En el caso de que el diagnóstico realizado sea correcto, ingrese la enfermadad actual que detecto en el paciente.", "ESTABLECER ENFERMEDAD ACTUAL - S.I.BI.M - GSA", "Ingrese enfermedad")
                If myValue.Equals("") Then
                Else
                    d.enfactual = myValue
                    Select Case d.setenfactual
                        Case 0
                            MsgBox("Enfermedad actual actualizada éxitosamente.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
                        Case 1 : MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                        Case Else : MsgBox("Hubo errores al actualizar la enfermedad actual. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                    End Select
                End If
            Case 1 : MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
            Case Else : MsgBox("Hubo errores al ingresar el diagnóstico. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
        End Select
        d = Nothing
    End Sub
    Private Sub frmDiagnostico_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Me.Close()
    End Sub

    Private Sub frmDiagnostico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        cboTipo.ResetText()
        txtCI.Clear()
        dtpFecha.ResetText()
        txtDescripcion.Clear()
        gbBuscar.Enabled = True
        gbDatos.Visible = False
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