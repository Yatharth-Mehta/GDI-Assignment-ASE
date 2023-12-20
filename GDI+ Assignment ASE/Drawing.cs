using GDI__Assignment_ASE;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI__Assignment_ASE.Properties
{
    //Pen pen = new Pen(Color.Red, 2);
    public class Drawing
     {
        private int xpos = 0;
        private int ypos = 0;
        public void draw(Graphics g ,String cmd,String fillvalue)
        { 
            
            Pen pen = new Pen(Color.Black);
            Brush brush = new SolidBrush(Color.Black);

            String command = cmd;
            command = command.ToLower();
            String[] split_command = command.Split(' ');

            List<string> commandlist = new List<string>();
            commandlist.Add("circle");
            commandlist.Add("rectangle");
            commandlist.Add("triangle");
            commandlist.Add("square");
            commandlist.Add("moveto");
            commandlist.Add("drawto");
            commandlist.Add("clear");
            commandlist.Add("reset");
            commandlist.Add("pen");
            commandlist.Add("fill");

            if (commandlist.Contains(split_command[0]))
            {
                if (split_command[0] == "fill")
                {
                    // Set the fill flag based on the provided value
                    /*if (split_command[1] == "on")
                    {
                        fillEnabled = true;
                    }
                    else
                    {
                        fillEnabled = false;
                    }*/
                }
                switch (split_command[0])
                    {
                        case "circle":
                            Circle c = new Circle(int.Parse(split_command[1]));
                        if (fillvalue == "on")
                        {
                            c.drawfill(g, brush, xpos, ypos);
                        }
                        else
                        {
                            c.draw(g, pen, xpos, ypos);
                        }
                        break;

                        case "rectangle":
                            rectangle rect = new rectangle(int.Parse(split_command[1]), int.Parse(split_command[2]));

                        if (fillvalue == "on")
                        {
                            rect.drawfill(g, brush, xpos, ypos);
                        }
                        else
                        {
                            rect.draw(g, pen, xpos, ypos);
                        }
                        break;

                        case "square":
                            rectangle sq = new rectangle(int.Parse(split_command[1]), int.Parse(split_command[2]));
                        if (fillvalue == "on")
                        {
                            sq.drawfill(g, brush, xpos, ypos);
                        }
                        else
                        {
                            sq.draw(g, pen, xpos, ypos);
                        }
                        break;

                        case "triangle":
                            triangle tr = new triangle(g, pen);
                        if (fillvalue == "on")
                        {
                            tr.drawfill(g, brush, xpos, ypos);
                        }
                        else
                        {
                            tr.draw(g, pen, xpos, ypos);
                        }
                        break;

                        case "clear":
                            clear cl = new clear();
                            cl.draw(g);
                            break;

                        case "drawto":
                            int X = int.Parse(split_command[1]);
                            int Y = int.Parse(split_command[2]);
                            g.DrawLine(pen, xpos, ypos, X, Y);
                            xpos = int.Parse(split_command[1]);
                            ypos = int.Parse(split_command[2]);

                            break;
                        default:
                            break;
                    }
                
            }
            else
            {
                errors er = new errors(g, pen);
            }

        }

    }
}


/*String command = final;
        public Drawing(Graphics g)
        {
            this.g = g;
            xPos = yPos = 0;
            Pen = new Pen(Color.Black, 1);
        }

        public void draw(int x ,int y)
        {
            if(command == "drawto")
            {
                g.DrawLine(Pen , xPos , yPos , x, y);
                xPos = x;
                yPos = y;
          */

/*if (split_command[0] == "circle")
                    {
                        Circle c = new Circle(int.Parse(split_command[1]));
                        c.draw(g, pen, xpos, ypos);
                    }
                    else if (split_command[0] == "drawto")
                    {
                        g.DrawLine(pen, xpos, ypos, int.Parse(split_command[1]), int.Parse(split_command[2]));
                        xpos = int.Parse(split_command[1]);
                        ypos = int.Parse(split_command[2]);
                    }*/


/*public void drawto(int toX, int toY)
{
    g.DrawLine(pen, xpos, ypos, toX, toY);
    xpos = toX;
    ypos = toY;
}
public void rectangle(int tX, int tY)
{
    g.DrawRectangle(pen, xpos, ypos, xpos + tX, ypos + tY);
}*/















/*

public void drawto(Graphics g) { }*/