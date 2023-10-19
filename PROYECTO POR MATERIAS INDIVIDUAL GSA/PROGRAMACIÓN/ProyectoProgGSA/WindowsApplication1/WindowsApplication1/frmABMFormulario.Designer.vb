<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmABMFormulario
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmABMFormulario))
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.lblFTipo = New System.Windows.Forms.Label()
        Me.lblSeleccPreg = New System.Windows.Forms.Label()
        Me.cboPregunta = New System.Windows.Forms.ComboBox()
        Me.lblNuevaPreg = New System.Windows.Forms.Label()
        Me.txtNuevaPregunta = New System.Windows.Forms.TextBox()
        Me.cmdModPregunta = New System.Windows.Forms.Button()
        Me.cmdEliminarPregunta = New System.Windows.Forms.Button()
        Me.cmdEliminarForm = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdCrear = New System.Windows.Forms.Button()
        Me.txtCrearPregunta = New System.Windows.Forms.TextBox()
        Me.lblPregunta = New System.Windows.Forms.Label()
        Me.lblTipoForm = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCrearTipoForm = New System.Windows.Forms.TextBox()
        Me.gbIngPreg = New System.Windows.Forms.GroupBox()
        Me.cboID = New System.Windows.Forms.ComboBox()
        Me.lblFID = New System.Windows.Forms.Label()
        Me.cmdIngresar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.gbIngPreg.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Location = New System.Drawing.Point(59, 33)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(114, 21)
        Me.cboTipo.TabIndex = 56
        Me.ToolTip1.SetToolTip(Me.cboTipo, "Seleccionar tipo de formulario")
        '
        'lblFTipo
        '
        Me.lblFTipo.AutoSize = True
        Me.lblFTipo.BackColor = System.Drawing.Color.Transparent
        Me.lblFTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFTipo.Location = New System.Drawing.Point(8, 34)
        Me.lblFTipo.Name = "lblFTipo"
        Me.lblFTipo.Size = New System.Drawing.Size(39, 20)
        Me.lblFTipo.TabIndex = 54
        Me.lblFTipo.Text = "Tipo"
        '
        'lblSeleccPreg
        '
        Me.lblSeleccPreg.AutoSize = True
        Me.lblSeleccPreg.BackColor = System.Drawing.Color.Transparent
        Me.lblSeleccPreg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeleccPreg.Location = New System.Drawing.Point(8, 28)
        Me.lblSeleccPreg.Name = "lblSeleccPreg"
        Me.lblSeleccPreg.Size = New System.Drawing.Size(74, 20)
        Me.lblSeleccPreg.TabIndex = 59
        Me.lblSeleccPreg.Text = "Pregunta"
        '
        'cboPregunta
        '
        Me.cboPregunta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPregunta.FormattingEnabled = True
        Me.cboPregunta.Location = New System.Drawing.Point(86, 30)
        Me.cboPregunta.Name = "cboPregunta"
        Me.cboPregunta.Size = New System.Drawing.Size(344, 21)
        Me.cboPregunta.TabIndex = 60
        Me.ToolTip1.SetToolTip(Me.cboPregunta, "Seleccionar pregunta")
        '
        'lblNuevaPreg
        '
        Me.lblNuevaPreg.AutoSize = True
        Me.lblNuevaPreg.BackColor = System.Drawing.Color.Transparent
        Me.lblNuevaPreg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNuevaPreg.Location = New System.Drawing.Point(8, 64)
        Me.lblNuevaPreg.Name = "lblNuevaPreg"
        Me.lblNuevaPreg.Size = New System.Drawing.Size(122, 20)
        Me.lblNuevaPreg.TabIndex = 62
        Me.lblNuevaPreg.Text = "Nueva pregunta"
        '
        'txtNuevaPregunta
        '
        Me.txtNuevaPregunta.Location = New System.Drawing.Point(136, 66)
        Me.txtNuevaPregunta.MaxLength = 160
        Me.txtNuevaPregunta.Multiline = True
        Me.txtNuevaPregunta.Name = "txtNuevaPregunta"
        Me.txtNuevaPregunta.Size = New System.Drawing.Size(466, 69)
        Me.txtNuevaPregunta.TabIndex = 63
        Me.ToolTip1.SetToolTip(Me.txtNuevaPregunta, "Ingresar nueva pregunta")
        '
        'cmdModPregunta
        '
        Me.cmdModPregunta.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdModPregunta.Location = New System.Drawing.Point(136, 141)
        Me.cmdModPregunta.Name = "cmdModPregunta"
        Me.cmdModPregunta.Size = New System.Drawing.Size(225, 33)
        Me.cmdModPregunta.TabIndex = 64
        Me.cmdModPregunta.Text = "Modificar pregunta"
        Me.ToolTip1.SetToolTip(Me.cmdModPregunta, "Modificar pregunta")
        Me.cmdModPregunta.UseVisualStyleBackColor = False
        '
        'cmdEliminarPregunta
        '
        Me.cmdEliminarPregunta.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdEliminarPregunta.Location = New System.Drawing.Point(375, 141)
        Me.cmdEliminarPregunta.Name = "cmdEliminarPregunta"
        Me.cmdEliminarPregunta.Size = New System.Drawing.Size(227, 33)
        Me.cmdEliminarPregunta.TabIndex = 65
        Me.cmdEliminarPregunta.Text = "Eliminar pregunta"
        Me.ToolTip1.SetToolTip(Me.cmdEliminarPregunta, "Eliminar pregunta")
        Me.cmdEliminarPregunta.UseVisualStyleBackColor = False
        '
        'cmdEliminarForm
        '
        Me.cmdEliminarForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdEliminarForm.Enabled = False
        Me.cmdEliminarForm.Location = New System.Drawing.Point(59, 61)
        Me.cmdEliminarForm.Name = "cmdEliminarForm"
        Me.cmdEliminarForm.Size = New System.Drawing.Size(275, 33)
        Me.cmdEliminarForm.TabIndex = 66
        Me.cmdEliminarForm.Text = "Eliminar formulario"
        Me.ToolTip1.SetToolTip(Me.cmdEliminarForm, "Eliminar formulario")
        Me.cmdEliminarForm.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(514, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 33)
        Me.Button1.TabIndex = 74
        Me.Button1.Text = "Crear"
        Me.ToolTip1.SetToolTip(Me.Button1, "Crear pregunta")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cmdCrear
        '
        Me.cmdCrear.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdCrear.Location = New System.Drawing.Point(173, 24)
        Me.cmdCrear.Name = "cmdCrear"
        Me.cmdCrear.Size = New System.Drawing.Size(88, 33)
        Me.cmdCrear.TabIndex = 73
        Me.cmdCrear.Text = "Crear"
        Me.ToolTip1.SetToolTip(Me.cmdCrear, "Crear formulario")
        Me.cmdCrear.UseVisualStyleBackColor = False
        '
        'txtCrearPregunta
        '
        Me.txtCrearPregunta.Location = New System.Drawing.Point(86, 28)
        Me.txtCrearPregunta.MaxLength = 160
        Me.txtCrearPregunta.Multiline = True
        Me.txtCrearPregunta.Name = "txtCrearPregunta"
        Me.txtCrearPregunta.Size = New System.Drawing.Size(422, 84)
        Me.txtCrearPregunta.TabIndex = 71
        Me.ToolTip1.SetToolTip(Me.txtCrearPregunta, "Ingresar pregunta")
        '
        'lblPregunta
        '
        Me.lblPregunta.AutoSize = True
        Me.lblPregunta.BackColor = System.Drawing.Color.Transparent
        Me.lblPregunta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPregunta.Location = New System.Drawing.Point(6, 26)
        Me.lblPregunta.Name = "lblPregunta"
        Me.lblPregunta.Size = New System.Drawing.Size(74, 20)
        Me.lblPregunta.TabIndex = 70
        Me.lblPregunta.Text = "Pregunta"
        '
        'lblTipoForm
        '
        Me.lblTipoForm.AutoSize = True
        Me.lblTipoForm.BackColor = System.Drawing.Color.Transparent
        Me.lblTipoForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoForm.Location = New System.Drawing.Point(6, 30)
        Me.lblTipoForm.Name = "lblTipoForm"
        Me.lblTipoForm.Size = New System.Drawing.Size(39, 20)
        Me.lblTipoForm.TabIndex = 67
        Me.lblTipoForm.Text = "Tipo"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtCrearTipoForm)
        Me.GroupBox1.Controls.Add(Me.lblTipoForm)
        Me.GroupBox1.Controls.Add(Me.cmdCrear)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(297, 74)
        Me.GroupBox1.TabIndex = 75
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CREAR FORMULARIO"
        '
        'txtCrearTipoForm
        '
        Me.txtCrearTipoForm.Location = New System.Drawing.Point(51, 30)
        Me.txtCrearTipoForm.MaxLength = 50
        Me.txtCrearTipoForm.Name = "txtCrearTipoForm"
        Me.txtCrearTipoForm.Size = New System.Drawing.Size(114, 20)
        Me.txtCrearTipoForm.TabIndex = 67
        Me.txtCrearTipoForm.Tag = ""
        Me.ToolTip1.SetToolTip(Me.txtCrearTipoForm, "Ingresar tipo de formulario")
        '
        'gbIngPreg
        '
        Me.gbIngPreg.BackColor = System.Drawing.Color.Transparent
        Me.gbIngPreg.Controls.Add(Me.cboID)
        Me.gbIngPreg.Controls.Add(Me.lblFID)
        Me.gbIngPreg.Controls.Add(Me.cmdEliminarForm)
        Me.gbIngPreg.Controls.Add(Me.lblFTipo)
        Me.gbIngPreg.Controls.Add(Me.cboTipo)
        Me.gbIngPreg.Location = New System.Drawing.Point(12, 241)
        Me.gbIngPreg.Name = "gbIngPreg"
        Me.gbIngPreg.Size = New System.Drawing.Size(359, 102)
        Me.gbIngPreg.TabIndex = 76
        Me.gbIngPreg.TabStop = False
        Me.gbIngPreg.Text = "SELECCIONAR FORMULARIO"
        '
        'cboID
        '
        Me.cboID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboID.FormattingEnabled = True
        Me.cboID.Location = New System.Drawing.Point(220, 34)
        Me.cboID.Name = "cboID"
        Me.cboID.Size = New System.Drawing.Size(114, 21)
        Me.cboID.TabIndex = 68
        Me.ToolTip1.SetToolTip(Me.cboID, "Seleccionar número identificador del formulario")
        '
        'lblFID
        '
        Me.lblFID.AutoSize = True
        Me.lblFID.BackColor = System.Drawing.Color.Transparent
        Me.lblFID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFID.Location = New System.Drawing.Point(188, 34)
        Me.lblFID.Name = "lblFID"
        Me.lblFID.Size = New System.Drawing.Size(26, 20)
        Me.lblFID.TabIndex = 67
        Me.lblFID.Text = "ID"
        '
        'cmdIngresar
        '
        Me.cmdIngresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdIngresar.Location = New System.Drawing.Point(436, 19)
        Me.cmdIngresar.Name = "cmdIngresar"
        Me.cmdIngresar.Size = New System.Drawing.Size(166, 37)
        Me.cmdIngresar.TabIndex = 69
        Me.cmdIngresar.Text = "Ingresar pregunta al formulario"
        Me.ToolTip1.SetToolTip(Me.cmdIngresar, "Ingresar pregunta al formulario")
        Me.cmdIngresar.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.lblPregunta)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.txtCrearPregunta)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 107)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(608, 128)
        Me.GroupBox3.TabIndex = 76
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CREAR PREGUNTAS"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cmdIngresar)
        Me.GroupBox2.Controls.Add(Me.lblSeleccPreg)
        Me.GroupBox2.Controls.Add(Me.cboPregunta)
        Me.GroupBox2.Controls.Add(Me.lblNuevaPreg)
        Me.GroupBox2.Controls.Add(Me.txtNuevaPregunta)
        Me.GroupBox2.Controls.Add(Me.cmdEliminarPregunta)
        Me.GroupBox2.Controls.Add(Me.cmdModPregunta)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 358)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(608, 181)
        Me.GroupBox2.TabIndex = 77
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ADMINISTRACIÓN PREGUNTAS"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.ReshowDelay = 100
        '
        'frmABMFormulario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.the_background_292720
        Me.ClientSize = New System.Drawing.Size(634, 561)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbIngPreg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmABMFormulario"
        Me.Text = "ADMINISTRACIÓN FORMULARIOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbIngPreg.ResumeLayout(False)
        Me.gbIngPreg.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents lblFTipo As System.Windows.Forms.Label
    Friend WithEvents lblSeleccPreg As System.Windows.Forms.Label
    Friend WithEvents cboPregunta As System.Windows.Forms.ComboBox
    Friend WithEvents lblNuevaPreg As System.Windows.Forms.Label
    Friend WithEvents txtNuevaPregunta As System.Windows.Forms.TextBox
    Friend WithEvents cmdModPregunta As System.Windows.Forms.Button
    Friend WithEvents cmdEliminarPregunta As System.Windows.Forms.Button
    Friend WithEvents cmdEliminarForm As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmdCrear As System.Windows.Forms.Button
    Friend WithEvents txtCrearPregunta As System.Windows.Forms.TextBox
    Friend WithEvents lblPregunta As System.Windows.Forms.Label
    Friend WithEvents lblTipoForm As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gbIngPreg As System.Windows.Forms.GroupBox
    Public WithEvents txtCrearTipoForm As System.Windows.Forms.TextBox
    Friend WithEvents cmdIngresar As System.Windows.Forms.Button
    Friend WithEvents cboID As System.Windows.Forms.ComboBox
    Friend WithEvents lblFID As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
