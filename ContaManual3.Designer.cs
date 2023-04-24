namespace EscalaApp
{
    partial class ContaManual3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContaManual3));
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.pictureBoxDataPreco = new System.Windows.Forms.PictureBox();
            this.pictureBoxRepeticao = new System.Windows.Forms.PictureBox();
            this.pictureBoxNomeConta = new System.Windows.Forms.PictureBox();
            this.labelInformacao = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1Voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDataPreco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRepeticao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNomeConta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.Location = new System.Drawing.Point(158, 381);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(98, 26);
            this.radioButton5.TabIndex = 58;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Todo ano";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton6.Location = new System.Drawing.Point(158, 349);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(101, 26);
            this.radioButton6.TabIndex = 57;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Todo mês";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(158, 317);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(166, 26);
            this.radioButton3.TabIndex = 56;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "A cada quinze dias";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(158, 285);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(126, 26);
            this.radioButton4.TabIndex = 55;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Toda semana";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(158, 253);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(128, 26);
            this.radioButton2.TabIndex = 54;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Todos os dias";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(158, 221);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(128, 26);
            this.radioButton1.TabIndex = 53;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Não se repete";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // pictureBoxDataPreco
            // 
            this.pictureBoxDataPreco.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDataPreco.Image")));
            this.pictureBoxDataPreco.Location = new System.Drawing.Point(317, 59);
            this.pictureBoxDataPreco.Name = "pictureBoxDataPreco";
            this.pictureBoxDataPreco.Size = new System.Drawing.Size(43, 26);
            this.pictureBoxDataPreco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDataPreco.TabIndex = 52;
            this.pictureBoxDataPreco.TabStop = false;
            // 
            // pictureBoxRepeticao
            // 
            this.pictureBoxRepeticao.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRepeticao.Image")));
            this.pictureBoxRepeticao.Location = new System.Drawing.Point(366, 59);
            this.pictureBoxRepeticao.Name = "pictureBoxRepeticao";
            this.pictureBoxRepeticao.Size = new System.Drawing.Size(43, 26);
            this.pictureBoxRepeticao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRepeticao.TabIndex = 51;
            this.pictureBoxRepeticao.TabStop = false;
            // 
            // pictureBoxNomeConta
            // 
            this.pictureBoxNomeConta.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxNomeConta.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNomeConta.Image")));
            this.pictureBoxNomeConta.Location = new System.Drawing.Point(268, 59);
            this.pictureBoxNomeConta.Name = "pictureBoxNomeConta";
            this.pictureBoxNomeConta.Size = new System.Drawing.Size(43, 26);
            this.pictureBoxNomeConta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNomeConta.TabIndex = 50;
            this.pictureBoxNomeConta.TabStop = false;
            // 
            // labelInformacao
            // 
            this.labelInformacao.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformacao.ForeColor = System.Drawing.Color.Purple;
            this.labelInformacao.Location = new System.Drawing.Point(166, 123);
            this.labelInformacao.Name = "labelInformacao";
            this.labelInformacao.Size = new System.Drawing.Size(328, 68);
            this.labelInformacao.TabIndex = 49;
            this.labelInformacao.Text = "Este agendamento se repete?";
            this.labelInformacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(543, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1Voltar
            // 
            this.button1Voltar.BackColor = System.Drawing.Color.White;
            this.button1Voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Voltar.ForeColor = System.Drawing.Color.Purple;
            this.button1Voltar.Location = new System.Drawing.Point(12, 12);
            this.button1Voltar.Name = "button1Voltar";
            this.button1Voltar.Size = new System.Drawing.Size(37, 25);
            this.button1Voltar.TabIndex = 47;
            this.button1Voltar.Text = "<-";
            this.button1Voltar.UseVisualStyleBackColor = false;
            this.button1Voltar.Click += new System.EventHandler(this.button1Voltar_Click);
            // 
            // ContaManual3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.pictureBoxDataPreco);
            this.Controls.Add(this.pictureBoxRepeticao);
            this.Controls.Add(this.pictureBoxNomeConta);
            this.Controls.Add(this.labelInformacao);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1Voltar);
            this.Name = "ContaManual3";
            this.Text = "ContaManual3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDataPreco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRepeticao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNomeConta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.PictureBox pictureBoxDataPreco;
        private System.Windows.Forms.PictureBox pictureBoxRepeticao;
        private System.Windows.Forms.PictureBox pictureBoxNomeConta;
        private System.Windows.Forms.Label labelInformacao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1Voltar;
    }
}