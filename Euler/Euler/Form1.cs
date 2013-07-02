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
using Microsoft.Office.Interop.Word;


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
        // Сохранение в текстовый файл
        private void TextSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Текстовые файлы (*.txt)|*.txt";
            if (sfd.ShowDialog() != DialogResult.Cancel)
            {
                string fileName = sfd.FileName;
                //Записываем в файл данные построчно
                if (fileName != null && fileName != "")
                {

                    StreamWriter writer = new StreamWriter(fileName);
                    try
                    {
                        for (int i = 0; i < countDots; i++)
                        {
                            writer.WriteLine("X: " + X[i].ToString() + " , Y: " + Y[i].ToString());
                        }
                        writer.Flush();
                        MessageBox.Show("Сохранение в текстовый файл завершено");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        writer.Close();
                    }
                }
            }
        }
        // Сохранение в файл Word
        private void WordSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // вывод отчета в ворд
                Microsoft.Office.Interop.Word.Application msWord;

                Microsoft.Office.Interop.Word.Document doc;

                object objMiss;

                object endofdoc = "\\endofdoc";

                msWord = new Microsoft.Office.Interop.Word.Application();
                objMiss = System.Reflection.Missing.Value;
                msWord.Visible = true;

                doc = msWord.Documents.Add(ref objMiss, ref objMiss, ref objMiss, ref objMiss);

                Microsoft.Office.Interop.Word.Table tbl1;

                Microsoft.Office.Interop.Word.Range wordRange = doc.Bookmarks.get_Item(ref endofdoc).Range;

                int rowsNum = countDots + 1;

                tbl1 = doc.Content.Tables.Add(wordRange, rowsNum, 2, ref objMiss, ref objMiss);

                tbl1.Borders.Enable = 1;

                tbl1.Cell(1, 1).Range.Text = "Координата Х";
                tbl1.Cell(1, 2).Range.Text = "Координата Y";

                // добавляем в таблицу данные
                for (int i = 2; i <= rowsNum; i++)
                {

                    // добавляем текст
                    tbl1.Cell(i, 1).Range.Text = X[i - 2].ToString();
                    tbl1.Cell(i, 2).Range.Text = Y[i - 2].ToString();
                }
            }
            catch (Exception)
            { }
        }
    }
}
