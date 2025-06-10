using Kinar_Bakery.Controller;
using Kinar_Bakery.Model;
using Kinar_Bakery.GUI;
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
    public partial class Keranjang1 : Form
    {
        private readonly int _id_user;
        private readonly KontrolerTransaksi _kontroler;

        public Keranjang1(int id_user)
        {
            try
            {
                InitializeComponent();
                _id_user = id_user;
                _kontroler = new KontrolerTransaksi();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menginisialisasi keranjang: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            try
            {
                dataGridViewKeranjang.AutoGenerateColumns = false;
                dataGridViewKeranjang.Columns.Clear();
                dataGridViewKeranjang.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Nama_produk", HeaderText = "Nama Produk", ReadOnly = true });
                dataGridViewKeranjang.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Jumlah", HeaderText = "Jumlah", ReadOnly = true });
                dataGridViewKeranjang.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Total_harga", HeaderText = "Total Harga", ReadOnly = true });
                dataGridViewKeranjang.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Status", HeaderText = "Status", ReadOnly = true });
                var kolomHapus = new DataGridViewLinkColumn { HeaderText = "Aksi", Text = "Hapus", UseColumnTextForLinkValue = true, ReadOnly = true };
                dataGridViewKeranjang.Columns.Add(kolomHapus);

                var keranjang = _kontroler.AmbilKeranjang(_id_user);
                dataGridViewKeranjang.DataSource = new BindingList<ItemKeranjang>(keranjang.ToList());

                decimal total = keranjang.Sum(item => item.Total_harga ?? 0m);
                lblTotal.Text = $"Total: {total:C2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data keranjang: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewKeranjang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewKeranjang.Columns.Count - 1)
                {
                    var row = dataGridViewKeranjang.Rows[e.RowIndex];
                    var id_produk = Convert.ToInt32(row.Cells[0].Value);
                    _kontroler.HapusTransaksi(id_produk);
                    LoadData();
                    MessageBox.Show("Produk dihapus dari keranjang!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menghapus item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Checkout berhasil! Total: " + lblTotal.Text, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var keranjang = _kontroler.AmbilKeranjang(_id_user);
                foreach (var item in keranjang)
                {
                    _kontroler.HapusTransaksi(item.Id_produk);
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal melakukan checkout: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
