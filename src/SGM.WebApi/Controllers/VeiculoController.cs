using Microsoft.AspNetCore.Mvc;
using SGM.ApplicationServices.Interfaces;

namespace SGM.WebApi.Controllers
{
    [ApiController]
    [Route("SGM")]
    [Produces("application/json")]
    public class VeiculoController : ControllerBase
    {
        private readonly Serilog.ILogger _logger;
        private readonly IVeiculoServices _veiculoServices;

        public VeiculoController(Serilog.ILogger logger, IVeiculoServices veiculoServices)
        {
            _logger = logger;
            _veiculoServices= veiculoServices;
        }
    }
}
