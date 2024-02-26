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
    public partial class Frm_Principal_Menu_MDI : Form
    {
        public Frm_Principal_Menu_MDI()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void helloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_HelloWorld formHelloWorld = new Frm_HelloWorld();
            formHelloWorld.MdiParent = this;
            formHelloWorld.Show();
        }

        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DemonstracaoKey formDemonstracaoKey = new Frm_DemonstracaoKey();
            formDemonstracaoKey.MdiParent = this;
            formDemonstracaoKey.Show();
        }

        private void máscaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Mascara formMascara = new Frm_Mascara();
            formMascara.MdiParent= this;
            formMascara.Show();
        }

        private void valídaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidaCPF formValidaCPF = new Frm_ValidaCPF();
            formValidaCPF.MdiParent = this;
            formValidaCPF.Show();
        }

        private void valídaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidaCPF2 formValidaCPF2 = new Frm_ValidaCPF2();
            formValidaCPF2.MdiParent = this;
            formValidaCPF2.Show();
        }

        private void valídaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidaSenha formValidaSenha = new Frm_ValidaSenha();
            formValidaSenha.MdiParent = this;
            formValidaSenha.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }

   
}
