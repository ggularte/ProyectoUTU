#!/bin/bash
menu(){
echo "-Menu Logs GSA-
1- Buscar Logs por servicio
2- Buscar Logs por prioridad
3- Buscar Logs por Scripts
0- Salir"
echo "Seleccione una opción y luego presione INTRO."
read op
case $op in
1) clear
   echo "Ingrese el nombre del servicio del cual desea buscar los logs."
   read nom
   echo "¿Desea ingresar parametros de tiempo? Y/N"
   read op1
   if [ $op1 == "Y" ] || [ $op1 == "y" ]
	then
		echo "Ingrese el parametro de tiempo desde el que desea buscar los logs."
		echo "NOTA: Formato válido (YYYY-MM-DD HH:mm:ss)"
		read stime
		echo "Ingrese el parametro de tiempo hasta el que desea buscar los logs."
		echo "NOTA: Formato válido (YYYY-MM-DD HH:mm:ss)"
		read utime
		journalctl -u $nom.service --since "$stime" --until "$utime" | more
		menu
	elif [ $op1 == "N" ] || [ $op1 == "n" ]
		then
			journalctl -u $nom.service | more
			menu
	else
		echo "Ingrese una opción válida"
		menu
   fi
   ;;

2) clear
   echo "Ingrese el valor de prioridad por el que desea filtrar los logs."
   echo "NOTA: Valores válidos (0,1,2,3,4,5,6,7)"
   read priori
   if [ $priori -ge 0 ] && [ $priori -le 7 ]
	then
		echo "¿Desea ingresar parámetros de tiempo? Y/N"
		read op1
		if [ $op1 == "Y" ] || [ $op1 == "y" ]
			then
				echo "Ingrese el parámetro de tiempo desde el que desea buscar los logs."
				echo "NOTA: Formato válido (YYYY-MM-DD HH:mm:ss)"
				read stime
				echo "Ingrese el parámetro de tiempo hasta el que desea buscar los logs."
				echo "NOTA: Formato válido (YYYY-MM-DD HH:mm:ss)"
				read utime
				journalctl -p $priori --since "$stime" --until "$utime" | more
				menu
			elif [ $op1 == "N" ] || [ $op1 == "n" ]
				then
					journalctl -p $priori | more
 					menu
				else
					echo "Ingrese una opción válida"
					menu
		fi
	else
		echo "Ingrese una opción válida"
		menu
   fi
   ;;

3) clear
   ./ScriptVerLogs.sh
   ;;

0) clear
   echo "Saliendo del script"
   exit
   ;;

*) clear
   echo "Ingrese una opción válida"
   echo ""
   menu
   ;;
esac
}

menu
