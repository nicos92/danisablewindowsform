using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
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
        private SoundPlayer player = new SoundPlayer();
        private EventLog eventLog1 = new EventLog();

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
            //LblMenustrip.Text = "New";
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
            LblEstado.Text = "Reproduciendo";
        }

        private void BtnDetenerRep_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            LblEstado.Text = "Detenido";

        }

        private void BtnPausa_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            LblEstado.Text = "En Pausa";


        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void BtnBeep_Click(object sender, EventArgs e)
        {
            int frequency = 1000;
            int duration = 200;
            Console.Beep(frequency,duration);
        }

       
        // no funcionan, por alguna razon,supongo que es Windows 11, en el windows 10 del trabajo funcionan casi todos menos el question.
        private void button8_Click(object sender, EventArgs e)
        {
            SystemSounds.Asterisk.Play();
            //SystemSounds.Beep.Play();
            //SystemSounds.Hand.Play();
            //SystemSounds.Exclamation.Play();
            //SystemSounds.Question.Play();



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ruta = openFileDialog1.FileName;
            }
        }

        private void BtnPlayNativo_Click(object sender, EventArgs e)
        {
            // solo repreoduce archivos WAV
            player.SoundLocation = ruta;
            player.Load();
            player.Play();
        }

        private void BtnDetenerNativo_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void BtnPausaNativo_Click(object sender, EventArgs e)
        {
            // no tiene pausa
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "¤"+this.Width.ToString() + "x" + this.Height.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "¤" + this.Width.ToString() + "x" + this.Height.ToString();
            WriteEventLogEntry("This is an entry in the event log by daveoncsharp.com");

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            int num = dataGridView1.Rows.Add();
            dataGridView1.Rows[num].Cells[0].Value = TxtNombre.Text;
            dataGridView1.Rows[num].Cells[1].Value = TxtApellido.Text;
            dataGridView1.Rows[num].Cells[2].Value = TxtCalificacion.Text;
            dataGridView1.Rows[num].Cells[3].Value = Convert.ToInt32(TxtCalificacion.Text) >= 7 ? true : false;
        }

        private  void WriteEventLogEntry(string message)
        {
            //Log de eventos en Windows: Los eventos se guardan en el Visor de eventos de Windows, que puedes acceder desde "Panel de control > Herramientas administrativas > Visor de eventos". Ahí podrás ver los eventos registrados por tu aplicación.
            //El uso de la herramienta Event Log en una aplicación de Windows Forms es útil para registrar información importante, advertencias o errores.Es importante manejar adecuadamente los permisos y asegurarte de que la fuente de eventos esté configurada correctamente para evitar errores al escribir en el registro de eventos.
            // Create an instance of EventLog


            // Check if the event source exists. If not create it.
            if (!EventLog.SourceExists("TestApplication"))
            {
                EventLog.CreateEventSource("TestApplication", "Application");
            }

            // Set the source name for writing log entries.
            eventLog1.Source = "TestApplication";

            // Create an event ID to add to the event log
            int eventID = 8;

            // Write an entry to the event log.
            eventLog1.WriteEntry(message,
                                EventLogEntryType.Information,
                                eventID);

            // Close the Event Log
            eventLog1.Close();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            label2.Text = domainUpDown1.Text;
        }
    }
}
