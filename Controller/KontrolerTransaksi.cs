using Kinar_Bakery.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinar_Bakery.Controller
{
    public class KontrolerTransaksi
    {
        private readonly KonteksTransaksi _konteks = new KonteksTransaksi();

        public List<ItemKeranjang> AmbilKeranjang(int id_pelanggan)
        {
            return _konteks.AmbilKeranjang(id_pelanggan);
        }

        public void TambahKeKeranjang(int id_produk, int jumlah, int id_pelanggan)
        {
            _konteks.TambahTransaksi(id_produk, jumlah, id_pelanggan);
        }

        public void HapusTransaksi(int id_produk)
        {
            _konteks.HapusTransaksi(id_produk);
        }
    }
}