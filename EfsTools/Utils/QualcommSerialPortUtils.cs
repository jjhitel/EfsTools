﻿using System.Collections.Generic;
using System.Runtime.InteropServices;
using EfsTools.Qualcomm;
using Microsoft.Win32;

namespace EfsTools.Utils
{
    internal static class QualcommSerialPortUtils
    {
        public static bool IsQualcommPort(string port, int baudrate)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return IsWindowsQualcommPort(port);
            }

            return CheckQualcommPort(port, baudrate);
        }

        private static bool IsWindowsQualcommPort(string port)
        {
            var qualcommPorts = InitializeQualcommPorts();
            return qualcommPorts.Contains(port);
        }

        private static bool CheckQualcommPort(string port, int baudrate)
        {
            try
            {
                using (var manager = new QcdmManager(port, baudrate, 500))
                {
                    manager.Open();
                    var version = manager.Version;
                    manager.Close();
                    return true;
                }
            }
            catch
            {
            }
            return false;
        }

        private static HashSet<string> InitializeQualcommPorts()
        {
            try
            {
                var qualcommPorts = new HashSet<string>();
                using (var portsKey =
                    Registry.LocalMachine.OpenSubKey(
                        "SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e978-e325-11ce-bfc1-08002be10318}", false))
                {
                    if (portsKey != null)
                    {
                        foreach (var keyName in portsKey.GetSubKeyNames())
                        {
                            if (keyName != "Properties")
                            {
                                ProcessRegistryKey(portsKey, keyName, qualcommPorts);
                            }
                        }
                    }
                }
                return qualcommPorts;
            }
            catch
            {
                return new HashSet<string>();
            }
        }

        private static void ProcessRegistryKey(RegistryKey portsKey, string keyName, HashSet<string> qualcommPorts)
        {
            try
            {
                using (var portKey = portsKey.OpenSubKey(keyName, false))
                {
                    if (portKey != null)
                    {
                        var assignedPortForQcDevice =
                            portKey.GetValue("AssignedPortForQCDevice", string.Empty).ToString();
                        if (!string.IsNullOrEmpty(assignedPortForQcDevice))
                        {
                            qualcommPorts.Add(assignedPortForQcDevice);
                        }
                    }

                    // "Qualcomm HS-USB"
                }
            }
            catch
            {
                // ignored
            }
        }
    }
}