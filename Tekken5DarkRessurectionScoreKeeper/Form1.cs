using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FauskangerLib;

namespace Tekken5DarkRessurectionScoreKeeper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int charImgWidth = 1085 / 12;
        private int charImgHeight = 264 / 3;

        private int X;
        private int Y;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Calc.isInRange(X, 1, 12) && Calc.isInRange(Y, 1, 3) && (X != 1 || Y != 1))
            {
                label1.Text = X.ToString();
                label2.Text = Y.ToString();
            }
            else
            {
                label1.Text = label2.Text = "?";
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            X = e.X/charImgWidth+1;
            Y = e.Y/charImgHeight+1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
