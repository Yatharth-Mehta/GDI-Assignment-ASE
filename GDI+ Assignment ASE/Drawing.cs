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

        Graphics g;
        Pen pen;
        private int xpos , ypos ;

        public Drawing(Graphics g)
        {
            this.g = g;
            xpos = ypos = 0;
            pen = new Pen(Color.Black);
        }


        public void draw(String cmd)
        { 
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
                switch (split_command[0])
                {
                    case "circle":
                        Circle c = new Circle(int.Parse(split_command[1]));
                        c.draw(g, pen, xpos, ypos);
                        break;

                    case "rectangle":
                        rectangle rect = new rectangle(int.Parse(split_command[1]), int.Parse(split_command[2]));
                        rect.draw(g, pen, xpos, ypos);
                        break;

                    case "square":
                        rectangle sq = new rectangle(int.Parse(split_command[1]), int.Parse(split_command[2]));
                        sq.draw(g, pen, xpos, ypos);
                        break;

                    case "triangle":
                        triangle tr = new triangle(g, pen);
                        break;

                    case "clear":
                        clear cl = new clear();
                        cl.draw(g);
                        break;

                    case "drawto":
                       drawto dt = new drawto(g,pen,xpos,ypos, int.Parse(split_command[1]), int.Parse(split_command[2]));
                        xpos = dt.updateX(int.Parse(split_command[1]));
                        ypos = dt.updateY(int.Parse(split_command[2]));
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