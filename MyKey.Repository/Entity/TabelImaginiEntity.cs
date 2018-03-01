using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKey.Repository.Entity
{
    [Table("dbo.TabelImagini")]
    public class TabelImaginiEntity
    {
        [Key]
        public int IDImagini { get; set; }

        public string NumeImagine { get; set; }

        public byte[] Imagine { get; set; }
    }
}
