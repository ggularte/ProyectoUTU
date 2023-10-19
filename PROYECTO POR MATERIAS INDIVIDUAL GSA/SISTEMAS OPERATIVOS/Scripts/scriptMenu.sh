#!/bin/bash
menuprincipal(){
echo "-Menú GSA-
1-Inicializar sistema
2-Opciones individuales
0-Salir"
read -p "Seleccione una opcion y luego presione INTRO. " op
case $op in
1) clear
   menusistema
   ;;

2) clear
   menuopciones
   ;;
   
0) echo ""
   echo "Saliendo del sistema."
   exit
   ;;

*) clear
   echo "Ingrese una opcion valida."
   echo ""
   menuprincipal
   ;;
esac
}

menusistema(){
./ScriptInstalacionMysql.sh
./ScriptRedes.sh
./ScriptUpd.sh
./scriptUyG.sh
./ScriptCTBU.sh
./ScriptConfigSSH.sh
./ScriptConfigFWSE.sh
}

menuopciones(){
echo "-Menu Opciones GSA-
01- Respaldos
02- Configuración Firewall y SELinux
03- Congfiguracion SSH
04- Instalación MySQL
05- Actualización del sistema
06- Usuarios mínimos y grupos
07- Administración de usuarios y grupos
08- Configuración redes
09- Ver Logs Scripts
10- Restauración de respaldos
11- Ver Logs Sistema
0- Volver"
echo ""
echo "Ingrese una opción"
read op
case $op in
1) clear
   ./ScriptBackup.sh
   ;;
2) clear
   ./ScriptConfigFWSE.sh
   ;;
3) clear
   ./ScriptConfigSSH.sh
   ;;
4) clear
   ./ScriptInstalacionMysql.sh
   ;;
5) clear
   ./ScriptUpd.sh
   ;;
6) clear
   ./scriptUyG.sh
   ;;
7) clear
   ./shellScriptGSA.sh
   ;;
8) clear
   ./ScriptRedes.sh
   ;;
9) clear
   ./ScriptVerLogs.sh
   ;;
10) clear
   ./ScriptRestauracion.sh
   ;;
11) clear
    ./LogsGSA.sh
    ;;
0) clear
   menuprincipal
   ;; 
*) clear 
   echo "Seleccione una opción valida"
   menuopciones
   ;;
esac
}

chmod u+x ScriptUpd.sh
chmod u+x scriptUyG.sh
chmod u+x ScriptCTBU.sh
chmod u+x ScriptConfigSSH.sh
chmod u+x ScriptConfigFWSE.sh
chmod u+x ScriptInstalacionMysql.sh
chmod u+x shellScriptGSA.sh
chmod u+x ScriptRedes.sh
chmod u+x ScriptVerLogs.sh
chmod u+x ScriptRestauracion.sh
chmod u+x ScriptBackup.sh
chmod u+x LogsGSA.sh
menuprincipal
