using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pruebaIvynosis.Entities.Servicios;

namespace pruebaIvynosis.Aplicacion.pruebaIvynosis.casosDeUso
{
    public class JuicioCasoDeUso
    {
        private readonly CalculadoraPuntos _calculadora;

        public JuicioCasoDeUso(CalculadoraPuntos calculadora)
        {
            _calculadora = calculadora;
        }

        public string ImprimirGanador(string demandante, string demandado)
        {
            var puntosDemandante = _calculadora.CalcularPuntuacion(demandante);
            var puntosDemandado = _calculadora.CalcularPuntuacion(demandado);

            if (puntosDemandante > puntosDemandado)
            {
                return "Gana demandante";
            }
            if (puntosDemandado > puntosDemandante)
            {
                return "Gana demandado";
            }
            return "Empate";
        }
    }
}
