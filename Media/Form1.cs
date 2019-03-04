using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media
{
    public partial class Form1 : Form
    {
        Media m = new Media();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            txtNome.Enabled = false;
            txtNota1.Enabled = false;
            txtNota2.Enabled = false;
            txtNota3.Enabled = false;
            txtNota4.Enabled = false;
            btnMedia.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            txtNota1.Enabled = true;
            txtNota2.Enabled = true;
            txtNota3.Enabled = true;
            txtNota4.Enabled = true;
            btnMedia.Enabled = true;

            txtNome.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtNota4.Clear();
    
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            m.nome = txtNome.Text;
            m.nota1 = float.Parse(txtNota1.Text);
            m.nota2 = float.Parse(txtNota2.Text);
            m.nota3 = float.Parse(txtNota3.Text);
            m.nota4 = float.Parse(txtNota4.Text);
    
            m.MediaNota();

            m.MaiorNota();

            m.MediaNota();

            lblNome.Text = m.nome;
            lblMedia.Text =Convert.ToString("A Media " + m.resultado);
           
            lblMaiorNota.Text =Convert.ToString ("A maior Nota " + m.maiornota);


            lblMenorNota.Text = Convert.ToString("A Menor Nota " + m.menornota);






        }
    }
}
