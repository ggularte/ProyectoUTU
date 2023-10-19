Public Class frmIngresoPacientes

    Private Sub txtBCI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBCI.KeyPress
        permitirNumerosSE(e)
    End Sub

    Private Sub txtPnombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPnombre.KeyPress
        permitirLetrasCE(e)
    End Sub

    Private Sub txtPapellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPapellido.KeyPress
        permitirLetrasCE(e)
    End Sub

    Private Sub txtSnombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSnombre.KeyPress
       permitirLetrasCE(e)
    End Sub

    Private Sub txtSapellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSapellido.KeyPress
        permitirLetrasCE(e)
    End Sub

    Private Sub txtEdad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEdad.KeyPress
        permitirNumerosSE(e)
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        Dim p As New Pacientes
        p.ci = Val(txtBCI.Text)
        p.cn = cn
        Select Case p.verifyci()
            Case 0
                Select Case p.Buscar()
                    Case 0 'Encontré
                        If p.estadoborradop = 1 Then
                            If MsgBox("El paciente se dió de baja, ¿Desaea darle de alta?", MsgBoxStyle.YesNo, "S.I.BI.M - GSA") = MsgBoxResult.Yes Then
                                Select Case p.estadop()
                                    Case 0
                                        MsgBox("El alta del paciente se realizó éxitosamente", MessageBoxIcon.Information, "S.I.BI.M - GSA")
                                    Case 1
                                        MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                                    Case Else
                                        MsgBox("Hubo errores al realizar el alta. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                                End Select
                            End If
                        Else
                            txtPnombre.Text = p.pnombre
                            txtSnombre.Text = p.snombre
                            txtPapellido.Text = p.papellido
                            txtSapellido.Text = p.sapellido
                            dtpFechaNac.Text = p.fechanac
                            txtEdad.Text = p.edad
                            cbEcivil.Text = p.estadocivil
                            cbSexo.Text = p.sexo
                            txtCalle.Text = p.calle
                            txtCorreo.Text = p.correo
                            txtNpuerta.Text = p.nropuerta
                            txtEsquina.Text = p.esquina
                            Dim lista As List(Of String)
                            lista = p.ecivil()
                            For Each EstadoCivil In lista
                                cbEcivil.Items.Add(EstadoCivil)
                            Next
                            Dim lista1 As List(Of Char)
                            lista1 = p.csexo()
                            For Each Sexo In lista1
                                cbSexo.Items.Add(Sexo)
                            Next
                            Dim lista2 As List(Of String)
                            lista2 = p.patelefono()
                            For Each Telefono In lista2
                                cbTelefono.Items.Add(Telefono)
                            Next
                            gbTelefono.Visible = True
                            gbBuscar.Enabled = False
                            gbDatos.Visible = True
                            cmdIngresar.Enabled = False
                            cmdEliminar.Enabled = True
                            cmdModificar.Enabled = True
                        End If
                    Case 3 'No encontré
                        MsgBox("Esta persona perteneciente al personal médico ya tiene los datos necesarios ingresados, para ingresarlo como paciente solamente hace falta ingresar los siguientes datos.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
                        frmUsuario.Show()
                        frmUsuario.cmdIngresar.Visible = True
                        frmPaciente.Enabled = False
                        frmPaciente.Show()
                        frmPaciente.cmdIngresar2.Visible = True
                    Case 1 : MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                    Case Else : MsgBox("Hubo errores al buscar el paciente. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                End Select
            Case 3
                Select Case p.Buscar()
                    Case 0 'Encontré
                        If p.estadoborradop = 1 Then
                            If MsgBox("El paciente se dió de baja, ¿Desaea darle de alta?", MsgBoxStyle.YesNo, "S.I.BI.M - GSA") = MsgBoxResult.Yes Then
                                Select Case p.estadop()
                                    Case 0
                                        MsgBox("El alta del paciente se realizó éxitosamente", MessageBoxIcon.Information, "S.I.BI.M - GSA")
                                    Case 1
                                        MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                                    Case Else
                                        MsgBox("Hubo errores al realizar el alta. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                                End Select
                            End If
                        Else
                            txtPnombre.Text = p.pnombre
                            txtSnombre.Text = p.snombre
                            txtPapellido.Text = p.papellido
                            txtSapellido.Text = p.sapellido
                            dtpFechaNac.Text = p.fechanac
                            txtEdad.Text = p.edad
                            cbEcivil.Text = p.estadocivil
                            cbSexo.Text = p.sexo
                            txtCalle.Text = p.calle
                            txtCorreo.Text = p.correo
                            txtNpuerta.Text = p.nropuerta
                            txtEsquina.Text = p.esquina
                            Dim lista As List(Of String)
                            lista = p.ecivil()
                            For Each EstadoCivil In lista
                                cbEcivil.Items.Add(EstadoCivil)
                            Next
                            Dim lista1 As List(Of Char)
                            lista1 = p.csexo()
                            For Each Sexo In lista1
                                cbSexo.Items.Add(Sexo)
                            Next
                            Dim lista2 As List(Of String)
                            lista2 = p.patelefono()
                            For Each Telefono In lista2
                                cbTelefono.Items.Add(Telefono)
                            Next
                            gbTelefono.Visible = True
                            gbBuscar.Enabled = False
                            gbDatos.Visible = True
                            cmdIngresar.Enabled = False
                            cmdEliminar.Enabled = True
                            cmdModificar.Enabled = True
                        End If
                    Case 3
                        If MsgBox("El paciente no se encontró, ¿Desea ingresarlo?", MsgBoxStyle.YesNo, "S.I.BI.M - GSA") = MsgBoxResult.Yes Then
                            frmUsuario.Show()
                            frmUsuario.cmdIngresar.Visible = True
                            Me.Enabled = False
                            Dim lista As List(Of String)
                            lista = p.ecivil()
                            For Each EstadoCivil In lista
                                cbEcivil.Items.Add(EstadoCivil)
                            Next
                            Dim lista1 As List(Of Char)
                            lista1 = p.csexo()
                            For Each Sexo In lista1
                                cbSexo.Items.Add(Sexo)
                            Next
                            gbTelefono.Visible = False
                            gbBuscar.Enabled = False
                            gbDatos.Visible = True
                            cmdIngresar.Enabled = True
                            cmdEliminar.Enabled = False
                            cmdModificar.Enabled = False
                        End If
                End Select
            Case Else : MsgBox("Hubo errores al buscar el paciente. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
        End Select
        p = Nothing
    End Sub

    Private Sub cmdEliminar_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        Dim p As New Pacientes
        p.ci = Val(txtBCI.Text)
        p.cn = cn
        Select Case p.Eliminar()
            Case 0
                MsgBox("Paciente eliminado éxitosamente.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
                txtPnombre.Clear()
                txtSnombre.Clear()
                txtPapellido.Clear()
                txtSapellido.Clear()
                cbEcivil.ResetText()
                cbTelefono.ResetText()
                dtpFechaNac.ResetText()
                txtEdad.Clear()
                txtCalle.Clear()
                cbEcivil.Items.Clear()
                cbSexo.Items.Clear()
                cbTelefono.Items.Clear()
                txtCorreo.Clear()
                txtNpuerta.Clear()
                txtEsquina.Clear()
                gbTelefono.Visible = False
                gbBuscar.Enabled = True
                gbDatos.Visible = False
            Case 1 : MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
            Case Else : MsgBox("Hubo errores al eliminar el paciente. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
        End Select
        p = Nothing
    End Sub

    Private Sub cmdIngresar_Click(sender As Object, e As EventArgs) Handles cmdIngresar.Click
        Dim p As New Pacientes
        p.ci = Val(txtBCI.Text)
        p.pnombre = txtPnombre.Text
        p.snombre = txtSnombre.Text
        p.papellido = txtPapellido.Text
        p.sapellido = txtSapellido.Text
        p.fechanac = dtpFechaNac.Text
        p.estadocivil = cbEcivil.Text
        p.sexo = cbSexo.Text
        p.calle = txtCalle.Text
        p.correo = txtCorreo.Text
        p.nropuerta = txtNpuerta.Text
        p.esquina = txtEsquina.Text
        p.cn = cn
        Select Case p.Guardar(1)
            Case 0
                MsgBox("Paciente ingresado éxitosamente.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
                frmTelefono.Show()
                frmTelefono.cmdAgregar.Visible = True
                frmTelefono.cmdQuitar.Visible = True
            Case 1 : MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
            Case Else : MsgBox("Hubo errores al ingresar el paciente. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
        End Select
        p = Nothing
    End Sub
    Private Sub cmdModificar_Click(sender As Object, e As EventArgs) Handles cmdModificar.Click
        Dim p As New Pacientes
        p.ci = Val(txtBCI.Text)
        p.pnombre = txtPnombre.Text
        p.snombre = txtSnombre.Text
        p.papellido = txtPapellido.Text
        p.sapellido = txtSapellido.Text
        p.fechanac = dtpFechaNac.Text
        p.estadocivil = cbEcivil.Text
        p.sexo = cbSexo.Text
        p.calle = txtCalle.Text
        p.telefono = txtCorreo.Text
        p.nropuerta = txtNpuerta.Text
        p.esquina = txtEsquina.Text
        p.cn = cn
        Select Case p.Guardar(0)
            Case 0
                MsgBox("El paciente se modificó éxitosamente.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
            Case 1 : MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
            Case Else : MsgBox("Hubo errores al modificar el paciente. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
        End Select
        p = Nothing
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        txtPnombre.Clear()
        txtSnombre.Clear()
        txtPapellido.Clear()
        txtSapellido.Clear()
        cbEcivil.ResetText()
        cbTelefono.ResetText()
        dtpFechaNac.ResetText()
        txtEdad.Clear()
        txtCalle.Clear()
        cbEcivil.Items.Clear()
        cbSexo.Items.Clear()
        cbTelefono.Items.Clear()
        txtCorreo.Clear()
        txtNpuerta.Clear()
        txtEsquina.Clear()
        gbTelefono.Visible = False
        gbBuscar.Enabled = True
        gbDatos.Visible = False
    End Sub

    Private Sub dtpFechaNac_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaNac.ValueChanged
        Dim Anios As Integer
        Dim Meses As Integer
        Dim Dias As Integer
        Dim FechaCalculo As Date
        FechaCalculo = dtpFechaNac.Value

        If dtpFechaNac.Value > Now Then
            MsgBox("Error, no se permite ingresar una fecha de nacimiento mayor a la fecha actual.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
        End If

        Do While DateAdd("YYYY", 1, FechaCalculo) <= Now
            Anios = Anios + 1
            FechaCalculo = DateAdd("YYYY", 1, FechaCalculo)
        Loop

        Do While DateAdd("m", 1, FechaCalculo) <= Now
            Meses = Meses + 1
            FechaCalculo = DateAdd("m", 1, FechaCalculo)
        Loop

        Do While DateAdd("d", 1, FechaCalculo) <= Now
            Dias = Dias + 1
            FechaCalculo = DateAdd("d", 1, FechaCalculo)
        Loop

        Dim Edad As String = Anios & " años, " & Meses & " meses y " & Dias & " días"
        txtEdad.Text = Edad
    End Sub

    Private Sub frmIngresoPacientes_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Me.Close()
    End Sub

    Private Sub frmIngresoPacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFechaNac.Format = DateTimePickerFormat.Custom
        dtpFechaNac.CustomFormat = "yyyy/MM/dd HH:mm:ss"
    End Sub

    Private Sub cmdAddMed_Click(sender As Object, e As EventArgs)
        Dim m As New PersonalMedico
        m.ci = Val(txtBCI.Text)
        m.cn = cn
        Select Case m.Buscar()
            Case 0 'Encontré
                If m.estadoborradom = 1 Then
                    If MsgBox("El médico o auxiliar se dió de baja, ¿Desaea darle de alta?", MsgBoxStyle.YesNo, "S.I.BI.M - GSA") = MsgBoxResult.Yes Then
                        Select Case m.estado()
                            Case 0
                                MsgBox("El médico o auxiliar se dio de alta éxitosamente.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
                            Case 1
                                MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                            Case Else
                                MsgBox("Hubo errores al efectuar el alta del médico o auxiliar. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                        End Select
                    End If
                End If
                MsgBox("Esta persona ya pertence al personal médico.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
            Case 3 'No encontré
                frmMedico.Show()
            Case 1 : MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
            Case Else : MsgBox("Hubo errores al buscar el personal médico. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
        End Select
        m = Nothing
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Dim p As New Pacientes
        p.ci = Val(txtBCI.Text)
        p.telefono = cbTelefono.Text
        p.cn = cn
        Select Case p.GuardarT(1)
            Case 0
                MsgBox("Teléfono ingresado éxitosamente.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
                cbTelefono.Items.Clear()
                Dim lista2 As List(Of String)
                lista2 = p.patelefono()
                For Each Telefono In lista2
                    cbTelefono.Items.Add(Telefono)
                Next
            Case 1 : MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
            Case Else : MsgBox("Hubo errores al ingresar el teléfono. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
        End Select
        p = Nothing
    End Sub

    Private Sub cmdQuitar_Click(sender As Object, e As EventArgs) Handles cmdQuitar.Click
        Dim p As New Pacientes
        p.ci = Val(txtBCI.Text)
        p.telefono = cbTelefono.Text
        p.cn = cn
        Select Case p.EliminarT(1)
            Case 0
                MsgBox("Teléfono eliminado éxitosamente.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
                cbTelefono.Items.Clear()
                Dim lista2 As List(Of String)
                lista2 = p.patelefono()
                For Each Telefono In lista2
                    cbTelefono.Items.Add(Telefono)
                Next
            Case 1 : MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
            Case Else : MsgBox("Hubo errores al eliminar el teléfono. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
        End Select
        p = Nothing
    End Sub

    Private Sub cbEcivil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbEcivil.KeyPress
        e.Handled = True
        MsgBox("Solo puede seleccionar los estados civilies existentes.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
    End Sub

    Private Sub cbSexo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbSexo.KeyPress
        e.Handled = True
        MsgBox("Solo puede seleccionar los sexos existentes.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
    End Sub

    Private Sub cbTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbTelefono.KeyPress
        permitirNumerosSE(e)
    End Sub

End Class