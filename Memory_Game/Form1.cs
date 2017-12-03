using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Memory_Game
{
    public partial class Form1 : Form
    {
        #region variable

        public static Random rnd = new Random();
        public static PictureBox open1;
        public static PictureBox open2;
        public static List<PictureBox> check = new List<PictureBox>() { };
        public static List<Point> points = new List<Point>();
        
        #endregion

        #region form1

        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Form Load

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (PictureBox image in kaardhouder.Controls)
            {
                image.Cursor = Cursors.Hand;
                points.Add(image.Location);
                image.Image = Properties.Resources.imagemain;
                image.Enabled = true;
            }
            foreach (PictureBox image in kaardhouder.Controls)
            {
                int next = rnd.Next(points.Count);
                Point p = points[next];
                image.Location = p;
                points.Remove(p);
            }
        }

        #endregion

        #region pixturebox clicks

        public void PictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.image1;
            PictureBox main = pictureBox1;
            Image.Imagecheck(main);
        }


        public void PictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.image1;
            PictureBox main = pictureBox2;
            Image.Imagecheck(main);
        }

        public void PictureBox3_Click(object sender, EventArgs e)
        {

            pictureBox3.Image = Properties.Resources.image2;
            PictureBox main = pictureBox3;
            Image.Imagecheck(main);
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.image2;
            PictureBox main = pictureBox4;
            Image.Imagecheck(main);
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.image3;
            PictureBox main = pictureBox5;
            Image.Imagecheck(main);
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources.image3;
            PictureBox main = pictureBox6;
            Image.Imagecheck(main);
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources.image4;
            PictureBox main = pictureBox7;
            Image.Imagecheck(main);

        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.Image = Properties.Resources.image4;
            PictureBox main = pictureBox8;
            Image.Imagecheck(main);
        }

        private void PictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = Properties.Resources.image5;
            PictureBox main = pictureBox9;
            Image.Imagecheck(main);

        }

        private void PictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox10.Image = Properties.Resources.image5;
            PictureBox main = pictureBox10;
            Image.Imagecheck(main);
        }

        private void PictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox11.Image = Properties.Resources.image6;
            PictureBox main = pictureBox11;
            Image.Imagecheck(main);

        }
        private void PictureBox12_Click(object sender, EventArgs e)
        {
            pictureBox12.Image = Properties.Resources.image6;
            PictureBox main = pictureBox12;
            Image.Imagecheck(main);
        }
        #endregion

        #region time

        public void Timeset()
        {
            timer2.Interval = 300;
            timer2.Start();
            timer2.Tick += Timer2_Tick;
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            foreach (PictureBox image in check)
            {
                image.Image = Properties.Resources.imagemain;
            }
            Image.Openclear();
        }

        #endregion

        #region restart button

        private void button1_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        #endregion

    }
}
