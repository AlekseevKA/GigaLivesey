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
    public partial class Form2 : Form
    {
 


    
        public Form2()
        {
            InitializeComponent();
        }
        //awaid this
        public Form2(Form1 f, GigaForm3 gigaForm3)
        {
            InitializeComponent();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {

            if (e.newState == 8)
            {
                this.axWindowsMediaPlayer1.close();
                this.Controls.Remove(axWindowsMediaPlayer1);

            }

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Вы действительно хотите выйти?", "Предупреждение", MessageBoxButtons.YesNoCancel);
            if (res == System.Windows.Forms.DialogResult.Yes)
            {
                Form1.ActiveForm.Close();

            }
            else
            {
                return;
            }
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            if (form1 != null)
            {
                this.Close();
            }
            else
                MessageBox.Show("Error while changing data in Form1.", "Error");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
            this.Hide();
        }
        public WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            WMP.URL = @"E:\ЗАГРУЗКИ\GigaLivesey-master\GigaLivesey-master\WindowsFormsApp1\Resources\ass-we-can.mp3";
          //  WMP.URL = @"E:\ЗАГРУЗКИ\GigaLivesey-master\GigaLivesey-master\WindowsFormsApp1\Resources\56800453453.mp3";

            WMP.controls.play();
            //WMP.controls.stop();
            //WMP.close();
        }
    }
}
