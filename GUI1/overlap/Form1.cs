namespace overlap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            panel1.Hide();
            panel2.Show();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            panel1.Show();
            panel2.Hide();
        }
    }
}