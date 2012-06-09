#COM1 equivalent, /dev/ttyS0
<?cs if:(system.remote.lirc.active == "0" || system.remote.lirc.receiver.serial_port != "/dev/ttyS0") ?>#<?cs /if ?>options lirc_serial irq=4 io=0x3f8
#COM2 equivalent, /dev/ttyS1
<?cs if:(system.remote.lirc.active == "0" || system.remote.lirc.receiver.serial_port != "/dev/ttyS1") ?>#<?cs /if ?>options lirc_serial irq=3 io=0x2f8
<?cs if:(system.remote.lirc.active == "1" || system.remote.lirc.receiver.serial_port != "" ) ?>
install lirc_serial setserial <?cs var:system.remote.lirc.receiver.serial_port ?> uart none; /sbin/modprobe --ignore-install lirc_serial 
<?cs /if ?>
