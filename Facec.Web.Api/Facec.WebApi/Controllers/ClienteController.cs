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
        public IActionResult Gravar(Cliente cliente)
        {
            try
            {
               _servico.Gravar(cliente);    
             return Ok();
            }
            catch (ApplicationException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult Obter()
        {
            try
            {
                return Ok(_servico.Obter());
            }
            catch (ApplicationException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
