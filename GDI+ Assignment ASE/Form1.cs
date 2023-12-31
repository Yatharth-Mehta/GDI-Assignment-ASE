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
using System.IO;

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
            graphics.Clear(Color.White);

            fill fv = new fill(graphics);
            fv.fillvalue = fillvalue.Text;
            Drawing d = new Drawing();

            if (singleline.Text.Equals("reset"))
            {
                reset r = new reset(singleline.Text, multiline.Text);
                singleline.Text = r.do_reset();
                multiline.Text = r.do_reset();
                fillvalue.Text = r.do_reset();
                graphics.Clear(Color.White);
            }
            else
            {
                if (multiline.Text != "")
                {
                    if (singleline.Text.Equals("run"))
                    {

                        multiline cpl = new multiline(multiline.Text, graphics,fv.fillvalue);
                        cpl.variables();
                        /*String multi = multiline.Text;
                        String[] split_command = multi.Split('\n');
                        foreach (String i in split_command)
                        {
                            d.draw(graphics, i, fv.fillvalue);
                        }*/
                    }
                    else
                    {
                        Font f = new Font("Arial", 14);
                        graphics.DrawString("Enter Run in command line", f, Brushes.Red, new Point(50, 50));
                    }
                }
                else
                {
                    d.draw(graphics, singleline.Text, fv.fillvalue);
                }
            }

            Refresh();
        }

        private void syntax_Click(object sender, EventArgs e)
        {

            drawingcanvas.Image = new Bitmap(drawingcanvas.Width, drawingcanvas.Height);

            var g = Graphics.FromImage(drawingcanvas.Image);
            g.Clear(Color.White);
            syntax_checking sc = new syntax_checking();

            if (multiline.Text != "")
            {
                if (singleline.Text.Equals("run"))
                {

                    String multi = multiline.Text;
                    String[] split_command = multi.Split('\n');
                    foreach (String i in split_command)
                    {
                        sc.check(i, g);
                    }
                }
            }
            else
            {
                sc.check(singleline.Text, g);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openfile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String file = openFileDialog1.FileName;
                //multiline.Text = file;
                var data = File.ReadAllText(file);
                multiline.Text = data;

            }
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter file = new StreamWriter(saveFileDialog1.FileName);
                file.Write(multiline.Text);
                //multiline.Text = file;
                file.Close();
            }
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