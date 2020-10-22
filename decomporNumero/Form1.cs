using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            lbFatores.Items.Clear();
            int numero = Convert.ToInt32(txtValor.Text);
            int contador = Calculo.GetFatoresPrimos(numero, out int[] arrResultado);
            for (int i = 0; i < contador; i++)
            {
                lbFatores.Items.Add(arrResultado[i]);
                if (i != contador - 1)
                    lbFatores.Items.Add("*");
                lbFatores.Items.Add(string.Format("{0} {1}", arrResultado[i], "*"));
            }
        }
    }
}
