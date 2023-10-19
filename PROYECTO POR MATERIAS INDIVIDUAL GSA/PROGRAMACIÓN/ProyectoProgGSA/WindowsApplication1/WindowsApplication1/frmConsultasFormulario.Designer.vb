<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultasFormulario
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultasFormulario))
        Me.gbBuscar = New System.Windows.Forms.GroupBox()
        Me.txtCI = New System.Windows.Forms.TextBox()
        Me.lblBCI = New System.Windows.Forms.Label()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.lblFTipo = New System.Windows.Forms.Label()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.lblFID = New System.Windows.Forms.Label()
        Me.cboID = New System.Windows.Forms.ComboBox()
        Me.gbFiltros = New System.Windows.Forms.GroupBox()
        Me.dgv_Form = New System.Windows.Forms.DataGridView()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.gbFormulario = New System.Windows.Forms.GroupBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbBuscar.SuspendLayout()
        Me.gbFiltros.SuspendLayout()
        CType(Me.dgv_Form, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFormulario.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbBuscar
        '
        Me.gbBuscar.BackColor = System.Drawing.Color.Transparent
        Me.gbBuscar.Controls.Add(Me.txtCI)
        Me.gbBuscar.Controls.Add(Me.lblBCI)
        Me.gbBuscar.Controls.Add(Me.cmdBuscar)
        Me.gbBuscar.Location = New System.Drawing.Point(12, 12)
        Me.gbBuscar.Name = "gbBuscar"
        Me.gbBuscar.Size = New System.Drawing.Size(380, 45)
        Me.gbBuscar.TabIndex = 76
        Me.gbBuscar.TabStop = False
        Me.gbBuscar.Text = "BUSCAR"
        '
        'txtCI
        '
        Me.txtCI.Location = New System.Drawing.Point(37, 16)
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
        Me.lblBCI.Location = New System.Drawing.Point(6, 16)
        Me.lblBCI.Name = "lblBCI"
        Me.lblBCI.Size = New System.Drawing.Size(25, 20)
        Me.lblBCI.TabIndex = 22
        Me.lblBCI.Text = "CI"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdBuscar.Location = New System.Drawing.Point(268, 13)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(102, 25)
        Me.cmdBuscar.TabIndex = 21
        Me.cmdBuscar.Text = "Buscar"
        Me.ToolTip1.SetToolTip(Me.cmdBuscar, "Buscar formualrios")
        Me.cmdBuscar.UseVisualStyleBackColor = False
        '
        'lblFTipo
        '
        Me.lblFTipo.AutoSize = True
        Me.lblFTipo.BackColor = System.Drawing.Color.Transparent
        Me.lblFTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFTipo.Location = New System.Drawing.Point(10, 22)
        Me.lblFTipo.Name = "lblFTipo"
        Me.lblFTipo.Size = New System.Drawing.Size(39, 20)
        Me.lblFTipo.TabIndex = 70
        Me.lblFTipo.Text = "Tipo"
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Location = New System.Drawing.Point(61, 21)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(114, 21)
        Me.cboTipo.TabIndex = 71
        Me.ToolTip1.SetToolTip(Me.cboTipo, "Filtrar por tipo de formulario")
        '
        'lblFID
        '
        Me.lblFID.AutoSize = True
        Me.lblFID.BackColor = System.Drawing.Color.Transparent
        Me.lblFID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFID.Location = New System.Drawing.Point(190, 22)
        Me.lblFID.Name = "lblFID"
        Me.lblFID.Size = New System.Drawing.Size(26, 20)
        Me.lblFID.TabIndex = 72
        Me.lblFID.Text = "ID"
        '
        'cboID
        '
        Me.cboID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboID.FormattingEnabled = True
        Me.cboID.Location = New System.Drawing.Point(222, 22)
        Me.cboID.Name = "cboID"
        Me.cboID.Size = New System.Drawing.Size(114, 21)
        Me.cboID.TabIndex = 73
        Me.ToolTip1.SetToolTip(Me.cboID, "Seleccionar número identificador del formulario")
        '
        'gbFiltros
        '
        Me.gbFiltros.BackColor = System.Drawing.Color.Transparent
        Me.gbFiltros.Controls.Add(Me.cboID)
        Me.gbFiltros.Controls.Add(Me.cboTipo)
        Me.gbFiltros.Controls.Add(Me.lblFTipo)
        Me.gbFiltros.Controls.Add(Me.lblFID)
        Me.gbFiltros.Enabled = False
        Me.gbFiltros.Location = New System.Drawing.Point(12, 77)
        Me.gbFiltros.Name = "gbFiltros"
        Me.gbFiltros.Size = New System.Drawing.Size(380, 59)
        Me.gbFiltros.TabIndex = 77
        Me.gbFiltros.TabStop = False
        Me.gbFiltros.Text = "FILTROS"
        Me.gbFiltros.Visible = False
        '
        'dgv_Form
        '
        Me.dgv_Form.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_Form.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_Form.BackgroundColor = System.Drawing.SystemColors.MenuHighlight
        Me.dgv_Form.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Form.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Form.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Form.GridColor = System.Drawing.Color.White
        Me.dgv_Form.Location = New System.Drawing.Point(11, 19)
        Me.dgv_Form.Name = "dgv_Form"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Form.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Form.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack
        Me.dgv_Form.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_Form.Size = New System.Drawing.Size(698, 253)
        Me.dgv_Form.TabIndex = 78
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdCancelar.Location = New System.Drawing.Point(11, 276)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(102, 25)
        Me.cmdCancelar.TabIndex = 25
        Me.cmdCancelar.Text = "Cancelar"
        Me.ToolTip1.SetToolTip(Me.cmdCancelar, "Cancelar ingreso de datos")
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'gbFormulario
        '
        Me.gbFormulario.BackColor = System.Drawing.Color.Transparent
        Me.gbFormulario.Controls.Add(Me.dgv_Form)
        Me.gbFormulario.Controls.Add(Me.cmdCancelar)
        Me.gbFormulario.Enabled = False
        Me.gbFormulario.Location = New System.Drawing.Point(12, 153)
        Me.gbFormulario.Name = "gbFormulario"
        Me.gbFormulario.Size = New System.Drawing.Size(715, 307)
        Me.gbFormulario.TabIndex = 78
        Me.gbFormulario.TabStop = False
        Me.gbFormulario.Text = "FORMULARIO"
        Me.gbFormulario.Visible = False
        '
        'frmConsultasFormulario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.the_background_292720
        Me.ClientSize = New System.Drawing.Size(743, 472)
        Me.Controls.Add(Me.gbFormulario)
        Me.Controls.Add(Me.gbFiltros)
        Me.Controls.Add(Me.gbBuscar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConsultasFormulario"
        Me.Text = "FORMULARIOS"
        Me.gbBuscar.ResumeLayout(False)
        Me.gbBuscar.PerformLayout()
        Me.gbFiltros.ResumeLayout(False)
        Me.gbFiltros.PerformLayout()
        CType(Me.dgv_Form, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFormulario.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbBuscar As System.Windows.Forms.GroupBox
    Friend WithEvents txtCI As System.Windows.Forms.TextBox
    Friend WithEvents lblBCI As System.Windows.Forms.Label
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents lblFTipo As System.Windows.Forms.Label
    Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents lblFID As System.Windows.Forms.Label
    Friend WithEvents cboID As System.Windows.Forms.ComboBox
    Friend WithEvents gbFiltros As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_Form As System.Windows.Forms.DataGridView
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents gbFormulario As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
