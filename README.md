# XMRGUI

XMR GUI is in development and is in early alpha stages. This is a frontend wrapper for xmr-stak. Feel free to use the miner and submit any bugs below in the comments section.

![alt text](https://akhawaii.com/wp-content/uploads/2018/01/screen.gif)

![alt text](https://akhawaii.com/wp-content/uploads/2018/01/screen1.png)



Feel free to leave any and all suggestions for new features as I will be maintaining this regularly. 

Many of the features in the GUI do not function yet, please be patient and I will continue to update and add them.

* Currently, the dev donation is configurable through the GUI at a minimum of 1%

Instructions:

1. Run setup - In the release folder or at https://akhawaii.com/xmr-gui
2. Enter your Pool URL, XMR Address, Port Number, and Pool Password. 
3. Click "Mine!"


Special Notes:

If you have issues with the program make sure to delete the folder at /AppData/Roaming/XMRGUI and reinstall.
Choosing the "Run on Idle" option has some minor issues. Please report them below. Currently, the GUI will remember your pool information, however, it won't remember the option for "Run on Idle" even though it still functions
If you click "Mine!" and don't get any text displayed in the terminal area, please double check your pool information for incorrect symbols.
Antivirus currently detects xmr-stak.exe as a potentially dangerous file. Untill I can request that xmr-stak be whitelisted, you may need to allow it to run manually. This happens with almost all compiled versions of xmr-stak.


Changelog:

01/12/2018 - Fixed GPU detection and setup. Added an instructional for beginners.

01/11/2018 - Fixed a major memory leak. Added first hashrate graph. Several Bug Fixes.

01/10/2018 - Added an update utility. Users will be prompted to update if one is found. Installation takes less than 1 minute and is automatic.

01/09/2018 - Updated UI Color Scheme, possible long run time memory overflow fix, added terminal color settings, fixed refresh interval.

01/08/2018 - Added "Run on Idle" and "Run on Startup" Feature, Several Bugs Fixed. 

01/07/2018 - Fixed OpenSSL exceptions.
