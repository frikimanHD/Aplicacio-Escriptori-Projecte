using Aplicacion_Escritorio_Proyecto.Vista;
using Aplicacion_Escritorio_Proyecto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplicacion_Escritorio_Proyecto.Controlador;

namespace Aplicacion_Escritorio_Proyecto
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new LoginController();
            
        }
    }
}
