using System;
using System.Drawing;
using System.Windows.Forms;

namespace Slider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }
        Random rnd = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {

            pictureBox1.Image = imgList.Images[rnd.Next(0, imgList.Images.Count)];
        }

        private void trcSpeed_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = trcSpeed.Value;
        }

        private void trcRed_Scroll(object sender, EventArgs e)
        {
            int red = trcRed.Value;
            int blue = trcBlue.Value;
            int green = trcGreen.Value; 
            this.BackColor = Color.FromArgb(red, green, blue);
        }
    }
}
