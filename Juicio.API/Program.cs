using pruebaIvynosis.Aplicacion;
using pruebaIvynosis.Aplicacion.pruebaIvynosis.casosDeUso;
using pruebaIvynosis.Entities.Servicios;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Endpoint simple: GET /juicio?demandante=KN&demandado=NNV
app.MapGet("/juicio", (string demandante, string demandado) =>
{
    var useCase = new JuicioCasoDeUso(new CalculadoraPuntos());
    var result = useCase.ImprimirGanador(demandante, demandado);
    return Results.Ok(result);
});

app.Run();

