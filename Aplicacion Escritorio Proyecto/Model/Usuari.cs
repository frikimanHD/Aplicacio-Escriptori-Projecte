using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Escritorio_Proyecto.Model
{
    public class Usuari
    {
        public int? UsuariId {  get; set; }
        public string NomUsuari {  get; set; }
        public string Correu { get; set; }
        public string Contrasenya { get; set; }
        public string Rol { get; set; }
        public int? SucursalId { get; set; }
        public int? ComerçId { get; set; }

        public Usuari()
        {
            
        }

        public Usuari(string NomUsuari, string Correu, string Contrasenya, string Rol, int? SucursalId, int? ComerçId)
        {
            this.NomUsuari = NomUsuari;
            this.Correu = Correu;
            this.Contrasenya = Contrasenya;
            this.Rol = Rol;
            this.SucursalId = SucursalId;
            this.ComerçId = ComerçId;
        }
    }
}
