using Projeto_N2_POO.Classes;
using Projeto_N2_POO.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_N2_POO
{
    public partial class frMainMenu : Form
    {
        private Form formAberto = null;
        public frMainMenu()
        {
            InitializeComponent();
            Dados.LerMarcas();
            Dados.LerModelo();
            Dados.LerPedagio();
            Dados.LerVeiculo();
        }
        
        private void btnAbriMenuCadastro_Click(object sender, EventArgs e)
        {
            if (pnlCadastro.Visible)
                pnlCadastro.Visible = false;
            else
                pnlCadastro.Visible = true;
        }
        private void btnGerencia_Click(object sender, EventArgs e)
        {
            if (pnlGerencia.Visible)
                pnlGerencia.Visible = false;
            else
                pnlGerencia.Visible = true;
            AbrirForm(new frGerenciar());
        }
        private void AbrirForm(Form formASerAberto)
        {
            if (formAberto != null)
                formAberto.Close();
            if (formASerAberto == null)
                return;

            // Configurações do Form 
            formASerAberto.TopLevel = false;
            formASerAberto.FormBorderStyle = FormBorderStyle.None;
            formASerAberto.Dock = DockStyle.Fill;
            pnlMainForm.Controls.Add(formASerAberto);
            formASerAberto.BackColor = pnlMainForm.BackColor;


            formASerAberto.BringToFront();
            formASerAberto.Show();
            formAberto = formASerAberto;
        }
        private void btnSobre_Click(object sender, EventArgs e)
        {
            AbrirForm(new frSobre());
        }
        private void btnCadMarca_Click(object sender, EventArgs e)
        {
            AbrirForm(new frCadastroMarca());
        }
        private void btnCadModelo_Click(object sender, EventArgs e)
        {
            AbrirForm(new frCadastroDeModelo());
        }
        private void btnCadSemaforo_Click(object sender, EventArgs e)
        {
            AbrirForm(new frCadastroPedagio());
        }
        private void btnCadCarro_Click(object sender, EventArgs e)
        {
            AbrirForm(new frCadastroCarro());
        }
        private void btnCadCaminhao_Click(object sender, EventArgs e)
        {
            AbrirForm(new frCadastroCaminhao());
        }
        private void btnCadOnibus_Click(object sender, EventArgs e)
        {
            AbrirForm(new frCadastroOnibus());
        }
        private void btnCadMoto_Click(object sender, EventArgs e)
        {
            AbrirForm(new frCadastroMoto());
        }
        private void btnCadAviao_Click(object sender, EventArgs e)
        {
            AbrirForm(new frCadastroAviao());
        }
        private void btnCadAviaoDeGuerra_Click(object sender, EventArgs e)
        {
            AbrirForm(new frCadastroAviaoDeGuerra());
        }
        private void btnGenCarro_Click(object sender, EventArgs e)
        {
            AbrirForm(new frGerenciarCarro());
        }
        private void btnGenCaminhao_Click(object sender, EventArgs e)
        {
            AbrirForm(new frGerenciarCaminhao());
        }
        private void btnGenOnibus_Click(object sender, EventArgs e)
        {
            AbrirForm(new frGerenciarOnibus());
        }
        private void btnGenMoto_Click(object sender, EventArgs e)
        {
            AbrirForm(new frGerenciarMoto());
        }
        private void btnGenAviao_Click(object sender, EventArgs e)
        {
            AbrirForm(new frGerenciarAviao());
        }
        private void btnGenAviaoDeGuerra_Click(object sender, EventArgs e)
        {
            AbrirForm(new frGerenciarAviaoDeGuerra());
        }
        private void btnGenMarca_Click(object sender, EventArgs e)
        {
            AbrirForm(new frGerenciarMarcas());
        }
        private void btnGenModelo_Click(object sender, EventArgs e)
        {
            AbrirForm(new frGerenciarModelos());
        }
        private void btnGenPedagio_Click(object sender, EventArgs e)
        {
            AbrirForm(new frGerenciarPedagio());
        }
    }
}
