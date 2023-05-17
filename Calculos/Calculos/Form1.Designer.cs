namespace Calculos
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
            this.btnCalcula = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.rbdSomar = new System.Windows.Forms.RadioButton();
            this.rbdSubtrai = new System.Windows.Forms.RadioButton();
            this.rbdMultiplica = new System.Windows.Forms.RadioButton();
            this.rbdDivide = new System.Windows.Forms.RadioButton();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor 2:";
            // 
            // btnCalcula
            // 
            this.btnCalcula.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcula.Location = new System.Drawing.Point(50, 229);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(117, 27);
            this.btnCalcula.TabIndex = 2;
            this.btnCalcula.Text = "Calcular";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(187, 231);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(117, 27);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // rbdSomar
            // 
            this.rbdSomar.AutoSize = true;
            this.rbdSomar.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdSomar.Location = new System.Drawing.Point(379, 84);
            this.rbdSomar.Name = "rbdSomar";
            this.rbdSomar.Size = new System.Drawing.Size(79, 25);
            this.rbdSomar.TabIndex = 4;
            this.rbdSomar.TabStop = true;
            this.rbdSomar.Text = "Soma";
            this.rbdSomar.UseVisualStyleBackColor = true;
            this.rbdSomar.CheckedChanged += new System.EventHandler(this.rbdSomar_CheckedChanged);
            // 
            // rbdSubtrai
            // 
            this.rbdSubtrai.AutoSize = true;
            this.rbdSubtrai.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdSubtrai.Location = new System.Drawing.Point(379, 132);
            this.rbdSubtrai.Name = "rbdSubtrai";
            this.rbdSubtrai.Size = new System.Drawing.Size(118, 25);
            this.rbdSubtrai.TabIndex = 5;
            this.rbdSubtrai.TabStop = true;
            this.rbdSubtrai.Text = "Subtrair";
            this.rbdSubtrai.UseVisualStyleBackColor = true;
            // 
            // rbdMultiplica
            // 
            this.rbdMultiplica.AutoSize = true;
            this.rbdMultiplica.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdMultiplica.Location = new System.Drawing.Point(379, 181);
            this.rbdMultiplica.Name = "rbdMultiplica";
            this.rbdMultiplica.Size = new System.Drawing.Size(145, 25);
            this.rbdMultiplica.TabIndex = 6;
            this.rbdMultiplica.TabStop = true;
            this.rbdMultiplica.Text = "Multiplicar";
            this.rbdMultiplica.UseVisualStyleBackColor = true;
            // 
            // rbdDivide
            // 
            this.rbdDivide.AutoSize = true;
            this.rbdDivide.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdDivide.Location = new System.Drawing.Point(379, 231);
            this.rbdDivide.Name = "rbdDivide";
            this.rbdDivide.Size = new System.Drawing.Size(92, 25);
            this.rbdDivide.TabIndex = 7;
            this.rbdDivide.TabStop = true;
            this.rbdDivide.Text = "Dividir";
            this.rbdDivide.UseVisualStyleBackColor = true;
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(94, 89);
            this.txtValor1.Multiline = true;
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(150, 24);
            this.txtValor1.TabIndex = 8;
            this.txtValor1.TextChanged += new System.EventHandler(this.txtValor1_TextChanged);
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(94, 166);
            this.txtValor2.Multiline = true;
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(150, 24);
            this.txtValor2.TabIndex = 9;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(71, 348);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(115, 21);
            this.lblResult.TabIndex = 10;
            this.lblResult.Text = "Resultado";
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.rbdDivide);
            this.Controls.Add(this.rbdMultiplica);
            this.Controls.Add(this.rbdSubtrai);
            this.Controls.Add(this.rbdSomar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.RadioButton rbdSomar;
        private System.Windows.Forms.RadioButton rbdSubtrai;
        private System.Windows.Forms.RadioButton rbdMultiplica;
        private System.Windows.Forms.RadioButton rbdDivide;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Label lblResult;
    }
}

