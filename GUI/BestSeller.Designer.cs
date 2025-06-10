namespace Kinar_Bakery.GUI
{
    partial class BestSeller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BestSeller));
            panel2 = new Panel();
            panel12 = new Panel();
            label3 = new Label();
            panel9 = new Panel();
            dataGridViewBestSeller = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            txtJumlah = new TextBox();
            txtDashboardKasir = new Label();
            panel3 = new Panel();
            panel7 = new Panel();
            btnKatalog = new Button();
            panel5 = new Panel();
            button4 = new Button();
            panel15 = new Panel();
            panel6 = new Panel();
            btnBestSeller = new Button();
            btnHomePelanggan = new Button();
            panel4 = new Panel();
            panel1 = new Panel();
            databaseConnectionBindingSource = new BindingSource(components);
            panel2.SuspendLayout();
            panel12.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBestSeller).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)databaseConnectionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(251, 238, 215);
            panel2.Controls.Add(panel12);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(txtDashboardKasir);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel1);
            panel2.Font = new Font("Microsoft Sans Serif", 8.25F);
            panel2.Location = new Point(1, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1263, 683);
            panel2.TabIndex = 8;
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(80, 43, 15);
            panel12.Controls.Add(label3);
            panel12.Location = new Point(267, 136);
            panel12.Name = "panel12";
            panel12.Size = new Size(984, 59);
            panel12.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(251, 238, 215);
            label3.Location = new Point(313, 14);
            label3.Name = "label3";
            label3.Size = new Size(305, 25);
            label3.TabIndex = 8;
            label3.Text = "5 Produk Terlaris saat ini";
            label3.Click += label3_Click;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(183, 150, 107);
            panel9.Controls.Add(dataGridViewBestSeller);
            panel9.Controls.Add(button1);
            panel9.Controls.Add(label1);
            panel9.Controls.Add(txtJumlah);
            panel9.Location = new Point(267, 136);
            panel9.Name = "panel9";
            panel9.Size = new Size(984, 520);
            panel9.TabIndex = 5;
            // 
            // dataGridViewBestSeller
            // 
            dataGridViewBestSeller.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBestSeller.Location = new Point(39, 86);
            dataGridViewBestSeller.Name = "dataGridViewBestSeller";
            dataGridViewBestSeller.Size = new Size(902, 318);
            dataGridViewBestSeller.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(806, 407);
            button1.Name = "button1";
            button1.Size = new Size(135, 43);
            button1.TabIndex = 3;
            button1.Text = "Tambah Ke keranjang";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(576, 414);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 2;
            label1.Text = "Jumlah ";
            // 
            // txtJumlah
            // 
            txtJumlah.Location = new Point(662, 419);
            txtJumlah.Name = "txtJumlah";
            txtJumlah.Size = new Size(100, 20);
            txtJumlah.TabIndex = 1;
            // 
            // txtDashboardKasir
            // 
            txtDashboardKasir.AutoSize = true;
            txtDashboardKasir.Font = new Font("Segoe UI", 45.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDashboardKasir.ForeColor = Color.FromArgb(80, 43, 15);
            txtDashboardKasir.Location = new Point(580, 0);
            txtDashboardKasir.Name = "txtDashboardKasir";
            txtDashboardKasir.Size = new Size(333, 82);
            txtDashboardKasir.TabIndex = 3;
            txtDashboardKasir.Text = "Best Seller";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(183, 150, 107);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(btnKatalog);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(panel15);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(btnBestSeller);
            panel3.Controls.Add(btnHomePelanggan);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(245, 683);
            panel3.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(251, 238, 215);
            panel7.BackgroundImage = (Image)resources.GetObject("panel7.BackgroundImage");
            panel7.BackgroundImageLayout = ImageLayout.Center;
            panel7.Location = new Point(48, 327);
            panel7.Name = "panel7";
            panel7.Size = new Size(42, 38);
            panel7.TabIndex = 8;
            // 
            // btnKatalog
            // 
            btnKatalog.BackColor = Color.FromArgb(251, 238, 215);
            btnKatalog.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKatalog.Location = new Point(41, 321);
            btnKatalog.Name = "btnKatalog";
            btnKatalog.Size = new Size(149, 48);
            btnKatalog.TabIndex = 7;
            btnKatalog.Text = " Katalog ";
            btnKatalog.TextAlign = ContentAlignment.MiddleRight;
            btnKatalog.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(251, 238, 215);
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Center;
            panel5.Location = new Point(47, 503);
            panel5.Name = "panel5";
            panel5.Size = new Size(42, 37);
            panel5.TabIndex = 3;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(251, 238, 215);
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(41, 500);
            button4.Name = "button4";
            button4.Size = new Size(149, 48);
            button4.TabIndex = 5;
            button4.Text = "Cari Produk";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = false;
            // 
            // panel15
            // 
            panel15.BackColor = Color.FromArgb(251, 238, 215);
            panel15.BackgroundImage = Properties.Resources.Frame;
            panel15.BackgroundImageLayout = ImageLayout.Center;
            panel15.Location = new Point(47, 240);
            panel15.Name = "panel15";
            panel15.Size = new Size(42, 37);
            panel15.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(251, 238, 215);
            panel6.BackgroundImage = (Image)resources.GetObject("panel6.BackgroundImage");
            panel6.BackgroundImageLayout = ImageLayout.Stretch;
            panel6.Location = new Point(48, 420);
            panel6.Name = "panel6";
            panel6.Size = new Size(42, 38);
            panel6.TabIndex = 6;
            // 
            // btnBestSeller
            // 
            btnBestSeller.BackColor = Color.FromArgb(251, 238, 215);
            btnBestSeller.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBestSeller.Location = new Point(41, 415);
            btnBestSeller.Name = "btnBestSeller";
            btnBestSeller.Size = new Size(152, 48);
            btnBestSeller.TabIndex = 3;
            btnBestSeller.Text = "Best Seller ";
            btnBestSeller.TextAlign = ContentAlignment.MiddleRight;
            btnBestSeller.UseVisualStyleBackColor = false;
            // 
            // btnHomePelanggan
            // 
            btnHomePelanggan.BackColor = Color.FromArgb(251, 238, 215);
            btnHomePelanggan.Font = new Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHomePelanggan.Location = new Point(38, 235);
            btnHomePelanggan.Name = "btnHomePelanggan";
            btnHomePelanggan.Size = new Size(152, 48);
            btnHomePelanggan.TabIndex = 2;
            btnHomePelanggan.Text = "Home  ";
            btnHomePelanggan.TextAlign = ContentAlignment.MiddleRight;
            btnHomePelanggan.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackgroundImage = Properties.Resources.Group;
            panel4.BackgroundImageLayout = ImageLayout.Center;
            panel4.Location = new Point(20, 24);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 132);
            panel4.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(0, 0);
            panel1.TabIndex = 0;
            // 
            // databaseConnectionBindingSource
            // 
            databaseConnectionBindingSource.DataSource = typeof(DatabaseConnection);
            // 
            // BestSeller
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panel2);
            Name = "BestSeller";
            Text = "BestSeller";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBestSeller).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)databaseConnectionBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel12;
        private Label label3;
        private Panel panel9;
        private Label txtDashboardKasir;
        private Panel panel3;
        private Panel panel7;
        private Button btnKatalog;
        private Panel panel5;
        private Button button4;
        private Panel panel15;
        private Panel panel6;
        private Button btnBestSeller;
        private Button btnHomePelanggan;
        private Panel panel4;
        private Panel panel1;
        private BindingSource databaseConnectionBindingSource;
        private Button button1;
        private Label label1;
        private TextBox txtJumlah;
        private DataGridView dataGridViewBestSeller;
    }
}