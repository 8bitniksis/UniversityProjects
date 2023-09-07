using System;
using System.Windows.Forms;

namespace OS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            Form_process form2 = new Form_process();
            form2.Show();
            form2.Location = this.Location;
            Hide();  
        }
    }
}
