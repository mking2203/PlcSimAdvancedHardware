# PlcSimAdvancedHardware
Siemens PlcSimAdvanced Hardware Simulator

Working with the Siemens Software PlcSimAdvanced I realized I can do a simulation of the PLC but not for the IO's. I know there are products out there, but quite expensive for small machines. I discovered the API which comes with the simulation. So I wrote a Hardware simulator where I can manipulate the inputs which leads me to a virtual commissioning.

Actual functions:
-Button (Bool)
-Toogle-button (Bool)
-Checkbox (Bool)
-Lamps (Bool)
-Trackbar (Dint Value like analog inputs)
-Inregrator (raises value in certain speed)
-Pulse generator (Bool)

You can find my TIA 16 demo project also here.

https://github.com/mking2203/PlcSimAdvancedHardware/blob/main/Pictures/PlcSimAdvanced30.png

1. start the simulator and start one instance of CPU
2. start the TIA Portal and download the file
3. the PLC should run now in virtual mode
4. copy the JSON file to the app folder and edit the PLC instance if needed
5. start the app

With the buttons you can now manipulate the inputs and see the outputs.

https://github.com/mking2203/PlcSimAdvancedHardware/blob/main/Pictures/HardwareSimulation.png
