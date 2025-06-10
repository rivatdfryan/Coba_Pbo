using Kinar_Bakery.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kinar_Bakery.GUI
{
    public partial class BestSeller : Form
    {
        private readonly int _id_user;
        private readonly KontrolerProduk _kontroler;

        public BestSeller(int id_user)
        {
            try
            {
                InitializeComponent();
                _id_user = id_user;
                _kontroler = new KontrolerProduk();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menginisialisasi best seller: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadData()
        {
            try
            {
                var bestSellerList = _kontroler.AmbilBestSeller();
                dataGridViewBestSeller.DataSource = bestSellerList; 
                dataGridViewBestSeller.Columns["Id_produk"].HeaderText = "ID Produk";
                dataGridViewBestSeller.Columns["Nama"].HeaderText = "Nama Produk";
                dataGridViewBestSeller.Columns["Jenis"].HeaderText = "Jenis Produk";
                dataGridViewBestSeller.Columns["Harga"].HeaderText = "Harga";
           
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat best seller: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewBestSeller_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewBestSeller.Columns.Count - 1)
                {
                    var row = dataGridViewBestSeller.Rows[e.RowIndex];
                    var id_produk = Convert.ToInt32(row.Cells["Id_produk"].Value);
                    int jumlah;
                    if (!int.TryParse(txtJumlah.Text, out jumlah) || jumlah <= 0)
                    {
                        MessageBox.Show("Masukkan jumlah yang valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    _kontroler.TambahKeKeranjang(id_produk, jumlah, _id_user);
                    MessageBox.Show("Produk ditambahkan ke keranjang!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menambahkan ke keranjang: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
