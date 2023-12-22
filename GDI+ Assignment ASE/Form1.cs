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
            graphics.Clear(Color.White);

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
            g.Clear(Color.White);
            cmdline = cmdline.ToLower().Trim();
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
                        String extra = split_command[2];
                        if (cmdline != "circle")
                        {
                                Font f = new Font("Arial", 14);
                                g.DrawString("The Syntax is correct", f, Brushes.Red, new Point(5, 50));
                        }
                        else
                        {
                            throw new circle_exception(g);
                        }

                        
                    }
                    

                    if (split_command[0] == "square" && split_command[3] != null)
                    {
                        throw new rectangle_sqaure_exception(g);
                    }
                    else
                    {
                        Font f = new Font("Arial", 14);
                        g.DrawString("The Syntax is correct", f, Brushes.Red, new Point(50, 50));
                    }

                    if (split_command[0] == "rectangle" && split_command[3] != null)
                    {
                        throw new rectangle_sqaure_exception(g);
                    }
                    else
                    {
                        Font f = new Font("Arial", 14);
                        g.DrawString("The Syntax is correct", f, Brushes.Red, new Point(50, 50));
                    }

                    if (split_command[0] == "triangle" && split_command[1] != null)
                    {
                        throw new triangle_exception(g);
                    }
                    else
                    {
                        Font f = new Font("Arial", 14);
                        g.DrawString("The Syntax is correct", f, Brushes.Red, new Point(50, 50));
                    }


                    if (split_command[0] == "clear" && split_command[1] != null)
                    {
                        throw new Not_a_valid_command_exception(g);
                    }
                    else
                    {
                        Font f = new Font("Arial", 14);
                        g.DrawString("The Syntax is correct", f, Brushes.Red, new Point(50, 50));
                    }

                    if (split_command[0] == "reset" && split_command[1] != null)
                    {
                        throw new Not_a_valid_command_exception(g);
                    }
                    else
                    {
                        Font f = new Font("Arial", 14);
                        g.DrawString("The Syntax is correct", f, Brushes.Red, new Point(50, 50));
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