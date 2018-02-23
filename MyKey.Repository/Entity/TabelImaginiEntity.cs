using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKey.Repository.Entity
{
    [Table("TabelImagini")]
    public class TabelImaginiEntity
    {
        [Key]
        public byte[] IDImagini;

        public byte[] NumeImagine;

        public byte[] Imagine;
    }
}
