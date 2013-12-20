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
        double ksi;

        Equation equation;
        BoundaryValue boundaryValue;
        Graphic graphic;

        int numberOfSteps = 5;

        
        public Form1()
        {
            InitializeComponent();

            ksi = 0.525;
            equation = new Equation(ksi);

            graphic = new Graphic(numberOfSteps);
            boundaryValue = new BoundaryValue(0.0, 0.0, 1.0, 1.0);
        }

        void drawGraphic()
        {
            graph.Series["series"].Points.Clear();

            for (int i = 0; i < numberOfSteps + 1; i++)
            {
                graph.Series["series"].Points.AddXY(graphic.x[i], graphic.y[i]);
            }
        }

        private void btnToDo_Click(object sender, EventArgs e)
        {
            graphic.getFrom(equation, boundaryValue);

            drawGraphic();
        }
    }
}
