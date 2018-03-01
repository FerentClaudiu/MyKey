using MyKey.Repository.Entity;
using MyKey.Repository.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKey.Repository
{
    public class ProduseRepository : Irepository<ProduseEntity>
    {
        public ProduseEntity GetProduseById(int Id)
        {
            return GetProduseById(Id);
        }

        public ProduseEntity GetProduseInsert( int entity)
        {
            return GetProduseInsert(entity);
        }

        public ProduseEntity GetProduseDelete(int id)
        {
            return GetProduseDelete(id);
        }

        public ProduseEntity GetProduseUpdate( int entity)
        {
            return GetProduseUpdate(entity);
        }

        public ProduseEntity GetProduseGetAll()
        {
            return GetProduseGetAll();
        }
    }
}
