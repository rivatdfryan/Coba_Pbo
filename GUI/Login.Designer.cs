using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Kinar_Bakery
{
    partial class Login
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
            BtnLogin = new Button();
            button1 = new Button();
            Password = new TextBox();
            label4 = new Label();
            Username = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(251, 238, 215);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(BtnLogin);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(Password);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(Username);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(298, 140);
            panel1.Name = "panel1";
            panel1.Size = new Size(683, 439);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.Group_74__1__1_1;
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.ForeColor = Color.FromArgb(251, 238, 215);
            panel2.Location = new Point(38, 141);
            panel2.Name = "panel2";
            panel2.Size = new Size(248, 212);
            panel2.TabIndex = 9;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(543, 283);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(60, 16);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Register";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // BtnLogin
            // 
            BtnLogin.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLogin.ForeColor = Color.FromArgb(80, 43, 15);
            BtnLogin.Location = new Point(364, 315);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(166, 38);
            BtnLogin.TabIndex = 7;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click_1;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.Vector;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Location = new Point(551, 234);
            button1.Name = "button1";
            button1.Size = new Size(52, 35);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = true;
            // 
            // Password
            // 
            Password.BackColor = Color.White;
            Password.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password.Location = new Point(310, 234);
            Password.Name = "Password";
            Password.Size = new Size(235, 35);
            Password.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(303, 206);
            label4.Name = "label4";
            label4.Size = new Size(111, 25);
            label4.TabIndex = 4;
            label4.Text = "Password";
            // 
            // Username
            // 
            Username.BackColor = Color.White;
            Username.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Username.Location = new Point(310, 155);
            Username.Name = "Username";
            Username.Size = new Size(293, 35);
            Username.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(303, 123);
            label3.Name = "label3";
            label3.Size = new Size(119, 25);
            label3.TabIndex = 2;
            label3.Text = "Username";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(80, 43, 15);
            label2.Location = new Point(155, 83);
            label2.Name = "label2";
            label2.Size = new Size(375, 25);
            label2.TabIndex = 1;
            label2.Text = "Please Login to access KInar Bakery";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 45.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(80, 43, 15);
            label1.Location = new Point(245, 0);
            label1.Name = "label1";
            label1.Size = new Size(195, 82);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._D9C19D_1__1_;
            ClientSize = new Size(1264, 681);
            Controls.Add(panel1);
            MaximumSize = new Size(1980, 1080);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox Password;
        private Label label4;
        private TextBox Username;
        private Button button1;
        private Button BtnLogin;
        private Panel panel2;
        private LinkLabel linkLabel1;
    }
}



