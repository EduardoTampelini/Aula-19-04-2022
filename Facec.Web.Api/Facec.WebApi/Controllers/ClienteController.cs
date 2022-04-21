using Facec.Dominio.nsEntidades;
using Facec.Dominio.nsInterfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Facec.WebApi.Controllers
{
    [ApiController]
    [Route("clientes")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteServico _servico;
        public ClienteController(IClienteServico servico)
        {
               _servico = servico;
        }
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Excluir(Guid id)
        {
            try
            {
                _servico.Excluir(id);
                return Ok();
            }
            catch(ApplicationException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public void Gravar(Cliente cliente) => _servico.Gravar(cliente);

        [HttpGet]
        public IEnumerable<Cliente> Obter() => _servico.Obter();
        
    }
}
