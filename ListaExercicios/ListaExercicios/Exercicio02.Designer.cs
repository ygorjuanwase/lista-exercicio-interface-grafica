namespace ListaExercicios
{
    partial class Exercicio02
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
            this.lbQuantidadedeLitros = new System.Windows.Forms.Label();
            this.txtQuantidadeLitros = new System.Windows.Forms.TextBox();
            this.txtAnosConsumidos = new System.Windows.Forms.TextBox();
            this.txtvalorporLitro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbvalorporLitro = new System.Windows.Forms.Label();
            this.lbAnosConsumidos = new System.Windows.Forms.Label();
            this.txtResultado1 = new System.Windows.Forms.TextBox();
            this.btnresultado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbQuantidadedeLitros
            // 
            this.lbQuantidadedeLitros.AutoSize = true;
            this.lbQuantidadedeLitros.Location = new System.Drawing.Point(27, 13);
            this.lbQuantidadedeLitros.Name = "lbQuantidadedeLitros";
            this.lbQuantidadedeLitros.Size = new System.Drawing.Size(104, 13);
            this.lbQuantidadedeLitros.TabIndex = 0;
            this.lbQuantidadedeLitros.Text = "Quantidade de litros ";
            // 
            // txtQuantidadeLitros
            // 
            this.txtQuantidadeLitros.Location = new System.Drawing.Point(137, 13);
            this.txtQuantidadeLitros.Name = "txtQuantidadeLitros";
            this.txtQuantidadeLitros.Size = new System.Drawing.Size(171, 20);
            this.txtQuantidadeLitros.TabIndex = 1;
            // 
            // txtAnosConsumidos
            // 
            this.txtAnosConsumidos.Location = new System.Drawing.Point(137, 48);
            this.txtAnosConsumidos.Multiline = true;
            this.txtAnosConsumidos.Name = "txtAnosConsumidos";
            this.txtAnosConsumidos.Size = new System.Drawing.Size(171, 22);
            this.txtAnosConsumidos.TabIndex = 2;
            // 
            // txtvalorporLitro
            // 
            this.txtvalorporLitro.Location = new System.Drawing.Point(137, 91);
            this.txtvalorporLitro.Name = "txtvalorporLitro";
            this.txtvalorporLitro.Size = new System.Drawing.Size(171, 20);
            this.txtvalorporLitro.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // lbvalorporLitro
            // 
            this.lbvalorporLitro.AutoSize = true;
            this.lbvalorporLitro.Location = new System.Drawing.Point(53, 91);
            this.lbvalorporLitro.Name = "lbvalorporLitro";
            this.lbvalorporLitro.Size = new System.Drawing.Size(68, 13);
            this.lbvalorporLitro.TabIndex = 6;
            this.lbvalorporLitro.Text = "Valor por litro";
            // 
            // lbAnosConsumidos
            // 
            this.lbAnosConsumidos.AutoSize = true;
            this.lbAnosConsumidos.Location = new System.Drawing.Point(37, 48);
            this.lbAnosConsumidos.Name = "lbAnosConsumidos";
            this.lbAnosConsumidos.Size = new System.Drawing.Size(84, 13);
            this.lbAnosConsumidos.TabIndex = 7;
            this.lbAnosConsumidos.Text = "Anos cosumidos";
            // 
            // txtResultado1
            // 
            this.txtResultado1.Location = new System.Drawing.Point(137, 134);
            this.txtResultado1.Multiline = true;
            this.txtResultado1.Name = "txtResultado1";
            this.txtResultado1.Size = new System.Drawing.Size(171, 85);
            this.txtResultado1.TabIndex = 8;
            // 
            // btnresultado
            // 
            this.btnresultado.Location = new System.Drawing.Point(56, 134);
            this.btnresultado.Name = "btnresultado";
            this.btnresultado.Size = new System.Drawing.Size(75, 53);
            this.btnresultado.TabIndex = 9;
            this.btnresultado.Text = "Mostrar Resultado";
            this.btnresultado.UseVisualStyleBackColor = true;
            this.btnresultado.Click += new System.EventHandler(this.btnresultado_Click);
            // 
            // Exercicio02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 377);
            this.Controls.Add(this.btnresultado);
            this.Controls.Add(this.txtResultado1);
            this.Controls.Add(this.lbAnosConsumidos);
            this.Controls.Add(this.lbvalorporLitro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtvalorporLitro);
            this.Controls.Add(this.txtAnosConsumidos);
            this.Controls.Add(this.txtQuantidadeLitros);
            this.Controls.Add(this.lbQuantidadedeLitros);
            this.Name = "Exercicio02";
            this.Text = "Exercicio02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbQuantidadedeLitros;
        private System.Windows.Forms.TextBox txtQuantidadeLitros;
        private System.Windows.Forms.TextBox txtAnosConsumidos;
        private System.Windows.Forms.TextBox txtvalorporLitro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbvalorporLitro;
        private System.Windows.Forms.Label lbAnosConsumidos;
        private System.Windows.Forms.TextBox txtResultado1;
        private System.Windows.Forms.Button btnresultado;
    }
}