﻿using LetsBlood_2;
using LetsBlood_2.Cadastros_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsBloob_2
{
    public partial class frm_Cadastros : Form
    {
        public frm_Cadastros()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lb_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_cadast_med_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_cadastrarMedico form = new frm_cadastrarMedico();
            form.ShowDialog();
            this.Show();
        }

        private void bt_cadast_doador_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_cadastrarDoador form = new frm_cadastrarDoador();
            form.ShowDialog();
            this.Show();
        }

        private void bt_cadast_bolsa_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_cadastrarBolsa form = new frm_cadastrarBolsa();
            form.ShowDialog();
            this.Show();
        }

        private void bt_cadast_hospital_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_cadastrarHospital form = new frm_cadastrarHospital();
            form.ShowDialog();
            this.Show();
        }
    }
}
