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
    public partial class Frm_Principal_Menu : Form
    {
        public Frm_Principal_Menu()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void helloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_HelloWorld formHelloWorld = new Frm_HelloWorld();
            formHelloWorld.ShowDialog();
        }

        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DemonstracaoKey formDemonstracaoKey = new Frm_DemonstracaoKey();
            formDemonstracaoKey.ShowDialog();
        }

        private void máscaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Mascara formMascara = new Frm_Mascara();
            formMascara.ShowDialog();
        }

        private void valídaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidaCPF formValidaCPF = new Frm_ValidaCPF();
            formValidaCPF.ShowDialog();
        }

        private void valídaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidaCPF2 formValidaCPF2 = new Frm_ValidaCPF2();
            formValidaCPF2.ShowDialog();
        }

        private void valídaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidaSenha formValidaSenha = new Frm_ValidaSenha();
            formValidaSenha.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
