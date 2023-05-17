namespace ProjetoSom
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
            this.btnMediaPlayer = new System.Windows.Forms.Button();
            this.btnSomJogo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMediaPlayer
            // 
            this.btnMediaPlayer.Location = new System.Drawing.Point(118, 38);
            this.btnMediaPlayer.Name = "btnMediaPlayer";
            this.btnMediaPlayer.Size = new System.Drawing.Size(248, 60);
            this.btnMediaPlayer.TabIndex = 0;
            this.btnMediaPlayer.Text = "MediaPlayer";
            this.btnMediaPlayer.UseVisualStyleBackColor = true;
            this.btnMediaPlayer.Click += new System.EventHandler(this.btnMediaPlayer_Click);
            // 
            // btnSomJogo
            // 
            this.btnSomJogo.Location = new System.Drawing.Point(118, 123);
            this.btnSomJogo.Name = "btnSomJogo";
            this.btnSomJogo.Size = new System.Drawing.Size(248, 60);
            this.btnSomJogo.TabIndex = 1;
            this.btnSomJogo.Text = "Som Jogos";
            this.btnSomJogo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSomJogo);
            this.Controls.Add(this.btnMediaPlayer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMediaPlayer;
        private System.Windows.Forms.Button btnSomJogo;
    }
}

