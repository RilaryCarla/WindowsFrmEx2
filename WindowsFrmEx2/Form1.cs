using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFrmEx2
{
    public partial class Form1 : Form
    {
        double resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string produto = txtProduto.Text;
            double valor = double.Parse(txtValor.Text);
            int quantidade = int.Parse(txtQtde.Text);

            ListBox lista = lstProdutos;
            lista.Items.Add(produto + "/" + quantidade + "/" + valor);

            resultado += valor * quantidade;

            lblTotal.Text = resultado.ToString();

            txtProduto.Clear();
            txtValor.Clear();
            txtQtde.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtProduto.Clear();
            txtValor.Clear();
            txtQtde.Clear();
            lstProdutos.Items.Clear();
            lblTotal.Text = "0";
        }
    }
}
