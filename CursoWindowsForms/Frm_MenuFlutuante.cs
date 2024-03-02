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
    public partial class Frm_MenuFlutuante : Form
    {
        public Frm_MenuFlutuante()
        {
            InitializeComponent();
        }

        private void Frm_MenuFlutuante_MouseDown(object sender, MouseEventArgs e)
        {

            ToolStripMenuItem AdicionarItemMenu(string item, string nomeImagem)
            {
                var vToolTip = new ToolStripMenuItem();
                vToolTip.Text = item;

                Image myImage = (Image)Properties.Resources.ResourceManager.GetObject(nomeImagem);
                vToolTip.Image = myImage;
                return vToolTip;
            }

            if (e.Button == MouseButtons.Right)
            {
                //var posicaoX = e.X; 
                //var posicaoY = e.Y;
                //MessageBox.Show($"Cliquei com o botão direito do mouse na posição relativa: X:{posicaoX};Y:{posicaoY}");

                var contextMenu = new ContextMenuStrip();
                var vToolTip001 = AdicionarItemMenu("Menu 1", "_1");
                var vToolTip002 = AdicionarItemMenu("Menu 2", "_2");

                contextMenu.Items.Add(vToolTip001);
                contextMenu.Items.Add(vToolTip002);
                contextMenu.Show(this, new Point(e.X,e.Y)) ;
                vToolTip001.Click += new EventHandler(vToolTip001_Click);
                vToolTip002.Click += new EventHandler(vToolTip002_Click);
            }

            void vToolTip001_Click(object sender1, EventArgs e1)
            {
                MessageBox.Show("Selecionei a opção do Menu 001");
            }

            void vToolTip002_Click(object sender1, EventArgs e1)
            {
                MessageBox.Show("Selecionei a opção do Menu 002");
            }

        }
    }
}
