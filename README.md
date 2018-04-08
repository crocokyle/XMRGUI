# XMRGUI

XMR GUI is in development and early alpha stages. This is a frontend wrapper for xmr-stak. Feel free to use the miner and submit any bugs in [Issue](https://github.com/crocokyle/XMRGUI/issues), or improvements in a Pull request.

![alt text](https://akhawaii.com/wp-content/uploads/2018/01/screen1-1.png)

![alt text](https://akhawaii.com/wp-content/uploads/2018/01/screen2.png)



Feel free to leave any and all suggestions for new features as I will be maintaining this regularly. 

Many of the features in the GUI do not function yet, please be patient and I will continue to update and add them.

* Currently, the dev donation is configurable through the GUI at a minimum of `1%`.

Instructions:

1. Run `xmrgui_setup_v(version number).exe` - downlaod it from [Releases](https://github.com/crocokyle/XMRGUI/releases) or from [the site](http://xmrgui.com/download)

2. Enter your `Pool URL`, `XMR Address`, `Port Number`, and `Pool Password`. 
3. Click `Mine!`



**Special Notes:**

- If you have issues with the program make sure to delete the folder at `/AppData/Roaming/XMRGUI` and reinstall.

- Choosing the `Run on Idle` option has some minor issues. Please report them in the Issues section. 

- Currently, the GUI will remember your pool information, however, it won't remember the option for `Run on Idle` even though it still functions.

- If you click `Mine!` and no text is displayed in the terminal area, please double check your pool information for incorrect symbols.

- Antiviruses currently detect `xmr-stak.exe` as a potentially dangerous file. Until I can request that it be be whitelisted, you may need to allow it to run manually. This happens with almost all compiled versions of xmr-stak.


*Changelog:*

01/14/2018 - Many UI Improvements, added manual CPU Configuration.

01/13/2018 - Lots of housecleaning. Fixed broken updates. Completed setup wizard.

01/12/2018 - Fixed GPU detection and setup. Added an instructional for beginners.

01/11/2018 - Fixed a major memory leak. Added first hashrate graph. Several Bug Fixes.

01/10/2018 - Added an update utility. Users will be prompted to update if one is found. Installation takes less than 1 minute and is automatic.

01/09/2018 - Updated UI Color Scheme, possible long run time memory overflow fix, added terminal color settings, fixed refresh interval.

01/08/2018 - Added "Run on Idle" and "Run on Startup" Feature, Several Bugs Fixed. 

01/07/2018 - Fixed OpenSSL exceptions.
