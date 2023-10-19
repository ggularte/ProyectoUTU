#!/bin/bash
#~
menu(){
clear
echo "-Menú Backups GSA-
1- Tarea Backup Completo
2- Tarea Backup Incremental
3- Backup Base de Datos
4- Comprobar agenda Crontab
5- Eliminar agenda Crontab
0- Salir"
echo ""
echo "Seleccione una opción y luego presione INTRO."
read -p "" op
case $op in
1) clear
   backupcompleto
   ;;
2) clear 
   backupincremental
   ;;
3) clear
   backupbd
   ;;
4) clear
   echo "Agenda Crontab: "
   echo ""
   crontab -l
   ;;
5) clear
   (crontab -r && echo "$var: Agenda crontab eliminada correctamente" >> ~/Logs/CrontabLogs) || echo "$var: Error al eliminar la agenda crontab" >> ~/Logs/CrontabLogs
   echo ""
   echo "Agenda Crontab eliminada correctamente."
   ;;
0) clear
   echo "Script finalizado."
   exit
   ;;
*) clear
   echo "Ingrese una opción valida."
   menu
   ;;
esac
}

backupcompleto(){
echo "00 00 */1 */1 0 ./BackupCompletoGSA" >> ~/crontabGSA/rutinasCrontab
(crontab ~/crontabGSA/rutinasCrontab && echo "$var: Agenda crontab cargada correctamente" >> ~/Logs/CrontabLogs) || echo "$var: Error al cargar agenda crontab" >> ~/Logs/CrontabLogs
reset
}

backupincremental(){
echo "00 00 */1 */1 1-6 ./BackupIncremental00GSA" >> ~/crontabGSA/rutinasCrontab
echo "00 13 */1 */1 */1 ./BackupIncremental13GSA" >> ~/crontabGSA/rutinasCrontab
(crontab ~/crontabGSA/rutinasCrontab && echo "$var: Agenda crontab cargada correctamente" >> ~/Logs/CrontabLogs) || echo "$var: Error al cargar agenda crontab" >> ~/Logs/CrontabLogs
}

backupbd(){
echo "00 21 */1 */1 1-6 ./BackupBD" >> ~/crontabGSA/rutinasCrontab
echo "00 00 */1 */1 0 ./BackupBD" >> ~/crontabGSA/rutinasCrontab 
(crontab ~/crontabGSA/rutinasCrontab && echo "$var: Agenda crontab cargada correctamente" >> ~/Logs/CrontabLogs) || echo "$var: Error al cargar agenda crontab" >> ~/Logs/CrontabLogs
}

var=$(date)
dir=~/Logs

if [ -d $dir ]
	then
		echo ""
	else
		mkdir $dir 
fi

dir2=~/crontabGSA

if [ -d $dir2 ]
	then
		echo ""
	else
		mkdir $dir2 
fi

chmod u+x BackupBD
chmod u+x RestoreBD
chmod u+x BackupCompletoGSA
chmod u+x BackupIncremental13GSA
chmod u+x BackupIncremental00GSA
reset
menu
