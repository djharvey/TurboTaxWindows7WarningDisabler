# TurboTax Windows 7 Warning Disabler

If you're tired of the TurboTax 2019 Windows 7 to Windows 10 update warning/nag screen, such as I was, maybe this application can help to disable it for each application launch.

This little console application is designed to go into the current user's AppData folder and modify the pertinent setting in the settings JSON file. A backup version of the file is also made in case you might need to restore it.

Alternatively, you can simply go to %AppData%\Intuit\TurboTax\TY19\TTWin\Notifications and edit "Notifications.settings" manually. Specifically, look for the feature called "windows7ShowDialog" and edit the "miscPayload" section from "{\"Enabled\":true}" to "{\"Enabled\":false}".

This has been tested on TurboTax 2019 Deluxe. It should work on other 2019 versions, but I have not tested this, nor is it guaranteed. If you're reading this in the future, it probably won't work on later versions. I don't recommend trying until I've had a chance to test myself.

Please understand that by modifying these files, you undertake any and all risk yourself. I am not responsible for any loss or damage to your system. Proceed at your own risk.

### Getting Started

The project was built in Visual Studio 2017 and is built on .NET 4.6.1.

### Installing

It's fairly simple. [Pull the project](https://github.com/djharvey/TurboTaxWindows7WarningDisabler) and build. Alternatively, you can download the executable from the [releases](https://github.com/djharvey/TurboTaxWindows7WarningDisabler/releases) page.

### Deployment

The executable must be run under each Windows account where you wish to remove the nag screen, as the TurboTax settings are stored on a per-user basis.

### Authors

* **David Harvey**

### License

This project is licensed under the MIT License - see the [LICENSE.md](License.md) file for details
