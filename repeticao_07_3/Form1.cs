using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace repeticao_07_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            int n, cont;
            long prod = 1;
            n = int.Parse(txt_num.Text);

            ltx_imprimir.Items.Clear();
            ltx_imprimir.Items.Add(n + "! =");

            for (cont = n; cont >= 1; cont--)
            {
                ltx_imprimir.Items.Add(n + "*");
                prod *= n;
                n--;
            }

            ltx_imprimir.Items.Add("= " + prod);

        }
    }
}
