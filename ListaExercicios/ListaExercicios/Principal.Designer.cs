namespace ListaExercicios
{
    partial class Principal
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
            this.btnExrcicio01 = new System.Windows.Forms.Button();
            this.btnExrcicio02 = new System.Windows.Forms.Button();
            this.btnExrcicio3 = new System.Windows.Forms.Button();
            this.btnExrcicio04 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExrcicio01
            // 
            this.btnExrcicio01.Location = new System.Drawing.Point(12, 12);
            this.btnExrcicio01.Name = "btnExrcicio01";
            this.btnExrcicio01.Size = new System.Drawing.Size(75, 23);
            this.btnExrcicio01.TabIndex = 0;
            this.btnExrcicio01.Text = "Exercicio01";
            this.btnExrcicio01.UseVisualStyleBackColor = true;
            this.btnExrcicio01.Click += new System.EventHandler(this.btnExrcicio01_Click);
            // 
            // btnExrcicio02
            // 
            this.btnExrcicio02.Location = new System.Drawing.Point(12, 55);
            this.btnExrcicio02.Name = "btnExrcicio02";
            this.btnExrcicio02.Size = new System.Drawing.Size(75, 23);
            this.btnExrcicio02.TabIndex = 1;
            this.btnExrcicio02.Text = "Exrcicio2";
            this.btnExrcicio02.UseVisualStyleBackColor = true;
            this.btnExrcicio02.Click += new System.EventHandler(this.btnExrcicio02_Click);
            // 
            // btnExrcicio3
            // 
            this.btnExrcicio3.Location = new System.Drawing.Point(12, 97);
            this.btnExrcicio3.Name = "btnExrcicio3";
            this.btnExrcicio3.Size = new System.Drawing.Size(75, 23);
            this.btnExrcicio3.TabIndex = 2;
            this.btnExrcicio3.Text = "Exrcicio03";
            this.btnExrcicio3.UseVisualStyleBackColor = true;
            this.btnExrcicio3.Click += new System.EventHandler(this.btnExrcicio3_Click);
            // 
            // btnExrcicio04
            // 
            this.btnExrcicio04.Location = new System.Drawing.Point(12, 136);
            this.btnExrcicio04.Name = "btnExrcicio04";
            this.btnExrcicio04.Size = new System.Drawing.Size(75, 23);
            this.btnExrcicio04.TabIndex = 3;
            this.btnExrcicio04.Text = "Exrcicio04";
            this.btnExrcicio04.UseVisualStyleBackColor = true;
            this.btnExrcicio04.Click += new System.EventHandler(this.btnExrcicio04_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnExrcicio04);
            this.Controls.Add(this.btnExrcicio3);
            this.Controls.Add(this.btnExrcicio02);
            this.Controls.Add(this.btnExrcicio01);
            this.Name = "Principal";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExrcicio01;
        private System.Windows.Forms.Button btnExrcicio02;
        private System.Windows.Forms.Button btnExrcicio3;
        private System.Windows.Forms.Button btnExrcicio04;
    }
}