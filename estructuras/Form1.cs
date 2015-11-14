using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estructuras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            linkedList l = new linkedList();
            l.ShowDialog();
        }

        private void btnPila_Click(object sender, EventArgs e)
        {
            stack s = new stack();
            s.ShowDialog();
        }

        private void btnCola_Click(object sender, EventArgs e)
        {
            queue q = new queue();
            q.ShowDialog();
        }
    }
}
