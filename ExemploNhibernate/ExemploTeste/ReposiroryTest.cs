using Domain.Entities;
using Domain.Repository;
using NUnit.Framework;

namespace ExemploTeste
{
    [TestFixture]
    public class ReposiroryTest
    {
        private Cliente _cliente;

        [SetUp]
        public void a_Criar_clientes()
        {
            _cliente = new Cliente { Nome = "Rejane", Sexo = new TipoSexos().Obter<TipoSexo>(2) };
            new Clientes().Salvar(_cliente);
        }


        [Test]
        public void construtor()
        {
            Assert.IsNotNull(new Clientes());
        }

        [Test]
        public void b_Alterar_cliente()
        {
            var cli = new Clientes();
            var cliente = cli.Obter(_cliente.Id);
            cliente.Nome = "teste";
            cli.Salvar(cliente);

            Assert.AreEqual(cliente.Id, _cliente.Id);
        }

        [Test]
        public void c_Obter_clientes()
        {
            Assert.NotNull(new Clientes().Todos());
        }

        [TearDown]
        public void deletar_cliente()
        {
            new Clientes().Deletar(_cliente);
        }
    }
}
