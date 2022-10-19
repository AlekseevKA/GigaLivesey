﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace WindowsFormsApp1
{
    public partial class GigaForm3 : Form
    {
        public GigaForm3(Form2 f)
        {
            InitializeComponent();
        }
        public GigaForm3()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.UserPaint, true);

            UpdateStyles();




            BackgroundImage = Image.FromStream(new WebClient().OpenRead("https://media.tenor.com/yPUAJMwL2uwAAAAC/gigachad.gif"));
            ImageAnimator.Animate(BackgroundImage, OnFrameChanged);

            WMP.URL = @"E:\ЗАГРУЗКИ\GigaLivesey-master\GigaLivesey-master\WindowsFormsApp1\Resources\GigaChad.mp3";
            WMP.controls.play();
            //WMP.controls.stop();
            //WMP.close();

            this.BackgroundImageLayout = ImageLayout.Stretch;
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.ResizeRedraw, true);
        }
        public Bitmap HandlerTexure = Resource1.GigaFace,
            TargetTexture = Resource1.Target;
        private Point _targetPosition = new Point(300, 300);
        private Point _direction = Point.Empty;
        private int _score = 0;
        // private PictureBox pictureBox;

        private Random _random = new Random();

        private void OnFrameChanged(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke((Action)(() => OnFrameChanged(sender, e)));
                return;
            }
            ImageAnimator.UpdateFrames();
            Invalidate(false);

        }
        private void GigaForm3_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            var localPosition = this.PointToClient(Cursor.Position);

            _targetPosition.X += _direction.X * 1;
            _targetPosition.Y += _direction.Y * 1;

            if (_targetPosition.X < 0 || _targetPosition.X > 1900)
            {
                _direction.X *= -1;

            }
            if (_targetPosition.Y < 0 || _targetPosition.Y > 1000)
            {
                _direction.Y *= -1;

            }


            Point between = new Point(localPosition.X - _targetPosition.X, localPosition.Y - _targetPosition.Y);
            float distance = (float)Math.Sqrt((between.X * between.X) + (between.Y * between.Y));

            if (distance < 70)
            {
                AddScore(1);
            }
            if (distance < 10)
            {
                AddScore(5);
            }

            var handlerRect = new Rectangle(localPosition.X - 50, localPosition.Y - 50, 100, 100);
            var targetRect = new Rectangle(_targetPosition.X - 50, _targetPosition.Y - 50, 100, 200);
            g.DrawImage(HandlerTexure, targetRect);
            g.DrawImage(TargetTexture, handlerRect);

        }
        public WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();

        private void musicOn_Click(object sender, EventArgs e)
        {
            WMP.URL = @"E:\ЗАГРУЗКИ\GigaLivesey-master\GigaLivesey-master\WindowsFormsApp1\Resources\GigaChad.mp3";
            WMP.controls.play();
            //WMP.controls.stop();
            //WMP.close();
        }

        private void musicOff_Click(object sender, EventArgs e)
        {
            WMP.URL = @"E:\ЗАГРУЗКИ\GigaLivesey-master\GigaLivesey-master\WindowsFormsApp1\Resources\GigaChad.mp3";
            //WMP.controls.play();
            WMP.controls.stop();
            //WMP.close();  
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            WMP.controls.stop();

            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            WMP.controls.stop();

            DialogResult res = MessageBox.Show("Вы действительно хотите выйти?", "Предупреждение", MessageBoxButtons.YesNoCancel);

            if (res == System.Windows.Forms.DialogResult.Yes)
            {
                GigaForm3.ActiveForm.Close();

            }
            else
            {
                return;
            }
            GigaForm3 gigaForm3 = (GigaForm3)Application.OpenForms["GigaForm3"];
            if (gigaForm3 != null)
            {




                this.Close();
            }
            else
                MessageBox.Show("Error while changing data in Form1.", "Error");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            timer2.Interval = r.Next(25, 1000);
            _direction.X = r.Next(-1, 2);
            _direction.Y = r.Next(-1, 2);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

            int p1 = BackgroundImage.Size.Width;
            int p2 = BackgroundImage.Size.Height;
            int s1 = pictureBox1.Size.Width;
            int s2 = pictureBox1.Size.Height;

            Random rnd = new Random();
            // pictureBox1.Location = new Point(rnd.Next(Location.X), rnd.Next(Location.Y));
            //   pictureBox1.Location = new Point(rnd.Next(_targetPosition.X += _direction.X * 1, _targetPosition.Y += _direction.Y * 1));
            //pictureBox1.Location = new Point(rnd.Next(_targetPosition.X += _direction.X * 1, _targetPosition.Y += _direction.Y * 1));
            pictureBox1.Location = new Point(rnd.Next(p1 - s1), rnd.Next(p2 - s2));

            int score = 1;
            _score += score;
            scoreLabel.Text = _score.ToString();
            pictureBox1.Visible = true;



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {



        }

        private void AddScore(int score)
        {

            _score += score;
            scoreLabel.Text = _score.ToString();

        }

    }

}
