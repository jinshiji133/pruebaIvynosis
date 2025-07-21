using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pruebaIvynosis.Entities.Servicios;

namespace pruebaIvynosis.Aplicacion.pruebaIvynosis.casosDeUso
{
    //Definición de todos los casos de uso posible, gana x, gana y y empate
    public class JuicioCasoDeUso
    {
        private readonly CalculadoraPuntos _calculadora;
        //Parte 2 de la prueba
        private readonly HistorialConsultas _historial;

        public JuicioCasoDeUso(CalculadoraPuntos calculadora, HistorialConsultas historial)
        {
            _calculadora = calculadora;
            _historial = historial;
        }

            public string ImprimirGanador(string demandante, string demandado)
            {
                //Al necesitar añadir la información al historial habrá que almacenar la solución en una variable
                var puntosDemandante = _calculadora.CalcularPuntuacion(demandante);
                var puntosDemandado = _calculadora.CalcularPuntuacion(demandado);

                string resultado = puntosDemandante > puntosDemandado ? "Gana Demandante" :
                                   puntosDemandado > puntosDemandante ? "Gana Demandado" :
                                   "Empate";

                _historial.add(demandante, demandado, resultado);

                return resultado;
            }
        }
    } 
