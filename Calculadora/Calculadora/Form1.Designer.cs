﻿namespace Calculadora
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PanelCenter = new System.Windows.Forms.Panel();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.TablaBotones = new System.Windows.Forms.TableLayoutPanel();
            this.BtnCE = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.BtnDividir = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.BtnMultiplicar = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.BtnMenos = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.BtnMas = new System.Windows.Forms.Button();
            this.BtnMasMenos = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.BtnPunto = new System.Windows.Forms.Button();
            this.BtnIgual = new System.Windows.Forms.Button();
            this.TxtCuenta = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.PanelCenter.SuspendLayout();
            this.PanelTop.SuspendLayout();
            this.TablaBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.PanelCenter, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(480, 557);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // PanelCenter
            // 
            this.PanelCenter.Controls.Add(this.TablaBotones);
            this.PanelCenter.Controls.Add(this.PanelTop);
            this.PanelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCenter.Location = new System.Drawing.Point(23, 23);
            this.PanelCenter.Name = "PanelCenter";
            this.PanelCenter.Size = new System.Drawing.Size(434, 511);
            this.PanelCenter.TabIndex = 0;
            // 
            // PanelTop
            // 
            this.PanelTop.Controls.Add(this.TxtCuenta);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(434, 100);
            this.PanelTop.TabIndex = 0;
            // 
            // TablaBotones
            // 
            this.TablaBotones.ColumnCount = 4;
            this.TablaBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TablaBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TablaBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TablaBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TablaBotones.Controls.Add(this.BtnIgual, 3, 4);
            this.TablaBotones.Controls.Add(this.BtnPunto, 2, 4);
            this.TablaBotones.Controls.Add(this.Btn0, 1, 4);
            this.TablaBotones.Controls.Add(this.BtnMasMenos, 0, 4);
            this.TablaBotones.Controls.Add(this.BtnMas, 3, 3);
            this.TablaBotones.Controls.Add(this.Btn3, 2, 3);
            this.TablaBotones.Controls.Add(this.Btn2, 1, 3);
            this.TablaBotones.Controls.Add(this.Btn1, 0, 3);
            this.TablaBotones.Controls.Add(this.BtnMenos, 3, 2);
            this.TablaBotones.Controls.Add(this.Btn6, 2, 2);
            this.TablaBotones.Controls.Add(this.Btn5, 1, 2);
            this.TablaBotones.Controls.Add(this.Btn4, 0, 2);
            this.TablaBotones.Controls.Add(this.BtnMultiplicar, 3, 1);
            this.TablaBotones.Controls.Add(this.Btn9, 2, 1);
            this.TablaBotones.Controls.Add(this.Btn8, 1, 1);
            this.TablaBotones.Controls.Add(this.Btn7, 0, 1);
            this.TablaBotones.Controls.Add(this.BtnDividir, 3, 0);
            this.TablaBotones.Controls.Add(this.BtnBorrar, 2, 0);
            this.TablaBotones.Controls.Add(this.BtnC, 1, 0);
            this.TablaBotones.Controls.Add(this.BtnCE, 0, 0);
            this.TablaBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablaBotones.Location = new System.Drawing.Point(0, 100);
            this.TablaBotones.Name = "TablaBotones";
            this.TablaBotones.RowCount = 5;
            this.TablaBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TablaBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TablaBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TablaBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TablaBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TablaBotones.Size = new System.Drawing.Size(434, 411);
            this.TablaBotones.TabIndex = 1;
            // 
            // BtnCE
            // 
            this.BtnCE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCE.Font = new System.Drawing.Font("Hack Nerd Font", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCE.Location = new System.Drawing.Point(3, 3);
            this.BtnCE.Name = "BtnCE";
            this.BtnCE.Size = new System.Drawing.Size(102, 76);
            this.BtnCE.TabIndex = 0;
            this.BtnCE.Text = "CE";
            this.BtnCE.UseVisualStyleBackColor = true;
            // 
            // BtnC
            // 
            this.BtnC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnC.Font = new System.Drawing.Font("Hack Nerd Font", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnC.Location = new System.Drawing.Point(111, 3);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(102, 76);
            this.BtnC.TabIndex = 1;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = true;
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBorrar.Font = new System.Drawing.Font("Hack Nerd Font", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrar.Location = new System.Drawing.Point(219, 3);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(102, 76);
            this.BtnBorrar.TabIndex = 2;
            this.BtnBorrar.Text = "<-";
            this.BtnBorrar.UseVisualStyleBackColor = true;
            // 
            // BtnDividir
            // 
            this.BtnDividir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDividir.Font = new System.Drawing.Font("Hack Nerd Font", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDividir.Location = new System.Drawing.Point(327, 3);
            this.BtnDividir.Name = "BtnDividir";
            this.BtnDividir.Size = new System.Drawing.Size(104, 76);
            this.BtnDividir.TabIndex = 3;
            this.BtnDividir.Text = "/";
            this.BtnDividir.UseVisualStyleBackColor = true;
            this.BtnDividir.Click += new System.EventHandler(this.BtnDividir_Click);
            // 
            // Btn7
            // 
            this.Btn7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn7.Font = new System.Drawing.Font("Hack Nerd Font", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn7.Location = new System.Drawing.Point(3, 85);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(102, 76);
            this.Btn7.TabIndex = 4;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = true;
            this.Btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // Btn8
            // 
            this.Btn8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn8.Font = new System.Drawing.Font("Hack Nerd Font", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn8.Location = new System.Drawing.Point(111, 85);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(102, 76);
            this.Btn8.TabIndex = 5;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = true;
            this.Btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // Btn9
            // 
            this.Btn9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn9.Font = new System.Drawing.Font("Hack Nerd Font", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn9.Location = new System.Drawing.Point(219, 85);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(102, 76);
            this.Btn9.TabIndex = 6;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = true;
            this.Btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // BtnMultiplicar
            // 
            this.BtnMultiplicar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMultiplicar.Font = new System.Drawing.Font("Hack Nerd Font", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMultiplicar.Location = new System.Drawing.Point(327, 85);
            this.BtnMultiplicar.Name = "BtnMultiplicar";
            this.BtnMultiplicar.Size = new System.Drawing.Size(104, 76);
            this.BtnMultiplicar.TabIndex = 7;
            this.BtnMultiplicar.Text = "X";
            this.BtnMultiplicar.UseVisualStyleBackColor = true;
            this.BtnMultiplicar.Click += new System.EventHandler(this.BtnMultiplicar_Click);
            // 
            // Btn4
            // 
            this.Btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn4.Font = new System.Drawing.Font("Hack Nerd Font", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn4.Location = new System.Drawing.Point(3, 167);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(102, 76);
            this.Btn4.TabIndex = 8;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // Btn5
            // 
            this.Btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn5.Font = new System.Drawing.Font("Hack Nerd Font", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn5.Location = new System.Drawing.Point(111, 167);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(102, 76);
            this.Btn5.TabIndex = 9;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = true;
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // Btn6
            // 
            this.Btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn6.Font = new System.Drawing.Font("Hack Nerd Font", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn6.Location = new System.Drawing.Point(219, 167);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(102, 76);
            this.Btn6.TabIndex = 10;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = true;
            this.Btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // BtnMenos
            // 
            this.BtnMenos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenos.Font = new System.Drawing.Font("Hack Nerd Font", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenos.Location = new System.Drawing.Point(327, 167);
            this.BtnMenos.Name = "BtnMenos";
            this.BtnMenos.Size = new System.Drawing.Size(104, 76);
            this.BtnMenos.TabIndex = 11;
            this.BtnMenos.Text = "-";
            this.BtnMenos.UseVisualStyleBackColor = true;
            this.BtnMenos.Click += new System.EventHandler(this.BtnMenos_Click);
            // 
            // Btn1
            // 
            this.Btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1.Font = new System.Drawing.Font("Hack Nerd Font", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.Location = new System.Drawing.Point(3, 249);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(102, 76);
            this.Btn1.TabIndex = 12;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn2
            // 
            this.Btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn2.Font = new System.Drawing.Font("Hack Nerd Font", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2.Location = new System.Drawing.Point(111, 249);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(102, 76);
            this.Btn2.TabIndex = 13;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn3
            // 
            this.Btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn3.Font = new System.Drawing.Font("Hack Nerd Font", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3.Location = new System.Drawing.Point(219, 249);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(102, 76);
            this.Btn3.TabIndex = 14;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // BtnMas
            // 
            this.BtnMas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMas.Font = new System.Drawing.Font("Hack Nerd Font", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMas.Location = new System.Drawing.Point(327, 249);
            this.BtnMas.Name = "BtnMas";
            this.BtnMas.Size = new System.Drawing.Size(104, 76);
            this.BtnMas.TabIndex = 15;
            this.BtnMas.Text = "+";
            this.BtnMas.UseVisualStyleBackColor = true;
            this.BtnMas.Click += new System.EventHandler(this.BtnMas_Click);
            // 
            // BtnMasMenos
            // 
            this.BtnMasMenos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMasMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMasMenos.Font = new System.Drawing.Font("Hack Nerd Font", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMasMenos.Location = new System.Drawing.Point(3, 331);
            this.BtnMasMenos.Name = "BtnMasMenos";
            this.BtnMasMenos.Size = new System.Drawing.Size(102, 77);
            this.BtnMasMenos.TabIndex = 16;
            this.BtnMasMenos.Text = "+/-";
            this.BtnMasMenos.UseVisualStyleBackColor = true;
            // 
            // Btn0
            // 
            this.Btn0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn0.Font = new System.Drawing.Font("Hack Nerd Font", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn0.Location = new System.Drawing.Point(111, 331);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(102, 77);
            this.Btn0.TabIndex = 17;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = true;
            this.Btn0.Click += new System.EventHandler(this.Btn0_Click);
            // 
            // BtnPunto
            // 
            this.BtnPunto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnPunto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPunto.Font = new System.Drawing.Font("Hack Nerd Font", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPunto.Location = new System.Drawing.Point(219, 331);
            this.BtnPunto.Name = "BtnPunto";
            this.BtnPunto.Size = new System.Drawing.Size(102, 77);
            this.BtnPunto.TabIndex = 18;
            this.BtnPunto.Text = ".";
            this.BtnPunto.UseVisualStyleBackColor = true;
            // 
            // BtnIgual
            // 
            this.BtnIgual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIgual.Font = new System.Drawing.Font("Hack Nerd Font", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIgual.Location = new System.Drawing.Point(327, 331);
            this.BtnIgual.Name = "BtnIgual";
            this.BtnIgual.Size = new System.Drawing.Size(104, 77);
            this.BtnIgual.TabIndex = 19;
            this.BtnIgual.Text = "=";
            this.BtnIgual.UseVisualStyleBackColor = true;
            this.BtnIgual.Click += new System.EventHandler(this.BtnIgual_Click);
            // 
            // TxtCuenta
            // 
            this.TxtCuenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtCuenta.Font = new System.Drawing.Font("Hack Nerd Font", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCuenta.Location = new System.Drawing.Point(0, 0);
            this.TxtCuenta.MaxLength = 15;
            this.TxtCuenta.Name = "TxtCuenta";
            this.TxtCuenta.Size = new System.Drawing.Size(434, 63);
            this.TxtCuenta.TabIndex = 0;
            this.TxtCuenta.TextChanged += new System.EventHandler(this.TxtCuenta_TextChanged);
            this.TxtCuenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCuenta_KeyPress);
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(480, 557);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Hack Nerd Font", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.PanelCenter.ResumeLayout(false);
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.TablaBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel PanelCenter;
        private System.Windows.Forms.TableLayoutPanel TablaBotones;
        private System.Windows.Forms.Button BtnCE;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Button BtnIgual;
        private System.Windows.Forms.Button BtnPunto;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button BtnMasMenos;
        private System.Windows.Forms.Button BtnMas;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button BtnMenos;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button BtnMultiplicar;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button BtnDividir;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.TextBox TxtCuenta;
    }
}
