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
 //           graphics.Clear(Color.White);

            Drawing d = new Drawing(graphics);

            d.draw(singleline.Text);

           /* String command = singleline.Text.ToLower();


                if (command == "drawto")
                {
                    d.drawto(150 , 40);
                }
                else if (command == "rectangle")
                {
                    d.rectangle(80 ,80);
                }*/

            
        Refresh();
        }
    }
}
