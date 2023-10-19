Public Class Tratamientos
    Protected _ci As Integer
    Protected _nombre As String
    Protected _id As Integer
    Protected _fechainicio As Date
    Protected _fechafinal As Date
    Protected _descripcion As String
    Protected _estadoborradop As Integer
    Protected _cn As ADODB.Connection
    'Metodos constructores
    Sub New()
        _ci = 0
        _estadoborradop = 0
        _nombre = ""
        _id = 0
        _fechainicio = New Date
        _fechafinal = New Date
        _descripcion = ""
        _cn = New ADODB.Connection
    End Sub
    Sub New(ByVal estadoborradop As Integer, ByVal ci As Integer, ByVal nombre As String, ByVal id As Integer, ByVal fechainicio As Date, ByVal fechafinal As Date, ByVal descripcion As String, ByVal cn As ADODB.Connection)
        _ci = ci
        _nombre = nombre
        _estadoborradop = estadoborradop
        _id = id
        _fechainicio = fechainicio
        _fechafinal = fechafinal
        _descripcion = descripcion
        _cn = cn
    End Sub
    'Get y set de las propiedades
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
    Property nombre As String
        Get
            Return (_nombre)
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property
    Property id As Integer
        Get
            Return (_id)
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property
    Property fechainicio As Date
        Get
            Return (_fechainicio)
        End Get
        Set(ByVal value As Date)
            _fechainicio = value
        End Set
    End Property
    Property fechafinal As Date
        Get
            Return (_fechafinal)
        End Get
        Set(ByVal value As Date)
            _fechafinal = value
        End Set
    End Property
    Property descripcion As String
        Get
            Return (_descripcion)
        End Get
        Set(ByVal value As String)
            _descripcion = value
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
    Function Buscar() As Integer
        Dim sql As String
        Dim sql2 As String
        Dim rs As New ADODB.Recordset
        Dim retorno As Integer = 0
        If cn.State = 0 Then
            retorno = 1
        Else
            sql = "select * from Tratamiento as t JOIN Realiza as r ON t.ID_Trata=r.ID_Trata where r.ID_Trata=" & _id & " AND r.CI_Paciente=" & _ci & ";"
            Try
                rs.Open(sql, _cn)
            Catch ex As Exception
                Return (2)
            End Try
            If rs.RecordCount = 0 Then
                retorno = 3
            Else
                _nombre = rs("Nombre").Value
                _ci = rs("CI_Paciente").Value
                _id = rs("ID_Trata").Value
                _fechainicio = rs("FechaInicio").Value
                _descripcion = rs("Descripcion_Trat").Value
                rs.Close()
                sql2 = "select r.FechaFinal from Tratamiento as t JOIN Realiza as r ON t.ID_Trata=r.ID_Trata where r.ID_Trata=" & _id & " AND r.CI_Paciente=" & _ci & ";"
                Try
                    rs.Open(sql2, _cn)
                Catch ex As Exception
                    Return (2)
                End Try
                If rs.RecordCount = 0 Then
                    retorno = 3
                Else
                    If rs.EOF And rs.BOF Then
                        _fechainicio = "NO ESTABLECIDA"
                    Else
                        _fechafinal = rs("FechaFinal").Value
                    End If
                    rs.Close()
                End If
            End If

        End If
        Return (retorno)
    End Function
    Function Guardar(ByVal alta As Boolean) As Integer
        Dim retorno As Integer = 0
        Dim rs As New ADODB.Recordset
        Dim sql As String
        Dim sql2 As String
        Dim sql3 As String
        Dim sql4 As String
        If cn.State = 0 Then
            retorno = 1
        Else
            If alta Then
                sql = "insert into Tratamiento (Nombre,Descripcion_Trat) VALUES ('" & _nombre & "','" & _descripcion & "');"
                Try
                    _cn.Execute(sql)
                Catch ex As Exception
                    Return (2)
                End Try
                sql2 = "SELECT MAX(ID_Trata) AS ID_TrataC FROM Tratamiento;"
                Try
                    rs.Open(sql2, _cn)
                Catch ex As Exception
                    Return (3)
                End Try
                _id = rs("ID_TrataC").Value
                rs.Close()
                sql3 = "insert into Realiza(FechaInicio,FechaFinal,CI_Paciente,ID_Trata) VALUES ('" & Format(_fechainicio, "yyyy-MM-dd HH:mm:ss") & "','" & Format(_fechafinal, "yyyy-MM-dd HH:mm:ss") & "'," & _ci & "," & _id & ");"
                Try
                    _cn.Execute(sql3)
                Catch ex As Exception
                    Return (4)
                End Try
                sql4 = "insert into Posee(ID_Estado,CI_Paciente,FechaInicio_E) VALUES ('4','" & _ci & "','" & Format(Now(), "yyyy-MM-dd HH:mm:ss") & "');"
                Try
                    _cn.Execute(sql4)
                Catch ex As Exception
                    Return (3)
                End Try
            Else
                sql = "update Tratamiento set Nombre='" & _nombre & "', Descripcion_Trat='" & _descripcion & "' where ID_Trata=" & _id & ";"
                Try
                    _cn.Execute(sql)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    Return (4)
                End Try
                sql2 = "update Realiza set FechaInicio='" & Format(_fechainicio, "yyyy-MM-dd HH:mm:ss") & "', FechaFinal='" & Format(_fechafinal, "yyyy-MM-dd HH:mm:ss") & "' where ID_Trata=" & _id & ";"
                Try
                    _cn.Execute(sql2)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    Return (4)
                End Try

            End If
        End If
        Return (retorno)
    End Function
    Function Eliminar() As Integer
        Dim sql As String
        Dim rs As New ADODB.Recordset
        Dim retorno As Integer = 0
        If cn.State = 0 Then
            retorno = 1
        Else
            sql = "update Tratamiento set EstadoBorradoT= TRUE where ID_Trata =" & _id & ";"
            Try
                _cn.Execute(sql)
            Catch ex As Exception
                Return (2)
            End Try
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
            sql = "select pa.CI_Paciente, pa.EstadoBorradoP from Persona as p JOIN Paciente as pa ON p.CI=pa.CI_Paciente JOIN Realiza as r ON pa.CI_Paciente=r.CI_Paciente JOIN Tratamiento as t ON r.ID_Trata=t.ID_Trata where EstadoBorradoT = FALSE AND pa.CI_Paciente=" & _ci & ";"
            Try
                rs.Open(sql, _cn)
            Catch ex As Exception
                MsgBox(ex.ToString)
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
            sql = "select CI_Paciente, EstadoBorradoP from Paciente where CI_Paciente=" & _ci & ";"
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
    Function idtratamiento() As List(Of Integer)
        Dim retorno As New List(Of Integer)
        Dim rs As New ADODB.Recordset
        Dim sql As String
        sql = "SELECT DISTINCT r.ID_Trata FROM Realiza as r JOIN Tratamiento as t ON r.ID_Trata=t.ID_Trata WHERE t.EstadoBorradoT=FALSE AND r.CI_Paciente=" & _ci & ";"
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
End Class
