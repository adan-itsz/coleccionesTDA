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
            try
            {
                valor = txtBoxValor.Text;
                contador = listBox1.SelectedIndex;
                LinkedListNode<object> nodo = lista.Find(lista.ElementAt(contador));
                lista.AddBefore(nodo, valor);
                listBox1.Items.Insert(contador - 1, valor);
            }
            catch (Exception)
            {

            }
        }

        private void btnEliminarPrimero_Click(object sender, EventArgs e)
        {
            lista.RemoveFirst();
            listBox1.Items.RemoveAt(0);
        }

        private void btnEliminarUltimo_Click(object sender, EventArgs e)
        {
            lista.RemoveLast();
            listBox1.Items.RemoveAt(lista.Count - 1);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                contador = listBox1.SelectedIndex;
                lista.Remove(contador);
                listBox1.Items.RemoveAt(contador);
            }
            catch (Exception)
            {

            }
        }

        private void btnAgregarDespues_Click(object sender, EventArgs e)
        {
            try
            {
                valor = txtBoxValor.Text;
                contador = listBox1.SelectedIndex;
                LinkedListNode<object> nodo = lista.Find(lista.ElementAt(contador));
                lista.AddAfter(nodo, valor);
                listBox1.Items.Insert(contador + 1, valor);
            }
            catch (Exception)
            {

            }
        }
    }
}
