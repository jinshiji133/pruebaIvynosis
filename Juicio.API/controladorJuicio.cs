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

        public ControladorJuicio()
        {
            _CasoDeUso = new JuicioCasoDeUso(new CalculadoraPuntos());
        }

        [HttpGet]
        public IActionResult Get([FromQuery] string demandante, [FromQuery] string demandado)
        {
            var result = _CasoDeUso.ImprimirGanador(demandante, demandado);
            return Ok(result);
        }
    }
}
