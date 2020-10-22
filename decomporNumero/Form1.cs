using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace decomporNumero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (textBoxVazias())
            {
                MessageBox.Show("O campo não pode ser vazio");
                txtValor.Text = "0";
            }

            if (apenasNumeros(e))
            {
                MessageBox.Show("Campo Somente Número");
                txtValor.Text = "0";
            }

            lbFatores.Items.Clear();

            long numero = Convert.ToInt64(txtValor.Text);
            long contador = Calculo.GetFatoresPrimos(numero, out long[] arrResultado);
            for (int i = 0; i < contador; i++)
            {
                lbFatores.Items.Add(arrResultado[i]);
                if (i != contador - 1)
                    lbFatores.Items.Add("*");
                lbFatores.Items.Add(string.Format("{0} {1}", arrResultado[i], "*"));
            }
        }

        private void lbFatores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
         

        }

        private bool textBoxVazias()
        {
            foreach (Control c in this.Controls)
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                        return true;
                }
            return false;
        }

        private bool apenasNumeros(EventArgs e)
        {
            foreach (Control c in this.Controls)
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (Regex.IsMatch(textBox.Text, @"[^\d]"))
                        return true;
                }
            return false;
        }
    }
}
