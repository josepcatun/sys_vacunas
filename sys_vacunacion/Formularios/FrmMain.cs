﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sys_vacunacion.Formularios
{
    public partial class FrmMain : Form
    {
        
        public FrmMain()
        {
            InitializeComponent();
        }
        
        private void Form2_Load(object sender, EventArgs e){}

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PanelConsultaVacunacion.Visible = false;
            PanelVacuna.Visible = true;
            PanelVacuna.Dock = DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PanelVacuna.Visible = false;
            PanelConsultaVacunacion.Visible = true;
            PanelConsultaVacunacion.Dock = DockStyle.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PanelConsultaVacunacion.Visible = false;
            PanelVacuna.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PanelConsultaVacunacion.Visible = false;
            PanelVacuna.Visible = false;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void TxtBuscarVacuna_TextChanged(object sender, EventArgs e)
        {
            if (TxtBuscarVacuna.Text.Trim() == "")
            {
                DgvBuscarVacuna.Visible = false;
            }
            else
            {
                DgvBuscarVacuna.Visible = true;
            }
        }

        private void TxtBoxNombreConsultarVacunacion_TextChanged(object sender, EventArgs e)
        {
            if (TxtBoxNombreConsultarVacunacion.Text.Trim() == "")
            {
                DvgSearchConsultaVacunacion.Visible = false;
            }
            else
            {
                DvgSearchConsultaVacunacion.Visible = true;
            }
        }

        private void TxtBoxCuiConsultarVacunacion_TextChanged(object sender, EventArgs e)
        {
            if (TxtBoxCuiConsultarVacunacion.Text.Trim() == "")
            {
                DvgSearchCuiConsultaVacunacion.Visible = false;
            }
            else
            {
                DvgSearchCuiConsultaVacunacion.Visible = true;
            }
        }
    }
}
