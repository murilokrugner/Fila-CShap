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

namespace FILA___MURILO_AUGUSTO_KRUGNER_ALMEIDA_LEITE
{
    public partial class FrmPrincipal : Form
    {
        public Queue queue = new Queue();
        Array pointer;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show("Por favor, digite um valor para adicionar a fila");
                return;
            }

            queue.Enqueue(textBox.Text);

            pointer = queue.ToArray();

            listView1.Items.Clear();

            foreach (string i in pointer)
            {
                listView1.Items.Add(i.ToString());

            }

            textBox.Clear();

            textBox.Focus();
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            queue.Dequeue();

            pointer = queue.ToArray();

            listView1.Items.Clear();

            foreach (string i in pointer)
            {
                listView1.Items.Add(i.ToString());

            }

            textBox.Clear();

            textBox.Focus();
        }

        private void btnQnt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("QUANTIDADE DE ITENS NA FILA: " + queue.Count.ToString());

            textBox.Clear();

            textBox.Focus();
        }
    }
}
