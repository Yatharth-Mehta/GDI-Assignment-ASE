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
using System.IO;

namespace GDI__Assignment_ASE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This class will activate when the Run button will be clicked.
        /// If the user would have entered reset in the command line then it would call a Reset function
        /// and the whole form will be cleared and reset.
        /// If not then it will do the functions written in the command line and multiline.
        /// If commands are written in multiline then run should be written in the command line in order to
        /// multiline commands be executed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submit_Click(object sender, EventArgs e)
        {
            if (drawingcanvas.Image == null)
            {
                drawingcanvas.Image = new Bitmap(drawingcanvas.Width, drawingcanvas.Height);
            }
            var graphics = Graphics.FromImage(drawingcanvas.Image);
            graphics.Clear(Color.White);

            fill fv = new fill(graphics);
            if (fill_on.Checked)
            {

                fv.fillvalue = "on";
            }
            else
            {
                fv.fillvalue = "off";
            }
            Drawing d = new Drawing();

            if (singleline.Text.Equals("reset"))
            {
                reset r = new reset(singleline.Text, multiline.Text);
                singleline.Text = r.do_reset();
                multiline.Text = r.do_reset();
                fill_on.Checked = false;
                fill_off.Checked = false;
                graphics.Clear(Color.White);
            }
            else
            {
                if (multiline.Text != "")
                {
                    if (singleline.Text.Equals("run"))
                    {

                        multiline cpl = new multiline(multiline.Text, graphics,fv.fillvalue);
                        cpl.multiline_main();
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
        /// <summary>
        /// This method will be activated when the user clicks on syntax button
        /// It will take all the lines from commandline or multiline and
        /// will pass it to syntax_checking.cs to check whether the 
        /// syntax of that command is correct or not.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    int y = 0;
                    foreach (String i in split_command)
                    {
                           sc.check(i, g,y);
                           y += 20;
                       
                    }
                }
            }
            else
            {
                sc.check(singleline.Text, g,0);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This method is activatedd when open file button is clicked.
        /// It will open a file explorer to open a text file and load it
        /// in the mulitine text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openfile_Click(object sender, EventArgs e)
        {
            open_button op = new open_button();
            op.open(sender);
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String file = openFileDialog1.FileName;
                var data = File.ReadAllText(file);
                multiline.Text = data;

            }
        }

        /// <summary>
        /// This method is activatedd when save button is clicked.
        /// It will open a file explorer to save a text file with all the text in multiline textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void savebutton_Click(object sender, EventArgs e)
        {
            save_button sb = new save_button(sender);
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter file = new StreamWriter(saveFileDialog1.FileName);
                file.Write(multiline.Text);
                file.Close();
            }
        }

        /// <summary>
        /// This method is activatedd when reset button is clicked.
        /// It reset the entire form and all it's parametres.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reset_Click(object sender, EventArgs e)
        {
            drawingcanvas.Image = new Bitmap(drawingcanvas.Width, drawingcanvas.Height);
            reset r = new reset(singleline.Text, multiline.Text);
            singleline.Text = r.do_reset();
            multiline.Text = r.do_reset();
            fill_on.Checked = false;
            fill_off.Checked = false; 
            var graphics = Graphics.FromImage(drawingcanvas.Image);
            graphics.Clear(Color.White);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void fill_off_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}