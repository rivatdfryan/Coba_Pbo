using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinar_Bakery.Model
{
    public class KonteksProduk
    {
        private readonly DatabaseConnection dbConnection = new DatabaseConnection();
        private List<Produk> daftarProduk = new List<Produk>();

        public List<Produk> AmbilSemua(string opsiUrut = null)
        {
            daftarProduk.Clear();
            string query = "SELECT p.id_produk, p.nama, p.jenis, p.stok, kp.harga " +
                           "FROM public.produk p " +
                           "JOIN public.katalog_produk kp ON p.id_produk = kp.id_produk";
            var result = dbConnection.ExecuteQuery(query);

            foreach (DataRow row in result.Rows)
            {
                daftarProduk.Add(new Produk
                {
                    Id_produk = Convert.ToInt32(row["id_produk"]),
                    Nama = row["nama"].ToString(),
                    Jenis = row["jenis"].ToString(),
                    Stok = Convert.ToInt32(row["stok"]),
                    Harga = row["harga"] != DBNull.Value ? Convert.ToDecimal(row["harga"]) : 0m 
                });
            }

            if (opsiUrut == "Harga Tertinggi")
                return daftarProduk.OrderByDescending(p => p.Harga ?? 0m).ToList(); 
            else if (opsiUrut == "Harga Terendah")
                return daftarProduk.OrderBy(p => p.Harga ?? 0m).ToList();
            else if (opsiUrut == "Jenis")
                return daftarProduk.OrderBy(p => p.Jenis).ToList();

            return daftarProduk;
        }

        public Produk AmbilBerdasarkanId(string id)
        {
            string query = "SELECT p.id_produk, p.nama, p.jenis, p.stok, kp.harga " +
                           "FROM public.produk p " +
                           "JOIN public.katalog_produk kp ON p.id_produk = kp.id_produk " +
                           "WHERE p.id_produk = @id";
            var parameters = new[] { new NpgsqlParameter("@id", id) };
            var result = dbConnection.ExecuteQuery(query, parameters);

            if (result.Rows.Count > 0)
            {
                var row = result.Rows[0];
                return new Produk
                {
                    Id_produk = Convert.ToInt32(row["id_produk"]),
                    Nama = row["nama"].ToString(),
                    Jenis = row["jenis"].ToString(),
                    Stok = Convert.ToInt32(row["stok"]),
                    Harga = row["harga"] != DBNull.Value ? Convert.ToDecimal(row["harga"]) : 0m
                };
            }
            return null;
        }
        

        public List<Produk> AmbilBestSeller()
        {
            var daftarProduk = new List<Produk>();
            try
            {
                string query = @"
                    SELECT p.id_produk, p.nama, p.jenis, kp.harga, COUNT(tp.id_produk) as total_penjualan
                    FROM public.produk p
                    JOIN public.katalog_produk kp ON p.id_produk = kp.id_produk
                    LEFT JOIN public.transaksi_penjualan tp ON p.id_produk = tp.id_produk
                    GROUP BY p.id_produk, p.nama, p.jenis, kp.harga
                    ORDER BY total_penjualan DESC
                    LIMIT 5";
                var result = dbConnection.ExecuteQuery(query);

                foreach (DataRow row in result.Rows)
                {
                    daftarProduk.Add(new Produk
                    {
                        Id_produk = Convert.ToInt32(row["id_produk"]),
                        Nama = row["nama"].ToString(),
                        Jenis = row["jenis"].ToString(),
                        Harga = Convert.ToDecimal(row["harga"])
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal mengambil best seller: {ex.Message}");
            }
            return daftarProduk;
        }

        public void Perbarui(Produk entitas)
        {
            string query = "UPDATE public.produk SET nama = @nama, jenis = @jenis, stok = @stok WHERE id_produk = @id";
            var parameters = new[]
            {
                new NpgsqlParameter("@nama", entitas.Nama ?? (object)DBNull.Value),
                new NpgsqlParameter("@jenis", entitas.Jenis ?? (object)DBNull.Value),
                new NpgsqlParameter("@stok", entitas.Stok),
                new NpgsqlParameter("@id", entitas.Id_produk)
            };
            dbConnection.ExecuteNonQuery(query, parameters);
        }

        public void Hapus(string id)
        {
            string query = "DELETE FROM public.produk WHERE id_produk = @id";
            var parameters = new[] { new NpgsqlParameter("@id", id) };
            dbConnection.ExecuteNonQuery(query, parameters);
        }
    }
}