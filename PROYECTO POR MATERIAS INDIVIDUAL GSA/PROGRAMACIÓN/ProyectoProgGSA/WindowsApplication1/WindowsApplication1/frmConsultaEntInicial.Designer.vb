<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaEntInicial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaEntInicial))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gbBuscar = New System.Windows.Forms.GroupBox()
        Me.lblBCI = New System.Windows.Forms.Label()
        Me.txtCI = New System.Windows.Forms.TextBox()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.gbDatos = New System.Windows.Forms.GroupBox()
        Me.txtPulso = New System.Windows.Forms.TextBox()
        Me.txtActitud = New System.Windows.Forms.TextBox()
        Me.txtEstadoNutricion = New System.Windows.Forms.TextBox()
        Me.cbFecha = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTipoEnfAnt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTipoEnfActual = New System.Windows.Forms.TextBox()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCIMedico = New System.Windows.Forms.TextBox()
        Me.txtNombreAcompañante = New System.Windows.Forms.TextBox()
        Me.txtOtro = New System.Windows.Forms.TextBox()
        Me.lblEstadoDeConciencia = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAntecedentes = New System.Windows.Forms.TextBox()
        Me.lblMotivoDeConsulta = New System.Windows.Forms.Label()
        Me.txtEnfermedadFamiliar = New System.Windows.Forms.TextBox()
        Me.lblGradoDeColaboracion = New System.Windows.Forms.Label()
        Me.txtEnfermedadActual = New System.Windows.Forms.TextBox()
        Me.lblMovilidad = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblActitud = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblEstadoDeNutrición = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblGradoDeHidratacion = New System.Windows.Forms.Label()
        Me.lblTemperatura = New System.Windows.Forms.Label()
        Me.txtMotivo = New System.Windows.Forms.TextBox()
        Me.lblPulso = New System.Windows.Forms.Label()
        Me.lblFrecuenciaCardiaca = New System.Windows.Forms.Label()
        Me.CheckBoxOtroS = New System.Windows.Forms.CheckBox()
        Me.lblFrecuenciaRespiratoria = New System.Windows.Forms.Label()
        Me.CheckBoxMalestar = New System.Windows.Forms.CheckBox()
        Me.lblFiebre = New System.Windows.Forms.Label()
        Me.CheckBoxDolor = New System.Windows.Forms.CheckBox()
        Me.lblDolor = New System.Windows.Forms.Label()
        Me.CheckBoxFiebre = New System.Windows.Forms.CheckBox()
        Me.lblMalestar = New System.Windows.Forms.Label()
        Me.txtFrecuenciaResp = New System.Windows.Forms.TextBox()
        Me.lblOtroSint = New System.Windows.Forms.Label()
        Me.txtFrecuenciaCardiaca = New System.Windows.Forms.TextBox()
        Me.txtEstadoConciencia = New System.Windows.Forms.TextBox()
        Me.txtTemperatura = New System.Windows.Forms.TextBox()
        Me.txtGradoDeColab = New System.Windows.Forms.TextBox()
        Me.txtGradoDeHidratacion = New System.Windows.Forms.TextBox()
        Me.txtMovilidad = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdConsultar = New System.Windows.Forms.Button()
        Me.gbBuscar.SuspendLayout()
        Me.gbDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 20)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = " "
        '
        'gbBuscar
        '
        Me.gbBuscar.BackColor = System.Drawing.Color.Transparent
        Me.gbBuscar.Controls.Add(Me.lblBCI)
        Me.gbBuscar.Controls.Add(Me.txtCI)
        Me.gbBuscar.Controls.Add(Me.cmdBuscar)
        Me.gbBuscar.Location = New System.Drawing.Point(22, 12)
        Me.gbBuscar.Name = "gbBuscar"
        Me.gbBuscar.Size = New System.Drawing.Size(440, 89)
        Me.gbBuscar.TabIndex = 87
        Me.gbBuscar.TabStop = False
        Me.gbBuscar.Text = "BUSCAR"
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
        'txtCI
        '
        Me.txtCI.Location = New System.Drawing.Point(53, 37)
        Me.txtCI.MaxLength = 8
        Me.txtCI.Name = "txtCI"
        Me.txtCI.Size = New System.Drawing.Size(257, 20)
        Me.txtCI.TabIndex = 41
        Me.ToolTip1.SetToolTip(Me.txtCI, "Ingresar cédula de identidad")
        '
        'cmdBuscar
        '
        Me.cmdBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdBuscar.Location = New System.Drawing.Point(320, 30)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(102, 33)
        Me.cmdBuscar.TabIndex = 40
        Me.cmdBuscar.Text = "Buscar"
        Me.ToolTip1.SetToolTip(Me.cmdBuscar, "Buscar entrevista inicial")
        Me.cmdBuscar.UseVisualStyleBackColor = False
        '
        'gbDatos
        '
        Me.gbDatos.BackColor = System.Drawing.Color.Transparent
        Me.gbDatos.Controls.Add(Me.cmdConsultar)
        Me.gbDatos.Controls.Add(Me.txtPulso)
        Me.gbDatos.Controls.Add(Me.txtActitud)
        Me.gbDatos.Controls.Add(Me.txtEstadoNutricion)
        Me.gbDatos.Controls.Add(Me.cbFecha)
        Me.gbDatos.Controls.Add(Me.Label9)
        Me.gbDatos.Controls.Add(Me.Label8)
        Me.gbDatos.Controls.Add(Me.txtTipoEnfAnt)
        Me.gbDatos.Controls.Add(Me.Label6)
        Me.gbDatos.Controls.Add(Me.txtTipoEnfActual)
        Me.gbDatos.Controls.Add(Me.cmdCancelar)
        Me.gbDatos.Controls.Add(Me.Label7)
        Me.gbDatos.Controls.Add(Me.txtCIMedico)
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
        Me.gbDatos.Location = New System.Drawing.Point(22, 120)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(639, 508)
        Me.gbDatos.TabIndex = 88
        Me.gbDatos.TabStop = False
        Me.gbDatos.Text = "INGRESAR DATOS ENTREVISTA"
        Me.gbDatos.Visible = False
        '
        'txtPulso
        '
        Me.txtPulso.Enabled = False
        Me.txtPulso.Location = New System.Drawing.Point(509, 62)
        Me.txtPulso.Name = "txtPulso"
        Me.txtPulso.Size = New System.Drawing.Size(121, 20)
        Me.txtPulso.TabIndex = 97
        Me.ToolTip1.SetToolTip(Me.txtPulso, "Pulso del paciente")
        '
        'txtActitud
        '
        Me.txtActitud.Enabled = False
        Me.txtActitud.Location = New System.Drawing.Point(197, 130)
        Me.txtActitud.MaxLength = 10
        Me.txtActitud.Name = "txtActitud"
        Me.txtActitud.Size = New System.Drawing.Size(121, 20)
        Me.txtActitud.TabIndex = 96
        Me.ToolTip1.SetToolTip(Me.txtActitud, "Actitud del paciente")
        '
        'txtEstadoNutricion
        '
        Me.txtEstadoNutricion.Enabled = False
        Me.txtEstadoNutricion.Location = New System.Drawing.Point(197, 168)
        Me.txtEstadoNutricion.Name = "txtEstadoNutricion"
        Me.txtEstadoNutricion.Size = New System.Drawing.Size(121, 20)
        Me.txtEstadoNutricion.TabIndex = 95
        Me.ToolTip1.SetToolTip(Me.txtEstadoNutricion, "Estado de nutrición del paciente")
        '
        'cbFecha
        '
        Me.cbFecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFecha.FormattingEnabled = True
        Me.cbFecha.Location = New System.Drawing.Point(197, 27)
        Me.cbFecha.Name = "cbFecha"
        Me.cbFecha.Size = New System.Drawing.Size(121, 21)
        Me.cbFecha.TabIndex = 94
        Me.ToolTip1.SetToolTip(Me.cbFecha, "Filtrar por fecha de entrevista inicial")
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
        Me.txtTipoEnfAnt.Enabled = False
        Me.txtTipoEnfAnt.Location = New System.Drawing.Point(509, 269)
        Me.txtTipoEnfAnt.MaxLength = 20
        Me.txtTipoEnfAnt.Name = "txtTipoEnfAnt"
        Me.txtTipoEnfAnt.Size = New System.Drawing.Size(121, 20)
        Me.txtTipoEnfAnt.TabIndex = 91
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
        Me.txtTipoEnfActual.Enabled = False
        Me.txtTipoEnfActual.Location = New System.Drawing.Point(509, 236)
        Me.txtTipoEnfActual.MaxLength = 20
        Me.txtTipoEnfActual.Name = "txtTipoEnfActual"
        Me.txtTipoEnfActual.Size = New System.Drawing.Size(121, 20)
        Me.txtTipoEnfActual.TabIndex = 90
        Me.ToolTip1.SetToolTip(Me.txtTipoEnfActual, "Tipo de enfermedad anterior del paciente")
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdCancelar.Location = New System.Drawing.Point(10, 460)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(102, 33)
        Me.cmdCancelar.TabIndex = 89
        Me.cmdCancelar.Text = "Cancelar"
        Me.ToolTip1.SetToolTip(Me.cmdCancelar, "Cancelar ingreso de datos")
        Me.cmdCancelar.UseVisualStyleBackColor = False
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
        Me.txtCIMedico.Enabled = False
        Me.txtCIMedico.Location = New System.Drawing.Point(509, 303)
        Me.txtCIMedico.MaxLength = 8
        Me.txtCIMedico.Name = "txtCIMedico"
        Me.txtCIMedico.Size = New System.Drawing.Size(121, 20)
        Me.txtCIMedico.TabIndex = 85
        Me.ToolTip1.SetToolTip(Me.txtCIMedico, "Cédula de identidad del médico")
        '
        'txtNombreAcompañante
        '
        Me.txtNombreAcompañante.Enabled = False
        Me.txtNombreAcompañante.Location = New System.Drawing.Point(198, 303)
        Me.txtNombreAcompañante.MaxLength = 20
        Me.txtNombreAcompañante.Name = "txtNombreAcompañante"
        Me.txtNombreAcompañante.Size = New System.Drawing.Size(121, 20)
        Me.txtNombreAcompañante.TabIndex = 73
        Me.ToolTip1.SetToolTip(Me.txtNombreAcompañante, "Nombre de acompañante del paciente")
        '
        'txtOtro
        '
        Me.txtOtro.Enabled = False
        Me.txtOtro.Location = New System.Drawing.Point(471, 421)
        Me.txtOtro.MaxLength = 20
        Me.txtOtro.Name = "txtOtro"
        Me.txtOtro.Size = New System.Drawing.Size(162, 20)
        Me.txtOtro.TabIndex = 83
        Me.ToolTip1.SetToolTip(Me.txtOtro, "Ingresar otro síntoma")
        Me.txtOtro.Visible = False
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
        'txtAntecedentes
        '
        Me.txtAntecedentes.Enabled = False
        Me.txtAntecedentes.Location = New System.Drawing.Point(197, 269)
        Me.txtAntecedentes.MaxLength = 55
        Me.txtAntecedentes.Name = "txtAntecedentes"
        Me.txtAntecedentes.Size = New System.Drawing.Size(121, 20)
        Me.txtAntecedentes.TabIndex = 80
        Me.ToolTip1.SetToolTip(Me.txtAntecedentes, "Antecedentes personales del paciente")
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
        'txtEnfermedadFamiliar
        '
        Me.txtEnfermedadFamiliar.Enabled = False
        Me.txtEnfermedadFamiliar.Location = New System.Drawing.Point(509, 202)
        Me.txtEnfermedadFamiliar.MaxLength = 55
        Me.txtEnfermedadFamiliar.Name = "txtEnfermedadFamiliar"
        Me.txtEnfermedadFamiliar.Size = New System.Drawing.Size(121, 20)
        Me.txtEnfermedadFamiliar.TabIndex = 79
        Me.ToolTip1.SetToolTip(Me.txtEnfermedadFamiliar, "Enfermedad familiar del paciente")
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
        'txtEnfermedadActual
        '
        Me.txtEnfermedadActual.Enabled = False
        Me.txtEnfermedadActual.Location = New System.Drawing.Point(197, 236)
        Me.txtEnfermedadActual.MaxLength = 55
        Me.txtEnfermedadActual.Name = "txtEnfermedadActual"
        Me.txtEnfermedadActual.Size = New System.Drawing.Size(121, 20)
        Me.txtEnfermedadActual.TabIndex = 78
        Me.ToolTip1.SetToolTip(Me.txtEnfermedadActual, "Enfermedad actual de l paciente")
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
        'txtMotivo
        '
        Me.txtMotivo.Enabled = False
        Me.txtMotivo.Location = New System.Drawing.Point(198, 338)
        Me.txtMotivo.MaxLength = 20
        Me.txtMotivo.Multiline = True
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.Size = New System.Drawing.Size(271, 104)
        Me.txtMotivo.TabIndex = 74
        Me.ToolTip1.SetToolTip(Me.txtMotivo, "Motivo de consulta del paciente")
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
        'CheckBoxOtroS
        '
        Me.CheckBoxOtroS.AutoSize = True
        Me.CheckBoxOtroS.BackColor = System.Drawing.Color.Transparent
        Me.CheckBoxOtroS.Enabled = False
        Me.CheckBoxOtroS.Location = New System.Drawing.Point(541, 401)
        Me.CheckBoxOtroS.Name = "CheckBoxOtroS"
        Me.CheckBoxOtroS.Size = New System.Drawing.Size(35, 17)
        Me.CheckBoxOtroS.TabIndex = 72
        Me.CheckBoxOtroS.Text = "Si"
        Me.ToolTip1.SetToolTip(Me.CheckBoxOtroS, "Otro síntoma")
        Me.CheckBoxOtroS.UseVisualStyleBackColor = False
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
        'CheckBoxMalestar
        '
        Me.CheckBoxMalestar.AutoSize = True
        Me.CheckBoxMalestar.BackColor = System.Drawing.Color.Transparent
        Me.CheckBoxMalestar.Enabled = False
        Me.CheckBoxMalestar.Location = New System.Drawing.Point(541, 382)
        Me.CheckBoxMalestar.Name = "CheckBoxMalestar"
        Me.CheckBoxMalestar.Size = New System.Drawing.Size(35, 17)
        Me.CheckBoxMalestar.TabIndex = 71
        Me.CheckBoxMalestar.Text = "Si"
        Me.ToolTip1.SetToolTip(Me.CheckBoxMalestar, "Síntoma de malestar")
        Me.CheckBoxMalestar.UseVisualStyleBackColor = False
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
        'CheckBoxDolor
        '
        Me.CheckBoxDolor.AutoSize = True
        Me.CheckBoxDolor.BackColor = System.Drawing.Color.Transparent
        Me.CheckBoxDolor.Enabled = False
        Me.CheckBoxDolor.Location = New System.Drawing.Point(541, 360)
        Me.CheckBoxDolor.Name = "CheckBoxDolor"
        Me.CheckBoxDolor.Size = New System.Drawing.Size(35, 17)
        Me.CheckBoxDolor.TabIndex = 70
        Me.CheckBoxDolor.Text = "Si"
        Me.ToolTip1.SetToolTip(Me.CheckBoxDolor, "Síntoma de dolor")
        Me.CheckBoxDolor.UseVisualStyleBackColor = False
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
        'CheckBoxFiebre
        '
        Me.CheckBoxFiebre.AutoSize = True
        Me.CheckBoxFiebre.BackColor = System.Drawing.Color.Transparent
        Me.CheckBoxFiebre.Enabled = False
        Me.CheckBoxFiebre.Location = New System.Drawing.Point(541, 339)
        Me.CheckBoxFiebre.Name = "CheckBoxFiebre"
        Me.CheckBoxFiebre.Size = New System.Drawing.Size(35, 17)
        Me.CheckBoxFiebre.TabIndex = 69
        Me.CheckBoxFiebre.Text = "Si"
        Me.ToolTip1.SetToolTip(Me.CheckBoxFiebre, "Síntoma de fiebre")
        Me.CheckBoxFiebre.UseVisualStyleBackColor = False
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
        'txtFrecuenciaResp
        '
        Me.txtFrecuenciaResp.Enabled = False
        Me.txtFrecuenciaResp.Location = New System.Drawing.Point(509, 130)
        Me.txtFrecuenciaResp.Name = "txtFrecuenciaResp"
        Me.txtFrecuenciaResp.Size = New System.Drawing.Size(121, 20)
        Me.txtFrecuenciaResp.TabIndex = 68
        Me.ToolTip1.SetToolTip(Me.txtFrecuenciaResp, "Frecuencia respiratoria del paciente")
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
        'txtFrecuenciaCardiaca
        '
        Me.txtFrecuenciaCardiaca.Enabled = False
        Me.txtFrecuenciaCardiaca.Location = New System.Drawing.Point(509, 93)
        Me.txtFrecuenciaCardiaca.Name = "txtFrecuenciaCardiaca"
        Me.txtFrecuenciaCardiaca.Size = New System.Drawing.Size(121, 20)
        Me.txtFrecuenciaCardiaca.TabIndex = 67
        Me.ToolTip1.SetToolTip(Me.txtFrecuenciaCardiaca, "Frecuencia cardíaca del paciente")
        '
        'txtEstadoConciencia
        '
        Me.txtEstadoConciencia.Enabled = False
        Me.txtEstadoConciencia.Location = New System.Drawing.Point(197, 202)
        Me.txtEstadoConciencia.MaxLength = 20
        Me.txtEstadoConciencia.Name = "txtEstadoConciencia"
        Me.txtEstadoConciencia.Size = New System.Drawing.Size(121, 20)
        Me.txtEstadoConciencia.TabIndex = 59
        Me.ToolTip1.SetToolTip(Me.txtEstadoConciencia, "Estado de conciencia del paciente")
        '
        'txtTemperatura
        '
        Me.txtTemperatura.Enabled = False
        Me.txtTemperatura.Location = New System.Drawing.Point(509, 29)
        Me.txtTemperatura.Name = "txtTemperatura"
        Me.txtTemperatura.Size = New System.Drawing.Size(121, 20)
        Me.txtTemperatura.TabIndex = 65
        Me.ToolTip1.SetToolTip(Me.txtTemperatura, "Temperatura del paciente")
        '
        'txtGradoDeColab
        '
        Me.txtGradoDeColab.Enabled = False
        Me.txtGradoDeColab.Location = New System.Drawing.Point(197, 62)
        Me.txtGradoDeColab.MaxLength = 20
        Me.txtGradoDeColab.Name = "txtGradoDeColab"
        Me.txtGradoDeColab.Size = New System.Drawing.Size(121, 20)
        Me.txtGradoDeColab.TabIndex = 60
        Me.ToolTip1.SetToolTip(Me.txtGradoDeColab, "Grado de colaboración asociado al paciente")
        '
        'txtGradoDeHidratacion
        '
        Me.txtGradoDeHidratacion.Enabled = False
        Me.txtGradoDeHidratacion.Location = New System.Drawing.Point(509, 168)
        Me.txtGradoDeHidratacion.MaxLength = 20
        Me.txtGradoDeHidratacion.Name = "txtGradoDeHidratacion"
        Me.txtGradoDeHidratacion.Size = New System.Drawing.Size(121, 20)
        Me.txtGradoDeHidratacion.TabIndex = 64
        Me.ToolTip1.SetToolTip(Me.txtGradoDeHidratacion, "Frado hidratación del paciente")
        '
        'txtMovilidad
        '
        Me.txtMovilidad.Enabled = False
        Me.txtMovilidad.Location = New System.Drawing.Point(197, 96)
        Me.txtMovilidad.MaxLength = 20
        Me.txtMovilidad.Multiline = True
        Me.txtMovilidad.Name = "txtMovilidad"
        Me.txtMovilidad.Size = New System.Drawing.Size(121, 20)
        Me.txtMovilidad.TabIndex = 61
        Me.ToolTip1.SetToolTip(Me.txtMovilidad, "Movilidad del paciente")
        '
        'cmdConsultar
        '
        Me.cmdConsultar.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.cmdConsultar.Location = New System.Drawing.Point(471, 447)
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(162, 37)
        Me.cmdConsultar.TabIndex = 84
        Me.cmdConsultar.Text = "Consultar dolor en las partes del cuerpo"
        Me.ToolTip1.SetToolTip(Me.cmdConsultar, "Ver las partes del cuerpo del paciente con dolor")
        Me.cmdConsultar.UseVisualStyleBackColor = False
        Me.cmdConsultar.Visible = False
        '
        'frmConsultaEntInicial
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
        Me.Name = "frmConsultaEntInicial"
        Me.Text = "CONSULTA ENTREVISTA INICIAL"
        Me.gbBuscar.ResumeLayout(False)
        Me.gbBuscar.PerformLayout()
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gbBuscar As System.Windows.Forms.GroupBox
    Friend WithEvents lblBCI As System.Windows.Forms.Label
    Friend WithEvents txtCI As System.Windows.Forms.TextBox
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents gbDatos As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTipoEnfAnt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTipoEnfActual As System.Windows.Forms.TextBox
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCIMedico As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreAcompañante As System.Windows.Forms.TextBox
    Friend WithEvents txtOtro As System.Windows.Forms.TextBox
    Friend WithEvents lblEstadoDeConciencia As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAntecedentes As System.Windows.Forms.TextBox
    Friend WithEvents lblMotivoDeConsulta As System.Windows.Forms.Label
    Friend WithEvents txtEnfermedadFamiliar As System.Windows.Forms.TextBox
    Friend WithEvents lblGradoDeColaboracion As System.Windows.Forms.Label
    Friend WithEvents txtEnfermedadActual As System.Windows.Forms.TextBox
    Friend WithEvents lblMovilidad As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblActitud As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblEstadoDeNutrición As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblGradoDeHidratacion As System.Windows.Forms.Label
    Friend WithEvents lblTemperatura As System.Windows.Forms.Label
    Friend WithEvents txtMotivo As System.Windows.Forms.TextBox
    Friend WithEvents lblPulso As System.Windows.Forms.Label
    Friend WithEvents lblFrecuenciaCardiaca As System.Windows.Forms.Label
    Friend WithEvents CheckBoxOtroS As System.Windows.Forms.CheckBox
    Friend WithEvents lblFrecuenciaRespiratoria As System.Windows.Forms.Label
    Friend WithEvents CheckBoxMalestar As System.Windows.Forms.CheckBox
    Friend WithEvents lblFiebre As System.Windows.Forms.Label
    Friend WithEvents CheckBoxDolor As System.Windows.Forms.CheckBox
    Friend WithEvents lblDolor As System.Windows.Forms.Label
    Friend WithEvents CheckBoxFiebre As System.Windows.Forms.CheckBox
    Friend WithEvents lblMalestar As System.Windows.Forms.Label
    Friend WithEvents txtFrecuenciaResp As System.Windows.Forms.TextBox
    Friend WithEvents lblOtroSint As System.Windows.Forms.Label
    Friend WithEvents txtFrecuenciaCardiaca As System.Windows.Forms.TextBox
    Friend WithEvents txtEstadoConciencia As System.Windows.Forms.TextBox
    Friend WithEvents txtTemperatura As System.Windows.Forms.TextBox
    Friend WithEvents txtGradoDeColab As System.Windows.Forms.TextBox
    Friend WithEvents txtGradoDeHidratacion As System.Windows.Forms.TextBox
    Friend WithEvents txtMovilidad As System.Windows.Forms.TextBox
    Friend WithEvents cbFecha As System.Windows.Forms.ComboBox
    Friend WithEvents txtPulso As System.Windows.Forms.TextBox
    Friend WithEvents txtActitud As System.Windows.Forms.TextBox
    Friend WithEvents txtEstadoNutricion As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cmdConsultar As System.Windows.Forms.Button
End Class
