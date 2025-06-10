using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kinar_Bakery.Controller;
using Kinar_Bakery.Model;

namespace Kinar_Bakery
{
    public partial class HomeDasboardkasir : Form
    {
        private readonly int _id_user;
        private readonly KontrolerPengguna _kontroler;
        private readonly KontrolerTransaksi _kontrolerTransaksi;

        public HomeDasboardkasir(int id_user)
        {
            InitializeComponent();
            _id_user = id_user;
            _kontroler = new KontrolerPengguna();
            _kontrolerTransaksi = new KontrolerTransaksi();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var pengguna = _kontroler.AmbilPengguna(_id_user);
                if (pengguna == null || pengguna.Role != "karyawan")
                {
                    MessageBox.Show("Akses ditolak. Anda bukan kasir!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                //// Inisialisasi judul atau konten dashboard
                //lblJudul.Text = "Dashboard Kasir"; // Asumsi ada label bernama lblJudul
                //lblSelamatDatang.Text = $"Selamat Datang, {pengguna.Nama}"; // Asumsi ada label bernama lblSelamatDatang

                //// Muat daftar transaksi atau pesanan (contoh)
                //var transaksi = _kontrolerTransaksi.AmbilTransaksi(_id_user); // Asumsi ada metode AmbilTransaksi
                //dataGridViewTransaksi.DataSource = transaksi; // Asumsi ada DataGridView bernama dataGridViewTransaksi
                //dataGridViewTransaksi.Columns["Id_transaksi"].HeaderText = "ID Transaksi";
                //dataGridViewTransaksi.Columns["Nama_produk"].HeaderText = "Nama Produk";
                //dataGridViewTransaksi.Columns["Jumlah"].HeaderText = "Jumlah";
                //dataGridViewTransaksi.Columns["Total_harga"].HeaderText = "Total Harga";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat dashboard: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}