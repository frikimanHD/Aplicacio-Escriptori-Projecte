using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Escritorio_Proyecto.Model
{
    public class Stock
    {
        public string CodiDeBarres { get; set; } = null!;

        public int SucursalId { get; set; }

        public int? Stock1 { get; set; }
        public Stock()
        {
            
        }
    }
}
