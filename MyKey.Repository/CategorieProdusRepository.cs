using MyKey.Repository.Entity;
using MyKey.Repository.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKey.Repository
{
    public class CategorieProdusRepository : Irepository<CategorieProdusEntity>
    {
        public CategorieProdusEntity GetCategorieProdusById(int Id)
        {
            return GetCategorieProdusById(Id);
        }

        public CategorieProdusEntity GetCategorieProdusInsert(int entity)
        {
            return GetCategorieProdusInsert(entity);
        }

        public CategorieProdusEntity GetCategorieProdusDelete(int id)
        {
            return GetCategorieProdusDelete(id);
        }

        public CategorieProdusEntity GetCategorieProdusUpdate(int entity)
        {
            return GetCategorieProdusUpdate(entity);
        }

        public CategorieProdusEntity GetCategorieProdusGetAll()
        {
            return GetCategorieProdusGetAll();
        }
    }
}
