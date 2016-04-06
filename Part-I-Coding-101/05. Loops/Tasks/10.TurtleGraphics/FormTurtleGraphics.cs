namespace TurtleGraphics
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Nakov.TurtleGraphics;

    public partial class FormTurtleGraphics : Form
    {
        public FormTurtleGraphics()
        {
            this.InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            // Assign a delay to visualize the drawing process
            Turtle.Delay = 100;

            // Draw a equilateral triangle
            Turtle.Rotate(30);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);

            // Draw a line in the triangle
            Turtle.Rotate(-30);
            Turtle.PenUp();
            Turtle.Backward(50);
            Turtle.PenDown();
            Turtle.Backward(100);
            Turtle.PenUp();
            Turtle.Forward(150);
            Turtle.PenDown();
            Turtle.Rotate(30);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Turtle.Reset();
        }

        private void btnHideTurtle_Click(object sender, EventArgs e)
        {
            if (Turtle.ShowTurtle)
            {
                Turtle.ShowTurtle = false;
                this.btnHideTurtle.Text = "Show Turtle";
            }
            else
            {
                Turtle.ShowTurtle = true;
                this.btnHideTurtle.Text = "Hide Turtle";
            }
        }

        private void btnHexagon_Click(object sender, EventArgs e)
        {
            // Assign a delay to visualize the drawing process
            Turtle.Delay = 100;

            // Hexagon -> rotate 360/6 degrees
            for (int i = 0; i < 6; i++)
            {
                Turtle.Forward(100);
                Turtle.Rotate(60);
            }
        }

        private void btnStar_Click(object sender, EventArgs e)
        {
            // Assign a delay to visualize the drawing process
            Turtle.Delay = 100;

            Turtle.PenColor = Color.Red;

            Turtle.Rotate(18);

            /* 
             * Regular star polygons
             * 
             * https://en.wikipedia.org/wiki/Regular_polygon#Regular_star_polygons
             * 
             * p -> number of Edges
             * q -> Density (If q is 2, for example, then every second edge is joined)
             * 
             * Internal angle (degrees) = (180*(p - 2*q))/p
             * 
             * Example: Star pentagon
             *   
             * Internal angle (degrees) = (180*(5 - 2*2))/5 = 36 degrees
             * and we have to rotate turtle on 180 - 36 = 144 degrees
             */
            for (int i = 0; i < 5; i++)
            {
                Turtle.Forward(150);
                Turtle.Rotate(144);
            }
        }

        private void btnSpiral_Click(object sender, EventArgs e)
        {
            // Assign a delay to visualize the drawing process
            Turtle.Delay = 100;

            Turtle.PenColor = Color.Blue;

            for (int i = 0; i < 20; i++)
            {
                Turtle.Forward(10 + (i * 7));
                Turtle.Rotate(60);
            }
        }

        private void btnSun_Click(object sender, EventArgs e)
        {
            // Assign a delay to visualize the drawing process
            Turtle.Delay = 50;

            Turtle.PenColor = Color.Yellow;
            Turtle.PenSize = 3;

            /* 
             * Regular star polygons
             * 
             * https://en.wikipedia.org/wiki/Regular_polygon#Regular_star_polygons
             * 
             * p -> number of Edges
             * q -> Density
             * 
             * Internal angle (degrees) = (180*(p - 2*q))/p
             * 
             * Example: 36 edges polygon
             *   
             * Internal angle (degrees) = (180*(36 - 2*17))/36 = 10 degrees
             * and we have to rotate turtle on 180 - 10 = 170 degrees
             */
            for (int i = 0; i < 36; i++)
            {
                Turtle.Forward(200);
                Turtle.Rotate(170);
            }
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            // Assign a delay to visualize the drawing process
            Turtle.Delay = 50;

            Turtle.PenColor = Color.Red;
            Turtle.PenSize = 5;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 21; j++)
                {
                    Turtle.Rotate(120);
                    Turtle.Forward(10 + (j * 10));
                }

                Turtle.Rotate(-240);
            }
        }
    }
}
