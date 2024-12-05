using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private StringBuilder Texto = new StringBuilder();
        private void Btn1_Click(object sender, EventArgs e)
        {
            Texto.Append("1");
            TxtCuenta.Text = Texto.ToString();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Texto.Append("2");
            TxtCuenta.Text = Texto.ToString();
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            Texto.Append("3");
            TxtCuenta.Text = Texto.ToString();
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            Texto.Append("4");
            TxtCuenta.Text = Texto.ToString();
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            Texto.Append("5");
            TxtCuenta.Text = Texto.ToString();
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            Texto.Append("6");
            TxtCuenta.Text = Texto.ToString();
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            Texto.Append("7");
            TxtCuenta.Text = Texto.ToString();
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            Texto.Append("8");
            TxtCuenta.Text = Texto.ToString();
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            Texto.Append("9");
            TxtCuenta.Text = Texto.ToString();
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            Texto.Append("0");
            TxtCuenta.Text = Texto.ToString();
        }

        private void BtnDividir_Click(object sender, EventArgs e)
        {
            Texto.Append("/");
            TxtCuenta.Text = Texto.ToString();
        }

        private void BtnMultiplicar_Click(object sender, EventArgs e)
        {
            Texto.Append("x");
            TxtCuenta.Text = Texto.ToString();
        }

        private void BtnMenos_Click(object sender, EventArgs e)
        {
            Texto.Append("-");
            TxtCuenta.Text = Texto.ToString();
        }

        private void BtnMas_Click(object sender, EventArgs e)
        {
            Texto.Append("+");
            TxtCuenta.Text = Texto.ToString();
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            // hacer la cuenta
        }

        private void TxtCuenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }

        private void BtnApagar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnPunto_Click(object sender, EventArgs e)
        {
            Texto.Append(",");
            TxtCuenta.Text = Texto.ToString();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void BtnOff_MouseHover(object sender, EventArgs e)
        {
            BtnOff.Image = Calculadora.Properties.Resources.off1;
        }

        private void BtnOff_MouseLeave(object sender, EventArgs e)
        {
            BtnOff.Image = Calculadora.Properties.Resources.off;

        }
    }
}
