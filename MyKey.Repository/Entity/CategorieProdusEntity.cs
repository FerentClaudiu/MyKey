using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKey.Repository.Entity
{
    [Table("dbo.CategorieProdus")]
    public class CategorieProdusEntity
    {
        [Key]
        public int IDCategorie { get; set; }

        public string NumeCategorie { get; set; }
    }
}
