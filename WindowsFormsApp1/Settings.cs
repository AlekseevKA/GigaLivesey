using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        public Settings(Form2 f)
        {
            InitializeComponent();
        }
        public Settings(Form1 f)
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void livesey_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void gigachad_Click(object sender, EventArgs e)
        {
            GigaForm3 gigaForm3 = new GigaForm3();
            gigaForm3.Show();
            this.Hide();
        }
    }
}
