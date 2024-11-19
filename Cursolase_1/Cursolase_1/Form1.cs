using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cursolase_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {

            label1.Text = textBox1.Text;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (RbRojo.Checked)
            {
                ColorElejido.Text = RbRojo.Text;
            }
            if (RbVerde.Checked)
            {
                ColorElejido.Text = RbVerde.Text;
            }
            if (RbAzul.Checked)
            {
                ColorElejido.Text = RbAzul.Text;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = comboBox1.Text;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = listBox1.SelectedItem.ToString();
        }


        // Manejar el clic del botón para iniciar la tarea en segundo plano
        private void button4_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;

            // Deshabilitar el botón para evitar clics múltiples
            button4.Enabled = false;

            // Iniciar el BackgroundWorker
            backgroundWorker1.RunWorkerAsync();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
        }

        // Evento DoWork: Se ejecuta en un hilo en segundo plano
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {


            for (int i = 0; i <= 100; i++)
            {
                // Comprobar si se ha solicitado la cancelación
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }

                // Realizar el trabajo en segundo plano
                Thread.Sleep(100); // Simulamos una tarea que toma tiempo

                // Reportar progreso
                backgroundWorker1.ReportProgress(i);
            }
        }


        // Evento ProgressChanged: Se ejecuta cuando se reporta progreso
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //progressBar1.Value = e.ProgressPercentage;
            label4.Text = $"Progreso: {e.ProgressPercentage}%";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Habilitar el botón de inicio de nuevo
            button4.Enabled = true;
            progressBar1.Visible = false;
            if (e.Cancelled)
            {
                MessageBox.Show("La tarea fue cancelada.");
            }
            else
            {
                MessageBox.Show("La tarea se completó correctamente.");
            }

            
        }


        // Evento RunWorkerCompleted: Se ejecuta cuando el trabajo ha terminado
        private void button6_Click(object sender, EventArgs e)
        {
            // Solicitar la cancelación de la tarea
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
                button4.Enabled = true;

            }
        }
    }
}
