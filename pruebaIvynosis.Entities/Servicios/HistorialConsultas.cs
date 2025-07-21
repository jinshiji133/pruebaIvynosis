using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pruebaIvynosis.Entities.Modelos;

namespace pruebaIvynosis.Entities.Servicios
{
    public class HistorialConsultas
    {
        private readonly List<Historial> _historial = new();

        public void add (string demandante, string demandado, string resultado)
        {
            _historial.Add(new Historial
            {
                Demandante = demandante,
                Demandado = demandado,
                Resultado = resultado
            });
        }
        public IReadOnlyList<Historial> GetAll ()
        {
            return _historial.AsReadOnly(); 
        }
    }
}
