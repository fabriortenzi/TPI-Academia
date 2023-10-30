using Escritorio.Comision;
using Escritorio.Curso;
using Escritorio.Generalizado;
using Escritorio.Inscripcion;
using Escritorio.ProfesorCurso;
using Escritorio.Reportes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new formLogin());
            Application.Run(new formLogin());
        }
    }
}
