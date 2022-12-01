using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Israel_Survival
{
    public partial class FormMenu : Form
    {
        private string nomeJogador;

        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new FormJogo();
            form1.Closed += (s, args) => this.Close();
            form1.Show();

            form1.setNomeJogador(this.nomeJogador);

        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
        
            this.nomeJogador = textBox1.Text;
            label2.Text = "Confirmado!";


        }

        private void btnRank_Click(object sender, EventArgs e)
        {
            
            var form3 = new FrmRank();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void btnSair2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
