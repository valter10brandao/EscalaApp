namespace EscalaApp
{
    partial class OpacaoAgendamento
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
            this.button2CodigoBarras = new System.Windows.Forms.Button();
            this.button3Manual = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1Voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2CodigoBarras
            // 
            this.button2CodigoBarras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2CodigoBarras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button2CodigoBarras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2CodigoBarras.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2CodigoBarras.ForeColor = System.Drawing.Color.White;
            this.button2CodigoBarras.Location = new System.Drawing.Point(205, 289);
            this.button2CodigoBarras.Name = "button2CodigoBarras";
            this.button2CodigoBarras.Size = new System.Drawing.Size(330, 39);
            this.button2CodigoBarras.TabIndex = 17;
            this.button2CodigoBarras.Text = "COM CÓDIGO DE BARRAS";
            this.button2CodigoBarras.UseVisualStyleBackColor = false;
            this.button2CodigoBarras.Click += new System.EventHandler(this.button2CodigoBarras_Click);
            // 
            // button3Manual
            // 
            this.button3Manual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3Manual.BackColor = System.Drawing.Color.White;
            this.button3Manual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3Manual.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3Manual.ForeColor = System.Drawing.Color.Purple;
            this.button3Manual.Location = new System.Drawing.Point(205, 228);
            this.button3Manual.Name = "button3Manual";
            this.button3Manual.Size = new System.Drawing.Size(330, 39);
            this.button3Manual.TabIndex = 16;
            this.button3Manual.Text = "MANUAL";
            this.button3Manual.UseVisualStyleBackColor = false;
            this.button3Manual.Click += new System.EventHandler(this.button3Manual_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(199, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 121);
            this.label2.TabIndex = 15;
            this.label2.Text = "Como você prefere cadastrar este agendamento?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1Voltar
            // 
            this.button1Voltar.BackColor = System.Drawing.Color.White;
            this.button1Voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Voltar.ForeColor = System.Drawing.Color.Purple;
            this.button1Voltar.Location = new System.Drawing.Point(12, 12);
            this.button1Voltar.Name = "button1Voltar";
            this.button1Voltar.Size = new System.Drawing.Size(37, 25);
            this.button1Voltar.TabIndex = 14;
            this.button1Voltar.Text = "<-";
            this.button1Voltar.UseVisualStyleBackColor = false;
            this.button1Voltar.Click += new System.EventHandler(this.button1Voltar_Click);
            // 
            // OpacaoAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2CodigoBarras);
            this.Controls.Add(this.button3Manual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1Voltar);
            this.Name = "OpacaoAgendamento";
            this.Text = "OpacaoAgendamento";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2CodigoBarras;
        private System.Windows.Forms.Button button3Manual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1Voltar;
    }
}