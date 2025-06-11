using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinar_Bakery.Model
{
    public class DatabaseConnection
    {
        private readonly string connectionString;

        public DatabaseConnection()
        {
            connectionString = "Host=localhost;Port=5432;Username=postgres;Password=dav3020;Database=Coba_Bakery_P";
        }

        public NpgsqlConnection GetConnection()
        {
            try
            {
                var connection = new NpgsqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal membuka koneksi ke database: " + ex.Message);
            }
        }

        public DataTable ExecuteQuery(string query, NpgsqlParameter[] parameters = null)
        {
            DataTable dataTable = new DataTable();
            using (var connection = GetConnection())
            {
                try
                {
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        if (parameters != null) command.Parameters.AddRange(parameters);
                        using (var adapter = new NpgsqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Gagal menjalankan query: " + ex.Message);
                }
            }
            return dataTable;
        }

        public int ExecuteNonQuery(string query, NpgsqlParameter[] parameters = null)
        {
            using (var connection = GetConnection())
            {
                try
                {
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        if (parameters != null) command.Parameters.AddRange(parameters);
                        return command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Gagal menjalankan perintah: " + ex.Message);
                }
            }
        }
    }
}
