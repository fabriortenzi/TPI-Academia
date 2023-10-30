using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Escritorio.ProfesorCurso;
using Escritorio.Inscripcion;
using Escritorio.Comision;
using Escritorio.Especialidad;
using Escritorio.Curso;
using Escritorio.Cursado;
using Escritorio.Persona;
using Escritorio.Materia;

namespace Escritorio.Generalizado
{
    public partial class formListar : Form
    {
        private Type? tipoDato;
        private List<Object> ListaGeneral = new List<Object>();


        public formListar(Type tipo_dato)
        {
            InitializeComponent();
            tipoDato = tipo_dato;

        }




        private void formListar_Load(object sender, EventArgs e)
        {
            CargarNombreDeVentana();
            CargarDGV();
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            dgvGrilla.DataSource = null;
            dgvGrilla.Refresh();
            dgvGrilla.DataSource = ListaGeneral[0];

        }


        private void CargarNombreDeVentana()
        {
            string nom_clase = "";
            if (tipoDato == typeof(TPI.Entidades.ProfesorCurso))
            {

                nom_clase = "Profesores Cursos";
            }
            else if (tipoDato == typeof(TPI.Entidades.Curso))
            {
                nom_clase = "Cursos";
            }
            else if (tipoDato == typeof(TPI.Entidades.Cursado))
            {
                nom_clase = "Inscripciones";
            }
            else if (tipoDato == typeof(TPI.Entidades.Materia))
            {
                nom_clase = "Materias";
            }
            else if (tipoDato == typeof(TPI.Entidades.Persona))
            {
                nom_clase = "Personas";
            }
            else if (tipoDato == typeof(TPI.Entidades.Plan))
            {
                nom_clase = "Planes";
            }
            else if (tipoDato == typeof(TPI.Entidades.Usuario))
            {
                nom_clase = "Usuarios";
            }
            else if (tipoDato == typeof(TPI.Entidades.Comision))
            {
                nom_clase = "Comisiones";
            }
            else if (tipoDato == typeof(TPI.Entidades.TipoDeUsuario))
            {
                nom_clase = "TiposDeUsuarios";
            }
            else if (tipoDato == typeof(TPI.Entidades.Especialidad))
            {
                nom_clase = "Especialidades";
            }

            this.Text = $"Listar-{nom_clase}";
            lblClase.Text = nom_clase;
        }
        private void CargarDGV()
        {
            if (ListaGeneral.Count != 0) { ListaGeneral.Clear(); }

            if (tipoDato == typeof(TPI.Entidades.ProfesorCurso))
            {
                ListaGeneral.Add(TPI.Negocio.ProfesorCurso.GetAll());
            }
            else if (tipoDato == typeof(TPI.Entidades.Comision))
            {
                ListaGeneral.Add(TPI.Negocio.Comision.GetAll());
            }
            else if (tipoDato == typeof(TPI.Entidades.Especialidad))
            {
                ListaGeneral.Add(TPI.Negocio.Especialidad.GetAllEspecialidades());
            }
            else if (tipoDato == typeof(TPI.Entidades.Curso))
            {
                ListaGeneral.Add(TPI.Negocio.Curso.GetAll());
            }
            else if (tipoDato == typeof(TPI.Entidades.Cursado))
            {
                ListaGeneral.Add(TPI.Negocio.Cursado.GetAll());
            }
            else if (tipoDato == typeof(TPI.Entidades.Materia))
            {
                ListaGeneral.Add(TPI.Negocio.Materia.GetAll());
            }
            else if (tipoDato == typeof(TPI.Entidades.Persona))
            {
                ListaGeneral.Add(TPI.Negocio.Persona.GetAll()
                    .OrderBy(x => x.Apellido)
                    .ThenBy(x => x.Nombre).ToList());
                btnAgregar.Visible = false;
                btnEliminar.Visible = false;
                btnModificar.Visible = false;
                btnAgregar.Visible = false;
                btnConsultar.Visible = false;
            }
            else if (tipoDato == typeof(TPI.Entidades.Plan))
            {
                ListaGeneral.Add(TPI.Negocio.Plan.GetAll()
                    .Select(p => new 
                        { p.Especialidad,
                        p.Anio
                    })
                    .OrderBy(p => p.Especialidad.Descripcion)
                    .ThenBy(p => p.Anio)
                    .ToList());

                btnAgregar.Visible = false;
                btnEliminar.Visible = false;
                btnModificar.Visible = false;
                btnAgregar.Visible = false;
                btnConsultar.Visible = false;
            }
            else if (tipoDato == typeof(TPI.Entidades.Usuario))
            {
                ListaGeneral.Add(TPI.Negocio.Usuario.GetAllUsuarios()
                    .Select(x => new
                    {
                        x.Legajo,
                        x.Persona,
                        x.TipoDeUsuario,
                        x.Plan?.Especialidad,
                        x.Plan
                    }).ToList());
            }
            else if (tipoDato == typeof(TPI.Entidades.TipoDeUsuario))
            {
                ListaGeneral.Add(TPI.Negocio.TipoDeUsuario.GetAllTiposDeUsuario());
            }
        }





        private void btnBuscar_Click(object sender, EventArgs e)
        {

            string consulta = txtConsulta.Text;

            if (consulta == "")
            {
                btnListar_Click(sender, e);
            }

            if (ListaGeneral.Count != 0) { ListaGeneral.Clear(); }

            if (tipoDato == typeof(TPI.Entidades.Comision))
            {
                List<TPI.Entidades.Comision> comision = TPI.Negocio.Comision.GetAll();
                ListaGeneral.Add(comision.Where(x => x.Id.ToString().Contains(consulta) || x.NroComision.ToString().Contains(consulta) || x.Especialidad.Descripcion.Contains(consulta)).ToList());
            }
            else if (tipoDato == typeof(TPI.Entidades.Cursado))
            {
                List<TPI.Entidades.Cursado> cursado = TPI.Negocio.Cursado.GetAll();
                ListaGeneral.Add(cursado.Where(x => x.Id.ToString().Contains(consulta)).ToList());
            }
            else if (tipoDato == typeof(TPI.Entidades.ProfesorCurso))
            {
                List<TPI.Entidades.ProfesorCurso> profesor_curso = TPI.Negocio.ProfesorCurso.GetAll();
                ListaGeneral.Add(profesor_curso.Where(x => x.Id.ToString().Contains(consulta) || x.Cargo.Contains(consulta)).ToList());
            }
            else if (tipoDato == typeof(TPI.Entidades.Curso))
            {
                List<TPI.Entidades.Curso> cursos = TPI.Negocio.Curso.GetAll();
                ListaGeneral.Add(cursos.Where(x => x.Id.ToString().Contains(consulta) || x.CicloLectivo.ToString().Contains(consulta) || x.Materia.ToString().Contains(consulta) || x.Comision.ToString().Contains(consulta) || x.Cupo.ToString().Contains(consulta) || x.Dia.Contains(consulta)).ToList());
            }
            else if (tipoDato == typeof(TPI.Entidades.Materia))
            {
                List<TPI.Entidades.Materia> materias = TPI.Negocio.Materia.GetAll();
                ListaGeneral.Add(materias.Where(x => x.Id.ToString().Contains(consulta) || x.Descripcion.Contains(consulta)).ToList());
            }
            else if (tipoDato == typeof(TPI.Entidades.Persona))
            {
                List<TPI.Entidades.Persona> personas = TPI.Negocio.Persona.GetAll();
                ListaGeneral.Add(personas.Where(x => x.Dni.ToString().Contains(consulta)
                    || x.Nombre.ToUpper().Contains(consulta.ToUpper())
                    || x.Apellido.ToUpper().Contains(consulta.ToUpper())
                    || $"{x.Nombre} {x.Apellido}".ToUpper().Contains(consulta.ToUpper()))
                    .OrderBy(x => x.Apellido)
                    .ThenBy(x => x.Nombre).ToList());
            }
            else if (tipoDato == typeof(TPI.Entidades.Plan))
            {
                List<TPI.Entidades.Plan> planes = TPI.Negocio.Plan.GetAll();
                ListaGeneral.Add(planes.Where(x => x.Anio.ToString().Contains(consulta)
                || x.Especialidad.ToString().ToUpper().Contains(consulta.ToUpper()))
                    .Select(p => new
                    {
                        p.Especialidad,
                        p.Anio
                    })
                    .OrderBy(p => p.Especialidad.Descripcion)
                    .ThenBy(p => p.Anio)
                    .ToList());
            }
            else if (tipoDato == typeof(TPI.Entidades.Usuario))
            {
                List<TPI.Entidades.Usuario> usuarios = TPI.Negocio.Usuario.GetAllUsuarios();
                ListaGeneral.Add(usuarios.Where(x => x.Legajo.ToString().Contains(consulta))
                    .Select(x => new
                    {
                        x.Legajo,
                        x.Persona,
                        x.TipoDeUsuario,
                        x.Plan?.Especialidad,
                        x.Plan
                    }).ToList());
            }
            else if (tipoDato == typeof(TPI.Entidades.Especialidad))
            {
                List<TPI.Entidades.Especialidad> esp = TPI.Negocio.Especialidad.GetAllEspecialidades();
                ListaGeneral.Add(esp.Where(x => x.Descripcion.Contains(consulta) || x.Id.ToString().Contains(consulta)).ToList());
            }
            else if (tipoDato == typeof(TPI.Entidades.TipoDeUsuario))
            {
                List<TPI.Entidades.TipoDeUsuario> tip = TPI.Negocio.TipoDeUsuario.GetAllTiposDeUsuario();
                ListaGeneral.Add(tip.Where(x => x.Descripcion.Contains(consulta) || x.Id.ToString().Contains(consulta)).ToList());
            }
            else
            {

            }
            ActualizarGrilla();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {

            CargarDGV();
            ActualizarGrilla();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (tipoDato == typeof(TPI.Entidades.ProfesorCurso))
            {
                formAgregarProfesorCurso formAgregarProfesorCurso = new formAgregarProfesorCurso();
                formAgregarProfesorCurso.Show();
                formAgregarProfesorCurso.FormClosed += (s, args) => btnListar_Click(sender, e);

            }
            else if (tipoDato == typeof(TPI.Entidades.Curso))
            {
                formCrearCurso formCrearCurso = new formCrearCurso();
                formCrearCurso.Show();
                formCrearCurso.FormClosed += (s, args) => btnListar_Click(sender, e);


            }
            else if (tipoDato == typeof(TPI.Entidades.Cursado))
            {
                formAgregarCursado formAgregarCursado = new formAgregarCursado();
                formAgregarCursado.Show();
                formAgregarCursado.FormClosed += (s, args) => btnListar_Click(sender, e);
            }
            else if (tipoDato == typeof(TPI.Entidades.Materia))
            {
                formCrearMateria formCrearMateria = new formCrearMateria();
                formCrearMateria.Show();
                formCrearMateria.FormClosed += (s, args) => btnListar_Click(sender, e);

            }
            else if (tipoDato == typeof(TPI.Entidades.Persona))
            {
                formNuevaPersona formNuevaPersona = new formNuevaPersona();
                formNuevaPersona.Show();
                formNuevaPersona.FormClosed += (s, args) => btnListar_Click(sender, e);

            }
            else if (tipoDato == typeof(TPI.Entidades.Plan))
            {
                MessageBox.Show("No implementado");

            }
            else if (tipoDato == typeof(TPI.Entidades.Usuario))
            {
                formNuevoUsuario formNuevoUsuario = new formNuevoUsuario();
                formNuevoUsuario.Show();
                formNuevoUsuario.FormClosed += (s, args) => btnListar_Click(sender, e);
            }
            else if (tipoDato == typeof(TPI.Entidades.Comision))
            {
                formCrearComision formCrearComision = new formCrearComision();
                formCrearComision.Show();
                formCrearComision.FormClosed += (s, args) => btnListar_Click(sender, e);
            }
            else if (tipoDato == typeof(TPI.Entidades.Especialidad))
            {
                formCrearEspecialidad formCrearEspecialidad = new formCrearEspecialidad();
                formCrearEspecialidad.Show();
                formCrearEspecialidad.FormClosed += (s, args) => btnListar_Click(sender, e);
            }
            else if (tipoDato == typeof(TPI.Entidades.TipoDeUsuario))
            {
                //No implementado
            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvGrilla.SelectedRows.Count == 0) { MessageBox.Show("Debe seleccionar algo para ser borrado"); return; }
            DialogResult conf = MessageBox.Show("¿Estas seguro que deseas eliminar?", "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (conf == DialogResult.Yes)
            {
                int filaSeleccionada = dgvGrilla.SelectedRows[0].Index;
                if (tipoDato == typeof(TPI.Entidades.ProfesorCurso))
                {
                    List<TPI.Entidades.ProfesorCurso> lpc = (List<TPI.Entidades.ProfesorCurso>)ListaGeneral[0];
                    TPI.Negocio.ProfesorCurso.Eliminar(lpc[filaSeleccionada]);
                }
                else if (tipoDato == typeof(TPI.Entidades.Curso))
                {
                    List<TPI.Entidades.Curso> lpc = (List<TPI.Entidades.Curso>)ListaGeneral[0];
                    TPI.Negocio.Curso.Eliminar(lpc[filaSeleccionada]);
                }
                else if (tipoDato == typeof(TPI.Entidades.Cursado))
                {
                    List<TPI.Entidades.Cursado> lpc = (List<TPI.Entidades.Cursado>)ListaGeneral[0];
                    TPI.Negocio.Cursado.Eliminar(lpc[filaSeleccionada]);

                }
                else if (tipoDato == typeof(TPI.Entidades.Materia))
                {
                    //List<TPI.Entidades.Materia> lpc =  (List<TPI.Entidades.Materia>)ListaGeneral[0];
                    //TPI.Negocio.Materia.Eliminar(lpc[filaSeleccionada]);
                    //.FormClosed += (s, args) => btnListar_Click(sender, e);
                    MessageBox.Show("NO IMPLEMENTADO");
                }
                else if (tipoDato == typeof(TPI.Entidades.Persona))
                {
                    MessageBox.Show("No implementado");


                }
                else if (tipoDato == typeof(TPI.Entidades.Plan))
                {
                    //List<TPI.Entidades.Plan> lpc = (List<TPI.Entidades.Plan>)ListaGeneral[0];
                    //TPI.Negocio.Plan.Eliminar(lpc[filaSeleccionada]);
                    MessageBox.Show("NO IMPLEMENTADO");
                }
                else if (tipoDato == typeof(TPI.Entidades.Usuario))
                {
                    //List<TPI.Entidades.Usuario> lpc = (List<TPI.Entidades.Usuario>)ListaGeneral[0];
                    // TPI.Negocio.Usuario.Eliminar(lpc[filaSeleccionada]); 
                    MessageBox.Show("NO IMPLEMENTADO");
                }
                else if (tipoDato == typeof(TPI.Entidades.Comision))
                {
                    List<TPI.Entidades.Comision> lpc = (List<TPI.Entidades.Comision>)ListaGeneral[0];
                    TPI.Negocio.Comision.Eliminar(lpc[filaSeleccionada]);


                }
                else if (tipoDato == typeof(TPI.Entidades.Especialidad))
                {
                    //List<TPI.Entidades.Especialidad> lpc = (List<TPI.Entidades.Especialidad>)ListaGeneral[0];
                    //TPI.Negocio.Especialidad.Eliminar(lpc[filaSeleccionada]);
                    MessageBox.Show("NO IMPLEMENTADO");
                }
                else if (tipoDato == typeof(TPI.Entidades.TipoDeUsuario))
                {
                    //List<TPI.Entidades.TipoDeUsuario> lpc = (List<TPI.Entidades.TipoDeUsuario>)ListaGeneral[0];
                    //TPI.Negocio.TipoDeUsuario.Eliminar(lpc[filaSeleccionada]);
                    MessageBox.Show("NO IMPLEMENTADO");
                }

                btnListar_Click(sender, e);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvGrilla.SelectedRows.Count == 0) { MessageBox.Show("Debe seleccionar algo para ser Modificado"); return; }

            int filaSeleccionada = dgvGrilla.SelectedRows[0].Index;
            if (tipoDato == typeof(TPI.Entidades.ProfesorCurso))
            {
                List<TPI.Entidades.ProfesorCurso> lpc = (List<TPI.Entidades.ProfesorCurso>)ListaGeneral[0];
                formModificarProfesorCurso formModificarProfesorCurso = new formModificarProfesorCurso(lpc[filaSeleccionada]);
                formModificarProfesorCurso.Show();
                formModificarProfesorCurso.FormClosed += (s, args) => btnListar_Click(sender, e);
            }
            else if (tipoDato == typeof(TPI.Entidades.Curso))
            {
                List<TPI.Entidades.Curso> lpc = (List<TPI.Entidades.Curso>)ListaGeneral[0];
                formModificarCurso formModificarCurso = new formModificarCurso(lpc[filaSeleccionada]);
                formModificarCurso.Show();
                formModificarCurso.FormClosed += (s, args) => btnListar_Click(sender, e);

            }
            else if (tipoDato == typeof(TPI.Entidades.Cursado))
            {
                List<TPI.Entidades.Cursado> lpc = (List<TPI.Entidades.Cursado>)ListaGeneral[0];
                formModificarCursado formModificarCursado = new formModificarCursado(lpc[filaSeleccionada]);
                formModificarCursado.Show();
                formModificarCursado.FormClosed += (s, args) => btnListar_Click(sender, e);

            }
            else if (tipoDato == typeof(TPI.Entidades.Materia))
            {
                MessageBox.Show("NO IMPLEMENTADO");
            }
            else if (tipoDato == typeof(TPI.Entidades.Persona))
            {
                MessageBox.Show("NO IMPLEMENTADO");

            }
            else if (tipoDato == typeof(TPI.Entidades.Plan))
            {
                MessageBox.Show("NO IMPLEMENTADO");
            }
            else if (tipoDato == typeof(TPI.Entidades.Usuario))
            {
                MessageBox.Show("NO IMPLEMENTADO");
            }
            else if (tipoDato == typeof(TPI.Entidades.Comision))
            {
                List<TPI.Entidades.Comision> lpc = (List<TPI.Entidades.Comision>)ListaGeneral[0];
                formModificarComision formModificarComision = new formModificarComision(lpc[filaSeleccionada]);
                formModificarComision.Show();
                formModificarComision.FormClosed += (s, args) => btnListar_Click(sender, e);

            }
            else if (tipoDato == typeof(TPI.Entidades.Especialidad))
            {
                formModificarEspecialidad formModificarEspecialidad = new formModificarEspecialidad();
                formModificarEspecialidad.Show();
                formModificarEspecialidad.FormClosed += (s, args) => btnListar_Click(sender, e);

            }
            else if (tipoDato == typeof(TPI.Entidades.TipoDeUsuario))
            {
                MessageBox.Show("NO IMPLEMENTADO");
            }



        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (dgvGrilla.SelectedRows.Count == 0) { MessageBox.Show("Debe seleccionar algo para ser consultado"); return; }

            int filaSeleccionada = dgvGrilla.SelectedRows[0].Index;

            if (tipoDato == typeof(TPI.Entidades.ProfesorCurso))
            {
                List<TPI.Entidades.ProfesorCurso> lpc = (List<TPI.Entidades.ProfesorCurso>)ListaGeneral[0];
                formMostrarProfesorCurso formMostrarProfesorCurso = new formMostrarProfesorCurso(lpc[filaSeleccionada]);
                formMostrarProfesorCurso.Show();
                formMostrarProfesorCurso.FormClosed += (s, args) => btnListar_Click(sender, e);


            }
            else if (tipoDato == typeof(TPI.Entidades.Curso))
            {
                List<TPI.Entidades.Curso> lpc = (List<TPI.Entidades.Curso>)ListaGeneral[0];
                formMostrarCurso formMostrarCurso = new formMostrarCurso(lpc[filaSeleccionada]);
                formMostrarCurso.Show();
                formMostrarCurso.FormClosed += (s, args) => btnListar_Click(sender, e);
            }
            else if (tipoDato == typeof(TPI.Entidades.Cursado))
            {
                List<TPI.Entidades.Cursado> lpc = (List<TPI.Entidades.Cursado>)ListaGeneral[0];
                FormMostrarCursado formMostrarCursado = new FormMostrarCursado(lpc[filaSeleccionada]);
                formMostrarCursado.Show();
                formMostrarCursado.FormClosed += (s, args) => btnListar_Click(sender, e);
            }
            else if (tipoDato == typeof(TPI.Entidades.Materia))
            {
                List<TPI.Entidades.Materia> lpc = (List<TPI.Entidades.Materia>)ListaGeneral[0];
                formMostrarMateria formMostrarMateria = new formMostrarMateria(lpc[filaSeleccionada]);
                formMostrarMateria.Show();
                formMostrarMateria.FormClosed += (s, args) => btnListar_Click(sender, e);
            }
            else if (tipoDato == typeof(TPI.Entidades.Persona))
            {
                List<TPI.Entidades.Persona> lpc = (List<TPI.Entidades.Persona>)ListaGeneral[0];
                formMostrarPersona formMostrarPersona = new formMostrarPersona(lpc[filaSeleccionada]);
                formMostrarPersona.Show();
                formMostrarPersona.FormClosed += (s, args) => btnListar_Click(sender, e);
            }
            else if (tipoDato == typeof(TPI.Entidades.Plan))
            {
                MessageBox.Show("NO IMPLEMENTADO");
            }
            else if (tipoDato == typeof(TPI.Entidades.Usuario))
            {
                List<TPI.Entidades.Usuario> lpc = (List<TPI.Entidades.Usuario>)ListaGeneral[0];
                formConsultarDatosUsuario formConsultarDatosUsuario = new formConsultarDatosUsuario(lpc[filaSeleccionada]);
                formConsultarDatosUsuario.Show();
                formConsultarDatosUsuario.FormClosed += (s, args) => btnListar_Click(sender, e);
            }
            else if (tipoDato == typeof(TPI.Entidades.Comision))
            {
                List<TPI.Entidades.Comision> lpc = (List<TPI.Entidades.Comision>)ListaGeneral[0];
                formMostrarComision formMostrarComision = new formMostrarComision(lpc[filaSeleccionada]);
                formMostrarComision.Show();
                formMostrarComision.FormClosed += (s, args) => btnListar_Click(sender, e);
            }
            else if (tipoDato == typeof(TPI.Entidades.Especialidad))
            {
                List<TPI.Entidades.Especialidad> lpc = (List<TPI.Entidades.Especialidad>)ListaGeneral[0];
                formMostrarEspecialidad formMostrarEspecialidad = new formMostrarEspecialidad(lpc[filaSeleccionada]);
                formMostrarEspecialidad.Show();
                formMostrarEspecialidad.FormClosed += (s, args) => btnListar_Click(sender, e);
            }
            else if (tipoDato == typeof(TPI.Entidades.TipoDeUsuario))
            {
                MessageBox.Show("NO IMPLEMENTADO");
            }

        }
    }
}

