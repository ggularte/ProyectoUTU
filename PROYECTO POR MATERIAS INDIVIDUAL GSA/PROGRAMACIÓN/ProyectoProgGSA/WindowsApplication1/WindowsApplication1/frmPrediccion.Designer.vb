<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrediccion
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrediccion))
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCI = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFiebre = New System.Windows.Forms.TextBox()
        Me.txtMalestar = New System.Windows.Forms.TextBox()
        Me.txtDolor = New System.Windows.Forms.TextBox()
        Me.txtOtro = New System.Windows.Forms.TextBox()
        Me.cmdConsultar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.gbBuscar = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdConfirmar = New System.Windows.Forms.Button()
        Me.txtEnfermedadActual = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBuscar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(9, 19)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(25, 20)
        Me.lblNombre.TabIndex = 69
        Me.lblNombre.Text = "CI"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(211, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(459, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Apellido"
        '
        'txtCI
        '
        Me.txtCI.Enabled = False
        Me.txtCI.Location = New System.Drawing.Point(40, 19)
        Me.txtCI.MaxLength = 30
        Me.txtCI.Name = "txtCI"
        Me.txtCI.Size = New System.Drawing.Size(160, 20)
        Me.txtCI.TabIndex = 72
        Me.ToolTip1.SetToolTip(Me.txtCI, "Cédula de identidad del paciente")
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(282, 19)
        Me.txtNombre.MaxLength = 30
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(160, 20)
        Me.txtNombre.TabIndex = 73
        Me.ToolTip1.SetToolTip(Me.txtNombre, "Primer nombre del paciente")
        '
        'txtApellido
        '
        Me.txtApellido.Enabled = False
        Me.txtApellido.Location = New System.Drawing.Point(530, 19)
        Me.txtApellido.MaxLength = 30
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(160, 20)
        Me.txtApellido.TabIndex = 74
        Me.ToolTip1.SetToolTip(Me.txtApellido, "Primer apellido del paciente")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(164, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 20)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "Dolor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 20)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Malestar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 20)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Fiebre"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(164, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 20)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "Otro"
        '
        'txtFiebre
        '
        Me.txtFiebre.Enabled = False
        Me.txtFiebre.Location = New System.Drawing.Point(85, 57)
        Me.txtFiebre.MaxLength = 30
        Me.txtFiebre.Name = "txtFiebre"
        Me.txtFiebre.Size = New System.Drawing.Size(63, 20)
        Me.txtFiebre.TabIndex = 79
        Me.ToolTip1.SetToolTip(Me.txtFiebre, "Síntoma fiebre")
        '
        'txtMalestar
        '
        Me.txtMalestar.Enabled = False
        Me.txtMalestar.Location = New System.Drawing.Point(85, 97)
        Me.txtMalestar.MaxLength = 30
        Me.txtMalestar.Name = "txtMalestar"
        Me.txtMalestar.Size = New System.Drawing.Size(63, 20)
        Me.txtMalestar.TabIndex = 80
        Me.ToolTip1.SetToolTip(Me.txtMalestar, "Síntoma malestar")
        '
        'txtDolor
        '
        Me.txtDolor.Enabled = False
        Me.txtDolor.Location = New System.Drawing.Point(217, 59)
        Me.txtDolor.MaxLength = 30
        Me.txtDolor.Name = "txtDolor"
        Me.txtDolor.Size = New System.Drawing.Size(63, 20)
        Me.txtDolor.TabIndex = 81
        Me.ToolTip1.SetToolTip(Me.txtDolor, "Síntoma dolor")
        '
        'txtOtro
        '
        Me.txtOtro.Enabled = False
        Me.txtOtro.Location = New System.Drawing.Point(215, 99)
        Me.txtOtro.MaxLength = 30
        Me.txtOtro.Name = "txtOtro"
        Me.txtOtro.Size = New System.Drawing.Size(197, 20)
        Me.txtOtro.TabIndex = 82
        Me.ToolTip1.SetToolTip(Me.txtOtro, "Otro síntoma")
        '
        'cmdConsultar
        '
        Me.cmdConsultar.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.cmdConsultar.Location = New System.Drawing.Point(286, 50)
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(126, 37)
        Me.cmdConsultar.TabIndex = 83
        Me.cmdConsultar.Text = "Consultar dolor en las partes del cuerpo"
        Me.ToolTip1.SetToolTip(Me.cmdConsultar, "Ver las partes del cuerpo del paciente con dolor")
        Me.cmdConsultar.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuHighlight
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(13, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Size = New System.Drawing.Size(670, 150)
        Me.DataGridView1.TabIndex = 84
        '
        'gbBuscar
        '
        Me.gbBuscar.BackColor = System.Drawing.Color.Transparent
        Me.gbBuscar.Controls.Add(Me.txtCI)
        Me.gbBuscar.Controls.Add(Me.lblNombre)
        Me.gbBuscar.Controls.Add(Me.cmdConsultar)
        Me.gbBuscar.Controls.Add(Me.Label1)
        Me.gbBuscar.Controls.Add(Me.txtOtro)
        Me.gbBuscar.Controls.Add(Me.Label2)
        Me.gbBuscar.Controls.Add(Me.txtDolor)
        Me.gbBuscar.Controls.Add(Me.txtNombre)
        Me.gbBuscar.Controls.Add(Me.txtMalestar)
        Me.gbBuscar.Controls.Add(Me.txtApellido)
        Me.gbBuscar.Controls.Add(Me.txtFiebre)
        Me.gbBuscar.Controls.Add(Me.Label3)
        Me.gbBuscar.Controls.Add(Me.Label6)
        Me.gbBuscar.Controls.Add(Me.Label4)
        Me.gbBuscar.Controls.Add(Me.Label5)
        Me.gbBuscar.Location = New System.Drawing.Point(12, 12)
        Me.gbBuscar.Name = "gbBuscar"
        Me.gbBuscar.Size = New System.Drawing.Size(693, 138)
        Me.gbBuscar.TabIndex = 85
        Me.gbBuscar.TabStop = False
        Me.gbBuscar.Text = "INFORMACIÓN"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 164)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(693, 186)
        Me.GroupBox1.TabIndex = 86
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "POSIBLES ENFERMEDADES"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cmdConfirmar)
        Me.GroupBox2.Controls.Add(Me.txtEnfermedadActual)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 367)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(693, 64)
        Me.GroupBox2.TabIndex = 87
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CONFIRMAR ENFERMEDAD ACTUAL"
        '
        'cmdConfirmar
        '
        Me.cmdConfirmar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdConfirmar.Location = New System.Drawing.Point(331, 22)
        Me.cmdConfirmar.Name = "cmdConfirmar"
        Me.cmdConfirmar.Size = New System.Drawing.Size(102, 25)
        Me.cmdConfirmar.TabIndex = 25
        Me.cmdConfirmar.Text = "Confirmar"
        Me.ToolTip1.SetToolTip(Me.cmdConfirmar, "Confirmar enfermedad actual del paciente")
        Me.cmdConfirmar.UseVisualStyleBackColor = False
        '
        'txtEnfermedadActual
        '
        Me.txtEnfermedadActual.Enabled = False
        Me.txtEnfermedadActual.Location = New System.Drawing.Point(156, 25)
        Me.txtEnfermedadActual.MaxLength = 30
        Me.txtEnfermedadActual.Name = "txtEnfermedadActual"
        Me.txtEnfermedadActual.Size = New System.Drawing.Size(160, 20)
        Me.txtEnfermedadActual.TabIndex = 84
        Me.ToolTip1.SetToolTip(Me.txtEnfermedadActual, "Seleccionar enfermedad actual del paciente")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 20)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "Enfermedad actual"
        '
        'frmPrediccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.the_background_292720
        Me.ClientSize = New System.Drawing.Size(707, 545)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbBuscar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrediccion"
        Me.Text = "PREDICCIÓN ENFERMEDAD"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBuscar.ResumeLayout(False)
        Me.gbBuscar.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCI As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtFiebre As System.Windows.Forms.TextBox
    Friend WithEvents txtMalestar As System.Windows.Forms.TextBox
    Friend WithEvents txtDolor As System.Windows.Forms.TextBox
    Friend WithEvents txtOtro As System.Windows.Forms.TextBox
    Friend WithEvents cmdConsultar As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents gbBuscar As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtEnfermedadActual As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmdConfirmar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
