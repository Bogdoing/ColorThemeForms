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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getTime();
            NavigationOnReestr();
            swithColorTheme();
        }

        public void NavigationOnReestr()
        {
            // Процесс получения ссылки на объект RegistryKey называется открытием ключа.
            RegistryKey myKey = Registry.CurrentUser;
            RegistryKey software = myKey.OpenSubKey("Software");
            RegistryKey microsoft = software.OpenSubKey("Microsoft");
            RegistryKey windows = microsoft.OpenSubKey("Windows");
            RegistryKey currentVersion = windows.OpenSubKey("CurrentVersion");
            RegistryKey themes = currentVersion.OpenSubKey("Themes");
            RegistryKey personalize = themes.OpenSubKey("Personalize");

            //tb.Text = (microsoft.Name + " - всего элементов: " + microsoft.SubKeyCount);

            // Читаем данные и конвертируем в нужный формат.
            AppsUseLightTheme = personalize.GetValue("AppsUseLightTheme").ToString();
            SystemUsesLightTheme = personalize.GetValue("SystemUsesLightTheme").ToString();
            //int Int = Convert.ToInt32(personalize.GetValue("AppsUseLightTheme"));
            //int Ant = Convert.ToInt32(personalize.GetValue("AnotherName"));           

            // Покажем содержимое, чтобы убедиться в том, что чтение прошло успешно.
            tb.Text += "AppsUseLightTheme: " + AppsUseLightTheme + "\r\n" 
                     + "SystemUsesLightTheme: " + SystemUsesLightTheme + "\r\n";


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
            int result = DateTime.Compare(DateTime.Parse(currentDateTime), DateTime.Parse("18:00:00"));
            if (result < 0)
                tb.Text += "< 0 - раньше";
            else if (result == 0)
                tb.Text += "==";
            else
                tb.Text += "else - позже";

            tb.Text += DateTime.Parse(currentDateTime) + "  " + DateTime.Parse("18:00:00");


            RegistryKey myKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", true);
            if (myKey != null)
            {
                myKey.SetValue("AppsUseLightTheme", "1", RegistryValueKind.DWord);
                myKey.Close();
            }
            else
            {
                tb.Text += "\r\n myKey = null";
            }
        }
    }
}