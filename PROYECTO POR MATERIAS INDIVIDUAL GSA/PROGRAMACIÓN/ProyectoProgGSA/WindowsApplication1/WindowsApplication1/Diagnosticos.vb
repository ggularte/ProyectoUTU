Public Class Diagnosticos
    Protected _id As Integer
    Protected _ci As Integer
    Protected _tipo As String
    Protected _fecha As Date
    Protected _fechaatiende As Date
    Protected _nombreD As String
    Protected _descripcion As String
    Protected _estadoborradop As Integer
    Protected _enfactual As String
    Protected _cimedico As Integer
    Protected _cn As ADODB.Connection
    'Metodos constructores
    Sub New()
        _ci = 0
        _cimedico = 0
        _tipo = ""
        _enfactual = ""
        _fecha = New Date
        _fechaatiende = New Date
        _descripcion = ""
        _estadoborradop = 0
        _nombreD = ""
        _cn = New ADODB.Connection
        _id = 0
    End Sub

    Sub New(ByVal enfactual As String, ByVal estadoborradop As Integer, ByVal ci As Integer, ByVal nombreD As String, ByVal cimedico As Integer, ByVal tipo As String, ByVal fechaatiende As Date, ByVal fecha As Date, ByVal descripcion As String, ByVal cn As ADODB.Connection, ByVal id As Integer)
        _ci = ci
        _enfactual = enfactual
        _estadoborradop = estadoborradop
        _tipo = tipo
        _fecha = fecha
        _fechaatiende = fechaatiende
        _descripcion = descripcion
        _cn = cn
        _id = id
        _nombreD = nombreD
        _cimedico = cimedico
    End Sub
    'Get y set de las propiedades
    Property enfactual As String
        Get
            Return (_enfactual)
        End Get
        Set(ByVal value As String)
            _enfactual = value
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
    Property cimedico As Integer
        Get
            Return (_cimedico)
        End Get
        Set(ByVal value As Integer)
            _cimedico = value
        End Set
    End Property
    Property nombreD As String
        Get
            Return (_nombreD)
        End Get
        Set(ByVal value As String)
            _nombreD = value
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
    Property id As Integer
        Get
            Return (_id)
        End Get
        Set(ByVal value As Integer)
            _id = value
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
    Function Buscar() As Integer
        Dim sql As String
        Dim rs As New ADODB.Recordset
        Dim retorno As Integer = 0
        If cn.State = 0 Then
            retorno = 1
        Else
            sql = "select * from Diagnostico as d JOIN Elabora as e ON d.ID_Diag=e.ID_Diag where e.ID_Diag=" & _id & " AND e.CI_Paciente=" & _ci & ";"
            Try
                rs.Open(sql, _cn)
            Catch ex As Exception
                Return (4)
            End Try
            If rs.RecordCount = 0 Then
                retorno = 3
            Else
                _ci = rs("CI_Paciente").Value
                _descripcion = rs("Descripcion_Diag").Value
                _fecha = rs("Fecha_Diag").Value
                _nombreD = rs("Tipo_Diag").Value
            End If
            rs.Close()
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
        Dim sql5 As String
        Dim sql6 As String
        If cn.State = 0 Then
            retorno = 1
        Else
            If alta Then
                sql = "insert into Diagnostico (Tipo_Diag,Descripcion_Diag) VALUES ('" & _tipo & "','" & _descripcion & "');"
                Try
                    _cn.Execute(sql)
                Catch ex As Exception
                    Return (4)
                End Try
                sql2 = "SELECT MAX(ID_Diag) AS ID_DiagC FROM Diagnostico;"
                Try
                    rs.Open(sql2, _cn)
                Catch ex As Exception
                    Return (4)
                End Try
                _id = rs("ID_DiagC").Value
                rs.Close()
                sql3 = "SELECT MAX(Fecha_Atiende) AS Fecha_AtiendeC FROM Atiende WHERE CI_Paciente=" & _ci & ";"
                Try
                    rs.Open(sql3, _cn)
                Catch ex As Exception
                    Return (5)
                End Try
                _fechaatiende = rs("Fecha_AtiendeC").Value
                rs.Close()
                sql4 = "SELECT CI_Medico AS CI_MedicoC FROM Atiende WHERE Fecha_Atiende='" & Format(_fechaatiende, "yyyy-MM-dd HH:mm:ss") & "' AND CI_Paciente=" & _ci & ";"
                Try
                    rs.Open(sql4, _cn)
                Catch ex As Exception
                    Return (6)
                End Try
                _cimedico = rs("CI_MedicoC").Value
                rs.Close()
                sql5 = "insert into Elabora(ID_Diag,Fecha_Diag,Fecha_Atiende,CI_Medico,CI_Paciente) VALUES (" & _id & ",'" & Format(_fecha, "yyyy-MM-dd HH:mm:ss") & "','" & Format(_fechaatiende, "yyyy-MM-dd HH:mm:ss") & "'," & _cimedico & "," & _ci & ");"
                Try
                    _cn.Execute(sql5)
                Catch ex As Exception
                    Return (2)
                End Try
                sql6 = "insert into Posee(ID_Estado,CI_Paciente,FechaInicio_E) VALUES ('3','" & _ci & "','" & Format(Now(), "yyyy-MM-dd HH:mm:ss") & "');"
                Try
                    _cn.Execute(sql6)
                Catch ex As Exception
                    Return (3)
                End Try
            Else
                sql = "update Diagnostico set Tipo_Diag='" & _tipo & "', Descripcion_Diag='" & _descripcion & "' where ID_Diag=" & _id & ";"
                Try
                    _cn.Execute(sql)
                Catch ex As Exception
                    Return (7)
                End Try
                sql = "update Elabora set Fecha_Diag='" & Format(_fecha, "yyyy-MM-dd HH:mm:ss") & "' where ID_Diag=" & _id & ";"
                Try
                    _cn.Execute(sql)
                Catch ex As Exception
                    Return (8)
                End Try
            End If
        End If
        Return (retorno)
    End Function
    Function iddiag() As List(Of Integer)
        Dim retorno As New List(Of Integer)
        Dim rs As New ADODB.Recordset
        Dim sql As String
        sql = "SELECT DISTINCT e.ID_Diag FROM Elabora as e JOIN Diagnostico as d ON e.ID_Diag=d.ID_Diag WHERE d.EstadoBorradoD=FALSE AND e.CI_Paciente=" & _ci & ";"
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
        Dim sql As String
        Dim rs As New ADODB.Recordset
        Dim retorno As Integer = 0
        If cn.State = 0 Then
            retorno = 1
        Else
            sql = "update Diagnostico set EstadoBorradoD= TRUE where ID_Diag =" & _id & ";"
            Try
                _cn.Execute(sql)
            Catch ex As Exception
                Return (2)
            End Try
        End If
        Return (retorno)
    End Function
    Function setenfactual() As Integer
        Dim sql As String
        Dim sql2 As String
        Dim rs As New ADODB.Recordset
        Dim retorno As Integer = 0
        If cn.State = 0 Then
            retorno = 1
        Else
            sql = "SELECT MAX(Fecha_Atiende) AS Fecha_AtiendeC FROM Atiende WHERE CI_Paciente=" & _ci & ";"
            Try
                rs.Open(sql, _cn)
            Catch ex As Exception
                Return (5)
            End Try
            _fechaatiende = rs("Fecha_AtiendeC").Value
            rs.Close()
            sql2 = "update Atiende set Enfermedad_Actual='" & _enfactual & "' where Fecha_Atiende ='" & Format(_fechaatiende, "yyyy-MM-dd HH:mm:ss") & "' AND CI_Paciente=" & _ci & ";"
            Try
                _cn.Execute(sql2)
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
            sql = "select e.CI_Paciente, pa.EstadoBorradoP from Persona as p JOIN Paciente as pa ON p.CI=pa.CI_Paciente JOIN Atiende as a ON pa.CI_Paciente=a.CI_Paciente JOIN Elabora as e ON a.CI_Paciente=e.CI_Paciente where e.CI_Paciente=" & _ci & ";"
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
    Function tipodiag() As List(Of String)
        Dim retorno As New List(Of String)
        Dim rs As New ADODB.Recordset
        Dim sql As String
        sql = "SELECT DISTINCT Tipo_Diag FROM Diagnostico;"
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
