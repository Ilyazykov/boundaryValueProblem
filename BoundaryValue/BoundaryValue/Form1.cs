using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BoundaryValue.Functions;

namespace BoundaryValue
{
    public partial class Form1 : Form
    {
        double begin = 0;
        double end = 0;

        double[] x;
        double[] y;
        double[] a;
        double[] d;
        double[] fi;

        double[] alpha;
        double[] beta;

        double ksi;
        FunctionK k;
        FunctionQ q;
        FunctionF f;

        double nu1 = 0.0;
        double nu2 = 1.0;

        int numberOfSteps = 5;

        public Form1()
        {
            InitializeComponent();

            ksi = 0.525;
            k = new FunctionK(ksi);
            q = new FunctionQ(ksi);
            f = new FunctionF(ksi);
        }

        private void btnToDo_Click(object sender, EventArgs e)
        {
            x = new double[numberOfSteps + 1];
            y = new double[numberOfSteps + 1];
            a = new double[numberOfSteps + 1];
            d = new double[numberOfSteps + 1];
            fi = new double[numberOfSteps + 1];
            alpha = new double[numberOfSteps + 1];
            beta = new double[numberOfSteps + 1];
            

            double step = (begin - end) / numberOfSteps;
            for (int i = 0; i <= numberOfSteps; i++)
            {
                x[i] = begin + i * step;
            }

            for (int i = 1; i < numberOfSteps; i++)
            {
           
                d[i] = ( q.integrateFuncton(x[i] + step / 2, x[i] - step / 2) ) / step;
                fi[i] = (f.integrateFuncton(x[i] + step / 2, x[i] - step / 2) ) / step;
                a[i] = step / ( k.integrateDevidedOneIntoFunction(x[i - 1], x[i]) );
            }
            a[numberOfSteps] = step / (k.integrateDevidedOneIntoFunction(x[numberOfSteps - 1], x[numberOfSteps]));

            y[0] = nu1;
            y[numberOfSteps] = nu2;

            for (int i = 2; i <= numberOfSteps; i++)
            {
                alpha[i] = (-a[i]) / (-a[i] - a[i - 1] - d[i - 1] * step * step + alpha[i - 1] * a[i - 1]);
                beta[i] = (-fi[i - 1] * step * step - a[i - 1] * beta[i - 1]) / (-a[i] - a[i - 1] - d[i - 1] * step * step + alpha[i - 1] * a[i - 1]);
            }

            for (int i = numberOfSteps - 1; i > 0; i--)
            {
                y[i] = alpha[i + 1] * y[i + 1] + beta[i + 1];
            }
        }
    }
}
