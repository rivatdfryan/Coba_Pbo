using Kinar_Bakery.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinar_Bakery.Controller
{
    public class KontrolerPengguna
    {
        private readonly KonteksPengguna _konteks = new KonteksPengguna();

        public Pengguna AmbilPengguna(int id)
        {
            return _konteks.AmbilBerdasarkanId(id);
        }

        public void PerbaruiPengguna(Pengguna pengguna)
        {
            _konteks.Perbarui(pengguna);
        }

        public void HapusPengguna(int id)
        {
            _konteks.Hapus(id);
        }
    }
}