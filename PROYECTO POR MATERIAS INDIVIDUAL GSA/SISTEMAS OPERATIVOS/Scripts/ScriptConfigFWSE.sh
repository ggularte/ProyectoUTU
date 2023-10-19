#!/bin/bash

var=$(date)
dir=~/Logs

if [ -d $dir ]
	then
		echo ""
	else
		mkdir $dir 
fi

(yum -y install policycoreutils-python-utils && echo "$var: Instalación del paquete Python Utilites completada correctamente" >> ~/Logs/ConfiguracionFWSELogs) || echo "$var: Error al instalar el paquete Python Utilites" >> ~/Logs/ConfiguracionFWSELogs

(systemctl start firewalld && echo "$var: Firewall iniciado correctamente" >> ~/Logs/ConfiguracionFWSELogs) || echo "$var: Error al iniciar el firewall" >> ~/Logs/ConfiguracionFWSELogs

(systemctl enable firewalld && echo "$var: Firewall habilitado correctamente" >> ~/Logs/ConfiguracionFWSELogs) || echo "$var: Error al habilitar el firewall" >> ~/Logs/ConfiguracionFWSELogs

(firewall-cmd --zone=public --remove-port=22/tcp --permanent && echo "$var: Puerto removido correctamente del firewall" >> ~/Logs/ConfiguracionFWSELogs) || echo "$var: Error al remover puerto del firewall" >> ~/Logs/ConfiguracionFWSELogs

(firewall-cmd --zone=public --add-service=ssh --permanent && echo "$var: Servicio agregado correctamente al firewall" >> ~/Logs/ConfiguracionFWSELogs) || echo "$var: Error al agregar servicio al firewall" >> ~/Logs/ConfiguracionFWSELogs
(firewall-cmd --zone=public --add-service=mysql --permanent && echo "$var: Servicio agregado correctamente al firewall" >> ~/Logs/ConfiguracionFWSELogs) || echo "$var: Error al agregar servicio al firewall" >> ~/Logs/ConfiguracionFWSELogs

(firewall-cmd --zone=public --add-port=3306/tcp --permanent && echo "$var: Puerto agregado correctamente al firewall" >> ~/Logs/ConfiguracionFWSELogs) || echo "$var: Error al agregarpuerto al firewall" >> ~/Logs/ConfiguracionFWSELogs
(firewall-cmd --zone=public --add-port=3899/tcp --permanent && echo "$var: Puerto agregado correctamente al firewall" >> ~/Logs/ConfiguracionFWSELogs) || echo "$var: Error al agregar puerto al firewall" >> ~/Logs/ConfiguracionFWSELogs

(firewall-cmd --reload && echo "$var: Firewall reiniciado correctamente" >> ~/Logs/ConfiguracionFWSELogs) || echo "$var: Error al reiniciar el firewall" >> ~/Logs/ConfiguracionFWSELogs

(semanage port -a -t ssh_port_t -p tcp 3899 && echo "$var: Puerto agregado al SELinux correctamente" >> ~/Logs/ConfiguracionFWSELogs) || echo "$var: Error al agregar puerto al SELinux" >> ~/Logs/ConfiguracionFWSELogs
(semanage port -a -t mysqld_port_t -p tcp 3306 && echo "$var: Puerto agregado al SELinux correctamente" >> ~/Logs/ConfiguracionFWSELogs) || echo "$var: Error al agregar puerto al SELinux" >> ~/Logs/ConfiguracionFWSELogs
