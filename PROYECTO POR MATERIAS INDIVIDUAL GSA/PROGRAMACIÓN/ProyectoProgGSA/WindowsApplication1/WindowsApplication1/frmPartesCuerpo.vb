Public Class frmPartesCuerpo
    Private Sub cmdIngresar_Click(sender As Object, e As EventArgs) Handles cmdIngresar.Click
        Dim i As New EntrevistaInicial
        i.ci = Val(frmEntrevistaInicial.txtCI.Text)
        i.cimedico = frmEntrevistaInicial.txtCIMedico.Text
        i.fecha = frmEntrevistaInicial.dtpFecha.Value
        i.cn = cn
        If cbBoca.Checked = True Then
            i.boca = 1
        Else
            i.boca = 0
        End If
        If cbBrazo.Checked = True Then
            i.brazo = 1
        Else
            i.brazo = 0
        End If
        If cbCabeza.Checked = True Then
            i.cabeza = 1
        Else
            i.cabeza = 0
        End If
        If cbCuello.Checked = True Then
            i.cuello = 1
        Else
            i.cuello = 0
        End If
        If cbDedo.Checked = True Then
            i.dedo = 1
        Else
            i.dedo = 0
        End If
        If cbEspalda.Checked = True Then
            i.espalda = 1
        Else
            i.espalda = 0
        End If
        If cbEstomago.Checked = True Then
            i.estomago = 1
        Else
            i.estomago = 0
        End If
        If cbFrente.Checked = True Then
            i.frente = 1
        Else
            i.frente = 0
        End If
        If cbGarganta.Checked = True Then
            i.garganta = 1
        Else
            i.garganta = 0
        End If
        If cbHombro.Checked = True Then
            i.hombro = 1
        Else
            i.hombro = 0
        End If
        If cbMano.Checked = True Then
            i.mano = 1
        Else
            i.mano = 0
        End If
        If cbMuslo.Checked = True Then
            i.muslo = 1
        Else
            i.muslo = 0
        End If
        If cbMunieca.Checked = True Then
            i.munieca = 1
        Else
            i.munieca = 0
        End If
        If cbNariz.Checked = True Then
            i.nariz = 1
        Else
            i.nariz = 0
        End If
        If cbOjo.Checked = True Then
            i.ojo = 1
        Else
            i.ojo = 0
        End If
        If cbOreja.Checked = True Then
            i.oreja = 1
        Else
            i.oreja = 0
        End If
        If cbPantorrilla.Checked = True Then
            i.pantorrilla = 1
        Else
            i.pantorrilla = 0
        End If
        If cbPecho.Checked = True Then
            i.pecho = 1
        Else
            i.pecho = 0
        End If
        If cbPie.Checked = True Then
            i.pie = 1
        Else
            i.pie = 0
        End If
        If cbPierna.Checked = True Then
            i.pierna = 1
        Else
            i.pierna = 0
        End If
        If cbRodilla.Checked = True Then
            i.rodilla = 1
        Else
            i.rodilla = 0
        End If
        If cbTobillo.Checked = True Then
            i.tobillo = 1
        Else
            i.tobillo = 0
        End If
        If cbTrasero.Checked = True Then
            i.trasero = 1
        Else
            i.trasero = 0
        End If
        Select Case i.Guardar2(1)
            Case 0
                MsgBox("Partes del cuerpo con dolor éxitosamente.", MessageBoxIcon.Information, "S.I.BI.M - GSA")
                frmPrediccion.Show()
                Me.Close()
            Case 1 : MsgBox("Se ha perdido la sesión. Debe loguearse nuevamente.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
            Case Else : MsgBox("Hubo errores al ingresar la el dolor de las partes del cuerpo. En caso de persistir, consulte al adm. del sistema.", MessageBoxIcon.Error, "S.I.BI.M - GSA")
        End Select
        i = Nothing
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        cbBoca.Checked = False
        cbBrazo.Checked = False
        cbCabeza.Checked = False
        cbCuello.Checked = False
        cbDedo.Checked = False
        cbEspalda.Checked = False
        cbEstomago.Checked = False
        cbFrente.Checked = False
        cbGarganta.Checked = False
        cbHombro.Checked = False
        cbMano.Checked = False
        cbMuslo.Checked = False
        cbMunieca.Checked = False
        cbNariz.Checked = False
        cbOjo.Checked = False
        cbOreja.Checked = False
        cbPantorrilla.Checked = False
        cbPecho.Checked = False
        cbPie.Checked = False
        cbPierna.Checked = False
        cbRodilla.Checked = False
        cbTobillo.Checked = False
        cbTrasero.Checked = False
        Me.Close()
    End Sub

End Class