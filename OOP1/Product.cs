using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    //bu tip klasslarda sadece özellikler olur.
    //CRUD operasyonları---cread-read-update-delete-eklemek okumak güncellemek silmek

    //snippet- hazır kodlar kare içinde üç noktalar- tab tab -(prop)
    //unit price- birim fiyat
    //product name- ürün adı
    //Id-nesne ayrımında veri tabanlarında kullanılan alan
    //unid price- fiyatı
    //category Id-kategori numarası
    //public int CategoryId { get; set; }-referans alanları prime(ana anahtar) altına yazılmalı
    //UnitsInStock- stok durumu

    internal class Product  ///Entity-varlık olarak adlandırılır
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }



    }
}
