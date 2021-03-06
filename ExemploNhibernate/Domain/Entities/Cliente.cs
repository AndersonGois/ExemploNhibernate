﻿
using Domain.Interfaces;

namespace Domain.Entities
{
    public  class Cliente :IAggregateRoot<int>
    {
        public virtual string Nome { get; set; }
        public virtual int Id { get; set; }
        public virtual TipoSexo Sexo { get; set; }
    }
}
