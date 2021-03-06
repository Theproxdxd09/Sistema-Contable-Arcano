﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class formAsientos : Form
    {
        Controladores.controladores controladores = new Controladores.controladores();

        public formAsientos()
        {
            InitializeComponent();
        }

        private void btnAsiento_Click(object sender, EventArgs e)
        {
            controladores.abrirFormularioPanel(panelAsiento, new formIngresoAsiento());
            controladores.controladorBotonesSubMenAsc(btnAsiento, btnMayorizacion, 10, 161, 141);
        }

        private void btnMayorizacion_Click(object sender, EventArgs e)
        {
            controladores.abrirFormularioPanel(panelAsiento, new formReporteAsiento());
            controladores.controladorBotonesSubMenAsc(btnMayorizacion, btnAsiento, 56, 77, 140);

        }
    }
}
