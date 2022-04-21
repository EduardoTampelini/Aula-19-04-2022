using Facec.Dominio.nsInterfaces;
using Facec.Servicos.nsServicos;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facec.IoC
{
    public static class Instalador
    {
        public static void Registrar(ref Container container)
        {
            container.Register<IClienteServico, ClienteServico>(Lifestyle.Singleton);
        }
    }
}
