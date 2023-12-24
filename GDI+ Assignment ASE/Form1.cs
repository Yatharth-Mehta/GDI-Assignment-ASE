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

            fill fv = new fill();
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

                        String multi = multiline.Text;
                        String[] split_command = multi.Split('\n');
                        foreach (String i in split_command)
                        {
                            d.draw(graphics, i, fv.fillvalue);
                        }
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

            String cmdline = singleline.Text;
            cmdline = cmdline.ToLower();
            String[] split_command = cmdline.Split(' ');

            List<string> commandlist = new List<string>();
            commandlist.Add("circle");
            commandlist.Add("rectangle");
            commandlist.Add("triangle");
            commandlist.Add("square");
            commandlist.Add("moveto");
            commandlist.Add("drawto");
            commandlist.Add("clear");
            commandlist.Add("reset");

            try
            {
                if (commandlist.Contains(split_command[0]))
                {
                    if (cmdline == "")
                    {
                        throw new cmdline_empty_exception(g);
                    }

                    if (split_command[0] == "circle")
                    {
                        int total_ele = split_command.Count(); 
                        if (total_ele == 2 && int.TryParse(split_command[1],out _))
                        {
                            Font f = new Font("Arial", 14);
                            g.DrawString("The Syntax is correct", f, Brushes.Red, new Point(50, 50));
                        }
                        else
                        {
                            throw new circle_exception(g);
                        }
                    }


                    if (split_command[0] == "rectangle" || split_command[0] == "sqaure")
                    {
                        int total_ele = split_command.Count();
                        if (total_ele == 3 && int.TryParse(split_command[1], out _) && int.TryParse(split_command[2], out _))
                        {
                            Font f = new Font("Arial", 14);
                            g.DrawString("The Syntax is correct", f, Brushes.Red, new Point(50, 50));
                        }
                        else
                        {
                            throw new rectangle_sqaure_exception(g);
                        }
                    }

                    
                    if (split_command[0]  == "triangle")
                    {
                        int total_ele = split_command.Count();
                        if (total_ele == 1)
                        {
                            Font f = new Font("Arial", 14);
                            g.DrawString("The Syntax is correct", f, Brushes.Red, new Point(50, 50));
                        }
                        else
                        {
                            throw new triangle_exception(g);
                        }
                    }


                    if (split_command[0] == "clear")
                    {
                        int total_ele = split_command.Count();
                        if (total_ele == 1)
                        {
                            Font f = new Font("Arial", 14);
                            g.DrawString("The Syntax is correct", f, Brushes.Red, new Point(50, 50));
                        }
                        else
                        {
                            throw new clear_exception(g);
                        }
                    }


                    if (split_command[0] == "reset")
                    {
                        int total_ele = split_command.Count();
                        if (total_ele == 1)
                        {
                            Font f = new Font("Arial", 14);
                            g.DrawString("The Syntax is correct", f, Brushes.Red, new Point(50, 50));
                        }
                        else
                        {
                            throw new reset_exception(g);
                        }
                    }
                }
                else
                {
                    throw new Not_a_valid_command_exception(g);
                }
            }
            catch
            {

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