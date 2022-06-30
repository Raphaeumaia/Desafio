using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pibImagem.Image = Properties.Resources.padrao;
            pibImagem.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string nome, sobrenome;
            int niver, data;

            
            
            nome = txtNome.Text;
            sobrenome = txtSobrenome.Text;
            niver = int.Parse(txtAno.Text);
            data = DateTime.Now.Year;
            int idade = data - niver; 

            if (idade >= 18)
            {
                lblResultado.Text = ("Bem-Vindo ao Emoticons" + " " + nome + " " + sobrenome);
                pibImagem.Image = Properties.Resources.certo;
                pibImagem.SizeMode = PictureBoxSizeMode.Zoom;
                lblResultado.ForeColor = Color.Green;
            }
            else
            {
                lblResultado.Text = "Não Pode Entrar!!!!!";
                pibImagem.Image = Properties.Resources.errado;
                pibImagem.SizeMode = PictureBoxSizeMode.Zoom;
                lblResultado.ForeColor = Color.Red;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAno.Text = "";
            pibImagem.Image= Properties.Resources.padrao;
            pibImagem.SizeMode = PictureBoxSizeMode.Zoom;
            lblResultado.Text = "";
        }
    }
}
