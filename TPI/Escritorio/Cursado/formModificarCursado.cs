﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio.Cursado
{
    public partial class formModificarCursado : Form
    {
        private TPI.Entidades.Usuario Usuario;
        private TPI.Entidades.Curso Curso;
        private TPI.Entidades.Cursado Cursado;
        public formModificarCursado(TPI.Entidades.Cursado cursado)
        {
            Cursado = cursado;
            InitializeComponent();
        }

        private void formModificarCursado_Load(object sender, EventArgs e)
        {
            foreach (TPI.Entidades.Usuario us in TPI.Negocio.Usuario.GetAllAlumnos())
            {
                cbxUsuario.Items.Add(us.Persona.Nombre + " " + us.Persona.Apellido);
            }
            foreach (TPI.Entidades.Curso cur in TPI.Negocio.Curso.GetAll())
            {
                cbxCurso.Items.Add(cur.Id);
            }
        }

        private void cbxUsuario_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void cbxCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCurso.SelectedItem != null) { 
            var idCurso = Convert.ToInt32(cbxCurso.SelectedItem.ToString());
            Curso = TPI.Negocio.Curso.GetOne(idCurso);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var nota = Convert.ToInt32(nupNota.Value);
            try
            {

                
                bool validar_curso = TPI.Negocio.Cursado.ValidarCurso(Usuario, Curso);
                bool validar_nota = TPI.Negocio.Cursado.ValidarNota(nota);

                if (validar_curso && validar_nota)
                {
                    if(Cursado!=null && Usuario!=null && Curso != null) {
                    
                    TPI.Negocio.Cursado.Cambiar(Cursado, Usuario, Curso, dtpFecha.Value, nota);
                    }
                }
                if (validar_curso == false)
                {
                    MessageBox.Show("Error en el curso se superpone con otro curso");
                }
                if (validar_nota == false)
                {
                    MessageBox.Show("Error en la nota. Recuerde que la misma debe ser un entero de 0 a 10");
                }
            }
            catch
            {
                MessageBox.Show("Error al modificar cursado");
            }


        }

        private void cbxUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxUsuario.SelectedItem != null) { 
            Usuario = TPI.Negocio.Usuario.GetUsuarioPorNomyApe(cbxUsuario.SelectedItem.ToString());
            }
        }
    }
}
