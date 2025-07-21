using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaIvynosis.Entities.Modelos
{
    //Definir todos los datos que necesites consultar
    public class Historial
    {
        public string Demandante { get; set; }
        public string Demandado { get; set; }
        public string Resultado { get; set; }
        public DateTime Fecha { get; set; } = DateTime.UtcNow;
    }
}
