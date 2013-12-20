using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BoundaryValue
{
    public partial class Form1 : Form
    {
        double ksi = 0.525;

        Equation equation;
        BoundaryValue boundaryValue;
        Graphic graphicOne;
        Graphic graphicTwo;

        int numberOfSteps = 5;

        
        public Form1()
        {
            InitializeComponent();

            equation = new Equation(ksi);

            graphicOne = new Graphic(numberOfSteps);
            graphicTwo = new Graphic(numberOfSteps/2);
            boundaryValue = new BoundaryValue(0.0, 0.0, 1.0, 1.0);
        }

        void drawGraphics()
        {
            graph.Series["series1"].Points.Clear();
            graph.Series["series2"].Points.Clear();

            for (int i = 0; i < graphicOne.numberOfIntervals; i++)
            {
                graph.Series["series1"].Points.AddXY(graphicOne.x[i], graphicOne.y[i]);
            }

            for (int i = 0; i < graphicTwo.numberOfIntervals; i++)
            {
                graph.Series["series2"].Points.AddXY(graphicTwo.x[i], graphicTwo.y[i]);
            }
        }

        private void btnToDo_Click(object sender, EventArgs e)
        {
            graphicOne.getFrom(equation, boundaryValue);
            graphicTwo.getFrom(equation, boundaryValue);

            drawGraphics();
        }

        private void numericUpDownNumberOfSteps_ValueChanged(object sender, EventArgs e)
        {
            numberOfSteps = (int)numericUpDownNumberOfSteps.Value;
            graphicOne = new Graphic(numberOfSteps);
            graphicTwo = new Graphic(numberOfSteps/2);
        }
    }
}