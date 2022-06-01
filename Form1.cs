using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galeria_De_Imagenes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            p1.Image = Properties.Resources.o1;
            p2.Image = Properties.Resources.o2;
            p3.Image = Properties.Resources.o3;
            p4.Image = Properties.Resources.o4;
            p5.Image = Properties.Resources.o5;
            p6.Image = Properties.Resources.o6;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            p1.Image = Properties.Resources.Signo;
            p2.Image = Properties.Resources.Signo;
            p3.Image = Properties.Resources.Signo;
            p4.Image = Properties.Resources.Signo;
            p5.Image = Properties.Resources.Signo;
            p6.Image = Properties.Resources.Signo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p1.Image = Properties.Resources.Signo;
            p2.Image = Properties.Resources.Signo;
            p3.Image = Properties.Resources.Signo;
            p4.Image = Properties.Resources.Signo;
            p5.Image = Properties.Resources.Signo;
            p6.Image = Properties.Resources.Signo;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            p1.Image = Properties.Resources.b1;
            p2.Image = Properties.Resources.b2;
            p3.Image = Properties.Resources.b3;
            p4.Image = Properties.Resources.b4;
            p5.Image = Properties.Resources.b5;
            p6.Image = Properties.Resources.b6;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            p1.Image = Properties.Resources.n1;
            p2.Image = Properties.Resources.n2;
            p3.Image = Properties.Resources.n3;
            p4.Image = Properties.Resources.n4;
            p5.Image = Properties.Resources.n5;
            p6.Image = Properties.Resources.n6;
        }

        private void p1_Click(object sender, EventArgs e)
        {

        }
    }
}
