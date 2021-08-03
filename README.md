# aspnetCryptTools

Instructions

-Create a new C# (.net framework) console application in Visual Studio

-Replace the contents of program.cs with that of FormsDecrypt.cs or FormsEncrypt.cs (whichever you are compiling) 

-Replace the contents of app.config with the app.config in this repo

-Put the desired decryption / validation keys in the app.config, make sure the algo's are set correctly

-Build the solution, and then use from the command line

For FormsDecrypt.cs:

After building, run on the command line. Example: FormsDecrypt.exe [your encrypted forms cookie]

For FormsEncrypt.cs:

By default, it loads an existing cookie and swaps out the userData field, and adds time to the expiry. To change the username, simply comment out the existing one and use the currently commented line which uses a user-defined username. 


IMPORTANT! If you are importing a machineKey, and it has a "compatibilityMode" attribute set, you need to match it. If you don't know if there was one set, or you don't know what version of .NET you are dealing with, here are three values to set (before compliing) if you are having trouble: Framework20SP1, Framework20SP2, Framework45

