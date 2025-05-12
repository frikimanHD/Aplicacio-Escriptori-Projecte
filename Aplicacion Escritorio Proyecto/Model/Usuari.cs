using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Escritorio_Proyecto.Model
{
    public class Usuari
    {
        public int? usuId {  get; set; }
        public string nomUsuari {  get; set; }
        public string correu { get; set; }
        public string contrasenya { get; set; }
        public string rol { get; set; }
        public int? sucursalId { get; set; }
        public int? comerçId { get; set; }

        public Usuari()
        {
            
        }

        public Usuari(string NomUsuari, string Correu, string Contrasenya, string Rol, int? SucursalId, int? ComerçId)
        {
            this.nomUsuari = NomUsuari;
            this.correu = Correu;
            this.contrasenya = Contrasenya;
            this.rol = Rol;
            this.sucursalId = SucursalId;
            this.comerçId = ComerçId;
        }
    }
}
