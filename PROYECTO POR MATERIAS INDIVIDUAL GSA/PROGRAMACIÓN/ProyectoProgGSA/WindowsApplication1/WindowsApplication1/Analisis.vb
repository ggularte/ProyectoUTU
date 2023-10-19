Public Class Analisis
    Protected _ci As Integer
    Protected _cimedico As Integer
    Protected _id As Integer
    Protected _tipo As String
    Protected _fecha As Date
    Protected _fechaatiende As Date
    Protected _resultado As String
    Protected _estadoborradop As Integer
    Protected _cn As ADODB.Connection
    'Metodos constructores
    Sub New()
        _ci = 0
        _cimedico = 0
        _id = 0
        _estadoborradop = 0
        _tipo = ""
        _fecha = New Date
        _fechaatiende = New Date
        _resultado = ""
        _cn = New ADODB.Connection
    End Sub
    Sub New(ByVal estadoborradop As Integer, ByVal ci As Integer, ByVal cimedico As Integer, ByVal id As Integer, ByVal tipo As String, ByVal fecha As Date, ByVal fechaatiende As Date, ByVal resultado As String, ByVal cn As ADODB.Connection)
        _ci = ci
        _estadoborradop = estadoborradop
        _cimedico = cimedico
        _id = id
        _tipo = tipo
        _fecha = fecha
        _fechaatiende = fechaatiende
        _resultado = resultado
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
    Property cimedico As Integer
        Get
            Return (_cimedico)
        End Get
        Set(ByVal value As Integer)
            _cimedico = value
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
    Property tipo As String
        Get
            Return (_tipo)
        End Get
        Set(ByVal value As String)
            _tipo = value
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
    Property fechaatiende As Date
        Get
            Return (_fechaatiende)
        End Get
        Set(ByVal value As Date)
            _fechaatiende = value
        End Set
    End Property
    Property resultado As String
        Get
            Return (_resultado)
        End Get
        Set(ByVal value As String)
            _resultado = value
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
        Dim rs As New ADODB.Recordset
        Dim retorno As Integer = 0
        If cn.State = 0 Then
            retorno = 1
        Else
            sql = "select * from Analisis_Clinico where CI_Paciente=" & _ci & " AND ID_Analisis=" & _id & ";"
            Try
                rs.Open(sql, _cn)
            Catch ex As Exception
                Return (4)
            End Try

            If rs.RecordCount = 0 Then
                retorno = 3
            Else
                _resultado = rs("Resultado").Value
                _fecha = rs("Fecha_Analisis").Value
                _tipo = rs("TipoAnalisis").Value
            End If
            rs.Close()
        End If
        Return (retorno)
    End Function
    Function idanalisis() As List(Of Integer)
        Dim retorno As New List(Of Integer)
        Dim rs As New ADODB.Recordset
        Dim sql As String
        sql = "SELECT DISTINCT ID_Analisis FROM Analisis_Clinico WHERE EstadoBorradoA= FALSE AND CI_Paciente=" & _ci & ";"
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
            MsgBox("1")
        Else
            sql = "select an.CI_Paciente, pa.EstadoBorradoP, an.EstadoBorradoA from Persona as p JOIN Paciente as pa ON p.CI=pa.CI_Paciente JOIN Atiende as a ON pa.CI_Paciente=a.CI_Paciente JOIN Analisis_Clinico as an ON a.CI_Paciente=an.CI_Paciente  where an.EstadoBorradoA = FALSE AND an.CI_Paciente=" & _ci & ";"
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
            sql = "select pa.CI_Paciente, pa.EstadoBorradoP from Persona as p JOIN Paciente as pa ON p.CI=pa.CI_Paciente where pa.CI_Paciente=" & _ci & ";"
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
                sql = "SELECT MAX(Fecha_Atiende) AS Fecha_AtiendeC FROM Atiende WHERE CI_Paciente=" & _ci & ";"
                Try
                    rs.Open(sql, _cn)
                Catch ex As Exception
                    Return (5)
                End Try
                _fechaatiende = rs("Fecha_AtiendeC").Value
                rs.Close()
                sql2 = "SELECT CI_Medico AS CI_MedicoC FROM Atiende WHERE Fecha_Atiende='" & Format(_fechaatiende, "yyyy-MM-dd HH:mm:ss") & "' AND CI_Paciente=" & _ci & ";"
                Try
                    rs.Open(sql2, _cn)
                Catch ex As Exception
                    Return (6)
                End Try
                _cimedico = rs("CI_MedicoC").Value
                rs.Close()
                sql3 = "insert into Analisis_Clinico(CI_Paciente, TipoAnalisis, Fecha_Analisis, Resultado, CI_Medico, Fecha_Atiende) VALUES (" & _ci & ",'" & _tipo & "','" & Format(_fecha, "yyyy-MM-dd HH:mm:ss") & "','" & _resultado & "'," & _cimedico & ",'" & Format(_fechaatiende, "yyyy-MM-dd HH:mm:ss") & "');"
                Try
                    _cn.Execute(sql3)
                Catch ex As Exception
                    Return (7)
                End Try
                sql4 = "insert into Posee(ID_Estado,CI_Paciente,FechaInicio_E) VALUES ('3','" & _ci & "','" & Format(Now(), "yyyy-MM-dd HH:mm:ss") & "');"
                Try
                    _cn.Execute(sql4)
                Catch ex As Exception
                    Return (3)
                End Try
            Else
                sql = "update Analisis_Clinico set TipoAnalisis='" & _tipo & "', Fecha_Analisis='" & Format(_fecha, "yyyy-MM-dd HH:mm:ss") & "', Resultado='" & _resultado & "' where ID_Analisis=" & _id & ";"
                Try
                    _cn.Execute(sql)
                Catch ex As Exception
                    Return (8)
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
            sql = "update Analisis_Clinico set EstadoBorradoA= TRUE where ID_Analisis =" & _id & ";"
            Try
                _cn.Execute(sql)
            Catch ex As Exception
                Return (2)
            End Try
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
    Function getci() As Integer
        Dim sql As String
        Dim rs As New ADODB.Recordset
        Dim retorno As Integer = 0
        If cn.State = 0 Then
            retorno = 1
        Else
            sql = "select CI from Usuario_Rol WHERE Usuario='" & cipub & "';"
            Try
                rs.Open(sql, _cn)
            Catch ex As Exception
                MsgBox(ex.ToString)
                Return (2)
            End Try
            If rs.RecordCount = 0 Then
                retorno = 3
            Else
                _ci = rs("CI").Value
            End If
            rs.Close()
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
