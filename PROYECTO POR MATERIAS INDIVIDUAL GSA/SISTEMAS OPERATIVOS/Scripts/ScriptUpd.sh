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

(yum update && echo "$var: Sistema actualizado correctamente" >> ~/Logs/UpdateLogs) || echo "$var: Error al actualizar el sistema" >> ~/Logs/UpdateLogs

echo "00 20 */1 */1 1 yum -y update" >> ~/crontabGSA/rutinasCrontab
(crontab ~/crontabGSA/rutinasCrontab && echo "$var: Agenda crontab cargada correctamente" >> ~/Logs/CrontabLogs) || echo "$var: Error al cargar agenda crontab" >> ~/Logs/CrontabLogs

