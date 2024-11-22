using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CambioHora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fecha = dateTimePicker1.Value.ToString("dd-MM-yyyy");
            EjecutarComando("date " + fecha);
            Msj.Text = "Cambio de Fecha Correcto";
            backgroundWorker1.RunWorkerAsync();

        }

        static void EjecutarComando(string comando)
        {
            ProcessStartInfo procesoInfo = new ProcessStartInfo()
            {
                FileName = "cmd.exe",
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                Verb = "runas" // Ejecuta el proceso con privilegios de administrador
            };

            using (Process proceso = Process.Start(procesoInfo))
            {
                proceso.StandardInput.WriteLine(comando);
                proceso.StandardInput.Close();
                string salida = proceso.StandardOutput.ReadToEnd();
                Console.WriteLine(salida);
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button1_Click(sender, e);
            }
        }

        private void dateTimePicker1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button1_Click(sender, e);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 150, 0);
            Thread.Sleep(50);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.BackColor = Color.FromArgb(247, 239, 233);

        }
    }
}


