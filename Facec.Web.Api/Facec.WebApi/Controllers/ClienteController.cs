using Facec.Dominio.nsEntidades;
using Facec.Dominio.nsInterfaces;
using Microsoft.AspNetCore.Mvc;
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
        public void Excluir(Cliente cliente) => _servico.Excluir(cliente);

        [HttpPost]
        public void Gravar(Cliente cliente) => _servico.Gravar(cliente);

        [HttpGet]
        public IEnumerable<Cliente> Obter() => _servico.Obter();
        
    }
}
