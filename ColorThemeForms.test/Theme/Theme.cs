using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorThemeForms.test
{
    public class Theme
    {
        static public void onDark()
        {
            RegistryKey? myKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", true);
            myKey.SetValue("AppsUseLightTheme", "0", RegistryValueKind.DWord);
            myKey.SetValue("SystemUsesLightTheme", "0", RegistryValueKind.DWord);
            myKey.Close();
        }

        static public void onLight()
        {
            RegistryKey? myKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", true);
            myKey.SetValue("AppsUseLightTheme", "1", RegistryValueKind.DWord);
            myKey.SetValue("SystemUsesLightTheme", "0", RegistryValueKind.DWord);
            myKey.Close();
        }
    }
}
