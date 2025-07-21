using System;
using pruebaIvynosis.Entities.Servicios;

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
