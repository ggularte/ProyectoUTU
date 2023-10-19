<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFormulario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFormulario))
        Me.gbBuscar = New System.Windows.Forms.GroupBox()
        Me.txtCI = New System.Windows.Forms.TextBox()
        Me.lblBCI = New System.Windows.Forms.Label()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.gbDatos = New System.Windows.Forms.GroupBox()
        Me.cbCIMedico = New System.Windows.Forms.ComboBox()
        Me.cbFecha = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbSelecPreg = New System.Windows.Forms.GroupBox()
        Me.cboPregunta = New System.Windows.Forms.ComboBox()
        Me.gbIngPreg = New System.Windows.Forms.GroupBox()
        Me.cboID = New System.Windows.Forms.ComboBox()
        Me.lblFID = New System.Windows.Forms.Label()
        Me.lblFTipo = New System.Windows.Forms.Label()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.gbIngResp = New System.Windows.Forms.GroupBox()
        Me.txtRespuesta = New System.Windows.Forms.TextBox()
        Me.cmdIngresar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbBuscar.SuspendLayout()
        Me.gbDatos.SuspendLayout()
        Me.gbSelecPreg.SuspendLayout()
        Me.gbIngPreg.SuspendLayout()
        Me.gbIngResp.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbBuscar
        '
        Me.gbBuscar.BackColor = System.Drawing.Color.Transparent
        Me.gbBuscar.Controls.Add(Me.txtCI)
        Me.gbBuscar.Controls.Add(Me.lblBCI)
        Me.gbBuscar.Controls.Add(Me.cmdBuscar)
        Me.gbBuscar.Location = New System.Drawing.Point(12, 12)
        Me.gbBuscar.Name = "gbBuscar"
        Me.gbBuscar.Size = New System.Drawing.Size(380, 45)
        Me.gbBuscar.TabIndex = 77
        Me.gbBuscar.TabStop = False
        Me.gbBuscar.Text = "BUSCAR"
        '
        'txtCI
        '
        Me.txtCI.Location = New System.Drawing.Point(37, 16)
        Me.txtCI.MaxLength = 8
        Me.txtCI.Name = "txtCI"
        Me.txtCI.Size = New System.Drawing.Size(211, 20)
        Me.txtCI.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.txtCI, "Ingresar cédula de identidad")
        '
        'lblBCI
        '
        Me.lblBCI.AutoSize = True
        Me.lblBCI.BackColor = System.Drawing.Color.Transparent
        Me.lblBCI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBCI.Location = New System.Drawing.Point(6, 16)
        Me.lblBCI.Name = "lblBCI"
        Me.lblBCI.Size = New System.Drawing.Size(25, 20)
        Me.lblBCI.TabIndex = 22
        Me.lblBCI.Text = "CI"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdBuscar.Location = New System.Drawing.Point(268, 13)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(102, 25)
        Me.cmdBuscar.TabIndex = 21
        Me.cmdBuscar.Text = "Buscar"
        Me.ToolTip1.SetToolTip(Me.cmdBuscar, "Buscar paciente")
        Me.cmdBuscar.UseVisualStyleBackColor = False
        '
        'gbDatos
        '
        Me.gbDatos.BackColor = System.Drawing.Color.Transparent
        Me.gbDatos.Controls.Add(Me.cbCIMedico)
        Me.gbDatos.Controls.Add(Me.cbFecha)
        Me.gbDatos.Controls.Add(Me.Label2)
        Me.gbDatos.Controls.Add(Me.Label1)
        Me.gbDatos.Enabled = False
        Me.gbDatos.Location = New System.Drawing.Point(12, 63)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(500, 48)
        Me.gbDatos.TabIndex = 78
        Me.gbDatos.TabStop = False
        Me.gbDatos.Text = "DATOS"
        Me.gbDatos.Visible = False
        '
        'cbCIMedico
        '
        Me.cbCIMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCIMedico.FormattingEnabled = True
        Me.cbCIMedico.Location = New System.Drawing.Point(350, 18)
        Me.cbCIMedico.Name = "cbCIMedico"
        Me.cbCIMedico.Size = New System.Drawing.Size(137, 21)
        Me.cbCIMedico.TabIndex = 96
        Me.ToolTip1.SetToolTip(Me.cbCIMedico, "Seleccionar cédula de identidad del médico")
        '
        'cbFecha
        '
        Me.cbFecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFecha.FormattingEnabled = True
        Me.cbFecha.Location = New System.Drawing.Point(123, 18)
        Me.cbFecha.Name = "cbFecha"
        Me.cbFecha.Size = New System.Drawing.Size(137, 21)
        Me.cbFecha.TabIndex = 95
        Me.ToolTip1.SetToolTip(Me.cbFecha, "Seleccionar fecha atiende")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 20)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Fecha atiende"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(264, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "CI Médico"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 20)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = "Pregunta"
        '
        'gbSelecPreg
        '
        Me.gbSelecPreg.BackColor = System.Drawing.Color.Transparent
        Me.gbSelecPreg.Controls.Add(Me.cboPregunta)
        Me.gbSelecPreg.Controls.Add(Me.Label3)
        Me.gbSelecPreg.Enabled = False
        Me.gbSelecPreg.Location = New System.Drawing.Point(12, 176)
        Me.gbSelecPreg.Name = "gbSelecPreg"
        Me.gbSelecPreg.Size = New System.Drawing.Size(598, 47)
        Me.gbSelecPreg.TabIndex = 96
        Me.gbSelecPreg.TabStop = False
        Me.gbSelecPreg.Text = "SELECCIONAR PREGUNTA"
        Me.gbSelecPreg.Visible = False
        '
        'cboPregunta
        '
        Me.cboPregunta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPregunta.FormattingEnabled = True
        Me.cboPregunta.Location = New System.Drawing.Point(86, 16)
        Me.cboPregunta.Name = "cboPregunta"
        Me.cboPregunta.Size = New System.Drawing.Size(495, 21)
        Me.cboPregunta.TabIndex = 97
        Me.ToolTip1.SetToolTip(Me.cboPregunta, "Seleccionar pregunta de un formulario")
        '
        'gbIngPreg
        '
        Me.gbIngPreg.BackColor = System.Drawing.Color.Transparent
        Me.gbIngPreg.Controls.Add(Me.cboID)
        Me.gbIngPreg.Controls.Add(Me.lblFID)
        Me.gbIngPreg.Controls.Add(Me.lblFTipo)
        Me.gbIngPreg.Controls.Add(Me.cboTipo)
        Me.gbIngPreg.Enabled = False
        Me.gbIngPreg.Location = New System.Drawing.Point(12, 117)
        Me.gbIngPreg.Name = "gbIngPreg"
        Me.gbIngPreg.Size = New System.Drawing.Size(380, 53)
        Me.gbIngPreg.TabIndex = 97
        Me.gbIngPreg.TabStop = False
        Me.gbIngPreg.Text = "SELECCIONAR FORMULARIO"
        Me.gbIngPreg.Visible = False
        '
        'cboID
        '
        Me.cboID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboID.FormattingEnabled = True
        Me.cboID.Location = New System.Drawing.Point(218, 19)
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
        Me.lblFID.Location = New System.Drawing.Point(186, 19)
        Me.lblFID.Name = "lblFID"
        Me.lblFID.Size = New System.Drawing.Size(26, 20)
        Me.lblFID.TabIndex = 67
        Me.lblFID.Text = "ID"
        '
        'lblFTipo
        '
        Me.lblFTipo.AutoSize = True
        Me.lblFTipo.BackColor = System.Drawing.Color.Transparent
        Me.lblFTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFTipo.Location = New System.Drawing.Point(6, 19)
        Me.lblFTipo.Name = "lblFTipo"
        Me.lblFTipo.Size = New System.Drawing.Size(39, 20)
        Me.lblFTipo.TabIndex = 54
        Me.lblFTipo.Text = "Tipo"
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Location = New System.Drawing.Point(57, 18)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(114, 21)
        Me.cboTipo.TabIndex = 56
        Me.ToolTip1.SetToolTip(Me.cboTipo, "Seleccionar tipo del formulario")
        '
        'gbIngResp
        '
        Me.gbIngResp.BackColor = System.Drawing.Color.Transparent
        Me.gbIngResp.Controls.Add(Me.txtRespuesta)
        Me.gbIngResp.Controls.Add(Me.cmdIngresar)
        Me.gbIngResp.Controls.Add(Me.cmdCancelar)
        Me.gbIngResp.Controls.Add(Me.Label4)
        Me.gbIngResp.Enabled = False
        Me.gbIngResp.Location = New System.Drawing.Point(12, 229)
        Me.gbIngResp.Name = "gbIngResp"
        Me.gbIngResp.Size = New System.Drawing.Size(598, 184)
        Me.gbIngResp.TabIndex = 97
        Me.gbIngResp.TabStop = False
        Me.gbIngResp.Text = "INGRESAR RESPUESTA"
        Me.gbIngResp.Visible = False
        '
        'txtRespuesta
        '
        Me.txtRespuesta.Location = New System.Drawing.Point(99, 16)
        Me.txtRespuesta.MaxLength = 160
        Me.txtRespuesta.Multiline = True
        Me.txtRespuesta.Name = "txtRespuesta"
        Me.txtRespuesta.Size = New System.Drawing.Size(482, 131)
        Me.txtRespuesta.TabIndex = 25
        Me.ToolTip1.SetToolTip(Me.txtRespuesta, "Ingresar respuesta a una pregunta de un formulario")
        '
        'cmdIngresar
        '
        Me.cmdIngresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdIngresar.Location = New System.Drawing.Point(479, 153)
        Me.cmdIngresar.Name = "cmdIngresar"
        Me.cmdIngresar.Size = New System.Drawing.Size(102, 25)
        Me.cmdIngresar.TabIndex = 97
        Me.cmdIngresar.Text = "Ingresar"
        Me.ToolTip1.SetToolTip(Me.cmdIngresar, "Alta respuesta")
        Me.cmdIngresar.UseVisualStyleBackColor = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdCancelar.Location = New System.Drawing.Point(371, 153)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(102, 25)
        Me.cmdCancelar.TabIndex = 25
        Me.cmdCancelar.Text = "Cancelar"
        Me.ToolTip1.SetToolTip(Me.cmdCancelar, "Cancelar ingreso de datos")
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 20)
        Me.Label4.TabIndex = 96
        Me.Label4.Text = "Respuesta"
        '
        'frmFormulario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.the_background_292720
        Me.ClientSize = New System.Drawing.Size(634, 561)
        Me.Controls.Add(Me.gbIngResp)
        Me.Controls.Add(Me.gbIngPreg)
        Me.Controls.Add(Me.gbSelecPreg)
        Me.Controls.Add(Me.gbDatos)
        Me.Controls.Add(Me.gbBuscar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFormulario"
        Me.Text = "RESPUESTAS FORMULARIO"
        Me.gbBuscar.ResumeLayout(False)
        Me.gbBuscar.PerformLayout()
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        Me.gbSelecPreg.ResumeLayout(False)
        Me.gbSelecPreg.PerformLayout()
        Me.gbIngPreg.ResumeLayout(False)
        Me.gbIngPreg.PerformLayout()
        Me.gbIngResp.ResumeLayout(False)
        Me.gbIngResp.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbBuscar As System.Windows.Forms.GroupBox
    Friend WithEvents txtCI As System.Windows.Forms.TextBox
    Friend WithEvents lblBCI As System.Windows.Forms.Label
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents gbDatos As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbFecha As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gbSelecPreg As System.Windows.Forms.GroupBox
    Friend WithEvents cbCIMedico As System.Windows.Forms.ComboBox
    Friend WithEvents cboPregunta As System.Windows.Forms.ComboBox
    Friend WithEvents gbIngPreg As System.Windows.Forms.GroupBox
    Friend WithEvents cboID As System.Windows.Forms.ComboBox
    Friend WithEvents lblFID As System.Windows.Forms.Label
    Friend WithEvents lblFTipo As System.Windows.Forms.Label
    Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents gbIngResp As System.Windows.Forms.GroupBox
    Friend WithEvents txtRespuesta As System.Windows.Forms.TextBox
    Friend WithEvents cmdIngresar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
