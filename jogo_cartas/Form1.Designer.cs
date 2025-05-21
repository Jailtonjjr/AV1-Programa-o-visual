using System.Windows.Forms;

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
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.pontuacao_computador = new System.Windows.Forms.TextBox();
            this.Proxima_rodada = new System.Windows.Forms.Button();
            this.imagem1 = new System.Windows.Forms.PictureBox();
            this.imagem4 = new System.Windows.Forms.PictureBox();
            this.imagem3 = new System.Windows.Forms.PictureBox();
            this.imagem2 = new System.Windows.Forms.PictureBox();
            this.Fundo = new System.Windows.Forms.PictureBox();
            this.Vitoria = new System.Windows.Forms.Label();
            this.Derrota = new System.Windows.Forms.Label();
            this.pontuacao_jogador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fundo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReiniciar.Location = new System.Drawing.Point(65, 57);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(119, 45);
            this.btnReiniciar.TabIndex = 4;
            this.btnReiniciar.Text = "Nova Partida";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            // 
            // pontuacao_computador
            // 
            this.pontuacao_computador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pontuacao_computador.Enabled = false;
            this.pontuacao_computador.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.pontuacao_computador.Location = new System.Drawing.Point(737, 57);
            this.pontuacao_computador.Name = "pontuacao_computador";
            this.pontuacao_computador.Size = new System.Drawing.Size(115, 45);
            this.pontuacao_computador.TabIndex = 8;
            this.pontuacao_computador.Text = "0";
            this.pontuacao_computador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Proxima_rodada
            // 
            this.Proxima_rodada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Proxima_rodada.Location = new System.Drawing.Point(1100, 57);
            this.Proxima_rodada.Name = "Proxima_rodada";
            this.Proxima_rodada.Size = new System.Drawing.Size(119, 45);
            this.Proxima_rodada.TabIndex = 11;
            this.Proxima_rodada.Text = "Proima Rodada";
            this.Proxima_rodada.UseVisualStyleBackColor = true;
            // 
            // imagem1
            // 
            this.imagem1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imagem1.Image = ((System.Drawing.Image)(resources.GetObject("imagem1.Image")));
            this.imagem1.Location = new System.Drawing.Point(45, 243);
            this.imagem1.Name = "imagem1";
            this.imagem1.Size = new System.Drawing.Size(190, 270);
            this.imagem1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagem1.TabIndex = 13;
            this.imagem1.TabStop = false;
            // 
            // imagem4
            // 
            this.imagem4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imagem4.Image = ((System.Drawing.Image)(resources.GetObject("imagem4.Image")));
            this.imagem4.Location = new System.Drawing.Point(1060, 243);
            this.imagem4.Name = "imagem4";
            this.imagem4.Size = new System.Drawing.Size(190, 270);
            this.imagem4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagem4.TabIndex = 14;
            this.imagem4.TabStop = false;
            // 
            // imagem3
            // 
            this.imagem3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imagem3.Image = ((System.Drawing.Image)(resources.GetObject("imagem3.Image")));
            this.imagem3.Location = new System.Drawing.Point(713, 243);
            this.imagem3.Name = "imagem3";
            this.imagem3.Size = new System.Drawing.Size(190, 270);
            this.imagem3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagem3.TabIndex = 15;
            this.imagem3.TabStop = false;
            // 
            // imagem2
            // 
            this.imagem2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imagem2.Image = ((System.Drawing.Image)(resources.GetObject("imagem2.Image")));
            this.imagem2.Location = new System.Drawing.Point(372, 243);
            this.imagem2.Name = "imagem2";
            this.imagem2.Size = new System.Drawing.Size(190, 270);
            this.imagem2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagem2.TabIndex = 16;
            this.imagem2.TabStop = false;
            // 
            // Fundo
            // 
            this.Fundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fundo.Image = ((System.Drawing.Image)(resources.GetObject("Fundo.Image")));
            this.Fundo.Location = new System.Drawing.Point(0, 0);
            this.Fundo.Name = "Fundo";
            this.Fundo.Size = new System.Drawing.Size(1295, 653);
            this.Fundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fundo.TabIndex = 17;
            this.Fundo.TabStop = false;
            // 
            // Vitoria
            // 
            this.Vitoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Vitoria.AutoSize = true;
            this.Vitoria.BackColor = System.Drawing.Color.Transparent;
            this.Vitoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vitoria.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Vitoria.Location = new System.Drawing.Point(455, 118);
            this.Vitoria.Name = "Vitoria";
            this.Vitoria.Size = new System.Drawing.Size(316, 108);
            this.Vitoria.TabIndex = 18;
            this.Vitoria.Text = "Vitoria";
            this.Vitoria.Visible = false;
            // 
            // Derrota
            // 
            this.Derrota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Derrota.AutoSize = true;
            this.Derrota.BackColor = System.Drawing.Color.Transparent;
            this.Derrota.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Derrota.Location = new System.Drawing.Point(455, 118);
            this.Derrota.Name = "Derrota";
            this.Derrota.Size = new System.Drawing.Size(364, 108);
            this.Derrota.TabIndex = 19;
            this.Derrota.Text = "Derrota";
            this.Derrota.Visible = false;
            // 
            // pontuacao_jogador
            // 
            this.pontuacao_jogador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pontuacao_jogador.BackColor = System.Drawing.SystemColors.Window;
            this.pontuacao_jogador.Enabled = false;
            this.pontuacao_jogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.pontuacao_jogador.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pontuacao_jogador.Location = new System.Drawing.Point(424, 56);
            this.pontuacao_jogador.Name = "pontuacao_jogador";
            this.pontuacao_jogador.Size = new System.Drawing.Size(115, 45);
            this.pontuacao_jogador.TabIndex = 7;
            this.pontuacao_jogador.Text = "0";
            this.pontuacao_jogador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Você";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(745, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Adversário";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 653);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Derrota);
            this.Controls.Add(this.Vitoria);
            this.Controls.Add(this.imagem2);
            this.Controls.Add(this.imagem3);
            this.Controls.Add(this.imagem4);
            this.Controls.Add(this.imagem1);
            this.Controls.Add(this.Proxima_rodada);
            this.Controls.Add(this.pontuacao_computador);
            this.Controls.Add(this.pontuacao_jogador);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.Fundo);
            this.MinimumSize = new System.Drawing.Size(1311, 692);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fundo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.TextBox pontuacao_computador;
        private System.Windows.Forms.Button Proxima_rodada;
        private System.Windows.Forms.PictureBox imagem1;
        private System.Windows.Forms.PictureBox imagem4;
        private System.Windows.Forms.PictureBox imagem3;
        private System.Windows.Forms.PictureBox imagem2;
        private System.Windows.Forms.PictureBox Fundo;
        private System.Windows.Forms.Label Vitoria;
        private System.Windows.Forms.Label Derrota;
        private TextBox pontuacao_jogador;
        private Label label1;
        private Label label2;
    }
}

