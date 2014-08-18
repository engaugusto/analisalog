namespace AnalisaLog
{
    partial class FormPrincipal
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
            this.fbdDir = new System.Windows.Forms.FolderBrowserDialog();
            this.btnDir = new System.Windows.Forms.Button();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.txtOutputPath = new System.Windows.Forms.TextBox();
            this.btnOutputPath = new System.Windows.Forms.Button();
            this.fbdOutput = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProcessa = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSeparador = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtColIP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDir
            // 
            this.btnDir.Location = new System.Drawing.Point(383, 38);
            this.btnDir.Name = "btnDir";
            this.btnDir.Size = new System.Drawing.Size(75, 23);
            this.btnDir.TabIndex = 0;
            this.btnDir.Text = "Escolher diretorio";
            this.btnDir.UseVisualStyleBackColor = true;
            this.btnDir.Click += new System.EventHandler(this.btnDir_Click);
            // 
            // txtDir
            // 
            this.txtDir.BackColor = System.Drawing.SystemColors.Window;
            this.txtDir.Location = new System.Drawing.Point(50, 41);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(314, 20);
            this.txtDir.TabIndex = 1;
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.BackColor = System.Drawing.SystemColors.Window;
            this.txtOutputPath.Location = new System.Drawing.Point(50, 96);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.Size = new System.Drawing.Size(314, 20);
            this.txtOutputPath.TabIndex = 2;
            // 
            // btnOutputPath
            // 
            this.btnOutputPath.Location = new System.Drawing.Point(383, 94);
            this.btnOutputPath.Name = "btnOutputPath";
            this.btnOutputPath.Size = new System.Drawing.Size(75, 23);
            this.btnOutputPath.TabIndex = 3;
            this.btnOutputPath.Text = "Escolher diretorio";
            this.btnOutputPath.UseVisualStyleBackColor = true;
            this.btnOutputPath.Click += new System.EventHandler(this.btnOutputPath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Caminho dos logs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Caminho do output";
            // 
            // btnProcessa
            // 
            this.btnProcessa.Location = new System.Drawing.Point(383, 140);
            this.btnProcessa.Name = "btnProcessa";
            this.btnProcessa.Size = new System.Drawing.Size(75, 23);
            this.btnProcessa.TabIndex = 6;
            this.btnProcessa.Text = "Processar";
            this.btnProcessa.UseVisualStyleBackColor = true;
            this.btnProcessa.Click += new System.EventHandler(this.btnProcessa_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(50, 140);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 20);
            this.txtIP.TabIndex = 7;
            this.txtIP.Text = "172";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Separador";
            // 
            // txtSeparador
            // 
            this.txtSeparador.Location = new System.Drawing.Point(169, 140);
            this.txtSeparador.MaxLength = 1;
            this.txtSeparador.Name = "txtSeparador";
            this.txtSeparador.Size = new System.Drawing.Size(100, 20);
            this.txtSeparador.TabIndex = 9;
            this.txtSeparador.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Col. do IP";
            // 
            // txtColIP
            // 
            this.txtColIP.Location = new System.Drawing.Point(293, 140);
            this.txtColIP.Name = "txtColIP";
            this.txtColIP.Size = new System.Drawing.Size(71, 20);
            this.txtColIP.TabIndex = 11;
            this.txtColIP.Text = "3";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 175);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtColIP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSeparador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.btnProcessa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOutputPath);
            this.Controls.Add(this.txtOutputPath);
            this.Controls.Add(this.txtDir);
            this.Controls.Add(this.btnDir);
            this.Name = "FormPrincipal";
            this.Text = "Analisador de Log.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fbdDir;
        private System.Windows.Forms.Button btnDir;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.TextBox txtOutputPath;
        private System.Windows.Forms.Button btnOutputPath;
        private System.Windows.Forms.FolderBrowserDialog fbdOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProcessa;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSeparador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtColIP;
    }
}

