using pruebaIvynosis.Aplicacion;
using pruebaIvynosis.Aplicacion.pruebaIvynosis.casosDeUso;
using pruebaIvynosis.Entities.Servicios;


//Pide las firmas de forma manual, se podría hacer para que pidiese un archivo y que lo mire el mismo programa.
Console.WriteLine("Introduzca firma de demandante (e.j. KN):");
var demandante = Console.ReadLine();

Console.WriteLine("Introduzca firma demandado (e.j. NNV):");
var demandado = Console.ReadLine();

var casoDeUso = new JuicioCasoDeUso(new CalculadoraPuntos());
var result = casoDeUso.ImprimirGanador(demandante, demandado);

Console.WriteLine($"Result: {result}");