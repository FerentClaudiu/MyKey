using MyKey.BLL.Ports;
using MyKey.Repository;
using MyKey.Repository.Entity;
using System;
using MyKey.Core.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyKey.BLL
{
    class ImageService: IImageService
    {
        private readonly TabelImaginiRepository _tabelImaginiRepository;

        public ImageService(TabelImaginiRepository tabelImaginiRepository)
        {
            _tabelImaginiRepository = tabelImaginiRepository;
        }

        public object GetTabelImaginiById(int id)
        {
            return _tabelImaginiRepository.GetTabelImaginiById(id);
        }
        public void Save(TabelImaginiEntity tabelImagini)
        {
            throw new NotImplementedException();
        }
          private Image ConvertToImage(TabelImaginiEntity tabelImaginiEntity)
        {
            var imagini = new Image();

            imagini.IDImagini = tabelImaginiEntity.IDImagini;
            imagini.NumeImagine = tabelImaginiEntity.NumeImagine;
            imagini.Imagine = tabelImaginiEntity.Imagine;

            return imagini;

           
        }
       
    }
}
