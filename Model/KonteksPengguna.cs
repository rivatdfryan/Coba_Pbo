using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinar_Bakery.Model
{
    public class KonteksPengguna
    {
        private readonly DatabaseConnection dbConnection = new DatabaseConnection();

        public List<Pengguna> AmbilSemua()
        {
            var daftarPengguna = new List<Pengguna>();
            string query = "SELECT id_user, nama, username, nomor_telepon, alamat, role, tanggal_lahir FROM public.users";
            var result = dbConnection.ExecuteQuery(query);

            foreach (DataRow row in result.Rows)
            {
                daftarPengguna.Add(new Pengguna
                {
                    Id_user = Convert.ToInt32(row["id_user"]),
                    Nama = row["nama"].ToString(),
                    Username = row["username"].ToString(),
                    Nomor_telepon = row["nomor_telepon"].ToString(),
                    Alamat = row["alamat"].ToString(),
                    Role = row["role"].ToString(),
                    Tanggal_lahir = Convert.ToDateTime(row["tanggal_lahir"])
                });
            }
            return daftarPengguna;
        }

        public Pengguna AmbilBerdasarkanId(int id)
        {
            try
            {
                string query = "SELECT id_user, nama, username, nomor_telepon, alamat, role, tanggal_lahir FROM public.users WHERE id_user = @id";
                var parameters = new[] { new NpgsqlParameter("@id", id) };
                var result = dbConnection.ExecuteQuery(query, parameters);

                if (result.Rows.Count > 0)
                {
                    var row = result.Rows[0];
                    return new Pengguna
                    {
                        Id_user = Convert.ToInt32(row["id_user"]),
                        Nama = row["nama"] != DBNull.Value ? row["nama"].ToString() : null,
                        Username = row["username"] != DBNull.Value ? row["username"].ToString() : null,
                        Nomor_telepon = row["nomor_telepon"] != DBNull.Value ? row["nomor_telepon"].ToString() : null,
                        Alamat = row["alamat"] != DBNull.Value ? row["alamat"].ToString() : null,
                        Role = row["role"] != DBNull.Value ? row["role"].ToString() : null,
                        Tanggal_lahir = row["tanggal_lahir"] != DBNull.Value ? Convert.ToDateTime(row["tanggal_lahir"]) : (DateTime?)null
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal menjalankan query: {ex.Message}");
            }
        }

        public void Perbarui(Pengguna entitas)
        {
            try
            {
                string query = "UPDATE public.users SET nama = @nama, username = @username, nomor_telepon = @nomor_telepon, " +
                               "alamat = @alamat, role = @role, tanggal_lahir = @tanggal_lahir WHERE id_user = @id";
                var parameters = new[]
                {
                    new NpgsqlParameter("@nama", entitas.Nama ?? (object)DBNull.Value),
                    new NpgsqlParameter("@username", entitas.Username ?? (object)DBNull.Value),
                    new NpgsqlParameter("@nomor_telepon", entitas.Nomor_telepon ?? (object)DBNull.Value),
                    new NpgsqlParameter("@alamat", entitas.Alamat ?? (object)DBNull.Value),
                    new NpgsqlParameter("@role", entitas.Role ?? "Pelanggan"), // Pastikan role sesuai constraint
                    new NpgsqlParameter("@tanggal_lahir", entitas.Tanggal_lahir ?? DateTime.Now),
                    new NpgsqlParameter("@id", entitas.Id_user)
                };
                dbConnection.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal memperbarui data: {ex.Message}");
            }
        }

        public void Hapus(int id)
        {
            try
            {
                string query = "DELETE FROM public.users WHERE id_user = @id";
                var parameters = new[] { new NpgsqlParameter("@id", id) };
                dbConnection.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal menghapus data: {ex.Message}");
            }
        }
    }
}