using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKey.Repository.Entity
{
    [Table("dbo.Categorie")]
    public class CategorieEntity
    {
        [Key]
        public int ID { get; set; }

        public string NumeCategorie { get; set; }
    }
}
