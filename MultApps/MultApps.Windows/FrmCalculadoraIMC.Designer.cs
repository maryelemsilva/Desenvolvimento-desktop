﻿namespace MultApps.Windows
{
    partial class FrmCalculadoraIMC
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
            this.Adulto = new System.Windows.Forms.Panel();
            this.TxtAltura = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.cmbIdade = new System.Windows.Forms.ComboBox();
            this.lblIdade2 = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.chkFeminino = new System.Windows.Forms.CheckBox();
            this.chkMasculino = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkCrianca = new System.Windows.Forms.CheckBox();
            this.chkAdulto = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.Adulto.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblResultado);
            this.panel1.Controls.Add(this.btncalcular);
            this.panel1.Controls.Add(this.Adulto);
            this.panel1.Controls.Add(this.lblIdade);
            this.panel1.Controls.Add(this.chkFeminino);
            this.panel1.Controls.Add(this.chkMasculino);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.chkCrianca);
            this.panel1.Controls.Add(this.chkAdulto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(28, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1549, 759);
            this.panel1.TabIndex = 0;
            // 
            // Adulto
            // 
            this.Adulto.Controls.Add(this.TxtAltura);
            this.Adulto.Controls.Add(this.txtPeso);
            this.Adulto.Controls.Add(this.cmbIdade);
            this.Adulto.Controls.Add(this.lblIdade2);
            this.Adulto.Controls.Add(this.lblAltura);
            this.Adulto.Controls.Add(this.lblPeso);
            this.Adulto.Location = new System.Drawing.Point(85, 204);
            this.Adulto.Name = "Adulto";
            this.Adulto.Size = new System.Drawing.Size(1080, 111);
            this.Adulto.TabIndex = 8;
            // 
            // TxtAltura
            // 
            this.TxtAltura.Location = new System.Drawing.Point(127, 48);
            this.TxtAltura.Name = "TxtAltura";
            this.TxtAltura.Size = new System.Drawing.Size(73, 29);
            this.TxtAltura.TabIndex = 7;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(20, 48);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(75, 29);
            this.txtPeso.TabIndex = 6;
            // 
            // cmbIdade
            // 
            this.cmbIdade.FormattingEnabled = true;
            this.cmbIdade.Items.AddRange(new object[] {
            "1 ano",
            "2 anos",
            "3 anos",
            "4 anos ",
            "5 anos ",
            "6 anos",
            "7 anos",
            "8 anos",
            "9 anos",
            "10 anos",
            "11 anos",
            "12 anos",
            "13 anos",
            "14 anos ",
            "15 anos",
            "16 anos ",
            "17 anos",
            "18 anos"});
            this.cmbIdade.Location = new System.Drawing.Point(265, 45);
            this.cmbIdade.Name = "cmbIdade";
            this.cmbIdade.Size = new System.Drawing.Size(121, 32);
            this.cmbIdade.TabIndex = 5;
            // 
            // lblIdade2
            // 
            this.lblIdade2.AutoSize = true;
            this.lblIdade2.Location = new System.Drawing.Point(261, 9);
            this.lblIdade2.Name = "lblIdade2";
            this.lblIdade2.Size = new System.Drawing.Size(57, 24);
            this.lblIdade2.TabIndex = 4;
            this.lblIdade2.Text = "Idade";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(129, 9);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(58, 24);
            this.lblAltura.TabIndex = 1;
            this.lblAltura.Text = "Altura";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(25, 9);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(53, 24);
            this.lblPeso.TabIndex = 0;
            this.lblPeso.Text = "Peso";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.Location = new System.Drawing.Point(80, 159);
            this.lblIdade.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(184, 25);
            this.lblIdade.TabIndex = 6;
            this.lblIdade.Text = "Acima de 19 anos";
            // 
            // chkFeminino
            // 
            this.chkFeminino.AutoSize = true;
            this.chkFeminino.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFeminino.ForeColor = System.Drawing.Color.Gray;
            this.chkFeminino.Location = new System.Drawing.Point(743, 82);
            this.chkFeminino.Name = "chkFeminino";
            this.chkFeminino.Size = new System.Drawing.Size(176, 41);
            this.chkFeminino.TabIndex = 5;
            this.chkFeminino.Text = "Feminino";
            this.chkFeminino.UseVisualStyleBackColor = true;
            this.chkFeminino.Click += new System.EventHandler(this.chkFeminino_CheckendChanged);
            // 
            // chkMasculino
            // 
            this.chkMasculino.AutoSize = true;
            this.chkMasculino.Checked = true;
            this.chkMasculino.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMasculino.ForeColor = System.Drawing.Color.Orange;
            this.chkMasculino.Location = new System.Drawing.Point(537, 82);
            this.chkMasculino.Name = "chkMasculino";
            this.chkMasculino.Size = new System.Drawing.Size(189, 41);
            this.chkMasculino.TabIndex = 4;
            this.chkMasculino.Text = "Masculino";
            this.chkMasculino.UseVisualStyleBackColor = true;
            this.chkMasculino.Click += new System.EventHandler(this.chkMasculino_CheckendChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(532, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sexo";
            // 
            // chkCrianca
            // 
            this.chkCrianca.AutoSize = true;
            this.chkCrianca.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCrianca.ForeColor = System.Drawing.Color.Gray;
            this.chkCrianca.Location = new System.Drawing.Point(218, 82);
            this.chkCrianca.Name = "chkCrianca";
            this.chkCrianca.Size = new System.Drawing.Size(154, 41);
            this.chkCrianca.TabIndex = 2;
            this.chkCrianca.Text = "Criança";
            this.chkCrianca.UseVisualStyleBackColor = true;
            this.chkCrianca.Click += new System.EventHandler(this.chkCrianca_CheckedChanged);
            // 
            // chkAdulto
            // 
            this.chkAdulto.AutoSize = true;
            this.chkAdulto.Checked = true;
            this.chkAdulto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAdulto.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAdulto.ForeColor = System.Drawing.Color.Orange;
            this.chkAdulto.Location = new System.Drawing.Point(78, 82);
            this.chkAdulto.Name = "chkAdulto";
            this.chkAdulto.Size = new System.Drawing.Size(134, 41);
            this.chkAdulto.TabIndex = 1;
            this.chkAdulto.Text = "Adulto";
            this.chkAdulto.UseVisualStyleBackColor = true;
            this.chkAdulto.Click += new System.EventHandler(this.chkAdulto_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione";
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.Color.Chartreuse;
            this.btncalcular.Location = new System.Drawing.Point(85, 380);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(209, 42);
            this.btncalcular.TabIndex = 9;
            this.btncalcular.Text = "calcular";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(346, 398);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(94, 24);
            this.lblResultado.TabIndex = 10;
            this.lblResultado.Text = "Resultado";
            // 
            // FrmCalculadoraIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1599, 831);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmCalculadoraIMC";
            this.Text = "FrmCalculadoraIMC";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Adulto.ResumeLayout(false);
            this.Adulto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkCrianca;
        private System.Windows.Forms.CheckBox chkAdulto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkFeminino;
        private System.Windows.Forms.CheckBox chkMasculino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Panel Adulto;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox TxtAltura;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.ComboBox cmbIdade;
        private System.Windows.Forms.Label lblIdade2;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lblResultado;
    }
}