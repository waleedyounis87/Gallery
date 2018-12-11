using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gallery
{
    public partial class Form1 : Form
    {
        int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (sender == a)
            {
                pictureBox2.Image = (Image)Properties.Resources.ResourceManager.GetObject("img1");
            }
            if (sender == b)
            {
                pictureBox2.Image = (Image)Properties.Resources.ResourceManager.GetObject("img2");
            }
            if (sender == c)
            {
                pictureBox2.Image = (Image)Properties.Resources.ResourceManager.GetObject("img3");
            }
            if (sender == d)
            {
                pictureBox2.Image = (Image)Properties.Resources.ResourceManager.GetObject("img4");
            }
            if (sender == test)
            {
                pictureBox2.Image = (Image)Properties.Resources.ResourceManager.GetObject("img5");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Play.Visible = false;
            Pause.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (index > 6)
                index = 0;
            else
            {
                index++;
                pictureBox2.Image = (Image)Properties.Resources.ResourceManager.GetObject("img" + index);
            }
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Pause.Visible = false;
            Play.Visible = true;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (index > 6)
                index = 0;
            else
            {
                index++;
                pictureBox2.Image = (Image)Properties.Resources.ResourceManager.GetObject("img" + index);
            }
        }

        private void Prevouis_Click(object sender, EventArgs e)
        {
            if (index > 6 || index < 0)
                index = 0;
            else
            {
                index--;
                pictureBox2.Image = (Image)Properties.Resources.ResourceManager.GetObject("img" + index);
            }
        }
    }
}
