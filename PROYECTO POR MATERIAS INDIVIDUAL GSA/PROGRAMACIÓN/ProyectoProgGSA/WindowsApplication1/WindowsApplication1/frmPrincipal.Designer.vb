<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menuAdministracion = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuInformacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPersonalMedico = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAdmEntrevista = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFormularios = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuConsFormularios = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAdmDiagnostico = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAdmAnalisis = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAdmTratamiento = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAnamnesis = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuConsInf = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEntrevistaInicial = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPreDiagnostico = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuDiagnostico = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuIngFormulario = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPlan = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuIngTratamiento = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuIngAnalisis = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuConsAnalisis = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuConsDiagnostico = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAcercaDe = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCreditos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuIngreso = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuLogin = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuAdministracion, Me.menuAnamnesis, Me.menuPreDiagnostico, Me.menuPlan, Me.menuAcercaDe, Me.menuIngreso})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menuAdministracion
        '
        Me.menuAdministracion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuInformacion, Me.menuPersonalMedico, Me.menuAdmEntrevista, Me.menuFormularios, Me.menuConsFormularios, Me.menuAdmDiagnostico, Me.menuAdmAnalisis, Me.menuAdmTratamiento})
        Me.menuAdministracion.Name = "menuAdministracion"
        Me.menuAdministracion.Size = New System.Drawing.Size(100, 20)
        Me.menuAdministracion.Text = "Administración"
        '
        'menuInformacion
        '
        Me.menuInformacion.Name = "menuInformacion"
        Me.menuInformacion.Size = New System.Drawing.Size(189, 22)
        Me.menuInformacion.Text = "Pacientes"
        '
        'menuPersonalMedico
        '
        Me.menuPersonalMedico.Name = "menuPersonalMedico"
        Me.menuPersonalMedico.Size = New System.Drawing.Size(189, 22)
        Me.menuPersonalMedico.Text = "Personal médico"
        '
        'menuAdmEntrevista
        '
        Me.menuAdmEntrevista.Name = "menuAdmEntrevista"
        Me.menuAdmEntrevista.Size = New System.Drawing.Size(189, 22)
        Me.menuAdmEntrevista.Text = "Entrevista"
        '
        'menuFormularios
        '
        Me.menuFormularios.Name = "menuFormularios"
        Me.menuFormularios.Size = New System.Drawing.Size(189, 22)
        Me.menuFormularios.Text = "Formularios"
        '
        'menuConsFormularios
        '
        Me.menuConsFormularios.Name = "menuConsFormularios"
        Me.menuConsFormularios.Size = New System.Drawing.Size(189, 22)
        Me.menuConsFormularios.Text = "Consultar formularios"
        '
        'menuAdmDiagnostico
        '
        Me.menuAdmDiagnostico.Name = "menuAdmDiagnostico"
        Me.menuAdmDiagnostico.Size = New System.Drawing.Size(189, 22)
        Me.menuAdmDiagnostico.Text = "Diagnosticos"
        '
        'menuAdmAnalisis
        '
        Me.menuAdmAnalisis.Name = "menuAdmAnalisis"
        Me.menuAdmAnalisis.Size = New System.Drawing.Size(189, 22)
        Me.menuAdmAnalisis.Text = "Analisis clínicos"
        '
        'menuAdmTratamiento
        '
        Me.menuAdmTratamiento.Name = "menuAdmTratamiento"
        Me.menuAdmTratamiento.Size = New System.Drawing.Size(189, 22)
        Me.menuAdmTratamiento.Text = "Tratatamientos"
        '
        'menuAnamnesis
        '
        Me.menuAnamnesis.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuConsInf, Me.menuEntrevistaInicial})
        Me.menuAnamnesis.Name = "menuAnamnesis"
        Me.menuAnamnesis.Size = New System.Drawing.Size(89, 20)
        Me.menuAnamnesis.Text = "1. Anamnesis"
        '
        'menuConsInf
        '
        Me.menuConsInf.Name = "menuConsInf"
        Me.menuConsInf.Size = New System.Drawing.Size(205, 22)
        Me.menuConsInf.Text = "1.1 Información paciente"
        '
        'menuEntrevistaInicial
        '
        Me.menuEntrevistaInicial.Name = "menuEntrevistaInicial"
        Me.menuEntrevistaInicial.Size = New System.Drawing.Size(205, 22)
        Me.menuEntrevistaInicial.Text = "1.2 Entrevista inicial"
        '
        'menuPreDiagnostico
        '
        Me.menuPreDiagnostico.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuDiagnostico, Me.menuIngFormulario})
        Me.menuPreDiagnostico.Name = "menuPreDiagnostico"
        Me.menuPreDiagnostico.Size = New System.Drawing.Size(180, 20)
        Me.menuPreDiagnostico.Text = "2. Prediagnóstico/diagnóstico "
        '
        'menuDiagnostico
        '
        Me.menuDiagnostico.Name = "menuDiagnostico"
        Me.menuDiagnostico.Size = New System.Drawing.Size(155, 22)
        Me.menuDiagnostico.Text = "2.1 Diagnóstico"
        '
        'menuIngFormulario
        '
        Me.menuIngFormulario.Name = "menuIngFormulario"
        Me.menuIngFormulario.Size = New System.Drawing.Size(155, 22)
        Me.menuIngFormulario.Text = "2.2 Formulario"
        '
        'menuPlan
        '
        Me.menuPlan.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuIngTratamiento, Me.menuIngAnalisis, Me.menuConsAnalisis, Me.menuConsDiagnostico})
        Me.menuPlan.Name = "menuPlan"
        Me.menuPlan.Size = New System.Drawing.Size(54, 20)
        Me.menuPlan.Text = "3. Plan"
        '
        'menuIngTratamiento
        '
        Me.menuIngTratamiento.Name = "menuIngTratamiento"
        Me.menuIngTratamiento.Size = New System.Drawing.Size(227, 22)
        Me.menuIngTratamiento.Text = "3.1 Ingreso tratamiento"
        '
        'menuIngAnalisis
        '
        Me.menuIngAnalisis.Name = "menuIngAnalisis"
        Me.menuIngAnalisis.Size = New System.Drawing.Size(227, 22)
        Me.menuIngAnalisis.Text = "3.2 Ingreso análisis clínico"
        '
        'menuConsAnalisis
        '
        Me.menuConsAnalisis.Name = "menuConsAnalisis"
        Me.menuConsAnalisis.Size = New System.Drawing.Size(227, 22)
        Me.menuConsAnalisis.Text = "3.3 Consultar análisis clínicos"
        '
        'menuConsDiagnostico
        '
        Me.menuConsDiagnostico.Name = "menuConsDiagnostico"
        Me.menuConsDiagnostico.Size = New System.Drawing.Size(227, 22)
        Me.menuConsDiagnostico.Text = "3.4 Consultar diagnósticos"
        '
        'menuAcercaDe
        '
        Me.menuAcercaDe.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuCreditos})
        Me.menuAcercaDe.Name = "menuAcercaDe"
        Me.menuAcercaDe.Size = New System.Drawing.Size(71, 20)
        Me.menuAcercaDe.Text = "Acerca de"
        '
        'menuCreditos
        '
        Me.menuCreditos.Name = "menuCreditos"
        Me.menuCreditos.Size = New System.Drawing.Size(118, 22)
        Me.menuCreditos.Text = "Créditos"
        '
        'menuIngreso
        '
        Me.menuIngreso.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuLogin, Me.menuSalir})
        Me.menuIngreso.Name = "menuIngreso"
        Me.menuIngreso.Size = New System.Drawing.Size(58, 20)
        Me.menuIngreso.Text = "Ingreso"
        '
        'menuLogin
        '
        Me.menuLogin.Name = "menuLogin"
        Me.menuLogin.Size = New System.Drawing.Size(104, 22)
        Me.menuLogin.Text = "Login"
        '
        'menuSalir
        '
        Me.menuSalir.Name = "menuSalir"
        Me.menuSalir.Size = New System.Drawing.Size(104, 22)
        Me.menuSalir.Text = "Salir"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.login
        Me.ClientSize = New System.Drawing.Size(784, 761)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmPrincipal"
        Me.Text = "PRINCIPAL"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents menuAdministracion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuFormularios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuPersonalMedico As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuIngreso As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuLogin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuAnamnesis As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuEntrevistaInicial As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuPreDiagnostico As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuDiagnostico As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuPlan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuIngTratamiento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuIngAnalisis As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuConsAnalisis As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuConsDiagnostico As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuAcercaDe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuCreditos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuAdmDiagnostico As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuAdmTratamiento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuAdmAnalisis As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuAdmEntrevista As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuConsFormularios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuIngFormulario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuInformacion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuConsInf As System.Windows.Forms.ToolStripMenuItem

End Class
