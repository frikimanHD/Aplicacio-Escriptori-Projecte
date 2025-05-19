using Aplicacion_Escritorio_Proyecto.Model;
using Aplicacion_Escritorio_Proyecto.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Aplicacion_Escritorio_Proyecto.Controlador
{
    public class SeleccionarSucursalController
    {
        Comerç com;
        ClientHttp c;
        SeleccionarSucursal f;
        public SeleccionarSucursalController(Comerç comerç, ClientHttp client)
        {
            init(comerç, client);
            initListeners();
            f.Show();
        }
        void init(Comerç comerç, ClientHttp client)
        {
            com = comerç;
            c = client;
            f = new SeleccionarSucursal();
            f.SucursalsComboBox.DataSource = c.GetSucursalsComerç(com.ComerçId);
            f.SucursalsComboBox.DisplayMember = "Direccio";
        }
        void initListeners()
        {
            f.SeleccionarButton.Click += Seleccionar;
            f.CrearSucursalButton.Click += CrearSucursal;
        }
        void Seleccionar(object sender, EventArgs e)
        {
            Sucursal sucursal = (Sucursal)f.SucursalsComboBox.SelectedItem;
            f.Hide();
            new Controller(sucursal, c);
            
        }
        void CrearSucursal(object sender, EventArgs e)
        {
            RegistrarSucursalController reg = new RegistrarSucursalController(com, c);
            f.Hide();
            reg.tancar += (s, args) =>
            {
                f.Show();
                f.SucursalsComboBox.DataSource = c.GetSucursalsComerç(com.ComerçId);
            };
        }
    }
}
