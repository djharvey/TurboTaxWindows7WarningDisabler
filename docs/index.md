# TurboTax Windows 7 Warning Disabler

![Microsoft has ended support for Windows 7 - your computer is at risk for
malware and virus attack Upgrade your operating system prior to using Turbo Tax
Your computer is running on Windows 7. Microsoft no longer provides security updates or support for PCs running Windows 7. This means your computer is more vulnerable to security risks and viruses. To avoid these risks, Microsoft recommends upgrading to Windows 10.
To help maintain the security of your personal information, like your Social Security number and bank account information, you need to upgrade your operating system immediately.
Select "Switch to Win 10" to exit TurboTax and learn how to upgrade to Windows 10. Don't worry, your TurboTax information is saved, so you can pick up right where you left off.
By selecting "Continue on Win 7" you are acknowledging the risks of using TurboTax on Windows 7 (not recommended).
Continue on Windows 7
Switch to Windows 10](images/TurboTaxWindows7Nag.png)

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

This project is licensed under the MIT License - see the [LICENSE.md](License.md) file for details.

### Buy Me a Coffee?

If (and only if) you have found my work helpful and feel so inclined, tips are always appreciated but never expected.
<a href="https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=N7STENDX6DGHE&currency_code=USD" target="_blank"><img src="https://www.paypalobjects.com/en_US/i/btn/btn_donate_SM.gif" alt="Donate with PayPal button" /></a>
