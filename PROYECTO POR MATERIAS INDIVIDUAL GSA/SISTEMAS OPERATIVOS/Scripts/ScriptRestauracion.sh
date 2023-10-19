#!/bin/bash

var2=$(date)
dir=~/Logs
dir2=~/Respaldos
dir3=~/Restauracion

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


if [ -d $dir3 ]
	then
		echo ""
	else
		mkdir $dir3 
fi



(rsync -a --rsync-path="mkdir -p /home/gsaITI/Respaldos/ && rsync" -e "ssh -p 3899 -i ~/.ssh/id_rsa" -avzh gsaITI@192.168.10.3:/home/gsaITI/Respaldos ~/Restauracion && echo "$var2 : Restauración realizada correctamente" >> ~/Logs/RestauracionLogs) || echo "$var2 : Error al realizar la restauración" >> ~/Logs/RestauracionLogs
