using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen blackPen = new Pen(Color.FromArgb(255, 0, 0, 0), 1);
            Pen greenPen = new Pen(Color.FromArgb(255, 0, 255, 0), 10);
            greenPen.Alignment = PenAlignment.Inset;

            //Draw the line with the wide green pen;
            e.Graphics.DrawRectangle(greenPen, 10, 100, 50, 50);

            //Draw the line with the thin black pen
            e.Graphics.DrawRectangle(blackPen, 10, 100, 50, 50);
        }
    }
}
