import sys
import glob
import serial
import time

BAUD_RATE = 9600

def list_serial():
    if sys.platform.startswith('win'):
        ports = ['COM%s' % (i + 1) for i in range(256)]
    elif sys.platform.startswith('linux') or sys.platform.startswith('cygwin'):
        ports = glob.glob('/dev/tty[A-Za-z]*')
    elif sys.platform.startswith('darwin'):
        ports = glob.glob('/dev/tty.*')
    else:
        raise EnvironmentError('Unsupported platform')

    result = []
    for port in ports:
        try:
            s = serial.Serial(port)
            s.close()
            result.append(port)
        except (OSError, serial.SerialException):
            pass
    return result

if __name__ == "__main__":
    list_available_ports = list_serial()
    print("Available Serial Ports:", list_available_ports)
    if len(list_available_ports) > 0:
        used_port = list_available_ports[0]
        ser = serial.Serial(used_port, BAUD_RATE, timeout=0.050)
        count = 0

        while True:
            ser.write(bytes('{}'.format(count), 'utf-8'))
            time.sleep(1)
            count += 1
    else:
        print("No available serial port.")