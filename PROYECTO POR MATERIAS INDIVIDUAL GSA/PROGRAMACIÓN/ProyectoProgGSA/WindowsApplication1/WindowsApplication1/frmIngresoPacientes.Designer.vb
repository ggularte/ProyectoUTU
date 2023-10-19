<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIngresoPacientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIngresoPacientes))
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.txtPnombre = New System.Windows.Forms.TextBox()
        Me.lblBCI = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.lblEcivil = New System.Windows.Forms.Label()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.lblCalle = New System.Windows.Forms.Label()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.lblSapellido = New System.Windows.Forms.Label()
        Me.lblPnombre = New System.Windows.Forms.Label()
        Me.lblPapellido = New System.Windows.Forms.Label()
        Me.lblSnombre = New System.Windows.Forms.Label()
        Me.txtPapellido = New System.Windows.Forms.TextBox()
        Me.txtSnombre = New System.Windows.Forms.TextBox()
        Me.txtBCI = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.txtSapellido = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.cbSexo = New System.Windows.Forms.ComboBox()
        Me.cbEcivil = New System.Windows.Forms.ComboBox()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdIngresar = New System.Windows.Forms.Button()
        Me.txtEsquina = New System.Windows.Forms.TextBox()
        Me.lblNpuerta = New System.Windows.Forms.Label()
        Me.txtNpuerta = New System.Windows.Forms.TextBox()
        Me.cmdModificar = New System.Windows.Forms.Button()
        Me.lblEsquina = New System.Windows.Forms.Label()
        Me.gbBuscar = New System.Windows.Forms.GroupBox()
        Me.gbDatos = New System.Windows.Forms.GroupBox()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.dtpFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaNac = New System.Windows.Forms.Label()
        Me.gbTelefono = New System.Windows.Forms.GroupBox()
        Me.cbTelefono = New System.Windows.Forms.ComboBox()
        Me.cmdQuitar = New System.Windows.Forms.Button()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.cmdAgregar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbBuscar.SuspendLayout()
        Me.gbDatos.SuspendLayout()
        Me.gbTelefono.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdBuscar
        '
        Me.cmdBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdBuscar.Location = New System.Drawing.Point(274, 14)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(102, 33)
        Me.cmdBuscar.TabIndex = 2
        Me.cmdBuscar.Text = "Buscar"
        Me.ToolTip1.SetToolTip(Me.cmdBuscar, "Buscar paciente")
        Me.cmdBuscar.UseVisualStyleBackColor = False
        '
        'txtPnombre
        '
        Me.txtPnombre.Location = New System.Drawing.Point(156, 17)
        Me.txtPnombre.MaxLength = 20
        Me.txtPnombre.Name = "txtPnombre"
        Me.txtPnombre.Size = New System.Drawing.Size(141, 20)
        Me.txtPnombre.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtPnombre, "Ingresar primer nombre del paciente")
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
        Me.txtPapellido.Location = New System.Drawing.Point(156, 60)
        Me.txtPapellido.MaxLength = 20
        Me.txtPapellido.Name = "txtPapellido"
        Me.txtPapellido.Size = New System.Drawing.Size(141, 20)
        Me.txtPapellido.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.txtPapellido, "Ingresar primer apellido del paciente")
        '
        'txtSnombre
        '
        Me.txtSnombre.Location = New System.Drawing.Point(445, 17)
        Me.txtSnombre.MaxLength = 20
        Me.txtSnombre.Name = "txtSnombre"
        Me.txtSnombre.Size = New System.Drawing.Size(142, 20)
        Me.txtSnombre.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.txtSnombre, "Ingresar segundo nombre del paciente")
        '
        'txtBCI
        '
        Me.txtBCI.Location = New System.Drawing.Point(37, 19)
        Me.txtBCI.MaxLength = 8
        Me.txtBCI.Name = "txtBCI"
        Me.txtBCI.Size = New System.Drawing.Size(211, 20)
        Me.txtBCI.TabIndex = 20
        Me.ToolTip1.SetToolTip(Me.txtBCI, "Ingresar cédula de identidad")
        '
        'txtEdad
        '
        Me.txtEdad.Enabled = False
        Me.txtEdad.Location = New System.Drawing.Point(445, 97)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(142, 20)
        Me.txtEdad.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.txtEdad, "Edad calculada a partir de la fecha de nacimiento")
        '
        'txtCalle
        '
        Me.txtCalle.Location = New System.Drawing.Point(445, 175)
        Me.txtCalle.MaxLength = 25
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(142, 20)
        Me.txtCalle.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.txtCalle, "Ingresar calle del domicilio del paciente")
        '
        'txtSapellido
        '
        Me.txtSapellido.Location = New System.Drawing.Point(445, 59)
        Me.txtSapellido.MaxLength = 20
        Me.txtSapellido.Name = "txtSapellido"
        Me.txtSapellido.Size = New System.Drawing.Size(142, 20)
        Me.txtSapellido.TabIndex = 25
        Me.ToolTip1.SetToolTip(Me.txtSapellido, "Ingresar segundo nombre del paciente")
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(156, 177)
        Me.txtCorreo.MaxLength = 40
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(141, 20)
        Me.txtCorreo.TabIndex = 28
        '
        'cbSexo
        '
        Me.cbSexo.FormattingEnabled = True
        Me.cbSexo.Location = New System.Drawing.Point(445, 134)
        Me.cbSexo.Name = "cbSexo"
        Me.cbSexo.Size = New System.Drawing.Size(142, 21)
        Me.cbSexo.TabIndex = 29
        Me.ToolTip1.SetToolTip(Me.cbSexo, "Seleccionar sexo del paciente")
        '
        'cbEcivil
        '
        Me.cbEcivil.FormattingEnabled = True
        Me.cbEcivil.Location = New System.Drawing.Point(156, 134)
        Me.cbEcivil.Name = "cbEcivil"
        Me.cbEcivil.Size = New System.Drawing.Size(141, 21)
        Me.cbEcivil.TabIndex = 31
        Me.ToolTip1.SetToolTip(Me.cbEcivil, "Seleccionar estado civil del paciente")
        '
        'cmdEliminar
        '
        Me.cmdEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdEliminar.Location = New System.Drawing.Point(192, 303)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(102, 33)
        Me.cmdEliminar.TabIndex = 32
        Me.cmdEliminar.Text = "Eliminar"
        Me.ToolTip1.SetToolTip(Me.cmdEliminar, "Eliminar paciente")
        Me.cmdEliminar.UseVisualStyleBackColor = False
        '
        'cmdIngresar
        '
        Me.cmdIngresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdIngresar.Location = New System.Drawing.Point(74, 303)
        Me.cmdIngresar.Name = "cmdIngresar"
        Me.cmdIngresar.Size = New System.Drawing.Size(102, 33)
        Me.cmdIngresar.TabIndex = 33
        Me.cmdIngresar.Text = "Ingresar"
        Me.ToolTip1.SetToolTip(Me.cmdIngresar, "Alta paciente")
        Me.cmdIngresar.UseVisualStyleBackColor = False
        '
        'txtEsquina
        '
        Me.txtEsquina.Location = New System.Drawing.Point(445, 221)
        Me.txtEsquina.MaxLength = 25
        Me.txtEsquina.Name = "txtEsquina"
        Me.txtEsquina.Size = New System.Drawing.Size(142, 20)
        Me.txtEsquina.TabIndex = 35
        Me.ToolTip1.SetToolTip(Me.txtEsquina, "Ingresar esquina del domicilio del paciente")
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
        'txtNpuerta
        '
        Me.txtNpuerta.Location = New System.Drawing.Point(155, 221)
        Me.txtNpuerta.MaxLength = 10
        Me.txtNpuerta.Name = "txtNpuerta"
        Me.txtNpuerta.Size = New System.Drawing.Size(142, 20)
        Me.txtNpuerta.TabIndex = 38
        Me.ToolTip1.SetToolTip(Me.txtNpuerta, "Ingresar número de puerta del domicilio del paciente")
        '
        'cmdModificar
        '
        Me.cmdModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdModificar.Location = New System.Drawing.Point(313, 303)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(102, 33)
        Me.cmdModificar.TabIndex = 74
        Me.cmdModificar.Text = "Modificar"
        Me.ToolTip1.SetToolTip(Me.cmdModificar, "Modificar paciente")
        Me.cmdModificar.UseVisualStyleBackColor = False
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
        'gbBuscar
        '
        Me.gbBuscar.BackColor = System.Drawing.Color.Transparent
        Me.gbBuscar.Controls.Add(Me.cmdBuscar)
        Me.gbBuscar.Controls.Add(Me.txtBCI)
        Me.gbBuscar.Controls.Add(Me.lblBCI)
        Me.gbBuscar.Location = New System.Drawing.Point(12, 25)
        Me.gbBuscar.Name = "gbBuscar"
        Me.gbBuscar.Size = New System.Drawing.Size(418, 59)
        Me.gbBuscar.TabIndex = 76
        Me.gbBuscar.TabStop = False
        Me.gbBuscar.Text = "Buscar"
        '
        'gbDatos
        '
        Me.gbDatos.BackColor = System.Drawing.Color.Transparent
        Me.gbDatos.Controls.Add(Me.cmdCancelar)
        Me.gbDatos.Controls.Add(Me.cmdModificar)
        Me.gbDatos.Controls.Add(Me.dtpFechaNac)
        Me.gbDatos.Controls.Add(Me.cmdEliminar)
        Me.gbDatos.Controls.Add(Me.cmdIngresar)
        Me.gbDatos.Controls.Add(Me.lblEsquina)
        Me.gbDatos.Controls.Add(Me.txtNpuerta)
        Me.gbDatos.Controls.Add(Me.txtSapellido)
        Me.gbDatos.Controls.Add(Me.lblMail)
        Me.gbDatos.Controls.Add(Me.lblFechaNac)
        Me.gbDatos.Controls.Add(Me.txtEdad)
        Me.gbDatos.Controls.Add(Me.txtSnombre)
        Me.gbDatos.Controls.Add(Me.cbEcivil)
        Me.gbDatos.Controls.Add(Me.lblSapellido)
        Me.gbDatos.Controls.Add(Me.lblSnombre)
        Me.gbDatos.Controls.Add(Me.txtPapellido)
        Me.gbDatos.Controls.Add(Me.lblPapellido)
        Me.gbDatos.Controls.Add(Me.lblNpuerta)
        Me.gbDatos.Controls.Add(Me.lblPnombre)
        Me.gbDatos.Controls.Add(Me.cbSexo)
        Me.gbDatos.Controls.Add(Me.txtEsquina)
        Me.gbDatos.Controls.Add(Me.txtCorreo)
        Me.gbDatos.Controls.Add(Me.txtCalle)
        Me.gbDatos.Controls.Add(Me.lblEdad)
        Me.gbDatos.Controls.Add(Me.lblCalle)
        Me.gbDatos.Controls.Add(Me.txtPnombre)
        Me.gbDatos.Controls.Add(Me.lblSexo)
        Me.gbDatos.Controls.Add(Me.lblEcivil)
        Me.gbDatos.Controls.Add(Me.gbTelefono)
        Me.gbDatos.Location = New System.Drawing.Point(12, 91)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(610, 351)
        Me.gbDatos.TabIndex = 77
        Me.gbDatos.TabStop = False
        Me.gbDatos.Text = "Datos"
        Me.gbDatos.Visible = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdCancelar.Location = New System.Drawing.Point(434, 303)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(102, 33)
        Me.cmdCancelar.TabIndex = 80
        Me.cmdCancelar.Text = "Cancelar"
        Me.ToolTip1.SetToolTip(Me.cmdCancelar, "Cancelar ingreso de datos")
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'dtpFechaNac
        '
        Me.dtpFechaNac.Location = New System.Drawing.Point(156, 97)
        Me.dtpFechaNac.Name = "dtpFechaNac"
        Me.dtpFechaNac.Size = New System.Drawing.Size(141, 20)
        Me.dtpFechaNac.TabIndex = 79
        Me.ToolTip1.SetToolTip(Me.dtpFechaNac, "Seleccionar fecha de nacimiento del paciente")
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
        'gbTelefono
        '
        Me.gbTelefono.Controls.Add(Me.cbTelefono)
        Me.gbTelefono.Controls.Add(Me.cmdQuitar)
        Me.gbTelefono.Controls.Add(Me.lblTelefono)
        Me.gbTelefono.Controls.Add(Me.cmdAgregar)
        Me.gbTelefono.Location = New System.Drawing.Point(8, 247)
        Me.gbTelefono.Name = "gbTelefono"
        Me.gbTelefono.Size = New System.Drawing.Size(579, 42)
        Me.gbTelefono.TabIndex = 86
        Me.gbTelefono.TabStop = False
        Me.gbTelefono.Text = "MODIFICAR TELEFONO"
        Me.gbTelefono.Visible = False
        '
        'cbTelefono
        '
        Me.cbTelefono.FormattingEnabled = True
        Me.cbTelefono.Location = New System.Drawing.Point(147, 13)
        Me.cbTelefono.MaxLength = 9
        Me.cbTelefono.Name = "cbTelefono"
        Me.cbTelefono.Size = New System.Drawing.Size(141, 21)
        Me.cbTelefono.TabIndex = 83
        Me.ToolTip1.SetToolTip(Me.cbTelefono, "Seleccionar estado civil del paciente")
        '
        'cmdQuitar
        '
        Me.cmdQuitar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdQuitar.Location = New System.Drawing.Point(445, 10)
        Me.cmdQuitar.Name = "cmdQuitar"
        Me.cmdQuitar.Size = New System.Drawing.Size(128, 26)
        Me.cmdQuitar.TabIndex = 85
        Me.cmdQuitar.Text = "Quitar"
        Me.cmdQuitar.UseVisualStyleBackColor = False
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.BackColor = System.Drawing.Color.Transparent
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(4, 16)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(71, 20)
        Me.lblTelefono.TabIndex = 82
        Me.lblTelefono.Text = "Teléfono"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdAgregar.Location = New System.Drawing.Point(299, 10)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(140, 26)
        Me.cmdAgregar.TabIndex = 84
        Me.cmdAgregar.Text = "Agregar"
        Me.cmdAgregar.UseVisualStyleBackColor = False
        '
        'frmIngresoPacientes
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
        Me.Name = "frmIngresoPacientes"
        Me.Text = "INGRESO PACIENTES"
        Me.gbBuscar.ResumeLayout(False)
        Me.gbBuscar.PerformLayout()
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        Me.gbTelefono.ResumeLayout(False)
        Me.gbTelefono.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents txtPnombre As System.Windows.Forms.TextBox
    Friend WithEvents lblBCI As System.Windows.Forms.Label
    Friend WithEvents lblSexo As System.Windows.Forms.Label
    Friend WithEvents lblEcivil As System.Windows.Forms.Label
    Friend WithEvents lblMail As System.Windows.Forms.Label
    Friend WithEvents lblCalle As System.Windows.Forms.Label
    Friend WithEvents lblEdad As System.Windows.Forms.Label
    Friend WithEvents lblSapellido As System.Windows.Forms.Label
    Friend WithEvents lblPnombre As System.Windows.Forms.Label
    Friend WithEvents lblPapellido As System.Windows.Forms.Label
    Friend WithEvents lblSnombre As System.Windows.Forms.Label
    Friend WithEvents txtPapellido As System.Windows.Forms.TextBox
    Friend WithEvents txtSnombre As System.Windows.Forms.TextBox
    Friend WithEvents txtBCI As System.Windows.Forms.TextBox
    Friend WithEvents txtEdad As System.Windows.Forms.TextBox
    Friend WithEvents txtCalle As System.Windows.Forms.TextBox
    Friend WithEvents txtSapellido As System.Windows.Forms.TextBox
    Friend WithEvents txtCorreo As System.Windows.Forms.TextBox
    Friend WithEvents cbSexo As System.Windows.Forms.ComboBox
    Friend WithEvents cbEcivil As System.Windows.Forms.ComboBox
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents cmdIngresar As System.Windows.Forms.Button
    Friend WithEvents txtEsquina As System.Windows.Forms.TextBox
    Friend WithEvents lblNpuerta As System.Windows.Forms.Label
    Friend WithEvents txtNpuerta As System.Windows.Forms.TextBox
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    Friend WithEvents lblEsquina As System.Windows.Forms.Label
    Friend WithEvents gbBuscar As System.Windows.Forms.GroupBox
    Friend WithEvents gbDatos As System.Windows.Forms.GroupBox
    Friend WithEvents lblFechaNac As System.Windows.Forms.Label
    Friend WithEvents dtpFechaNac As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents cbTelefono As System.Windows.Forms.ComboBox
    Friend WithEvents cmdQuitar As System.Windows.Forms.Button
    Friend WithEvents cmdAgregar As System.Windows.Forms.Button
    Friend WithEvents gbTelefono As System.Windows.Forms.GroupBox
End Class
