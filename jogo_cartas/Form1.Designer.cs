namespace jogo_cartas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imagem1 = new System.Windows.Forms.PictureBox();
            this.imagem2 = new System.Windows.Forms.PictureBox();
            this.imagem3 = new System.Windows.Forms.PictureBox();
            this.imagem4 = new System.Windows.Forms.PictureBox();
            this.btnReiniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagem4)).BeginInit();
            this.SuspendLayout();
            // 
            // imagem1
            // 
            this.imagem1.Image = ((System.Drawing.Image)(resources.GetObject("imagem1.Image")));
            this.imagem1.Location = new System.Drawing.Point(71, 125);
            this.imagem1.Name = "imagem1";
            this.imagem1.Size = new System.Drawing.Size(196, 289);
            this.imagem1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imagem1.TabIndex = 0;
            this.imagem1.TabStop = false;
            this.imagem1.Click += imagem1_Click;
            // 
            // imagem2
            // 
            this.imagem2.Image = ((System.Drawing.Image)(resources.GetObject("imagem2.Image")));
            this.imagem2.Location = new System.Drawing.Point(347, 125);
            this.imagem2.Name = "imagem2";
            this.imagem2.Size = new System.Drawing.Size(196, 289);
            this.imagem2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imagem2.TabIndex = 1;
            this.imagem2.TabStop = false;
            this.imagem2.Click += imagem2_Click;
            // 
            // imagem3
            // 
            this.imagem3.Image = ((System.Drawing.Image)(resources.GetObject("imagem3.Image")));
            this.imagem3.Location = new System.Drawing.Point(618, 125);
            this.imagem3.Name = "imagem3";
            this.imagem3.Size = new System.Drawing.Size(196, 289);
            this.imagem3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imagem3.TabIndex = 2;
            this.imagem3.TabStop = false;
            this.imagem3.Click += imagem3_Click;
            // 
            // imagem4
            // 
            this.imagem4.Image = ((System.Drawing.Image)(resources.GetObject("imagem4.Image")));
            this.imagem4.Location = new System.Drawing.Point(870, 125);
            this.imagem4.Name = "imagem4";
            this.imagem4.Size = new System.Drawing.Size(196, 289);
            this.imagem4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imagem4.TabIndex = 3;
            this.imagem4.TabStop = false;
            this.imagem4.Click += imagem4_Click;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(944, 25);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(113, 41);
            this.btnReiniciar.TabIndex = 4;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            btnReiniciar.Click += BtnReiniciar_Click;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 574);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.imagem4);
            this.Controls.Add(this.imagem3);
            this.Controls.Add(this.imagem2);
            this.Controls.Add(this.imagem1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagem4)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.PictureBox imagem1;
        private System.Windows.Forms.PictureBox imagem2;
        private System.Windows.Forms.PictureBox imagem3;
        private System.Windows.Forms.PictureBox imagem4;
        private System.Windows.Forms.Button btnReiniciar;
    }
}

