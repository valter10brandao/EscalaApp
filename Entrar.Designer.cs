namespace EscalaApp
{
    partial class Entrar
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
            this.button1Entrar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2Cadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1Entrar
            // 
            this.button1Entrar.Location = new System.Drawing.Point(274, 268);
            this.button1Entrar.Name = "button1Entrar";
            this.button1Entrar.Size = new System.Drawing.Size(253, 43);
            this.button1Entrar.TabIndex = 6;
            this.button1Entrar.Text = "Entrar";
            this.button1Entrar.UseVisualStyleBackColor = true;
            this.button1Entrar.Click += new System.EventHandler(this.button1Entrar_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(274, 198);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(253, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(274, 139);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2Cadastrar
            // 
            this.button2Cadastrar.Location = new System.Drawing.Point(274, 340);
            this.button2Cadastrar.Name = "button2Cadastrar";
            this.button2Cadastrar.Size = new System.Drawing.Size(253, 43);
            this.button2Cadastrar.TabIndex = 7;
            this.button2Cadastrar.Text = "Cadastrar";
            this.button2Cadastrar.UseVisualStyleBackColor = true;
            this.button2Cadastrar.Click += new System.EventHandler(this.button2Cadastrar_Click);
            // 
            // Entrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2Cadastrar);
            this.Controls.Add(this.button1Entrar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Entrar";
            this.Text = "Entrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1Entrar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2Cadastrar;
    }
}