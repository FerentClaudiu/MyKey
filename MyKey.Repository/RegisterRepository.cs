using MyKey.Repository.Entity;
using MyKey.Repository.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKey.Repository
{
    public class RegisterRepository : Irepository<RegisterEntity>
    {
        public RegisterEntity GetRegisterById(int Id)
        {
            return GetRegisterById(Id);
        }

        public RegisterEntity GetRegisterInsert(int entity)
        {
            return GetRegisterInsert(entity);
        }

        public RegisterEntity GetRegisterDelete(int id)
        {
            return GetRegisterDelete(id);
        }

        public RegisterEntity GetRegisterUpdate(int entity)
        {
            return GetRegisterUpdate(entity);
        }

        public RegisterEntity GetRegisterGetAll()
        {
            return GetRegisterGetAll();
        }
    }
}
