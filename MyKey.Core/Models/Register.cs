using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKey.Core.Models
{
    public class Register
    {
        public int ID { get; set; }

        public string Nume { get; set; }

        public string Parola { get; set; }

        public string Adresa  { get; set; }

        public string Email { get; set; }
        
        public int Telefon { get; set; }
    }
}
