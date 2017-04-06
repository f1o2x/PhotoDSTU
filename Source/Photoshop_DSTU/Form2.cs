using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photoshop_DSTU
{
    public partial class Form2 : Form
    {
        Form1 parent;
        ColorSpace[] clone;
        public Form2()
        {
            InitializeComponent();
        }

        public void GetClone(ColorSpace[] clone)
        {
            this.clone = clone;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            parent = (Form1)this.Owner;
        }

        public void button3_Click(object sender, EventArgs e)
        {
            parent.CreateClone();
            parent.clone_ycbcr = false;
            parent.pictureBox1.Image = parent.img_loader.Razconvert(parent.img_loader.get_byte);
            this.Close();
        }

        public void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (!(parent.clone_ycbcr))
            {
                parent.clone_ycbcr = !parent.clone_ycbcr;
                clone = ImgLoader.RGBtoYCbCr(clone);
                parent.clone_ycbcr = true;
            }
            parent.img_loader.ClearByte(); //in the name of garbage collector
            clone.CopyTo(parent.img_loader.get_byte, 0);
            parent.img_loader.ChangeBrightness(trackBar1.Value);
            parent.pictureBox1.Image = parent.img_loader.Razconvert(parent.img_loader.get_byte);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (parent.clone_ycbcr)
            {
                clone = ImgLoader.YCbCrtoRGB(clone);
                parent.clone_ycbcr = false;
            }
            parent.img_loader.ClearByte(); //in the name of garbage collector
            clone.CopyTo(parent.img_loader.get_byte, 0);
            parent.pictureBox1.Image = parent.img_loader.Razconvert(parent.img_loader.get_byte);
            this.Close();
        }


        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Enabled = true;
        }
    }
}
