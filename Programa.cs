
using pruebaIvynosis.Aplicacion;
using pruebaIvynosis.Entities.Servicios;

Console.WriteLine("Introduce firmas de demandante (Ej.KN)");
var demandante = Console.ReadLine();

Console.WriteLine("Introduce firmas de demandado (Ej. NNV):");
var demandado = Console.ReadLine();

var casoDeUso = new JuicioCasoDeUso(new CalculadoraPuntos());
var resulttado = casoDeUso.ImprimirGanador(demandante, demandado);

Console.WriteLine($"Result: {resultado}");
