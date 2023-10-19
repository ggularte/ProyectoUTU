Public Class frmAnalisisClinico
    Private Sub cmdIngresar_Click(sender As Object, e As EventArgs) Handles cmdIngresar.Click
        Dim a As New Analisis
        a.ci = Val(txtBCI.Text)
        a.resultado = txtResultado.Text
        a.tipo = txtTipo.Text
        a.fecha = dtpFecha.Value
        a.cn = cn
        Select Case a.Guardar(1)
            Case 0
                MsgBox("Análisis ingresado con éxito.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
            Case 1 : MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
            Case Else : MsgBox("Hubo errores al ingresar el análisis. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
        End Select
        a = Nothing
    End Sub

    Private Sub frmAnalisisClinico_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Me.Close()
    End Sub

    Private Sub frmAnalisisClinico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFecha.Format = DateTimePickerFormat.Custom
        dtpFecha.CustomFormat = "yyyy/MM/dd HH:mm:ss"
    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Dim a As New Analisis
        a.ci = Val(txtBCI.Text)
        a.cn = cn
        Select Case a.verifyci2()
            Case 0 'Encontré
                If a.estadoborradop = 1 Then
                    If MsgBox("El paciente se dió de baja, ¿Desaea darle de alta?", MsgBoxStyle.YesNo, "S.I.BI.M - GSA") = MsgBoxResult.Yes Then
                        Select Case a.estadop()
                            Case 0
                                MsgBox("Paciente dado de alta éxitosamente.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
                            Case 1
                                MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                            Case Else
                                MsgBox("Hubo errores al realizar el alta del paciente. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                        End Select
                    End If
                Else
                    Select Case a.comprobarFecha()
                        Case 0
                            If MsgBox("¿Desea ingresar los datos de un análisis clínico perteneciente a un paciente con C.I " & (txtBCI.Text) & "?", MsgBoxStyle.YesNo, "S.I.BI.M - GSA") = MsgBoxResult.Yes Then
                                gbBuscar.Enabled = False
                                gbDatos.Enabled = True
                                gbDatos.Visible = True
                            End If
                        Case Else
                            MsgBox("El paciente no tiene consultas con un médico, para ingresar un análisis clínico es necesario previamente que se atienda con un médico.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                    End Select
                End If
            Case 3 'No encontré
                MsgBox("El paciente no existe, asegurese de que ingreso correctamente la CI.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                txtTipo.Clear()
                txtResultado.Clear()
                txtTipo.Clear()
            Case Else
                MsgBox("Hubo errores al buscar el paciente. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
        End Select
        a = Nothing
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        txtBCI.Clear()
        dtpFecha.ResetText()
        txtResultado.Clear()
        txtTipo.Clear()
        gbBuscar.Enabled = True
        gbDatos.Visible = False
    End Sub

    Private Sub txtBCI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBCI.KeyPress
        permitirNumerosSE(e)
    End Sub

    Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha.ValueChanged
        If dtpFecha.Value > Now Then
            MsgBox("Error, no se permite ingresar una fecha mayor a la fecha actual.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
            dtpFecha.ResetText()
        End If
    End Sub

End Class