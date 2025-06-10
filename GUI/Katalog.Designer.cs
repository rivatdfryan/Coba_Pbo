namespace Kinar_Bakery.GUI
{
    partial class Katalog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Katalog));
            panel2 = new Panel();
            panel12 = new Panel();
            textBox1 = new TextBox();
            comboBoxUrut = new ComboBox();
            label3 = new Label();
            panel9 = new Panel();
            button1 = new Button();
            txtJumlah = new TextBox();
            label1 = new Label();
            dataGridViewKatalog = new DataGridView();
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
            panel2.SuspendLayout();
            panel12.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKatalog).BeginInit();
            panel3.SuspendLayout();
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
            panel2.TabIndex = 7;
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(80, 43, 15);
            panel12.Controls.Add(textBox1);
            panel12.Controls.Add(comboBoxUrut);
            panel12.Controls.Add(label3);
            panel12.Location = new Point(270, 97);
            panel12.Name = "panel12";
            panel12.Size = new Size(984, 59);
            panel12.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(797, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 20);
            textBox1.TabIndex = 10;
            // 
            // comboBoxUrut
            // 
            comboBoxUrut.FormattingEnabled = true;
            comboBoxUrut.Location = new Point(24, 18);
            comboBoxUrut.Name = "comboBoxUrut";
            comboBoxUrut.Size = new Size(121, 21);
            comboBoxUrut.TabIndex = 9;
            comboBoxUrut.Text = "Urutkan";
            comboBoxUrut.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(251, 238, 215);
            label3.Location = new Point(643, 14);
            label3.Name = "label3";
            label3.Size = new Size(148, 25);
            label3.TabIndex = 8;
            label3.Text = "Cari Produk";
            label3.Click += label3_Click;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(183, 150, 107);
            panel9.Controls.Add(button1);
            panel9.Controls.Add(txtJumlah);
            panel9.Controls.Add(label1);
            panel9.Controls.Add(dataGridViewKatalog);
            panel9.Location = new Point(270, 97);
            panel9.Name = "panel9";
            panel9.Size = new Size(984, 573);
            panel9.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(823, 514);
            button1.Name = "button1";
            button1.Size = new Size(149, 49);
            button1.TabIndex = 13;
            button1.Text = "Tambah Ke Keranjang";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtJumlah
            // 
            txtJumlah.Location = new Point(633, 529);
            txtJumlah.Name = "txtJumlah";
            txtJumlah.Size = new Size(96, 20);
            txtJumlah.TabIndex = 12;
            txtJumlah.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(80, 43, 15);
            label1.Location = new Point(530, 524);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 11;
            label1.Text = "Jumlah";
            // 
            // dataGridViewKatalog
            // 
            dataGridViewKatalog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKatalog.Location = new Point(52, 71);
            dataGridViewKatalog.Name = "dataGridViewKatalog";
            dataGridViewKatalog.Size = new Size(845, 437);
            dataGridViewKatalog.TabIndex = 0;
            // 
            // txtDashboardKasir
            // 
            txtDashboardKasir.AutoSize = true;
            txtDashboardKasir.Font = new Font("Segoe UI", 45.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDashboardKasir.ForeColor = Color.FromArgb(80, 43, 15);
            txtDashboardKasir.Location = new Point(454, 0);
            txtDashboardKasir.Name = "txtDashboardKasir";
            txtDashboardKasir.Size = new Size(575, 82);
            txtDashboardKasir.TabIndex = 3;
            txtDashboardKasir.Text = "KATALOG PRODUK";
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
            // Katalog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panel2);
            Name = "Katalog";
            Text = "Katalog";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKatalog).EndInit();
            panel3.ResumeLayout(false);
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
        private ComboBox comboBoxUrut;
        private TextBox textBox1;
        private TextBox txtJumlah;
        private Label label1;
        private DataGridView dataGridViewKatalog;
        private Button button1;
    }
}