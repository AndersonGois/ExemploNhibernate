
using Domain.Entities;
using Domain.Repository;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using NUnit.Framework;

namespace ExemploTeste.Infrastructure
{
    [TestFixture]
    public class CriarBancoDeDados
    {
        [Test]
        public void a_Criar_Banco_de_Dados()
        {
            Fluently.Configure().Database(MsSqlConfiguration.MsSql2008.ConnectionString(x => x.FromAppSetting("Conexao")))
                .Mappings(x => x.FluentMappings.AddFromAssemblyOf<Cliente>()).Mappings(x => x.MergeMappings())
                .ExposeConfiguration(BildSchema)
                .BuildSessionFactory();

        }
        
        [Test]
        public void Criar_Tipo_Sexo()
        {
            var sexos = new TipoSexos();
            var m = new TipoSexo{Nome = "Masculino"};
            var f = new TipoSexo {Nome = "Feminino"};
            sexos.Salvar(m);
            sexos.Salvar(f);
        }

        private void BildSchema(Configuration configuration)
        {
            new SchemaExport(configuration).Drop(true,true);
            new SchemaExport(configuration).Create(true,true);
        }
    }
}
