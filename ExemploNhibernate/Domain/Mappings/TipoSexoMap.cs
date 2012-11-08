using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Entities;
using FluentNHibernate.Mapping;

namespace Domain.Mappings
{
    public sealed class TipoSexoMap : ClassMap<TipoSexo>
    {
        public TipoSexoMap()
        {
            Id(x => x.Id);
            Map(x => x.Nome);
        }
    }
}
