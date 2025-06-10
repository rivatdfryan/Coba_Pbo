using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinar_Bakery.Model
{
    public class Akun
    {
        public int Id_user { get; set; }
        public string? Nama { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Nomor_telepon { get; set; }
        public string? Alamat { get; set; }
        public string? Role { get; set; }
        public DateTime? Tanggal_lahir { get; set; }
    }
}