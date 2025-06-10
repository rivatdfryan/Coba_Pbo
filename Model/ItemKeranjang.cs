using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinar_Bakery.Model
{
    public class ItemKeranjang
    {
        public int Id_produk { get; set; }
        public string? Nama_produk { get; set; }
        public int Jumlah { get; set; }
        public decimal? Total_harga { get; set; }
        public string? Status { get; set; }
    }
}

    //public int Id_produk { get => _id_produk; set => _id_produk = value; }
    //public string Nama_produk { get => _nama_produk; set => _nama_produk = value; }
    //public int Jumlah { get => _jumlah; set => _jumlah = value; }
    //public decimal Total_harga { get => _total_harga; set => _total_harga = value; }

