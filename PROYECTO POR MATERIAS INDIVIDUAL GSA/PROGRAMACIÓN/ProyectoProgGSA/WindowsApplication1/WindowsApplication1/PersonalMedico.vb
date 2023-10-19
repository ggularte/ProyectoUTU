Public Class PersonalMedico
    Protected _ci As Integer
    Protected _pnombre As String
    Protected _snombre As String
    Protected _usuario As String
    Protected _contrasena As String
    Protected _papellido As String
    Protected _fechanac As Date
    Protected _sapellido As String
    Protected _calle As String
    Protected _nropuerta As String
    Protected _esquina As String
    Protected _correo As String
    Protected _telefono As String
    Protected _edad As Integer
    Protected _especialidad As String
    Protected _estadoborradom As Integer
    Protected _cn As ADODB.Connection
    Sub New()
        _ci = 0
        _edad = 0
        _usuario = ""
        _contrasena = ""
        _estadoborradom = 0
        _fechanac = New Date
        _pnombre = ""
        _correo = ""
        _snombre = ""
        _papellido = ""
        _sapellido = ""
        _nropuerta = ""
        _esquina = ""
        _calle = ""
        _telefono = ""
        _especialidad = ""
        _cn = New ADODB.Connection
    End Sub
    Sub New(ByVal usuario As String, ByVal contrasena As String, ByVal correo As String, ByVal estadoborradom As Integer, ByVal ci As Integer, ByVal edad As Integer, ByVal fechanac As Date, ByVal calle As String, ByVal pnombre As String, ByVal snombre As String, ByVal papellido As String, ByVal sapellido As String, ByVal nropuerta As String, ByVal esquina As String, ByVal telefono As String, ByVal especialidad As String, ByVal cn As ADODB.Connection)
        _ci = ci
        _usuario = usuario
        _contrasena = contrasena
        _pnombre = pnombre
        _correo = correo
        _edad = edad
        _snombre = snombre
        _fechanac = fechanac
        _calle = calle
        _papellido = papellido
        _sapellido = sapellido
        _nropuerta = nropuerta
        _esquina = esquina
        _telefono = telefono
        _especialidad = especialidad
        _cn = cn
        _estadoborradom = estadoborradom
    End Sub
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
    Property estadoborradom As Integer
        Get
            Return (_estadoborradom)
        End Get
        Set(ByVal value As Integer)
            _estadoborradom = value
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
    Property edad As Integer
        Get
            Return (_edad)
        End Get
        Set(ByVal value As Integer)
            _edad = value
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
    Property fechanac As Date
        Get
            Return (_fechanac)
        End Get
        Set(ByVal value As Date)
            _fechanac = value
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
    Property snombre As String
        Get
            Return (_pnombre)
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
    Property nropuerta As String
        Get
            Return (_nropuerta)
        End Get
        Set(ByVal value As String)
            _nropuerta = value
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
    Property telefono As String
        Get
            Return (_telefono)
        End Get
        Set(ByVal value As String)
            _telefono = value
        End Set
    End Property
    Property especialidad As String
        Get
            Return (_especialidad)
        End Get
        Set(ByVal value As String)
            _especialidad = value
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
            sql = "select * from Persona as p JOIN Personal_Medico as m ON p.CI=m.CI where m.CI=" & _ci & ";"
            Try
                rs.Open(sql, _cn)
            Catch ex As Exception
                Return (2)
            End Try
            If rs.RecordCount = 0 Then
                retorno = 3
            Else
                _pnombre = rs("Primer_Nombre").Value
                _snombre = rs("Segundo_Nombre").Value
                _papellido = rs("Primer_Apellido").Value
                _sapellido = rs("Segundo_Apellido").Value
                _fechanac = rs("Fecha_Nac").Value
                _calle = rs("Calle").Value
                _esquina = rs("Esquina").Value
                _nropuerta = rs("Numero").Value
                _estadoborradom = rs("EstadoBorradoM").Value
                rs.Close()
                sql = "select Telefono from Persona_Telefono where CI=" & _ci & ";"
                Try
                    rs.Open(sql, _cn)
                    _telefono = rs("Telefono").Value
                Catch ex As Exception
                    Return (4)
                End Try
                rs.Close()
                sql = "select Especialidad from Medico where CI_Medico=" & _ci & ";"
                Try
                    rs.Open(sql, _cn)
                    If rs.EOF And rs.BOF Then
                        _especialidad = "-"
                    Else
                        _especialidad = rs("Especialidad").Value
                    End If
                Catch ex As Exception
                    Return (5)
                End Try
                rs.Close()
                sql = "select TIMESTAMPDIFF(YEAR, Fecha_Nac, curdate()) as Edad from Persona where CI=" & _ci & ";"
                Try
                    rs.Open(sql, _cn)
                    _edad = rs("Edad").Value
                    rs.Close()
                Catch ex As Exception
                    Return (6)
                End Try
            End If
        End If
        Return (retorno)
    End Function
    Function estado() As Integer
        Dim sql As String
        Dim rs As New ADODB.Recordset
        Dim retorno As Integer = 0
        If cn.State = 0 Then
            retorno = 1
        Else
            sql = "update Personal_Medico set EstadoBorradoM= FALSE where CI =" & _ci & ";"
            Try
                _cn.Execute(sql)
            Catch ex As Exception
                Return (2)
            End Try
        End If
        Return (retorno)
    End Function
    Function Guardar1(ByVal alta As Boolean) As Integer
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
                    MsgBox(ex.ToString)
                    Return (2)
                End Try
                sql3 = "insert into Personal_Medico(CI) VALUES (" & _ci & ");"
                Try
                    _cn.Execute(sql3)
                Catch ex As Exception
                    Return (4)
                End Try
                sql4 = "insert into Medico(CI_Medico, Especialidad) VALUES (" & _ci & ",'" & _especialidad & "');"
                Try
                    _cn.Execute(sql4)
                Catch ex As Exception
                    Return (4)
                End Try
            Else
                sql = "update Medico set Especialidad='" & _especialidad & "' where CI_Medico=" & _ci & ";"
                Try
                    _cn.Execute(sql)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    Return (5)
                End Try
                sql3 = "update Persona set Fecha_Nac='" & Format(_fechanac, "yyyy-MM-dd HH:mm:ss") & "', Calle='" & _calle & "', Esquina='" & _esquina & "', Numero='" & _nropuerta & "', Primer_Apellido='" & _papellido & "', Segundo_Apellido='" & _sapellido & "', Primer_Nombre='" & _pnombre & "', Segundo_Nombre='" & _snombre & "', Correo='" & _correo & "' where CI=" & _ci & ";"
                Try
                    _cn.Execute(sql3)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    Return (7)
                End Try
            End If
        End If
        Return (retorno)
    End Function
    Function addusermed(ByVal alta As Boolean) As Integer
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
                sql3 = "GRANT GSAMedicos TO '" & _usuario & "'@'192.168.1.209';"
                Try
                    _cn.Execute(sql3)
                Catch ex As Exception
                    Return (5)
                End Try
                sql4 = "insert into Usuario_Rol(Usuario,Rol) VALUES ('" & _usuario & "','1'," & _ci & ");"
                Try
                    _cn.Execute(sql4)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    Return (6)
                End Try
            End If
        End If
        Return (retorno)
    End Function
    Function adduseraux(ByVal alta As Boolean) As Integer
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
                    Return (5)
                End Try
                sql3 = "GRANT GSAAuxiliares TO '" & _usuario & "'@'192.168.1.209';"
                Try
                    _cn.Execute(sql3)
                Catch ex As Exception
                    Return (5)
                End Try
                sql4 = "insert into Usuario_Rol(Usuario,Rol) VALUES ('" & _usuario & "','2'," & _ci & ");"
                Try
                    _cn.Execute(sql4)
                Catch ex As Exception
                    Return (6)
                End Try
            End If
        End If
        Return (retorno)
    End Function
    Function Guardar2(ByVal alta As Boolean) As Integer
        Dim retorno As Integer = 0
        Dim rs As New ADODB.Recordset
        Dim sql As String
        Dim sql3 As String
        If cn.State = 0 Then
            retorno = 1
        Else
            If alta Then
                sql = "insert into Persona (CI,Fecha_Nac,Calle,Esquina,Numero,Primer_Apellido,Segundo_Apellido,Primer_Nombre,Segundo_Nombre, Correo) VALUES (" & _ci & ",'" & Format(_fechanac, "yyyy-MM-dd HH:mm:ss") & "','" & _calle & "','" & _esquina & "','" & _nropuerta & "','" & _papellido & "','" & _sapellido & "','" & _pnombre & "','" & _snombre & "','" & _correo & "');"
                Try
                    _cn.Execute(sql)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    Return (2)
                End Try
                sql3 = "insert into Personal_Medico(CI) VALUES (" & _ci & ");"
                Try
                    _cn.Execute(sql3)
                Catch ex As Exception
                    Return (4)
                End Try
            Else
                sql3 = "update Persona set Fecha_Nac='" & Format(_fechanac, "yyyy-MM-dd HH:mm:ss") & "', Calle='" & _calle & "', Esquina='" & _esquina & "', Numero='" & _nropuerta & "', Primer_Apellido='" & _papellido & "', Segundo_Apellido='" & _sapellido & "', Primer_Nombre='" & _pnombre & "', Segundo_Nombre='" & _snombre & "', Correo='" & _correo & "' where CI=" & _ci & ";"
                Try
                    _cn.Execute(sql3)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    Return (7)
                End Try
            End If
        End If
        Return (retorno)
    End Function
    Function Guardar3(ByVal alta As Boolean) As Integer
        Dim retorno As Integer = 0
        Dim rs As New ADODB.Recordset
        Dim sql3 As String
        Dim sql4 As String
        If cn.State = 0 Then
            retorno = 1
        Else
            If alta Then
                sql3 = "insert into Personal_Medico(CI) VALUES (" & _ci & ");"
                Try
                    _cn.Execute(sql3)
                Catch ex As Exception
                    Return (4)
                End Try
                sql4 = "insert into Medico(CI_Medico, Especialidad) VALUES (" & _ci & ",'" & _especialidad & "');"
                Try
                    _cn.Execute(sql4)
                Catch ex As Exception
                    Return (4)
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
            sql = "select CI_Paciente from Paciente WHERE CI_Paciente=" & _ci & ";"
            Try
                rs.Open(sql, _cn)
            Catch ex As Exception
                MsgBox(ex.ToString)
                Return (2)
            End Try
            If rs.RecordCount = 0 Then
                retorno = 3
            Else
                _ci = rs("CI_Paciente").Value
            End If
            rs.Close()
        End If
        Return (retorno)
    End Function
    Function pmtelefono() As List(Of String)
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
    Function Guardar4(ByVal alta As Boolean) As Integer
        Dim retorno As Integer = 0
        Dim rs As New ADODB.Recordset
        Dim sql3 As String
        If cn.State = 0 Then
            retorno = 1
        Else
            If alta Then
                sql3 = "insert into Personal_Medico(CI) VALUES (" & _ci & ");"
                Try
                    _cn.Execute(sql3)
                Catch ex As Exception
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
            sql = "update Personal_Medico set EstadoBorradoM= TRUE where CI =" & _ci & ";"
            Try
                _cn.Execute(sql)
            Catch ex As Exception
                Return (2)
            End Try
        End If
        Return (retorno)
    End Function
End Class
