using Aplicacion_Escritorio_Proyecto.Model;
using Aplicacion_Escritorio_Proyecto.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Escritorio_Proyecto.Controlador
{
    public class EditarEstatController
    {
        EditarEstat f;
        ClientHttp c;
        int en;
        public EditarEstatController(int encarrec, ClientHttp client)
        {
            init(encarrec, client);
        }
        void init(int encarrec, ClientHttp client)
        {
            en = encarrec;
            c = client;
            f = new EditarEstat();
            initListeners();
            f.ShowDialog();
        }

        void initListeners()
        {
            f.ConfirmarButton.Click += modificar;
        }
        async void modificar(object sender, EventArgs e)
        {
            string estat = f.EstatComboBox.SelectedItem.ToString();
            await c.EditarEstat(en, estat);
            f.Close();
        }
    }
}
