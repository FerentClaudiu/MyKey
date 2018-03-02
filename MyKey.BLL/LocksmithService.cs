using MyKey.BLL.Ports;
using MyKey.Repository;
using MyKey.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKey.BLL
{
    class LocksmithService:ILocksmithService
    {
        private readonly LocksmithRepository _locksmithRepository;

        public LocksmithService(LocksmithRepository locksmithRepository)
        {
            _locksmithRepository = locksmithRepository;
        }
        public object GetLocksmithById(int Id)
        {
            return _locksmithRepository.GetLocksmithById(Id);
        }

        public void Save(LocksmithEntity locksmith)
        {
            throw new NotImplementedException();
        }
    }

}
