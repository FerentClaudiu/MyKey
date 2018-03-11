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
    public class ProductService: IProductService

    {
        private readonly ProduseRepository _produseRepository;

        public ProductService(ProduseRepository produseRepository)
        {
            _produseRepository = produseRepository;
        }

        public Product  GetProduseById(int id)
        {
            var produseEntity= _produseRepository. GetProduseById(id);

            return ConvertToProduct(produseEntity);

        }

        public void Save(ProduseEntity produse)
        {
            throw new NotImplementedException();
        }

        private Product ConvertToProduct(ProduseEntity produseEntity)
        {
            var produse = new Product();

                produse.CategorieID= produseEntity.CategorieID;
                produse.DescriereProdus = produseEntity.DescriereProdus;
                produse.IdImagine = produseEntity.IdImagine;
                produse.IdProdus = produseEntity.IdProdus;
                produse.NumeProdus = produseEntity.NumeProdus;

            return produse;

        }

    }
    
}

