<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.cmdIngresar = New System.Windows.Forms.Button()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtContrasenia = New System.Windows.Forms.TextBox()
        Me.lblContraseniaMSG = New System.Windows.Forms.Label()
        Me.lblUsuarioMSG = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'txtUsuario
        '
        Me.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(229, 177)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(198, 31)
        Me.txtUsuario.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtUsuario, "Ingresar usuario")
        '
        'cmdIngresar
        '
        Me.cmdIngresar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdIngresar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.cmdIngresar.Enabled = False
        Me.cmdIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdIngresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdIngresar.Location = New System.Drawing.Point(229, 269)
        Me.cmdIngresar.Name = "cmdIngresar"
        Me.cmdIngresar.Size = New System.Drawing.Size(198, 36)
        Me.cmdIngresar.TabIndex = 4
        Me.cmdIngresar.Text = "INGRESAR"
        Me.ToolTip1.SetToolTip(Me.cmdIngresar, "Ingresar al sistema")
        Me.cmdIngresar.UseVisualStyleBackColor = False
        '
        'lblNombre
        '
        Me.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(110, 176)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(120, 29)
        Me.lblNombre.TabIndex = 69
        Me.lblNombre.Text = "USUARIO"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 220)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 29)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "CONTRASEÑA"
        '
        'txtContrasenia
        '
        Me.txtContrasenia.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtContrasenia.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContrasenia.Location = New System.Drawing.Point(229, 221)
        Me.txtContrasenia.Name = "txtContrasenia"
        Me.txtContrasenia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContrasenia.Size = New System.Drawing.Size(198, 31)
        Me.txtContrasenia.TabIndex = 71
        Me.ToolTip1.SetToolTip(Me.txtContrasenia, "Ingresar contraseña")
        '
        'lblContraseniaMSG
        '
        Me.lblContraseniaMSG.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblContraseniaMSG.AutoSize = True
        Me.lblContraseniaMSG.BackColor = System.Drawing.Color.Transparent
        Me.lblContraseniaMSG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContraseniaMSG.ForeColor = System.Drawing.Color.Red
        Me.lblContraseniaMSG.Location = New System.Drawing.Point(33, 345)
        Me.lblContraseniaMSG.Name = "lblContraseniaMSG"
        Me.lblContraseniaMSG.Size = New System.Drawing.Size(589, 16)
        Me.lblContraseniaMSG.TabIndex = 72
        Me.lblContraseniaMSG.Text = "La contraseña debe de tener un mínimo de 8 carácteres y máximo de 24 carácteres. " & _
    ""
        '
        'lblUsuarioMSG
        '
        Me.lblUsuarioMSG.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblUsuarioMSG.AutoSize = True
        Me.lblUsuarioMSG.BackColor = System.Drawing.Color.Transparent
        Me.lblUsuarioMSG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarioMSG.ForeColor = System.Drawing.Color.Red
        Me.lblUsuarioMSG.Location = New System.Drawing.Point(48, 320)
        Me.lblUsuarioMSG.Name = "lblUsuarioMSG"
        Me.lblUsuarioMSG.Size = New System.Drawing.Size(560, 16)
        Me.lblUsuarioMSG.TabIndex = 73
        Me.lblUsuarioMSG.Text = "El usuario debe de tener un mínimo de 4 carácteres y máximo de 16 carácteres. "
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.login
        Me.ClientSize = New System.Drawing.Size(634, 511)
        Me.Controls.Add(Me.lblUsuarioMSG)
        Me.Controls.Add(Me.lblContraseniaMSG)
        Me.Controls.Add(Me.txtContrasenia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.cmdIngresar)
        Me.Controls.Add(Me.txtUsuario)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.Text = "LOGIN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents cmdIngresar As System.Windows.Forms.Button
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtContrasenia As System.Windows.Forms.TextBox
    Friend WithEvents lblContraseniaMSG As System.Windows.Forms.Label
    Friend WithEvents lblUsuarioMSG As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
