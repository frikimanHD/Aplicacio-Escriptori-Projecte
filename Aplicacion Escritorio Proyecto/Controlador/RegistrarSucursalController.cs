using Aplicacion_Escritorio_Proyecto.Model;
using Aplicacion_Escritorio_Proyecto.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Escritorio_Proyecto.Controlador
{
    public class RegistrarSucursalController
    {
        CrearSucursal f;
        ClientHttp c;
        Comerç com;
        public RegistrarSucursalController(Comerç comerç, ClientHttp client)
        {
            init(comerç, client);
            initListeners();
            f.Show();

        }
        void init(Comerç comerç, ClientHttp client)
        {
            f = new CrearSucursal();
            c = client;
            com = comerç;
        }
        void initListeners()
        {
            f.CrearSucursalButton.Click += registrar;
            f.FormClosed += Tancar;
        }
        void registrar(object sender, EventArgs e)
        {
            Sucursal sucursal = new Sucursal();
            sucursal.Direccio = f.DireccioSucursalTextBox.Text;
            sucursal.ComerçId = com.ComerçId;
            c.PostSucursal(sucursal);
            f.Close();
        }
        public EventHandler tancar;
        public void Tancar (object sender, EventArgs e)
        {
            tancar.Invoke(this, EventArgs.Empty);
        }
    }
}
