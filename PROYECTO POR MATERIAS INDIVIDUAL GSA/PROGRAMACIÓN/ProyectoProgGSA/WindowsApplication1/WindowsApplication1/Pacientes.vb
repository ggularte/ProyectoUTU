Public Class Pacientes
    Protected _ci As Integer
    Protected _pnombre As String
    Protected _snombre As String
    Protected _usuario As String
    Protected _papellido As String
    Protected _sapellido As String
    Protected _estadocivil As String
    Protected _sexo As Char
    Protected _fechanac As Date
    Protected _edad As Integer
    Protected _telefono As String
    Protected _calle As String
    Protected _correo As String
    Protected _esquina As String
    Protected _nropuerta As String
    Protected _contrasena As String
    Protected _estadoborradop As Integer
    Protected _cn As ADODB.Connection
    'Metodos constructores
    Sub New()
        _ci = 0
        _usuario = ""
        _pnombre = ""
        _snombre = ""
        _estadoborradop = 0
        _papellido = ""
        _sapellido = ""
        _estadocivil = ""
        _sexo = ""
        _contrasena = ""
        _edad = 0
        _correo = ""
        _fechanac = New Date
        _telefono = ""
        _calle = ""
        _esquina = ""
        _nropuerta = ""
        _cn = New ADODB.Connection
    End Sub
    Sub New(ByVal usuario As String, ByVal contrasena As String, ByVal correo As String, ByVal estadoborradop As Integer, ByVal ci As Integer, ByVal pnombre As String, ByVal snombre As String, ByVal papellido As String, ByVal sapellido As String, ByVal estadocivil As String, ByVal sexo As Char, ByVal ocupacion As String, ByVal edad As Integer, ByVal fechanac As Date, ByVal telefono As String, ByVal calle As String, ByVal esquina As String, ByVal nropuerta As String, ByVal cn As ADODB.Connection)
        _ci = ci
        _usuario = usuario
        _correo = correo
        _contrasena = contrasena
        _pnombre = pnombre
        _snombre = snombre
        _papellido = papellido
        _sapellido = sapellido
        _estadoborradop = estadoborradop
        _estadocivil = estadocivil
        _sexo = sexo
        _edad = edad
        _fechanac = fechanac
        _telefono = telefono
        _calle = calle
        _esquina = esquina
        _nropuerta = nropuerta
        _cn = cn
    End Sub
    'Get y set de las propiedades
    Property usuario As String
        Get
            Return (_usuario)
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property
    Property contrasena As String
        Get
            Return (_contrasena)
        End Get
        Set(ByVal value As String)
            _contrasena = value
        End Set
    End Property
    Property correo As String
        Get
            Return (_correo)
        End Get
        Set(ByVal value As String)
            _correo = value
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
    Property pnombre As String
        Get
            Return (_pnombre)
        End Get
        Set(ByVal value As String)
            _pnombre = value
        End Set
    End Property
    Property snombre As String
        Get
            Return (_snombre)
        End Get
        Set(ByVal value As String)
            _snombre = value
        End Set
    End Property
    Property papellido As String
        Get
            Return (_papellido)
        End Get
        Set(ByVal value As String)
            _papellido = value
        End Set
    End Property
    Property sapellido As String
        Get
            Return (_sapellido)
        End Get
        Set(ByVal value As String)
            _sapellido = value
        End Set
    End Property
    Property estadocivil As String
        Get
            Return (_estadocivil)
        End Get
        Set(ByVal value As String)
            _estadocivil = value
        End Set
    End Property
    Property sexo As Char
        Get
            Return (_sexo)
        End Get
        Set(ByVal value As Char)
            _sexo = value
        End Set
    End Property
    Property fechanac As Date
        Get
            Return (_fechanac)
        End Get
        Set(ByVal value As Date)
            _fechanac = value
        End Set
    End Property
    Property edad As Integer
        Get
            Return (_edad)
        End Get
        Set(ByVal value As Integer)
            _edad = value
        End Set
    End Property
    Property telefono As String
        Get
            Return (_telefono)
        End Get
        Set(ByVal value As String)
            _telefono = value
        End Set
    End Property
    Property calle As String
        Get
            Return (_calle)
        End Get
        Set(ByVal value As String)
            _calle = value
        End Set
    End Property
    Property esquina As String
        Get
            Return (_esquina)
        End Get
        Set(ByVal value As String)
            _esquina = value
        End Set
    End Property
    Property nropuerta As String
        Get
            Return (_nropuerta)
        End Get
        Set(ByVal value As String)
            _nropuerta = value
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
            sql = "select * from Persona as p JOIN Paciente as pa ON p.CI=pa.CI_Paciente WHERE pa.CI_Paciente=" & _ci & ";"
            Try
                rs.Open(sql, _cn)
            Catch ex As Exception
                MsgBox(ex.ToString)
                Return (2)
            End Try
            If rs.RecordCount = 0 Then
                retorno = 3
            Else
                _pnombre = rs("Primer_Nombre").Value
                _estadoborradop = rs("EstadoBorradoP").Value
                _snombre = rs("Segundo_Nombre").Value
                _papellido = rs("Primer_Apellido").Value
                _sapellido = rs("Segundo_Apellido").Value
                _estadocivil = rs("Estado_Civil").Value
                _sexo = rs("Sexo").Value
                _fechanac = rs("Fecha_Nac").Value
                _calle = rs("Calle").Value
                _esquina = rs("Esquina").Value
                _nropuerta = rs("Numero").Value
                _correo = rs("Correo").Value
                rs.Close()
                sql = "select TIMESTAMPDIFF(YEAR, Fecha_Nac, curdate()) as Edad from Persona where CI=" & _ci & ";"
                Try
                    rs.Open(sql, _cn)
                    _edad = rs("Edad").Value
                Catch ex As Exception
                    Return (5)
                End Try
            End If
            rs.Close()
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
            sql = "select CI from Personal_Medico WHERE CI=" & _ci & ";"
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
    Function patelefono() As List(Of String)
        Dim retorno As New List(Of String)
        Dim rs As New ADODB.Recordset
        Dim sql As String
        sql = "select Telefono from Persona_Telefono where CI=" & _ci & ";"
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
    Function Guardar(ByVal alta As Boolean) As Integer
        Dim retorno As Integer = 0
        Dim rs As New ADODB.Recordset
        Dim sql As String
        Dim sql3 As String
        Dim sql4 As String
        If cn.State = 0 Then
            retorno = 1
        Else
            If alta Then
                sql = "insert into Persona (CI,Fecha_Nac,Calle,Esquina,Numero,Primer_Apellido,Segundo_Apellido,Primer_Nombre,Segundo_Nombre, Correo) VALUES (" & _ci & ",'" & Format(_fechanac, "yyyy-MM-dd HH:mm:ss") & "','" & _calle & "','" & _esquina & "','" & _nropuerta & "','" & _papellido & "','" & _sapellido & "','" & _pnombre & "','" & _snombre & "','" & _correo & "');"
                Try
                    _cn.Execute(sql)
                Catch ex As Exception
                    Return (2)
                End Try
                sql3 = "insert into Paciente(CI_Paciente,Estado_Civil,Sexo) VALUES (" & _ci & ",'" & _estadocivil & "','" & _sexo & "');"
                Try
                    _cn.Execute(sql3)
                Catch ex As Exception
                    Return (5)
                End Try
                sql4 = "insert into Posee(ID_Estado,CI_Paciente,FechaInicio_E) VALUES ('1','" & _ci & "','" & Format(Now(), "yyyy-MM-dd HH:mm:ss") & "');"
                Try
                    _cn.Execute(sql4)
                Catch ex As Exception
                    Return (5)
                End Try
            Else
                sql = "update Paciente set Estado_Civil='" & _estadocivil & "', Sexo='" & _sexo & "' where CI_Paciente=" & _ci & ";"
                Try
                    _cn.Execute(sql)
                Catch ex As Exception
                    Return (5)
                End Try
                sql3 = "update Persona set Fecha_Nac='" & Format(_fechanac, "yyyy-MM-dd HH:mm:ss") & "', Calle='" & _calle & "', Esquina='" & _esquina & "', Numero='" & _nropuerta & "', Primer_Apellido='" & _papellido & "', Segundo_Apellido='" & _sapellido & "', Primer_Nombre='" & _pnombre & "', Segundo_Nombre='" & _snombre & "', Correo='" & _correo & "' where CI=" & _ci & ";"
                Try
                    _cn.Execute(sql3)
                Catch ex As Exception
                    Return (7)
                End Try
            End If
        End If
        Return (retorno)
    End Function
    Function GuardarT(ByVal alta As Boolean) As Integer
        Dim retorno As Integer = 0
        Dim rs As New ADODB.Recordset
        Dim sql2 As String
        If cn.State = 0 Then
            retorno = 1
        Else
            If alta Then
                sql2 = "insert into Persona_Telefono(CI,Telefono) VALUES (" & _ci & ",'" & _telefono & "');"
                Try
                    _cn.Execute(sql2)
                Catch ex As Exception
                    Return (3)
                End Try
            End If
        End If
        Return (retorno)
    End Function
    Function EliminarT(ByVal alta As Boolean) As Integer
        Dim retorno As Integer = 0
        Dim rs As New ADODB.Recordset
        Dim sql2 As String
        If cn.State = 0 Then
            retorno = 1
        Else
            If alta Then
                sql2 = "delete from Persona_Telefono where Telefono= '" & _telefono & "';"
                Try
                    _cn.Execute(sql2)
                Catch ex As Exception
                    Return (3)
                End Try
            End If
        End If
        Return (retorno)
    End Function
    Function Guardar1(ByVal alta As Boolean) As Integer
        Dim retorno As Integer = 0
        Dim rs As New ADODB.Recordset
        Dim sql3 As String
        Dim sql4 As String
        If cn.State = 0 Then
            retorno = 1
        Else
            If alta Then
                sql3 = "insert into Paciente(CI_Paciente,Estado_Civil,Sexo) VALUES (" & _ci & ",'" & _estadocivil & "','" & _sexo & "');"
                Try
                    _cn.Execute(sql3)
                Catch ex As Exception
                    Return (5)
                End Try
                sql4 = "insert into Posee(ID_Estado,CI_Paciente,FechaInicio_E) VALUES ('1','" & _ci & "','" & Format(Now(), "yyyy-MM-dd HH:mm:ss") & "');"
                Try
                    _cn.Execute(sql4)
                Catch ex As Exception
                    Return (5)
                End Try
            End If
        End If
        Return (retorno)
    End Function
    Function adduser(ByVal alta As Boolean) As Integer
        Dim retorno As Integer = 0
        Dim rs As New ADODB.Recordset
        Dim sql3 As String
        Dim sql4 As String
        If cn.State = 0 Then
            retorno = 1
        Else
            If alta Then
                sql3 = "CREATE USER '" & _usuario & "'@'192.168.1.209' IDENTIFIED BY '" & _contrasena & "';"
                Try
                    _cn.Execute(sql3)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    Return (5)
                End Try
                sql3 = "GRANT GSAPacientes TO '" & _usuario & "'@'192.168.1.209';"
                Try
                    _cn.Execute(sql3)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    Return (5)
                End Try
                sql4 = "insert into Usuario_Rol(Usuario,Rol,CI) VALUES ('" & _usuario & "','3'," & _ci & ");"
                Try
                    _cn.Execute(sql4)
                Catch ex As Exception
                    Return (6)
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
            sql = "update Paciente set EstadoBorradoP= TRUE where CI_Paciente =" & _ci & ";"
            Try
                _cn.Execute(sql)
            Catch ex As Exception
                Return (2)
            End Try
        End If
        Return (retorno)
    End Function
    Function ecivil() As List(Of String)
        Dim retorno As New List(Of String)
        Dim rs As New ADODB.Recordset
        Dim sql As String
        sql = "SELECT DISTINCT Estado_Civil FROM Paciente;"
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
    Function csexo() As List(Of Char)
        Dim retorno As New List(Of Char)
        Dim rs As New ADODB.Recordset
        Dim sql As String
        sql = "SELECT DISTINCT Sexo FROM Paciente;"
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
