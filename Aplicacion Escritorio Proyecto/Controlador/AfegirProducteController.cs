using Aplicacion_Escritorio_Proyecto.Model;
using Aplicacion_Escritorio_Proyecto.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Escritorio_Proyecto.Controlador
{
    public class AfegirProducteController
    {
        Producte prod;
        bool edicio = false;
        AfegirProducte f;
        int stock;
        ClientHttp c;
        public AfegirProducteController(Producte? producte, int? stock, ClientHttp client)
        {
            init(producte, stock, client);
            initListeners();
            f.ShowDialog();
        }
        void init(Producte? producte, int? stock, ClientHttp client)
        {
            f = new AfegirProducte();
            c = client;
            if (producte != null)
            {
                prod = producte;
                f.CodiBarresTextBox.Text = prod.CodiDeBarres;
                f.CodiBarresTextBox.ReadOnly = true;
                f.NomTextBox.Text = prod.Nom;
                f.DescripcioTextBox.Text = prod.Descripcio;
                f.PreuTextBox.Text = prod.Preu.ToString();
                f.StockTextBox.Text = stock.ToString();
                f.CategoriaComboBox.SelectedIndex = f.CategoriaComboBox.Items.IndexOf(prod.Categoria);
                
                edicio = true;
            }
            
        }
        void initListeners()
        {

        }
        void afegir(object sender, EventArgs e)
        {
            if (edicio)
            {
                prod.Nom = f.NomTextBox.Text;
                prod.Descripcio = f.DescripcioTextBox.Text;
                prod.Categoria = f.CategoriaComboBox.SelectedItem.ToString();
            }
        }

    }
}
