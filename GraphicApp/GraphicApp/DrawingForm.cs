using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicApp
{
    public partial class DrawingForm : Form
    {
        private bool isDrawing;
        private Graphics graphics;
        private Pen pen;
        private int prevX;
        private int prevY;

        public DrawingForm()
        {
            InitializeComponent();
        }

        private void DrawingForm_Load(object sender, EventArgs e)
        {
            isDrawing = false;
            graphics = CreateGraphics();
            pen = new Pen(Color.Black, 2);
        }

        private void DrawingForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                prevX = e.X;
                prevY = e.Y;
            }
            else
            {
                colorDialog1.ShowDialog();
                pen.Color = colorDialog1.Color;
            }
        }

        private void DrawingForm_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void DrawingForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                graphics.DrawLine(pen, prevX, prevY, e.X, e.Y);
                prevX = e.X;
                prevY = e.Y;
            }
        }

        private void DrawingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            graphics.Dispose();
            pen.Dispose();
        }
    }
}
