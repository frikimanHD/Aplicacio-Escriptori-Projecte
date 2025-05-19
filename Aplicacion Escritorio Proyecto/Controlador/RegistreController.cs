using Aplicacion_Escritorio_Proyecto.Model;
using Aplicacion_Escritorio_Proyecto.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Escritorio_Proyecto.Controlador
{
    public class RegistreController
    {
        Registre f;
        ClientHttp c;
        public RegistreController()
        {
            init();
            initListeners();
            f.Show();
        }
        void init()
        {
            f = new Registre();
            c = new ClientHttp();
        }
        void initListeners()
        {
            f.RegistrarseButtonRegistre.Click += registrar;
            f.FormClosing += Tancant;
            f.CancelaButtonRegistre.Click += tancar;
        }
        void tancar (object sender, EventArgs e)
        {
            f.Close();
        }
        bool verificarMail(string email)
        {
            string regex = "[a-zA-Z0-9_]+([.][a-zA-Z0-9_]+)*@[a-zA-Z0-9_]+([.][a-zA-Z0-9_]+)*[.][a-zA-Z]{2,5}";
            var correuNuvol = c.GetUsuaris().Select(x=>x.correu);
            return Regex.IsMatch(email, regex) && !correuNuvol.Contains(email);
            
        }
        void registrar (object sender, EventArgs e)
        {
            try
            {
                if(f.ContrasenyaTextBoxRegistre.Text != f.ConfirmaTextBoxRegistre.Text)
                {
                    throw new Exception("Les contrasenyes no coincideixen.");
                }
                if (!verificarMail(f.CorreuTextBoxRegistre.Text))
                {
                    throw new Exception("Introdueix un correu valid que no estigui en us.");
                }
                string correu = f.CorreuTextBoxRegistre.Text;
                string usuari = f.NomUsuariTextBoxRegistre.Text;
                string contrasenya = f.ContrasenyaTextBoxRegistre.Text;

                Usuari u = new Usuari();
                u.correu = correu;
                u.nomUsuari = usuari;
                u.contrasenya = contrasenya;
                u.rol = "Admin";
                c.PostUsuari(u);

            }
            catch(Exception ex)
            {
                f.ErrorLabelRegistre.Text = ex.Message;
            }
        }
        public EventHandler Closing;
        private void Tancant(object sender, EventArgs e)
        {
            Closing.Invoke(this, EventArgs.Empty);
        }



    }
}
