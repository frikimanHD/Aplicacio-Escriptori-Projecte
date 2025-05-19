using Aplicacion_Escritorio_Proyecto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Aplicacion_Escritorio_Proyecto.Controlador
{
    
    public class Controller
    {
        Form1 f;
        Sucursal s;
        ClientHttp c;
        Comerç comerç;
        public Controller(Sucursal sucursal, ClientHttp client)
        {
            init(sucursal, client);
            initListeners();
            f.Show();
        }
        void init(Sucursal sucursal, ClientHttp client)
        {
            f = new Form1();
            this.s = sucursal;
            c = client;
            comerç = c.GetComerç(s.ComerçId);
            List<Stock> stock = c.GetStock(s.SucursalId.Value);
            List<Producte> productes = new List<Producte>();
            foreach (Stock stockitem in stock)
            {
                Producte p = c.GetProducte(stockitem.CodiDeBarres);
                productes.Add(p);
            }
            foreach (Producte p in productes)
            {
                ListViewItem item = new ListViewItem(p.CodiDeBarres);
                item.SubItems.Add(p.Nom);
                item.SubItems.Add(p.Imatge);
                item.SubItems.Add(p.Descripcio);
                item.SubItems.Add(p.Preu.ToString());
                item.SubItems.Add(stock.Where(s=>s.CodiDeBarres == p.CodiDeBarres).Select(s=>s.Stock1).FirstOrDefault().ToString());
                item.SubItems.Add(p.Categoria);

                f.ListViewProductes.Items.Add(item);
            }
            f.ListViewProductes.Refresh();
            
        }
        void afegir (object sender, EventArgs e)
        {

        }
        void initListeners()
        {
            f.FormClosed += Sortir;
            f.RefrescarProductesButton.Click += refrescar;
        }
        void refrescar(object sender, EventArgs e)
        {
            List<Stock> stock = c.GetStock(s.SucursalId.Value);
            List<Producte> productes = new List<Producte>();
            foreach (Stock stockitem in stock)
            {
                Producte p = c.GetProducte(stockitem.CodiDeBarres);
                productes.Add(p);
            }
            foreach (Producte p in productes)
            {
                ListViewItem item = new ListViewItem(p.CodiDeBarres);
                item.SubItems.Add(p.Nom);
                item.SubItems.Add(p.Imatge);
                item.SubItems.Add(p.Descripcio);
                item.SubItems.Add(p.Preu.ToString());
                item.SubItems.Add(stock.Where(s => s.CodiDeBarres == p.CodiDeBarres).Select(s => s.Stock1).FirstOrDefault().ToString());
                item.SubItems.Add(p.Categoria);

                f.ListViewProductes.Items.Add(item);
            }
            f.ListViewProductes.Refresh();
        }
        
        void Sortir(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

    }
}