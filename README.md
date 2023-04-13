# ![Logo](https://raw.githubusercontent.com/ad4mh3/WinWLAN/main/WinWLAN%20icon.ico) WinWLAN

An alternative to the baked in WiFi manager Windows provides.

![Main program window](https://raw.githubusercontent.com/ad4mh3/WinWLAN/main/Assets/Screenshot%20main%20window.png)



## Why WinWLAN?

WinWLAN, WWLAN, provides:

- Extensive information on every access point including
  - PHY type
  - Cipher
  - Supported speeds
  - AP Type
  - BSSID and whether it is UAA or LAA (legitimate or spoofed MAC address)
  - Signal strength
  - SSID
  - Flags such as
    - Connected
    - HasProfile
  - If unable to connect, reason why
- Ability to scan for APs for any duration from 1 to 999 seconds
- Ability to connect to an AP even if it requires a Username or Domain
- Ability to warn you of APs that are not using their real MAC address (LAA/spoofed)



## What's it built on?

WWLAN is built on .NET 6 C#.



## How can I run it?

You can download the ready-to-run executable that is not framework dependent which can be found in the "Releases" directory (make sure to download the entire directory as the DLLs included are required).



## How can I contribute?

Spread the word! WWLAN is one of few WiFi managers for Windows and any support is greatly appreciated.



## Notices

WinWLAN would not be possible if it wasn't for ManagedNativeWifi and SimpleWIFI.