using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario.Aula._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            string nomeCliente = "";
            string sobrenomeCliente = "";
            int idadeCliente;
            string emailCliente = "";
            nomeCliente = textBoxNome.Text;
            sobrenomeCliente = textBoxSobrenome.Text;
            idadeCliente = int.Parse(textBoxIdade.Text);
            emailCliente = textBoxEmail.Text;

            //MessageBox.Show("Nome Completo: " + nomeCliente + " " + sobrenomeCliente + "\nIdade: " + idadeCliente + "\nEmail: " + emailCliente);

            labelnome.Text = nomeCliente;
            labelsobrenome.Text = sobrenomeCliente;

            labelidade.Text = idadeCliente.ToString();
            labelemail.Text = emailCliente;
        }

        private void labelidade_Click(object sender, EventArgs e)
        {

        }

        private void labelsobrenome_Click(object sender, EventArgs e)
        {

        }

        private void labelnome_Click(object sender, EventArgs e)
        {

        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelemail_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxIdade_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSobrenome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
