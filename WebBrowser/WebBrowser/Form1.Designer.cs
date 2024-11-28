namespace WebBrowser
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.WebBrowser = new System.Windows.Forms.WebBrowser();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.BtnAdelante = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnIr = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.WebBrowser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 361);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.04066F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.130859F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.130859F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.003163F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.618192F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.618192F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.41566F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.001757F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.04066F));
            this.tableLayoutPanel1.Controls.Add(this.BtnAtras, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnAdelante, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnUpdate, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnHome, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnStop, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnIr, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxtBuscar, 6, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // WebBrowser
            // 
            this.WebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebBrowser.Location = new System.Drawing.Point(0, 0);
            this.WebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowser.Name = "WebBrowser";
            this.WebBrowser.Size = new System.Drawing.Size(784, 361);
            this.WebBrowser.TabIndex = 2;
            // 
            // BtnAtras
            // 
            this.BtnAtras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAtras.AutoSize = true;
            this.BtnAtras.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAtras.Location = new System.Drawing.Point(30, 38);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(25, 23);
            this.BtnAtras.TabIndex = 0;
            this.BtnAtras.Text = "<";
            this.BtnAtras.UseVisualStyleBackColor = true;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // BtnAdelante
            // 
            this.BtnAdelante.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAdelante.AutoSize = true;
            this.BtnAdelante.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAdelante.Location = new System.Drawing.Point(70, 38);
            this.BtnAdelante.Name = "BtnAdelante";
            this.BtnAdelante.Size = new System.Drawing.Size(25, 23);
            this.BtnAdelante.TabIndex = 1;
            this.BtnAdelante.Text = ">";
            this.BtnAdelante.UseVisualStyleBackColor = true;
            this.BtnAdelante.Click += new System.EventHandler(this.BtnAdelante_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnUpdate.AutoSize = true;
            this.BtnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnUpdate.Location = new System.Drawing.Point(106, 38);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(64, 23);
            this.BtnUpdate.TabIndex = 2;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnHome.AutoSize = true;
            this.BtnHome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnHome.Location = new System.Drawing.Point(178, 38);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(49, 23);
            this.BtnHome.TabIndex = 3;
            this.BtnHome.Text = "Home";
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnStop.AutoSize = true;
            this.BtnStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnStop.Location = new System.Drawing.Point(237, 38);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(49, 23);
            this.BtnStop.TabIndex = 4;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnIr
            // 
            this.BtnIr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnIr.AutoSize = true;
            this.BtnIr.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnIr.Location = new System.Drawing.Point(720, 38);
            this.BtnIr.Name = "BtnIr";
            this.BtnIr.Size = new System.Drawing.Size(33, 23);
            this.BtnIr.TabIndex = 5;
            this.BtnIr.Text = "Ir";
            this.BtnIr.UseVisualStyleBackColor = true;
            this.BtnIr.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtBuscar.Location = new System.Drawing.Point(315, 39);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(377, 21);
            this.TxtBuscar.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("MartianMono NF", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Web Browser";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnAtras;
        private System.Windows.Forms.Button BtnAdelante;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnIr;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.WebBrowser WebBrowser;
        private System.Windows.Forms.TextBox TxtBuscar;
    }
}

