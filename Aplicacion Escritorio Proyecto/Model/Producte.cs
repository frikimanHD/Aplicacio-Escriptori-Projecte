using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Escritorio_Proyecto.Model
{
    public class Producte
    {
        public string CodiDeBarres {  get; set; }
        public string Nom {  get; set; }
        public string Imatge { get; set; }
        public string Descripcio { get; set; }
        public double Preu { get; set; }
        public string Categoria { get; set; }
    }
}
