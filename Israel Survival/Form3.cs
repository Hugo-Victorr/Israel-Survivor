using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections;

namespace Israel_Survival
{
    public partial class FrmRank : Form
    {
        public FrmRank()
        {
            InitializeComponent();
        }

        private void FrmRank_Load(object sender, EventArgs e)
        {
            List<string> Linhas = new List<string>();

            

            Linhas = File.ReadAllLines("Israel_Survival.Properties.Resources.IsraelSurvivalrank").ToList();

            Linhas.Sort();

            foreach (string linha in Linhas)
            {
                ltbRank.Items.Add(linha);
            }
        }

        private void ltbRank_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
