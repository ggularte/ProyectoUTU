Imports System.Data.SqlClient
Public Class EntrevistaInicial
    Protected _ci As Integer
    Protected _estadoc As String
    Protected _gradoc As String
    Protected _movilidad As String
    Protected _actitud As String
    Protected _estadon As String
    Protected _gradoh As String
    Protected _motivoconsulta As String
    Protected _temperatura As Double
    Protected _pulso As String
    Protected _fechacb As Date
    Protected _frecuenciac As String
    Protected _frecuenciar As String
    Protected _fiebre As Integer
    Protected _dolor As Integer
    Protected _idp As Integer
    Protected _malestar As Integer
    Protected _otro As String
    Protected _enfermedad As String
    Protected _tipoenfactual As String
    Protected _tipoenfanterior As String
    Protected _enfermedadf As String
    Protected _cimedico As String
    Protected _nombreacompañante As String
    Protected _antecedentes As String
    Protected _nombrepaciente As String
    Protected _apellidopaciente As String
    Protected _estadoborradop As Integer
    Protected _fecha As Date
    Protected _boca As Integer
    Protected _brazo As Integer
    Protected _cabeza As Integer
    Protected _cuello As Integer
    Protected _dedo As Integer
    Protected _espalda As Integer
    Protected _estomago As Integer
    Protected _frente As Integer
    Protected _garganta As Integer
    Protected _hombro As Integer
    Protected _mano As Integer
    Protected _muslo As Integer
    Protected _munieca As Integer
    Protected _nariz As Integer
    Protected _ojo As Integer
    Protected _oreja As Integer
    Protected _pantorrilla As Integer
    Protected _pecho As Integer
    Protected _pie As Integer
    Protected _pierna As Integer
    Protected _rodilla As Integer
    Protected _tobillo As Integer
    Protected _trasero As Integer
    Protected _cn As ADODB.Connection

    Sub New()
        _ci = 0
        _estadoborradop = 0
        _cimedico = 0
        _estadoc = ""
        _gradoc = ""
        _nombrepaciente = ""
        _apellidopaciente = ""
        _movilidad = ""
        _enfermedad = ""
        _enfermedadf = ""
        _actitud = ""
        _estadon = ""
        _gradoh = ""
        _motivoconsulta = ""
        _temperatura = 0
        _idp = 0
        _pulso = ""
        _frecuenciac = ""
        _frecuenciar = ""
        _tipoenfactual = ""
        _tipoenfanterior = ""
        _fiebre = 0
        _dolor = 0
        _malestar = 0
        _nombreacompañante = ""
        _otro = ""
        _boca = 0
        _brazo = 0
        _cabeza = 0
        _cuello = 0
        _dedo = 0
        _espalda = 0
        _estomago = 0
        _frente = 0
        _garganta = 0
        _hombro = 0
        _mano = 0
        _muslo = 0
        _munieca = 0
        _nariz = 0
        _ojo = 0
        _oreja = 0
        _pantorrilla = 0
        _pecho = 0
        _pie = 0
        _pierna = 0
        _rodilla = 0
        _tobillo = 0
        _trasero = 0
        _fechacb = New Date
        _fecha = New Date
        _cn = New ADODB.Connection
    End Sub
    Sub New(ByVal nombrepaciente As String, ByVal apellidopaciente As String, ByVal idp As Integer, ByVal trasero As Integer, ByVal tobillo As Integer, ByVal rodilla As Integer, ByVal pierna As Integer, ByVal nariz As Integer, ByVal ojo As Integer, ByVal oreja As Integer, ByVal pantorilla As Integer, ByVal pecho As Integer, ByVal pie As Integer, ByVal hombro As Integer, ByVal mano As Integer, ByVal muslo As Integer, ByVal munieca As Integer, ByVal boca As Integer, ByVal brazo As Integer, ByVal cabeza As Integer, ByVal cuello As Integer, ByVal dedo As Integer, ByVal espalda As Integer, ByVal estomago As Integer, ByVal frente As Integer, ByVal garganta As Integer, ByVal estadoborradop As Integer, ByVal ci As Integer, ByVal fechacb As Date, ByVal tipoenfactual As String, ByVal tipoenfanterior As String, ByVal cimedico As Integer, ByVal estadoc As String, ByVal antecedentes As String, ByVal nombreacompañante As String, ByVal enfermedad As String, ByVal enfermedadf As String, ByVal gradoc As String, ByVal movilidad As String, ByVal actitud As String, ByVal estadon As String, ByVal gradoh As Double, ByVal temperatura As Double, ByVal pulso As Double, ByVal frecuenciac As String, ByVal frecuenciar As String, ByVal fiebre As Integer, ByVal dolor As Integer, ByVal malestar As Integer, ByVal otro As String, ByVal motivoconsultatxt As String, ByVal fecha As Date, ByVal cn As ADODB.Connection)
        _ci = ci
        _idp = idp
        _nombrepaciente = nombrepaciente
        _apellidopaciente = apellidopaciente
        _fechacb = fechacb
        _tipoenfactual = tipoenfactual
        _estadoborradop = estadoborradop
        _tipoenfanterior = tipoenfanterior
        _cimedico = cimedico
        _estadoc = estadoc
        _gradoc = gradoc
        _movilidad = movilidad
        _actitud = actitud
        _estadon = estadon
        _gradoh = gradoh
        _motivoconsulta = motivoconsulta
        _temperatura = temperatura
        _pulso = pulso
        _frecuenciac = frecuenciac
        _frecuenciar = frecuenciar
        _fiebre = fiebre
        _dolor = dolor
        _malestar = malestar
        _enfermedad = enfermedad
        _enfermedadf = enfermedadf
        _antecedentes = antecedentes
        _otro = otro
        _fecha = fecha
        _nombreacompañante = nombreacompañante
        _boca = boca
        _brazo = brazo
        _cabeza = cabeza
        _cuello = cuello
        _dedo = dedo
        _espalda = espalda
        _estomago = estomago
        _frente = frente
        _garganta = garganta
        _hombro = hombro
        _mano = mano
        _muslo = muslo
        _munieca = munieca
        _nariz = nariz
        _ojo = ojo
        _oreja = oreja
        _pantorrilla = pantorrilla
        _pecho = pecho
        _pie = pie
        _pierna = pierna
        _rodilla = rodilla
        _tobillo = tobillo
        _trasero = trasero
        _cn = cn
    End Sub
    Property nombrepaciente As String
        Get
            Return (_nombrepaciente)
        End Get
        Set(ByVal value As String)
            _nombrepaciente = value
        End Set
    End Property
    Property apellidopaciente As String
        Get
            Return (_apellidopaciente)
        End Get
        Set(ByVal value As String)
            _apellidopaciente = value
        End Set
    End Property
    Property boca As Integer
        Get
            Return (_boca)
        End Get
        Set(ByVal value As Integer)
            _boca = value
        End Set
    End Property
    Property idp As Integer
        Get
            Return (_idp)
        End Get
        Set(ByVal value As Integer)
            _idp = value
        End Set
    End Property
    Property brazo As Integer
        Get
            Return (_brazo)
        End Get
        Set(ByVal value As Integer)
            _brazo = value
        End Set
    End Property
    Property cabeza As Integer
        Get
            Return (_cabeza)
        End Get
        Set(ByVal value As Integer)
            _cabeza = value
        End Set
    End Property
    Property cuello As Integer
        Get
            Return (_cuello)
        End Get
        Set(ByVal value As Integer)
            _cuello = value
        End Set
    End Property
    Property dedo As Integer
        Get
            Return (_dedo)
        End Get
        Set(ByVal value As Integer)
            _dedo = value
        End Set
    End Property
    Property espalda As Integer
        Get
            Return (_espalda)
        End Get
        Set(ByVal value As Integer)
            _espalda = value
        End Set
    End Property
    Property estomago As Integer
        Get
            Return (_estomago)
        End Get
        Set(ByVal value As Integer)
            _estomago = value
        End Set
    End Property
    Property frente As Integer
        Get
            Return (_frente)
        End Get
        Set(ByVal value As Integer)
            _frente = value
        End Set
    End Property
    Property garganta As Integer
        Get
            Return (_garganta)
        End Get
        Set(ByVal value As Integer)
            _garganta = value
        End Set
    End Property
    Property hombro As Integer
        Get
            Return (_hombro)
        End Get
        Set(ByVal value As Integer)
            _hombro = value
        End Set
    End Property
    Property mano As Integer
        Get
            Return (_mano)
        End Get
        Set(ByVal value As Integer)
            _mano = value
        End Set
    End Property
    Property muslo As Integer
        Get
            Return (_muslo)
        End Get
        Set(ByVal value As Integer)
            _muslo = value
        End Set
    End Property
    Property munieca As Integer
        Get
            Return (_munieca)
        End Get
        Set(ByVal value As Integer)
            _munieca = value
        End Set
    End Property
    Property nariz As Integer
        Get
            Return (_nariz)
        End Get
        Set(ByVal value As Integer)
            _nariz = value
        End Set
    End Property
    Property ojo As Integer
        Get
            Return (_ojo)
        End Get
        Set(ByVal value As Integer)
            _ojo = value
        End Set
    End Property
    Property oreja As Integer
        Get
            Return (_oreja)
        End Get
        Set(ByVal value As Integer)
            _oreja = value
        End Set
    End Property
    Property pantorrilla As Integer
        Get
            Return (_pantorrilla)
        End Get
        Set(ByVal value As Integer)
            _pantorrilla = value
        End Set
    End Property
    Property pecho As Integer
        Get
            Return (_pecho)
        End Get
        Set(ByVal value As Integer)
            _pecho = value
        End Set
    End Property
    Property pie As Integer
        Get
            Return (_pie)
        End Get
        Set(ByVal value As Integer)
            _pie = value
        End Set
    End Property
    Property pierna As Integer
        Get
            Return (_pierna)
        End Get
        Set(ByVal value As Integer)
            _pierna = value
        End Set
    End Property
    Property rodilla As Integer
        Get
            Return (_rodilla)
        End Get
        Set(ByVal value As Integer)
            _rodilla = value
        End Set
    End Property
    Property tobillo As Integer
        Get
            Return (_tobillo)
        End Get
        Set(ByVal value As Integer)
            _tobillo = value
        End Set
    End Property
    Property trasero As Integer
        Get
            Return (_trasero)
        End Get
        Set(ByVal value As Integer)
            _trasero = value
        End Set
    End Property
    Property estadoborradop As Integer
        Get
            Return (_estadoborradop)
        End Get
        Set(ByVal value As Integer)
            _estadoborradop = value
        End Set
    End Property
    Property ci As Integer
        Get
            Return (_ci)
        End Get
        Set(ByVal value As Integer)
            _ci = value
        End Set
    End Property
    Property fechacb As Date
        Get
            Return (_fechacb)
        End Get
        Set(ByVal value As Date)
            _fechacb = value
        End Set
    End Property
    Property tipoenfactual As String
        Get
            Return (_tipoenfactual)
        End Get
        Set(ByVal value As String)
            _tipoenfactual = value
        End Set
    End Property
    Property tipoenfanterior As String
        Get
            Return (_tipoenfanterior)
        End Get
        Set(ByVal value As String)
            _tipoenfanterior = value
        End Set
    End Property
    Property cimedico As Integer
        Get
            Return (_cimedico)
        End Get
        Set(ByVal value As Integer)
            _cimedico = value
        End Set
    End Property
    Property estadoc As String
        Get
            Return (_estadoc)
        End Get
        Set(ByVal value As String)
            _estadoc = value
        End Set
    End Property
    Property antecedentes As String
        Get
            Return (_antecedentes)
        End Get
        Set(ByVal value As String)
            _antecedentes = value
        End Set
    End Property
    Property gradoc As String
        Get
            Return (_gradoc)
        End Get
        Set(ByVal value As String)
            _gradoc = value
        End Set
    End Property
    Property nombreacompañante As String
        Get
            Return (_nombreacompañante)
        End Get
        Set(ByVal value As String)
            _nombreacompañante = value
        End Set
    End Property
    Property movilidad As String
        Get
            Return (_movilidad)
        End Get
        Set(ByVal value As String)
            _movilidad = value
        End Set
    End Property
    Property enfermedad As String
        Get
            Return (_enfermedad)
        End Get
        Set(ByVal value As String)
            _enfermedad = value
        End Set
    End Property
    Property enfermedadf As String
        Get
            Return (_enfermedadf)
        End Get
        Set(ByVal value As String)
            _enfermedadf = value
        End Set
    End Property
    Property actitud As String
        Get
            Return (_actitud)
        End Get
        Set(ByVal value As String)
            _actitud = value
        End Set
    End Property
    Property estadon As String
        Get
            Return (_estadon)
        End Get
        Set(ByVal value As String)
            _estadon = value
        End Set
    End Property
    Property gradoh As String
        Get
            Return (_gradoh)
        End Get
        Set(ByVal value As String)
            _gradoh = value
        End Set
    End Property
    Property motivoconsulta As String
        Get
            Return (_motivoconsulta)
        End Get
        Set(ByVal value As String)
            _motivoconsulta = value
        End Set
    End Property
    Property temperatura As Double
        Get
            Return (_temperatura)
        End Get
        Set(ByVal value As Double)
            _temperatura = value
        End Set
    End Property
    Property pulso As String
        Get
            Return (_pulso)
        End Get
        Set(ByVal value As String)
            _pulso = value
        End Set
    End Property
    Property frecuenciac As String
        Get
            Return (_frecuenciac)
        End Get
        Set(ByVal value As String)
            _frecuenciac = value
        End Set
    End Property
    Property frecuenciar As String
        Get
            Return (_frecuenciar)
        End Get
        Set(ByVal value As String)
            _frecuenciar = value
        End Set
    End Property
    Property otro As String
        Get
            Return (_otro)
        End Get
        Set(ByVal value As String)
            _otro = value
        End Set
    End Property
    Property fiebre As Integer
        Get
            Return (_fiebre)
        End Get
        Set(ByVal value As Integer)
            _fiebre = value
        End Set
    End Property
    Property dolor As Integer
        Get
            Return (_dolor)
        End Get
        Set(ByVal value As Integer)
            _dolor = value
        End Set
    End Property
    Property malestar As Integer
        Get
            Return (_malestar)
        End Get
        Set(ByVal value As Integer)
            _malestar = value
        End Set
    End Property
    Property cn As ADODB.Connection
        Get
            Return (_cn)
        End Get
        Set(ByVal value As ADODB.Connection)
            _cn = value
        End Set
    End Property
    Property fecha As Date
        Get
            Return (_fecha)
        End Get
        Set(ByVal value As Date)
            _fecha = value
        End Set
    End Property
    Function Buscar() As Integer
        Dim sql As String
        Dim rs As New ADODB.Recordset
        Dim retorno As Integer = 0
        If cn.State = 0 Then
            retorno = 1
        Else
            sql = "select * from Atiende WHERE Fecha_Atiende='" & Format(_fechacb, "yyyy-MM-dd HH:mm:ss") & "';"
            Try
                rs.Open(sql, _cn)
            Catch ex As Exception
                Return (2)
            End Try
            If rs.RecordCount = 0 Then
                retorno = 3
            Else
                _actitud = rs("Actitud").Value
                _antecedentes = rs("Antecedentes_Personales").Value
                _dolor = rs("Dolor").Value
                _enfermedad = rs("Enfermedad_Actual").Value
                _enfermedadf = rs("Enfermedad_Familiar").Value
                _estadoc = rs("Estado_De_Conciencia").Value
                _estadon = rs("Estado_De_Nutricion").Value
                _fiebre = rs("Fiebre").Value
                _frecuenciac = rs("Frecuencia_Cardiaca").Value
                _frecuenciar = rs("Frecuencia_Respiratoria").Value
                _gradoc = rs("Grado_De_Colaboracion").Value
                _gradoh = rs("Grado_De_Hidratacion").Value
                _malestar = rs("Malestar").Value
                _motivoconsulta = rs("Motivo").Value
                _movilidad = rs("Movilidad").Value
                _nombreacompañante = rs("Nombre_Acompaniante").Value
                _otro = rs("Otro").Value
                _pulso = rs("Pulso").Value
                _temperatura = rs("Temperatura").Value
                _tipoenfactual = rs("Tipo_EnfermedadActual").Value
                _tipoenfanterior = rs("Tipo_EnfermedadAnterior").Value
                _cimedico = rs("CI_Medico").Value
                rs.Close()
            End If
        End If
        Return (retorno)
    End Function
    Function Guardar(ByVal alta As Boolean) As Integer
        Dim retorno As Integer = 0
        Dim rs As New ADODB.Recordset
        Dim sql As String
        Dim sql2 As String
        If cn.State = 0 Then
            retorno = 1
        Else
            If alta Then
                sql = "insert into Atiende (CI_Paciente, Estado_De_Conciencia, Grado_De_Colaboracion, Movilidad, Grado_De_Hidratacion, Motivo, Temperatura, Frecuencia_Cardiaca, Frecuencia_Respiratoria, Otro, Actitud, Estado_de_Nutricion, Pulso, Enfermedad_Actual, Nombre_Acompaniante, Enfermedad_Familiar, Antecedentes_Personales, Fiebre, Dolor, Malestar, Fecha_Atiende, CI_Medico, Tipo_EnfermedadActual, Tipo_EnfermedadAnterior) VALUES ('" & _ci & "','" & _estadoc & "','" & _gradoc & "','" & _movilidad & "','" & _gradoh & "','" & _motivoconsulta & "','" & _temperatura & "','" & _frecuenciac & "','" & _frecuenciar & "','" & _otro & "','" & _actitud & "','" & _estadon & "','" & _pulso & "','" & _enfermedad & "','" & _nombreacompañante & "','" & _enfermedadf & "','" & _antecedentes & "','" & _fiebre & "','" & _dolor & "','" & _malestar & "','" & Format(_fecha, "yyyy-MM-dd HH:mm:ss") & "','" & _cimedico & "','" & _tipoenfactual & "','" & _tipoenfanterior & "');"
                Try
                    cn.Execute(sql)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    Return (2)
                End Try
                sql2 = "insert into Posee(ID_Estado,CI_Paciente,FechaInicio_E) VALUES ('2','" & _ci & "','" & Format(Now(), "yyyy-MM-dd HH:mm:ss") & "');"
                Try
                    _cn.Execute(sql2)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    Return (3)
                End Try
            End If
        End If
        Return (retorno)
    End Function
    Function verifyci() As Integer
        Dim sql As String
        Dim rs As New ADODB.Recordset
        Dim retorno As Integer = 0
        If cn.State = 0 Then
            retorno = 1
        Else
            sql = "select pa.CI_Paciente, pa.EstadoBorradoP from Persona as p JOIN Paciente as pa ON p.CI=pa.CI_Paciente where pa.CI_Paciente=" & _ci & ";"
            Try
                rs.Open(sql, _cn)
            Catch ex As Exception
                Return (4)
            End Try
            If rs.RecordCount = 0 Then
                retorno = 3
            Else
                _ci = rs("CI_Paciente").Value
                _estadoborradop = rs("EstadoBorradoP").Value
                rs.Close()
            End If
        End If
        Return (retorno)
    End Function
    Function verifyci2() As Integer
        Dim sql As String
        Dim rs As New ADODB.Recordset
        Dim retorno As Integer = 0
        If cn.State = 0 Then
            retorno = 1
        Else
            sql = "select pa.CI_Paciente, pa.EstadoBorradoP from Persona as p JOIN Paciente as pa ON p.CI=pa.CI_Paciente JOIN Atiende as a ON pa.CI_Paciente=a.CI_Paciente where a.CI_Paciente=" & _ci & ";"
            Try
                rs.Open(sql, _cn)
            Catch ex As Exception
                Return (4)
            End Try
            If rs.RecordCount = 0 Then
                retorno = 3
            Else
                _ci = rs("CI_Paciente").Value
                _estadoborradop = rs("EstadoBorradoP").Value
                rs.Close()
            End If
        End If
        Return (retorno)
    End Function
    Function buscardolor() As Integer
        Dim sql As String
        Dim rs As New ADODB.Recordset
        Dim retorno As Integer = 0
        If cn.State = 0 Then
            retorno = 1
        Else
            sql = "select * from PartesCuerpo as pc JOIN Incluye as i ON pc.ID_Partes=i.ID_Partes JOIN Atiende as a ON i.CI_Paciente=a.CI_Paciente where i.Fecha_Atiende='" & Format(_fecha, "yyyy-MM-dd HH:mm:ss") & "';"
            Try
                rs.Open(sql, _cn)
            Catch ex As Exception
                Return (4)
            End Try
            If rs.RecordCount = 0 Then
                retorno = 3
            Else
                _boca = rs("Boca").Value
                _brazo = rs("Brazo").Value
                _cabeza = rs("Cabeza").Value
                _cuello = rs("Cuello").Value
                _dedo = rs("Dedo").Value
                _espalda = rs("Espalda").Value
                _estomago = rs("Estomago").Value
                _frente = rs("Frente").Value
                _garganta = rs("Garganta").Value
                _hombro = rs("Hombro").Value
                _mano = rs("Mano").Value
                _muslo = rs("Muslo").Value
                _munieca = rs("Munieca").Value
                _nariz = rs("Nariz").Value
                _ojo = rs("Ojo").Value
                _oreja = rs("Oreja").Value
                _pantorrilla = rs("Pantorrilla").Value
                _pecho = rs("Pecho").Value
                _pie = rs("Pie").Value
                _pierna = rs("Pierna").Value
                _rodilla = rs("Rodilla").Value
                _tobillo = rs("Tobillo").Value
                _trasero = rs("Trasero").Value
                rs.Close()
            End If
        End If
        Return (retorno)
    End Function
    Function actitudE() As List(Of String)
        Dim retorno As New List(Of String)
        Dim rs As New ADODB.Recordset
        Dim sql As String
        sql = "SELECT DISTINCT Actitud FROM Atiende;"
        Try
            rs = _cn.Execute(sql)
        Catch ex As Exception
            Return (retorno)
        End Try
        retorno.Clear()
        While Not rs.EOF
            retorno.Add(rs(0).Value)
            rs.MoveNext()
        End While
        rs.Close()
        rs = Nothing
        Return (retorno)
    End Function
    Function fechafunc() As List(Of String)
        Dim retorno As New List(Of String)
        Dim rs As New ADODB.Recordset
        Dim sql As String
        sql = "SELECT Fecha_Atiende FROM Atiende WHERE CI_Paciente= " & _ci & ";"
        Try
            rs = _cn.Execute(sql)
        Catch ex As Exception
            Return (retorno)
        End Try
        retorno.Clear()
        While Not rs.EOF
            retorno.Add(rs(0).Value)
            rs.MoveNext()
        End While
        rs.Close()
        rs = Nothing
        Return (retorno)
    End Function
    Function estadonE() As List(Of String)
        Dim retorno As New List(Of String)
        Dim rs As New ADODB.Recordset
        Dim sql As String
        sql = "SELECT DISTINCT Estado_De_Nutricion FROM Atiende;"
        Try
            rs = _cn.Execute(sql)
        Catch ex As Exception
            Return (retorno)
        End Try
        retorno.Clear()
        While Not rs.EOF
            retorno.Add(rs(0).Value)
            rs.MoveNext()
        End While
        rs.Close()
        rs = Nothing
        Return (retorno)
    End Function
    Function pulsoE() As List(Of String)
        Dim retorno As New List(Of String)
        Dim rs As New ADODB.Recordset
        Dim sql As String
        sql = "SELECT DISTINCT Pulso FROM Atiende;"
        Try
            rs = _cn.Execute(sql)
        Catch ex As Exception
            Return (retorno)
        End Try
        retorno.Clear()
        While Not rs.EOF
            retorno.Add(rs(0).Value)
            rs.MoveNext()
        End While
        rs.Close()
        rs = Nothing
        Return (retorno)
    End Function
    Function estadop() As Integer
        Dim sql As String
        Dim rs As New ADODB.Recordset
        Dim retorno As Integer = 0
        If cn.State = 0 Then
            retorno = 1
        Else
            sql = "update Paciente set EstadoBorradoP= False where CI_Paciente =" & _ci & ";"
            Try
                _cn.Execute(sql)
            Catch ex As Exception
                Return (2)
            End Try
        End If
        Return (retorno)
    End Function
    Function Guardar2(ByVal alta As Boolean) As Integer
        Dim retorno As Integer = 0
        Dim rs As New ADODB.Recordset
        Dim sql As String
        Dim sql2 As String
        Dim sql3 As String
        If cn.State = 0 Then
            retorno = 1
        Else
            If alta Then
                sql = "insert into PartesCuerpo (Cabeza, Cuello, Brazo, Mano, Muslo, Pantorrilla, Oreja, Hombro, Espalda, Trasero, Tobillo, Ojo, Nariz, Boca, Munieca, Dedo, Pierna, Frente, Garganta, Pecho, Estomago, Rodilla, Pie) VALUES ('" & _cabeza & "','" & _cuello & "','" & _brazo & "','" & _mano & "','" & _muslo & "','" & _pantorrilla & "','" & _oreja & "','" & _hombro & "','" & _espalda & "','" & _trasero & "','" & _tobillo & "','" & _ojo & "','" & _nariz & "','" & _boca & "','" & _munieca & "','" & _dedo & "','" & _pierna & "','" & _frente & "','" & _garganta & "','" & _pecho & "','" & _estomago & "','" & _rodilla & "','" & _pie & "');"
                Try
                    cn.Execute(sql)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    Return (2)
                End Try
                sql2 = "SELECT MAX(ID_Partes) AS ID_PartesC FROM PartesCuerpo;"
                Try
                    rs.Open(sql2, _cn)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    Return (3)
                End Try
                _idp = rs("ID_PartesC").Value
                sql3 = "insert into Incluye (ID_Partes, CI_Paciente, CI_Medico, Fecha_Atiende) VALUES ('" & _idp & "','" & _ci & "','" & _cimedico & "','" & Format(_fecha, "yyyy-MM-dd HH:mm:ss") & "');"
                Try
                    cn.Execute(sql3)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    Return (2)
                End Try
            End If
        End If
        Return (retorno)
    End Function
    Function tabladata1() As DataTable
        Dim retorno As New DataTable
        Dim rs As New ADODB.Recordset
        Dim da As New OleDb.OleDbDataAdapter
        Dim sql As String
        sql = "select Enfermedad_Actual as 'Enfermedad' from vista_SintomasAtiendeSD where Dolor =" & _dolor & " AND Fiebre =" & _fiebre & " AND Malestar =" & _malestar & " AND Otro='" & _otro & "';"
        Try
            rs.Open(sql, _cn)
        Catch ex As Exception
            Return (retorno)
        End Try
        da.Fill(retorno, rs)
        Return (retorno)
    End Function
    Function tabladata2() As DataTable
        Dim retorno As New DataTable
        Dim rs As New ADODB.Recordset
        Dim da As New OleDb.OleDbDataAdapter
        Dim sql As String
        sql = "select Enfermedad_Actual as 'Enfermedad' from vista_SintomasAtiendeCD where Dolor =" & _dolor & " AND Fiebre =" & _fiebre & " AND Malestar =" & _malestar & " AND Otro='" & _otro & "' AND Cabeza =" & _cabeza & " AND Cuello =" & _cuello & " AND Brazo=" & _brazo & " AND Mano =" & _mano & " AND Muslo =" & _muslo & " AND Pantorrilla=" & _pantorrilla & " AND Oreja =" & _oreja & " AND Hombro =" & _hombro & " AND Espalda=" & _espalda & " AND Trasero =" & _trasero & " AND Tobillo =" & _tobillo & " AND Ojo=" & _ojo & " AND Nariz =" & _nariz & " AND Boca =" & _boca & " AND Munieca=" & _munieca & " AND Dedo =" & _dedo & " AND Pierna =" & _pierna & " AND Frente=" & _frente & " AND Garganta =" & _garganta & " AND Pecho =" & _pecho & " AND Estomago=" & _estomago & " AND Rodilla =" & _rodilla & " AND Pie=" & _pie & ";"
        Try
            rs.Open(sql, _cn)
        Catch ex As Exception
            Return (retorno)
        End Try
        da.Fill(retorno, rs)
        Return (retorno)
    End Function
    Function nomape() As Integer
        Dim sql As String
        Dim rs As New ADODB.Recordset
        Dim retorno As Integer = 0
        If cn.State = 0 Then
            retorno = 1
        Else
            sql = "select Primer_Nombre, Primer_Apellido from Persona where CI=" & _ci & ";"
            Try
                rs.Open(sql, _cn)
            Catch ex As Exception
                Return (4)
            End Try
            If rs.RecordCount = 0 Then
                retorno = 3
            Else
                _nombrepaciente = rs("Primer_Nombre").Value
                _apellidopaciente = rs("Primer_Apellido").Value
                rs.Close()
            End If
        End If
        Return (retorno)
    End Function
    Function confirmarenf() As Integer
        Dim sql As String
        Dim rs As New ADODB.Recordset
        Dim retorno As Integer = 0
        If cn.State = 0 Then
            retorno = 1
        Else
            sql = "update Atiende set Enfermedad_Actual='" & _enfermedad & "' where CI_Paciente=" & _ci & " AND Fecha_Atiende='" & Format(_fecha, "yyyy-MM-dd HH:mm:ss") & "';"
            Try
                _cn.Execute(sql)
            Catch ex As Exception
                Return (2)
            End Try
        End If
        Return (retorno)
    End Function
End Class
