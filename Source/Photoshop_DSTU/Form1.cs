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
    public partial class Form1 : Form
    {
        public bool clone_ycbcr;
        public ImgLoader img_loader;
        public ColorSpace[] clone;
        const string availableFormats = "Bitmap|*.bmp|Gif|*.gif|PNG|*.png|JPEG|*.jpg";

        public Form1()
        {
            InitializeComponent();
            saveToolStripMenuItem.Enabled = false;

            foreach (ToolStripMenuItem item in menuStrip1.Items)
                item.Enabled = false;
            //file->load must be accessible
            menuStrip1.Items[0].Enabled = true;
            ePICFORMATLoadToolStripMenuItem.Enabled = true;
            ePICFORMATToolStripMenuItem.Enabled = true;
        }

        //backup
        public void CreateClone()
        {
            clone = new ColorSpace[img_loader.get_byte.Length];
            img_loader.get_byte.CopyTo(clone, 0);
        }

        //save function
        private void Save()
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            if (MessageBox.Show("Save?", "Saving", buttons) == DialogResult.Yes)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = availableFormats;
                if (sfd.ShowDialog() == DialogResult.OK)
                    img_loader.SaveImage(sfd.FileName);
            }
        }

        //TOOLSTRIPS
        //load
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = availableFormats;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                img_loader = new ImgLoader();
                img_loader.OpenImage(ofd.FileName);
                pictureBox1.Image = img_loader.Razconvert(img_loader.get_byte);
                saveToolStripMenuItem.Enabled = true;
                foreach (ToolStripMenuItem item in menuStrip1.Items)
                    item.Enabled = true;
                CreateClone();
                clone_ycbcr = false;
            }
        }

        //save
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        //exit-save
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveToolStripMenuItem.Enabled)
                Save();
            this.Close();
        }

        //rgb->gbr->brg
        private void rGBGBRBRGRGBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            img_loader.RGBtoGBR();
            pictureBox1.Image = img_loader.Razconvert(img_loader.get_byte);
            CreateClone();
        }

        //open change brightness form
        private void changeBrightnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Form2 form2 = new Form2();
            form2.GetClone(clone);
            form2.Show(this);
        }

        //mirror - vertical
        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            img_loader.Mirror('v');
            pictureBox1.Image = img_loader.Razconvert(img_loader.get_byte);
            CreateClone();
        }

        //mirror - horizontal
        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            img_loader.Mirror('h');
            pictureBox1.Image = img_loader.Razconvert(img_loader.get_byte);
            CreateClone();
        }

        //linear brightness correction
        private void correctBrightnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            img_loader.CorrectBrightness();
            pictureBox1.Image = img_loader.Razconvert(img_loader.get_byte);
            CreateClone();
        }

        //relief_alpha
        private void reliefToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double[,] RELIEF1 = {
                       {0, 0, -1},
                       {0, 0, 0},
                       {1, 0, 0}
                       };
            Philter_matrix relief1 = new Philter_matrix(RELIEF1, 1, 128, true);
            img_loader.Philter(relief1);
            pictureBox1.Image = img_loader.Razconvert(img_loader.get_byte);
            CreateClone();
        }

        //relief_beta
        private void greyContursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double[,] RELIEF2 = {
                       {-1, -1, -1},
                       {-1, 8, -1},
                       {-1, -1, -1}
                       };
            Philter_matrix relief2 = new Philter_matrix(RELIEF2, 1, 128, true);
            img_loader.Philter(relief2);
            pictureBox1.Image = img_loader.Razconvert(img_loader.get_byte);
            CreateClone();
        }

        //blur
        private void blurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double[,] ZGLAD = {
                       {1, 2, 1},
                       {2, 5, 2},
                       {1, 2, 1}
                         };
            Philter_matrix zglad = new Philter_matrix(ZGLAD, 1.0 / 16);
            img_loader.Philter(zglad);
            pictureBox1.Image = img_loader.Razconvert(img_loader.get_byte);
            CreateClone();
        }

        //sharpness
        private void sharpnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double[,] RAZGLAD = {
                       {0, -1, 0},
                       {-1, 5, -1},
                       {0, -1, 0}
                       };
            Philter_matrix razglad = new Philter_matrix(RAZGLAD);
            img_loader.Philter(razglad);
            pictureBox1.Image = img_loader.Razconvert(img_loader.get_byte);
            CreateClone();
        }

        //Aqua
        private void custom1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            img_loader.Aqua();

            pictureBox1.Image = img_loader.Razconvert(img_loader.get_byte);
            CreateClone();
        }


        //rotation left
        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            img_loader.RotationLeft();
            pictureBox1.Image = img_loader.Razconvert(img_loader.get_byte);
            CreateClone();
        }

        //rotation right
        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            img_loader.RotationRight();
            pictureBox1.Image = img_loader.Razconvert(img_loader.get_byte);
            CreateClone();
        }

        //scale up
        private void increaseX2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            img_loader.Scale(2, 'i'); //Change this scale here (1x, 2x, 3x, 'i' for increase, 'd' for decrease)
            pictureBox1.Image = img_loader.Razconvert(img_loader.get_byte);
            CreateClone();
        }

        //scale down
        private void decreaseX2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            img_loader.Scale(2, 'd'); //Change this scale here (1x, 2x, 3x, 'i' for increase, 'd' for decrease)
            pictureBox1.Image = img_loader.Razconvert(img_loader.get_byte);
            CreateClone();
        }

        //grayscale
        private void goToGrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            img_loader.RGBtoGrey();
            pictureBox1.Image = img_loader.Razconvert(img_loader.get_byte);
            CreateClone();
        }

        //negative
        private void negativeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            img_loader.Negative();
            pictureBox1.Image = img_loader.Razconvert(img_loader.get_byte);
            CreateClone();
        }
        //sepia
        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            img_loader.Sepia();
            pictureBox1.Image = img_loader.Razconvert(img_loader.get_byte);
            CreateClone();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (saveToolStripMenuItem.Enabled)
                Save();
        }

        //lab2
        private void ePICFORMATToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            if (MessageBox.Show("Save?", "Saving", buttons) == DialogResult.Yes)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "EPC|*.epc";
                if (sfd.ShowDialog() == DialogResult.OK)
                    img_loader.SaveAsEF(sfd.FileName);
            }
        }

        private void ePICFORMATLoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                img_loader = new ImgLoader();
                img_loader.LoadAsEF(ofd.FileName);
                pictureBox1.Image = img_loader.Razconvert(img_loader.get_byte);
                saveToolStripMenuItem.Enabled = true;
                CreateClone();
                clone_ycbcr = false;
            }
        }
    }
}
