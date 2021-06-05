using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public class Tagok
    {
        public int TagID { get; set; }
        public string Nev { get; set; }
        public int Telefon { get; set; }
        public string SZIG { get; set; }
        public string Lakcim { get; set; }
        public string Statusz { get; set; }

    }
}
}