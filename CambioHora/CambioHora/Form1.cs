using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
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
            Msj.Text = "Cambio de hora correcto";
            
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
    }
}

/*
 * 
  // Establecer la hora a 14:30:00
        string command = $"time 14:30:00";

        // Ejecutar el comando TIME en la línea de comandos
        ProcessStartInfo psi = new ProcessStartInfo("cmd", "/c " + command);
        psi.CreateNoWindow = true;
        psi.UseShellExecute = false;
        Process process = Process.Start(psi);
        process.WaitForExit();
        
     
     
     */
