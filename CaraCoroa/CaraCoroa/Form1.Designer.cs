
namespace CaraCoroa
{
    partial class Form1
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
            this.rdbCara = new System.Windows.Forms.RadioButton();
            this.rdbCoroa = new System.Windows.Forms.RadioButton();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.ptbMoeda = new System.Windows.Forms.PictureBox();
            this.ptbComputador = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTema = new System.Windows.Forms.ComboBox();
            this.btnAplicar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMoeda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbComputador)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbCara
            // 
            this.rdbCara.AutoSize = true;
            this.rdbCara.BackColor = System.Drawing.Color.Transparent;
            this.rdbCara.Location = new System.Drawing.Point(119, 262);
            this.rdbCara.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rdbCara.Name = "rdbCara";
            this.rdbCara.Size = new System.Drawing.Size(75, 27);
            this.rdbCara.TabIndex = 0;
            this.rdbCara.Text = "Cara";
            this.rdbCara.UseVisualStyleBackColor = false;
            this.rdbCara.CheckedChanged += new System.EventHandler(this.rdbCara_CheckedChanged);
            // 
            // rdbCoroa
            // 
            this.rdbCoroa.AutoSize = true;
            this.rdbCoroa.Location = new System.Drawing.Point(223, 262);
            this.rdbCoroa.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rdbCoroa.Name = "rdbCoroa";
            this.rdbCoroa.Size = new System.Drawing.Size(86, 27);
            this.rdbCoroa.TabIndex = 1;
            this.rdbCoroa.Text = "Coroa";
            this.rdbCoroa.UseVisualStyleBackColor = true;
            this.rdbCoroa.CheckedChanged += new System.EventHandler(this.rdbCoroa_CheckedChanged);
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(23, 297);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(171, 38);
            this.btnVerificar.TabIndex = 2;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // ptbMoeda
            // 
            this.ptbMoeda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbMoeda.Location = new System.Drawing.Point(23, 111);
            this.ptbMoeda.Name = "ptbMoeda";
            this.ptbMoeda.Size = new System.Drawing.Size(171, 143);
            this.ptbMoeda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMoeda.TabIndex = 3;
            this.ptbMoeda.TabStop = false;
            this.ptbMoeda.Click += new System.EventHandler(this.ptbMoeda_Click);
            // 
            // ptbComputador
            // 
            this.ptbComputador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbComputador.Location = new System.Drawing.Point(219, 111);
            this.ptbComputador.Name = "ptbComputador";
            this.ptbComputador.Size = new System.Drawing.Size(171, 143);
            this.ptbComputador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbComputador.TabIndex = 4;
            this.ptbComputador.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "JOGADOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "COMPUTADOR";
            // 
            // lblMensagem
            // 
            this.lblMensagem.BackColor = System.Drawing.Color.Maroon;
            this.lblMensagem.ForeColor = System.Drawing.Color.White;
            this.lblMensagem.Location = new System.Drawing.Point(23, 350);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(367, 33);
            this.lblMensagem.TabIndex = 7;
            this.lblMensagem.Text = "-";
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(200, 297);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(171, 38);
            this.btnNovo.TabIndex = 8;
            this.btnNovo.Text = "Novo Jogo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tema:";
            // 
            // cmbTema
            // 
            this.cmbTema.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTema.FormattingEnabled = true;
            this.cmbTema.Items.AddRange(new object[] {
            "Amarelo",
            "Vermelho",
            "Preto"});
            this.cmbTema.Location = new System.Drawing.Point(17, 28);
            this.cmbTema.Name = "cmbTema";
            this.cmbTema.Size = new System.Drawing.Size(278, 27);
            this.cmbTema.TabIndex = 10;
            // 
            // btnAplicar
            // 
            this.btnAplicar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicar.Location = new System.Drawing.Point(301, 24);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(83, 33);
            this.btnAplicar.TabIndex = 11;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 415);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.cmbTema);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptbComputador);
            this.Controls.Add(this.ptbMoeda);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.rdbCoroa);
            this.Controls.Add(this.rdbCara);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ptbMoeda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbComputador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbCara;
        private System.Windows.Forms.RadioButton rdbCoroa;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.PictureBox ptbMoeda;
        private System.Windows.Forms.PictureBox ptbComputador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTema;
        private System.Windows.Forms.Button btnAplicar;
    }
}

