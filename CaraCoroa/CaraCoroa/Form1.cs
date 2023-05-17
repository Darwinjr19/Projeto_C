using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CaraCoroa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            //sortear escolha do computador
            Random rdm = new Random();
            int escolhaPC = rdm.Next(0, 2);
            //0 - cara     1 - coroa
            if (escolhaPC == 0 && rdbCara.Checked == true) //cara com cara
            {
                ptbComputador.Image = Properties.Resources.cara;
                lblMensagem.Text = "Você ganhou!";

                //reproduzir áudio
                System.Media.SoundPlayer sp = new System.Media.SoundPlayer("acerto.wav");
                sp.Play();
                
            }
            else if (escolhaPC == 1 && rdbCoroa.Checked == true) //coroa com coroa
            {
                ptbComputador.Image = Properties.Resources.coroa;
                lblMensagem.Text = "Você ganhou!";

                //reproduzir áudio
                System.Media.SoundPlayer sp = new System.Media.SoundPlayer("acerto.wav");
                sp.Play();
            }
            else if (escolhaPC == 0 && rdbCoroa.Checked == true) //cara com coroa
            {
                ptbComputador.Image = Properties.Resources.cara;
                lblMensagem.Text = "Você predeu!";

                //reproduzir áudio
                System.Media.SoundPlayer sp = new System.Media.SoundPlayer("erro.wav");
                sp.Play();
            }
            else if (escolhaPC == 1 && rdbCara.Checked == true) //cara com coroa
            {
                ptbComputador.Image = Properties.Resources.coroa;
                lblMensagem.Text = "Você predeu!";

                //reproduzir áudio
                System.Media.SoundPlayer sp = new System.Media.SoundPlayer("erro.wav");
                sp.Play();
            }
            else
            {
                lblMensagem.Text = "Selecione uma opção";
                return;//para a execução
            }

            //bloqueando opções
            btnVerificar.Enabled = false;
            rdbCara.Enabled = false;
            rdbCoroa.Enabled = false;
        }

        private void ptbMoeda_Click(object sender, EventArgs e)
        {

        }

        private void rdbCara_CheckedChanged(object sender, EventArgs e)
        {
            ptbMoeda.Image = Properties.Resources.cara;
        }

        private void rdbCoroa_CheckedChanged(object sender, EventArgs e)
        {
            ptbMoeda.Image = Properties.Resources.coroa;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //desmarcar opções
            rdbCara.Checked = false;
            rdbCoroa.Checked = false;
            //desbloquear botões
            btnVerificar.Enabled = true;
            rdbCara.Enabled = true;
            rdbCoroa.Enabled = true;
            //limpar imagens
            ptbMoeda.Image = null;
            ptbComputador.Image = null;

            //limpar mensagem
            lblMensagem.Text = "";
           
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if(cmbTema.Text == "Amarelo")
            {
                this.BackColor = Color.Yellow;

                //trocar cor de todos componentes automaticamente
                foreach (Control controle in this.Controls)
                {
                    if (controle is Label) controle.ForeColor = Color.Red;
                    if (controle is RadioButton) controle.ForeColor = Color.Red;
                }
            }
            else if(cmbTema.Text == "Vermelho")
            {
                this.BackColor = Color.Red;

                //trocar cor de todos componentes automaticamente
                foreach (Control controle in this.Controls)
                {
                    if (controle is Label) controle.ForeColor = Color.BlueViolet;
                    if (controle is RadioButton) controle.ForeColor = Color.BlueViolet;
                }

            }
            else if(cmbTema.Text == "Preto")
            {
                this.BackColor = Color.Black;

                //trocar cor de todos componentes automaticamente
                foreach (Control controle in this.Controls)
                {
                    if (controle is Label) controle.ForeColor = Color.White;
                    if (controle is RadioButton) controle.ForeColor = Color.White;
                }

            }
            else
            {
                MessageBox.Show("Selecione um tema");
            }
        }
    }
}
