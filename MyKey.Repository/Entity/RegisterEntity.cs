using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKey.Repository.Entity
{

    [Table("dbo.Register")]
    public class RegisterEntity
    {
        [Key]
        public int ID { get; set; }

        public string Nume { get; set; }

        public string Parola { get; set; }

        public string Adresa { get; set; }

        public string Email { get; set; }

        public int Telefon { get; set; }
    }
}
