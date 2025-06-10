using Kinar_Bakery.Controller;
using Kinar_Bakery.Model;
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
    public partial class FormUbahPengguna : Form
    {
        private readonly KontrolerPengguna _kontroler;
        private readonly int _id_user;
        private Pengguna _pengguna;

        public FormUbahPengguna(int id_user)
        {
            InitializeComponent();
            _id_user = id_user;
            _kontroler = new KontrolerPengguna();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                _pengguna = _kontroler.AmbilPengguna(_id_user);
                if (_pengguna != null)
                {
                    txtNama.Text = _pengguna.Nama ?? "";
                    txtUsername.Text = _pengguna.Username ?? "";
                    txtNomorTelepon.Text = _pengguna.Nomor_telepon ?? "";
                    txtAlamat.Text = _pengguna.Alamat ?? "";
                    lblTanggal_lahir.Text = $"Tanggal Lahir: {_pengguna.Tanggal_lahir?.ToShortDateString() ?? ""}";
                    lblUsername.Text = $"Username: {_pengguna.Username ?? ""}";
                    lblNomor_telepon.Text = $"Nomor Telepon: {_pengguna.Nomor_telepon ?? ""}";
                    lblAlamat.Text = $"Alamat: {_pengguna.Alamat ?? ""}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (_pengguna == null)
                {
                    MessageBox.Show("Data pengguna tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _pengguna.Nama = txtNama.Text;
                _pengguna.Username = txtUsername.Text;
                _pengguna.Nomor_telepon = txtNomorTelepon.Text;
                _pengguna.Alamat = txtAlamat.Text;
                _pengguna.Role = "Pelanggan";

                _kontroler.PerbaruiPengguna(_pengguna);
                MessageBox.Show("Data berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menyimpan data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormUbahPengguna_Load(object sender, EventArgs e)
        {
            btnSimpan.Click += btnSimpan_Click;
            btnSimpan.Text = "Simpan"; 
        }
    }
}