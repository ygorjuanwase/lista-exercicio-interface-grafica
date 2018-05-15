namespace ListaExercicios
{
    partial class Exercicio10
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtanodanascimento = new System.Windows.Forms.TextBox();
            this.txtsuaidade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(106, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Idade";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite seu ano de nascimento";
            // 
            // txtanodanascimento
            // 
            this.txtanodanascimento.Location = new System.Drawing.Point(187, 32);
            this.txtanodanascimento.Name = "txtanodanascimento";
            this.txtanodanascimento.Size = new System.Drawing.Size(100, 20);
            this.txtanodanascimento.TabIndex = 2;
            // 
            // txtsuaidade
            // 
            this.txtsuaidade.Location = new System.Drawing.Point(187, 71);
            this.txtsuaidade.Multiline = true;
            this.txtsuaidade.Name = "txtsuaidade";
            this.txtsuaidade.Size = new System.Drawing.Size(119, 35);
            this.txtsuaidade.TabIndex = 3;
            // 
            // Exercicio10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 482);
            this.Controls.Add(this.txtsuaidade);
            this.Controls.Add(this.txtanodanascimento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Exercicio10";
            this.Text = "Exercicio10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtanodanascimento;
        private System.Windows.Forms.TextBox txtsuaidade;
    }
}