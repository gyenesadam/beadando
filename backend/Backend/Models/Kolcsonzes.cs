using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public class Kolcsonzes
    {
        public int KolcsonzesID { get; set; }
        public int TagID { get; set; }
        public int MediaID { get; set; }
        public string SZIG { get; set; }
        public string Kivetel { get; set; }
        public string Visszavetel { get; set; }
    }
}