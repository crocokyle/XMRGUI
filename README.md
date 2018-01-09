# XMRGUI

XMR GUI is in development and is in early alpha stages. Feel free to use the miner and submit any bugs below in the comments section. Currently, there are some issues with the initial GPU setup. 

If you have a GPU and already have either CUDA or OpenCL installed click no to both prompts! 

Feel free to leave any and all suggestions for new features as I will be maintaining this regularly. 

Many of the features in the GUI do not function yet, please be patient and I will continue to update and add them.
If you want to update your copy, delete the directory at AppData/Roaming/XMRGUI and then download the program again.


Instructions:

1. Run setup - In the release folder or at https://akhawaii.com/xmr-gui
2. If you have Cuda or OpenCL installed, press "NO" to both prompts. XMRGUI will still use your GPU. It has issues detecting whether CUDA and OpenCL are installed and also downloads extremely slowly. I recommend manually grabbing these if you don't already have them.
3. Enter your Pool URL, XMR Address, Port Number, and Pool Password. 
4. Click "Mine!"


Special Notes:

If you have issues with the program, please follow the instructions to update your copy. Make sure to delete the folder at /AppData/Roaming/XMRGUI.
Choosing the "Run on Idle" option has some minor issues. Please report them below. Currently, the GUI will remember your pool information, however, it won't remember the option for "Run on Idle" even though it still functions
If you click "Mine!" and don't get any text displayed in the terminal area, please double check your pool information for incorrect symbols.
Antivirus currently detects xmr-stak.exe as a potentially dangerous file. Untill I can request that xmr-stak be whitelisted, you may need to allow it to run manually. This happens with almost all compiled versions of xmr-stak.


Changelog:

01/08/2018 - Added "Run on Idle" and "Run on Startup" Feature, Several Bugs Fixed. 

01/07/2018 - Fixed OpenSSL exceptions.
