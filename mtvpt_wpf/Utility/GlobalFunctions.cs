using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace mtvpt_wpf.Utility
{
    public static class GlobalFunctions
    {
        public static void ShowDebug(string msg)
        {
            Debug.WriteLine(msg);
        }

        public static string GetIPAddress()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            string ipaddress = "";
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    ipaddress = ip.ToString();
                }
            }
            return ipaddress;
        }

        public static bool isNotError(bool value)
        {
            if (value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
