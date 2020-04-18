using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingTests1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdLoadImage_Click(object sender, EventArgs e)
        {
            string fname = txtSourceFile.Text;
            //pbImage.Load(fname);
            Image imag = Image.FromFile(fname);
            Bitmap img = new Bitmap(new Bitmap(imag));
            pbImage.Image = img;
        }

        private void cmdDrawrects_Click(object sender, EventArgs e)
        {
            Rectangle rect1 = new Rectangle(0, 0, 100, 100);
            Graphics gr = Graphics.FromImage(pbImage.Image);
            Pen pen = new Pen(Color.Red);
            gr.DrawRectangle(pen, rect1);
            pbImage.Invalidate();
        }

        private void cmdMisc_Click(object sender, EventArgs e)
        {
            double d = 95.12345678;
            txtSourceFile.Text = string.Format("Hello{0:F2}", d);
        }
    }
}
;