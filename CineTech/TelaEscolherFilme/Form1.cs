using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaEscolherFilme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CarregarFilmes();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            if (btnConfirmar.Enabled)
            {
                pnlNomeData.Visible = true;
            }
        }
        private void CarregarFilmes()
        {
            // Adicione os filmes à ComboBox
            cmbFilmes.Items.Add("Velozes e Furiosos 10");
            cmbFilmes.Items.Add("Sonic 2");
            cmbFilmes.Items.Add("Filme 3");

            // Configure o evento SelectedIndexChanged
            cmbFilmes.SelectedIndexChanged += cmbFilmes_SelectedIndexChanged;
        }
    

        private void cmbFilmes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtenha o filme selecionado
            string filmeSelecionado = cmbFilmes.SelectedItem.ToString();

            // Mude a imagem da PictureBox de acordo com o filme selecionado
            switch (filmeSelecionado)
            {
                case "Velozes e Furiosos 10":
                    imgCapaFilme.Image = Image.FromFile("velozesEfuriosos.jpg");
                    break;
                case "Sonic 2":
                    imgCapaFilme.Image = Image.FromFile("imagens.sonic.jpg");
                    break;
                case "Filme 3":
                    imgCapaFilme.Image = Image.FromFile("caminho_para_imagem_do_filme3.jpg");
                    break;
                default:
                    imgCapaFilme.Image = null;
                    break;
            }
        }
    }
}
