using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace estructuras
{
    public partial class queue : Form
    {
        public queue()
        {
            InitializeComponent();
        }
        Queue<object> cola = new Queue<object>();
        object valor;

        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            valor = txtBoxValor.Text;
            cola.Enqueue(valor);
            listBox1.Items.Add(valor);
            txtBoxValor.Clear();
        }

        private void btnDequeue_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(cola.Dequeue());
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            if (cola.Count != 0)
            {
                MessageBox.Show(Convert.ToString(cola.Peek()));
            }
            else
                MessageBox.Show("cola vacia");
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(cola.Count));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cola.Clear();
            listBox1.Items.Clear();
        }
    }
}
