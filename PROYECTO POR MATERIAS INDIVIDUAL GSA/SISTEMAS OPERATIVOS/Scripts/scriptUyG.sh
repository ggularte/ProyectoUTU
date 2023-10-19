#!/bin/bash
usergroup(){
var=$(date)
(groupadd -g 2222 Administradores_Sist && echo "$var: Grupo creado correctamente" >> ~/Logs/UyGLogs) || echo "$var: Error al crear grupo" >> ~/Logs/UyGLogs
(groupadd -g 3333 Administradores_Tec && echo "$var: Grupo creado correctamente" >> ~/Logs/UyGLogs) || echo "$var: Error al crear grupo" >> ~/Logs/UyGLogs

(useradd -g 2222 -c "Administrador del Sistema (1)" -m Administrador_Sistema1 && echo "$var: Usuario creado correctamente" >> ~/Logs/UyGLogs) || echo "$var: Error al crear usuario" >> ~/Logs/UyGLogs

(echo -e "54200707\n54200707" | passwd Administrador_Sistema1 && echo "$var: Contraseña asignada correctamente" >> ~/Logs/UyGLogs) || echo "$var: Error al asignar contraseña" >> ~/Logs/UyGLogs

(useradd -g 2222 -c "Administrador del Sistema (2)" -m Administrador_Sistema2 && echo "$var: Usuario creado correctamente" >> ~/Logs/UyGLogs) || echo "$var: Error al crear usuario" >> ~/Logs/UyGLogs

(echo -e "57932568\n57932568" | passwd Administrador_Sistema2 && echo "$var: Contraseña asignada correctamente" >> ~/Logs/UyGLogs) || echo "$var: Error al asignar contraseña" >> ~/Logs/UyGLogs

(useradd -g 3333 -c "Administrador Tecnico (1)" -m Administrador_Tecnico1 && echo "$var: Usuario creado correctamente" >> ~/Logs/UyGLogs) || echo "$var: Error al crear usuario" >> ~/Logs/UyGLogs

(echo -e "52582991\n52582991" | passwd Administrador_Tecnico1 && echo "$var: Contraseña asignada correctamente" >> ~/Logs/UyGLogs) || echo "$var: Error al asignar contraseña" >> ~/Logs/UyGLogs

(useradd -g 3333 -c "Administrador Tecnico (2)" -m Administrador_Tecnico2 && echo "$var: Usuario creado correctamente" >> ~/Logs/UyGLogs) || echo "$var: Error al crear usuario" >> ~/Logs/UyGLogs

(echo -e "55762293\n55762293" | passwd Administrador_Tecnico2 && echo "$var: Contraseña asignada correctamente" >> ~/Logs/UyGLogs) || echo "$var: Error al asignar contraseña" >> ~/Logs/UyGLogs

(usermod -a -G wheel Administrador_Sistema1 && echo "$var: Usario añadido a grupo correctamente" >> ~/Logs/UyGLogs) || echo "$var: Error al añadir usuario a grupo" >> ~/Logs/UyGLogs

(usermod -a -G wheel Administrador_Sistema2 && echo "$var: Usario añadido a grupo correctamente" >> ~/Logs/UyGLogs) || echo "$var: Error al añadir usuario a grupo" >> ~/Logs/UyGLogs

(usermod -a -G wheel Administrador_Tecnico1 && echo "$var: Usario añadido a grupo correctamente" >> ~/Logs/UyGLogs) || echo "$var: Error al añadir usuario a grupo" >> ~/Logs/UyGLogs

(usermod -a -G wheel Administrador_Tecnico2 && echo "$var: Usario añadido a grupo correctamente" >> ~/Logs/UyGLogs) || echo "$var: Error al añadir usuario a grupo" >> ~/Logs/UyGLogs

chown Administrador_Sistema1 /home/Administrador_Sistema1
chown Administrador_Sistema2 /home/Administrador_Sistema2
chown Administrador_Tecnico1 /home/Administrador_Tecnico1
chown Administrador_Tecnico2 /home/Administrador_Tecnico2
chmod a+rwx,g+rx,g-w,o-rwx /home/Administrador_Sistema1
chmod a+rwx,g+rx,g-w,o-rwx /home/Administrador_Sistema2
chmod a+rwx,g+rx,g-w,o-rwx /home/Administrador_Tecnico1
chmod a+rwx,g+rx,g-w,o-rwx /home/Administrador_Tecnico2
exit
}

dir=~/Logs

if [ -d $dir ]
	then
		echo ""
	else
		mkdir $dir 
fi

usergroup
