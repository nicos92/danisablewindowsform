using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curso_Clase_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool _abrirPanelLeft = true;
        private bool _abrirPanelRight = true;
        private bool _abrirPanelBottom = true;

        private void button2_Click(object sender, EventArgs e)
        {
            if (_abrirPanelLeft)
            {
                _abrirPanelLeft = false;
            PanelLeft.Width = PanelLeft.Width / 2;
            }
            else
            {
                _abrirPanelLeft = true;
                PanelLeft.Width = PanelLeft.Width * 2;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_abrirPanelBottom)
            {
                _abrirPanelBottom = false;
                PanelBottom.Height = PanelBottom.Height / 2;
            }
            else
            {
                _abrirPanelBottom = true;
                PanelBottom.Height = PanelBottom.Height * 2;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_abrirPanelRight)
            {
                _abrirPanelRight = false;
                PanelRight.Width = PanelRight.Width / 2;
            }
            else
            {
                _abrirPanelRight = true;
                PanelRight.Width = PanelRight.Width * 2;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "¤"+this.Width + "x" + this.Height;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "¤" + this.Width + "x" + this.Height;

        }
    }
}
