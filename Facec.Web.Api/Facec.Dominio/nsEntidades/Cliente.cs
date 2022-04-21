using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Facec.Dominio.nsEntidades
{
    public class Cliente : AbstractEntidade
    {
        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [JsonPropertyName("documento")]
        public string Documento { get; set; }

        public Cliente(string nome, string documento) : base()
        {
            Nome = nome;
            Documento = documento;
        }
    }
}
