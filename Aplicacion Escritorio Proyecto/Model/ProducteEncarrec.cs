using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Escritorio_Proyecto.Model
{
    public class ProducteEncarrec
    {
        public string CodiDeBarres {  get; set; }
        public int EncarrecId { get; set; }
        public int Quantitat { get; set; }

        public ProducteEncarrec()
        {
            
        }
    }
}
