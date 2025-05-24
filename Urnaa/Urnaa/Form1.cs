using Microsoft.VisualBasic.ApplicationServices;
using System.Media;
using Urnaa.Properties;

namespace Urnaa
{

    public partial class Form1 : Form
    {
        private Dictionary<string, Candidato> _dicCandidato;
        public Form1()
        {
            InitializeComponent();
            panelFim.Visible = false;


            _dicCandidato = new Dictionary<string, Candidato>();
            _dicCandidato.Add("02", new Candidato() { Id = 02, Nome = "Jimmy Tong", Partido = "Terno", Foto = Properties.Resources.Jimmy});
            _dicCandidato.Add("98", new Candidato() { Id = 98, Nome = "Insperto Lee", Partido = "Rush", Foto = Properties.Resources.Lee });
            _dicCandidato.Add("10", new Candidato() { Id = 10, Nome = "Mr. Han", Partido = "Karatê", Foto = Properties.Resources.Han});


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numeroUm_Click(object sender, EventArgs e)
        {
            RegistrarDigito("1");
        }

        private void numeroDois_Click(object sender, EventArgs e)
        {
            RegistrarDigito("2");
        }

        private void numeroTres_Click(object sender, EventArgs e)
        {
            RegistrarDigito("3");
        }

        private void numeroQuatro_Click(object sender, EventArgs e)
        {
            RegistrarDigito("4");
        }

        private void numeroCinco_Click(object sender, EventArgs e)
        {
            RegistrarDigito("5");
        }

        private void numeroSeis_Click(object sender, EventArgs e)
        {
            RegistrarDigito("6");
        }

        private void numeroSete_Click(object sender, EventArgs e)
        {
            RegistrarDigito("7");
        }

        private void numeroOito_Click(object sender, EventArgs e)
        {
            RegistrarDigito("8");
        }

        private void numeroNove_Click(object sender, EventArgs e)
        {
            RegistrarDigito("9");
        }

        private void numeroZero_Click(object sender, EventArgs e)
        {
            RegistrarDigito("0");
        }

        private void botaoBranco_Click(object sender, EventArgs e)
        {
            panelFim.Visible = true;
            Limpar();

            relogio.Tick += new EventHandler(AcaoFinal);
            relogio.Interval = 3000;
            relogio.Enabled = true;
            relogio.Start();
        }

        private void botaoCorrige_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void botaoConfirma_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textPresidente1.Text))
            {
                MessageBox.Show("Favor informar o candidato.");

            }

            panelFim.Visible = true;
            Limpar();

            relogio.Tick += new EventHandler(AcaoFinal);
            relogio.Interval = 3000;
            relogio.Enabled = true;
            relogio.Start();

        }
        private void RegistrarDigito(string digito)
        {
            if (string.IsNullOrEmpty(textPresidente1.Text))
                textPresidente1.Text = digito;
            else
            {
                textPresidente2.Text = digito;
                PreencherCandidato(textPresidente1.Text, textPresidente2.Text);
            }
        }

        private void PreencherCandidato(string d1, string d2)
        {
            if (_dicCandidato.ContainsKey(d1 + d2))
            {
                labelNome.Text = _dicCandidato[d1 + d2].Nome;
                labelPartido.Text = _dicCandidato[d1 + d2].Partido;
                fotoPresidente.Image = _dicCandidato[d1 + d2].Foto;

            }
            else
            {
                MessageBox.Show("Candidato não encontrado!");
            }
        }

        private void textPresidente1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPresidente2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AcaoFinal(Object myObject, EventArgs myEventArgs)
        {
            relogio.Stop();
            relogio.Enabled = false;
            panelFim.Visible = false;
        }
        private void Limpar()
        {
            textPresidente1.Text = "";
            textPresidente2.Text = "";
            labelNome.Text = String.Empty;
            labelPartido.Text = String.Empty;
            fotoPresidente.Image = null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void labelPartido_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
    }

    public class Candidato
        {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Partido { get; set; }
        public Image Foto { get; set; }
        }
}
