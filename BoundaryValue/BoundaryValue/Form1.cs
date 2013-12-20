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

        GetterListOfValues one;
        GetterListOfValues two;

        BoundaryValue boundaryValue;
        Graphic graphicOne;
        Graphic graphicTwo;

        int numberOfSteps = 5;

        
        public Form1()
        {
            InitializeComponent();

            one = new MainEquation(ksi);
            two = new MainEquation(ksi);

            graphicOne = new Graphic(numberOfSteps);
            graphicTwo = new Graphic(numberOfSteps);
            boundaryValue = new BoundaryValue(0.0, 0.0, 1.0, 1.0);
        }

        void drawGraphics()
        {
            graph.Series["series1"].Points.Clear();
            graph.Series["series2"].Points.Clear();

            for (int i = 0; i <= graphicOne.numberOfIntervals; i++)
            {
                graph.Series["series1"].Points.AddXY(graphicOne.x[i], graphicOne.y[i]);
            }

            for (int i = 0; i <= graphicTwo.numberOfIntervals; i++)
            {
                graph.Series["series2"].Points.AddXY(graphicTwo.x[i], graphicTwo.y[i]);
            }
        }

        private void btnToDo_Click(object sender, EventArgs e)
        {
            graphicOne.getFrom(one, boundaryValue);
            graphicTwo.getFrom(two, boundaryValue);

            drawGraphics();
        }

        private void numericUpDownNumberOfSteps_ValueChanged(object sender, EventArgs e)
        {
            numberOfSteps = (int)numericUpDownNumberOfSteps.Value;
            graphicOne = new Graphic(numberOfSteps);
            graphicTwo = new Graphic(numberOfSteps);
        }

        private void radioButtonMain_CheckedChanged(object sender, EventArgs e)
        {
            one = new MainEquation(ksi);
            two = new MainEquation(ksi);
            graph.Series["series1"].LegendText = "Обычный шаг";
            graph.Series["series2"].LegendText = "Половинный шаг";
        }

        private void radioButtonTestOne_CheckedChanged(object sender, EventArgs e)
        {
            one = new TestOneEquation(ksi);
            two = new FunctionYStar(ksi);
            graph.Series["series1"].LegendText = "Аппроксимация";
            graph.Series["series2"].LegendText = "Реальная функция";
        }
    }
}