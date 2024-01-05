using Objective.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objective.Tests.Fixtures
{
    [CollectionDefinition(nameof(PratoCollection))]
    public class PratoCollection : ICollectionFixture<PratoTesteFixture>
    { }

    public class PratoTesteFixture : IDisposable
    {
        public Prato GerarClienteValido()
        {
            var lasanha = new Prato(
                Guid.NewGuid(),
                "Lasanha");

            return lasanha;
        }

        public Prato GerarClienteInValido()
        {
            var cliente = new Prato(
                 Guid.NewGuid(),
                "Bolo de Chocolate");

            return cliente;
        }

        public void Dispose()
        {
        }
    }
}
