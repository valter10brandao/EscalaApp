namespace EscalaApp
{
    partial class ContaManual1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContaManual1));
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(229, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 59;
            this.label1.Text = "Nome da conta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(229, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 58;
            this.label6.Text = "Tipo da Conta";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Boleto",
            "Recibo",
            "Debito Automático",
            "Contas de consumo (agua, luz, telefone, internet)",
            "outros"});
            this.comboBox2.Location = new System.Drawing.Point(219, 237);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(265, 21);
            this.comboBox2.TabIndex = 57;
            this.comboBox2.TextChanged += new System.EventHandler(this.comboBox2_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Luz",
            "Água",
            "Telefone",
            "Aluguel",
            "Cartão de Crédito",
            "Financiamento",
            "Outros"});
            this.comboBox1.Location = new System.Drawing.Point(219, 195);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(265, 21);
            this.comboBox1.TabIndex = 56;
            // 
            // pictureBoxDataPreco
            // 
            this.pictureBoxDataPreco.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDataPreco.Image")));
            this.pictureBoxDataPreco.Location = new System.Drawing.Point(317, 59);
            this.pictureBoxDataPreco.Name = "pictureBoxDataPreco";
            this.pictureBoxDataPreco.Size = new System.Drawing.Size(43, 26);
            this.pictureBoxDataPreco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDataPreco.TabIndex = 55;
            this.pictureBoxDataPreco.TabStop = false;
            // 
            // pictureBoxRepeticao
            // 
            this.pictureBoxRepeticao.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRepeticao.Image")));
            this.pictureBoxRepeticao.Location = new System.Drawing.Point(366, 59);
            this.pictureBoxRepeticao.Name = "pictureBoxRepeticao";
            this.pictureBoxRepeticao.Size = new System.Drawing.Size(43, 26);
            this.pictureBoxRepeticao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRepeticao.TabIndex = 54;
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
            this.pictureBoxNomeConta.TabIndex = 53;
            this.pictureBoxNomeConta.TabStop = false;
            // 
            // labelInformacao
            // 
            this.labelInformacao.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformacao.ForeColor = System.Drawing.Color.Purple;
            this.labelInformacao.Location = new System.Drawing.Point(195, 101);
            this.labelInformacao.Name = "labelInformacao";
            this.labelInformacao.Size = new System.Drawing.Size(299, 68);
            this.labelInformacao.TabIndex = 52;
            this.labelInformacao.Text = "Qual o nome deste agendamento?";
            this.labelInformacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(544, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 51;
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
            this.button1Voltar.TabIndex = 50;
            this.button1Voltar.Text = "<-";
            this.button1Voltar.UseVisualStyleBackColor = false;
            this.button1Voltar.Click += new System.EventHandler(this.button1Voltar_Click);
            // 
            // ContaManual1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBoxDataPreco);
            this.Controls.Add(this.pictureBoxRepeticao);
            this.Controls.Add(this.pictureBoxNomeConta);
            this.Controls.Add(this.labelInformacao);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1Voltar);
            this.Name = "ContaManual1";
            this.Text = "ContaManual1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDataPreco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRepeticao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNomeConta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBoxDataPreco;
        private System.Windows.Forms.PictureBox pictureBoxRepeticao;
        private System.Windows.Forms.PictureBox pictureBoxNomeConta;
        private System.Windows.Forms.Label labelInformacao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1Voltar;
    }
}