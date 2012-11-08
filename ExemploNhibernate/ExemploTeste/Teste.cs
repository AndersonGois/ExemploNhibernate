using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Entities;
using Domain.Repository;
using ExemploTeste.BaseTest;
using NUnit.Framework;

namespace ExemploTeste
{
    [TestFixture]
    public class Teste : PersistenceTestBase
    {
        private Cliente _cliente;
        private Clientes _clientes;

        [SetUp]
        public void a_Criar_clientes()
        {
            _clientes = new Clientes(Session);
            _cliente = new Cliente { Nome = "anderson" };
            _clientes.Salvar(_cliente);
        }


        [Test]
        public void construtor()
        {
            var nes = new Clientes();
        }

        [Test]
        public void b_Alterar_cliente()
        {
            var cliente = _clientes.Obter(_cliente.Id);
            cliente.Nome = "teste";
            _clientes.Salvar(cliente);

            Assert.AreEqual(cliente.Id, _cliente.Id);
        }

        [Test]
        public void c_Obter_clientes()
        {
            var todos = _clientes.Todos();
            Assert.NotNull(todos);
        }
       

        [TearDown]
        public void deletar_cliente()
        {
            _clientes.Deletar(_cliente);
        }

    }
}
