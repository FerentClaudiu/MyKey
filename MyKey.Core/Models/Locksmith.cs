using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKey.Core.Models
{
    public class Locksmith
    {
        public int LocksmithID { get; set; }

        public string Nume { get; set; }

        public string Adresa { get; set; }

        public int Telefon { get; set; }

        public int CategorieID { get; set; }
    }
}
