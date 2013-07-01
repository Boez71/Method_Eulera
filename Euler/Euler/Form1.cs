using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Euler
{
    public partial class FormMy : Form
    {
        public FormMy()
        {
            InitializeComponent();
            zedGraph.GraphPane.Title.Text = "Метод Эйлера";
        }
    }
}
