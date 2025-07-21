using pruebaIvynosis.Aplicacion;
using pruebaIvynosis.Aplicacion.pruebaIvynosis.casosDeUso;
using pruebaIvynosis.Entities.Servicios;
using System.Reflection;

var historial = new HistorialConsultas();
var casoDeUso = new JuicioCasoDeUso(new CalculadoraPuntos(), historial);

while (true)
{
    Console.WriteLine("\n1.Ejecutar juicio");
    Console.WriteLine("2.Ver historial");
    Console.WriteLine("Salir");
    Console.Write("Opción: ");
    var option = Console.ReadLine();

    if (option == "1") { 
    //Pide las firmas de forma manual, se podría hacer para que pidiese un archivo y que lo mire el mismo programa.
    Console.WriteLine("Introduzca firma de demandante (e.j. KN):");
    var demandante = Console.ReadLine();

    Console.WriteLine("Introduzca firma demandado (e.j. NNV):");
    var demandado = Console.ReadLine();

    var result = casoDeUso.ImprimirGanador(demandante, demandado);

    Console.WriteLine($"Result: {result}");
    }
    if (option == "2")
    {
        var infoHistorial = historial.GetAll();
        if (!infoHistorial.Any())  Console.WriteLine("No hay historial.");
        foreach (var elemHistorial in infoHistorial)
        {
            Console.WriteLine($"[{elemHistorial.Fecha}] {elemHistorial.Demandante} vs {elemHistorial.Demandado} => {elemHistorial.Resultado}");
        }
    }
    if (option == "3") { break; }
    else { Console.WriteLine("Por favor introduzca un valor válido"); }
}