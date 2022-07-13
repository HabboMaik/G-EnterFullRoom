using System;
using System.Windows.Forms;

namespace GeodeExampleCSharp
{
    public partial class MainWindow : Form
    {
        public Extension ExtensionChild;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            ExtensionChild = new Extension(this);
            TopMost = true;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            ExtensionChild.OpenFlatConnection();
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            ExtensionChild.OpenFlatConnection();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                timer1.Enabled = true;
                
            }
            else
            {
                timer1.Enabled = false;
               
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked)
                this.TopMost = true;
            else
                this.TopMost = false; //provide a way to turn it off
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}