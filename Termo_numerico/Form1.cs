using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Termo_numerico
{
    public partial class Form1 : Form
    {
        int[] numeros = new int[30];
        int[] respostaCorreta = new int[5];
        Random random = new Random();
        int valorbloco;
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 5; i++)
                respostaCorreta[i] = random.Next(0, 10);

            for (int i = 0; i < 30; i++)
            {
                TextBox bloco = this.Controls.Find($"bloco{i + 1}", true).FirstOrDefault() as TextBox;
                if (bloco != null)
                {
                    bloco.KeyDown += Bloco_KeyDown;
                    bloco.KeyPress += Bloco_KeyPress;
                    bloco.TextChanged += Bloco_TextChanged;
                    bloco.Tag = i;
                }
            }
        }
        private void NovaPartida_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
                respostaCorreta[i] = random.Next(0, 10);
            for (int i = 0; i < 30; i++)
            {
                TextBox bloco = this.Controls.Find($"bloco{i + 1}", true).FirstOrDefault() as TextBox;
                if (bloco != null)
                {
                    bloco.Text = "";
                    bloco.BackColor = SystemColors.Window;
                    bloco.ReadOnly = true;
                }
            }

            // Ativa apenas a primeira linha
            tentativaAtual = 0;
            AtivarLinhaAtual();
        }
            
        
        int tentativaAtual = 0;

        private void Bloco_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            if (!char.IsControl(e.KeyChar) && tb.Text.Length >= 1 && tb.SelectionLength == 0)
            {
                e.Handled = true;
            }
        }

        private void Bloco_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            int index = (int)tb.Tag;

            if (int.TryParse(tb.Text, out int valor))
            {
                numeros[index] = valor;
            }
            else
            {
                numeros[index] = -1;
            }
            valorbloco = valor;
        }

        private void Bloco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                VerificarEntrada();
            }
        }

        private void VerificarEntrada()
        {
            int inicio = tentativaAtual * 5;
            bool[] usadosResposta = new bool[5]; 
            bool[] usadosTentativa = new bool[5]; 

            
            for (int i = 0; i < 5; i++)
            {
                int index = inicio + i;
                TextBox bloco = this.Controls.Find($"bloco{index + 1}", true).FirstOrDefault() as TextBox;

                if (bloco != null)
                {
                    if (numeros[index] == respostaCorreta[i])
                    {
                        bloco.BackColor = Color.Green;
                        usadosResposta[i] = true;
                        usadosTentativa[i] = true;
                    }
                }
            }

            
            for (int i = 0; i < 5; i++)
            {
                int index = inicio + i;
                TextBox bloco = this.Controls.Find($"bloco{index + 1}", true).FirstOrDefault() as TextBox;

                if (bloco != null && !usadosTentativa[i])
                {
                    bool achou = false;
                    for (int j = 0; j < 5; j++)
                    {
                        if (!usadosResposta[j] && numeros[index] == respostaCorreta[j])
                        {
                            bloco.BackColor = Color.Yellow;
                            usadosResposta[j] = true;
                            achou = true;
                            break;
                        }
                    }

                    if (!achou)
                    {
                        bloco.BackColor = Color.Red;
                    }
                }

                
                if (bloco != null)
                {
                    bloco.ReadOnly = true;
                }
            }

            tentativaAtual++;

            if (tentativaAtual < 6)
            {
                AtivarLinhaAtual();
            }

        }
        private void AtivarLinhaAtual()
        {
            for (int i = 0; i < 30; i++)
            {
                TextBox bloco = this.Controls.Find($"bloco{i + 1}", true).FirstOrDefault() as TextBox;
                if (bloco != null)
                {
                    bloco.ReadOnly = !(i >= tentativaAtual * 5 && i < (tentativaAtual + 1) * 5);
                }
            }
        }

        
    }
}