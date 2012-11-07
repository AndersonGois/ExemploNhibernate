

using Domain.Entities;
using FluentNHibernate.Mapping;

namespace Domain.Mapping
{
    public sealed class ClienteMap : ClassMap<Cliente>
    {
        public ClienteMap()
        {
            Id(x => x.Id);
            Map(x => x.Nome);
        }
    }
}
