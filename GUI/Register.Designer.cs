namespace Kinar_Bakery
{
    partial class Register
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
            panel1 = new Panel();
            panel2 = new Panel();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            Password = new TextBox();
            label5 = new Label();
            NomorTelepon = new TextBox();
            label4 = new Label();
            Username = new TextBox();
            label3 = new Label();
            NamaLengkap = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtAlamat = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources._D9C19D_1__1_;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1366, 768);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(251, 238, 215);
            panel2.Controls.Add(txtAlamat);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(Password);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(NomorTelepon);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(Username);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(NamaLengkap);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(302, 122);
            panel2.Name = "panel2";
            panel2.Size = new Size(675, 461);
            panel2.TabIndex = 0;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(506, 357);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(37, 15);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(287, 379);
            button1.Name = "button1";
            button1.Size = new Size(115, 38);
            button1.TabIndex = 9;
            button1.Text = "SIMPAN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Password
            // 
            Password.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password.Location = new Point(100, 306);
            Password.Name = "Password";
            Password.Size = new Size(474, 35);
            Password.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(80, 43, 15);
            label5.ImageAlign = ContentAlignment.TopCenter;
            label5.Location = new Point(103, 286);
            label5.Name = "label5";
            label5.Size = new Size(66, 17);
            label5.TabIndex = 7;
            label5.Text = "Password";
            // 
            // NomorTelepon
            // 
            NomorTelepon.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NomorTelepon.Location = new Point(100, 237);
            NomorTelepon.Name = "NomorTelepon";
            NomorTelepon.Size = new Size(474, 35);
            NomorTelepon.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(80, 43, 15);
            label4.ImageAlign = ContentAlignment.TopCenter;
            label4.Location = new Point(100, 217);
            label4.Name = "label4";
            label4.Size = new Size(104, 17);
            label4.TabIndex = 5;
            label4.Text = "Nomor Telepon";
            // 
            // Username
            // 
            Username.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Username.Location = new Point(100, 170);
            Username.Name = "Username";
            Username.Size = new Size(474, 35);
            Username.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(80, 43, 15);
            label3.ImageAlign = ContentAlignment.TopCenter;
            label3.Location = new Point(100, 150);
            label3.Name = "label3";
            label3.Size = new Size(69, 17);
            label3.TabIndex = 3;
            label3.Text = "Username";
            // 
            // NamaLengkap
            // 
            NamaLengkap.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NamaLengkap.Location = new Point(100, 103);
            NamaLengkap.Name = "NamaLengkap";
            NamaLengkap.Size = new Size(474, 35);
            NamaLengkap.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(80, 43, 15);
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(100, 83);
            label2.Name = "label2";
            label2.Size = new Size(100, 17);
            label2.TabIndex = 1;
            label2.Text = "Nama Lengkap";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 45.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(80, 43, 15);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(213, 0);
            label1.Name = "label1";
            label1.Size = new Size(269, 82);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(106, 367);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(100, 23);
            txtAlamat.TabIndex = 11;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(panel1);
            Name = "Register";
            Text = "pane";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private TextBox Password;
        private Label label5;
        private Button button2;
        private TextBox NomorTelepon;
        private Label label4;
        private TextBox Username;
        private Label label3;
        private TextBox NamaLengkap;
        private Button button1;
        private LinkLabel linkLabel1;
        private TextBox txtAlamat;
    }
}