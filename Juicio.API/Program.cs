using pruebaIvynosis.Aplicacion;
using pruebaIvynosis.Aplicacion.pruebaIvynosis.casosDeUso;
using pruebaIvynosis.Entities.Servicios;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


var historial = new HistorialConsultas();
var casoDeUso = new JuicioCasoDeUso(new CalculadoraPuntos(), historial);
// Endpoint simple: GET /juicio?demandante=KN&demandado=NNV
//Ejecutar juicio
app.MapGet("/juicio", (string demandante, string demandado) =>
{
    return casoDeUso.ImprimirGanador(demandante, demandado);
});

//Ver historial
app.MapGet("/historial", () =>
{
    return historial.GetAll();
});

app.Run();

