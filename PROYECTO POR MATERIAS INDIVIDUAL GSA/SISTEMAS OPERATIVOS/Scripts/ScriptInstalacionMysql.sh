#!/bin/bash

var=$(date)
dir=~/Logs

if [ -d $dir ]
	then
		echo ""
	else
		mkdir $dir
fi

(yum install -y mysql-server && echo "$var: MySQL Server instalado correctamente" >> ~/Logs/MysqlLogs) || echo "$var: Error al insta lar MySQL Server" >> ~/Logs/MysqlLogs

(systemctl start mysqld && echo "$var: MySQL Server iniciado correctamente" >> ~/Logs/MysqlLogs) || echo "$var: Error al iniciar MySQL Server" >> ~/Logs/MysqlLogs
(systemctl enable mysqld && echo "$var: MySQL Server habilitado correctamente" >> ~/Logs/MysqlLogs) || echo "$var: Error al habilitar MySQL Server" >> ~/Logs/MysqlLogs
(mysql_secure_installation && echo "$var: Configuración de MySQL realizada correctamente" >> ~/Logs/MysqlLogs) || echo "Error al configurar MySQL" >> ~/Logs/MysqlLogs



reset
