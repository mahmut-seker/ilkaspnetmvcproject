using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ilkproje.Models
{
    public class yazar
    {
        public int ID { get; set; }
        public string yazarAdi { get; set; }
        public string yazarSoyad { get; set; }
        public string Biyografi { get; set; }
        public DateTime dogumTarihi { get; set; }
    }
}