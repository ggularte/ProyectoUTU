<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTratamiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTratamiento))
        Me.lblFechaIN = New System.Windows.Forms.Label()
        Me.lblFechaFin = New System.Windows.Forms.Label()
        Me.txtDescripción = New System.Windows.Forms.TextBox()
        Me.lblDescripción = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.cmdIngresar = New System.Windows.Forms.Button()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCI = New System.Windows.Forms.TextBox()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.gbBuscar = New System.Windows.Forms.GroupBox()
        Me.gbDatos = New System.Windows.Forms.GroupBox()
        Me.txtNula = New System.Windows.Forms.TextBox()
        Me.cbFechaFinal = New System.Windows.Forms.CheckBox()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbBuscar.SuspendLayout()
        Me.gbDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFechaIN
        '
        Me.lblFechaIN.AutoSize = True
        Me.lblFechaIN.BackColor = System.Drawing.Color.Transparent
        Me.lblFechaIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaIN.Location = New System.Drawing.Point(1, 71)
        Me.lblFechaIN.Name = "lblFechaIN"
        Me.lblFechaIN.Size = New System.Drawing.Size(93, 20)
        Me.lblFechaIN.TabIndex = 57
        Me.lblFechaIN.Text = "Fecha inicio"
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.BackColor = System.Drawing.Color.Transparent
        Me.lblFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaFin.Location = New System.Drawing.Point(1, 109)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(87, 20)
        Me.lblFechaFin.TabIndex = 59
        Me.lblFechaFin.Text = "Fecha final"
        '
        'txtDescripción
        '
        Me.txtDescripción.Location = New System.Drawing.Point(103, 152)
        Me.txtDescripción.MaxLength = 240
        Me.txtDescripción.Multiline = True
        Me.txtDescripción.Name = "txtDescripción"
        Me.txtDescripción.Size = New System.Drawing.Size(458, 102)
        Me.txtDescripción.TabIndex = 63
        Me.ToolTip1.SetToolTip(Me.txtDescripción, "Ingresar descripción del tratamiento")
        '
        'lblDescripción
        '
        Me.lblDescripción.AutoSize = True
        Me.lblDescripción.BackColor = System.Drawing.Color.Transparent
        Me.lblDescripción.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripción.Location = New System.Drawing.Point(1, 150)
        Me.lblDescripción.Name = "lblDescripción"
        Me.lblDescripción.Size = New System.Drawing.Size(92, 20)
        Me.lblDescripción.TabIndex = 62
        Me.lblDescripción.Text = "Descripción"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(103, 30)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(208, 20)
        Me.txtNombre.TabIndex = 65
        Me.ToolTip1.SetToolTip(Me.txtNombre, "Ingresar nombre del tratamiento")
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(6, 30)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(65, 20)
        Me.lblNombre.TabIndex = 64
        Me.lblNombre.Text = "Nombre"
        '
        'cmdIngresar
        '
        Me.cmdIngresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdIngresar.Location = New System.Drawing.Point(10, 273)
        Me.cmdIngresar.Name = "cmdIngresar"
        Me.cmdIngresar.Size = New System.Drawing.Size(102, 33)
        Me.cmdIngresar.TabIndex = 66
        Me.cmdIngresar.Text = "Ingresar"
        Me.ToolTip1.SetToolTip(Me.cmdIngresar, "Alta tratamiento")
        Me.cmdIngresar.UseVisualStyleBackColor = False
        '
        'dtpInicio
        '
        Me.dtpInicio.Location = New System.Drawing.Point(103, 70)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(208, 20)
        Me.dtpInicio.TabIndex = 67
        Me.ToolTip1.SetToolTip(Me.dtpInicio, "Seleccionar fecha inicio del tratamiento")
        '
        'dtpFinal
        '
        Me.dtpFinal.Location = New System.Drawing.Point(103, 109)
        Me.dtpFinal.Name = "dtpFinal"
        Me.dtpFinal.Size = New System.Drawing.Size(208, 20)
        Me.dtpFinal.TabIndex = 68
        Me.ToolTip1.SetToolTip(Me.dtpFinal, "Seleccionar fecha final del tratamiento")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 20)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "CI"
        '
        'txtCI
        '
        Me.txtCI.Location = New System.Drawing.Point(103, 19)
        Me.txtCI.MaxLength = 8
        Me.txtCI.Name = "txtCI"
        Me.txtCI.Size = New System.Drawing.Size(208, 20)
        Me.txtCI.TabIndex = 70
        Me.ToolTip1.SetToolTip(Me.txtCI, "Ingresar cédula de identidad del paciente")
        '
        'cmdBuscar
        '
        Me.cmdBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdBuscar.Location = New System.Drawing.Point(327, 12)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(102, 33)
        Me.cmdBuscar.TabIndex = 71
        Me.cmdBuscar.Text = "Buscar"
        Me.ToolTip1.SetToolTip(Me.cmdBuscar, "Buscar cédula de identidad del paciente")
        Me.cmdBuscar.UseVisualStyleBackColor = False
        '
        'gbBuscar
        '
        Me.gbBuscar.BackColor = System.Drawing.Color.Transparent
        Me.gbBuscar.Controls.Add(Me.txtCI)
        Me.gbBuscar.Controls.Add(Me.cmdBuscar)
        Me.gbBuscar.Controls.Add(Me.Label1)
        Me.gbBuscar.Location = New System.Drawing.Point(12, 12)
        Me.gbBuscar.Name = "gbBuscar"
        Me.gbBuscar.Size = New System.Drawing.Size(440, 57)
        Me.gbBuscar.TabIndex = 72
        Me.gbBuscar.TabStop = False
        Me.gbBuscar.Text = "BUSCAR PACIENTE"
        '
        'gbDatos
        '
        Me.gbDatos.BackColor = System.Drawing.Color.Transparent
        Me.gbDatos.Controls.Add(Me.txtNula)
        Me.gbDatos.Controls.Add(Me.cbFechaFinal)
        Me.gbDatos.Controls.Add(Me.cmdCancelar)
        Me.gbDatos.Controls.Add(Me.lblNombre)
        Me.gbDatos.Controls.Add(Me.txtNombre)
        Me.gbDatos.Controls.Add(Me.dtpInicio)
        Me.gbDatos.Controls.Add(Me.dtpFinal)
        Me.gbDatos.Controls.Add(Me.cmdIngresar)
        Me.gbDatos.Controls.Add(Me.txtDescripción)
        Me.gbDatos.Controls.Add(Me.lblFechaIN)
        Me.gbDatos.Controls.Add(Me.lblFechaFin)
        Me.gbDatos.Controls.Add(Me.lblDescripción)
        Me.gbDatos.Location = New System.Drawing.Point(12, 93)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(575, 329)
        Me.gbDatos.TabIndex = 73
        Me.gbDatos.TabStop = False
        Me.gbDatos.Text = "INGRESAR DATOS TRATAMIENTO"
        Me.gbDatos.Visible = False
        '
        'txtNula
        '
        Me.txtNula.Enabled = False
        Me.txtNula.Location = New System.Drawing.Point(103, 108)
        Me.txtNula.MaxLength = 30
        Me.txtNula.Name = "txtNula"
        Me.txtNula.Size = New System.Drawing.Size(208, 20)
        Me.txtNula.TabIndex = 83
        Me.txtNula.Text = "NULA"
        Me.txtNula.Visible = False
        '
        'cbFechaFinal
        '
        Me.cbFechaFinal.AutoSize = True
        Me.cbFechaFinal.Location = New System.Drawing.Point(315, 111)
        Me.cbFechaFinal.Name = "cbFechaFinal"
        Me.cbFechaFinal.Size = New System.Drawing.Size(48, 17)
        Me.cbFechaFinal.TabIndex = 82
        Me.cbFechaFinal.Text = "Nula"
        Me.ToolTip1.SetToolTip(Me.cbFechaFinal, "Elegir si la fecha final es nula")
        Me.cbFechaFinal.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdCancelar.Location = New System.Drawing.Point(139, 273)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(102, 33)
        Me.cmdCancelar.TabIndex = 81
        Me.cmdCancelar.Text = "Cancelar"
        Me.ToolTip1.SetToolTip(Me.cmdCancelar, "Cancelar ingreso de datos")
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'frmTratamiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.the_background_292720
        Me.ClientSize = New System.Drawing.Size(634, 511)
        Me.Controls.Add(Me.gbBuscar)
        Me.Controls.Add(Me.gbDatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTratamiento"
        Me.Text = "TRATAMIENTO"
        Me.gbBuscar.ResumeLayout(False)
        Me.gbBuscar.PerformLayout()
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblFechaIN As System.Windows.Forms.Label
    Friend WithEvents lblFechaFin As System.Windows.Forms.Label
    Friend WithEvents txtDescripción As System.Windows.Forms.TextBox
    Friend WithEvents lblDescripción As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents cmdIngresar As System.Windows.Forms.Button
    Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCI As System.Windows.Forms.TextBox
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents gbBuscar As System.Windows.Forms.GroupBox
    Friend WithEvents gbDatos As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cbFechaFinal As System.Windows.Forms.CheckBox
    Friend WithEvents txtNula As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
