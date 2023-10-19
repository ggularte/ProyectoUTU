#!/bin/bash
menu(){
echo "-Menú redes GSA-
1-192.168.10.2 (Servidor de Base de Datos)
2-192.168.10.3 (Servidor de Respaldos)
3-192.168.10.4 (Servidor de Mail)
4-192.168.10.5 (Servidor Web)
0-Salir"
read -p "Seleccione una opcion y luego presione INTRO. " op
case $op in
1) clear
   ip1
   ;;

2) clear
   ip2
   ;;

3) clear
   ip3
   ;;

4) clear
   ip4
   ;;

0) echo ""
   echo "Saliendo del sistema."
   exit
   ;;

*) clear
   echo "Ingrese una opcion valida."
   echo ""
   menu
   ;;
esac
}

ip1(){
(echo "TYPE=\"Ethernet\"
PROXY_METHOD=\"none\"
BROWSER_ONLY=\"no\"
BOOTPROTO=\"static\"
DEFROUTE=\"yes\"
IPV4_FAILURE_FATAL=\"no\"
IPV6INIT=\"yes\"
IPV6_AUTOCONF=\"yes\"
IPV6_DEFROUTE=\"yes\"
IPV6_FAILURE_FATAL=\"no\"
IPV6_ADDR_GEN_MODE=\"stable-privacy\"
NAME=\"enp0s9\"
DEVICE=\"enp0s9\"
ONBOOT=\"yes\"
IPADDR=\"192.168.10.2\"
PREFIX=\"24\"
GATEWAY=\"192.168.10.1\"
DNS1=\"200.40.30.245\"
DNS2=\"200.40.220.245\"" > /etc/sysconfig/network-scripts/ifcfg-enp0s9 && echo "$var: Configuracion de red realizada correctamente" >> ~/Logs/RedesLogs) || echo "$var: Error al aplicar la configuracion de red" >> ~/Logs/RedesLogs
}

ip2(){
(echo "TYPE=\"Ethernet\"
PROXY_METHOD=\"none\"
BROWSER_ONLY=\"no\"
BOOTPROTO=\"static\"
DEFROUTE=\"yes\"
IPV4_FAILURE_FATAL=\"no\"
IPV6INIT=\"yes\"
IPV6_AUTOCONF=\"yes\"
IPV6_DEFROUTE=\"yes\"
IPV6_FAILURE_FATAL=\"no\"
IPV6_ADDR_GEN_MODE=\"stable-privacy\"
NAME=\"enp0s9\"
DEVICE=\"enp0s9\"
ONBOOT=\"yes\"
IPADDR=\"192.168.10.3\"
PREFIX=\"24\"
GATEWAY=\"192.168.10.1\"
DNS1=\"200.40.30.245\"
DNS2=\"200.40.220.245\"" > /etc/sysconfig/network-scripts/ifcfg-enp0s9 && echo "$var: Configuracion de red realizada correctamente" >> ~/Logs/RedesLogs) || echo "$var: Error al aplicar la configuracion de red" >> ~/Logs/RedesLogs
}

ip3(){
(echo "TYPE=\"Ethernet\"
PROXY_METHOD=\"none\"
BROWSER_ONLY=\"no\"
BOOTPROTO=\"static\"
DEFROUTE=\"yes\"
IPV4_FAILURE_FATAL=\"no\"
IPV6INIT=\"yes\"
IPV6_AUTOCONF=\"yes\"
IPV6_DEFROUTE=\"yes\"
IPV6_FAILURE_FATAL=\"no\"
IPV6_ADDR_GEN_MODE=\"stable-privacy\"
NAME=\"enp0s9\"
DEVICE=\"enp0s9\"
ONBOOT=\"yes\"
IPADDR=\"192.168.10.4\"
PREFIX=\"24\"
GATEWAY=\"192.168.10.1\"
DNS1=\"200.40.30.245\"
DNS2=\"200.40.220.245\"" > /etc/sysconfig/network-scripts/ifcfg-enp0s9 && echo "$var: Configuracion de red realizada correctamente" >> ~/Logs/RedesLogs) || echo "$var: Error al aplicar la configuracion de red" >> ~/Logs/RedesLogs
}

ip4(){
(echo "TYPE=\"Ethernet\"
PROXY_METHOD=\"none\"
BROWSER_ONLY=\"no\"
BOOTPROTO=\"static\"
DEFROUTE=\"yes\"
IPV4_FAILURE_FATAL=\"no\"
IPV6INIT=\"yes\"
IPV6_AUTOCONF=\"yes\"
IPV6_DEFROUTE=\"yes\"
IPV6_FAILURE_FATAL=\"no\"
IPV6_ADDR_GEN_MODE=\"stable-privacy\"
NAME=\"enp0s9\"
DEVICE=\"enp0s9\"
ONBOOT=\"yes\"
IPADDR=\"192.168.10.5\"
PREFIX=\"24\"
GATEWAY=\"192.168.10.1\"
DNS1=\"200.40.30.245\"
DNS2=\"200.40.220.245\"" > /etc/sysconfig/network-scripts/ifcfg-enp0s9 && echo "$var: Configuracion de red realizada correctamente" >> ~/Logs/RedesLogs) || echo "$var: Error al aplicar la configuracion de red" >> ~/Logs/RedesLogs
}

reiniciar(){
echo "Para aplicar la configuración se debe reiniciar el sistema, desea reiniciarlo? 1-Si / 2-No"
read op
if [ $op -eq 1 ]
	then
		reboot
	elif [ $op -eq 2 ]
		then
			echo "Saliendo del sistema"
			exit
		else
			reiniciar
fi
}

var=$(date)
dir=~/Logs
if [ -d $dir ]
	then
		echo ""
	else
		mkdir $dir
fi
 
menu
systemctl restart NetworkManager
reiniciar















