﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio
{
    public partial class formAgregoPlan : Form
    {
        public formAgregoPlan()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAño_TextChanged(object sender, EventArgs e)
        {

        }

        private void formAgregoPlan_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int año = Convert.ToInt32(this.textBoxAño.Text);
                string descplan = this.textBoxDesc.Text;
                

                var Plan = TPI.Negocio.Plan.CrearPlan(año , descplan);

                TPI.Negocio.Plan.AgregoPlan(Plan);

                MessageBox.Show("Plan creado con exito!");

                this.Dispose();
            }
            catch
            {
                MessageBox.Show("Algunos campos son incorrectos o quedaron en blanco");
            }
        }
    }
}