# jetson-pc-serialcom

This repository demonstrates the usage of serial communication between a Jetson Nano and a PC using C#. This communication can be used to send and receive data between the Jetson Nano and the PC.

**Hardware Requirements**

-   Jetson Nano
-   USB to TTL Serial Cable
-   PC with C# installed

**Software Requirements**

-   C#

**Setting up the Jetson Nano**

1.  Connect the USB to TTL Serial Cable to the Jetson Nano's UART ports.
2.  Make sure the baud rate is set to 9600.
3.  If necessary, install the necessary UART driver on the Jetson Nano.

**Setting up the PC**

1.  Connect the other end of the USB to TTL Serial Cable to the PC.
2.  Make sure the baud rate is set to 9600.

**Usage**

1.  Clone the repository by running **git clone https://github.com/ikhwan12/jetson-pc-serialcom.git**
2.  Open the project in Visual Studio and build it.
3.  Update the **COM** port of the PC in the code to match the port you are using.
4.  Deploy the code to the Jetson Nano and PC.
5.  Run the code on both the Jetson Nano and PC.
