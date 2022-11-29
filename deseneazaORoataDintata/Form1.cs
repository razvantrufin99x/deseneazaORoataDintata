using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace deseneazaORoataDintata
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics g;
        Pen pen0 = new Pen(Color.Black, 1);
        static float k1 = 360 / 30;
        static float k2 = 360 / 60;
        float rad = (float)(180 / 3.14);
        float stepf1 = k1;
        float stepf2 = k2;

        private void Form1_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //stie cineva cum se deseneaza o roata dintata ???
            g.DrawEllipse(pen0, 100, 100, 200, 200);
            g.DrawEllipse(pen0, 50, 50, 300, 300);
            int m = 0;
            for (float i = 0.0f; i <= 360.0f; i += stepf1)
            {
                m++;
                g.DrawLine(pen0, (float)(Math.Cos(i / rad) * 150 + 200), (float)(Math.Sin(i / rad) * 150 + 200), (float)(Math.Cos(i / rad) * 100 + 200), (float)(Math.Sin(i / rad) * 100 + 200));
               g.DrawLine(pen0, (float)(Math.Cos((i + stepf1) / rad) * 150 + 200), (float)(Math.Sin((i + stepf1) / rad) * 150 + 200), (float)(Math.Cos((i - stepf1) / rad) * 100 + 200), (float)(Math.Sin((i - stepf1) / rad) * 100 + 200));
                
                    g.DrawLine(pen0, (float)(Math.Cos((i + stepf2) / rad) * 170 + 200), (float)(Math.Sin((i + stepf2) / rad) * 170 + 200), (float)(Math.Cos((i + stepf2) / rad) * 100 + 200), (float)(Math.Sin((i + stepf2) / rad) * 100 + 200));
                
               if (m % 2 == 0)
               {
                   g.DrawLine(pen0, (float)(Math.Cos((i + stepf2) / rad) * 170 + 200), (float)(Math.Sin((i + stepf2) / rad) * 170 + 200), (float)(Math.Cos((i + stepf2 + stepf2 + stepf2) / rad) * 170 + 200), (float)(Math.Sin((i + stepf2 + stepf2 + stepf2) / rad) * 170 + 200));
               }

            }
        }
    }
}
