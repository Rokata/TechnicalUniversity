using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicApp
{
    public partial class PieChartForm : Form
    {
        public PieChartForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i1 = int.Parse(textBox1.Text);
            int i2 = int.Parse(textBox2.Text);
            int i3 = int.Parse(textBox3.Text);
            int i4 = int.Parse(textBox4.Text);

            float total = i1 + i2 + i3 + i4;

            float deg1 = (i1 / total) * 360;
            float deg2 = (i2 / total) * 360;
            float deg3 = (i3 / total) * 360;
            float deg4 = (i4 / total) * 360;
            
            Graphics g = this.CreateGraphics();
            Rectangle rec = new Rectangle(textBox1.Location.X + textBox1.Size.Width + 10, 12, 150, 150);
            Brush b1 = new SolidBrush(Color.Red);
            Brush b2 = new SolidBrush(Color.Blue);
            Brush b3 = new SolidBrush(Color.Black);
            Brush b4 = new SolidBrush(Color.BlueViolet);

            g.Clear(PieChartForm.DefaultBackColor);

            g.FillPie(b1, rec, 0, deg1);
            g.FillPie(b2, rec, deg1, deg2);
            g.FillPie(b3, rec, deg2 + deg1, deg3);
            g.FillPie(b4, rec, deg3 + deg2 + deg1, deg4);
        }
    }
}
