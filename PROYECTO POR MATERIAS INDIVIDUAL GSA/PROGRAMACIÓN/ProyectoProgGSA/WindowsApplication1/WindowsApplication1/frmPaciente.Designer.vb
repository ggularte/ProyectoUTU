<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaciente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPaciente))
        Me.gbDatos = New System.Windows.Forms.GroupBox()
        Me.cmdIngresar2 = New System.Windows.Forms.Button()
        Me.cbSexo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cbECivil = New System.Windows.Forms.ComboBox()
        Me.lblECivil = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbDatos
        '
        Me.gbDatos.BackColor = System.Drawing.Color.Transparent
        Me.gbDatos.Controls.Add(Me.cmdIngresar2)
        Me.gbDatos.Controls.Add(Me.cbSexo)
        Me.gbDatos.Controls.Add(Me.Label1)
        Me.gbDatos.Controls.Add(Me.cmdCancelar)
        Me.gbDatos.Controls.Add(Me.cbECivil)
        Me.gbDatos.Controls.Add(Me.lblECivil)
        Me.gbDatos.Location = New System.Drawing.Point(12, 12)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(373, 87)
        Me.gbDatos.TabIndex = 78
        Me.gbDatos.TabStop = False
        Me.gbDatos.Text = "INGRESAR DATOS"
        '
        'cmdIngresar2
        '
        Me.cmdIngresar2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdIngresar2.Location = New System.Drawing.Point(257, 12)
        Me.cmdIngresar2.Name = "cmdIngresar2"
        Me.cmdIngresar2.Size = New System.Drawing.Size(102, 33)
        Me.cmdIngresar2.TabIndex = 85
        Me.cmdIngresar2.Text = "Ingresar"
        Me.ToolTip1.SetToolTip(Me.cmdIngresar2, "Alta paciente")
        Me.cmdIngresar2.UseVisualStyleBackColor = False
        Me.cmdIngresar2.Visible = False
        '
        'cbSexo
        '
        Me.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSexo.FormattingEnabled = True
        Me.cbSexo.Location = New System.Drawing.Point(101, 52)
        Me.cbSexo.Name = "cbSexo"
        Me.cbSexo.Size = New System.Drawing.Size(141, 21)
        Me.cbSexo.TabIndex = 84
        Me.ToolTip1.SetToolTip(Me.cbSexo, "Seleccionar sexo del paciente")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 20)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Sexo"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdCancelar.Location = New System.Drawing.Point(257, 48)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(102, 33)
        Me.cmdCancelar.TabIndex = 82
        Me.cmdCancelar.Text = "Cancelar"
        Me.ToolTip1.SetToolTip(Me.cmdCancelar, "Cancelar ingreso de datos")
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cbECivil
        '
        Me.cbECivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbECivil.FormattingEnabled = True
        Me.cbECivil.Location = New System.Drawing.Point(101, 18)
        Me.cbECivil.Name = "cbECivil"
        Me.cbECivil.Size = New System.Drawing.Size(141, 21)
        Me.cbECivil.TabIndex = 81
        Me.ToolTip1.SetToolTip(Me.cbECivil, "Seleccionar estado civil del paciente")
        '
        'lblECivil
        '
        Me.lblECivil.AutoSize = True
        Me.lblECivil.BackColor = System.Drawing.Color.Transparent
        Me.lblECivil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblECivil.Location = New System.Drawing.Point(6, 19)
        Me.lblECivil.Name = "lblECivil"
        Me.lblECivil.Size = New System.Drawing.Size(88, 20)
        Me.lblECivil.TabIndex = 79
        Me.lblECivil.Text = "Estado civil"
        '
        'frmPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.the_background_292720
        Me.ClientSize = New System.Drawing.Size(403, 111)
        Me.Controls.Add(Me.gbDatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPaciente"
        Me.Text = "INGRESAR PERSONAL MÉDICO COMO PACIENTE"
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbDatos As System.Windows.Forms.GroupBox
    Friend WithEvents cbECivil As System.Windows.Forms.ComboBox
    Friend WithEvents lblECivil As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cbSexo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdIngresar2 As System.Windows.Forms.Button
End Class
