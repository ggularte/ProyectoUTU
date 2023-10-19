Module Rutinas
    Public cn As New ADODB.Connection
    Public cipub As String
    Public Sub doyPermisos(ByVal usuario As String)
        Dim sql As String
        Dim rs As New ADODB.Recordset
        frmPrincipal.menuInformacion.Enabled = False
        frmPrincipal.menuConsInf.Enabled = False
        frmPrincipal.menuFormularios.Enabled = False
        frmPrincipal.menuIngFormulario.Enabled = False
        frmPrincipal.menuConsFormularios.Enabled = False
        frmPrincipal.menuPersonalMedico.Enabled = False
        frmPrincipal.menuEntrevistaInicial.Enabled = False
        frmPrincipal.menuDiagnostico.Enabled = False
        frmPrincipal.menuIngTratamiento.Enabled = False
        frmPrincipal.menuIngAnalisis.Enabled = False
        frmPrincipal.menuConsAnalisis.Enabled = False
        frmPrincipal.menuConsDiagnostico.Enabled = False
        frmPrincipal.menuAdmDiagnostico.Enabled = False
        frmPrincipal.menuAdmTratamiento.Enabled = False
        frmPrincipal.menuAdmAnalisis.Enabled = False
        frmPrincipal.menuAdmEntrevista.Enabled = False
        If cn.State = 0 Then
            MsgBox("Debe abrir su sesión.")
        Else
            sql = "select Rol from Usuario_Rol where Usuario='" & usuario & "';"
            Try
                rs.Open(sql, cn)
            Catch ex As Exception
                MsgBox("Hubo errores al obtener rol del usuario.")
                Exit Sub
            End Try
            If rs.RecordCount = 0 Then
                MsgBox("El usuario no tiene rol asignado, comuníquese con el adm. del sistema.")
            Else
                Select Case rs(0).Value
                    Case 1 'Medico
                        'Formularios
                        frmPrincipal.menuFormularios.Enabled = True
                        'Ingreso datos
                        frmPrincipal.menuIngFormulario.Enabled = True
                        frmPrincipal.menuIngTratamiento.Enabled = True
                        frmPrincipal.menuIngAnalisis.Enabled = True
                        frmPrincipal.menuEntrevistaInicial.Enabled = True
                        frmPrincipal.menuDiagnostico.Enabled = True
                        'Consultar info
                        frmPrincipal.menuConsInf.Enabled = True
                        frmPrincipal.menuConsFormularios.Enabled = True
                        frmPrincipal.menuAdmDiagnostico.Enabled = True
                        frmPrincipal.menuAdmTratamiento.Enabled = True
                        frmPrincipal.menuAdmAnalisis.Enabled = True
                        frmPrincipal.menuAdmEntrevista.Enabled = True
                    Case 2 'Auxiliar
                        'Formularios
                        frmPrincipal.menuFormularios.Enabled = True
                        'Ingreso datos
                        frmPrincipal.menuIngFormulario.Enabled = True
                        frmPrincipal.menuIngTratamiento.Enabled = True
                        frmPrincipal.menuIngAnalisis.Enabled = True
                        frmPrincipal.menuEntrevistaInicial.Enabled = True
                        frmPrincipal.menuDiagnostico.Enabled = True
                    Case 3 'Paciente
                        'Consultar diagnostico
                        frmPrincipal.menuConsDiagnostico.Enabled = True
                        'Consultar analisis
                        frmPrincipal.menuConsAnalisis.Enabled = True
                    Case 4 'Administrador
                        frmPrincipal.menuInformacion.Enabled = True
                        frmPrincipal.menuPersonalMedico.Enabled = True
                End Select
            End If
            rs.Close()
        End If
        rs = Nothing
    End Sub
    'Permitir números con espacios
    Public Sub permitirLetrasCE(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("No se permite ingresar números o símbolos.", "ADVERTENCIA")
        End If
    End Sub
    'Permitir números sin espacios
    Public Sub permitirNumerosSE(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("No se permite ingresar espacios.", "ADVERTENCIA")
        Else
            e.Handled = True
            MessageBox.Show("No se permite ingresar letras.", "ADVERTENCIA")
        End If
    End Sub
End Module
