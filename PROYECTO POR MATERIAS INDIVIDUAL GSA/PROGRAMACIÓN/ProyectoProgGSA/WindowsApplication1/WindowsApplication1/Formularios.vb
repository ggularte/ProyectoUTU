Imports System.Data.SqlClient

Public Class Formularios
    Protected _idf As Integer
    Protected _idp As Integer
    Protected _tipo As String
    Protected _ci As Integer
    Protected _cimedico As Integer
    Protected _fecha As Date
    Protected _idr As Integer
    Protected _pregunta As String
    Protected _respuesta As String
    Protected _nuevapregunta As String
    Protected _estadoborradop As Integer
    Protected _cn As ADODB.Connection

    'Metodos constructores
    Sub New()
        _tipo = ""
        _respuesta = ""
        _estadoborradop = 0
        _pregunta = ""
        _nuevapregunta = ""
        _fecha = New Date
        _idf = 0
        _idr = 0
        _ci = 0
        _cimedico = 0
        _idp = 0
        _cn = New ADODB.Connection

    End Sub
    Sub New(ByVal cimedico As Integer, ByVal idr As Integer, ByVal respuesta As String, ByVal fecha As Date, ByVal estadoborradop As Integer, ByVal ci As Integer, ByVal tipo As String, ByVal pregunta As String, ByVal nuevapregunta As String, ByVal cn As ADODB.Connection, ByVal idf As Integer, ByVal idp As Integer)
        _idf = idf
        _idr = idr
        _idp = idp
        _fecha = fecha
        _cimedico = cimedico
        _tipo = tipo
        _respuesta = respuesta
        _estadoborradop = estadoborradop
        _pregunta = pregunta
        _nuevapregunta = nuevapregunta
        _cn = cn
        _ci = ci
    End Sub
    'Get y set de las propiedades
    Property cimedico As Integer
        Get
            Return (_cimedico)
        End Get
        Set(ByVal value As Integer)
            _cimedico = value
        End Set
    End Property
    Property idr As Integer
        Get
            Return (_idr)
        End Get
        Set(ByVal value As Integer)
            _idr = value
        End Set
    End Property
    Property respuesta As String
        Get
            Return (_respuesta)
        End Get
        Set(ByVal value As String)
            _respuesta = value
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
    Property tipo As String
        Get
            Return (_tipo)
        End Get
        Set(ByVal value As String)
            _tipo = value
        End Set
    End Property
    Property pregunta As String
        Get
            Return (_pregunta)
        End Get
        Set(ByVal value As String)
            _pregunta = value
        End Set
    End Property
    Property nuevapregunta As String
        Get
            Return (_nuevapregunta)
        End Get
        Set(ByVal value As String)
            _nuevapregunta = value
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
    Property idf As Integer
        Get
            Return (_idf)
        End Get
        Set(ByVal value As Integer)
            _idf = value
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
    Property cn As ADODB.Connection
        Get
            Return (_cn)
        End Get
        Set(ByVal value As ADODB.Connection)
            _cn = value
        End Set
    End Property
    Function Guardar(ByVal alta As Boolean) As Integer
        Dim retorno As Integer = 0
        Dim rs As New ADODB.Recordset
        Dim sql As String
        If cn.State = 0 Then
            retorno = 1
        Else
            If alta Then
                sql = "INSERT INTO Formulario (Tipo_Form) VALUES ('" & _tipo & "');"
                Try
                    _cn.Execute(sql)
                Catch ex As Exception
                    Return (5)
                End Try
            End If
        End If
        Return (retorno)
    End Function
    Function tipoform() As List(Of String)
        Dim retorno As New List(Of String)
        Dim rs As New ADODB.Recordset
        Dim sql As String
        sql = "SELECT DISTINCT Tipo_Form FROM Formulario WHERE EstadoBorradoF= FALSE;"
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
    Function verifyci() As Integer
        Dim sql As String
        Dim rs As New ADODB.Recordset
        Dim retorno As Integer = 0
        If cn.State = 0 Then
            retorno = 1
        Else
            sql = "select r.CI_Paciente, pa.EstadoBorradoP from Persona as p JOIN Paciente as pa ON p.CI=pa.CI_Paciente JOIN Atiende as a ON pa.CI_Paciente=a.CI_Paciente JOIN Responde as r ON a.CI_Paciente=r.CI_Paciente where r.CI_Paciente=" & _ci & ";"
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
    Function cifunc() As List(Of String)
        Dim retorno As New List(Of String)
        Dim rs As New ADODB.Recordset
        Dim sql As String
        sql = "SELECT CI_Medico FROM Atiende WHERE Fecha_Atiende= '" & Format(_fecha, "yyyy-MM-dd HH:mm:ss") & "';"
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
    Function verifyci2() As Integer
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
    Function tipoform2() As List(Of String)
        Dim retorno As New List(Of String)
        Dim rs As New ADODB.Recordset
        Dim sql As String
        sql = "SELECT DISTINCT f.Tipo_Form FROM Formulario as f JOIN Contiene as c ON f.ID_Form=c.ID_Form JOIN Tiene as t ON c.ID_Form=t.ID_Form JOIN Respuesta as r ON t.ID_Resp=r.ID_Resp JOIN Responde as re ON r.ID_Resp=re.ID_Resp WHERE f.EstadoBorradoF=FALSE AND re.CI_Paciente=" & _ci & ";"
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
    Function idform() As List(Of Integer)
        Dim retorno As New List(Of Integer)
        Dim rs As New ADODB.Recordset
        Dim sql As String
        sql = "SELECT DISTINCT ID_Form FROM Formulario WHERE EstadoBorradoF=FALSE AND Tipo_Form='" & _tipo & "';"
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
    Function Guardar1(ByVal alta As Boolean) As Integer
        Dim retorno As Integer = 0
        Dim rs As New ADODB.Recordset
        Dim sql As String
        If cn.State = 0 Then
            retorno = 1
        Else
            If alta Then
                sql = "INSERT INTO Pregunta (TextoPreg) VALUES ('" & _pregunta & "');"
                Try
                    _cn.Execute(sql)
                Catch ex As Exception
                    Return (5)
                End Try
            Else
            End If
        End If
        Return (retorno)
    End Function
    Function Guardar2(ByVal alta As Boolean) As Integer
        Dim retorno As Integer = 0
        Dim rs As New ADODB.Recordset
        Dim sql As String
        Dim sql2 As String
        If cn.State = 0 Then
            retorno = 1
        Else
            If alta Then
                sql = "SELECT ID_Preg FROM Pregunta where TextoPreg='" & _pregunta & "';"
                Try
                    rs.Open(sql, _cn)
                Catch ex As Exception
                    Return (5)
                End Try
                _idp = rs("ID_Preg").Value
                rs.Close()
                sql2 = "INSERT INTO Contiene (ID_Form,ID_Preg) VALUES ('" & _idf & "','" & _idp & "');"
                Try
                    _cn.Execute(sql2)
                Catch ex As Exception
                    Return (5)
                End Try
            Else
                sql = "SELECT ID_Preg FROM Pregunta where TextoPreg='" & _pregunta & "';"
                Try
                    rs.Open(sql, _cn)
                Catch ex As Exception
                    Return (5)
                End Try
                _idp = rs("ID_Preg").Value
                rs.Close()
                sql2 = "update Pregunta set TextoPreg='" & _nuevapregunta & "' where ID_Preg='" & _idp & "';"
                Try
                    _cn.Execute(sql2)
                Catch ex As Exception
                    Return (5)
                End Try
            End If
        End If
        Return (retorno)
    End Function
    Function preg() As List(Of String)
        Dim retorno As New List(Of String)
        Dim rs As New ADODB.Recordset
        Dim sql As String
        sql = "SELECT DISTINCT TextoPreg FROM Pregunta;"
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
    Function preg2() As List(Of String)
        Dim retorno As New List(Of String)
        Dim rs As New ADODB.Recordset
        Dim sql As String
        sql = "SELECT DISTINCT p.TextoPreg FROM Pregunta as p JOIN Contiene as c ON p.ID_Preg=c.ID_Preg WHERE c.ID_Form=" & _idf & ";"
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
    Function Eliminar() As Integer
        Dim retorno As Integer = 0
        Dim rs As New ADODB.Recordset
        Dim sql As String
        Dim sql2 As String
        Dim sql3 As String
        If cn.State = 0 Then
            retorno = 1
        Else
            sql = "SELECT ID_Preg FROM Pregunta where TextoPreg='" & _pregunta & "';"
            Try
                rs.Open(sql, _cn)
            Catch ex As Exception
                MsgBox(ex.ToString)
                Return (5)
            End Try
            _idp = rs("ID_Preg").Value
            rs.Close()
            sql2 = "delete from Tiene where ID_Preg=" & _idp & ";"
            Try
                _cn.Execute(sql2)
            Catch ex As Exception
                Return (2)
            End Try
            sql2 = "delete from Contiene where ID_Preg=" & _idp & ";"
            Try
                _cn.Execute(sql2)
            Catch ex As Exception
                Return (2)
            End Try
            sql3 = "delete from Pregunta where ID_Preg=" & _idp & ";"
            Try
                _cn.Execute(sql3)
            Catch ex As Exception
                Return (2)
            End Try
        End If
        Return (retorno)
    End Function
    Function Eliminar1() As Integer
        Dim retorno As Integer = 0
        Dim rs As New ADODB.Recordset
        Dim sql As String
        If cn.State = 0 Then
            retorno = 1
        Else
            sql = "update Formulario set EstadoBorradoF= TRUE where ID_Form=" & _idf & ";"
            Try
                _cn.Execute(sql)
            Catch ex As Exception
                Return (3)
            End Try
        End If
        Return (retorno)
    End Function
    Function tablaform() As DataTable
        Dim retorno As New DataTable
        Dim rs As New ADODB.Recordset
        Dim da As New OleDb.OleDbDataAdapter
        Dim sql As String
        sql = "select p.TextoPreg as 'Pregunta', r.TextoResp as 'Respuesta' from Pregunta as p join Tiene as t on p.ID_Preg=t.ID_Preg join Respuesta as r ON t.ID_Resp=r.ID_Resp where t.ID_Form=" & _idf & ";"
        Try
            rs.Open(sql, _cn)
        Catch ex As Exception
            Return (retorno)
        End Try
        da.Fill(retorno, rs)
        Return (retorno)
    End Function
    Function Guardar3(ByVal alta As Boolean) As Integer
        Dim retorno As Integer = 0
        Dim rs As New ADODB.Recordset
        Dim sql As String
        Dim sql2 As String
        Dim sql3 As String
        Dim sql4 As String
        Dim sql5 As String
        If cn.State = 0 Then
            retorno = 1
        Else
            If alta Then
                sql = "INSERT INTO Respuesta (TextoResp) VALUES ('" & _respuesta & "');"
                Try
                    _cn.Execute(sql)
                Catch ex As Exception
                    Return (2)
                End Try
                sql2 = "SELECT MAX(ID_Resp) AS ID_RespC FROM Respuesta;"
                Try
                    rs.Open(sql2, _cn)
                Catch ex As Exception
                    Return (3)
                End Try
                _idr = rs("ID_RespC").Value
                rs.Close()
                sql3 = "INSERT INTO Responde (CI_Medico,CI_Paciente,Fecha_Atiende,ID_Resp) VALUES (" & _cimedico & "," & _ci & ",'" & Format(_fecha, "yyyy-MM-dd HH:mm:ss") & "'," & _idr & ");"
                Try
                    _cn.Execute(sql3)
                Catch ex As Exception
                    Return (4)
                End Try
                sql4 = "SELECT ID_Preg FROM Pregunta where TextoPreg='" & _pregunta & "';"
                Try
                    rs.Open(sql4, _cn)
                Catch ex As Exception
                    Return (5)
                End Try
                _idp = rs("ID_Preg").Value
                rs.Close()
                sql5 = "INSERT INTO Tiene (ID_Form,ID_Preg,ID_Resp,FechaR) VALUES (" & _idf & "," & _idp & "," & _idr & ",'" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "');"
                Try
                    _cn.Execute(sql5)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    Return (6)
                End Try
            End If
        End If
        Return (retorno)
    End Function
    Function comprobarFecha() As Integer
        Dim sql As String
        Dim rs As New ADODB.Recordset
        Dim retorno As Integer = 0
        If cn.State = 0 Then
            retorno = 1
        Else
            sql = "select Fecha_Atiende from Atiende WHERE CI_Paciente='" & _ci & "';"
            Try
                rs.Open(sql, _cn)
            Catch ex As Exception
                MsgBox(ex.ToString)
                Return (2)
            End Try
            If rs.RecordCount = 0 Then
                retorno = 3
            Else
            End If
            rs.Close()
        End If
        Return (retorno)
    End Function
End Class

