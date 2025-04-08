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

        public List<Producte> Cistella { get; set; }

        public Encarrec()
        {
            
        }

        public Encarrec(decimal PreuTotal, DateTime? Data, bool Pagat, int SucursalId, int UsuId, List<Producte> Cistella)
        {
            this.PreuTotal = PreuTotal;
            this.Data = Data;
            this.Pagat = Pagat;
            this.SucursalId = SucursalId;
            this.UsuId = UsuId;
            this.Cistella = Cistella;

        }
    }
}
