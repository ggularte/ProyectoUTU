#!/bin/bash

menu(){
echo "-Menú Logs GSA-
01- Respaldos
02- Configuración Firewall y SELinux
03- Congfiguracion SSH
04- Instalación MySQL
05- Actualización del sistema
06- Usuarios mínimos y grupos
07- Administración de usuarios y grupos
08- Configuración redes
09- Crontab
10- Restauración de respaldos
0- Salir"

echo "Selecciona una opción: "
read -p "" op
case $op in
1) clear
   cat ~/Logs/BackupLogs | more
   fop
   ;;
2) clear
   cat ~/Logs/ConfiguracionFWSELogs | more
   fop
   ;;
3) clear
   cat ~/Logs/ConfiguracionSSHLogs | more
   fop
   ;;
4) clear
   cat ~/Logs/MysqlLogs | more
   fop
   ;;
5) clear
   cat ~/Logs/UpdateLogs | more
   fop
   ;;
6) clear
    cat ~/Logs/UyGLogs | more
    fop
    ;;
7) clear
    cat ~/Logs/AdmUGLogs | more
    fop
    ;;
8) clear
    cat  ~/Logs/RedesLogs | more
    fop
    ;;
9) clear
    cat ~/Logs/CrontabLogs | more
    fop
    ;;
10) clear
    cat ~/Logs/RestauracionLogs | more
    fop
    ;;
0) echo ""
   echo "Saliendo del sistema."
   exit
   ;;
*) clear
   echo "Ingresar una opción valida"
   menu
   ;;
esac
}

fop(){
echo ""
echo "Desea volver al menú? 1- Si / 2- No"
   read -p "" op
   if [ $op -eq 1 ]
   	then
   		menu
   	elif [ $op -eq 2 ]
   		then
   			echo "Saliendo del sistema"
   			exit
   	else
   		echo "Seleccione una opción correcta"
   		fop
   fi
}

menu
