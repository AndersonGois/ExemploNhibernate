using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Interfaces;

namespace Domain.Entities
{
    public class TipoSexo : IAggregateRoot<int>
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
    }
}
