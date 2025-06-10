using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinar_Bakery.Model
{
    public class KonteksTransaksi
    {
        private readonly DatabaseConnection dbConnection = new DatabaseConnection();

        public List<ItemKeranjang> AmbilKeranjang(int id_user)
        {
            var keranjang = new List<ItemKeranjang>();
            try
            {
                string query = "SELECT tp.id_produk, p.nama AS nama_produk, tp.jumlah, kp.harga * tp.jumlah AS total_harga, p.stok " +
                               "FROM public.transaksi_penjualan tp " +
                               "JOIN public.produk p ON tp.id_produk = p.id_produk " +
                               "JOIN public.katalog_produk kp ON p.id_produk = kp.id_produk " +
                               "WHERE tp.id_pelanggan = @id_user AND tp.tanggal_transaksi::date = @tanggal";
                var parameters = new[]
                {
                    new NpgsqlParameter("@id_user", id_user),
                    new NpgsqlParameter("@tanggal", DateTime.Now.Date) 
                };
                var result = dbConnection.ExecuteQuery(query, parameters);

                foreach (DataRow row in result.Rows)
                {
                    keranjang.Add(new ItemKeranjang
                    {
                        Id_produk = Convert.ToInt32(row["id_produk"]),
                        Nama_produk = row["nama_produk"] != DBNull.Value ? row["nama_produk"].ToString() : null,
                        Jumlah = Convert.ToInt32(row["jumlah"]),
                        Total_harga = row["total_harga"] != DBNull.Value ? Convert.ToDecimal(row["total_harga"]) : (decimal?)null,
                        Status = Convert.ToInt32(row["stok"]) > 0 ? "Tersedia" : "Habis"
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal menjalankan query: {ex.Message}");
            }
            return keranjang;
        }

        public void TambahTransaksi(int id_produk, int jumlah, int id_pelanggan)
        {
            try
            {
                string query = "INSERT INTO public.transaksi_penjualan (id_produk, id_pelanggan, jumlah, tanggal_transaksi, mp) " +
                               "VALUES (@id_produk, @id_pelanggan, @jumlah, @tanggal, @mp)";
                var parameters = new[]
                {
            new NpgsqlParameter("@id_produk", id_produk),
            new NpgsqlParameter("@id_pelanggan", id_pelanggan),
            new NpgsqlParameter("@jumlah", jumlah),
            new NpgsqlParameter("@tanggal", DateTime.Now),
            new NpgsqlParameter("@mp", "Tunai")
        };
                dbConnection.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal menambahkan transaksi: {ex.Message}");
            }
        }

        public void HapusTransaksi(int id_produk)
        {
            try
            {
                string query = "DELETE FROM public.transaksi_penjualan WHERE id_produk = @id_produk AND tanggal_transaksi::date = @tanggal";
                var parameters = new[]
                {
                    new NpgsqlParameter("@id_produk", id_produk),
                    new NpgsqlParameter("@tanggal", DateTime.Now.Date) 
                };
                dbConnection.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal menghapus transaksi: {ex.Message}");
            }
        }
    }
}