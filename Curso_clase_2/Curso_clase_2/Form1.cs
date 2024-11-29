﻿using System;
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
            Form2 form2 = new Form2();
            form2.Show();
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
    }
}
