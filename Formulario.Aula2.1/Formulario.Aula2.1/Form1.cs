using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario.Aula2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Limpar_Click(object sender, EventArgs e)
        {
            textBox_Titulo.Text= string.Empty;
            textBox_Genero.Text= string.Empty;
            textBox_Ano.Text= string.Empty;
            textBox_Avaliacao.Text= string.Empty;

            label_Cadastrado.Text= string.Empty;
            pictureBox1.Visible=false;

            label_Titulo.Text = string.Empty;
            label_Genero.Text = string.Empty;
            label_Ano.Text = string.Empty;
            label_Avaliacao.Text = string.Empty;

        }

        private void textBox_Titulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Cadastrar_Click(object sender, EventArgs e)
        {
            string tituloFilme = "";
            string generoFilme = "";
            int anoFilme;
            int AvaliacaoFilme;

            tituloFilme = textBox_Titulo.Text;
            generoFilme = textBox_Genero.Text;
            anoFilme = int.Parse(textBox_Ano.Text);
            AvaliacaoFilme = int.Parse(textBox_Avaliacao.Text);

            label_Titulo.Text = tituloFilme;
            label_Genero.Text = generoFilme;
            label_Ano.Text = anoFilme.ToString();
            label_Avaliacao.Text = AvaliacaoFilme.ToString();

            label_Cadastrado.Visible = true;
            pictureBox1.Visible = true;
            
        }
    }
}
