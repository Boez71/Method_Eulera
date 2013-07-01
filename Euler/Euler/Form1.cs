using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZedGraph;

namespace Euler
{
    public partial class FormMy : Form
    {
        public static double a, b, x0, y0, h; // параметры вычисления
        public static int countDots = 0; // кол-во точек
        public static Massive X;
        public static Massive Y;
        public static int precision; //точность

        public FormMy()
        {
            InitializeComponent();
            zedGraph.GraphPane.Title.Text = "Метод Эйлера";
        }

        public double f(double x, double y)
        {
            return y / x;
        }

        // чтение параметров
        public void readVariables()
        {
            a = Convert.ToDouble(textBox_a.Text);
            b = Convert.ToDouble(textBox_b.Text);
            x0 = Convert.ToDouble(textBox_x0.Text);
            y0 = Convert.ToDouble(textBox_y0.Text);
            h = Convert.ToDouble(textBox_h.Text);
            precision = Convert.ToInt32(textBox1.Text);
            checkVariables();
        }

        // валидация параметров
        private void checkVariables()
        {
            if (b < a)
            {
                throw new Exception("a не может быть больше b! Указан неверный диапазон");
            }
            if (b <= x0)
            {
                throw new Exception("x0 не может быть больше или равно b. Указан неверный диапазон");
            }

        }

        private void button_solve_Click(object sender, EventArgs e)
        {
            try
            {
                // Считывание и валидация параметров
                readVariables();
                // сколько всего точек
                countDots = Convert.ToInt32(((b - a) / h));
                // создаем массивы переменных
                X = new Massive(countDots, precision);
                Y = new Massive(countDots, precision);

                X[0] = a;

                for (int i = 0; i < countDots - 1; ++i)
                {
                    X[i + 1] = X[i] + h;
                    if (X[i] == b) break;
                }

                Y[0] = y0;


                for (int i = 1; i < countDots; ++i)
                {
                    Y[i] = Y[i - 1] + (X[i] - X[i - 1]) * f(X[i - 1], Y[i - 1]);
                }


                GraphPane pane = zedGraph.GraphPane;
                pane.CurveList.Clear();
                PointPairList list = new PointPairList();
                for (int j = 0; j < countDots; ++j)
                {
                    list.Add(X[j], Y[j]);
                }
                LineItem myCurve = pane.AddCurve("y' = y / x", list, Color.Red, SymbolType.None);
                zedGraph.AxisChange();
                zedGraph.Invalidate();
                pane.Title.Text = "Метод Эйлера";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
