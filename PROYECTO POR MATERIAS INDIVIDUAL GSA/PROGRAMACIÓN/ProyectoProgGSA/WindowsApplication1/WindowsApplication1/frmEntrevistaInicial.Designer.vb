<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntrevistaInicial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntrevistaInicial))
        Me.txtCI = New System.Windows.Forms.TextBox()
        Me.lblBCI = New System.Windows.Forms.Label()
        Me.lblMotivoDeConsulta = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblEstadoDeConciencia = New System.Windows.Forms.Label()
        Me.lblGradoDeColaboracion = New System.Windows.Forms.Label()
        Me.lblMovilidad = New System.Windows.Forms.Label()
        Me.lblActitud = New System.Windows.Forms.Label()
        Me.lblEstadoDeNutrición = New System.Windows.Forms.Label()
        Me.lblGradoDeHidratacion = New System.Windows.Forms.Label()
        Me.lblTemperatura = New System.Windows.Forms.Label()
        Me.lblPulso = New System.Windows.Forms.Label()
        Me.lblFrecuenciaCardiaca = New System.Windows.Forms.Label()
        Me.lblFrecuenciaRespiratoria = New System.Windows.Forms.Label()
        Me.lblFiebre = New System.Windows.Forms.Label()
        Me.lblDolor = New System.Windows.Forms.Label()
        Me.lblMalestar = New System.Windows.Forms.Label()
        Me.lblOtroSint = New System.Windows.Forms.Label()
        Me.txtEstadoConciencia = New System.Windows.Forms.TextBox()
        Me.txtGradoDeColab = New System.Windows.Forms.TextBox()
        Me.txtMovilidad = New System.Windows.Forms.TextBox()
        Me.cbActitud = New System.Windows.Forms.ComboBox()
        Me.cbEstadoNutricion = New System.Windows.Forms.ComboBox()
        Me.txtGradoDeHidratacion = New System.Windows.Forms.TextBox()
        Me.txtTemperatura = New System.Windows.Forms.TextBox()
        Me.txtFrecuenciaCardiaca = New System.Windows.Forms.TextBox()
        Me.txtFrecuenciaResp = New System.Windows.Forms.TextBox()
        Me.CheckBoxFiebre = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDolor = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMalestar = New System.Windows.Forms.CheckBox()
        Me.CheckBoxOtroS = New System.Windows.Forms.CheckBox()
        Me.txtNombreAcompañante = New System.Windows.Forms.TextBox()
        Me.txtMotivo = New System.Windows.Forms.TextBox()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.cmdIngresar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEnfermedadActual = New System.Windows.Forms.TextBox()
        Me.txtEnfermedadFamiliar = New System.Windows.Forms.TextBox()
        Me.txtAntecedentes = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtOtro = New System.Windows.Forms.TextBox()
        Me.gbBuscar = New System.Windows.Forms.GroupBox()
        Me.gbDatos = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTipoEnfAnt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTipoEnfActual = New System.Windows.Forms.TextBox()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cbPulso = New System.Windows.Forms.ComboBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCIMedico = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbBuscar.SuspendLayout()
        Me.gbDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCI
        '
        Me.txtCI.Location = New System.Drawing.Point(53, 37)
        Me.txtCI.MaxLength = 8
        Me.txtCI.Name = "txtCI"
        Me.txtCI.Size = New System.Drawing.Size(257, 20)
        Me.txtCI.TabIndex = 41
        Me.ToolTip1.SetToolTip(Me.txtCI, "Ingresar cédula de identidad")
        '
        'lblBCI
        '
        Me.lblBCI.AutoSize = True
        Me.lblBCI.BackColor = System.Drawing.Color.Transparent
        Me.lblBCI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBCI.Location = New System.Drawing.Point(6, 35)
        Me.lblBCI.Name = "lblBCI"
        Me.lblBCI.Size = New System.Drawing.Size(25, 20)
        Me.lblBCI.TabIndex = 40
        Me.lblBCI.Text = "CI"
        '
        'lblMotivoDeConsulta
        '
        Me.lblMotivoDeConsulta.AutoSize = True
        Me.lblMotivoDeConsulta.BackColor = System.Drawing.Color.Transparent
        Me.lblMotivoDeConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMotivoDeConsulta.Location = New System.Drawing.Point(5, 336)
        Me.lblMotivoDeConsulta.Name = "lblMotivoDeConsulta"
        Me.lblMotivoDeConsulta.Size = New System.Drawing.Size(141, 20)
        Me.lblMotivoDeConsulta.TabIndex = 42
        Me.lblMotivoDeConsulta.Text = "Motivo de consulta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 20)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = " "
        '
        'lblEstadoDeConciencia
        '
        Me.lblEstadoDeConciencia.AutoSize = True
        Me.lblEstadoDeConciencia.BackColor = System.Drawing.Color.Transparent
        Me.lblEstadoDeConciencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoDeConciencia.Location = New System.Drawing.Point(4, 202)
        Me.lblEstadoDeConciencia.Name = "lblEstadoDeConciencia"
        Me.lblEstadoDeConciencia.Size = New System.Drawing.Size(161, 20)
        Me.lblEstadoDeConciencia.TabIndex = 44
        Me.lblEstadoDeConciencia.Text = "Estado de conciencia"
        '
        'lblGradoDeColaboracion
        '
        Me.lblGradoDeColaboracion.AutoSize = True
        Me.lblGradoDeColaboracion.BackColor = System.Drawing.Color.Transparent
        Me.lblGradoDeColaboracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGradoDeColaboracion.Location = New System.Drawing.Point(4, 60)
        Me.lblGradoDeColaboracion.Name = "lblGradoDeColaboracion"
        Me.lblGradoDeColaboracion.Size = New System.Drawing.Size(170, 20)
        Me.lblGradoDeColaboracion.TabIndex = 45
        Me.lblGradoDeColaboracion.Text = "Grado de colaboración"
        '
        'lblMovilidad
        '
        Me.lblMovilidad.AutoSize = True
        Me.lblMovilidad.BackColor = System.Drawing.Color.Transparent
        Me.lblMovilidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMovilidad.Location = New System.Drawing.Point(4, 97)
        Me.lblMovilidad.Name = "lblMovilidad"
        Me.lblMovilidad.Size = New System.Drawing.Size(74, 20)
        Me.lblMovilidad.TabIndex = 46
        Me.lblMovilidad.Text = "Movilidad"
        '
        'lblActitud
        '
        Me.lblActitud.AutoSize = True
        Me.lblActitud.BackColor = System.Drawing.Color.Transparent
        Me.lblActitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActitud.Location = New System.Drawing.Point(0, 132)
        Me.lblActitud.Name = "lblActitud"
        Me.lblActitud.Size = New System.Drawing.Size(63, 20)
        Me.lblActitud.TabIndex = 47
        Me.lblActitud.Text = " Actitud"
        '
        'lblEstadoDeNutrición
        '
        Me.lblEstadoDeNutrición.AutoSize = True
        Me.lblEstadoDeNutrición.BackColor = System.Drawing.Color.Transparent
        Me.lblEstadoDeNutrición.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoDeNutrición.Location = New System.Drawing.Point(4, 166)
        Me.lblEstadoDeNutrición.Name = "lblEstadoDeNutrición"
        Me.lblEstadoDeNutrición.Size = New System.Drawing.Size(146, 20)
        Me.lblEstadoDeNutrición.TabIndex = 48
        Me.lblEstadoDeNutrición.Text = "Estado de nutrición"
        '
        'lblGradoDeHidratacion
        '
        Me.lblGradoDeHidratacion.AutoSize = True
        Me.lblGradoDeHidratacion.BackColor = System.Drawing.Color.Transparent
        Me.lblGradoDeHidratacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGradoDeHidratacion.Location = New System.Drawing.Point(318, 168)
        Me.lblGradoDeHidratacion.Name = "lblGradoDeHidratacion"
        Me.lblGradoDeHidratacion.Size = New System.Drawing.Size(158, 20)
        Me.lblGradoDeHidratacion.TabIndex = 49
        Me.lblGradoDeHidratacion.Text = "Grado de hidratación"
        '
        'lblTemperatura
        '
        Me.lblTemperatura.AutoSize = True
        Me.lblTemperatura.BackColor = System.Drawing.Color.Transparent
        Me.lblTemperatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTemperatura.Location = New System.Drawing.Point(318, 27)
        Me.lblTemperatura.Name = "lblTemperatura"
        Me.lblTemperatura.Size = New System.Drawing.Size(100, 20)
        Me.lblTemperatura.TabIndex = 50
        Me.lblTemperatura.Text = "Temperatura"
        '
        'lblPulso
        '
        Me.lblPulso.AutoSize = True
        Me.lblPulso.BackColor = System.Drawing.Color.Transparent
        Me.lblPulso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPulso.Location = New System.Drawing.Point(318, 62)
        Me.lblPulso.Name = "lblPulso"
        Me.lblPulso.Size = New System.Drawing.Size(48, 20)
        Me.lblPulso.TabIndex = 51
        Me.lblPulso.Text = "Pulso"
        '
        'lblFrecuenciaCardiaca
        '
        Me.lblFrecuenciaCardiaca.AutoSize = True
        Me.lblFrecuenciaCardiaca.BackColor = System.Drawing.Color.Transparent
        Me.lblFrecuenciaCardiaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrecuenciaCardiaca.Location = New System.Drawing.Point(318, 91)
        Me.lblFrecuenciaCardiaca.Name = "lblFrecuenciaCardiaca"
        Me.lblFrecuenciaCardiaca.Size = New System.Drawing.Size(152, 20)
        Me.lblFrecuenciaCardiaca.TabIndex = 52
        Me.lblFrecuenciaCardiaca.Text = "Frecuencia cardíaca"
        '
        'lblFrecuenciaRespiratoria
        '
        Me.lblFrecuenciaRespiratoria.AutoSize = True
        Me.lblFrecuenciaRespiratoria.BackColor = System.Drawing.Color.Transparent
        Me.lblFrecuenciaRespiratoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrecuenciaRespiratoria.Location = New System.Drawing.Point(318, 128)
        Me.lblFrecuenciaRespiratoria.Name = "lblFrecuenciaRespiratoria"
        Me.lblFrecuenciaRespiratoria.Size = New System.Drawing.Size(171, 20)
        Me.lblFrecuenciaRespiratoria.TabIndex = 53
        Me.lblFrecuenciaRespiratoria.Text = "Frecuencia respiratoria"
        '
        'lblFiebre
        '
        Me.lblFiebre.AutoSize = True
        Me.lblFiebre.BackColor = System.Drawing.Color.Transparent
        Me.lblFiebre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiebre.Location = New System.Drawing.Point(467, 338)
        Me.lblFiebre.Name = "lblFiebre"
        Me.lblFiebre.Size = New System.Drawing.Size(54, 20)
        Me.lblFiebre.TabIndex = 54
        Me.lblFiebre.Text = "Fiebre"
        '
        'lblDolor
        '
        Me.lblDolor.AutoSize = True
        Me.lblDolor.BackColor = System.Drawing.Color.Transparent
        Me.lblDolor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDolor.Location = New System.Drawing.Point(467, 358)
        Me.lblDolor.Name = "lblDolor"
        Me.lblDolor.Size = New System.Drawing.Size(47, 20)
        Me.lblDolor.TabIndex = 55
        Me.lblDolor.Text = "Dolor"
        '
        'lblMalestar
        '
        Me.lblMalestar.AutoSize = True
        Me.lblMalestar.BackColor = System.Drawing.Color.Transparent
        Me.lblMalestar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMalestar.Location = New System.Drawing.Point(467, 378)
        Me.lblMalestar.Name = "lblMalestar"
        Me.lblMalestar.Size = New System.Drawing.Size(70, 20)
        Me.lblMalestar.TabIndex = 56
        Me.lblMalestar.Text = "Malestar"
        '
        'lblOtroSint
        '
        Me.lblOtroSint.AutoSize = True
        Me.lblOtroSint.BackColor = System.Drawing.Color.Transparent
        Me.lblOtroSint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOtroSint.Location = New System.Drawing.Point(467, 398)
        Me.lblOtroSint.Name = "lblOtroSint"
        Me.lblOtroSint.Size = New System.Drawing.Size(40, 20)
        Me.lblOtroSint.TabIndex = 57
        Me.lblOtroSint.Text = "Otro"
        '
        'txtEstadoConciencia
        '
        Me.txtEstadoConciencia.Location = New System.Drawing.Point(197, 202)
        Me.txtEstadoConciencia.MaxLength = 20
        Me.txtEstadoConciencia.Name = "txtEstadoConciencia"
        Me.txtEstadoConciencia.Size = New System.Drawing.Size(121, 20)
        Me.txtEstadoConciencia.TabIndex = 59
        Me.ToolTip1.SetToolTip(Me.txtEstadoConciencia, "Ingresar estado de conciencia del paciente")
        '
        'txtGradoDeColab
        '
        Me.txtGradoDeColab.Location = New System.Drawing.Point(197, 62)
        Me.txtGradoDeColab.MaxLength = 20
        Me.txtGradoDeColab.Name = "txtGradoDeColab"
        Me.txtGradoDeColab.Size = New System.Drawing.Size(121, 20)
        Me.txtGradoDeColab.TabIndex = 60
        Me.ToolTip1.SetToolTip(Me.txtGradoDeColab, "Ingresar grado de colaboración del paciente")
        '
        'txtMovilidad
        '
        Me.txtMovilidad.Location = New System.Drawing.Point(197, 96)
        Me.txtMovilidad.MaxLength = 20
        Me.txtMovilidad.Name = "txtMovilidad"
        Me.txtMovilidad.Size = New System.Drawing.Size(121, 20)
        Me.txtMovilidad.TabIndex = 61
        Me.ToolTip1.SetToolTip(Me.txtMovilidad, "Ingresar movilidad del paciente")
        '
        'cbActitud
        '
        Me.cbActitud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbActitud.FormattingEnabled = True
        Me.cbActitud.Location = New System.Drawing.Point(197, 131)
        Me.cbActitud.Name = "cbActitud"
        Me.cbActitud.Size = New System.Drawing.Size(121, 21)
        Me.cbActitud.TabIndex = 62
        Me.ToolTip1.SetToolTip(Me.cbActitud, "Seleccionar actitud del paciente")
        '
        'cbEstadoNutricion
        '
        Me.cbEstadoNutricion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstadoNutricion.FormattingEnabled = True
        Me.cbEstadoNutricion.Location = New System.Drawing.Point(197, 167)
        Me.cbEstadoNutricion.Name = "cbEstadoNutricion"
        Me.cbEstadoNutricion.Size = New System.Drawing.Size(121, 21)
        Me.cbEstadoNutricion.TabIndex = 63
        Me.ToolTip1.SetToolTip(Me.cbEstadoNutricion, "Seleccionar estado de nutrición del paciente")
        '
        'txtGradoDeHidratacion
        '
        Me.txtGradoDeHidratacion.Location = New System.Drawing.Point(509, 168)
        Me.txtGradoDeHidratacion.MaxLength = 20
        Me.txtGradoDeHidratacion.Name = "txtGradoDeHidratacion"
        Me.txtGradoDeHidratacion.Size = New System.Drawing.Size(121, 20)
        Me.txtGradoDeHidratacion.TabIndex = 64
        Me.ToolTip1.SetToolTip(Me.txtGradoDeHidratacion, "Ingresar grado de hidratación del paciente")
        '
        'txtTemperatura
        '
        Me.txtTemperatura.Location = New System.Drawing.Point(509, 29)
        Me.txtTemperatura.MaxLength = 5
        Me.txtTemperatura.Name = "txtTemperatura"
        Me.txtTemperatura.Size = New System.Drawing.Size(121, 20)
        Me.txtTemperatura.TabIndex = 65
        Me.ToolTip1.SetToolTip(Me.txtTemperatura, "Ingresar temperatura del paciente")
        '
        'txtFrecuenciaCardiaca
        '
        Me.txtFrecuenciaCardiaca.Location = New System.Drawing.Point(509, 93)
        Me.txtFrecuenciaCardiaca.MaxLength = 20
        Me.txtFrecuenciaCardiaca.Name = "txtFrecuenciaCardiaca"
        Me.txtFrecuenciaCardiaca.Size = New System.Drawing.Size(121, 20)
        Me.txtFrecuenciaCardiaca.TabIndex = 67
        Me.ToolTip1.SetToolTip(Me.txtFrecuenciaCardiaca, "Ingresar frecuencia cardíaca del paciente")
        '
        'txtFrecuenciaResp
        '
        Me.txtFrecuenciaResp.Location = New System.Drawing.Point(509, 130)
        Me.txtFrecuenciaResp.MaxLength = 20
        Me.txtFrecuenciaResp.Name = "txtFrecuenciaResp"
        Me.txtFrecuenciaResp.Size = New System.Drawing.Size(121, 20)
        Me.txtFrecuenciaResp.TabIndex = 68
        Me.ToolTip1.SetToolTip(Me.txtFrecuenciaResp, "Ingresar frecuencia respiratoria del paciente")
        '
        'CheckBoxFiebre
        '
        Me.CheckBoxFiebre.AutoSize = True
        Me.CheckBoxFiebre.BackColor = System.Drawing.Color.Transparent
        Me.CheckBoxFiebre.Location = New System.Drawing.Point(541, 339)
        Me.CheckBoxFiebre.Name = "CheckBoxFiebre"
        Me.CheckBoxFiebre.Size = New System.Drawing.Size(35, 17)
        Me.CheckBoxFiebre.TabIndex = 69
        Me.CheckBoxFiebre.Text = "Si"
        Me.ToolTip1.SetToolTip(Me.CheckBoxFiebre, "Síntoma de fiebre")
        Me.CheckBoxFiebre.UseVisualStyleBackColor = False
        '
        'CheckBoxDolor
        '
        Me.CheckBoxDolor.AutoSize = True
        Me.CheckBoxDolor.BackColor = System.Drawing.Color.Transparent
        Me.CheckBoxDolor.Location = New System.Drawing.Point(541, 360)
        Me.CheckBoxDolor.Name = "CheckBoxDolor"
        Me.CheckBoxDolor.Size = New System.Drawing.Size(35, 17)
        Me.CheckBoxDolor.TabIndex = 70
        Me.CheckBoxDolor.Text = "Si"
        Me.ToolTip1.SetToolTip(Me.CheckBoxDolor, "Síntoma de dolor")
        Me.CheckBoxDolor.UseVisualStyleBackColor = False
        '
        'CheckBoxMalestar
        '
        Me.CheckBoxMalestar.AutoSize = True
        Me.CheckBoxMalestar.BackColor = System.Drawing.Color.Transparent
        Me.CheckBoxMalestar.Location = New System.Drawing.Point(541, 382)
        Me.CheckBoxMalestar.Name = "CheckBoxMalestar"
        Me.CheckBoxMalestar.Size = New System.Drawing.Size(35, 17)
        Me.CheckBoxMalestar.TabIndex = 71
        Me.CheckBoxMalestar.Text = "Si"
        Me.ToolTip1.SetToolTip(Me.CheckBoxMalestar, "Síntoma de malestar")
        Me.CheckBoxMalestar.UseVisualStyleBackColor = False
        '
        'CheckBoxOtroS
        '
        Me.CheckBoxOtroS.AutoSize = True
        Me.CheckBoxOtroS.BackColor = System.Drawing.Color.Transparent
        Me.CheckBoxOtroS.Location = New System.Drawing.Point(541, 401)
        Me.CheckBoxOtroS.Name = "CheckBoxOtroS"
        Me.CheckBoxOtroS.Size = New System.Drawing.Size(35, 17)
        Me.CheckBoxOtroS.TabIndex = 72
        Me.CheckBoxOtroS.Text = "Si"
        Me.ToolTip1.SetToolTip(Me.CheckBoxOtroS, "Otro síntoma")
        Me.CheckBoxOtroS.UseVisualStyleBackColor = False
        '
        'txtNombreAcompañante
        '
        Me.txtNombreAcompañante.Location = New System.Drawing.Point(198, 303)
        Me.txtNombreAcompañante.MaxLength = 20
        Me.txtNombreAcompañante.Name = "txtNombreAcompañante"
        Me.txtNombreAcompañante.Size = New System.Drawing.Size(121, 20)
        Me.txtNombreAcompañante.TabIndex = 73
        Me.ToolTip1.SetToolTip(Me.txtNombreAcompañante, "Ingresar nombre del acompañante del paciente")
        '
        'txtMotivo
        '
        Me.txtMotivo.Location = New System.Drawing.Point(198, 338)
        Me.txtMotivo.MaxLength = 240
        Me.txtMotivo.Multiline = True
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.Size = New System.Drawing.Size(271, 104)
        Me.txtMotivo.TabIndex = 74
        Me.ToolTip1.SetToolTip(Me.txtMotivo, "Ingresar motivo de consulta del paciente")
        '
        'cmdBuscar
        '
        Me.cmdBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdBuscar.Location = New System.Drawing.Point(320, 30)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(102, 33)
        Me.cmdBuscar.TabIndex = 40
        Me.cmdBuscar.Text = "Buscar"
        Me.ToolTip1.SetToolTip(Me.cmdBuscar, "Buscar paciente")
        Me.cmdBuscar.UseVisualStyleBackColor = False
        '
        'cmdIngresar
        '
        Me.cmdIngresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdIngresar.Location = New System.Drawing.Point(7, 454)
        Me.cmdIngresar.Name = "cmdIngresar"
        Me.cmdIngresar.Size = New System.Drawing.Size(102, 33)
        Me.cmdIngresar.TabIndex = 40
        Me.cmdIngresar.Text = "Ingresar"
        Me.ToolTip1.SetToolTip(Me.cmdIngresar, "Alta entrevista inicial")
        Me.cmdIngresar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(318, 203)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 20)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Enfermedad familiar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 236)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 20)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Enfermedad actual"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 269)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 20)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Antecedentes personales"
        '
        'txtEnfermedadActual
        '
        Me.txtEnfermedadActual.Location = New System.Drawing.Point(197, 236)
        Me.txtEnfermedadActual.MaxLength = 55
        Me.txtEnfermedadActual.Name = "txtEnfermedadActual"
        Me.txtEnfermedadActual.Size = New System.Drawing.Size(121, 20)
        Me.txtEnfermedadActual.TabIndex = 78
        Me.ToolTip1.SetToolTip(Me.txtEnfermedadActual, "Ingresar enfermedad actual del paciente")
        '
        'txtEnfermedadFamiliar
        '
        Me.txtEnfermedadFamiliar.Location = New System.Drawing.Point(509, 202)
        Me.txtEnfermedadFamiliar.Name = "txtEnfermedadFamiliar"
        Me.txtEnfermedadFamiliar.Size = New System.Drawing.Size(121, 20)
        Me.txtEnfermedadFamiliar.TabIndex = 55
        Me.ToolTip1.SetToolTip(Me.txtEnfermedadFamiliar, "Ingresar enfermedad familiar del paciente")
        '
        'txtAntecedentes
        '
        Me.txtAntecedentes.Location = New System.Drawing.Point(197, 269)
        Me.txtAntecedentes.MaxLength = 55
        Me.txtAntecedentes.Name = "txtAntecedentes"
        Me.txtAntecedentes.Size = New System.Drawing.Size(121, 20)
        Me.txtAntecedentes.TabIndex = 80
        Me.ToolTip1.SetToolTip(Me.txtAntecedentes, "Ingresar antecedentes personales del paciente")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 303)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(189, 20)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "Nombre de acompañante"
        '
        'txtOtro
        '
        Me.txtOtro.Location = New System.Drawing.Point(471, 421)
        Me.txtOtro.MaxLength = 20
        Me.txtOtro.Name = "txtOtro"
        Me.txtOtro.Size = New System.Drawing.Size(162, 20)
        Me.txtOtro.TabIndex = 83
        Me.ToolTip1.SetToolTip(Me.txtOtro, "Ingresar otro síntoma")
        Me.txtOtro.Visible = False
        '
        'gbBuscar
        '
        Me.gbBuscar.BackColor = System.Drawing.Color.Transparent
        Me.gbBuscar.Controls.Add(Me.lblBCI)
        Me.gbBuscar.Controls.Add(Me.txtCI)
        Me.gbBuscar.Controls.Add(Me.cmdBuscar)
        Me.gbBuscar.Location = New System.Drawing.Point(26, 12)
        Me.gbBuscar.Name = "gbBuscar"
        Me.gbBuscar.Size = New System.Drawing.Size(440, 89)
        Me.gbBuscar.TabIndex = 84
        Me.gbBuscar.TabStop = False
        Me.gbBuscar.Text = "BUSCAR"
        '
        'gbDatos
        '
        Me.gbDatos.BackColor = System.Drawing.Color.Transparent
        Me.gbDatos.Controls.Add(Me.Label9)
        Me.gbDatos.Controls.Add(Me.Label8)
        Me.gbDatos.Controls.Add(Me.txtTipoEnfAnt)
        Me.gbDatos.Controls.Add(Me.Label6)
        Me.gbDatos.Controls.Add(Me.txtTipoEnfActual)
        Me.gbDatos.Controls.Add(Me.cmdCancelar)
        Me.gbDatos.Controls.Add(Me.cbPulso)
        Me.gbDatos.Controls.Add(Me.dtpFecha)
        Me.gbDatos.Controls.Add(Me.Label7)
        Me.gbDatos.Controls.Add(Me.txtCIMedico)
        Me.gbDatos.Controls.Add(Me.cmdIngresar)
        Me.gbDatos.Controls.Add(Me.txtNombreAcompañante)
        Me.gbDatos.Controls.Add(Me.txtOtro)
        Me.gbDatos.Controls.Add(Me.lblEstadoDeConciencia)
        Me.gbDatos.Controls.Add(Me.Label4)
        Me.gbDatos.Controls.Add(Me.txtAntecedentes)
        Me.gbDatos.Controls.Add(Me.lblMotivoDeConsulta)
        Me.gbDatos.Controls.Add(Me.txtEnfermedadFamiliar)
        Me.gbDatos.Controls.Add(Me.lblGradoDeColaboracion)
        Me.gbDatos.Controls.Add(Me.txtEnfermedadActual)
        Me.gbDatos.Controls.Add(Me.lblMovilidad)
        Me.gbDatos.Controls.Add(Me.Label3)
        Me.gbDatos.Controls.Add(Me.lblActitud)
        Me.gbDatos.Controls.Add(Me.Label2)
        Me.gbDatos.Controls.Add(Me.lblEstadoDeNutrición)
        Me.gbDatos.Controls.Add(Me.Label1)
        Me.gbDatos.Controls.Add(Me.lblGradoDeHidratacion)
        Me.gbDatos.Controls.Add(Me.lblTemperatura)
        Me.gbDatos.Controls.Add(Me.txtMotivo)
        Me.gbDatos.Controls.Add(Me.lblPulso)
        Me.gbDatos.Controls.Add(Me.lblFrecuenciaCardiaca)
        Me.gbDatos.Controls.Add(Me.CheckBoxOtroS)
        Me.gbDatos.Controls.Add(Me.lblFrecuenciaRespiratoria)
        Me.gbDatos.Controls.Add(Me.CheckBoxMalestar)
        Me.gbDatos.Controls.Add(Me.lblFiebre)
        Me.gbDatos.Controls.Add(Me.CheckBoxDolor)
        Me.gbDatos.Controls.Add(Me.lblDolor)
        Me.gbDatos.Controls.Add(Me.CheckBoxFiebre)
        Me.gbDatos.Controls.Add(Me.lblMalestar)
        Me.gbDatos.Controls.Add(Me.txtFrecuenciaResp)
        Me.gbDatos.Controls.Add(Me.lblOtroSint)
        Me.gbDatos.Controls.Add(Me.txtFrecuenciaCardiaca)
        Me.gbDatos.Controls.Add(Me.txtEstadoConciencia)
        Me.gbDatos.Controls.Add(Me.txtTemperatura)
        Me.gbDatos.Controls.Add(Me.txtGradoDeColab)
        Me.gbDatos.Controls.Add(Me.txtGradoDeHidratacion)
        Me.gbDatos.Controls.Add(Me.txtMovilidad)
        Me.gbDatos.Controls.Add(Me.cbEstadoNutricion)
        Me.gbDatos.Controls.Add(Me.cbActitud)
        Me.gbDatos.Location = New System.Drawing.Point(26, 120)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(639, 508)
        Me.gbDatos.TabIndex = 85
        Me.gbDatos.TabStop = False
        Me.gbDatos.Text = "INGRESAR DATOS ENTREVISTA"
        Me.gbDatos.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(318, 269)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(187, 20)
        Me.Label9.TabIndex = 93
        Me.Label9.Text = "Tipo enfermedad anterior"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(318, 238)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(176, 20)
        Me.Label8.TabIndex = 92
        Me.Label8.Text = "Tipo enfermedad actual"
        '
        'txtTipoEnfAnt
        '
        Me.txtTipoEnfAnt.Location = New System.Drawing.Point(509, 269)
        Me.txtTipoEnfAnt.MaxLength = 20
        Me.txtTipoEnfAnt.Name = "txtTipoEnfAnt"
        Me.txtTipoEnfAnt.Size = New System.Drawing.Size(121, 20)
        Me.txtTipoEnfAnt.TabIndex = 91
        Me.ToolTip1.SetToolTip(Me.txtTipoEnfAnt, "Ingresar enfermedad anterior del paciente")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 20)
        Me.Label6.TabIndex = 84
        Me.Label6.Text = "Fecha"
        '
        'txtTipoEnfActual
        '
        Me.txtTipoEnfActual.Location = New System.Drawing.Point(509, 236)
        Me.txtTipoEnfActual.MaxLength = 20
        Me.txtTipoEnfActual.Name = "txtTipoEnfActual"
        Me.txtTipoEnfActual.Size = New System.Drawing.Size(121, 20)
        Me.txtTipoEnfActual.TabIndex = 90
        Me.ToolTip1.SetToolTip(Me.txtTipoEnfActual, "Ingresar tipo de enfermedad actual del paciente")
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdCancelar.Location = New System.Drawing.Point(124, 454)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(102, 33)
        Me.cmdCancelar.TabIndex = 89
        Me.cmdCancelar.Text = "Cancelar"
        Me.ToolTip1.SetToolTip(Me.cmdCancelar, "Cancelar ingreso de datos")
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cbPulso
        '
        Me.cbPulso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPulso.FormattingEnabled = True
        Me.cbPulso.Location = New System.Drawing.Point(509, 62)
        Me.cbPulso.Name = "cbPulso"
        Me.cbPulso.Size = New System.Drawing.Size(121, 21)
        Me.cbPulso.TabIndex = 88
        Me.ToolTip1.SetToolTip(Me.cbPulso, "Seleccionar pulso del paciente")
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(198, 29)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(121, 20)
        Me.dtpFecha.TabIndex = 87
        Me.ToolTip1.SetToolTip(Me.dtpFecha, "Seleccionar fecha de entrevista inicial")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(320, 303)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 20)
        Me.Label7.TabIndex = 86
        Me.Label7.Text = "C.I Médico"
        '
        'txtCIMedico
        '
        Me.txtCIMedico.Location = New System.Drawing.Point(509, 303)
        Me.txtCIMedico.MaxLength = 8
        Me.txtCIMedico.Name = "txtCIMedico"
        Me.txtCIMedico.Size = New System.Drawing.Size(121, 20)
        Me.txtCIMedico.TabIndex = 85
        Me.ToolTip1.SetToolTip(Me.txtCIMedico, "Ingresar cédula de identidad del médico")
        '
        'frmEntrevistaInicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.the_background_292720
        Me.ClientSize = New System.Drawing.Size(722, 750)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.gbBuscar)
        Me.Controls.Add(Me.gbDatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEntrevistaInicial"
        Me.Text = "ENTREVISTA INICIAL"
        Me.gbBuscar.ResumeLayout(False)
        Me.gbBuscar.PerformLayout()
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCI As System.Windows.Forms.TextBox
    Friend WithEvents lblBCI As System.Windows.Forms.Label
    Friend WithEvents lblMotivoDeConsulta As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblEstadoDeConciencia As System.Windows.Forms.Label
    Friend WithEvents lblGradoDeColaboracion As System.Windows.Forms.Label
    Friend WithEvents lblMovilidad As System.Windows.Forms.Label
    Friend WithEvents lblActitud As System.Windows.Forms.Label
    Friend WithEvents lblEstadoDeNutrición As System.Windows.Forms.Label
    Friend WithEvents lblGradoDeHidratacion As System.Windows.Forms.Label
    Friend WithEvents lblTemperatura As System.Windows.Forms.Label
    Friend WithEvents lblPulso As System.Windows.Forms.Label
    Friend WithEvents lblFrecuenciaCardiaca As System.Windows.Forms.Label
    Friend WithEvents lblFrecuenciaRespiratoria As System.Windows.Forms.Label
    Friend WithEvents lblFiebre As System.Windows.Forms.Label
    Friend WithEvents lblDolor As System.Windows.Forms.Label
    Friend WithEvents lblMalestar As System.Windows.Forms.Label
    Friend WithEvents lblOtroSint As System.Windows.Forms.Label
    Friend WithEvents txtEstadoConciencia As System.Windows.Forms.TextBox
    Friend WithEvents txtGradoDeColab As System.Windows.Forms.TextBox
    Friend WithEvents txtMovilidad As System.Windows.Forms.TextBox
    Friend WithEvents cbActitud As System.Windows.Forms.ComboBox
    Friend WithEvents cbEstadoNutricion As System.Windows.Forms.ComboBox
    Friend WithEvents txtGradoDeHidratacion As System.Windows.Forms.TextBox
    Friend WithEvents txtTemperatura As System.Windows.Forms.TextBox
    Friend WithEvents txtFrecuenciaCardiaca As System.Windows.Forms.TextBox
    Friend WithEvents txtFrecuenciaResp As System.Windows.Forms.TextBox
    Friend WithEvents CheckBoxFiebre As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxDolor As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxMalestar As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxOtroS As System.Windows.Forms.CheckBox
    Friend WithEvents txtNombreAcompañante As System.Windows.Forms.TextBox
    Friend WithEvents txtMotivo As System.Windows.Forms.TextBox
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents cmdIngresar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtEnfermedadActual As System.Windows.Forms.TextBox
    Friend WithEvents txtEnfermedadFamiliar As System.Windows.Forms.TextBox
    Friend WithEvents txtAntecedentes As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtOtro As System.Windows.Forms.TextBox
    Friend WithEvents gbBuscar As System.Windows.Forms.GroupBox
    Friend WithEvents gbDatos As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCIMedico As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbPulso As System.Windows.Forms.ComboBox
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTipoEnfAnt As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoEnfActual As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
