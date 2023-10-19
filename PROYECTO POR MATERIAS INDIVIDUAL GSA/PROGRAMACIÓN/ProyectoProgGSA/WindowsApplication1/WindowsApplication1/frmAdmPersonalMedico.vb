Public Class frmAdmPersonalMedico

    Private Sub txtEdad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEdad.KeyPress
        permitirNumerosSE(e)
    End Sub

    Private Sub txtBCI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCI.KeyPress
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

    Private Sub rbMedico_CheckedChanged(sender As Object, e As EventArgs) Handles rbMedico.CheckedChanged
        lblEspecialidad.Visible = True
        txtEspecialidad.Visible = True
    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Dim m As New PersonalMedico
        m.ci = Val(txtCI.Text)
        m.telefono = cbTelefono.Text
        m.cn = cn
        Select Case m.verifyci()
            Case 0
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
                        Else
                            txtPnombre.Text = m.pnombre
                            txtSnombre.Text = m.snombre
                            txtPapellido.Text = m.papellido
                            txtSapellido.Text = m.sapellido
                            dtpFechaNac.Text = m.fechanac
                            txtEdad.Text = m.edad
                            txtCalle.Text = m.calle
                            txtTelefono.Text = m.telefono
                            txtNpuerta.Text = m.nropuerta
                            txtEsquina.Text = m.esquina
                            txtEspecialidad.Text = m.especialidad
                            gbBuscar.Enabled = False
                            gbDatos.Visible = True
                            cmdIngresar.Enabled = False
                            cmdModificar.Enabled = True
                            cmdEliminar.Enabled = True
                            Dim lista2 As List(Of String)
                            lista2 = m.pmtelefono()
                            For Each Telefono In lista2
                                cbTelefono.Items.Add(Telefono)
                            Next

                            gbTelefono.Visible = True
                            If m.especialidad.Equals("-") Then
                                rbAuxiliarMedico.Checked = True
                                rbMedico.Checked = False
                                txtEspecialidad.Visible = False
                                txtEspecialidad.Clear()
                            Else
                                rbAuxiliarMedico.Checked = False
                                rbMedico.Checked = True
                                txtEspecialidad.Visible = True
                            End If
                        End If
                    Case 3 'No encontré
                        MsgBox("Este paciente ya tiene los datos necesarios ingresados, para ingresar como personal médico solamente hace falta ingresar los siguientes datos.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
                        frmUsuario.Show()
                        frmUsuario.cmdIngresar.Visible = True
                        frmMedico.Enabled = False
                        frmMedico.Show()
                    Case 1 : MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                    Case Else : MsgBox("Hubo errores al buscar el médico o paciente. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                End Select
            Case 3 'Encontré
                Select Case m.Buscar
                    Case 0 'Encontré
                        If m.estadoborradom = 1 Then
                            If MsgBox("El médico o auxiliar se dió de baja, ¿Desea darle de alta?", MsgBoxStyle.YesNo, "S.I.BI.M - GSA") = MsgBoxResult.Yes Then
                                Select Case m.estado()
                                    Case 0
                                        MsgBox("El médico o auxiliar se dio de alta éxitosamente.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
                                    Case 1
                                        MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                                    Case Else
                                        MsgBox("Hubo errores al efectuar el alta del médico o auxiliar. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                                End Select
                            End If
                        Else
                            txtPnombre.Text = m.pnombre
                            txtSnombre.Text = m.snombre
                            txtPapellido.Text = m.papellido
                            txtSapellido.Text = m.sapellido
                            dtpFechaNac.Text = m.fechanac
                            txtEdad.Text = m.edad
                            txtCalle.Text = m.calle
                            txtTelefono.Text = m.telefono
                            txtNpuerta.Text = m.nropuerta
                            txtEsquina.Text = m.esquina
                            txtEspecialidad.Text = m.especialidad
                            gbBuscar.Enabled = False
                            gbDatos.Visible = True
                            cmdIngresar.Enabled = False
                            cmdModificar.Enabled = True
                            cmdEliminar.Enabled = True
                            Dim lista2 As List(Of String)
                            lista2 = m.pmtelefono()
                            For Each Telefono In lista2
                                cbTelefono.Items.Add(Telefono)
                            Next
                            gbTelefono.Visible = True
                            If m.especialidad.Equals("-") Then
                                rbAuxiliarMedico.Checked = True
                                rbMedico.Checked = False
                                txtEspecialidad.Visible = False
                                txtEspecialidad.Clear()
                            Else
                                rbAuxiliarMedico.Checked = False
                                rbMedico.Checked = True
                                txtEspecialidad.Visible = True
                            End If
                        End If
                    Case 3
                        If MsgBox("El médico o auxiliar médico no se encontró, ¿Desaea ingresarlo?", MsgBoxStyle.YesNo, "S.I.BI.M - GSA") = MsgBoxResult.Yes Then
                            frmUsuario.Show()
                            frmUsuario.cmdIngresarM.Visible = True
                            frmUsuario.gbRadio.Visible = True
                            Me.Enabled = False
                            gbTelefono.Visible = False
                            gbBuscar.Enabled = False
                            gbDatos.Visible = True
                            cmdIngresar.Enabled = True
                            cmdEliminar.Enabled = False
                            cmdModificar.Enabled = False
                        End If
                End Select
            Case Else : MsgBox("Hubo errores al buscar el médico o paciente. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
        End Select
        m = Nothing
    End Sub

    Private Sub cmdIngresar_Click(sender As Object, e As EventArgs) Handles cmdIngresar.Click
        Dim m As New PersonalMedico
        m.ci = Val(txtCI.Text)
        m.pnombre = txtPnombre.Text
        m.snombre = txtSnombre.Text
        m.papellido = txtPapellido.Text
        m.sapellido = txtSapellido.Text
        m.fechanac = dtpFechaNac.Text
        m.calle = txtCalle.Text
        m.nropuerta = txtNpuerta.Text
        m.esquina = txtEsquina.Text
        m.correo = txtTelefono.Text
        m.especialidad = txtEspecialidad.Text
        m.cn = cn
        If rbAuxiliarMedico.Checked = False And rbMedico.Checked = False Then
            MsgBox("Debe seleccionar el tipo de personal. (Médico o Auxiliar)", MessageBoxIcon.Warning, "S.I.BI.M - GSA")
        Else
            If rbMedico.Checked = True Then
                Select Case m.Guardar1(1)
                    Case 0
                        MsgBox("Se ha ingresado éxitosamente al médico.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
                        frmTelefono.Show()
                        frmTelefono.cmdAgregar2.Visible = True
                        frmTelefono.cmdQuitar2.Visible = True
                    Case 1 : MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.")
                    Case Else : MsgBox("Hubo errores al ingresar el médico. En caso de persistir, consulte al adm. del sistema.")
                End Select
            ElseIf rbAuxiliarMedico.Checked = True Then
                Select Case m.Guardar2(1)
                    Case 0
                        MsgBox("Se ha ingresado éxitosamente al auxiliar médico.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
                    Case 1 : MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                    Case Else : MsgBox("Hubo errores al ingresar el auxiliar médico. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                End Select
            End If
        End If
        m = Nothing
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        txtPnombre.Clear()
        txtSnombre.Clear()
        txtPapellido.Clear()
        txtSapellido.Clear()
        dtpFechaNac.ResetText()
        txtEdad.Clear()
        txtCalle.Clear()
        txtTelefono.Clear()
        txtNpuerta.Clear()
        txtEsquina.Clear()
        cbTelefono.ResetText()
        cbTelefono.Items.Clear()
        txtEspecialidad.Clear()
        rbAuxiliarMedico.Checked = False
        rbMedico.Checked = False
        gbBuscar.Enabled = True
        gbDatos.Visible = False
    End Sub

    Private Sub cmdEliminar_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        Dim m As New PersonalMedico
        m.ci = Val(txtCI.Text)
        m.cn = cn
        Select Case m.Eliminar()
            Case 0
                MsgBox("Médico o auxiliar eliminado éxitosamente.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
                txtPnombre.Clear()
                txtSnombre.Clear()
                txtPapellido.Clear()
                txtSapellido.Clear()
                dtpFechaNac.ResetText()
                txtEdad.Clear()
                txtCalle.Clear()
                txtTelefono.Clear()
                txtNpuerta.Clear()
                txtEsquina.Clear()
                cbTelefono.ResetText()
                cbTelefono.Items.Clear()
                txtEspecialidad.Clear()
                rbAuxiliarMedico.Checked = False
                rbMedico.Checked = False
                gbBuscar.Enabled = True
                gbDatos.Visible = False
            Case 1 : MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
            Case Else : MsgBox("Hubo errores al eliminar el médico o auxiliar. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
        End Select
        m = Nothing
    End Sub

    Private Sub cmdModificar_Click(sender As Object, e As EventArgs) Handles cmdModificar.Click
        Dim m As New PersonalMedico
        m.ci = Val(txtCI.Text)
        m.pnombre = txtPnombre.Text
        m.snombre = txtSnombre.Text
        m.papellido = txtPapellido.Text
        m.sapellido = txtSapellido.Text
        m.fechanac = dtpFechaNac.Text
        m.calle = txtCalle.Text
        m.telefono = txtTelefono.Text
        m.nropuerta = txtNpuerta.Text
        m.esquina = txtEsquina.Text
        m.especialidad = txtEspecialidad.Text
        m.cn = cn
        If rbAuxiliarMedico.Checked = False And rbMedico.Checked = False Then
            MsgBox("Debe seleccionar el tipo de personal. (Médico o Auxiliar)", MessageBoxIcon.Warning, "S.I.BI.M - GSA")
        Else
            If rbMedico.Checked = True Then
                Select Case m.Guardar1(0)
                    Case 0
                        MsgBox("Médico modificado con éxito.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
                    Case 1 : MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                    Case Else : MsgBox("Hubo errores al efectuar la modificación del médico. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                End Select
            ElseIf rbAuxiliarMedico.Checked = True Then
                Select Case m.Guardar2(0)
                    Case 0
                        MsgBox("Auxiliar modificado con éxito.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
                    Case 1 : MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                    Case Else : MsgBox("Hubo errores al efectuar la modificación del auxiliar. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
                End Select
            End If
        End If
        m = Nothing
    End Sub

    Private Sub rbAuxiliarMedico_CheckedChanged(sender As Object, e As EventArgs) Handles rbAuxiliarMedico.CheckedChanged
        lblEspecialidad.Visible = False
        txtEspecialidad.Visible = False
        txtEspecialidad.Clear()
    End Sub

    Private Sub frmAdmPersonalMedico_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Me.Close()
    End Sub

    Private Sub frmAdmPersonalMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFechaNac.Format = DateTimePickerFormat.Custom
        dtpFechaNac.CustomFormat = "yyyy/MM/dd HH:mm:ss"
    End Sub

    Private Sub dtpFechaNac_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaNac.ValueChanged
        Dim Anios As Integer
        Dim Meses As Integer
        Dim Dias As Integer
        Dim FechaCalculo As Date
        FechaCalculo = dtpFechaNac.Value

        If dtpFechaNac.Value > Now Then
            MsgBox("Error, no se permite ingresar una fecha mayor a la fecha actual.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
            dtpFechaNac.ResetText()
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

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Dim p As New Pacientes
        p.ci = Val(txtCI.Text)
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
        p.ci = Val(txtCI.Text)
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

    Private Sub cbTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbTelefono.KeyPress
        permitirNumerosSE(e)
    End Sub
End Class