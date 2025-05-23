using Aplicacion_Escritorio_Proyecto.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

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
            refreshProductes();
            refreshEncarrecs();
            f.GenerarFacturaComandaButton.Enabled = false;
            f.NomComerçTextBox.Text = comerç.Nom;
            f.NIFComerçTextBox.Text = comerç.NIF;
            f.DireccioComerçTextBox.Text = s.Direccio;
            f.TelefonComerçTextBox.Text = comerç.Telefon;
            f.EmailComerçTextBox.Text = comerç.Email;
            refreshClients();
        }
        
        void initListeners()
        {
            f.FormClosed += Sortir;
            f.RefrescarProductesButton.Click += refrescarProductes;
            f.AfegirProducteButton.Click += afegirProducte;
            f.ModificarProducteButton.Click += modificarProducte;
            f.EliminarProducteButton.Click += eliminarProducte;
            f.ComandesListView.SelectedIndexChanged += EncarrecSeleccionat;
            f.EliminarComandesButton.Click += EliminarEncarrec;
            f.ModEstatComandaButton.Click += EditarEstat;
            f.RefrescarComandesButton.Click += refrescarEncarrecs;
            f.ActualitzarComerçButton.Click += ModificarComerç;
        }
        void afegirProducte(object sender, EventArgs e)
        {
            new AfegirProducteController(null, null, c, s);
            refreshProductes();
        }
        void modificarProducte(object sender, EventArgs e)
        {
            var prod = f.ListViewProductes.SelectedItems[0];
            Producte p = new Producte();
            p.CodiDeBarres = prod.Text;
            p.Nom = prod.SubItems[1].Text;
            p.Imatge = prod.SubItems[2].Text;
            p.Descripcio = prod.SubItems[3].Text;
            p.Preu = Double.Parse(prod.SubItems[4].Text);
            int stock = Int32.Parse(prod.SubItems[5].Text);
            p.Categoria = prod.SubItems[6].Text;

            new AfegirProducteController(p, stock, c, s);
            refreshProductes();
        }
        async void eliminarProducte(object sender, EventArgs e)
        {
            
            int id = this.s.SucursalId.Value;
            string codi = f.ListViewProductes.SelectedItems[0].Text;
            Debug.WriteLine(codi);
            try
            {
                await c.DelStock(codi, id);
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            
            refreshProductes();

        }
        void refrescarProductes(object sender, EventArgs e)
        {
            refreshProductes();
        }
        void refrescarEncarrecs(object sender, EventArgs e)
        {
            refreshEncarrecs();
        }
        void refreshEncarrecs()
        {
            f.ComandesListView.Items.Clear();
            List<Encarrec> encarrecs = c.GetEncarrecsSucursal(s.SucursalId.Value);
            foreach(Encarrec rec in encarrecs)
            {
                List<ProducteEncarrec> producteEncarrecs = c.GetProducteEncarrecs(rec.EncarrecId);
                ListViewItem item = new ListViewItem(rec.EncarrecId.ToString());
                item.SubItems.Add(c.GetUsuariId(rec.UsuId).nomUsuari);
                item.SubItems.Add(rec.PreuTotal.ToString());
                item.SubItems.Add(rec.Data.ToString());
                item.SubItems.Add(rec.Pagat ? "Pagat" : "No pagat");
                item.SubItems.Add(producteEncarrecs.Select(x => x.Quantitat).Sum().ToString());
                item.SubItems.Add(rec.Estat);
                f.ComandesListView.Items.Add(item);
            }
            f.ComandesListView.Refresh();
        }
        void refreshProductes()
        {
            f.ListViewProductes.Items.Clear();
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
        void EncarrecSeleccionat(object sender, EventArgs eventArgs)
        {
            f.ProductesEncarrecListView.Items.Clear();
            Encarrec e = new Encarrec();
            int id = 0;
            foreach(ListViewItem item in f.ComandesListView.SelectedItems)
            {
                id = Int32.Parse(item.SubItems[0].Text);
            }
            List<Producte> productes = c.GetProductesDeEncarrec(id);
            List<ProducteEncarrec> producteEncarrecs = c.GetProducteEncarrecs(id);
            foreach(Producte p in productes)
            {
                ListViewItem item = new ListViewItem(p.CodiDeBarres);
                item.SubItems.Add(p.Nom);
                item.SubItems.Add(producteEncarrecs.Where(en => en.CodiDeBarres == p.CodiDeBarres).Select(en => en.Quantitat).First().ToString());
                item.SubItems.Add(p.Preu.ToString());
                f.ProductesEncarrecListView.Items.Add(item);
            }
            f.ProductesEncarrecListView.Refresh();
        }
        async void EliminarEncarrec (object sender, EventArgs e)
        {
            int id = 0;
            foreach (ListViewItem item in f.ComandesListView.SelectedItems)
            {
                id = Int32.Parse(item.SubItems[0].Text);
            }
            await c.DelEncarrec(id);
            refreshEncarrecs();
        }
        void EditarEstat(object sender, EventArgs e)
        {
            int id = 0;
            foreach (ListViewItem item in f.ComandesListView.SelectedItems)
            {
                id = Int32.Parse(item.SubItems[0].Text);
            }
            new EditarEstatController(id, c);
            refreshEncarrecs();
        }
        void Sortir(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        async void ModificarComerç(object sender, EventArgs e)
        {
            try
            {
                string regex = "[a-zA-Z0-9_]+([.][a-zA-Z0-9_]+)*@[a-zA-Z0-9_]+([.][a-zA-Z0-9_]+)*[.][a-zA-Z]{2,5}";
                comerç.Nom = f.NomComerçTextBox.Text;
                comerç.NIF = f.NIFComerçTextBox.Text;
                comerç.Email = f.EmailComerçTextBox.Text;
                comerç.Telefon = f.TelefonComerçTextBox.Text;
                s.Direccio = f.DireccioComerçTextBox.Text;
                if(!Regex.IsMatch(comerç.Email, regex))
                {
                    throw new Exception("Email invalid");
                }
                if (!CheckDNI(comerç.NIF))
                {
                    throw new Exception("NIF invalid");
                }
                await c.PutComerç(comerç);
                await c.PutSucursal(s);
                f.NomComerçTextBox.Clear();
                f.NIFComerçTextBox.Clear();
                f.EmailComerçTextBox.Clear();
                f.TelefonComerçTextBox.Clear();
                f.DireccioComerçTextBox.Clear();
                f.labelErrorComerç.Text = "";
            }
            catch (Exception ex)
            {
                f.labelErrorComerç.Text = ex.Message;
            }
            
        }
        private  bool CheckDNI(string dni)
        {
            //Comprobamos si el DNI tiene 9 digitos
            if (dni.Length != 9)
            {
                //No es un DNI Valido
                return false;
            }

            //Extraemos los números y la letra
            string dniNumbers = dni.Substring(0, dni.Length - 1);
            string dniLeter = dni.Substring(dni.Length - 1, 1);
            //Intentamos convertir los números del DNI a integer
            var numbersValid = int.TryParse(dniNumbers, out int dniInteger);
            if (!numbersValid)
            {
                //No se pudo convertir los números a formato númerico
                return false;
            }
            if (CalculateDNILeter(dniInteger) != dniLeter)
            {
                //La letra del DNI es incorrecta
                return false;
            }
            //DNI Valido :)
            return true;
        }
        string CalculateDNILeter(int dniNumbers)
        {
            //Cargamos los digitos de control
            string[] control = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
            var mod = dniNumbers % 23;
            return control[mod];
        }

        void refreshClients()
        {
            f.ClientsListView.Items.Clear();
            List<Usuari> usuaris = c.GetUsuarisSucursal(s.SucursalId.Value);
            List<Encarrec> encarrecs = c.GetEncarrecsSucursal(s.SucursalId.Value);

            foreach(Usuari u in usuaris)
            {
                ListViewItem item = new ListViewItem(u.nomUsuari);
                int comandes = encarrecs.Where(e => e.UsuId == u.usuId).Count();
                item.SubItems.Add(u.correu);
                item.SubItems.Add(comandes.ToString());
                item.SubItems.Add(comandes >= 10 ? "Recurent" : "No recurrent");
                f.ClientsListView.Items.Add(item);
            }
            f.ClientsListView.Refresh();
            f.TopClientsListView.Items.Clear();
            List<ListViewItem> items = new List<ListViewItem>();
            foreach(Usuari u in usuaris)
            {
                ListViewItem item = new ListViewItem(u.nomUsuari);
                int comandes = encarrecs.Where(e => e.UsuId == u.usuId).Count();
                item.SubItems.Add(comandes.ToString());
                items.Add(item);
            }
            items.OrderByDescending(x => x.SubItems[1]);
            f.TopClientsListView.Items.AddRange(items.ToArray());
            f.TopClientsListView.Refresh();
        }
    }
}