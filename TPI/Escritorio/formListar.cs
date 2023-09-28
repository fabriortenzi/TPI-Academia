using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio.Generalizado
{
    public partial class formListar : Form
    {
        private Type? tipoDato;
        public formListar(Type tipo_dato)
        {
            InitializeComponent();
            tipoDato = tipo_dato;
        }

        private void formListar_Load(object sender, EventArgs e)
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

            this.Text = $"Listar-{nom_clase}";
            lblClase.Text = nom_clase;


            ActualizarDGV();
        }

        private void ActualizarDGV()
        {

            dgvGrilla.DataSource = null;

            if (tipoDato == typeof(TPI.Entidades.ProfesorCurso))
            {
                dgvGrilla.DataSource = TPI.Negocio.ProfesorCurso.GetAllProfesorCurso();
            }
            else if (tipoDato == typeof(TPI.Entidades.Curso))
            {
                dgvGrilla.DataSource = TPI.Negocio.Curso.GetAll();
            }
            else if (tipoDato == typeof(TPI.Entidades.Cursado))
            {
                //dgvGrilla.DataSource = TPI.Negocio.InscripcionCursado.GetAllInscripcion();
            }
            else if (tipoDato == typeof(TPI.Entidades.Materia))
            {
                dgvGrilla.DataSource = TPI.Negocio.Materia.GetAll();
            }
            else if (tipoDato == typeof(TPI.Entidades.Persona))
            {
                dgvGrilla.DataSource = TPI.Negocio.Persona.GetAll();
            }
            else if (tipoDato == typeof(TPI.Entidades.Plan))
            {
                dgvGrilla.DataSource = TPI.Negocio.Plan.GetAll();
            }
            else if (tipoDato == typeof(TPI.Entidades.Usuario))
            {
                dgvGrilla.DataSource = TPI.Negocio.Usuario.GetAllUsuarios();
            }


        }

        



            private void btnBuscar_Click(object sender, EventArgs e)
        {
            string consulta =txtConsulta.Text;
            
                //if (tipoDato == typeof(TPI.Entidades.MateriaAprobada))
                //{
                //    List<TPI.Entidades.MateriaAprobada> materias_aprobadas = TPI.Negocio.MateriaAprobada.GetAllMateriaAprobada();
                //    dgvGrilla.DataSource = materias_aprobadas.Where(x => x.Legajo.ToString().Contains(consulta) || x.idMateria.ToString().Contains(consulta)).ToList();
                //}
                //else if (tipoDato == typeof(TPI.Entidades.MateriaComision))
                //{
                //    List<TPI.Entidades.MateriaComision> materias_comisiones = TPI.Negocio.MateriaComision.GetAllMateriaComision();
                //    dgvGrilla.DataSource = materias_comisiones.Where(x => x.idMateria.ToString().Contains(consulta) || x.IdEspecialidad.ToString().Contains(consulta) || x.IdCom.ToString().Contains(consulta)).ToList();
                //}
                //else if (tipoDato == typeof(TPI.Entidades.ProfesorCurso))
                //{
                //    List<TPI.Entidades.ProfesorCurso> profesor_curso = TPI.Negocio.ProfesorCurso.GetAllProfesorCurso();
                //    dgvGrilla.DataSource = profesor_curso.Where(x => x.Legajo.ToString().Contains(consulta) || x.Anio.ToString().Contains(consulta) || x.idMateria.ToString().Contains(consulta)).ToList();
                //}
                //else if (tipoDato == typeof(TPI.Entidades.Evaluacion))
                //{
                //    List<TPI.Entidades.Evaluacion> evaluaciones = TPI.Negocio.Evaluaciones.GetAllEvaluacion();
                //    dgvGrilla.DataSource = evaluaciones.Where(x => x.Id.ToString().Contains(consulta)).ToList();
                //}
                //else if (tipoDato == typeof(TPI.Entidades.Curso))
                //{
                //    List <TPI.Entidades.Curso> cursos = TPI.Negocio.Curso.GetAll();
                //    dgvGrilla.DataSource = cursos.Where(x => x.Año.ToString().Contains(consulta) || x.IdMateria.ToString().Contains(consulta));
                //}
                //else if (tipoDato == typeof(TPI.Entidades.InscripcionCursado))
                //{
                //    List<TPI.Entidades.InscripcionCursado> inscripciones = TPI.Negocio.InscripcionCursado.GetAllInscripcion();
                //    dgvGrilla.DataSource = inscripciones.Where(x => x.LegajoUsuario.ToString().Contains(consulta) || x.FechaHora.ToString().Contains(consulta));
                //}
                //else if (tipoDato == typeof(TPI.Entidades.Materia))
                //{
                //    List<TPI.Entidades.Curso> cursos = TPI.Negocio.Curso.GetAll();
                //    dgvGrilla.DataSource = cursos.Where(x => x.Año.ToString().Contains(consulta) || x.IdMateria.ToString().Contains(consulta));
                //}
                if (tipoDato == typeof(TPI.Entidades.Persona))
                {
                    List<TPI.Entidades.Persona> personas = TPI.Negocio.Persona.GetAll();
                    dgvGrilla.DataSource = personas.Where(x => x.Dni.ToString().Contains(consulta));
                }
                else if (tipoDato == typeof(TPI.Entidades.Plan))
                {
                    List<TPI.Entidades.Plan> planes = TPI.Negocio.Plan.GetAll();
                    dgvGrilla.DataSource = planes.Where(x => x.Anio.ToString().Contains(consulta) || x.Especialidad.Id.ToString().Contains(consulta));
                }
                else if (tipoDato == typeof(TPI.Entidades.Usuario))
                {
                    List<TPI.Entidades.Usuario> usuarios = TPI.Negocio.Usuario.GetAllUsuarios();
                    dgvGrilla.DataSource = usuarios.Where(x => x.Legajo.ToString().Contains(consulta));
                }
                else
                {
                    
                }

            
            dgvGrilla.Update();
            dgvGrilla.Refresh();



        }


    }
    }

