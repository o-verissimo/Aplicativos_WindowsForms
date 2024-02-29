using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CursoWindowsFormsBiblioteca;

namespace CursoWindowsForms
{
    public partial class Frm_Principal_Menu_UC : Form
    {
        int ControleHelloWorld = 0;
        int ControleDemonstracaoKey = 0;
        int ControleMascara = 0;
        int ControleValidaCPF = 0;
        int ControleValidaCPF2 = 0;
        int ControleValidaSenha = 0;
        int ControleArquivoImagem = 0;
        public Frm_Principal_Menu_UC()
        {
            InitializeComponent();

            novoToolStripMenuItem.Enabled = false;
            apagarAbaToolStripMenuItem.Enabled = false;
            abrirImagemToolStripMenuItem.Enabled = false;
            desconectarToolStripMenuItem.Enabled = false;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void helloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleHelloWorld++;
            Frm_HelloWorld_UC ucHelloWorld = new Frm_HelloWorld_UC();
            ucHelloWorld.Dock = DockStyle.Fill;
            TabPage ucHelloWorldTabPage = new TabPage();
            ucHelloWorldTabPage.Name = $"Hello World {ControleHelloWorld}";
            ucHelloWorldTabPage.Text = $"Hello World {ControleHelloWorld}"; 
            ucHelloWorldTabPage.ImageIndex = 1;
            ucHelloWorldTabPage.Controls.Add(ucHelloWorld);
            Tbc_Aplicacoes.TabPages.Add(ucHelloWorldTabPage);
           
        }

        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleDemonstracaoKey++;
            Frm_DemonstracaoKey_UC ucDemosntracaoKey = new Frm_DemonstracaoKey_UC();
            ucDemosntracaoKey.Dock = DockStyle.Fill;
            TabPage ucDemonstracaKeyTabPage = new TabPage();
            ucDemonstracaKeyTabPage.Name = $"Demonstração Key {ControleDemonstracaoKey}";
            ucDemonstracaKeyTabPage.Text = $"Demonstração Key {ControleDemonstracaoKey}";
            ucDemonstracaKeyTabPage.ImageIndex = 0;
            ucDemonstracaKeyTabPage.Controls.Add(ucDemosntracaoKey);
            Tbc_Aplicacoes.TabPages.Add(ucDemonstracaKeyTabPage);

        }

        private void máscaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleMascara++;
            Frm_Mascara_UC ucMascara = new Frm_Mascara_UC();
            ucMascara.Dock = DockStyle.Fill;
            TabPage ucMasacaraTabPage = new TabPage();
            ucMasacaraTabPage.Name = $"Máscara {ControleMascara}";
            ucMasacaraTabPage.Text = $"Máscara {ControleMascara}";
            ucMasacaraTabPage.ImageIndex = 2;
            ucMasacaraTabPage.Controls.Add(ucMascara);
            Tbc_Aplicacoes.TabPages.Add(ucMasacaraTabPage);
        }

        private void valídaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaCPF++;
            Frm_ValidaCPF_UC ucValidaCPF = new Frm_ValidaCPF_UC();
            ucValidaCPF.Dock = DockStyle.Fill;
            TabPage ucValidaCPFTabPage = new TabPage();
            ucValidaCPFTabPage.Name = $"Valída CPF {ControleValidaCPF}";
            ucValidaCPFTabPage.Text = $"Valída CPF {ControleValidaCPF}";
            ucValidaCPFTabPage.ImageIndex = 3;
            ucValidaCPFTabPage.Controls.Add(ucValidaCPF);
            Tbc_Aplicacoes.TabPages.Add(ucValidaCPFTabPage);
        }

        private void valídaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaCPF2++;
            Frm_ValidaCPF_2_UC ucValidaCPF2 = new Frm_ValidaCPF_2_UC();
            ucValidaCPF2.Dock = DockStyle.Fill;
            TabPage ucValidaCPF2TabPage = new TabPage();
            ucValidaCPF2TabPage.Name = $"Valída CPF_2 {ControleValidaCPF2}";
            ucValidaCPF2TabPage.Text = $"Valída CPF_2 {ControleValidaCPF2}";
            ucValidaCPF2TabPage.ImageIndex = 4;
            ucValidaCPF2TabPage.Controls.Add(ucValidaCPF2);
            Tbc_Aplicacoes.TabPages.Add(ucValidaCPF2TabPage);
        }

        private void valídaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaSenha++;
            Frm_ValidaSenha_UC ucValidaSenha = new Frm_ValidaSenha_UC();
            ucValidaSenha.Dock = DockStyle.Fill;
            TabPage ucValidaSenhaTabPage = new TabPage();
            ucValidaSenhaTabPage.Name = $"Valída Senha {ControleValidaSenha}";
            ucValidaSenhaTabPage.Text = $"Valída Senha {ControleValidaSenha}";
            ucValidaSenhaTabPage.ImageIndex = 5;
            ucValidaSenhaTabPage.Controls.Add(ucValidaSenha);
            Tbc_Aplicacoes.TabPages.Add(ucValidaSenhaTabPage);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void apagarAbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(! (Tbc_Aplicacoes.SelectedTab == null))
            {
                Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.SelectedTab);
            }
            
        }

        private void abrirImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDB = new OpenFileDialog();
            openFileDB.InitialDirectory = "C:\\WindowsForms\\Curso\\CursoWindowsForms\\CursoWindowsForms\\Imagens";
            openFileDB.Filter = "PNG|*.PNG";
            openFileDB.Title = "Escolha a imagem";

            if (openFileDB.ShowDialog() == DialogResult.OK)
            {
                string nomeArquivoImagem = openFileDB.FileName;
                
                ControleArquivoImagem++;
                Frm_ArquivoImagem_UC ucArquivoImagem = new Frm_ArquivoImagem_UC(nomeArquivoImagem);
                ucArquivoImagem.Dock = DockStyle.Fill;
                TabPage ucArquivoImagemTabPage = new TabPage();
                ucArquivoImagemTabPage.Name = $"Arquivo Imagem {ControleArquivoImagem}";
                ucArquivoImagemTabPage.Text = $"Arquivo Imagem {ControleArquivoImagem}";
                ucArquivoImagemTabPage.ImageIndex = 6;
                ucArquivoImagemTabPage.Controls.Add(ucArquivoImagem);
                Tbc_Aplicacoes.TabPages.Add(ucArquivoImagemTabPage);
            }

            
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Login frm_Login = new Frm_Login();  
            frm_Login.ShowDialog();

            if(frm_Login.DialogResult == DialogResult.OK)
            {

                string senha = frm_Login.senha;
                string login = frm_Login.login;

                if(ValidaSenhaLogin.ValidarSenhaLogin(senha) == true)
                {
                    novoToolStripMenuItem.Enabled = true;
                    apagarAbaToolStripMenuItem.Enabled = true;
                    abrirImagemToolStripMenuItem.Enabled = true;
                    desconectarToolStripMenuItem.Enabled = true;
                    conectarToolStripMenuItem.Enabled = false;

                    MessageBox.Show($"Bem vindo {login}!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show($"Senha inválida", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Questao frm_Questao = new Frm_Questao("_6", "Você deseja se desconectar ?");
            frm_Questao.ShowDialog();

            if(frm_Questao.DialogResult == DialogResult.Yes)
            {
                //Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.SelectedTab);

                for(int i= Tbc_Aplicacoes.TabPages.Count -1; i >= 0; i--)
                {
                    Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.TabPages[i]);
                }

                novoToolStripMenuItem.Enabled = false;
                apagarAbaToolStripMenuItem.Enabled = false;
                abrirImagemToolStripMenuItem.Enabled = false;
                desconectarToolStripMenuItem.Enabled = false;
                conectarToolStripMenuItem.Enabled = true;
            }
        }
    }
}
