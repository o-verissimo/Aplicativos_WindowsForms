using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_ArquivoImagem_UC : UserControl
    {
        public Frm_ArquivoImagem_UC(string nomeArquivoImagem)
        {
            InitializeComponent();
            Lbl_ArquivoImagem.Text = nomeArquivoImagem;
            Pic_ArquivoImagem.Image = Image.FromFile(nomeArquivoImagem);
        }

        private void Btn_Font_Click(object sender, EventArgs e)
        {
            FontDialog fontDB = new FontDialog();
            if(fontDB.ShowDialog() == DialogResult.OK)
            {
                Lbl_ArquivoImagem.Font = fontDB.Font;
            }
        }

        private void Btn_Cor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDB = new ColorDialog();
            if(colorDB.ShowDialog() == DialogResult.OK)
            {
                Lbl_ArquivoImagem.ForeColor = colorDB.Color;
            }
        }

        private void Pic_ArquivoImagem_Click(object sender, EventArgs e)
        {

        }
    }
}
