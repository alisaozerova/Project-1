namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lockButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LockButton was clicked");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button was clicked");
        }
    }
}
