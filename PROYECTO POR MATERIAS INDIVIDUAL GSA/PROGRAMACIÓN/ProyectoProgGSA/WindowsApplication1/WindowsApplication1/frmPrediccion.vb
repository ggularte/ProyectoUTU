Public Class frmPrediccion
    Private Sub frmPrediccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As New EntrevistaInicial
        txtCI.Text = frmEntrevistaInicial.txtCI.Text
        i.ci = Val(txtCI.Text)
        i.cn = cn
        Select Case i.nomape()
            Case 0 'Encontré
                txtNombre.Text = i.nombrepaciente
                txtApellido.Text = i.apellidopaciente
            Case Else
                MsgBox("Hubo errores al realizar la operación. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
        End Select
        If frmEntrevistaInicial.CheckBoxFiebre.Checked = True Then
            txtFiebre.Text = "SI"
            i.fiebre = 1
        Else
            txtFiebre.Text = "NO"
            i.fiebre = 0
        End If
        If frmEntrevistaInicial.CheckBoxDolor.Checked = True Then
            txtDolor.Text = "SI"
            cmdConsultar.Enabled = True
            i.dolor = 1
        Else
            txtDolor.Text = "NO"
            cmdConsultar.Enabled = False
            i.dolor = 0
        End If
        If frmEntrevistaInicial.CheckBoxMalestar.Checked = True Then
            txtMalestar.Text = "SI"
            i.malestar = 1
        Else
            txtMalestar.Text = "NO"
            i.malestar = 0
        End If
        If frmEntrevistaInicial.CheckBoxOtroS.Checked = True Then
            txtOtro.Text = frmEntrevistaInicial.txtOtro.Text
            i.otro = txtOtro.Text
        Else
            txtOtro.Text = "NO"
            i.otro = ""
        End If
        If txtDolor.Text.Equals("SI") Then
            DataGridView1.DataSource = i.tabladata2()
        Else
            DataGridView1.DataSource = i.tabladata1()
        End If
        i = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdConfirmar.Click
        Dim i As New EntrevistaInicial
        txtCI.Text = frmEntrevistaInicial.txtCI.Text
        i.ci = Val(txtCI.Text)
        i.fecha = frmEntrevistaInicial.dtpFecha.Value
        i.enfermedad = txtEnfermedadActual.Text
        i.cn = cn
        Select Case i.confirmarenf()
            Case 0 'Encontré
                MsgBox("Enfermedad actual del paciente modificada con éxito.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
            Case Else
                MsgBox("Hubo errores al realizar la operación. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
        End Select
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtEnfermedadActual.Text = Convert.ToString(DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString())
    End Sub

    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs) Handles cmdConsultar.Click
        Dim i As New EntrevistaInicial
        i.ci = Val(txtCI.Text)
        i.fecha = frmEntrevistaInicial.dtpFecha.Value
        i.cn = cn
        Select Case i.buscardolor()
            Case 0 'Encontré
                frmPartesCuerpo.Show()
                frmPartesCuerpo.cmdIngresar.Enabled = False
                If i.boca = 1 Then
                    frmPartesCuerpo.cbBoca.Checked = True
                Else
                    frmPartesCuerpo.cbBoca.Checked = False
                End If
                If i.brazo = 1 Then
                    frmPartesCuerpo.cbBrazo.Checked = True
                Else
                    frmPartesCuerpo.cbBrazo.Checked = False
                End If
                If i.cabeza = 1 Then
                    frmPartesCuerpo.cbCabeza.Checked = True
                Else
                    frmPartesCuerpo.cbCabeza.Checked = False
                End If
                If i.cuello = 1 Then
                    frmPartesCuerpo.cbCuello.Checked = True
                Else
                    frmPartesCuerpo.cbCuello.Checked = False
                End If
                If i.dedo = 1 Then
                    frmPartesCuerpo.cbDedo.Checked = True
                Else
                    frmPartesCuerpo.cbDedo.Checked = False
                End If
                If i.espalda = 1 Then
                    frmPartesCuerpo.cbEspalda.Checked = True
                Else
                    frmPartesCuerpo.cbEspalda.Checked = False
                End If
                If i.estomago = 1 Then
                    frmPartesCuerpo.cbEstomago.Checked = True
                Else
                    frmPartesCuerpo.cbEstomago.Checked = False
                End If
                If i.frente = 1 Then
                    frmPartesCuerpo.cbFrente.Checked = True
                Else
                    frmPartesCuerpo.cbFrente.Checked = False
                End If
                If i.garganta = 1 Then
                    frmPartesCuerpo.cbGarganta.Checked = True
                Else
                    frmPartesCuerpo.cbGarganta.Checked = False
                End If
                If i.hombro = 1 Then
                    frmPartesCuerpo.cbHombro.Checked = True
                Else
                    frmPartesCuerpo.cbHombro.Checked = False
                End If
                If i.mano = 1 Then
                    frmPartesCuerpo.cbMano.Checked = True
                Else
                    frmPartesCuerpo.cbMano.Checked = False
                End If
                If i.muslo = 1 Then
                    frmPartesCuerpo.cbMuslo.Checked = True
                Else
                    frmPartesCuerpo.cbMuslo.Checked = False
                End If
                If i.munieca = 1 Then
                    frmPartesCuerpo.cbMunieca.Checked = True
                Else
                    frmPartesCuerpo.cbMunieca.Checked = False
                End If
                If i.nariz = 1 Then
                    frmPartesCuerpo.cbNariz.Checked = True
                Else
                    frmPartesCuerpo.cbNariz.Checked = False
                End If
                If i.ojo = 1 Then
                    frmPartesCuerpo.cbOjo.Checked = True
                Else
                    frmPartesCuerpo.cbOjo.Checked = False
                End If
                If i.oreja = 1 Then
                    frmPartesCuerpo.cbOreja.Checked = True
                Else
                    frmPartesCuerpo.cbOreja.Checked = False
                End If
                If i.pantorrilla = 1 Then
                    frmPartesCuerpo.cbPantorrilla.Checked = True
                Else
                    frmPartesCuerpo.cbPantorrilla.Checked = False
                End If
                If i.pecho = 1 Then
                    frmPartesCuerpo.cbPecho.Checked = True
                Else
                    frmPartesCuerpo.cbPecho.Checked = False
                End If
                If i.pie = 1 Then
                    frmPartesCuerpo.cbPie.Checked = True
                Else
                    frmPartesCuerpo.cbPie.Checked = False
                End If
                If i.pierna = 1 Then
                    frmPartesCuerpo.cbPierna.Checked = True
                Else
                    frmPartesCuerpo.cbPierna.Checked = False
                End If
                If i.rodilla = 1 Then
                    frmPartesCuerpo.cbRodilla.Checked = True
                Else
                    frmPartesCuerpo.cbRodilla.Checked = False
                End If
                If i.tobillo = 1 Then
                    frmPartesCuerpo.cbTobillo.Checked = True
                Else
                    frmPartesCuerpo.cbTobillo.Checked = False
                End If
                If i.trasero = 1 Then
                    frmPartesCuerpo.cbTrasero.Checked = True
                Else
                    frmPartesCuerpo.cbTrasero.Checked = False
                End If
            Case Else 'No encontré
                MsgBox("Hubo errores al consultar las partes del cuerpo. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
        End Select
    End Sub
End Class