using GDI__Assignment_ASE.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI__Assignment_ASE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (drawingcanvas.Image == null)
            {
                drawingcanvas.Image = new Bitmap(drawingcanvas.Width, drawingcanvas.Height);
            }
            var graphics = Graphics.FromImage(drawingcanvas.Image);

            fill fv = new fill();
            fv.fillvalue = fillvalue.Text;

            Drawing d = new Drawing();
            d.draw(graphics, singleline.Text, fv.fillvalue);

            Refresh();
        }

        private void syntax_Click(object sender, EventArgs e)
        {
            String cmdline = singleline.Text;

            drawingcanvas.Image = new Bitmap(drawingcanvas.Width, drawingcanvas.Height);

            var g = Graphics.FromImage(drawingcanvas.Image);
            cmdline = cmdline.ToLower().Trim();
            //String[] split_command = cmdline.Split(' ');
            try
            {
                if (cmdline == "")
                {
                    throw new cmdline_empty_exception(g);
                }
                if (cmdline == "circle")
                {
                    Font f = new Font("Arial", 14);
                    g.DrawString("Give Radius to circle !", f, Brushes.Red, new Point(50, 50));
                }
                if (cmdline == "square")
                {
                    Font f = new Font("Arial", 14);
                    g.DrawString("Give Height and Width to Square !", f, Brushes.Red, new Point(50, 50));
                }
                if (cmdline == "rectangle")
                {
                    Font f = new Font("Arial", 14);
                    g.DrawString("Give Height and Width to Rectangle !", f, Brushes.Red, new Point(50, 50));
                }
            }
            catch { }
           
        }
    }
}


            /* String command = singleline.Text.ToLower();
           // graphics.Clear(Color.White);


                 if (command == "drawto")
                 {
                     d.drawto(150 , 40);
                 }
                 else if (command == "rectangle")
                 {
                     d.rectangle(80 ,80);
                 }*/