﻿using LetsBlood_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LetsBlood_2.Cadastros_Forms;

namespace LetsBloob_2
{
    public partial class frm_Menu_Principal : Form
    {
        public frm_Menu_Principal()
        {
            InitializeComponent();
        }

        private void frm_Menu_Principal_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    c.TabStop = false;
                }
            }
        }

        private void bt_cadastros_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_cadastrarBolsa form = new frm_cadastrarBolsa();
            form.ShowDialog();
            try
            {
                this.Show();
            }
            catch (System.ObjectDisposedException)
            {
                ProtegerSaida();
            } 
            
        }

        private void bt_Doador_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_cadastrarDoador form = new frm_cadastrarDoador();
            form.ShowDialog();
            try
            {
                this.Show();
            }
            catch (System.ObjectDisposedException)
            {
                ProtegerSaida();
            }
        }


        private void informaçõesDoProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_sobre form = new frm_sobre();
            form.ShowDialog();
            try
            {
                this.Show();
            }
            catch (System.ObjectDisposedException)
            {
                ProtegerSaida();
            }
        }

        private void informaçõesDeDoaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string message = @"Requisitos para doadores:
* Levar documento oficial de identidade com foto;
* Estar bem de saúde e descansado;
* Ter entre 16 e 69 anos 
(até os 18 anos apenas com consentimento formal dos responsáveis);
* Pesar mais de 50kg:
* Não estar em jejum e evitar alimentos gordurosos nas últimas três horas;
* Não ter ingerido bebida alcoólica nas últimas 12 horas.
                 
Tempo entre doações:
* Homens: podem fazer doação de sangue a cada 60 dias, com máximo de
doações a cada 12 meses.
* Mulheres: devem esperar 90 dias entre uma doação e outra, com
máximo de 3 doações no período de 12 meses.";
            const string caption = "Dicas de Doação";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Asterisk);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ProtegerSaida();
        }

        private void lb_sair_Click(object sender, EventArgs e)
        {
            ProtegerSaida();
        }

        private void ProtegerSaida ()
        {
            const string message = "Tem certeza que deseja fechar o programa?";
            const string caption = "Fechar";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit ();
            }
        }


    }
}
