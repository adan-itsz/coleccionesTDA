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
    public partial class stack : Form
    {
        Stack<object> pila= new Stack<object>();
        ArrayList lista = new ArrayList();
        object valor;
      
        public stack()
        {
            InitializeComponent();
        }

        
        private void btnPush_Click(object sender, EventArgs e)
        {
            valor = txtBoxValor.Text;
            pila.Push(valor);
            listBox1.Items.Insert(0, pila.Peek());
            txtBoxValor.Clear();
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(pila.Pop()); 
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            if (pila.Count != 0)
            {
                MessageBox.Show(Convert.ToString(pila.Peek()));
            }
            else
            {
                MessageBox.Show("la pila esta vacia");
            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            if (pila.Count != 0)
            {
                MessageBox.Show(Convert.ToString(pila.Count));
            }
            else
            {
                MessageBox.Show("la pila esta vacia");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            pila.Clear();
            listBox1.Items.Clear();
        }

    }
}
