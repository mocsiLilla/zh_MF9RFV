namespace Receptes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl1 uc1 = new UserControl1();
            panel1.Controls.Add(uc1);
            //panel1.Dock = DockStyle.Fill;
            uc1.Dock = DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl2 uc2 = new UserControl2(); 
            panel1.Controls.Add(uc2);
            uc2.Dock = DockStyle.Fill;
        }
    }
}