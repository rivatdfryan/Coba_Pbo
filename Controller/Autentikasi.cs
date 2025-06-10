using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;
using Kinar_Bakery.Model;

namespace Kinar_Bakery.Controller
{
    public class Autentikasi
    {
        private readonly DatabaseConnection dbConnection = new DatabaseConnection();

        public bool LoginUser(Akun akun, out string errorMessage, out string role)
        {
            errorMessage = string.Empty;
            role = string.Empty;

            try
            {
                var parameters = new[]
                {
                    new NpgsqlParameter("@username", akun.Username ?? (object)DBNull.Value),
                    new NpgsqlParameter("@password", akun.Password ?? (object)DBNull.Value)
                };

                string query = "SELECT id_user, nama, nomor_telepon, alamat, role, tanggal_lahir " +
                               "FROM public.users WHERE username = @username AND password = @password";
                var result = dbConnection.ExecuteQuery(query, parameters);

                if (result.Rows.Count > 0)
                {
                    var row = result.Rows[0];
                    akun.Id_user = Convert.ToInt32(row["id_user"]);
                    akun.Nama = row["nama"] != DBNull.Value ? row["nama"].ToString() : null;
                    akun.Nomor_telepon = row["nomor_telepon"] != DBNull.Value ? row["nomor_telepon"].ToString() : null;
                    akun.Alamat = row["alamat"] != DBNull.Value ? row["alamat"].ToString() : null;
                    role = row["role"] != DBNull.Value ? row["role"].ToString() : null;
                    akun.Tanggal_lahir = row["tanggal_lahir"] != DBNull.Value ? Convert.ToDateTime(row["tanggal_lahir"]) : (DateTime?)null;
                    return true;
                }
                else
                {
                    errorMessage = "Username atau password salah!";
                    return false;
                }
            }
            catch (Exception ex)
            {
                errorMessage = $"Gagal login: {ex.Message}";
                return false;
            }
        }

        public bool RegisterUser(Akun akun, out string errorMessage)
        {
            errorMessage = string.Empty;

            try
            {
                var parameters = new[]
                {
                    new NpgsqlParameter("@nama", akun.Nama ?? (object)DBNull.Value),
                    new NpgsqlParameter("@username", akun.Username ?? (object)DBNull.Value),
                    new NpgsqlParameter("@password", akun.Password ?? (object)DBNull.Value),
                    new NpgsqlParameter("@nomor_telepon", akun.Nomor_telepon ?? (object)DBNull.Value),
                    new NpgsqlParameter("@alamat", akun.Alamat ?? (object)DBNull.Value),
                    new NpgsqlParameter("@role", "pelanggan"),
                    new NpgsqlParameter("@tanggal_lahir", akun.Tanggal_lahir ?? DateTime.Now)
                };

                string query = "INSERT INTO public.users (nama, username, password, nomor_telepon, alamat, role, tanggal_lahir) " +
                               "VALUES (@nama, @username, @password, @nomor_telepon, @alamat, @role, @tanggal_lahir) RETURNING id_user";
                var result = dbConnection.ExecuteQuery(query, parameters);
                if (result.Rows.Count > 0)
                {
                    akun.Id_user = Convert.ToInt32(result.Rows[0]["id_user"]);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                errorMessage = $"Gagal registrasi: {ex.Message}";
                return false;
            }
        }
    }
}
