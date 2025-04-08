using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Escritorio_Proyecto.Model
{
    public class Comerç
    {
        public int ComerçId { get; set; }
        public string Nom { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string NIF {  get; set; }

        public Comerç()
        {
            
        }

        public Comerç(string Nom, string Telefon, string Email, string NIF)
        {
            this.Nom = Nom;
            this.Telefon = Telefon;
            this.Email = Email;
            this.NIF = NIF;
            
        }
    }
}
