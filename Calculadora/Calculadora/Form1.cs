using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using Svg;

namespace Calculadora
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }



        private void EnviarTecla(string tecla)
        {
            TxtCuenta.Focus();
            SendKeys.Send(tecla);
        }


        private void Btn1_Click(object sender, EventArgs e)
        {
            EnviarTecla("1");
        }

        

        private void Btn2_Click(object sender, EventArgs e)
        {
            EnviarTecla("2");

        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            EnviarTecla("3");

        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            EnviarTecla("4");

        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            EnviarTecla("5");

        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            EnviarTecla("6");

        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            EnviarTecla("7");

        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            EnviarTecla("8");

        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            EnviarTecla("9");

        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            EnviarTecla("0");

        }

        private void BtnDividir_Click(object sender, EventArgs e)
        {
            EnviarTecla("/");

        }

        private void BtnMultiplicar_Click(object sender, EventArgs e)
        {
            EnviarTecla("*");

        }

        private void BtnMenos_Click(object sender, EventArgs e)
        {
            EnviarTecla("-");

        }

        private void BtnMas_Click(object sender, EventArgs e)
        {
            EnviarTecla("+");

        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            // hacer la cuenta
        }

        private void TxtCuenta_TextChanged(object sender, EventArgs e)
        {
            /*if (!(Texto[Texto.Length] > 41 && Texto[Texto.Length] < 58))
            {
                BorrarUltimoCaracter();

            }*/
        }

        private void TxtCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            // para ingresar * + - / , . 0123456789
            if (!(e.KeyChar > 41 && e.KeyChar < 58) )
            {
                e.Handled = true;


            }

            // para borrar con tecla suprimir

            if ((e.KeyChar) == 127)
            {
                e.Handled = false;
            }

            // para borrar normal
            if ((e.KeyChar) == 8)
            {
                e.Handled = false;
            }

        }



        private void BtnPunto_Click(object sender, EventArgs e)
        {
            EnviarTecla(",");

        }

        

        private void BtnOff_MouseHover(object sender, EventArgs e)
        {
            BtnOff.Image = Properties.Resources.off1;
        }

        private void BtnOff_MouseLeave(object sender, EventArgs e)
        {
            BtnOff.Image = Properties.Resources.off;

        }

        private void BtnHistorial_MouseHover(object sender, EventArgs e)
        {
            BtnHistorial.Image = Properties.Resources.history1;

        }

        private void BtnHistorial_MouseLeave(object sender, EventArgs e)
        {
            BtnHistorial.Image = Properties.Resources.history;

        }

        private void BtnOff_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            LimpiarText();
        }

        private void LimpiarText()
        {
            TxtCuenta.Text = "";

        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            TxtCuenta.Text = "";

        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {

            // TODO rehacer
            BorrarUltimoCaracter();
        }

        private void BorrarUltimoCaracter()
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

            /*
            var svg = SvgDocument.Open(@"d:\Users\n.sandoval\Music\windowsform\Calculadora\Calculadora\Resources\4.svg");
            svg.Fill = new SvgColourServer(Color.Red);
            svg.Width = new SvgUnit(SvgUnitType.Pixel, 100);  // Cambiar el ancho a 500 píxeles
            svg.Height = new SvgUnit(SvgUnitType.Pixel, 100);
            BtnHistorial.Image = svg.Draw();
            */
    
        }
    }
}
