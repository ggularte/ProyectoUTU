<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuario))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdIngresarM = New System.Windows.Forms.Button()
        Me.lblCContrasena = New System.Windows.Forms.Label()
        Me.gbRadio = New System.Windows.Forms.GroupBox()
        Me.rbAuxiliarMedico = New System.Windows.Forms.RadioButton()
        Me.rbMedico = New System.Windows.Forms.RadioButton()
        Me.cmdIngresar = New System.Windows.Forms.Button()
        Me.lblContraseniaMSG = New System.Windows.Forms.Label()
        Me.txtCContrasena = New System.Windows.Forms.TextBox()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lblUsuarioMSG = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.gbRadio.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(272, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "USUARIO"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblUsuarioMSG)
        Me.GroupBox1.Controls.Add(Me.cmdIngresarM)
        Me.GroupBox1.Controls.Add(Me.lblCContrasena)
        Me.GroupBox1.Controls.Add(Me.gbRadio)
        Me.GroupBox1.Controls.Add(Me.cmdIngresar)
        Me.GroupBox1.Controls.Add(Me.lblContraseniaMSG)
        Me.GroupBox1.Controls.Add(Me.txtCContrasena)
        Me.GroupBox1.Controls.Add(Me.txtContrasena)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtUsuario)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(618, 300)
        Me.GroupBox1.TabIndex = 86
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INGRESAR DATOS"
        '
        'cmdIngresarM
        '
        Me.cmdIngresarM.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdIngresarM.BackColor = System.Drawing.SystemColors.HotTrack
        Me.cmdIngresarM.Enabled = False
        Me.cmdIngresarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdIngresarM.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdIngresarM.ForeColor = System.Drawing.Color.White
        Me.cmdIngresarM.Location = New System.Drawing.Point(210, 248)
        Me.cmdIngresarM.Name = "cmdIngresarM"
        Me.cmdIngresarM.Size = New System.Drawing.Size(198, 41)
        Me.cmdIngresarM.TabIndex = 94
        Me.cmdIngresarM.Text = "INGRESAR"
        Me.cmdIngresarM.UseVisualStyleBackColor = False
        Me.cmdIngresarM.Visible = False
        '
        'lblCContrasena
        '
        Me.lblCContrasena.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCContrasena.BackColor = System.Drawing.Color.Transparent
        Me.lblCContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCContrasena.ForeColor = System.Drawing.Color.Red
        Me.lblCContrasena.Location = New System.Drawing.Point(197, 179)
        Me.lblCContrasena.Name = "lblCContrasena"
        Me.lblCContrasena.Size = New System.Drawing.Size(236, 22)
        Me.lblCContrasena.TabIndex = 93
        Me.lblCContrasena.Text = "Las contraseñas no coinciden."
        '
        'gbRadio
        '
        Me.gbRadio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.gbRadio.Controls.Add(Me.rbAuxiliarMedico)
        Me.gbRadio.Controls.Add(Me.rbMedico)
        Me.gbRadio.ForeColor = System.Drawing.Color.Transparent
        Me.gbRadio.Location = New System.Drawing.Point(228, 195)
        Me.gbRadio.Name = "gbRadio"
        Me.gbRadio.Size = New System.Drawing.Size(169, 32)
        Me.gbRadio.TabIndex = 87
        Me.gbRadio.TabStop = False
        Me.gbRadio.Visible = False
        '
        'rbAuxiliarMedico
        '
        Me.rbAuxiliarMedico.AutoSize = True
        Me.rbAuxiliarMedico.BackColor = System.Drawing.Color.Transparent
        Me.rbAuxiliarMedico.Location = New System.Drawing.Point(73, 11)
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
        'cmdIngresar
        '
        Me.cmdIngresar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdIngresar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.cmdIngresar.Enabled = False
        Me.cmdIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdIngresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdIngresar.ForeColor = System.Drawing.Color.White
        Me.cmdIngresar.Location = New System.Drawing.Point(210, 248)
        Me.cmdIngresar.Name = "cmdIngresar"
        Me.cmdIngresar.Size = New System.Drawing.Size(198, 41)
        Me.cmdIngresar.TabIndex = 74
        Me.cmdIngresar.Text = "INGRESAR"
        Me.cmdIngresar.UseVisualStyleBackColor = False
        Me.cmdIngresar.Visible = False
        '
        'lblContraseniaMSG
        '
        Me.lblContraseniaMSG.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblContraseniaMSG.BackColor = System.Drawing.Color.Transparent
        Me.lblContraseniaMSG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContraseniaMSG.ForeColor = System.Drawing.Color.Red
        Me.lblContraseniaMSG.Location = New System.Drawing.Point(18, 113)
        Me.lblContraseniaMSG.Name = "lblContraseniaMSG"
        Me.lblContraseniaMSG.Size = New System.Drawing.Size(600, 24)
        Me.lblContraseniaMSG.TabIndex = 92
        Me.lblContraseniaMSG.Text = "La contraseña debe de tener un mínimo de 8 carácteres y máximo de 24 carácteres. " & _
    ""
        '
        'txtCContrasena
        '
        Me.txtCContrasena.Location = New System.Drawing.Point(239, 158)
        Me.txtCContrasena.Name = "txtCContrasena"
        Me.txtCContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCContrasena.Size = New System.Drawing.Size(148, 20)
        Me.txtCContrasena.TabIndex = 89
        '
        'txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(239, 90)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContrasena.Size = New System.Drawing.Size(148, 20)
        Me.txtContrasena.TabIndex = 88
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(199, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(220, 20)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "CONFIRMAR CONTRASEÑA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(250, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 20)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "CONTRASEÑA"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(239, 32)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(148, 20)
        Me.txtUsuario.TabIndex = 85
        '
        'lblUsuarioMSG
        '
        Me.lblUsuarioMSG.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblUsuarioMSG.AutoSize = True
        Me.lblUsuarioMSG.BackColor = System.Drawing.Color.Transparent
        Me.lblUsuarioMSG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarioMSG.ForeColor = System.Drawing.Color.Red
        Me.lblUsuarioMSG.Location = New System.Drawing.Point(18, 55)
        Me.lblUsuarioMSG.Name = "lblUsuarioMSG"
        Me.lblUsuarioMSG.Size = New System.Drawing.Size(560, 16)
        Me.lblUsuarioMSG.TabIndex = 95
        Me.lblUsuarioMSG.Text = "El usuario debe de tener un mínimo de 4 carácteres y máximo de 16 carácteres. "
        '
        'frmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.the_background_292720
        Me.ClientSize = New System.Drawing.Size(660, 324)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUsuario"
        Me.Text = "INGRESAR USUARIO"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbRadio.ResumeLayout(False)
        Me.gbRadio.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtCContrasena As System.Windows.Forms.TextBox
    Friend WithEvents txtContrasena As System.Windows.Forms.TextBox
    Friend WithEvents lblContraseniaMSG As System.Windows.Forms.Label
    Friend WithEvents lblCContrasena As System.Windows.Forms.Label
    Friend WithEvents cmdIngresar As System.Windows.Forms.Button
    Friend WithEvents gbRadio As System.Windows.Forms.GroupBox
    Friend WithEvents rbAuxiliarMedico As System.Windows.Forms.RadioButton
    Friend WithEvents rbMedico As System.Windows.Forms.RadioButton
    Friend WithEvents cmdIngresarM As System.Windows.Forms.Button
    Friend WithEvents lblUsuarioMSG As System.Windows.Forms.Label
End Class
