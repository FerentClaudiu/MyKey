using MyKey.Repository.Entity;
using MyKey.Repository.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKey.Repository
{
    public class TabelImaginiRepository: Irepository<TabelImaginiEntity>
    {
        public TabelImaginiEntity GetTabelImaginiById(int Id)
        {
            return GetTabelImaginiById(Id);
        }

        public TabelImaginiEntity GetTabelImaginiInsert(int entity)
        {
            return GetTabelImaginiInsert(entity);
        }

        public TabelImaginiEntity GetTabelImaginiDelete(int id)
        {
            return GetTabelImaginiDelete(id);
        }

        public TabelImaginiEntity GetTabelImaginiUpdate(int entity)
        {
            return GetTabelImaginiUpdate(entity);
        }

        public TabelImaginiEntity GetTabelImaginiGetAll()
        {
            return GetTabelImaginiGetAll();
        }
    }
}
