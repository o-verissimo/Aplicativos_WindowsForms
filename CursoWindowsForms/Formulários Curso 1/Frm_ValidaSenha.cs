using CursoWindowsFormsBiblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CursoWindowsFormsBiblioteca.ChecaForcaSenha;

namespace CursoWindowsForms
{
    public partial class Frm_ValidaSenha : Form
    {

        bool VerSenhaTxt = false;
        public Frm_ValidaSenha()
        {
            InitializeComponent();
        }

        private void Frm_ValidaSenha_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = "";
            Txt_Senha.Text = "";
        }

        private void Txt_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            ChecaForcaSenha verifica = new ChecaForcaSenha();
            ChecaForcaSenha.ForcaDaSenha forca;
            forca = verifica.GetForcaDaSenha(Txt_Senha.Text);
            Lbl_Resultado.Text = forca.ToString();

            if(Lbl_Resultado.Text == "Inaceitavel" || Lbl_Resultado.Text == "Fraca")
            {
                Lbl_Resultado.ForeColor = Color.Red;
            }
            else if (Lbl_Resultado.Text == "Aceitavel")
            {
                Lbl_Resultado.ForeColor = Color.Blue;
            }
            else
            {
                Lbl_Resultado.ForeColor = Color.Green;
            }
        }

        private void Btn_VerSenha_Click(object sender, EventArgs e)
        {
            if (VerSenhaTxt == false)
            {
                Txt_Senha.PasswordChar = '\0';
                VerSenhaTxt = true;
                Btn_VerSenha.Text = "Esconder Senha";
            }
            else
            {
                Txt_Senha.PasswordChar = '*';
                VerSenhaTxt = false;
                Btn_VerSenha.Text = "Ver Senha";
            }
                        
        }
    }
}
