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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


//namespace Kinar_Bakery
//{
//    public partial class Login : Form
//    {
//        private readonly Autentikasi autentikasi;

//        public Login()
//        {
//            try
//            {
//                InitializeComponent();
//                autentikasi = new Autentikasi();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show($"Gagal menginisialisasi form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private void Login_Load(object sender, EventArgs e)
//        {
//        }

//        private void label3_Click(object sender, EventArgs e)
//        {
//        }

//        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
//        {
//            this.Hide();
//            Register register = new Register();
//            register.ShowDialog();
//            this.Show();
//        }

//        private void panel1_Paint(object sender, PaintEventArgs e)
//        {
//        }

//        private void BtnLogin_Click_1(object sender, EventArgs e)
//        {
//            try
//            {
//                if (string.IsNullOrEmpty(Username.Text) || string.IsNullOrEmpty(Password.Text))
//                {
//                    MessageBox.Show("Harap memasukkan username dan password!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                    return;
//                }

//                Akun akun = new Akun
//                {
//                    Username = Username.Text,
//                    Password = Password.Text
//                };

//                string errorMessage;
//                string role;
//                bool success = autentikasi.LoginUser(akun, out errorMessage, out role);

//                if (success)
//                {
//                    MessageBox.Show("Login berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

//                    switch (role)
//                    {
//                        case "Admin":
//                            this.Hide();
//                            HomeDasboardAdmin homeDasboardAdmin = new HomeDasboardAdmin();
//                            homeDasboardAdmin.ShowDialog();
//                            break;
//                        case "Kasir":
//                            this.Hide();
//                            HomeDasboardkasir homeDasboardkasir = new HomeDasboardkasir();
//                            homeDasboardkasir.ShowDialog();
//                            break;
//                        case "Pelanggan":
//                            this.Hide();
//                            HomeDashboardPelanggan homeDashboardPelanggan = new HomeDashboardPelanggan();
//                            homeDashboardPelanggan.ShowDialog();
//                            break;
//                        default:
//                            MessageBox.Show("Role tidak dikenali!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                            return;
//                    }
//                    this.Close();
//                }
//                else
//                {
//                    MessageBox.Show(errorMessage, "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                    Username.Text = "";
//                    Password.Text = "";
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show($"Error saat login: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }
//    }
//}

namespace Kinar_Bakery
{
    public partial class Login : Form
    {
        private readonly Autentikasi autentikasi;

        public Login()
        {
            try
            {
                InitializeComponent();
                autentikasi = new Autentikasi();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menginisialisasi form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
            this.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
         
            using (Pen pen = new Pen(Color.LightGray, 1))
            {
                e.Graphics.DrawRectangle(pen, e.ClipRectangle);
            }
        }

        private void BtnLogin_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Username.Text) || string.IsNullOrEmpty(Password.Text))
                {
                    MessageBox.Show("Harap memasukkan username dan password!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Akun akun = new Akun
                {
                    Username = Username.Text,
                    Password = Password.Text
                };

                string errorMessage;
                string role;
                bool success = autentikasi.LoginUser(akun, out errorMessage, out role);

                if (success)
                {
                    MessageBox.Show("Login berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    switch (role)
                    {
                        case "Admin" or "owner":
                            this.Hide();
                            HomeDasboardAdmin homeDashboardAdmin = new HomeDasboardAdmin(akun.Id_user); 
                            homeDashboardAdmin.ShowDialog();
                            break;
                        case "kasir" or "karyawan":
                            this.Hide();
                            HomeDasboardkasir homeDashboardKasir = new HomeDasboardkasir(akun.Id_user);
                            homeDashboardKasir.ShowDialog();
                            break;
                        case "pelanggan" or "pembeli":
                            this.Hide();
                            HomeDashboardPelanggan homeDashboardPelanggan = new HomeDashboardPelanggan(akun.Id_user); 
                            homeDashboardPelanggan.ShowDialog();
                            break;
                        default:
                            MessageBox.Show("Role tidak dikenali!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show(errorMessage, "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Username.Text = "";
                    Password.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saat login: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}