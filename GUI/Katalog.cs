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
    public partial class Katalog : Form
    {
        private readonly int _id_user;
        private readonly KontrolerProduk _kontroler;
        public Katalog(int id_user)
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
                MessageBox.Show($"Gagal menginisialisasi katalog: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadData()
        {
            try
            {
                dataGridViewKatalog.AutoGenerateColumns = false;
                dataGridViewKatalog.Columns.Clear();
                dataGridViewKatalog.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id_produk", HeaderText = "ID Produk", ReadOnly = true });
                dataGridViewKatalog.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Nama", HeaderText = "Nama Produk", ReadOnly = true });
                dataGridViewKatalog.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Jenis", HeaderText = "Jenis Produk", ReadOnly = true });
                dataGridViewKatalog.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Harga", HeaderText = "Harga", ReadOnly = true });
                var kolomTambah = new DataGridViewLinkColumn { HeaderText = "Aksi", Text = "Tambah ke Keranjang", UseColumnTextForLinkValue = true, ReadOnly = true };
                dataGridViewKatalog.Columns.Add(kolomTambah);

                dataGridViewKatalog.DataSource = _kontroler.AmbilSemuaProduk();
                comboBoxUrut.Items.AddRange(new[] { "Harga Tertinggi", "Harga Terendah", "Jenis" });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data katalog: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewKatalog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewKatalog.Columns.Count - 1)
                {
                    var row = dataGridViewKatalog.Rows[e.RowIndex];
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

        private void comboBoxUrut_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var opsiUrut = comboBoxUrut.SelectedItem?.ToString();
                dataGridViewKatalog.DataSource = _kontroler.AmbilSemuaProduk(opsiUrut);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal mengurutkan data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
