#!/bin/bash
#Agregar, modificar, eliminar (Grupos y usuarios)

menu(){
echo "-Menu de administracion ©GSA -
1-Usuarios
2-Grupos
0-Salir"
read -p "Seleccione una opcion y luego presione INTRO. " op
case $op in
1) clear
   usuarios
   ;;

2) clear
   grupos
   ;;

0) echo ""
   echo "Saliendo del sistema."
   exit
   ;;

*) clear
   echo "Ingrese una opcion valida."
   echo ""
   menu
   ;;
esac

}

usuarios(){
echo "- Usuarios -
1- Agregar usuario
2- Modificar usuario
3- Eliminar usuario
4- Volver"
read -p "Seleccione una opcion y luego presione INTRO. " op
case $op in
1) clear
   agregarUsuario
   ;;

2) clear
   modificarUsuario
   ;;

3) clear
   eliminarUsuario
   ;;

4) clear
   menu
   ;;

*) clear
   echo "Ingrese una opcion valida."
   echo ""
   usuarios
   ;;
esac
}

grupos(){
echo "- Grupos -
1- Agregar grupo
2- Modificar grupo
3- Eliminar grupo
4- Volver"
read -p "Seleccione una opcion y luego presione INTRO. " op
case $op in
1) clear
   agregarGrupo
   ;;

2) clear
   modificarGrupo
   ;;

3) clear
   eliminarGrupo
   ;;

4) clear
   menu
   ;;

*) clear
   echo "Ingrese una opcion valida."
   echo ""
   grupos
   ;;
esac
}

agregarUsuario(){
echo "- Agregar usuario -"
read -p "Ingrese el nombre del usuario a crear: " user
if [ -n "$user" ] 
	then
echo "¿Desea crear un usuario con directorio HOME?
   1-Si
   2-No"
read -p "Seleccione una opcion y luego presione INTRO. " op
if  [ $op -eq 1 ]
	then
		userDirectoryName
        elif [ $op -eq 2 ]
		then
			wdir=0
        		userDirectoryName
	else
		echo ""		
		echo "Ingrese una opcion valida."
   		echo ""
		agregarUsuario
fi
else 
echo "El usuario debe tener nombre."
echo ""
agregarUsuario
fi		
}

userDirectoryName(){
echo "" 
echo "¿Desea crear un usuario con un directorio HOME distinto?
   1-Si
   2-No"
read -p "Seleccione una opcion y luego presione INTRO. " op
if [ $op -eq 1 ]
	then
		read -p "Ingrese el nombre del directorio del usuario: " directory
		wdir=2
		userUID
	elif [ $op -eq 2 ]
		then
			wdir=1
			userUID
        else
		echo ""
        	echo "Ingrese una opcion valida."
   		echo ""
   		userDirectoryName
fi
}

userUID(){
echo ""
echo "¿Desea asignarle un UID (User ID) especifico al usuario?
   1-Si
   2-No" 
read -p "Seleccione una opcion y luego presione INTRO. " op
if [ $op -eq 1 ]
	then
		read -p "Ingrese el UID del usuario a crear: " idu
wuid=1
userGID
	elif [ $op -eq 2 ]
		then	
			wuid=0
			userGID
        else
		echo ""
        	echo "Ingrese una opcion valida."
   		echo ""
   		userUID
fi
}

userGID(){
echo ""
echo "¿Desea asignarle un GID (Group ID) especifico al usuario?
   1-Si
   2-No (default Group:Usuarios GID:1221)" 
read -p "Seleccione una opcion y luego presione INTRO. " op
if [ $op -eq 1 ]
	then
		read -p "Ingrese el GID del usuario a crear: " idg
userShell
	elif [ $op -eq 2 ]
		then
			userShell
        else
		echo ""
        	echo "Ingrese una opcion valida."
   		echo ""
   		userGID
fi
}

userShell(){
echo ""
echo "¿Desea asignarle un Custom Shell especifico al usuario?
   1-Si
   2-No (default /bin/bash)" 
read -p "Seleccione una opcion y luego presione INTRO. " op
if [ $op -eq 1 ]
	then
		read -p "Ingrese el Shell del usuario a crear: " shellUser
		userDateExp
	elif [ $op -eq 2 ]
		then
			userDateExp
        else
		echo ""
        	echo "Ingrese una opcion valida."
   		echo ""
   		userShell
fi
}

userDateExp(){
echo ""
echo "¿Desea asignarle una fecha de vencimiento especifica al usuario?
   1-Si
   2-No" 
read -p "Seleccione una opcion y luego presione INTRO. " op
if [ $op -eq 1 ]
	then
		read -p "Ingrese año de expiracion: " aaaa
   		read -p "Ingrese mes de expiracion: " mmmm
   		read -p "Ingrese dìa de expiracion: " dddd
userComment
	elif [ $op -eq 2 ]
		then
			userComment
        else
		echo ""
        	echo "Ingrese una opcion valida."
   		echo ""
   		userDateExp
fi
}

userComment(){
echo ""
echo "¿Desea asignarle un comentario en especifico al usuario?
   1-Si
   2-No" 
read -p "Seleccione una opcion y luego presione INTRO. " op
if [ $op -eq 1 ]
	then
		read -p "Ingrese el comentario: " comment
userResultados
	elif [ $op -eq 2 ]
		then
			userResultados
        else
		echo ""
        	echo "Ingrese una opcion valida."
   		echo ""
   		userComment
fi
}

userResultados(){
#Excepciones varias
if [ -z $shellUser ]
	then
		shellUser="/bin/bash"
fi
if [ -z $idg ]
	then
		idg=1221
fi
echo ""
echo "Los datos ingresados son los siguientes:"
echo "****************************************"
echo "Nombre del usuario: $user"
if [ -z "$directory" ]
	then
		echo "Directorio home del usuario: NO ESTABLECIDO"
else 
	echo "Directorio home del usuario: $directory"
fi
if [ -z "$idu" ] 
	then
		echo "User ID del usuario: NO ESTABLECIDO"
else 
	echo "User ID del usuario: $idu"
fi
echo "Group ID del usuario: $idg"
echo "Shell del usuario: $shellUser"
if [ -z "$aaaa" -a -z "$mmmm" -a -z "$dddd" ] 
	then
		echo "Fecha de expiracion de la cuenta del usuario: NO ESTABLECIDA"
		aaaa=9999
		mmmm=12
		dddd=31
else 
	echo "Fecha de expiracion de la cuenta del usuario: $aaaa/$mmmm/$dddd"
fi
if [ -z "$comment" ] 
	then
		echo "Comentario del usuario: NO ESTABLECIDO"
else 
	echo "Comentario del usuario: $comment"
fi
echo "****************************************"
userAddConfirmacion
}

userAddConfirmacion(){
echo "Si los datos son correctos ingrese 1."
echo "De lo contrario ingrese 0 para volver."
read op
if [ $op -eq 1 ]
	then
		userAddResult
elif [ $op -eq 0 ]
	then
		usuarios
		echo ""
        else
		echo ""
        	echo "Ingrese una opcion valida."
   		echo ""
   		userAddConfirmacion
fi
}

userAddResult(){
if [ $wdir -eq 2 -a $wuid -eq 0 ]
	then
		(useradd -d $directory -g $idg -s $shellUser -e $aaaa-$mmmm-$dddd -c "$comment" $user && echo "$var: Usuario agregado correctamente" >> ~/Logs/AdmUGLogs) || echo "$var: Error al agregar usuario" >> ~/Logs/AdmUGLogs
		passwd $user
		echo ""
		usuarios
elif [ $wdir -eq 2 -a $wuid -eq 1 ]
	then
		(useradd -d $directory -u $idu -g $idg -s $shellUser -e $aaaa-$mmmm-$dddd -c "$comment" $user && echo "$var: Usuario agregado correctamente" >> ~/Logs/AdmUGLogs) || echo "$var: Error al agregar usuario" >> ~/Logs/AdmUGLogs
		passwd $user
		echo ""
		usuarios
elif [ $wdir -eq 1 -a $wuid -eq 0 ]
	then
		(useradd -g $idg -s $shellUser -e $aaaa-$mmmm-$dddd -c "$comment" -m $user && echo "$var: Usuario agregado correctamente" >> ~/Logs/AdmUGLogs) || echo "$var: Error al agregar usuario" >> ~/Logs/AdmUGLogs
		passwd $user
		echo ""
		usuarios
elif [ $wdir -eq 1 -a $wuid -eq 1 ]
	then
		(useradd -u $idu -g $idg -s $shellUser -e $aaaa-$mmmm-$dddd -c "$comment" -m $user && echo "$var: Usuario agregado correctamente" >> ~/Logs/AdmUGLogs) || echo "$var: Error al agregar usuario" >> ~/Logs/AdmUGLogs
		passwd $user
		echo ""
		usuarios
elif [ $wdir -eq 0 -a $wuid -eq 0 ]
	then
		(useradd -M -s "$shellUser" -e $aaaa-$mmmm-$dddd -c "$comment" -g $idg $user && echo "$var: Usuario agregado correctamente" >> ~/Logs/AdmUGLogs) || echo "$var: Error al agregar usuario" >> ~/Logs/AdmUGLogs
		passwd $user
                echo ""
		usuarios
elif [ $wdir -eq 0 -a $wuid -eq 1 ]
	then
		(useradd -M -u $idu -g $idg -s $shellUser -e $aaaa-$mmmm-$dddd -c "$comment" $user && echo "$var: Usuario agregado correctamente" >> ~/Logs/AdmUGLogs) || echo "$var: Error al agregar usuario" >> ~/Logs/AdmUGLogs
		passwd $user
                echo ""
		usuarios
else
		echo ""
        	echo "ERROR AL AGREGAR USUARIO."
   		echo ""
		usuarios
fi
}

modificarUsuario(){
echo "- Modificar usuarios -
1- Agregar grupo principal a usuario
2- Cambiar un usuario de grupo
3- Quitar grupo a usuario
4- Bloquear usuario
5- Desbloquear usuario
6- Modificar UID del usuario
7- Modificar USER SHELL del usuario
8- Modificar LOGIN NAME del usuario
9- Modificar fecha de expiracion del usuario
10- Modificar comentario del usuario
11- Modificar directorio HOME del usuario
12- Modificar contraseña del usuario
13- Volver"
read -p "Seleccione una opcion y luego presione INTRO. " op
case $op in
1) clear
   echo " - Agregar grupo a usuario - "
   read -p "Ingrese el nombre del usuario a modificar: " user
   read -p "Ingrese el nombre del grupo a agregar: " group
   echo ""
   echo "Los datos ingresados son los siguientes:"
   echo "****************************************"
   echo "Nombre del usuario a modificar: $user"
   echo "Nuevo grupo o GID a agregar del usuario: $group"
   echo "****************************************"
   echo "Si los datos son correctos ingrese 1."
   echo "De lo contrario ingrese 0 para cancelar."
   read op
   if [ $op -eq 1 ]
	   then
		   (usermod -a -G $group $user && echo "$var: Usuario $user agregado al grupo $group correctamente" >> ~/Logs/AdmUGLogs) || echo "$var: Error al agregar el usuario $user al grupo $group" >> ~/Logs/AdmUGLogs
   		   echo ""
   		   modificarUsuario
   elif [ $op -eq 0 ]
	then
		modificarUsuario
		echo ""
           else
		   echo ""
        	   echo "Opcion invalida."
   		   echo ""
   		   modificarUsuario
   fi
   
   ;;

2) clear
   echo " - Cambiar un usuario de grupo - "
   read -p "Ingrese el nombre del usuario a modificar: " user
   read -p "Ingrese el nombre del nuevo grupo o GID: " group
   echo ""
   echo "Los datos ingresados son los siguientes:"
   echo "****************************************"
   echo "Nombre del usuario a modificar: $user"
   echo "Nuevo grupo o GID a cambiar del usuario: $group"
   echo "****************************************"
   echo "Si los datos son correctos ingrese 1."
   echo "De lo contrario ingrese 0 para cancelar."
   read op
   if [ $op -eq 1 ]
	   then
		   (usermod -g $group $user && echo "$var: Usuario $user cambiado al grupo $group correctamente" >> ~/Logs/AdmUGLogs) || echo "$var: Error al cambiar el usuario $user de grupo"
   		   echo ""
   		   modificarUsuario
   elif [ $op -eq 0 ]
	then
		modificarUsuario
		echo ""
           else
		   echo ""
        	   echo "Opcion invalida."
   		   echo ""
   		   modificarUsuario
   fi
   ;;

3) clear
   echo " - Quitar grupo a usuario - "
   read -p "Ingrese el nombre del usuario a modificar: " user
   read -p "Ingrese el nombre del grupo a quitar: " group
   echo ""
   echo "Los datos ingresados son los siguientes:"
   echo "****************************************"
   echo "Nombre del usuario a modificar: $user"
   echo "Grupo a quitar del usuario: $group"
   echo "****************************************"
   echo "Si los datos son correctos ingrese 1."
   echo "De lo contrario ingrese 0 para cancelar."
   read op
   if [ $op -eq 1 ]
	   then
		   (deluser $user $group && echo "$var: Usuario $user eliminado correctamente del grupo $group" >> ~/Logs/AdmUGLogs) || echo "Error al quitar del grupo $group el usuario $user" >> ~/Logs/AdmUGLogs
   		   echo ""
   		   modificarUsuario
   elif [ $op -eq 0 ]
	then
		modificarUsuario
		echo ""
           else
		   echo ""
        	   echo "Opcion invalida."
   		   echo ""
   		   modificarUsuario
   fi
   ;;

4) clear
   echo " - Bloquear usuario - "
   read -p "Ingrese el nombre del usuario a bloquear: " user
   echo ""
   echo "Los datos ingresados son los siguientes:"
   echo "****************************************"
   echo "Nombre del usuario a bloquear: $user"
   echo "****************************************"
   echo "Si los datos son correctos ingrese 1."
   echo "De lo contrario ingrese 0 para cancelar."
   read op
   if [ $op -eq 1 ]
	   then
		   (usermod -L $user && echo "$var: Usuario $user bloqueado correctamente" >> ~/Logs/AdmUGLogs) || echo "$var: Error al bloquear al usuario $user" >> ~/Logs/AdmUGLogs
   		   echo ""
   		   modificarUsuario
   elif [ $op -eq 0 ]
	then
		modificarUsuario
		echo ""
           else
		   echo ""
        	   echo "Opcion invalida."
   		   echo ""
   		   modificarUsuario
   fi
   ;;

5) clear
   echo " - Desbloquear usuario - "
   read -p "Ingrese el nombre del usuario a desbloquear: " user
   echo ""
   echo "Los datos ingresados son los siguientes:"
   echo "****************************************"
   echo "Nombre del usuario a desbloquear: $user"
   echo "****************************************"
   echo "Si los datos son correctos ingrese 1."
   echo "De lo contrario ingrese 0 para cancelar."
   read op
   if [ $op -eq 1 ]
	   then
		   (usermod -U $user && echo "$var: Usuario $user desbloqueado correctamente" >> ~/Logs/AdmUGLogs) || echo "$var: Error al desbloquear al usuario $user" >> ~/Logs/AdmUGLogs
   		   passwd $user
   		   echo ""
   		   modificarUsuario
   elif [ $op -eq 0 ]
	then
		modificarUsuario
		echo ""
           else
		   echo ""
        	   echo "Opcion invalida."
   		   echo ""
   		   modificarUsuario
   fi
   ;;

6) clear
   echo " - Modificar UID del usuario - "
   read -p "Ingrese el nombre del usuario a modificar: " user
   read -p "Ingrese el UID del usuario a cambiar: " idu
   echo ""
   echo "Los datos ingresados son los siguientes:"
   echo "****************************************"
   echo "Nombre del usuario a modificar: $user"
   echo "Nuevo UID del usuario: $idu"
   echo "****************************************"
   echo "Si los datos son correctos ingrese 1."
   echo "De lo contrario ingrese 0 para cancelar."
   read op
   if [ $op -eq 1 ]
	   then
		   (usermod -u $idu $user && echo "$var: UID del usuario $user modificado correctamente" >> ~/Logs/AdmUGLogs) || echo "$var: Error al cambiar el UID del usuario $user" >> ~/Logs/AdmUGLogs
   		   echo ""
   		   modificarUsuario
   elif [ $op -eq 0 ]
	then
		modificarUsuario
		echo ""
           else
		   echo ""
        	   echo "Opcion invalida."
   		   echo ""
   		   modificarUsuario
   fi
   ;;

7) clear
   echo " - Modificar USER SHELL del usuario - "
   read -p "Ingrese el nombre del usuario a modificar: " user
   read -p "Ingrese el USER SHELL del usuario a cambiar: " shellUser
   echo ""
   echo "Los datos ingresados son los siguientes:"
   echo "****************************************"
   echo "Nombre del usuario a modificar: $user"
   echo "Nuevo USER SHELL del usuario: $shellUser"
   echo "****************************************"
   echo "Si los datos son correctos ingrese 1."
   echo "De lo contrario ingrese 0 para cancelar."
   read op
   if [ $op -eq 1 ]
	   then
		   (usermod -s $shellUser $user && echo "$var: SHELL del usuario $user modificado correctamente" >> ~/Logs/AdmUGLogs) || echo "$var: Error al modificar el SHELL del usuario $user" >> ~/Logs/AdmUGLogs
  		   echo ""
   		   modificarUsuario
   elif [ $op -eq 0 ]
	then
		modificarUsuario
		echo ""
           else
		   echo ""
        	   echo "Opcion invalida."
   		   echo ""
   		   modificarUsuario
   fi
   ;;

8) clear
   echo " - Modificar LOGIN NAME del usuario - "
   read -p "Ingrese el nombre del usuario a modificar: " user
   read -p "Ingrese el LOGIN NAME a cambiar: " lname
   echo ""
   echo "Los datos ingresados son los siguientes:"
   echo "****************************************"
   echo "Nombre del usuario a modificar: $user"
   echo "Nuevo LOGIN NAME: $lname"
   echo "****************************************"
   echo "Si los datos son correctos ingrese 1."
   echo "De lo contrario ingrese 0 para cancelar."
   read op
   if [ $op -eq 1 ]
	   then
		   (usermod -l $lname $user && echo "$var: Login Name del usuario correctamente" >> ~/Logs/AdmUGLogs) || echo "$var: Error al modificar el Login Name del usuario $user" >> ~/Logs/AdmUGLogs
   		   echo ""
   		   modificarUsuario
    elif [ $op -eq 0 ]
	then
		modificarUsuario
		echo ""
           else
		   echo ""
        	   echo "Opcion invalida."
   		   echo ""
   		   modificarUsuario
   fi
   ;;

9) clear
   echo " - Modificar fecha de expiracion del usuario - "
   read -p "Ingrese el nombre del usuario a modificar: " user
   read -p "Ingrese nuevo año de expiracion: " aaaa
   read -p "Ingrese nuevo mes de expiracion: " mmmm
   read -p "Ingrese nuevo dìa de expiracion: " dddd
   echo ""
   echo "Los datos ingresados son los siguientes:"
   echo "****************************************"
   echo "Nombre del usuario a modificar: $user"
   echo "Nuevo año de expiracion: $aaaa"
   echo "Nuevo mes de expiracion: $mmmm"
   echo "Nuevo nuevo dìa de expiracion: $dddd"
   echo "****************************************"
   echo "Si los datos son correctos ingrese 1."
   echo "De lo contrario ingrese 0 para cancelar."
   read op
   if [ $op -eq 1 ]
	   then
		   (usermod -e $aaaa-$mmmm-$dddd $user && echo "$var: Fecha de expiracion del usuario $user modificada correctamente" >> ~/Logs/AdmUGLogs) || echo "$var: Error al modificar la fecha de expiracion del usuario $user" >> ~/Logs/AdmUGLogs
   		   echo ""
   		   modificarUsuario
           else
		   echo ""
        	   echo "Opcion invalida."
   		   echo ""
   		   modificarUsuario
   fi
   ;;

10) clear
   echo " - Modificar comentario del usuario - "
   read -p "Ingrese el nombre del usuario a modificar: " user
   read -p "Ingrese nuevo comentario: " comment
   echo ""
   echo "Los datos ingresados son los siguientes:"
   echo "****************************************"
   echo "Nombre del usuario a modificar: $user"
   echo "Nuevo comentario: $comment"
   echo "****************************************"
   echo "Si los datos son correctos ingrese 1."
   echo "De lo contrario ingrese 0 para cancelar."
   read op
   if [ $op -eq 1 ]
	   then
		   (usermod -c "$comment" $user && echo "$var: Comentario del usuario modificado correctamente" >> ~/Logs/AdmUGLogs) || echo "$var: Error al modificar comentario del usuario $user" >> ~/Logs/AdmUGLogs
   		   echo ""
   	           modificarUsuario
   elif [ $op -eq 0 ]
	then
		modificarUsuario
		echo ""
           else
		   echo ""
        	   echo "Opcion invalida."
   		   echo ""
   		   modificarUsuario
   fi
   ;;

11) clear
   echo " - Modificar directorio HOME del usuario - "
   read -p "Ingrese el nombre del usuario a modificar: " user
   read -p "Ingrese el nombre del nuevo directorio del usuario: " directory
   echo ""
   echo "Los datos ingresados son los siguientes:"
   echo "****************************************"
   echo "Nombre del usuario a modificar: $user"
   echo "Nombre del nuevo directorio: $directory"
   echo "****************************************"
   echo "Si los datos son correctos ingrese 1."
   echo "De lo contrario pulse ingrese 0 para cancelar."
   read op
   if [ $op -eq 1 ]
	   then
		   (usermod -d $directory $user && echo "$var: Directorio Home del usuario $user modificado correctamente" >> ~/Logs/AdmUGLogs) || echo "$var: Error al modificar el directorio Home del usuario $user" >> ~/Logs/AdmUGLogs
   		   echo ""
   	   	   modificarUsuario
   elif [ $op -eq 0 ]
	then
		modificarUsuario
		echo ""
           else
		   echo ""
        	   echo "Opcion invalida."
   		   echo ""
   		   modificarUsuario
   fi
   ;;

12) clear
   echo " - Modificar contraseña del usuario - "
   read -p "Ingrese el nombre del usuario a modificar: " user
   passwd $user
   echo ""
   modificarUsuario
   ;;

13) clear
   usuarios
   ;;

*) clear
   echo "Ingrese una opcion valida."
   echo ""
   modificarUsuario
   ;;
esac
}

eliminarUsuario(){
echo "- Eliminar usuarios -
1- Eliminar usuario
2- Comprobar existencia
3- Volver"
read -p "Seleccione una opcion y luego presione INTRO. " op
case $op in
1) clear
   echo " - Eliminar usuarios - "
   read -p "Ingrese el nombre del usuario a eliminar: " user
   echo ""
   echo "Los datos ingresados son los siguientes:"
   echo "****************************************"
   echo "Nombre del usuario a eliminar: $user"
   echo "****************************************"
   echo "Si los datos son correctos ingrese 1."
   echo "De lo contrario ingrese 0 para cancelar."
   read op
   if [ $op -eq 1 ]
	   then
		   (userdel $user && echo "$var: Usuario $user eliminado correctamente" >> ~/Logs/AdmUGLogs) || echo "$var: Error al eliminar el usuario $user" >> ~/Logs/AdmUGLogs
		   echo ""
                   eliminarUsuario
   elif [ $op -eq 0 ]
	then
		eliminarUsuario
		echo ""
           else
		   echo ""
        	   echo "Opcion invalida."
   		   echo ""
   		   eliminarUsuario
   fi
   ;;

2) clear
   echo " - Comprobar existencia - "
   read -p "Ingrese el nombre del usuario a verificar: " user
   echo ""
   cut -d: -f1 /etc/passwd | grep $user
   echo ""
   eliminarUsuario
   ;;

3) clear
   usuarios
   ;;

*) clear
   echo "Ingrese una opcion valida."
   echo ""
   eliminarUsuario
   ;;
esac
}

agregarGrupo(){
echo "- Agregar grupo -"
read -p "Ingrese el nombre del grupo a crear: " gname
if [ -n "$gname" ] 
	then
echo "¿Desea crear un grupo con GID especifico?
   1-Si
   2-No"
read -p "Seleccione una opcion y luego presione INTRO. " op
if  [ $op -eq 1 ]
	then
		read -p "Ingrese el GID del grupo a crear: " idg
		wgGID=2
		groupGIDconsulta
        elif [ $op -eq 2 ]
		then
			wgGID=0
        		groupSystem
	else
		echo ""		
		echo "Ingrese una opcion valida."
   		echo ""
		pruebaGrupo
fi
else 
echo "El grupo debe tener nombre."
echo ""
agregarGrupo
fi		
}

groupGIDconsulta(){
echo ""
echo "¿Desea asignarle un GID (Group ID) no unico al grupo?
   1-Si
   2-No" 
read -p "Seleccione una opcion y luego presione INTRO. " op
if [ $op -eq 1 ]
	then
		wgGID=1
		groupSystem
	elif [ $op -eq 2 ]
		then
		groupSystem
        else
		echo ""
        	echo "Ingrese una opcion valida."
   		echo ""
   		groupGIDconsulta
fi
}

groupSystem(){
echo ""
echo "¿Desea que este grupo sea del sistema?
   1-Si
   2-No" 
read -p "Seleccione una opcion y luego presione INTRO. " op
if [ $op -eq 1 ]
	then
		wgSYS=1
		groupAddResultado
	elif [ $op -eq 2 ]
		then
			wgSYS=0
			groupAddResultado
        else
		echo ""
        	echo "Ingrese una opcion valida."
   		echo ""
   		groupSystem
fi
}

groupAddResultado(){
echo ""
echo "Los datos ingresados son los siguientes:"
echo "****************************************"
echo "Nombre del grupo: $gname"
if [ -z "$idg" ] 
	then
		echo "GID del grupo: NO ESTABLECIDO"
else 
	echo "GID del grupo: $idg"
fi
if [ $wgGID -eq 2 ]
	then
		echo "GID unico: SI"
elif [ $wgGID -eq 1 ] 
	then 
		echo "GID unico: NO"
else 
	echo "GID unico: NO ESTABLECIDO"
fi
if [ $wgSYS -eq 1 ] 
	then
		echo "Grupo del sistema: SI"
else 
	echo "Grupo del sistema: NO"
fi
echo "****************************************"
groupAddConfirmacion
}

groupAddConfirmacion(){
echo "Si los datos son correctos ingrese 1."
echo "De lo contrario ingrese 0 para cancelar."
read op
if [ $op -eq 1 ]
	then
		groupAddResult
elif [ $op -eq 0 ]
	then
		grupos
		echo ""
        else
		echo ""
        	echo "Ingrese una opcion valida."
   		echo ""
   		groupAddConfirmacion
fi
}

groupAddResult(){
if [ $wgGID -eq 2 -a $wgSYS -eq 0 ]
	then
		(groupadd -g $idg $gname && echo "$var: Grupo $gname agregado correctamente" >> ~/Logs/AdmUGLogs) || echo "$var: Error al agregar el grupo $gname" >> ~/Logs/AdmUGLogs
		echo ""
		grupos
elif [ $wgGID -eq 2 -a $wgSYS -eq 1 ]
	then
		(groupadd -r -g $idg $gname && echo "$var: Grupo $gname agregado correctamente" >> ~/Logs/AdmUGLogs) || echo "$var: Error al agregar el grupo $gname" >> ~/Logs/AdmUGLogs
		echo ""
		grupos
elif [ $wgGID -eq 1 -a $wgSYS -eq 0 ]
	then
		(groupadd -o -g $idg $gname && echo "$var: Grupo $gname agregado correctamente" >> ~/Logs/AdmUGLogs) || echo "$var: Error al agregar el grupo $gname" >> ~/Logs/AdmUGLogs
		echo ""
		grupos
elif [ $wgGID -eq 1 -a $wgSYS -eq 1 ]
	then
		(groupadd -r -o -g $idg $gname && echo "$var: Grupo $gname agregado correctamente" >> ~/Logs/AdmUGLogs) || echo "$var: Error al agregar el grupo $gname" >> ~/Logs/AdmUGLogs
		echo ""
		grupos
elif [ $wgGID -eq 0 -a $wgSYS -eq 0 ]
	then
		(groupadd $gname && echo "$var: Grupo $gname agregado correctamente" >> ~/Logs/AdmUGLogs) || echo "$var: Error al agregar el grupo $gname" >> ~/Logs/AdmUGLogs
                echo ""
		grupos
elif [ $wgGID -eq 0 -a $wgSYS -eq 1 ]
	then
		(groupadd -r $gname && echo "$var: Grupo $gname agregado correctamente" >> ~/Logs/AdmUGLogs) || echo "$var: Error al agregar el grupo $gname" >> ~/Logs/AdmUGLogs
                echo ""
		grupos
else
		echo ""
        	echo "ERROR AL AGREGAR USUARIO."
   		echo ""
		grupos
fi
}

modificarGrupo(){
echo "- Modificar grupo -
1- Modificar nombre del grupo
2- Modificar GID del grupo
3- Modificar GID del grupo a no unico
4- Volver"
read -p "Seleccione una opcion y luego presione INTRO. " op
case $op in
1) clear
   echo " - Modificar nombre del grupo - "
   read -p "Ingrese el nombre del grupo a modificar: " gnameold
   read -p "Ingrese el nuevo nombre del grupo: " gnamenew
   echo ""
   echo "Los datos ingresados son los siguientes:"
   echo "****************************************"
   echo "Nombre del grupo a modificar: $gnameold"
   echo "Nuevo nombre del grupo: $gnamenew"
   echo "****************************************"
   echo "Si los datos son correctos ingrese 1."
   echo "De lo contrario ingrese 0 para cancelar."
   read op
   if [ $op -eq 1 ]
	   then
		   (groupmod -n $gnamenew $gnameold && echo "$var: Grupo $gnameold modificado a $gnameold correctamente" >> ~/Logs/AdmUGLogs) || echo "$var: Error al modificar el grupo $gnameold a $gnameold" >> ~/Logs/AdmUGLogs
   		   echo ""
   	   	   modificarGrupo
   elif [ $op -eq 0 ]
	then
		modificarGrupo
		echo ""
           else
		   echo ""
        	   echo "Opcion invalida."
   		   echo ""
   		   modificarGrupo
   fi
   ;;

2) clear
   echo " - Modificar GID del grupo - "
   read -p "Ingrese el nombre del grupo a modificar: " gname
   read -p "Ingrese el nuevo GID del grupo: " gidnew
   echo ""
   echo "Los datos ingresados son los siguientes:"
   echo "****************************************"
   echo "Nombre del grupo a modificar: $gname"
   echo "Nuevo GID del grupo: $gidnew"
   echo "****************************************"
   echo "Si los datos son correctos ingrese 1."
   echo "De lo contrario ingrese 0 para cancelar."
   read op
   if [ $op -eq 1 ]
	   then
		   (groupmod -g $gidnew $gname && echo "$var: UID del grupo $gname a $gidnew modificado correctamente" >> ~/Logs/AdmUGLogs) || echo "$var: Error al modificar el UID del grupo $gname a $gidnew" >> ~/Logs/AdmUGLogs
   		   echo ""
   	   	   modificarGrupo
   elif [ $op -eq 0 ]
	then
		modificarGrupo
		echo ""
           else
		   echo ""
        	   echo "Opcion invalida."
   		   echo ""
   		   modificarGrupo
   fi
   ;;

3) clear
   echo " - Modificar GID del grupo a no unico - "
   read -p "Ingrese el nombre del grupo a modificar: " gname
   read -p "Ingrese el GID del grupo no unico: " gidnounique
   echo ""
   echo "Los datos ingresados son los siguientes:"
   echo "****************************************"
   echo "Nombre del grupo a modificar: $gname"
   echo "GID del grupo no unico: $gidnounique"
   echo "****************************************"
   echo "Si los datos son correctos ingrese 1."
   echo "De lo contrario ingrese 0 para cancelar."
   read op
   if [ $op -eq 1 ]
	   then
		   (groupmod -o -g $gidnounique $gname && echo "$var: GID del grupo $gname modificado correctamente a no unico $gidnounique" >> ~/Logs/AdmUGLogs) || echo "$var: Error al modificar el GID del grupo a $gname a no unico $gidnounique" >> ~/Logs/AdmUGLogs
   		   echo ""
   	   	   modificarGrupo
   elif [ $op -eq 0 ]
	then
		modificarGrupo
		echo ""
           else
		   echo ""
        	   echo "Opcion invalida."
   		   echo ""
   		   modificarGrupo
   fi
   ;;

4) clear
   grupos
   ;;

*) clear
   echo "Ingrese una opcion valida."
   echo ""
   modificarGrupo
   ;;
esac
}

eliminarGrupo(){
echo "- Eliminar grupo -
1- Eliminar grupo
2- Comprobar existencia
3- Volver"
read -p "Seleccione una opcion y luego presione INTRO. " op
case $op in
1) clear
   echo " - Eliminar grupo - "
   read -p "Ingrese el nombre del grupo a eliminar: " gname
   echo ""
   echo "Los datos ingresados son los siguientes:"
   echo "****************************************"
   echo "Nombre del grupo a eliminar: $gname"
   echo "****************************************"
   echo "Si los datos son correctos ingrese 1."
   echo "De lo contrario ingrese 0 para cancelar."
   read op
   if [ $op -eq 1 ]
	   then
		   (groupdel $gname && echo "$var: Grupo $gname eliminado correctamente" >> ~/Logs/AdmUGLogs) || echo "$var: Error al eliminar el grupo $gname" >> ~/Logs/AdmUGLogs
		   echo ""
                   eliminarGrupo
   elif [ $op -eq 0 ]
	then
		eliminarGrupo
		echo ""
           else
		   echo ""
        	   echo "Opcion invalida."
   		   echo ""
   		   eliminarGrupo
   fi
   ;;

2) clear
   echo " - Comprobar existencia - "
   read -p "Ingrese el nombre del grupo a verificar: " gname
   echo ""
   cut -d: -f1 /etc/group | grep $gname
   echo ""
   eliminarGrupo
   ;;

3) clear
   grupos
   ;;

*) clear
   echo "Ingrese una opcion valida."
   echo ""
   eliminarGrupo
   ;;
esac
}

var=$(date)
dir6=~/Logs

if [ -d $dir6 ]
	then
		echo ""
	else
		mkdir $dir6 
fi

groupadd -g 1221 Usuarios
reset
menu
