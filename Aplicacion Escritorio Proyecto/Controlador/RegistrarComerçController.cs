using Aplicacion_Escritorio_Proyecto.Model;
using Aplicacion_Escritorio_Proyecto.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Aplicacion_Escritorio_Proyecto.Controlador
{
    public class RegistrarComerçController
    {
        Usuari usuari;
        ClientHttp c;
        CrearComerç f;
        public RegistrarComerçController(Usuari usuari, ClientHttp client)
        {
            
            init(usuari, client);
            initListeners();
            f.Show();

        }
        void init(Usuari usuari, ClientHttp client)
        {
            f = new CrearComerç();
            this.usuari = usuari;
            this.c = client;
        }
        void initListeners()
        {
            f.registrarComerçButton.Click += registrar;
        }
        void registrar(object sender, EventArgs e)
        {
            try
            {
                string regex = "[a-zA-Z0-9_]+([.][a-zA-Z0-9_]+)*@[a-zA-Z0-9_]+([.][a-zA-Z0-9_]+)*[.][a-zA-Z]{2,5}";
                Comerç comerç = new Comerç();
                comerç.Nom = f.nomComerçTextBox.Text;
                comerç.Telefon = f.telefonComerçTextBox.Text;
                if(!Regex.IsMatch(f.emailComerçTextBox.Text, regex))
                {
                    throw new Exception("Introdueix un email valid");
                }
                comerç.Email = f.emailComerçTextBox.Text;
                if (!CheckDNI(f.NIFComerçTextBox.Text))
                {
                    throw new Exception("NIE no valid");
                }
                
                comerç.NIF = f.NIFComerçTextBox.Text;
                c.PostComerç(usuari, comerç);
                f.Hide();
                new SeleccionarSucursalController(comerç, c);
            }
            catch (Exception ex)
            {
                f.ErrorLabel.Text = ex.Message;
            }
            

            
       }
        bool CheckDNI(string dni)
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




    }
}
