using MyKey.BLL.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyKey.Repository.Entity;
using MyKey.Repository;
using MyKey.Core.Models;

namespace MyKey.BLL
{
    public class RegisterService: IRegisterService
    {
        private readonly RegisterRepository _registerRepository;

        public RegisterService(RegisterRepository registerRepository)
        {
            _registerRepository = registerRepository;
        }

        public Register GetRegisterById(int id)
        {
            var registerEntity = _registerRepository.GetRegisterById(id);

            return ConvertToRegister(registerEntity);

        }

        public void Save(RegisterEntity register)
        {
            throw new NotImplementedException();
        }

        private Register ConvertToRegister(RegisterEntity registerEntity)
        {
            var register = new Register();

            register.ID = registerEntity.ID;
            register.Nume = registerEntity.Nume;
            register.Parola = registerEntity.Parola;
            register.Adresa = registerEntity.Adresa;
            register.Email = registerEntity.Email;
            register.Telefon = registerEntity.Telefon;

            return register;

        }

    }

}

