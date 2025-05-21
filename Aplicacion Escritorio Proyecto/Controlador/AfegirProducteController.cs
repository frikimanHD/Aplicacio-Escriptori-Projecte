using Aplicacion_Escritorio_Proyecto.Model;
using Aplicacion_Escritorio_Proyecto.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        Sucursal sucur;
        public AfegirProducteController(Producte? producte, int? stock, ClientHttp client, Sucursal sucur)
        {
            init(producte, stock, client, sucur);
            initListeners();
            f.ShowDialog();
        }
        void init(Producte? producte, int? stock, ClientHttp client, Sucursal sucursal)
        {
            f = new AfegirProducte();
            c = client;
            sucur = sucursal;
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
            f.ConfirmarButton.Click += afegir;
        }
        async void afegir(object sender, EventArgs e)
        {
            if (edicio)
            {
                prod.Nom = f.NomTextBox.Text;
                prod.Descripcio = f.DescripcioTextBox.Text;
                prod.Categoria = f.CategoriaComboBox.SelectedItem.ToString();
                prod.Preu = Double.Parse(f.PreuTextBox.Text);
                stock = Int32.Parse(f.StockTextBox.Text);
                Stock s = new Stock();
                s.CodiDeBarres = prod.CodiDeBarres;
                s.Stock1 = stock;
                s.SucursalId = sucur.SucursalId.Value;
                c.PutProducte(prod);
                
                c.PutStock(s);
            }
            else
            {
                prod = new Producte();
                prod.CodiDeBarres = f.CodiBarresTextBox.Text;
                prod.Nom = f.NomTextBox.Text;
                prod.Descripcio = f.DescripcioTextBox.Text;
                prod.Categoria = f.CategoriaComboBox.SelectedItem.ToString();
                prod.Preu = Double.Parse(f.PreuTextBox.Text);
                stock = Int32.Parse(f.StockTextBox.Text);
                Stock s = new Stock();
                s.CodiDeBarres = prod.CodiDeBarres;
                s.Stock1 = stock;
                s.SucursalId = sucur.SucursalId.Value;
                await c.PostProducte(prod);
                
                await c.PostStock(s);
                
                
                
            }
            f.Close();
        }

    }
}
