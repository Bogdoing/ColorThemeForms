using Microsoft.Win32;

namespace ColorThemeForms.test
{
    public partial class Form1 : Form
    {

        private string currentDateTime { get; set; }

        private string AppsUseLightTheme { get; set; }
        private string SystemUsesLightTheme { get; set; }
        public Form1()
        {
            InitializeComponent();
            getTime();
            //swithColorThemeForTime();
        }

        private void clearTextBox()
        {
            tb.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getTime();
            NavigationOnReestr();
            swithColorTheme();
        }

        public void NavigationOnReestr()
        {
            // ������� ��������� ������ �� ������ RegistryKey ���������� ��������� �����.
            RegistryKey myKey = Registry.CurrentUser;
            RegistryKey software = myKey.OpenSubKey("Software");
            RegistryKey microsoft = software.OpenSubKey("Microsoft");
            RegistryKey windows = microsoft.OpenSubKey("Windows");
            RegistryKey currentVersion = windows.OpenSubKey("CurrentVersion");
            RegistryKey themes = currentVersion.OpenSubKey("Themes");
            RegistryKey personalize = themes.OpenSubKey("Personalize");

            //tb.Text = (microsoft.Name + " - ����� ���������: " + microsoft.SubKeyCount);

            // ������ ������ � ������������ � ������ ������.
            AppsUseLightTheme = personalize.GetValue("AppsUseLightTheme").ToString();
            SystemUsesLightTheme = personalize.GetValue("SystemUsesLightTheme").ToString();
            //int Int = Convert.ToInt32(personalize.GetValue("AppsUseLightTheme"));
            //int Ant = Convert.ToInt32(personalize.GetValue("AnotherName"));           

            // ������� ����������, ����� ��������� � ���, ��� ������ ������ �������.
            //tb.Text += "AppsUseLightTheme: " + AppsUseLightTheme + "\r\n" 
            //         + "SystemUsesLightTheme: " + SystemUsesLightTheme + "\r\n";


            closeAllRegistry(myKey, software, microsoft, windows, currentVersion, themes, personalize);

        }

        public void closeAllRegistry(RegistryKey myKey, RegistryKey software, RegistryKey microsoft, RegistryKey windows, RegistryKey currentVersion, RegistryKey themes, RegistryKey personalize)
        {
            personalize.Close();
            themes.Close();
            currentVersion.Close();
            windows.Close();
            microsoft.Close();
            software.Close();
            myKey.Close();
        }

        public void getTime()
        {
            //tb.Text += DateTime.Now.ToString("hh:mm:ss") + "\r\n"; //yyyy-MM-dd hh:mm:ss
            currentDateTime = DateTime.Now.ToString("HH:mm:ss");
        }

        private void swithColorTheme()
        {
            clearTextBox();

            RegistryKey? myKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", true);
            //tb.Text += "\r\n myKey AppsUseLightTheme Value: " + myKey.GetValue("AppsUseLightTheme").ToString();
            if (myKey.GetValue("AppsUseLightTheme").ToString() == "0")
            {
                myKey.SetValue("AppsUseLightTheme", "1", RegistryValueKind.DWord);
                myKey.SetValue("SystemUsesLightTheme", "0", RegistryValueKind.DWord);
                tb.Text += "switch to light \r\n";
                myKey.Close();
            }
            else
            if (myKey.GetValue("AppsUseLightTheme").ToString() == "1")
            {
                myKey.SetValue("AppsUseLightTheme", "0", RegistryValueKind.DWord);
                myKey.SetValue("SystemUsesLightTheme", "0", RegistryValueKind.DWord);
                tb.Text += "switch to dark \r\n";
                myKey.Close();
            }
            else
            {
                tb.Text += "\r\n myKey = null";
            }

        }

        private void swithColorThemeForTime()
        {
            clearTextBox();

            RegistryKey? myKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", true);
            int result = DateTime.Compare(DateTime.Parse(currentDateTime), DateTime.Parse("18:00:00"));
            if (result < 0)
            {
                //tb.Text += "< 0 - ������";
                myKey.SetValue("AppsUseLightTheme", "1", RegistryValueKind.DWord);
                myKey.SetValue("SystemUsesLightTheme", "0", RegistryValueKind.DWord);
                tb.Text += "switch to light \r\n";
                myKey.Close();
            }
            else if (result > 0)
            {
                //tb.Text += "else - �����";
                myKey.SetValue("AppsUseLightTheme", "0", RegistryValueKind.DWord);
                myKey.SetValue("SystemUsesLightTheme", "0", RegistryValueKind.DWord);
                tb.Text += "switch to dark \r\n";
                myKey.Close();
            }
            else
                tb.Text += "==";

            //tb.Text += DateTime.Parse(currentDateTime) + "  " + DateTime.Parse("18:00:00");
        }

        private void onLiteTheme(object sender, EventArgs e)
        {
            clearTextBox();

            Theme.onLight();

            tb.Text += "switch to light \r\n";

        }

        private void onDarkTheme(object sender, EventArgs e)
        {
            clearTextBox();

            Theme.onDark();

            tb.Text += "switch to dark \r\n";

        }

        private void onPerformans(object sender, EventArgs e)
        {
            Energy.onHighPerformance();
        }

        private void onSaving(object sender, EventArgs e)
        {
            Energy.onLowPerformance();
        }

        private void onBalans(object sender, EventArgs e)
        {
            Energy.onAmdBalans();
        }
    }
}