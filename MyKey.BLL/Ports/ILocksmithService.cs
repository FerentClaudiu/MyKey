using MyKey.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKey.BLL.Ports
{
     public interface ILocksmithService
    {
        void Save(LocksmithEntity locksmith);
    }
}
