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
        int index = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            index = rnd.Next(0, imgList.Images.Count);
            pictureBox1.Image = imgList.Images[index];
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            index++;
            if (index == imgList.Images.Count)
            {
                index = 0;
            }
            pictureBox1.Image = imgList.Images[index];
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            index = imgList.Images.Count - 1;
            pictureBox1.Image = imgList.Images[index];
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            index--;
            if (index == -1)
            {
                index = imgList.Images.Count - 1;
            }
            pictureBox1.Image = imgList.Images[index];
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            timer1.Stop(); 
            pictureBox1.Image = imgList.Images[0];
        }
    }
}
