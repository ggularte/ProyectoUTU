#!/bin/bash
var=$(date)
dir=~/Logs
dir2=~/crontabGSA

if [ -d $dir ]
	then
		echo ""
	else
		mkdir $dir
fi


if [ -d $dir2 ]
	then
		echo ""
	else
		mkdir $dir2
fi

echo "00 00 */1 */1 0 ./BackupCompletoGSA" >> ~/crontabGSA/rutinasCrontab
echo "00 00 */1 */1 1-6 ./BackupIncremental00GSA" >> ~/crontabGSA/rutinasCrontab
echo "00 13 */1 */1 */1 ./BackupIncremental13GSA" >> ~/crontabGSA/rutinasCrontab
echo "00 21 */1 */1 1-6 ./BackupBD" >> ~/crontabGSA/rutinasCrontab
echo "00 00 */1 */1 0 ./BackupBD" >> ~/crontabGSA/rutinasCrontab 
(crontab ~/crontabGSA/rutinasCrontab && echo "$var: Agenda crontab cargada correctamente" >> ~/Logs/CrontabLogs) || echo "$var: Error al cargar agenda crontab" >> ~/Logs/CrontabLogs
