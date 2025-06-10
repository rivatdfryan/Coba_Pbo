using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;
using Kinar_Bakery.Model;
using Kinar_Bakery.Controller;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Kinar_Bakery
{
    public partial class Register : Form
    {
        private readonly Autentikasi autentikasi;

        public Register()
        {
            try
            {
                InitializeComponent();
                autentikasi = new Autentikasi();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menginisialisasi registrasi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(NamaLengkap.Text) || string.IsNullOrEmpty(Username.Text) ||
                    string.IsNullOrEmpty(Password.Text) || string.IsNullOrEmpty(NomorTelepon.Text) || string.IsNullOrEmpty(txtAlamat.Text))
                {
                    MessageBox.Show("Harap memasukkan semua data dengan benar!", "Registrasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Akun akun = new Akun
                {
                    Nama = NamaLengkap.Text,
                    Username = Username.Text,
                    Password = Password.Text,
                    Nomor_telepon = NomorTelepon.Text,
                    Alamat = txtAlamat.Text,
                    //Tanggal_lahir = dateTimePickerTanggalLahir.Value
                };

                string errorMessage;
                if (autentikasi.RegisterUser(akun, out errorMessage))
                {
                    MessageBox.Show("Registrasi berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    new Login().ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(errorMessage, "Registrasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saat registrasi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                this.Hide();
                new Login().ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal beralih ke login: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}