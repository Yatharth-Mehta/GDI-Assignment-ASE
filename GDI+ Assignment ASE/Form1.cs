﻿using GDI__Assignment_ASE.Properties;
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
            String[] split_command = cmdline.Split(' ');
            try
            {
                if (cmdline == "")
                {
                    throw new cmdline_empty_exception(g);
                }
                else if (cmdline == "circle")
                {
                    throw new circle_exception(g);
                }
                else if (cmdline == "square")
                {
                    throw new rectangle_sqaure_exception(g);
                }
                else if (cmdline == "rectangle")
                {
                    throw new rectangle_sqaure_exception(g);
                }
                else if (split_command[0]=="circle" && split_command[2] != null)
                {
                    throw new circle_exception(g);
                }
                else if (split_command[0] == "square" && split_command[3] != null)
                {
                    throw new rectangle_sqaure_exception(g);
                }
                else if (split_command[0] == "rectangle" && split_command[3] != null)
                {
                    throw new rectangle_sqaure_exception(g);
                }
                else if (split_command[0] == "triangle" && split_command[1] !=null)
                {
                    throw new triangle_exception(g);
                }
                else
                {
                    Font f = new Font("Arial", 14);
                    g.DrawString("The Syntax is correct", f, Brushes.Red, new Point(50, 50));
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