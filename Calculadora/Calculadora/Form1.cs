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
        
        private void Btn1_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
          
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
           
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
           
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnDividir_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnMultiplicar_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnMenos_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnMas_Click(object sender, EventArgs e)
        {
           
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
            if (e.KeyChar > 41 && e.KeyChar < 58)
            {
                e.Handled = true;
               

            }

        }



        private void BtnPunto_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {

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
            BorrarUltimoCaracter();
        }

        private void BorrarUltimoCaracter()
        {
            
        }
    }
}
