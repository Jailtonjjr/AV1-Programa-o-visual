using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogo_cartas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
         InitializeComponent();
            this.BackColor = System.Drawing.Color.LightGreen;
            imagem1.Image = System.Drawing.Image.FromFile("C:\\Users\\jande\\OneDrive\\Documentos\\Visual Studio 2022\\tras_redimencionada.JPG");
            imagem2.Image = System.Drawing.Image.FromFile("C:\\Users\\jande\\OneDrive\\Documentos\\Visual Studio 2022\\tras_redimencionada.JPG");
            imagem3.Image = System.Drawing.Image.FromFile("C:\\Users\\jande\\OneDrive\\Documentos\\Visual Studio 2022\\tras_redimencionada.JPG");
            imagem4.Image = System.Drawing.Image.FromFile("C:\\Users\\jande\\OneDrive\\Documentos\\Visual Studio 2022\\tras_redimencionada.JPG");
        }
        
        // Evento para o clique do botão de reiniciar
        //private void BtnReiniciar_Click(object sender, EventArgs e)
        //{
        //    // Fecha o formulário atual
        //    this.Close();

        //    // Reabre o formulário criando uma nova instância
        //    Form1 novoForm = new Form1();
        //    novoForm.Show();
        //}
        private void BtnReiniciar_Click(object sender, EventArgs e)
        {
            Application.Restart(); // Reinicia toda a aplicação
        }

        public static void coordenadas()
        {
            // As coordenadas possíveis
            List<Point> coordenadas = new List<Point>
            {
            new Point(347, 125),
            new Point(870, 125),
            new Point(618, 125),
            new Point(71, 125)
            };

            // As imagens (simulados como variáveis)
            PictureBox imagem1 = new PictureBox();
            PictureBox imagem2 = new PictureBox();
            PictureBox imagem3 = new PictureBox();
            PictureBox imagem4 = new PictureBox();

            // Lista de imagens
            List<PictureBox> imagens = new List<PictureBox> { imagem1, imagem2, imagem3, imagem4 };

            // Gerar as permutações das posições
            var Numeros = Quantidade(coordenadas);

            // Aplicar cada permutação nas imagens
            foreach (var num in Numeros)
            {
                Console.WriteLine("Nova combinação:");
                for (int i = 0; i < imagens.Count; i++)
                {
                    imagens[i].Location = num[i];
                    Console.WriteLine($"Imagem {i + 1} -> {imagens[i].Location}");
                }
                Console.WriteLine();
            }
        }


        // Método para gerar as permutações de uma lista
        public static List<List<Point>> Quantidade(List<Point> lista)
        {
            var resultado = new List<List<Point>>();
            QuantidadeNumeros(lista, 0, resultado);
            return resultado;
        }

        // Método recursivo para gerar as permutações
        public static void QuantidadeNumeros(List<Point> lista, int indice, List<List<Point>> resultado)
        {
            if (indice == lista.Count)
            {
                resultado.Add(new List<Point>(lista));
            }
            else
            {
                for (int i = indice; i < lista.Count; i++)
                {
                    // Troca os elementos
                    Trocar(lista, indice, i);
                    QuantidadeNumeros(lista, indice + 1, resultado);
                    Trocar(lista, indice, i); // Desfaz a troca para a próxima iteração
                }
            }
        }


        // Método para trocar os elementos da lista
        public static void Trocar(List<Point> lista, int i, int j)
        {
            Point temp = lista[i];
            lista[i] = lista[j];
            lista[j] = temp;
        }
        private void imagem1_Click(object sender, EventArgs e)
        {
            // Troca a imagem ao clicar
            imagem1.Image = System.Drawing.Image.FromFile("C:\\Users\\jande\\OneDrive\\Documentos\\Visual Studio 2022\\As_de_espadas.JPG");
        }
        private void imagem2_Click(object sender, EventArgs e)
        {
            // Troca a imagem ao clicar
            imagem2.Image = System.Drawing.Image.FromFile("C:\\Users\\jande\\OneDrive\\Documentos\\Visual Studio 2022\\Rainha_de_espadas.JPG");
        }
        private void imagem3_Click(object sender, EventArgs e)
        {
            // Troca a imagem ao clicar
            imagem3.Image = System.Drawing.Image.FromFile("C:\\Users\\jande\\OneDrive\\Documentos\\Visual Studio 2022\\Rei_de_espadas.JPG");
        }
        private void imagem4_Click(object sender, EventArgs e)
        {
            // Troca a imagem ao clicar
            imagem4.Image = System.Drawing.Image.FromFile("C:\\Users\\jande\\OneDrive\\Documentos\\Visual Studio 2022\\Valete_de_espadas.JPG");
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
    }
}







        

