using pruebaIvynosis.Aplicacion;
using pruebaIvynosis.Aplicacion.pruebaIvynosis.casosDeUso;
using pruebaIvynosis.Entities.Servicios;

Console.WriteLine("Introduzca firma de demandante (e.j. KN):");
var demandante = Console.ReadLine();

Console.WriteLine("Introduzca firma demandado (e.j. NNV):");
var demandado = Console.ReadLine();

var casoDeUso = new JuicioCasoDeUso(new CalculadoraPuntos());
var result = casoDeUso.ImprimirGanador(demandante, demandado);

Console.WriteLine($"Result: {result}");