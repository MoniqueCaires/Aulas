namespace HelloWorld
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txbNumero1 = new System.Windows.Forms.TextBox();
            this.txbNumero2 = new System.Windows.Forms.TextBox();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnDivisão = new System.Windows.Forms.Button();
            this.btnMultiplicação = new System.Windows.Forms.Button();
            this.Menor_Maior = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNumero3 = new System.Windows.Forms.TextBox();
            this.btnmaiormenor = new System.Windows.Forms.Button();
            this.lbResultado2 = new System.Windows.Forms.Label();
            this.btnImparPar = new System.Windows.Forms.Button();
            this.lbResultado3 = new System.Windows.Forms.Label();
            this.lbimparpar = new System.Windows.Forms.Label();
            this.txbpar1 = new System.Windows.Forms.TextBox();
            this.Menor_Maior.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(286, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(388, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero 2";
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.ForeColor = System.Drawing.Color.White;
            this.lbResultado.Location = new System.Drawing.Point(282, 162);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(55, 13);
            this.lbResultado.TabIndex = 2;
            this.lbResultado.Text = "Resultado";
            // 
            // btnCalcular
            // 
            this.btnCalcular.ForeColor = System.Drawing.Color.Black;
            this.btnCalcular.Location = new System.Drawing.Point(266, 211);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(110, 49);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txbNumero1
            // 
            this.txbNumero1.Location = new System.Drawing.Point(285, 105);
            this.txbNumero1.Name = "txbNumero1";
            this.txbNumero1.Size = new System.Drawing.Size(54, 20);
            this.txbNumero1.TabIndex = 4;
            // 
            // txbNumero2
            // 
            this.txbNumero2.Location = new System.Drawing.Point(391, 105);
            this.txbNumero2.Name = "txbNumero2";
            this.txbNumero2.Size = new System.Drawing.Size(61, 20);
            this.txbNumero2.TabIndex = 5;
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.ForeColor = System.Drawing.Color.Black;
            this.btnSubtrair.Location = new System.Drawing.Point(409, 211);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(117, 49);
            this.btnSubtrair.TabIndex = 6;
            this.btnSubtrair.Text = "Subtrair";
            this.btnSubtrair.UseVisualStyleBackColor = true;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // btnDivisão
            // 
            this.btnDivisão.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivisão.ForeColor = System.Drawing.Color.Black;
            this.btnDivisão.Location = new System.Drawing.Point(266, 266);
            this.btnDivisão.Name = "btnDivisão";
            this.btnDivisão.Size = new System.Drawing.Size(110, 50);
            this.btnDivisão.TabIndex = 7;
            this.btnDivisão.Text = "Divisão";
            this.btnDivisão.UseVisualStyleBackColor = true;
            this.btnDivisão.Click += new System.EventHandler(this.btnDivisão_Click);
            // 
            // btnMultiplicação
            // 
            this.btnMultiplicação.ForeColor = System.Drawing.Color.Black;
            this.btnMultiplicação.Location = new System.Drawing.Point(409, 266);
            this.btnMultiplicação.Name = "btnMultiplicação";
            this.btnMultiplicação.Size = new System.Drawing.Size(117, 50);
            this.btnMultiplicação.TabIndex = 8;
            this.btnMultiplicação.Text = "Multilicação";
            this.btnMultiplicação.UseVisualStyleBackColor = true;
            this.btnMultiplicação.Click += new System.EventHandler(this.btnMultiplicação_Click);
            // 
            // Menor_Maior
            // 
            this.Menor_Maior.Controls.Add(this.lbResultado);
            this.Menor_Maior.Controls.Add(this.txbNumero2);
            this.Menor_Maior.Controls.Add(this.label1);
            this.Menor_Maior.Controls.Add(this.label2);
            this.Menor_Maior.Controls.Add(this.btnSubtrair);
            this.Menor_Maior.Controls.Add(this.txbNumero1);
            this.Menor_Maior.Controls.Add(this.btnDivisão);
            this.Menor_Maior.Controls.Add(this.btnCalcular);
            this.Menor_Maior.Controls.Add(this.btnMultiplicação);
            this.Menor_Maior.Controls.Add(this.txbpar1);
            this.Menor_Maior.Controls.Add(this.lbimparpar);
            this.Menor_Maior.Controls.Add(this.lbResultado3);
            this.Menor_Maior.Controls.Add(this.btnImparPar);
            this.Menor_Maior.Controls.Add(this.lbResultado2);
            this.Menor_Maior.Controls.Add(this.btnmaiormenor);
            this.Menor_Maior.Controls.Add(this.txbNumero3);
            this.Menor_Maior.Controls.Add(this.label3);
            this.Menor_Maior.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menor_Maior.ForeColor = System.Drawing.Color.White;
            this.Menor_Maior.Location = new System.Drawing.Point(12, 25);
            this.Menor_Maior.Name = "Menor_Maior";
            this.Menor_Maior.Size = new System.Drawing.Size(561, 403);
            this.Menor_Maior.TabIndex = 9;
            this.Menor_Maior.TabStop = false;
            this.Menor_Maior.Text = "Monique";
            this.Menor_Maior.Enter += new System.EventHandler(this.Menor_Maior_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Digite um numero:";
            // 
            // txbNumero3
            // 
            this.txbNumero3.Location = new System.Drawing.Point(29, 60);
            this.txbNumero3.Name = "txbNumero3";
            this.txbNumero3.Size = new System.Drawing.Size(139, 20);
            this.txbNumero3.TabIndex = 1;
            // 
            // btnmaiormenor
            // 
            this.btnmaiormenor.ForeColor = System.Drawing.Color.Black;
            this.btnmaiormenor.Location = new System.Drawing.Point(29, 128);
            this.btnmaiormenor.Name = "btnmaiormenor";
            this.btnmaiormenor.Size = new System.Drawing.Size(82, 56);
            this.btnmaiormenor.TabIndex = 2;
            this.btnmaiormenor.Text = "Menor Maior";
            this.btnmaiormenor.UseVisualStyleBackColor = true;
            this.btnmaiormenor.Click += new System.EventHandler(this.btnmaiormenor_Click);
            // 
            // lbResultado2
            // 
            this.lbResultado2.AutoSize = true;
            this.lbResultado2.Location = new System.Drawing.Point(26, 96);
            this.lbResultado2.Name = "lbResultado2";
            this.lbResultado2.Size = new System.Drawing.Size(67, 13);
            this.lbResultado2.TabIndex = 3;
            this.lbResultado2.Text = "Resultado M";
            // 
            // btnImparPar
            // 
            this.btnImparPar.ForeColor = System.Drawing.Color.Black;
            this.btnImparPar.Location = new System.Drawing.Point(40, 332);
            this.btnImparPar.Name = "btnImparPar";
            this.btnImparPar.Size = new System.Drawing.Size(85, 56);
            this.btnImparPar.TabIndex = 4;
            this.btnImparPar.Text = "Impar ou Par";
            this.btnImparPar.UseVisualStyleBackColor = true;
            this.btnImparPar.Click += new System.EventHandler(this.btnImparPar_Click);
            // 
            // lbResultado3
            // 
            this.lbResultado3.AutoSize = true;
            this.lbResultado3.Location = new System.Drawing.Point(37, 303);
            this.lbResultado3.Name = "lbResultado3";
            this.lbResultado3.Size = new System.Drawing.Size(61, 13);
            this.lbResultado3.TabIndex = 5;
            this.lbResultado3.Text = "Resultado I";
            // 
            // lbimparpar
            // 
            this.lbimparpar.AutoSize = true;
            this.lbimparpar.Location = new System.Drawing.Point(51, 231);
            this.lbimparpar.Name = "lbimparpar";
            this.lbimparpar.Size = new System.Drawing.Size(92, 13);
            this.lbimparpar.TabIndex = 6;
            this.lbimparpar.Text = "Digite um número:";
            // 
            // txbpar1
            // 
            this.txbpar1.Location = new System.Drawing.Point(40, 256);
            this.txbpar1.Name = "txbpar1";
            this.txbpar1.Size = new System.Drawing.Size(143, 20);
            this.txbpar1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Menor_Maior);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Menor_Maior.ResumeLayout(false);
            this.Menor_Maior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txbNumero1;
        private System.Windows.Forms.TextBox txbNumero2;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnDivisão;
        private System.Windows.Forms.Button btnMultiplicação;
        private System.Windows.Forms.GroupBox Menor_Maior;
        private System.Windows.Forms.Button btnmaiormenor;
        private System.Windows.Forms.TextBox txbNumero3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbResultado2;
        private System.Windows.Forms.Label lbResultado3;
        private System.Windows.Forms.Button btnImparPar;
        private System.Windows.Forms.TextBox txbpar1;
        private System.Windows.Forms.Label lbimparpar;
    }
}

