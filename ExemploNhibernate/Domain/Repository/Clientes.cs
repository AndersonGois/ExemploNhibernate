
using System.Collections.Generic;
using Domain.Entities;
using NHibernate;

namespace Domain.Repository
{
    public class Clientes : BaseRepository
    {
        public Clientes(ISession session)
            : base(session)
        {

        }

        public Clientes()
        {
            
        }
        public Cliente Obter(int id)
        {
            return Obter<Cliente>(id);
        }

        public IList<Cliente> Todos()
        {
            return Todos<Cliente>();
        }
    }
}
