using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinar_Bakery.Model
{
    public class Pengguna
    {
        private int _id_user;
        private string? _nama;
        private string? _username;
        private string? _password;
        private string? _nomor_telepon;
        private string? _alamat;
        private string? _role;
        private DateTime? _tanggal_lahir;

        public int Id_user { get => _id_user; set => _id_user = value; }
        public string? Nama { get => _nama; set => _nama = value; }
        public string? Username { get => _username; set => _username = value; }
        public string? Password { get => _password; set => _password = value; }
        public string? Nomor_telepon { get => _nomor_telepon; set => _nomor_telepon = value; }
        public string? Alamat { get => _alamat; set => _alamat = value; }
        public string? Role { get => _role; set => _role = value; }
        public DateTime? Tanggal_lahir { get => _tanggal_lahir; set => _tanggal_lahir = value; }
    }
}
