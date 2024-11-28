using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertirSvgEnIco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string path = Path.GetFullPath( textBox1.Text);

            EjecutarComando();
        }
        public  void ConvertSvgToIcoUsingInkscape()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "inkscape.exe",
                Arguments = $"-z -o d:\\Users\\n.sandoval\\Pictures\\regular\\00.svg d:\\Users\\n.sandoval\\Pictures\\regular\\00.ico ",
                CreateNoWindow = false,
                UseShellExecute = false
            };

            using (Process process = Process.Start("inkscape"))
            {
                process.WaitForExit();
            }
        }

        public void EjecutarComando()
        {
            ProcessStartInfo procesoInfo = new ProcessStartInfo()
            {
                //Esto especifica el programa que se va a ejecutar, en este caso, cmd.exe (el símbolo del sistema de Windows). Esto te permite ejecutar cualquier operación de línea de comandos dentro del proceso.
                FileName = "cmd.exe",
                //Arguments = $"-z -o d:\\Users\\n.sandoval\\Pictures\\regular\\00.svg d:\\Users\\n.sandoval\\Pictures\\regular\\00.ico ",


                // RedirectStandardInput = true Esto significa que puedes enviar entradas al proceso (es decir, al símbolo del sistema) de manera programática a través del flujo StandardInput.
                RedirectStandardInput = true,

                // RedirectStandardOutput = true Esto permite capturar la salida del proceso (es decir, el texto que el símbolo del sistema escribe en la consola) mediante el flujo StandardOutput. Puedes leer la salida para procesarla o mostrarla al usuario.
                RedirectStandardOutput = true,

                // UseShellExecute = false Esta configuración es necesaria cuando rediriges las entradas y salidas. Al establecerlo en false, se asegura que no se utilice el shell para iniciar el proceso, y que los flujos de entrada/salida estén disponibles para redirección.
                UseShellExecute = false,

                // CreateNoWindow = true Esto evita que la ventana del símbolo del sistema sea visible cuando el proceso esté ejecutándose. Es útil si no deseas que el usuario vea la ventana del símbolo del sistema mientras se ejecuta el comando.
                CreateNoWindow = true,

                // Verb = "runas" Esto configura el proceso para que se ejecute con privilegios elevados (como administrador). El verbo runas se utiliza específicamente para solicitar que el proceso se ejecute con derechos administrativos. Esto generará un mensaje del UAC (Control de Cuentas de Usuario) pidiendo permiso al usuario para continuar.
                Verb = "runas" // Ejecuta el proceso con privilegios de administrador
            };

            using (Process proceso = Process.Start(procesoInfo)) //  inicia el símbolo del sistema.
            {
                proceso.StandardInput.WriteLine(@"c:");
                proceso.StandardInput.WriteLine(@"cd c:\Users\N.Sandoval");

                proceso.StandardInput.WriteLine(@"inkscape d:\Users\n.sandoval\Pictures\regular\3.svg --export-filename=d:\Users\n.sandoval\Pictures\regular\3.png --export-width=256 --export-height=256"); // envía un comando al símbolo del sistema .
                proceso.StandardInput.Close();
                string salida = proceso.StandardOutput.ReadToEnd(); //  lee la salida del comando
                Console.WriteLine("Salida: " + salida);
                proceso.WaitForExit(); // asegura que el proceso termine antes de que el programa continúe o se cierre.
            }
        }
    }
}
