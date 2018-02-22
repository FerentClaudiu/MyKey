using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKey.Repository.Entity
{

    [Table("dbo.Produse")]

    public class ProduseEntity
    {
        [Key]
        public int CategorieID { get; set; }

        public int IdProdus { get; set; }

        public string NumeProdus { get; set; }
        
        public string DescriereProdus { get; set; }

        public int IdImagine { get; set; }

    }
}
