Public Class frmPrincipal

    Private Sub menuLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuLogin.Click
        If cn.State = 0 Then
            frmLogin.MdiParent = Me
            frmLogin.Show()
            frmLogin.WindowState = FormWindowState.Maximized
        Else
            If MsgBox("¿Desea cerrar sesión?", MsgBoxStyle.YesNo, "S.I.BI.M - GSA") = MsgBoxResult.Yes Then
                cn.Close()
                frmLogin.MdiParent = Me
                frmLogin.Show()
                frmLogin.WindowState = FormWindowState.Maximized
                menuInformacion.Enabled = False
                menuFormularios.Enabled = False
                menuPersonalMedico.Enabled = False
                menuEntrevistaInicial.Enabled = False
                menuDiagnostico.Enabled = False
                menuIngTratamiento.Enabled = False
                menuIngFormulario.Enabled = False
                menuConsInf.Enabled = False
                menuAdmEntrevista.Enabled = False
                menuIngAnalisis.Enabled = False
                menuConsAnalisis.Enabled = False
                menuConsDiagnostico.Enabled = False
                menuConsFormularios.Enabled = False
                menuAdmDiagnostico.Enabled = False
                menuAdmTratamiento.Enabled = False
                menuAdmAnalisis.Enabled = False
            End If
        End If
    End Sub


    Private Sub menuFormularios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuFormularios.Click
        frmABMFormulario.MdiParent = Me
        frmABMFormulario.Show()
        frmABMFormulario.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub menuPersonalMedico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuPersonalMedico.Click
        frmAdmPersonalMedico.MdiParent = Me
        frmAdmPersonalMedico.Show()
        frmAdmPersonalMedico.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub menuEntrevistaInicial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuEntrevistaInicial.Click
        frmEntrevistaInicial.MdiParent = Me
        frmEntrevistaInicial.Show()
        frmEntrevistaInicial.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub menuDiagnostico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuDiagnostico.Click
        frmDiagnostico.MdiParent = Me
        frmDiagnostico.Show()
        frmDiagnostico.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub menuIngTratamiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuIngTratamiento.Click
        frmTratamiento.MdiParent = Me
        frmTratamiento.Show()
        frmTratamiento.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub menuIngAnalisis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuIngAnalisis.Click
        frmAnalisisClinico.MdiParent = Me
        frmAnalisisClinico.Show()
        frmAnalisisClinico.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub menuIngDiagnostico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmDiagnostico.MdiParent = Me
        frmDiagnostico.Show()
        frmDiagnostico.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub menuConsAnalisis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuConsAnalisis.Click
        frmConsultaAnalisis.MdiParent = Me
        frmConsultaAnalisis.Show()
        frmConsultaAnalisis.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub menuConsDiagnostico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuConsDiagnostico.Click
        frmConsultaDiagnostico.MdiParent = Me
        frmConsultaDiagnostico.Show()
        frmConsultaDiagnostico.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub DiagnosticosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuAdmDiagnostico.Click
        frmBMDiagnostico.MdiParent = Me
        frmBMDiagnostico.Show()
        frmBMDiagnostico.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub TratatamientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuAdmTratamiento.Click
        frmBMTratamiento.MdiParent = Me
        frmBMTratamiento.Show()
        frmBMTratamiento.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub AnalisisClínicosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuAdmAnalisis.Click
        frmBMAnalisisClinico.MdiParent = Me
        frmBMAnalisisClinico.Show()
        frmBMAnalisisClinico.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub menuCreditos_Click(sender As Object, e As EventArgs) Handles menuCreditos.Click
        frmCreditos.MdiParent = Me
        frmCreditos.Show()
        frmCreditos.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmLogin.MdiParent = Me
        frmLogin.Show()
        frmLogin.WindowState = FormWindowState.Maximized
        menuInformacion.Enabled = False
        menuConsInf.Enabled = False
        menuFormularios.Enabled = False
        menuIngFormulario.Enabled = False
        menuConsFormularios.Enabled = False
        menuPersonalMedico.Enabled = False
        menuEntrevistaInicial.Enabled = False
        menuDiagnostico.Enabled = False
        menuIngTratamiento.Enabled = False
        menuIngAnalisis.Enabled = False
        menuConsAnalisis.Enabled = False
        menuConsDiagnostico.Enabled = False
        menuAdmDiagnostico.Enabled = False
        menuAdmTratamiento.Enabled = False
        menuAdmAnalisis.Enabled = False
        menuAdmEntrevista.Enabled = False
    End Sub

    Private Sub menuSalir_Click(sender As Object, e As EventArgs) Handles menuSalir.Click
        If cn.State = 0 Then
            Me.Close()
        Else
            cn.Close()
            Me.Close()
        End If
    End Sub

    Private Sub EntrevistaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuAdmEntrevista.Click
        frmConsultaEntInicial.MdiParent = Me
        frmConsultaEntInicial.Show()
        frmConsultaEntInicial.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub AToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles menuConsFormularios.Click
        frmConsultasFormulario.MdiParent = Me
        frmConsultasFormulario.Show()
        frmConsultasFormulario.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub FormularioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuIngFormulario.Click
        frmFormulario.MdiParent = Me
        frmFormulario.Show()
        frmFormulario.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub PacientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuInformacion.Click
        frmIngresoPacientes.MdiParent = Me
        frmIngresoPacientes.Show()
        frmIngresoPacientes.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub InformaciónPacienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuConsInf.Click
        frmConsultarPacientes.MdiParent = Me
        frmConsultarPacientes.Show()
        frmConsultarPacientes.WindowState = FormWindowState.Maximized
    End Sub
End Class
