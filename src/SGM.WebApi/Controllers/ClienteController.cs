﻿using Microsoft.AspNetCore.Mvc;
using SGM.ApplicationServices.Services;

namespace SGM.WebApi.Controllers
{
    [ApiController]
    [Route("MinhaPrimeiraAPI")]
    [Produces("application/json")]
    public class ClienteController : ControllerBase
    {
        private readonly Serilog.ILogger _logger;
        private readonly IClienteServices _clienteServices;

        public ClienteController(Serilog.ILogger logger,
            IClienteServices clienteServices)
        {
            _logger = logger;
            _clienteServices = clienteServices;
        }

        [HttpGet]
        [Route("cliente")]
        public IActionResult GetClientesForAll()
        {
            try
            {
                _logger.Information("[ClienteController.GetClientesForAll] - Solicitação para buscar todos os clientes");

                var clientes = _clienteServices.GetByAll();
                return Ok(clientes);
            }

            catch (Exception ex)
            {
                _logger.Error(ex, $"[ClienteController.GetClienteForAll] - Erro ao efetuar a chamada para buscar todos os clientes: ", ex);

                return StatusCode(500, ex);
            }
        }
    }
}