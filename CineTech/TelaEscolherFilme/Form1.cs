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
                btnConfirmar.Text = "Quero assistir esse!";
            }
        }
        private void CarregarFilmes()
        {
            cmbFilmes.Items.Add("Velozes e Furiosos 10");
            cmbFilmes.Items.Add("Sonic 2");
            cmbFilmes.Items.Add("Gatos de Botas");
            cmbFilmes.Items.Add("Ta chovendo Hamburger");
            cmbFilmes.Items.Add("Pelé");
            cmbFilmes.Items.Add("Lupin");
            cmbFilmes.Items.Add("Vingadores: Guerra Infinita");
            cmbFilmes.Items.Add("Peak Blieds");
            cmbFilmes.Items.Add("Neymas: O Caos Perfeito");
            cmbFilmes.Items.Add("Transformes");

            cmbFilmes.SelectedIndexChanged += cmbFilmes_SelectedIndexChanged;
        }


        private void cmbFilmes_SelectedIndexChanged(object sender, EventArgs e)
        {
  
            string filmeSelecionado = cmbFilmes.SelectedItem.ToString();

  
            switch (filmeSelecionado)
            {
                case "Velozes e Furiosos 10":
                    imgCapaFilme.Image = Properties.Resources.Velozes_e_Furiosos_10;
                    break;
                case "Sonic 2":
                    imgCapaFilme.Image = Properties.Resources.Sonic_2; 
                    break;
                case "Gatos de Botas":
                    imgCapaFilme.Image = Properties.Resources.Gatos_de_Botas; 
                    break;
                case "Ta chovendo Hamburger":
                    imgCapaFilme.Image = Properties.Resources.Ta_chovendo_Hamburger; 
                    break;
                case "Pelé":
                    imgCapaFilme.Image = Properties.Resources.Pelé;
                    break;
                case "Lupin":
                    imgCapaFilme.Image = Properties.Resources.Lupin;
                    break;
                case "Vingadores: Guerra Infinita":
                    imgCapaFilme.Image = Properties.Resources.Vingadores_Guerra_Infinita; 
                    break;
                case "Peak Blieds":
                    imgCapaFilme.Image = Properties.Resources.Peak_Blieds; 
                    break;
                case "Neymas: O Caos Perfeito":
                    imgCapaFilme.Image = Properties.Resources.Neymas_O_Caos_Perfeito; 
                    break;
                case "Transformes":
                    imgCapaFilme.Image = Properties.Resources.Transformes; 
                    break;

            }
        }

        private void btnAssistir_Click(object sender, EventArgs e)
        {

        }
    }
}
