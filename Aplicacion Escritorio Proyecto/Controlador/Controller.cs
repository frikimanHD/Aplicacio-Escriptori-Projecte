using Aplicacion_Escritorio_Proyecto.Model;
using System; 

namespace Aplicacion_Escritorio_Proyecto.Controlador
{
    
    public class Controller
    {
        Form1 f;
        Usuari usuari;
        public Controller(Usuari usuari)
        {
            init(usuari);
            initListeners();
            f.Show();
        }
        void init(Usuari usuari)
        {
            f = new Form1();
            this.usuari = usuari;
            
        }
        void initListeners()
        {
            f.FormClosed += Sortir;
        }

        
        void Sortir(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

    }
}