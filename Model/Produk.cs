using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinar_Bakery.Model
{
    public class Produk
    {
        public int Id_produk { get; set; }
        public string? Nama { get; set; }
        public string? Jenis { get; set; }
        public int Stok { get; set; }
        public decimal? Harga { get; set; }
    }
}