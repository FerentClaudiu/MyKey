﻿using MyKey.BLL.Ports;
using MyKey.Repository;
using MyKey.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKey.BLL
{
    class CategoryService: ICategoryService
    {
        private readonly CategorieRepository _categorieRepository;

        public CategoryService(CategorieRepository categorieRepository)
        {
            _categorieRepository = categorieRepository;
        }
        
        public object GetCategorieById(int Id)
        {
            return _categorieRepository.GetCategorieById(Id);
        }

        public void Save(CategorieEntity categorie)
        {
            throw new NotImplementedException();
        }
    }

}
