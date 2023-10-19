#!/bin/bash

var=$(date)
dir=~/Logs

if [ -d $dir ]
	then
		echo ""
	else
		mkdir $dir 
fi

(gawk -i inplace '{ gsub(/#Port 22/, "Port 3899"); print }' /etc/ssh/sshd_config && echo "$var: Puerto cambiado correctamente" >> ~/Logs/ConfiguracionSSHLogs) || echo "$var: Error al cambiar de puerto" >> ~/Logs/ConfiguracionSSHLogs
(gawk -i inplace '{ gsub(/#PermitRootLogin yes/, "PermitRootLogin no"); print }' /etc/ssh/sshd_config && echo "$var: Opción de permitir login por root cambiada correctamente" >> ~/Logs/ConfiguracionSSHLogs) || echo "$var: Error al cambiar la opcion de permitir login por root" >> ~/Logs/ConfiguracionSSHLogs
(gawk -i inplace '{ gsub(/#PasswordAuthentication no/, "PasswordAuthentication yes"); print }' /etc/ssh/sshd_config && echo "$var: Opcion de autenticación con contraseña cambiada correctamente" >> ~/Logs/ConfiguracionSSHLogs) || echo "$var: Error al cambiar la opcion de autenticación con contraseña" >> ~/Logs/ConfiguracionSSHLogs

(gawk -i inplace '{ gsub(/Port 22/, "Port 3899"); print }' /etc/ssh/sshd_config && echo "$var: Puerto cambiado correctamente" >> ~/Logs/ConfiguracionSSHLogs) || echo "$var: Error al cambiar de puerto" >> ~/Logs/ConfiguracionSSHLogs
(gawk -i inplace '{ gsub(/PermitRootLogin yes/, "PermitRootLogin no"); print }' /etc/ssh/sshd_config && echo "$var: Opción de permitir login por root cambiada correctamente" >> ~/Logs/ConfiguracionSSHLogs) || echo "$var: Error al cambiar la opcion de permitir login por root" >> ~/Logs/ConfiguracionSSHLogs
(gawk -i inplace '{ gsub(/PasswordAuthentication no/, "PasswordAuthentication yes"); print }' /etc/ssh/sshd_config && echo "$var: Opcion de autenticación con contraseña cambiada correctamente" >> ~/Logs/ConfiguracionSSHLogs) || echo "$var: Error al cambiar la opcion de autenticación con contraseña" >> ~/Logs/ConfiguracionSSHLogs

ssh-keygen
(ssh-copy-id gsaITI@192.168.10.3 -p 3899 && echo "$var: Clave copiada correctamente" >> ~/Logs/ConfiguracionSSHLogs) || echo "$var: Error al copiar la clave" >> ~/Logs/ConfiguracionSSHLogs
