using MyKey.BLL.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyKey.Repository.Entity;
using MyKey.Repository;

namespace MyKey.BLL
{
    public class ProductService: IProductService

    {
        private readonly ProduseRepository _produseRepository;

        public ProductService(ProduseRepository produseRepository)
        {
            _produseRepository = produseRepository;
        }

        public void Save(ProduseEntity produse)
        {
            throw new NotImplementedException();
        }

    }
    
}

