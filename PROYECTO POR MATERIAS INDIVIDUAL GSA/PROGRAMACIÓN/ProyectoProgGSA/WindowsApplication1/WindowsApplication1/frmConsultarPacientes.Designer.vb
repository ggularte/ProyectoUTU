<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultarPacientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultarPacientes))
        Me.gbBuscar = New System.Windows.Forms.GroupBox()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.txtBCI = New System.Windows.Forms.TextBox()
        Me.lblBCI = New System.Windows.Forms.Label()
        Me.gbDatos = New System.Windows.Forms.GroupBox()
        Me.cbTelefono = New System.Windows.Forms.ComboBox()
        Me.txtSexo = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txtEcivil = New System.Windows.Forms.TextBox()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.dtpFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.lblEsquina = New System.Windows.Forms.Label()
        Me.txtNpuerta = New System.Windows.Forms.TextBox()
        Me.txtSapellido = New System.Windows.Forms.TextBox()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.lblFechaNac = New System.Windows.Forms.Label()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtSnombre = New System.Windows.Forms.TextBox()
        Me.lblSapellido = New System.Windows.Forms.Label()
        Me.lblSnombre = New System.Windows.Forms.Label()
        Me.txtPapellido = New System.Windows.Forms.TextBox()
        Me.lblPapellido = New System.Windows.Forms.Label()
        Me.lblNpuerta = New System.Windows.Forms.Label()
        Me.lblPnombre = New System.Windows.Forms.Label()
        Me.txtEsquina = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.lblCalle = New System.Windows.Forms.Label()
        Me.txtPnombre = New System.Windows.Forms.TextBox()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.lblEcivil = New System.Windows.Forms.Label()
        Me.gbBuscar.SuspendLayout()
        Me.gbDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbBuscar
        '
        Me.gbBuscar.BackColor = System.Drawing.Color.Transparent
        Me.gbBuscar.Controls.Add(Me.cmdBuscar)
        Me.gbBuscar.Controls.Add(Me.txtBCI)
        Me.gbBuscar.Controls.Add(Me.lblBCI)
        Me.gbBuscar.Location = New System.Drawing.Point(12, 12)
        Me.gbBuscar.Name = "gbBuscar"
        Me.gbBuscar.Size = New System.Drawing.Size(418, 59)
        Me.gbBuscar.TabIndex = 78
        Me.gbBuscar.TabStop = False
        Me.gbBuscar.Text = "Buscar"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdBuscar.Location = New System.Drawing.Point(274, 14)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(102, 33)
        Me.cmdBuscar.TabIndex = 2
        Me.cmdBuscar.Text = "Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = False
        '
        'txtBCI
        '
        Me.txtBCI.Location = New System.Drawing.Point(37, 19)
        Me.txtBCI.MaxLength = 8
        Me.txtBCI.Name = "txtBCI"
        Me.txtBCI.Size = New System.Drawing.Size(211, 20)
        Me.txtBCI.TabIndex = 20
        '
        'lblBCI
        '
        Me.lblBCI.AutoSize = True
        Me.lblBCI.BackColor = System.Drawing.Color.Transparent
        Me.lblBCI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBCI.Location = New System.Drawing.Point(6, 19)
        Me.lblBCI.Name = "lblBCI"
        Me.lblBCI.Size = New System.Drawing.Size(25, 20)
        Me.lblBCI.TabIndex = 4
        Me.lblBCI.Text = "CI"
        '
        'gbDatos
        '
        Me.gbDatos.BackColor = System.Drawing.Color.Transparent
        Me.gbDatos.Controls.Add(Me.cbTelefono)
        Me.gbDatos.Controls.Add(Me.txtSexo)
        Me.gbDatos.Controls.Add(Me.lblTelefono)
        Me.gbDatos.Controls.Add(Me.txtEcivil)
        Me.gbDatos.Controls.Add(Me.cmdCancelar)
        Me.gbDatos.Controls.Add(Me.dtpFechaNac)
        Me.gbDatos.Controls.Add(Me.lblEsquina)
        Me.gbDatos.Controls.Add(Me.txtNpuerta)
        Me.gbDatos.Controls.Add(Me.txtSapellido)
        Me.gbDatos.Controls.Add(Me.lblMail)
        Me.gbDatos.Controls.Add(Me.lblFechaNac)
        Me.gbDatos.Controls.Add(Me.txtEdad)
        Me.gbDatos.Controls.Add(Me.txtSnombre)
        Me.gbDatos.Controls.Add(Me.lblSapellido)
        Me.gbDatos.Controls.Add(Me.lblSnombre)
        Me.gbDatos.Controls.Add(Me.txtPapellido)
        Me.gbDatos.Controls.Add(Me.lblPapellido)
        Me.gbDatos.Controls.Add(Me.lblNpuerta)
        Me.gbDatos.Controls.Add(Me.lblPnombre)
        Me.gbDatos.Controls.Add(Me.txtEsquina)
        Me.gbDatos.Controls.Add(Me.txtCorreo)
        Me.gbDatos.Controls.Add(Me.txtCalle)
        Me.gbDatos.Controls.Add(Me.lblEdad)
        Me.gbDatos.Controls.Add(Me.lblCalle)
        Me.gbDatos.Controls.Add(Me.txtPnombre)
        Me.gbDatos.Controls.Add(Me.lblSexo)
        Me.gbDatos.Controls.Add(Me.lblEcivil)
        Me.gbDatos.Location = New System.Drawing.Point(12, 78)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(610, 351)
        Me.gbDatos.TabIndex = 79
        Me.gbDatos.TabStop = False
        Me.gbDatos.Text = "Datos"
        Me.gbDatos.Visible = False
        '
        'cbTelefono
        '
        Me.cbTelefono.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTelefono.FormattingEnabled = True
        Me.cbTelefono.Location = New System.Drawing.Point(155, 266)
        Me.cbTelefono.MaxLength = 9
        Me.cbTelefono.Name = "cbTelefono"
        Me.cbTelefono.Size = New System.Drawing.Size(141, 21)
        Me.cbTelefono.TabIndex = 83
        '
        'txtSexo
        '
        Me.txtSexo.Enabled = False
        Me.txtSexo.Location = New System.Drawing.Point(446, 135)
        Me.txtSexo.MaxLength = 20
        Me.txtSexo.Name = "txtSexo"
        Me.txtSexo.Size = New System.Drawing.Size(141, 20)
        Me.txtSexo.TabIndex = 88
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.BackColor = System.Drawing.Color.Transparent
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(4, 267)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(71, 20)
        Me.lblTelefono.TabIndex = 82
        Me.lblTelefono.Text = "Teléfono"
        '
        'txtEcivil
        '
        Me.txtEcivil.Enabled = False
        Me.txtEcivil.Location = New System.Drawing.Point(156, 134)
        Me.txtEcivil.MaxLength = 20
        Me.txtEcivil.Name = "txtEcivil"
        Me.txtEcivil.Size = New System.Drawing.Size(141, 20)
        Me.txtEcivil.TabIndex = 87
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdCancelar.Location = New System.Drawing.Point(10, 306)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(102, 33)
        Me.cmdCancelar.TabIndex = 80
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'dtpFechaNac
        '
        Me.dtpFechaNac.Enabled = False
        Me.dtpFechaNac.Location = New System.Drawing.Point(156, 97)
        Me.dtpFechaNac.Name = "dtpFechaNac"
        Me.dtpFechaNac.Size = New System.Drawing.Size(141, 20)
        Me.dtpFechaNac.TabIndex = 79
        '
        'lblEsquina
        '
        Me.lblEsquina.AutoSize = True
        Me.lblEsquina.BackColor = System.Drawing.Color.Transparent
        Me.lblEsquina.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEsquina.Location = New System.Drawing.Point(303, 219)
        Me.lblEsquina.Name = "lblEsquina"
        Me.lblEsquina.Size = New System.Drawing.Size(67, 20)
        Me.lblEsquina.TabIndex = 75
        Me.lblEsquina.Text = "Esquina"
        '
        'txtNpuerta
        '
        Me.txtNpuerta.Enabled = False
        Me.txtNpuerta.Location = New System.Drawing.Point(155, 221)
        Me.txtNpuerta.MaxLength = 10
        Me.txtNpuerta.Name = "txtNpuerta"
        Me.txtNpuerta.Size = New System.Drawing.Size(142, 20)
        Me.txtNpuerta.TabIndex = 38
        '
        'txtSapellido
        '
        Me.txtSapellido.Enabled = False
        Me.txtSapellido.Location = New System.Drawing.Point(445, 59)
        Me.txtSapellido.MaxLength = 20
        Me.txtSapellido.Name = "txtSapellido"
        Me.txtSapellido.Size = New System.Drawing.Size(142, 20)
        Me.txtSapellido.TabIndex = 25
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.BackColor = System.Drawing.Color.Transparent
        Me.lblMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMail.Location = New System.Drawing.Point(6, 177)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(53, 20)
        Me.lblMail.TabIndex = 10
        Me.lblMail.Text = "E-Mail"
        '
        'lblFechaNac
        '
        Me.lblFechaNac.AutoSize = True
        Me.lblFechaNac.BackColor = System.Drawing.Color.Transparent
        Me.lblFechaNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNac.Location = New System.Drawing.Point(6, 95)
        Me.lblFechaNac.Name = "lblFechaNac"
        Me.lblFechaNac.Size = New System.Drawing.Size(135, 20)
        Me.lblFechaNac.TabIndex = 78
        Me.lblFechaNac.Text = "Fecha nacimiento"
        '
        'txtEdad
        '
        Me.txtEdad.Enabled = False
        Me.txtEdad.Location = New System.Drawing.Point(445, 97)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(142, 20)
        Me.txtEdad.TabIndex = 22
        '
        'txtSnombre
        '
        Me.txtSnombre.Enabled = False
        Me.txtSnombre.Location = New System.Drawing.Point(445, 17)
        Me.txtSnombre.MaxLength = 20
        Me.txtSnombre.Name = "txtSnombre"
        Me.txtSnombre.Size = New System.Drawing.Size(142, 20)
        Me.txtSnombre.TabIndex = 19
        '
        'lblSapellido
        '
        Me.lblSapellido.AutoSize = True
        Me.lblSapellido.BackColor = System.Drawing.Color.Transparent
        Me.lblSapellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSapellido.Location = New System.Drawing.Point(303, 59)
        Me.lblSapellido.Name = "lblSapellido"
        Me.lblSapellido.Size = New System.Drawing.Size(132, 20)
        Me.lblSapellido.TabIndex = 14
        Me.lblSapellido.Text = "Segundo apellido"
        '
        'lblSnombre
        '
        Me.lblSnombre.AutoSize = True
        Me.lblSnombre.BackColor = System.Drawing.Color.Transparent
        Me.lblSnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSnombre.Location = New System.Drawing.Point(303, 17)
        Me.lblSnombre.Name = "lblSnombre"
        Me.lblSnombre.Size = New System.Drawing.Size(132, 20)
        Me.lblSnombre.TabIndex = 17
        Me.lblSnombre.Text = "Segundo nombre"
        '
        'txtPapellido
        '
        Me.txtPapellido.Enabled = False
        Me.txtPapellido.Location = New System.Drawing.Point(156, 60)
        Me.txtPapellido.MaxLength = 20
        Me.txtPapellido.Name = "txtPapellido"
        Me.txtPapellido.Size = New System.Drawing.Size(141, 20)
        Me.txtPapellido.TabIndex = 18
        '
        'lblPapellido
        '
        Me.lblPapellido.AutoSize = True
        Me.lblPapellido.BackColor = System.Drawing.Color.Transparent
        Me.lblPapellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPapellido.Location = New System.Drawing.Point(6, 60)
        Me.lblPapellido.Name = "lblPapellido"
        Me.lblPapellido.Size = New System.Drawing.Size(112, 20)
        Me.lblPapellido.TabIndex = 16
        Me.lblPapellido.Text = "Primer apellido"
        '
        'lblNpuerta
        '
        Me.lblNpuerta.AutoSize = True
        Me.lblNpuerta.BackColor = System.Drawing.Color.Transparent
        Me.lblNpuerta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNpuerta.Location = New System.Drawing.Point(6, 219)
        Me.lblNpuerta.Name = "lblNpuerta"
        Me.lblNpuerta.Size = New System.Drawing.Size(77, 20)
        Me.lblNpuerta.TabIndex = 37
        Me.lblNpuerta.Text = "Nº Puerta"
        '
        'lblPnombre
        '
        Me.lblPnombre.AutoSize = True
        Me.lblPnombre.BackColor = System.Drawing.Color.Transparent
        Me.lblPnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPnombre.Location = New System.Drawing.Point(6, 17)
        Me.lblPnombre.Name = "lblPnombre"
        Me.lblPnombre.Size = New System.Drawing.Size(112, 20)
        Me.lblPnombre.TabIndex = 15
        Me.lblPnombre.Text = "Primer nombre"
        '
        'txtEsquina
        '
        Me.txtEsquina.Enabled = False
        Me.txtEsquina.Location = New System.Drawing.Point(445, 221)
        Me.txtEsquina.MaxLength = 25
        Me.txtEsquina.Name = "txtEsquina"
        Me.txtEsquina.Size = New System.Drawing.Size(142, 20)
        Me.txtEsquina.TabIndex = 35
        '
        'txtCorreo
        '
        Me.txtCorreo.Enabled = False
        Me.txtCorreo.Location = New System.Drawing.Point(156, 177)
        Me.txtCorreo.MaxLength = 40
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(141, 20)
        Me.txtCorreo.TabIndex = 28
        '
        'txtCalle
        '
        Me.txtCalle.Enabled = False
        Me.txtCalle.Location = New System.Drawing.Point(445, 175)
        Me.txtCalle.MaxLength = 25
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(142, 20)
        Me.txtCalle.TabIndex = 23
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.BackColor = System.Drawing.Color.Transparent
        Me.lblEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdad.Location = New System.Drawing.Point(303, 95)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(47, 20)
        Me.lblEdad.TabIndex = 12
        Me.lblEdad.Text = "Edad"
        '
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.BackColor = System.Drawing.Color.Transparent
        Me.lblCalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalle.Location = New System.Drawing.Point(303, 177)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(44, 20)
        Me.lblCalle.TabIndex = 11
        Me.lblCalle.Text = "Calle"
        '
        'txtPnombre
        '
        Me.txtPnombre.Enabled = False
        Me.txtPnombre.Location = New System.Drawing.Point(156, 17)
        Me.txtPnombre.MaxLength = 20
        Me.txtPnombre.Name = "txtPnombre"
        Me.txtPnombre.Size = New System.Drawing.Size(141, 20)
        Me.txtPnombre.TabIndex = 3
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.BackColor = System.Drawing.Color.Transparent
        Me.lblSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.Location = New System.Drawing.Point(303, 135)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(45, 20)
        Me.lblSexo.TabIndex = 5
        Me.lblSexo.Text = "Sexo"
        '
        'lblEcivil
        '
        Me.lblEcivil.AutoSize = True
        Me.lblEcivil.BackColor = System.Drawing.Color.Transparent
        Me.lblEcivil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEcivil.Location = New System.Drawing.Point(4, 135)
        Me.lblEcivil.Name = "lblEcivil"
        Me.lblEcivil.Size = New System.Drawing.Size(88, 20)
        Me.lblEcivil.TabIndex = 9
        Me.lblEcivil.Text = "Estado civil"
        '
        'frmConsultarPacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.the_background_292720
        Me.ClientSize = New System.Drawing.Size(634, 511)
        Me.Controls.Add(Me.gbBuscar)
        Me.Controls.Add(Me.gbDatos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConsultarPacientes"
        Me.Text = "INFORMACIÓN PACIENTE"
        Me.gbBuscar.ResumeLayout(False)
        Me.gbBuscar.PerformLayout()
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbBuscar As System.Windows.Forms.GroupBox
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents txtBCI As System.Windows.Forms.TextBox
    Friend WithEvents lblBCI As System.Windows.Forms.Label
    Friend WithEvents gbDatos As System.Windows.Forms.GroupBox
    Friend WithEvents cbTelefono As System.Windows.Forms.ComboBox
    Friend WithEvents txtSexo As System.Windows.Forms.TextBox
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents txtEcivil As System.Windows.Forms.TextBox
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents dtpFechaNac As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblEsquina As System.Windows.Forms.Label
    Friend WithEvents txtNpuerta As System.Windows.Forms.TextBox
    Friend WithEvents txtSapellido As System.Windows.Forms.TextBox
    Friend WithEvents lblMail As System.Windows.Forms.Label
    Friend WithEvents lblFechaNac As System.Windows.Forms.Label
    Friend WithEvents txtEdad As System.Windows.Forms.TextBox
    Friend WithEvents txtSnombre As System.Windows.Forms.TextBox
    Friend WithEvents lblSapellido As System.Windows.Forms.Label
    Friend WithEvents lblSnombre As System.Windows.Forms.Label
    Friend WithEvents txtPapellido As System.Windows.Forms.TextBox
    Friend WithEvents lblPapellido As System.Windows.Forms.Label
    Friend WithEvents lblNpuerta As System.Windows.Forms.Label
    Friend WithEvents lblPnombre As System.Windows.Forms.Label
    Friend WithEvents txtEsquina As System.Windows.Forms.TextBox
    Friend WithEvents txtCorreo As System.Windows.Forms.TextBox
    Friend WithEvents txtCalle As System.Windows.Forms.TextBox
    Friend WithEvents lblEdad As System.Windows.Forms.Label
    Friend WithEvents lblCalle As System.Windows.Forms.Label
    Friend WithEvents txtPnombre As System.Windows.Forms.TextBox
    Friend WithEvents lblSexo As System.Windows.Forms.Label
    Friend WithEvents lblEcivil As System.Windows.Forms.Label
End Class
