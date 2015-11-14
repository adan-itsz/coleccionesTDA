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
    public partial class linkedList : Form
    {
        public linkedList()
        {
            InitializeComponent();
        }
        LinkedList<object> lista = new LinkedList<object> ();
        object valor;
        int contador;

        private void btnAgregarInicio_Click(object sender, EventArgs e)
        {
            valor = txtBoxValor.Text;
            lista.AddFirst(valor);
            listBox1.Items.Insert(0, valor);
            txtBoxValor.Clear();
        }

        private void btnAgregarFinal_Click(object sender, EventArgs e)
        {
            valor = txtBoxValor.Text;
            lista.AddLast(valor);
            listBox1.Items.Insert(lista.Count - 1, valor);
            txtBoxValor.Clear();
        }

        private void btnAgregarAntes_Click(object sender, EventArgs e)
        {
            valor = txtBoxValor.Text;
            contador= listBox1.SelectedIndex;
            MessageBox.Show(Convert.ToString(valor));
           // lista.AddBefore(lista.ElementAt(contador), valor);
        }
    }
}
