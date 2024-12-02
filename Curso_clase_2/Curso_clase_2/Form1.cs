using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curso_clase_2
{
    public partial class Form1 : Form
    {
        private int miliSegundos = 0;
        private int segundos = 0;
        private int minutos = 0;
        private int horas = 0;
        private string ruta = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LblMenustrip.Text = "New";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {

                Form2 form2 = new Form2(textBox1.Text);
                form2.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("soy un cuadro de dialogo");
            MessageBox.Show("soy un cuadro de dialogo con titulo de cuadro", "titulo de cuadro");
            MessageBox.Show("soy un cuadro de dialogo con titulo de cuadro y botones", "titulo de cuadro", MessageBoxButtons.YesNoCancel);

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label10.Text = trackBar1.Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                groupBox6.BackColor = colorDialog1.Color;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.Font = fontDialog1.Font;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)

                label13.Text = openFileDialog1.FileName;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label14.Text = saveFileDialog1.FileName;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                label15.Text = printDialog1.PrinterSettings.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            miliSegundos++;

            if (miliSegundos < 10)
            {

                TxtMiliSegundos.Text = miliSegundos.ToString();

            }
            else
            {
                miliSegundos = 0;
                segundos++;

                TxtMiliSegundos.Text = miliSegundos.ToString();




                if (segundos < 60)
                {
                    TxtSegundos.Text = segundos.ToString();

                }
                else
                {
                    segundos = 0;
                    minutos++;
                    TxtSegundos.Text = segundos.ToString();

                    if (minutos < 60)
                    {
                        TxtMinutos.Text = minutos.ToString();
                    }
                    else
                    {
                        minutos = 0;
                        horas++;
                        TxtMinutos.Text = minutos.ToString();
                        TxtHoras.Text = horas.ToString();

                    }
                }

            }
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void BtnDetener_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void Btnreestablecer_Click(object sender, EventArgs e)
        {
            miliSegundos = 0;
            segundos = 0;
            minutos = 0;
            horas = 0;
            TxtMiliSegundos.Text = miliSegundos.ToString();
            TxtSegundos.Text = segundos.ToString();
            TxtMinutos.Text = minutos.ToString();
            TxtHoras.Text = horas.ToString();
        }

        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ruta = openFileDialog1.FileName;
            }
        }

        private void BtnReproducir_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = ruta;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void BtnDetenerRep_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void BtnPausa_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();

        }
    }
}
