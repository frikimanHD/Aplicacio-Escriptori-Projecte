using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Escritorio_Proyecto.Model
{
    public class Encarrec
    {
        public int EncarrecId {  get; set; }
        public decimal PreuTotal { get; set; }
        public DateTime? Data {  get; set; }
        public bool Pagat {  get; set; }
        public int SucursalId { get; set; }
        public int UsuId { get; set; }
        public string Estat {  get; set; }
        public Encarrec()
        {
            
        }
    }
}