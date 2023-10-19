<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMedico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMedico))
        Me.gbDatos = New System.Windows.Forms.GroupBox()
        Me.txtEspecialidad = New System.Windows.Forms.TextBox()
        Me.cmdIngresar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.lblEspecialidad = New System.Windows.Forms.Label()
        Me.lblTipoPersonal = New System.Windows.Forms.Label()
        Me.gbRadio = New System.Windows.Forms.GroupBox()
        Me.rbAuxiliarMedico = New System.Windows.Forms.RadioButton()
        Me.rbMedico = New System.Windows.Forms.RadioButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbDatos.SuspendLayout()
        Me.gbRadio.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbDatos
        '
        Me.gbDatos.BackColor = System.Drawing.Color.Transparent
        Me.gbDatos.Controls.Add(Me.txtEspecialidad)
        Me.gbDatos.Controls.Add(Me.cmdIngresar)
        Me.gbDatos.Controls.Add(Me.cmdCancelar)
        Me.gbDatos.Controls.Add(Me.lblEspecialidad)
        Me.gbDatos.Controls.Add(Me.lblTipoPersonal)
        Me.gbDatos.Controls.Add(Me.gbRadio)
        Me.gbDatos.Location = New System.Drawing.Point(12, 12)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(610, 97)
        Me.gbDatos.TabIndex = 77
        Me.gbDatos.TabStop = False
        Me.gbDatos.Text = "INGRESAR DATOS"
        '
        'txtEspecialidad
        '
        Me.txtEspecialidad.Location = New System.Drawing.Point(143, 61)
        Me.txtEspecialidad.MaxLength = 25
        Me.txtEspecialidad.Name = "txtEspecialidad"
        Me.txtEspecialidad.Size = New System.Drawing.Size(147, 20)
        Me.txtEspecialidad.TabIndex = 78
        Me.ToolTip1.SetToolTip(Me.txtEspecialidad, "Ingresar especialidad del médico")
        Me.txtEspecialidad.Visible = False
        '
        'cmdIngresar
        '
        Me.cmdIngresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdIngresar.Location = New System.Drawing.Point(393, 19)
        Me.cmdIngresar.Name = "cmdIngresar"
        Me.cmdIngresar.Size = New System.Drawing.Size(102, 33)
        Me.cmdIngresar.TabIndex = 71
        Me.cmdIngresar.Text = "Ingresar"
        Me.ToolTip1.SetToolTip(Me.cmdIngresar, "Alta médico")
        Me.cmdIngresar.UseVisualStyleBackColor = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdCancelar.Location = New System.Drawing.Point(502, 19)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(102, 33)
        Me.cmdCancelar.TabIndex = 77
        Me.cmdCancelar.Text = "Cancelar"
        Me.ToolTip1.SetToolTip(Me.cmdCancelar, "Cancelar ingreso de datos")
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'lblEspecialidad
        '
        Me.lblEspecialidad.AutoSize = True
        Me.lblEspecialidad.BackColor = System.Drawing.Color.Transparent
        Me.lblEspecialidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEspecialidad.Location = New System.Drawing.Point(2, 61)
        Me.lblEspecialidad.Name = "lblEspecialidad"
        Me.lblEspecialidad.Size = New System.Drawing.Size(99, 20)
        Me.lblEspecialidad.TabIndex = 69
        Me.lblEspecialidad.Text = "Especialidad"
        Me.lblEspecialidad.Visible = False
        '
        'lblTipoPersonal
        '
        Me.lblTipoPersonal.AutoSize = True
        Me.lblTipoPersonal.BackColor = System.Drawing.Color.Transparent
        Me.lblTipoPersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoPersonal.Location = New System.Drawing.Point(2, 28)
        Me.lblTipoPersonal.Name = "lblTipoPersonal"
        Me.lblTipoPersonal.Size = New System.Drawing.Size(104, 20)
        Me.lblTipoPersonal.TabIndex = 65
        Me.lblTipoPersonal.Text = "Tipo personal"
        '
        'gbRadio
        '
        Me.gbRadio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.gbRadio.Controls.Add(Me.rbAuxiliarMedico)
        Me.gbRadio.Controls.Add(Me.rbMedico)
        Me.gbRadio.ForeColor = System.Drawing.Color.Transparent
        Me.gbRadio.Location = New System.Drawing.Point(143, 19)
        Me.gbRadio.Name = "gbRadio"
        Me.gbRadio.Size = New System.Drawing.Size(244, 32)
        Me.gbRadio.TabIndex = 79
        Me.gbRadio.TabStop = False
        Me.ToolTip1.SetToolTip(Me.gbRadio, "Seleccionar tipo de personal médico")
        '
        'rbAuxiliarMedico
        '
        Me.rbAuxiliarMedico.AutoSize = True
        Me.rbAuxiliarMedico.BackColor = System.Drawing.Color.Transparent
        Me.rbAuxiliarMedico.Location = New System.Drawing.Point(139, 11)
        Me.rbAuxiliarMedico.Name = "rbAuxiliarMedico"
        Me.rbAuxiliarMedico.Size = New System.Drawing.Size(96, 17)
        Me.rbAuxiliarMedico.TabIndex = 67
        Me.rbAuxiliarMedico.TabStop = True
        Me.rbAuxiliarMedico.Text = "Auxiliar Médico"
        Me.rbAuxiliarMedico.UseVisualStyleBackColor = False
        '
        'rbMedico
        '
        Me.rbMedico.AutoSize = True
        Me.rbMedico.BackColor = System.Drawing.Color.Transparent
        Me.rbMedico.Location = New System.Drawing.Point(7, 11)
        Me.rbMedico.Name = "rbMedico"
        Me.rbMedico.Size = New System.Drawing.Size(60, 17)
        Me.rbMedico.TabIndex = 66
        Me.rbMedico.TabStop = True
        Me.rbMedico.Text = "Médico"
        Me.rbMedico.UseVisualStyleBackColor = False
        '
        'frmMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.the_background_292720
        Me.ClientSize = New System.Drawing.Size(634, 125)
        Me.Controls.Add(Me.gbDatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMedico"
        Me.Text = "INGRESAR PACIENTE COMO PERSONAL MÉDICO"
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        Me.gbRadio.ResumeLayout(False)
        Me.gbRadio.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbDatos As System.Windows.Forms.GroupBox
    Friend WithEvents txtEspecialidad As System.Windows.Forms.TextBox
    Friend WithEvents cmdIngresar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents lblEspecialidad As System.Windows.Forms.Label
    Friend WithEvents lblTipoPersonal As System.Windows.Forms.Label
    Friend WithEvents gbRadio As System.Windows.Forms.GroupBox
    Friend WithEvents rbAuxiliarMedico As System.Windows.Forms.RadioButton
    Friend WithEvents rbMedico As System.Windows.Forms.RadioButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
