Public Class frmABMFormulario

    Private Sub cmdCrear_Click(sender As Object, e As EventArgs) Handles cmdCrear.Click
        Dim f As New Formularios
        f.tipo = txtCrearTipoForm.Text
        f.cn = cn
        Select Case f.Guardar(1)
            Case 0
                cboTipo.Items.Clear()
                f.tipo = txtCrearTipoForm.Text
                MsgBox("Formulario creado éxitosamente.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
                f.cn = cn
                Dim lista As List(Of String)
                lista = f.tipoform()
                For Each Diagnostico In lista
                    cboTipo.Items.Add(Diagnostico)
                Next
            Case 1 : MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
            Case Else : MsgBox("Hubo errores al agregar un formulario. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
        End Select
        f = Nothing
    End Sub

    Private Sub frmABMFormulario_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Me.Close()
    End Sub

    Private Sub frmABMFormulario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f As New Formularios
        f.cn = cn
        cboTipo.Items.Clear()
        Dim lista As List(Of String)
        lista = f.tipoform()
        For Each Diagnostico In lista
            cboTipo.Items.Add(Diagnostico)
        Next
        cboPregunta.Items.Clear()
        Dim lista1 As List(Of String)
        lista1 = f.preg()
        For Each Pregunta In lista1
            cboPregunta.Items.Add(Pregunta)
        Next
    End Sub

    Private Sub cboTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipo.SelectedIndexChanged
        Dim f As New Formularios
        f.tipo = cboTipo.SelectedItem()
        f.cn = cn
        Dim lista As List(Of Integer)
        lista = f.idform()
        cboID.Items.Clear()
        cboID.ResetText()
        For Each id In lista
            cboID.Items.Add(id)
        Next
        cmdEliminarForm.Enabled = True
    End Sub

    Private Sub cmdIngresar_Click(sender As Object, e As EventArgs) Handles cmdIngresar.Click
        Dim f As New Formularios
        f.pregunta = cboPregunta.SelectedItem()
        f.idf = cboID.SelectedItem()
        f.cn = cn
        Select Case f.Guardar2(1)
            Case 0
                MsgBox("Pregunta ingresada éxitosamente.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
            Case 1 : MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
            Case Else : MsgBox("Hubo errores al ingresar la pregunta. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
        End Select
        f = Nothing
    End Sub


    Private Sub cmdModPregunta_Click(sender As Object, e As EventArgs) Handles cmdModPregunta.Click
        Dim f As New Formularios
        f.pregunta = cboPregunta.SelectedItem()
        f.nuevapregunta = txtNuevaPregunta.Text()
        f.idf = cboID.SelectedItem()
        f.cn = cn
        Select Case f.Guardar2(0)
            Case 0
                cboPregunta.Items.Clear()
                cboPregunta.ResetText()
                f.cn = cn
                Dim lista1 As List(Of String)
                lista1 = f.preg()
                For Each Pregunta In lista1
                    cboPregunta.Items.Add(Pregunta)
                Next
                MsgBox("Pregunta modificada con éxito.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
            Case 1 : MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
            Case Else : MsgBox("Hubo errores al modificar la pregunta. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
        End Select
        f = Nothing
    End Sub

    Private Sub cmdEliminarPregunta_Click(sender As Object, e As EventArgs) Handles cmdEliminarPregunta.Click
        Dim f As New Formularios
        f.pregunta = cboPregunta.SelectedItem()
        f.nuevapregunta = txtNuevaPregunta.Text()
        f.idf = cboID.SelectedItem()
        f.cn = cn
        Select Case f.Eliminar()
            Case 0
                cboPregunta.Items.Clear()
                f.cn = cn
                cboPregunta.ResetText()
                Dim lista1 As List(Of String)
                lista1 = f.preg()
                For Each Pregunta In lista1
                    cboPregunta.Items.Add(Pregunta)
                Next
                MsgBox("Pregunta eliminada con éxito.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
            Case 1 : MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
            Case Else : MsgBox("Hubo errores al eliminar la pregunta. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
        End Select
        f = Nothing
    End Sub

    Private Sub cmdEliminarForm_Click(sender As Object, e As EventArgs) Handles cmdEliminarForm.Click
        Dim f As New Formularios
        f.idf = cboID.SelectedItem()
        f.cn = cn
        Select Case f.Eliminar1()
            Case 0
                cboID.Items.Clear()
                f.cn = cn
                cboID.ResetText()
                Dim lista As List(Of Integer)
                lista = f.idform()
                For Each id In lista
                    cboID.Items.Add(id)
                Next
                cboTipo.Items.Clear()
                cboTipo.ResetText()
                Dim lista1 As List(Of String)
                lista1 = f.tipoform()
                For Each Diagnostico In lista1
                    cboTipo.Items.Add(Diagnostico)
                Next
                MsgBox("Formulario eliminado con éxito.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
            Case 1 : MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
            Case Else : MsgBox("Hubo errores al eliminar el formulario. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
        End Select
        f = Nothing
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As New Formularios
        f.pregunta = txtCrearPregunta.Text
        f.cn = cn
        Select Case f.Guardar1(1)
            Case 0
                cboPregunta.Items.Clear()
                MsgBox("Pregunta creada éxitosamente.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
                f.cn = cn
                Dim lista1 As List(Of String)
                lista1 = f.preg()
                For Each Pregunta In lista1
                    cboPregunta.Items.Add(Pregunta)
                Next
            Case 1 : MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
            Case Else : MsgBox("Hubo errores al crear la pregunta. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
        End Select
        f = Nothing
    End Sub

    Private Sub cboPregunta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPregunta.SelectedIndexChanged
        If cboPregunta.SelectedItem Is Nothing Then
            cmdEliminarPregunta.Enabled = False
            cmdModPregunta.Enabled = False
            cmdIngresar.Enabled = False
        Else
            cmdEliminarPregunta.Enabled = True
            cmdModPregunta.Enabled = True
            cmdIngresar.Enabled = True
        End If
    End Sub
End Class