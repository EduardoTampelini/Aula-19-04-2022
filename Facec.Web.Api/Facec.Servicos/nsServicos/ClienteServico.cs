using Facec.Dominio.nsEntidades;
using Facec.Dominio.nsInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facec.Servicos.nsServicos
{
    public class ClienteServico : IClienteServico
    {
        private List<Cliente> _cliente = new List<Cliente>();

        public void Excluir(Guid id)
        {
                     _cliente.Remove(_cliente.FirstOrDefault(x => x.Id == id) ?? throw new ApplicationException("Cliente nao existe"));
        }

        public void Gravar(Cliente cliente)
        {
            _cliente.Add(cliente);
        }

        public IEnumerable<Cliente> Obter()
        {
            return _cliente;
        }
    }
}
