using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


// Caminho base para a pasta de imagens

namespace jogo_cartas
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            imagem1.Image = System.Drawing.Image.FromFile("C:\\Users\\jande\\source\\repos\\Jailtonjjr\\jogo\\Visual Studio 2022\\jogo_cartas\\Imagens\\tras_carta_vermelha.png");
            imagem2.Image = System.Drawing.Image.FromFile("C:\\Users\\jande\\source\\repos\\Jailtonjjr\\jogo\\Visual Studio 2022\\jogo_cartas\\Imagens\\tras_carta_vermelha.png");
            imagem3.Image = System.Drawing.Image.FromFile("C:\\Users\\jande\\source\\repos\\Jailtonjjr\\jogo\\Visual Studio 2022\\jogo_cartas\\Imagens\\tras_carta_vermelha.png");
            imagem4.Image = System.Drawing.Image.FromFile("C:\\Users\\jande\\source\\repos\\Jailtonjjr\\jogo\\Visual Studio 2022\\jogo_cartas\\Imagens\\tras_carta_vermelha.png");
            List<PictureBox> imagens = new List<PictureBox> { imagem1, imagem2, imagem3, imagem4 };
            EmbaralharPosicoes(imagens);
            podeClicar = true;
        }
            List<Point> coordenadas = new List<Point>
            {
            new Point(347, 125),
            new Point(870, 125),
            new Point(618, 125),
            new Point(71, 125)
            };
        int valor_carta_jogador;
        int valor_carta_computador;
        int num1 = 0;
        int num2 = 0;
        bool podeClicar = true;

        

        public void BtnReiniciar_Click(object sender, EventArgs e)
        {
            Derrota.Visible = false;
            Vitoria.Visible = false;
       
            pontuacao_computador.Text = "0";
            pontuacao_jogador.Text = "0";
            num1 = 0;
            num2 = 0;
            imagem1.Image = System.Drawing.Image.FromFile("C:\\Users\\jande\\source\\repos\\Jailtonjjr\\jogo\\Visual Studio 2022\\jogo_cartas\\Imagens\\tras_carta_vermelha.png");
            imagem2.Image = System.Drawing.Image.FromFile("C:\\Users\\jande\\source\\repos\\Jailtonjjr\\jogo\\Visual Studio 2022\\jogo_cartas\\Imagens\\tras_carta_vermelha.png");
            imagem3.Image = System.Drawing.Image.FromFile("C:\\Users\\jande\\source\\repos\\Jailtonjjr\\jogo\\Visual Studio 2022\\jogo_cartas\\Imagens\\tras_carta_vermelha.png");
            imagem4.Image = System.Drawing.Image.FromFile("C:\\Users\\jande\\source\\repos\\Jailtonjjr\\jogo\\Visual Studio 2022\\jogo_cartas\\Imagens\\tras_carta_vermelha.png");

            List<PictureBox> imagens = new List<PictureBox> { imagem1, imagem2, imagem3, imagem4 };
            EmbaralharPosicoes(imagens);
            podeClicar = true;

            foreach (PictureBox pb in imagens)
            {
                pb.Enabled = true;
            }
        }
        public void Proxima_rodada_Click(object sender, EventArgs e)
        {
            if (num1 == 5 || num2 == 5)
            {
                podeClicar = false;
            }
            else
            {
                imagem1.Image = System.Drawing.Image.FromFile("C:\\Users\\jande\\source\\repos\\Jailtonjjr\\jogo\\Visual Studio 2022\\jogo_cartas\\Imagens\\tras_carta_vermelha.png");
                imagem2.Image = System.Drawing.Image.FromFile("C:\\Users\\jande\\source\\repos\\Jailtonjjr\\jogo\\Visual Studio 2022\\jogo_cartas\\Imagens\\tras_carta_vermelha.png");
                imagem3.Image = System.Drawing.Image.FromFile("C:\\Users\\jande\\source\\repos\\Jailtonjjr\\jogo\\Visual Studio 2022\\jogo_cartas\\Imagens\\tras_carta_vermelha.png");
                imagem4.Image = System.Drawing.Image.FromFile("C:\\Users\\jande\\source\\repos\\Jailtonjjr\\jogo\\Visual Studio 2022\\jogo_cartas\\Imagens\\tras_carta_vermelha.png");

                List<PictureBox> imagens = new List<PictureBox> { imagem1, imagem2, imagem3, imagem4 };
                EmbaralharPosicoes(imagens);
                podeClicar = true;

                foreach (PictureBox pb in imagens)
                {
                    pb.Enabled = true;
                }
            }
        }
        public static void EmbaralharPosicoes(List<PictureBox> imagens)
            {
            List<Point> posicoesOriginais = imagens.Select(img => img.Location).ToList();
            Random rnd = new Random();
            posicoesOriginais = posicoesOriginais.OrderBy(x => rnd.Next()).ToList();
                for (int i = 0; i < imagens.Count; i++)
                {
                    imagens[i].Location = posicoesOriginais[i];
                }
            }

        public void Carta_Click(object sender, EventArgs e)
        {
            
            if (!podeClicar)
            {
                return; 
            }
            PictureBox carta = sender as PictureBox;

            if (carta != null)
            {
                podeClicar = false; 

                if (carta == imagem1)
                {
                    carta.Image = System.Drawing.Image.FromFile("C:\\Users\\jande\\source\\repos\\Jailtonjjr\\jogo\\Visual Studio 2022\\jogo_cartas\\Imagens\\AS_copas.jpg");
                    valor_carta_jogador = 1;
                }
                else if (carta == imagem2)
                {
                    carta.Image = System.Drawing.Image.FromFile("C:\\Users\\jande\\source\\repos\\Jailtonjjr\\jogo\\Visual Studio 2022\\jogo_cartas\\Imagens\\rei.jpg");
                    valor_carta_jogador = 2;
                }
                else if (carta == imagem3)
                {
                    carta.Image = System.Drawing.Image.FromFile("C:\\Users\\jande\\source\\repos\\Jailtonjjr\\jogo\\Visual Studio 2022\\jogo_cartas\\Imagens\\dama.jpg");
                    valor_carta_jogador = 3;
                }
                else if (carta == imagem4)
                {
                    carta.Image = System.Drawing.Image.FromFile("C:\\Users\\jande\\source\\repos\\Jailtonjjr\\jogo\\Visual Studio 2022\\jogo_cartas\\Imagens\\valete.jpg");
                    valor_carta_jogador = 4;
                }
            }
                List<PictureBox> imagen = new List<PictureBox> { imagem1, imagem2, imagem3, imagem4 };
                imagen.Remove(carta);

                Random rand = new Random();
                int indice = rand.Next(imagen.Count);
                PictureBox imagemSorteada = imagen[indice];

                if (imagemSorteada == imagem1)
                {
                    imagemSorteada.Image = System.Drawing.Image.FromFile("C:\\Users\\jande\\source\\repos\\Jailtonjjr\\jogo\\Visual Studio 2022\\jogo_cartas\\Imagens\\AS_copas.jpg");
                valor_carta_computador = 1;
                }
                else if (imagemSorteada == imagem2)
                {
                    imagemSorteada.Image = System.Drawing.Image.FromFile("C:\\Users\\jande\\source\\repos\\Jailtonjjr\\jogo\\Visual Studio 2022\\jogo_cartas\\Imagens\\rei.jpg");
                valor_carta_computador = 2;
                }
                else if (imagemSorteada == imagem3)
                {
                    imagemSorteada.Image = System.Drawing.Image.FromFile("C:\\Users\\jande\\source\\repos\\Jailtonjjr\\jogo\\Visual Studio 2022\\jogo_cartas\\Imagens\\dama.jpg");
                valor_carta_computador = 3;
                }
                else if (imagemSorteada == imagem4)
                {
                    imagemSorteada.Image = System.Drawing.Image.FromFile("C:\\Users\\jande\\source\\repos\\Jailtonjjr\\jogo\\Visual Studio 2022\\jogo_cartas\\Imagens\\valete.jpg");
                valor_carta_computador = 4;
                }     
                foreach (PictureBox pb in new List<PictureBox> { imagem1, imagem2, imagem3, imagem4 })
                {
                    if (pb != carta) 
                    {
                        pb.Enabled = false;
                    }
                }
                if(valor_carta_jogador < valor_carta_computador)
                {
                    pontuacao_jogador.Clear();
                    num1++;
                    pontuacao_jogador.Text += num1;
                }
                else
                {
                pontuacao_computador.Clear();
                num2++;
                pontuacao_computador.Text += num2;
                }

                if(num1 >=5 ||  num2 >= 5)
                {

                    if (num1 == 5)
                    {
                    Vitoria.Visible = true;
                    }
                    else {
                        Derrota.Visible = true;
                    }


                    foreach (PictureBox pb in new List<PictureBox> { imagem1, imagem2, imagem3, imagem4 })

                        if (pb != carta)
                        {
                            pb.Enabled = false;
                        }
                }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<PictureBox> imagens = new List<PictureBox> { imagem1, imagem2, imagem3, imagem4 };

            EmbaralharPosicoes(imagens);
            imagem1.Click += Carta_Click;
            imagem2.Click += Carta_Click;
            imagem3.Click += Carta_Click;
            imagem4.Click += Carta_Click;
            btnReiniciar.Click += BtnReiniciar_Click;
            Proxima_rodada.Click += Proxima_rodada_Click;
        }

        
    }
}







        

