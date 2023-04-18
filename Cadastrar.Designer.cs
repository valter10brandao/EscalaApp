namespace EscalaApp
{
    partial class Cadastrar
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
            this.button2Cadastrar = new System.Windows.Forms.Button();
            this.textBox2Senha = new System.Windows.Forms.TextBox();
            this.textBox1Email = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2Cadastrar
            // 
            this.button2Cadastrar.Location = new System.Drawing.Point(274, 256);
            this.button2Cadastrar.Name = "button2Cadastrar";
            this.button2Cadastrar.Size = new System.Drawing.Size(253, 43);
            this.button2Cadastrar.TabIndex = 11;
            this.button2Cadastrar.Text = "Cadastrar";
            this.button2Cadastrar.UseVisualStyleBackColor = true;
            this.button2Cadastrar.Click += new System.EventHandler(this.button2Cadastrar_Click);
            // 
            // textBox2Senha
            // 
            this.textBox2Senha.Location = new System.Drawing.Point(274, 162);
            this.textBox2Senha.Name = "textBox2Senha";
            this.textBox2Senha.Size = new System.Drawing.Size(253, 20);
            this.textBox2Senha.TabIndex = 9;
            // 
            // textBox1Email
            // 
            this.textBox1Email.Location = new System.Drawing.Point(274, 103);
            this.textBox1Email.Name = "textBox1Email";
            this.textBox1Email.Size = new System.Drawing.Size(253, 20);
            this.textBox1Email.TabIndex = 8;
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2Cadastrar);
            this.Controls.Add(this.textBox2Senha);
            this.Controls.Add(this.textBox1Email);
            this.Name = "Cadastrar";
            this.Text = "Cadastrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2Cadastrar;
        private System.Windows.Forms.TextBox textBox2Senha;
        private System.Windows.Forms.TextBox textBox1Email;
    }
}