namespace ListaExercicios
{
    partial class Exercicio01
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
            this.lbNumero = new System.Windows.Forms.Label();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.btnmostrarResutado = new System.Windows.Forms.Button();
            this.lbantsuc = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumero.Location = new System.Drawing.Point(35, 23);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(122, 16);
            this.lbNumero.TabIndex = 0;
            this.lbNumero.Text = "Escolha um Numero";
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(177, 67);
            this.txtresultado.Multiline = true;
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(157, 77);
            this.txtresultado.TabIndex = 2;
            this.txtresultado.Text = " ";
            // 
            // btnmostrarResutado
            // 
            this.btnmostrarResutado.Location = new System.Drawing.Point(356, 46);
            this.btnmostrarResutado.Name = "btnmostrarResutado";
            this.btnmostrarResutado.Size = new System.Drawing.Size(122, 23);
            this.btnmostrarResutado.TabIndex = 3;
            this.btnmostrarResutado.Text = "Mostrar";
            this.btnmostrarResutado.UseVisualStyleBackColor = true;
            this.btnmostrarResutado.Click += new System.EventHandler(this.btResutado_Click);
            // 
            // lbantsuc
            // 
            this.lbantsuc.AutoSize = true;
            this.lbantsuc.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbantsuc.Location = new System.Drawing.Point(19, 80);
            this.lbantsuc.Name = "lbantsuc";
            this.lbantsuc.Size = new System.Drawing.Size(138, 14);
            this.lbantsuc.TabIndex = 4;
            this.lbantsuc.Text = "O Antecessor e Sucessor";
            this.lbantsuc.Click += new System.EventHandler(this.lbResultaod_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(177, 12);
            this.txtNumero.Multiline = true;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(124, 33);
            this.txtNumero.TabIndex = 5;
            this.txtNumero.Text = " ";
            // 
            // Exercicio01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 615);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lbantsuc);
            this.Controls.Add(this.btnmostrarResutado);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.lbNumero);
            this.Name = "Exercicio01";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button btnmostrarResutado;
        private System.Windows.Forms.Label lbantsuc;
        private System.Windows.Forms.TextBox txtNumero;
    }
}

