<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmPersonalMedico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmPersonalMedico))
        Me.txtCI = New System.Windows.Forms.TextBox()
        Me.lblBCI = New System.Windows.Forms.Label()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtSapellido = New System.Windows.Forms.TextBox()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtSnombre = New System.Windows.Forms.TextBox()
        Me.txtPapellido = New System.Windows.Forms.TextBox()
        Me.lblSnombre = New System.Windows.Forms.Label()
        Me.lblPapellido = New System.Windows.Forms.Label()
        Me.lblPnombre = New System.Windows.Forms.Label()
        Me.lblSapellido = New System.Windows.Forms.Label()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.txtPnombre = New System.Windows.Forms.TextBox()
        Me.lblNpuerta = New System.Windows.Forms.Label()
        Me.txtNpuerta = New System.Windows.Forms.TextBox()
        Me.lblTipoPersonal = New System.Windows.Forms.Label()
        Me.rbMedico = New System.Windows.Forms.RadioButton()
        Me.rbAuxiliarMedico = New System.Windows.Forms.RadioButton()
        Me.lblEspecialidad = New System.Windows.Forms.Label()
        Me.cmdIngresar = New System.Windows.Forms.Button()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdModificar = New System.Windows.Forms.Button()
        Me.lblFechaNac = New System.Windows.Forms.Label()
        Me.gbBuscar = New System.Windows.Forms.GroupBox()
        Me.gbDatos = New System.Windows.Forms.GroupBox()
        Me.gbTelefono = New System.Windows.Forms.GroupBox()
        Me.cbTelefono = New System.Windows.Forms.ComboBox()
        Me.cmdQuitar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdAgregar = New System.Windows.Forms.Button()
        Me.dtpFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEsquina = New System.Windows.Forms.TextBox()
        Me.txtEspecialidad = New System.Windows.Forms.TextBox()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.gbRadio = New System.Windows.Forms.GroupBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbBuscar.SuspendLayout()
        Me.gbDatos.SuspendLayout()
        Me.gbTelefono.SuspendLayout()
        Me.gbRadio.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCI
        '
        Me.txtCI.Location = New System.Drawing.Point(41, 34)
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
        Me.lblBCI.Location = New System.Drawing.Point(6, 34)
        Me.lblBCI.Name = "lblBCI"
        Me.lblBCI.Size = New System.Drawing.Size(25, 20)
        Me.lblBCI.TabIndex = 22
        Me.lblBCI.Text = "CI"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdBuscar.Location = New System.Drawing.Point(270, 29)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(102, 33)
        Me.cmdBuscar.TabIndex = 21
        Me.cmdBuscar.Text = "Buscar"
        Me.ToolTip1.SetToolTip(Me.cmdBuscar, "Buscar personal médico")
        Me.cmdBuscar.UseVisualStyleBackColor = False
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(448, 212)
        Me.txtTelefono.MaxLength = 40
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(147, 20)
        Me.txtTelefono.TabIndex = 57
        Me.ToolTip1.SetToolTip(Me.txtTelefono, "Ingresar teléfono")
        '
        'txtSapellido
        '
        Me.txtSapellido.Location = New System.Drawing.Point(448, 87)
        Me.txtSapellido.MaxLength = 20
        Me.txtSapellido.Name = "txtSapellido"
        Me.txtSapellido.Size = New System.Drawing.Size(147, 20)
        Me.txtSapellido.TabIndex = 55
        Me.ToolTip1.SetToolTip(Me.txtSapellido, "Ingresar segundo apellido")
        '
        'txtCalle
        '
        Me.txtCalle.Location = New System.Drawing.Point(158, 169)
        Me.txtCalle.MaxLength = 25
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(147, 20)
        Me.txtCalle.TabIndex = 54
        Me.ToolTip1.SetToolTip(Me.txtCalle, "Ingrese calle del domicilio")
        '
        'txtEdad
        '
        Me.txtEdad.Enabled = False
        Me.txtEdad.Location = New System.Drawing.Point(448, 128)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(147, 20)
        Me.txtEdad.TabIndex = 53
        Me.ToolTip1.SetToolTip(Me.txtEdad, "Edad calculada en base a la fecha de nacimiento")
        '
        'txtSnombre
        '
        Me.txtSnombre.Location = New System.Drawing.Point(448, 47)
        Me.txtSnombre.MaxLength = 20
        Me.txtSnombre.Name = "txtSnombre"
        Me.txtSnombre.Size = New System.Drawing.Size(147, 20)
        Me.txtSnombre.TabIndex = 52
        Me.ToolTip1.SetToolTip(Me.txtSnombre, "Ingresar segundo nombre")
        '
        'txtPapellido
        '
        Me.txtPapellido.Location = New System.Drawing.Point(157, 87)
        Me.txtPapellido.MaxLength = 20
        Me.txtPapellido.Name = "txtPapellido"
        Me.txtPapellido.Size = New System.Drawing.Size(147, 20)
        Me.txtPapellido.TabIndex = 51
        Me.ToolTip1.SetToolTip(Me.txtPapellido, "Ingresar primer apellido")
        '
        'lblSnombre
        '
        Me.lblSnombre.AutoSize = True
        Me.lblSnombre.BackColor = System.Drawing.Color.Transparent
        Me.lblSnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSnombre.Location = New System.Drawing.Point(311, 50)
        Me.lblSnombre.Name = "lblSnombre"
        Me.lblSnombre.Size = New System.Drawing.Size(132, 20)
        Me.lblSnombre.TabIndex = 50
        Me.lblSnombre.Text = "Segundo nombre"
        '
        'lblPapellido
        '
        Me.lblPapellido.AutoSize = True
        Me.lblPapellido.BackColor = System.Drawing.Color.Transparent
        Me.lblPapellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPapellido.Location = New System.Drawing.Point(16, 85)
        Me.lblPapellido.Name = "lblPapellido"
        Me.lblPapellido.Size = New System.Drawing.Size(112, 20)
        Me.lblPapellido.TabIndex = 49
        Me.lblPapellido.Text = "Primer apellido"
        '
        'lblPnombre
        '
        Me.lblPnombre.AutoSize = True
        Me.lblPnombre.BackColor = System.Drawing.Color.Transparent
        Me.lblPnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPnombre.Location = New System.Drawing.Point(16, 49)
        Me.lblPnombre.Name = "lblPnombre"
        Me.lblPnombre.Size = New System.Drawing.Size(112, 20)
        Me.lblPnombre.TabIndex = 48
        Me.lblPnombre.Text = "Primer nombre"
        '
        'lblSapellido
        '
        Me.lblSapellido.AutoSize = True
        Me.lblSapellido.BackColor = System.Drawing.Color.Transparent
        Me.lblSapellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSapellido.Location = New System.Drawing.Point(311, 85)
        Me.lblSapellido.Name = "lblSapellido"
        Me.lblSapellido.Size = New System.Drawing.Size(132, 20)
        Me.lblSapellido.TabIndex = 47
        Me.lblSapellido.Text = "Segundo apellido"
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.BackColor = System.Drawing.Color.Transparent
        Me.lblEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdad.Location = New System.Drawing.Point(311, 128)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(47, 20)
        Me.lblEdad.TabIndex = 46
        Me.lblEdad.Text = "Edad"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.BackColor = System.Drawing.Color.Transparent
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(16, 167)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(44, 20)
        Me.lblDireccion.TabIndex = 45
        Me.lblDireccion.Text = "Calle"
        '
        'txtPnombre
        '
        Me.txtPnombre.Location = New System.Drawing.Point(157, 50)
        Me.txtPnombre.MaxLength = 20
        Me.txtPnombre.Name = "txtPnombre"
        Me.txtPnombre.Size = New System.Drawing.Size(147, 20)
        Me.txtPnombre.TabIndex = 40
        Me.ToolTip1.SetToolTip(Me.txtPnombre, "Ingresar primer nombre")
        '
        'lblNpuerta
        '
        Me.lblNpuerta.AutoSize = True
        Me.lblNpuerta.BackColor = System.Drawing.Color.Transparent
        Me.lblNpuerta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNpuerta.Location = New System.Drawing.Point(311, 167)
        Me.lblNpuerta.Name = "lblNpuerta"
        Me.lblNpuerta.Size = New System.Drawing.Size(77, 20)
        Me.lblNpuerta.TabIndex = 62
        Me.lblNpuerta.Text = "Nº Puerta"
        '
        'txtNpuerta
        '
        Me.txtNpuerta.Location = New System.Drawing.Point(448, 169)
        Me.txtNpuerta.MaxLength = 10
        Me.txtNpuerta.Name = "txtNpuerta"
        Me.txtNpuerta.Size = New System.Drawing.Size(147, 20)
        Me.txtNpuerta.TabIndex = 63
        Me.ToolTip1.SetToolTip(Me.txtNpuerta, "Ingrese número de puerta del domicilio")
        '
        'lblTipoPersonal
        '
        Me.lblTipoPersonal.AutoSize = True
        Me.lblTipoPersonal.BackColor = System.Drawing.Color.Transparent
        Me.lblTipoPersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoPersonal.Location = New System.Drawing.Point(16, 19)
        Me.lblTipoPersonal.Name = "lblTipoPersonal"
        Me.lblTipoPersonal.Size = New System.Drawing.Size(104, 20)
        Me.lblTipoPersonal.TabIndex = 65
        Me.lblTipoPersonal.Text = "Tipo personal"
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
        'lblEspecialidad
        '
        Me.lblEspecialidad.AutoSize = True
        Me.lblEspecialidad.BackColor = System.Drawing.Color.Transparent
        Me.lblEspecialidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEspecialidad.Location = New System.Drawing.Point(16, 250)
        Me.lblEspecialidad.Name = "lblEspecialidad"
        Me.lblEspecialidad.Size = New System.Drawing.Size(99, 20)
        Me.lblEspecialidad.TabIndex = 69
        Me.lblEspecialidad.Text = "Especialidad"
        Me.lblEspecialidad.Visible = False
        '
        'cmdIngresar
        '
        Me.cmdIngresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdIngresar.Location = New System.Drawing.Point(71, 348)
        Me.cmdIngresar.Name = "cmdIngresar"
        Me.cmdIngresar.Size = New System.Drawing.Size(102, 33)
        Me.cmdIngresar.TabIndex = 71
        Me.cmdIngresar.Text = "Ingresar"
        Me.ToolTip1.SetToolTip(Me.cmdIngresar, "Alta personal médico")
        Me.cmdIngresar.UseVisualStyleBackColor = False
        '
        'cmdEliminar
        '
        Me.cmdEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdEliminar.Location = New System.Drawing.Point(191, 348)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(102, 33)
        Me.cmdEliminar.TabIndex = 72
        Me.cmdEliminar.Text = "Eliminar"
        Me.ToolTip1.SetToolTip(Me.cmdEliminar, "Eliminar personal médico")
        Me.cmdEliminar.UseVisualStyleBackColor = False
        '
        'cmdModificar
        '
        Me.cmdModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdModificar.Location = New System.Drawing.Point(309, 348)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(102, 33)
        Me.cmdModificar.TabIndex = 73
        Me.cmdModificar.Text = "Modificar"
        Me.ToolTip1.SetToolTip(Me.cmdModificar, "Modificar personal médico")
        Me.cmdModificar.UseVisualStyleBackColor = False
        '
        'lblFechaNac
        '
        Me.lblFechaNac.AutoSize = True
        Me.lblFechaNac.BackColor = System.Drawing.Color.Transparent
        Me.lblFechaNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNac.Location = New System.Drawing.Point(16, 128)
        Me.lblFechaNac.Name = "lblFechaNac"
        Me.lblFechaNac.Size = New System.Drawing.Size(135, 20)
        Me.lblFechaNac.TabIndex = 74
        Me.lblFechaNac.Text = "Fecha nacimiento"
        '
        'gbBuscar
        '
        Me.gbBuscar.BackColor = System.Drawing.Color.Transparent
        Me.gbBuscar.Controls.Add(Me.txtCI)
        Me.gbBuscar.Controls.Add(Me.lblBCI)
        Me.gbBuscar.Controls.Add(Me.cmdBuscar)
        Me.gbBuscar.Location = New System.Drawing.Point(12, 8)
        Me.gbBuscar.Name = "gbBuscar"
        Me.gbBuscar.Size = New System.Drawing.Size(398, 79)
        Me.gbBuscar.TabIndex = 75
        Me.gbBuscar.TabStop = False
        Me.gbBuscar.Text = "BUSCAR"
        '
        'gbDatos
        '
        Me.gbDatos.BackColor = System.Drawing.Color.Transparent
        Me.gbDatos.Controls.Add(Me.gbTelefono)
        Me.gbDatos.Controls.Add(Me.dtpFechaNac)
        Me.gbDatos.Controls.Add(Me.Label1)
        Me.gbDatos.Controls.Add(Me.txtEsquina)
        Me.gbDatos.Controls.Add(Me.txtEspecialidad)
        Me.gbDatos.Controls.Add(Me.cmdModificar)
        Me.gbDatos.Controls.Add(Me.cmdCancelar)
        Me.gbDatos.Controls.Add(Me.cmdEliminar)
        Me.gbDatos.Controls.Add(Me.lblFechaNac)
        Me.gbDatos.Controls.Add(Me.cmdIngresar)
        Me.gbDatos.Controls.Add(Me.txtPnombre)
        Me.gbDatos.Controls.Add(Me.lblTelefono)
        Me.gbDatos.Controls.Add(Me.lblDireccion)
        Me.gbDatos.Controls.Add(Me.lblEdad)
        Me.gbDatos.Controls.Add(Me.lblEspecialidad)
        Me.gbDatos.Controls.Add(Me.lblSapellido)
        Me.gbDatos.Controls.Add(Me.lblPnombre)
        Me.gbDatos.Controls.Add(Me.lblPapellido)
        Me.gbDatos.Controls.Add(Me.lblSnombre)
        Me.gbDatos.Controls.Add(Me.lblTipoPersonal)
        Me.gbDatos.Controls.Add(Me.txtPapellido)
        Me.gbDatos.Controls.Add(Me.txtNpuerta)
        Me.gbDatos.Controls.Add(Me.txtSnombre)
        Me.gbDatos.Controls.Add(Me.lblNpuerta)
        Me.gbDatos.Controls.Add(Me.txtEdad)
        Me.gbDatos.Controls.Add(Me.txtCalle)
        Me.gbDatos.Controls.Add(Me.txtTelefono)
        Me.gbDatos.Controls.Add(Me.txtSapellido)
        Me.gbDatos.Controls.Add(Me.gbRadio)
        Me.gbDatos.Location = New System.Drawing.Point(12, 106)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(610, 393)
        Me.gbDatos.TabIndex = 76
        Me.gbDatos.TabStop = False
        Me.gbDatos.Text = "INGRESAR DATOS"
        Me.gbDatos.Visible = False
        '
        'gbTelefono
        '
        Me.gbTelefono.Controls.Add(Me.cbTelefono)
        Me.gbTelefono.Controls.Add(Me.cmdQuitar)
        Me.gbTelefono.Controls.Add(Me.Label2)
        Me.gbTelefono.Controls.Add(Me.cmdAgregar)
        Me.gbTelefono.Location = New System.Drawing.Point(10, 285)
        Me.gbTelefono.Name = "gbTelefono"
        Me.gbTelefono.Size = New System.Drawing.Size(585, 45)
        Me.gbTelefono.TabIndex = 87
        Me.gbTelefono.TabStop = False
        Me.gbTelefono.Text = "MODIFICAR TELEFONO"
        Me.gbTelefono.Visible = False
        '
        'cbTelefono
        '
        Me.cbTelefono.FormattingEnabled = True
        Me.cbTelefono.Location = New System.Drawing.Point(81, 14)
        Me.cbTelefono.MaxLength = 9
        Me.cbTelefono.Name = "cbTelefono"
        Me.cbTelefono.Size = New System.Drawing.Size(202, 21)
        Me.cbTelefono.TabIndex = 83
        Me.ToolTip1.SetToolTip(Me.cbTelefono, "Ingresar o seleccionar teléfono del médico o auxiliar médico")
        '
        'cmdQuitar
        '
        Me.cmdQuitar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdQuitar.Location = New System.Drawing.Point(455, 13)
        Me.cmdQuitar.Name = "cmdQuitar"
        Me.cmdQuitar.Size = New System.Drawing.Size(124, 26)
        Me.cmdQuitar.TabIndex = 85
        Me.cmdQuitar.Text = "Quitar"
        Me.cmdQuitar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Teléfono"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdAgregar.Location = New System.Drawing.Point(326, 13)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(123, 26)
        Me.cmdAgregar.TabIndex = 84
        Me.cmdAgregar.Text = "Agregar"
        Me.cmdAgregar.UseVisualStyleBackColor = False
        '
        'dtpFechaNac
        '
        Me.dtpFechaNac.Location = New System.Drawing.Point(157, 128)
        Me.dtpFechaNac.Name = "dtpFechaNac"
        Me.dtpFechaNac.Size = New System.Drawing.Size(147, 20)
        Me.dtpFechaNac.TabIndex = 82
        Me.ToolTip1.SetToolTip(Me.dtpFechaNac, "Ingresar fecha de nacimiento")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 212)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "Esquina"
        '
        'txtEsquina
        '
        Me.txtEsquina.Location = New System.Drawing.Point(158, 212)
        Me.txtEsquina.MaxLength = 25
        Me.txtEsquina.Name = "txtEsquina"
        Me.txtEsquina.Size = New System.Drawing.Size(147, 20)
        Me.txtEsquina.TabIndex = 80
        Me.ToolTip1.SetToolTip(Me.txtEsquina, "Ingresar esquina del domicilio")
        '
        'txtEspecialidad
        '
        Me.txtEspecialidad.Location = New System.Drawing.Point(157, 250)
        Me.txtEspecialidad.MaxLength = 25
        Me.txtEspecialidad.Name = "txtEspecialidad"
        Me.txtEspecialidad.Size = New System.Drawing.Size(147, 20)
        Me.txtEspecialidad.TabIndex = 78
        Me.ToolTip1.SetToolTip(Me.txtEspecialidad, "Ingresar especialidad del médico")
        Me.txtEspecialidad.Visible = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdCancelar.Location = New System.Drawing.Point(427, 348)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(102, 33)
        Me.cmdCancelar.TabIndex = 77
        Me.cmdCancelar.Text = "Cancelar"
        Me.ToolTip1.SetToolTip(Me.cmdCancelar, "Cancelar ingreso de datos")
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.BackColor = System.Drawing.Color.Transparent
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(311, 210)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(53, 20)
        Me.lblTelefono.TabIndex = 44
        Me.lblTelefono.Text = "E-Mail"
        '
        'gbRadio
        '
        Me.gbRadio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.gbRadio.Controls.Add(Me.rbAuxiliarMedico)
        Me.gbRadio.Controls.Add(Me.rbMedico)
        Me.gbRadio.Enabled = False
        Me.gbRadio.ForeColor = System.Drawing.Color.Transparent
        Me.gbRadio.Location = New System.Drawing.Point(157, 10)
        Me.gbRadio.Name = "gbRadio"
        Me.gbRadio.Size = New System.Drawing.Size(244, 32)
        Me.gbRadio.TabIndex = 79
        Me.gbRadio.TabStop = False
        Me.ToolTip1.SetToolTip(Me.gbRadio, "Seleccionar tipo de personal médico")
        '
        'frmAdmPersonalMedico
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
        Me.Name = "frmAdmPersonalMedico"
        Me.Text = "ADMINISTRACIÓN PERSONAL MÉDICO"
        Me.gbBuscar.ResumeLayout(False)
        Me.gbBuscar.PerformLayout()
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        Me.gbTelefono.ResumeLayout(False)
        Me.gbTelefono.PerformLayout()
        Me.gbRadio.ResumeLayout(False)
        Me.gbRadio.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtCI As System.Windows.Forms.TextBox
    Friend WithEvents lblBCI As System.Windows.Forms.Label
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtSapellido As System.Windows.Forms.TextBox
    Friend WithEvents txtCalle As System.Windows.Forms.TextBox
    Friend WithEvents txtEdad As System.Windows.Forms.TextBox
    Friend WithEvents txtSnombre As System.Windows.Forms.TextBox
    Friend WithEvents txtPapellido As System.Windows.Forms.TextBox
    Friend WithEvents lblSnombre As System.Windows.Forms.Label
    Friend WithEvents lblPapellido As System.Windows.Forms.Label
    Friend WithEvents lblPnombre As System.Windows.Forms.Label
    Friend WithEvents lblSapellido As System.Windows.Forms.Label
    Friend WithEvents lblEdad As System.Windows.Forms.Label
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents txtPnombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNpuerta As System.Windows.Forms.Label
    Friend WithEvents txtNpuerta As System.Windows.Forms.TextBox
    Friend WithEvents lblTipoPersonal As System.Windows.Forms.Label
    Friend WithEvents rbMedico As System.Windows.Forms.RadioButton
    Friend WithEvents rbAuxiliarMedico As System.Windows.Forms.RadioButton
    Friend WithEvents lblEspecialidad As System.Windows.Forms.Label
    Friend WithEvents cmdIngresar As System.Windows.Forms.Button
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    Friend WithEvents lblFechaNac As System.Windows.Forms.Label
    Friend WithEvents gbBuscar As System.Windows.Forms.GroupBox
    Friend WithEvents gbDatos As System.Windows.Forms.GroupBox
    Friend WithEvents txtEspecialidad As System.Windows.Forms.TextBox
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents gbRadio As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEsquina As System.Windows.Forms.TextBox
    Friend WithEvents dtpFechaNac As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents gbTelefono As System.Windows.Forms.GroupBox
    Friend WithEvents cbTelefono As System.Windows.Forms.ComboBox
    Friend WithEvents cmdQuitar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdAgregar As System.Windows.Forms.Button
End Class
