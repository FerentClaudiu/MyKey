using MyKey.Repository.Entity;
using MyKey.Repository.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKey.Repository
{
    public class CategorieRepository : Irepository<CategorieEntity>
    {
        public CategorieEntity GetCategorieById(int Id)
        {
            return GetCategorieById(Id);
        }

        public CategorieEntity GetCategorieInsert(int entity)
        {
            return GetCategorieInsert(entity);
        }

        public CategorieEntity GetCategorieDelete(int id)
        {
            return GetCategorieDelete(id);
        }

        public CategorieEntity GetCategorieUpdate(int entity)
        {
            return GetCategorieUpdate(entity);
        }

        public CategorieEntity GetCategorieGetAll()
        {
            return GetCategorieGetAll();
        }
    }
}
