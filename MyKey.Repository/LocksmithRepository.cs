using MyKey.Repository.Entity;
using MyKey.Repository.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKey.Repository
{
    public class LocksmithRepository : Irepository<LocksmithEntity>
    {
        public LocksmithEntity GetLocksmithById(int Id)
        {
            return GetLocksmithById(Id);
        }

        public LocksmithEntity GetLocksmithInsert(int entity)
        {
            return GetLocksmithInsert(entity);
        }

        public LocksmithEntity GetLocksmithDelete(int id)
        {
            return GetLocksmithDelete(id);
        }

        public LocksmithEntity GetLocksmithUpdate(int entity)
        {
            return GetLocksmithUpdate(entity);
        }

        public LocksmithEntity GetLocksmithGetAll()
        {
            return GetLocksmithGetAll();
        }
    }
}
