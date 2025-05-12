using Aplicacion_Escritorio_Proyecto.Model;
using Aplicacion_Escritorio_Proyecto.Vista;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Aplicacion_Escritorio_Proyecto.Controlador
{
    public class LoginController
    {
        Login login;
        ClientHttp client;
        public LoginController()
        {
            init();
            initListeners();
            Application.Run(login);
        }

        public void init()
        {
            login = new Login();
            client = new ClientHttp();
            login.labelError.ForeColor = Color.Red;

            
            
        }
        public void initListeners()
        {
            login.LoginButton.Click += ferLogin;
            login.RegistrarseButton.Click += ferRegistre;
        }

        public void ferLogin(object sender, EventArgs e)
        {
            try
            {
                string correu = login.UsuariLoginTextBox.Text;
                if (String.IsNullOrWhiteSpace(correu))
                {
                    throw new Exception("Introdueix el teu correu");
                }
                string contrasenya = login.ContrasenyaLoginTextBox.Text;
                if (String.IsNullOrWhiteSpace(contrasenya))
                {
                    throw new Exception("Introdueix la teva contrasenya");
                }
                Usuari user = client.GetUsuari(correu);
                if(user == null)
                {
                    throw new Exception("Usuari no trobat");
                }
                if(contrasenya != user.contrasenya)
                {
                    throw new Exception("La contrasenya no es correcta");
                }
                var app = new Form1();
                login.Hide();
                new Controller();
            }catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                login.labelError.Text = ex.Message;
            }
            
        }
        void ferRegistre(object sender, EventArgs e)
        {
            RegistreController reg = new RegistreController();
            login.Hide();
            reg.Closing += (s, args) =>
            {
                login.Show();
            };
        }

        

    }
}
