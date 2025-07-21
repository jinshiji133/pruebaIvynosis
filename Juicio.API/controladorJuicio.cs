using Microsoft.AspNetCore.Mvc;
using pruebaIvynosis.Aplicacion.pruebaIvynosis.casosDeUso;
using pruebaIvynosis.Entities.Servicios;

namespace Juicio.API
{
    [ApiController]
    [Route("[controller]")]
    public class ControladorJuicio : ControllerBase
    {
        private readonly JuicioCasoDeUso _CasoDeUso;
        private readonly HistorialConsultas _historial;

        public ControladorJuicio()
        {
            _historial = new HistorialConsultas();
            _CasoDeUso = new JuicioCasoDeUso(new CalculadoraPuntos(), _historial);
        }
        // GET /juicio?demandante=KN&demandado=NNV
        [HttpGet]
        public IActionResult Get([FromQuery] string demandante, [FromQuery] string demandado)
        {
            var result = _CasoDeUso.ImprimirGanador(demandante, demandado);
            return Ok(result);
        }

        //GET /juicio/historial
        [HttpGet("historial")]
        public IActionResult GetHistorial()
        {
            var records = _historial.GetAll();
            return Ok(records);
        }
    }
}
