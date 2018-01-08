# XMRGUI
GUI miner for the cryptonight algorithm 

XMR GUI is in development and is in early alpha stages. Feel free to use the miner and submit any bugs. Currently, there are some issues with the initial GPU setup. 

If you have a GPU and already have either CUDA or OpenCL installed click no to both prompts! 

Feel free to leave any and all suggestions for new features as I will be maintaining this regularly. 

Windows builds are in the Release Folder. 

* Many of the features in the GUI do not function yet, please be patient and I will continue to update and add them.

* If you want to update your copy, delete the directory at appdata/XMRGUI and then download the program again.

* There is currently an issue where the program errors out stating it is missing "libeay32.dll" and "ssleay32.dll"
  These are libraries for OpenSSL. I have provided an affitional copy in the DLL folder until I can fix the issue. 
  These need to be copied into your C:\Windows\System32 folder if you don't already have them.
