using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwCalc = Calculadora.Util;

namespace Calculadora.WinForms
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int numero1, numero2 = 0;
                if (!int.TryParse(txtPrimeiroNumero.Text, out numero1))
                {
                    MessageBox.Show("O primeiro número é inválido");
                }
                if (!int.TryParse(txtSegundoNumero.Text, out numero2))
                {
                    MessageBox.Show("O primeiro número é inválido");
                }
                TwCalc.Calculadora calc = new TwCalc.Calculadora();
                switch (cmbOperacao.SelectedIndex)
                {
                    case 0:
                        txtResultado.Text = calc.Somar(numero1, numero2).ToString();
                        break;
                    case 1:
                        txtResultado.Text = calc.Subtrair(numero1, numero2).ToString();
                        break;
                    case 2:
                        txtResultado.Text = calc.Multiplicar(numero1, numero2).ToString();
                        break;
                    case 3:
                        txtResultado.Text = calc.Dividir(numero1, numero2).ToString();
                        break;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
