namespace ColorThemeForms.test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            theme();
        }

        public void theme()
        {
            var color_theme = SystemColors.Window;
            textBox1.Text = color_theme.ToArgb().ToString(); // color_theme.ToString()

            textBox1.BackColor= SystemColors.Window;

            System.Drawing.Color color = System.Drawing.Color.FromName("Red");


        }
    }
}