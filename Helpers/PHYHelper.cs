using SimpleWifi.Win32.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinWLAN.Helpers
{
    internal class PHYHelper
    {
        internal static string Lookup(uint value)
        {
            switch (value)
            {
                case 0:
                    return "Unknown/Any";
                case 1:
                    return "FHSS (frequency-hopping spread-spectrum) (Bluetooth?)";
                case 2:
                    return "DSSS (direct sequence spread spectrum)";
                case 3:
                    return "IrBaseband (infrared baseband)";
                case 4:
                    return "OFDM (orthogonal frequency division multiplexing)";
                case 5:
                    return "HRDSSS (high-rate DSSS)";
                case 6:
                    return "ERP (extended rate) (802.11g device?)";
                case 7:
                    return "802.11n (WiFi 4)";
                case 8:
                    return "802.11ac (WiFi 5)";
                case 0x80000000:
                    return "IHV_Start (Reserved/Developed by independent manufacturer)";
                case 0xffffffff:
                    return "IHV_End (Reserved/Developed by independent manufacturer)";
                default:
                    return $"Unable to resolve (={value})";
            }
        }
    }
}
