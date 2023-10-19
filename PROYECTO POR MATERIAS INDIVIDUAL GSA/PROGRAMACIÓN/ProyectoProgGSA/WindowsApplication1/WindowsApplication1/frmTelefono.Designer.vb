<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTelefono
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTelefono))
        Me.cmdQuitar = New System.Windows.Forms.Button()
        Me.cbTelefono = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdAgregar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdAgregar2 = New System.Windows.Forms.Button()
        Me.cmdQuitar2 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdQuitar
        '
        Me.cmdQuitar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdQuitar.Location = New System.Drawing.Point(257, 48)
        Me.cmdQuitar.Name = "cmdQuitar"
        Me.cmdQuitar.Size = New System.Drawing.Size(102, 33)
        Me.cmdQuitar.TabIndex = 82
        Me.cmdQuitar.Text = "Quitar"
        Me.cmdQuitar.UseVisualStyleBackColor = False
        Me.cmdQuitar.Visible = False
        '
        'cbTelefono
        '
        Me.cbTelefono.FormattingEnabled = True
        Me.cbTelefono.Location = New System.Drawing.Point(101, 18)
        Me.cbTelefono.MaxLength = 9
        Me.cbTelefono.Name = "cbTelefono"
        Me.cbTelefono.Size = New System.Drawing.Size(141, 21)
        Me.cbTelefono.TabIndex = 81
        Me.ToolTip1.SetToolTip(Me.cbTelefono, "Ingresar o seleccionar teléfono")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Teléfono"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdAgregar.Location = New System.Drawing.Point(257, 11)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(102, 33)
        Me.cmdAgregar.TabIndex = 71
        Me.cmdAgregar.Text = "Agregar"
        Me.cmdAgregar.UseVisualStyleBackColor = False
        Me.cmdAgregar.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmdAgregar2)
        Me.GroupBox1.Controls.Add(Me.cmdQuitar2)
        Me.GroupBox1.Controls.Add(Me.cmdQuitar)
        Me.GroupBox1.Controls.Add(Me.cbTelefono)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmdAgregar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(373, 87)
        Me.GroupBox1.TabIndex = 85
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INGRESAR DATOS"
        '
        'cmdAgregar2
        '
        Me.cmdAgregar2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdAgregar2.Location = New System.Drawing.Point(257, 12)
        Me.cmdAgregar2.Name = "cmdAgregar2"
        Me.cmdAgregar2.Size = New System.Drawing.Size(102, 33)
        Me.cmdAgregar2.TabIndex = 84
        Me.cmdAgregar2.Text = "Agregar"
        Me.ToolTip1.SetToolTip(Me.cmdAgregar2, "Agregar teléfono")
        Me.cmdAgregar2.UseVisualStyleBackColor = False
        Me.cmdAgregar2.Visible = False
        '
        'cmdQuitar2
        '
        Me.cmdQuitar2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdQuitar2.Location = New System.Drawing.Point(257, 49)
        Me.cmdQuitar2.Name = "cmdQuitar2"
        Me.cmdQuitar2.Size = New System.Drawing.Size(102, 33)
        Me.cmdQuitar2.TabIndex = 83
        Me.cmdQuitar2.Text = "Quitar"
        Me.ToolTip1.SetToolTip(Me.cmdQuitar2, "Quitar teléfono")
        Me.cmdQuitar2.UseVisualStyleBackColor = False
        Me.cmdQuitar2.Visible = False
        '
        'frmTelefono
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.the_background_292720
        Me.ClientSize = New System.Drawing.Size(403, 111)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTelefono"
        Me.Text = "INGRESAR TELEFONO"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdQuitar As System.Windows.Forms.Button
    Friend WithEvents cbTelefono As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdAgregar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdQuitar2 As System.Windows.Forms.Button
    Friend WithEvents cmdAgregar2 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
