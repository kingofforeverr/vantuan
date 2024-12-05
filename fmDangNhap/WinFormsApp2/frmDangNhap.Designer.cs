namespace WinFormsApp2
{
    partial class frmDangNhap
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
            label1 = new Label();
            label2 = new Label();
            txtTenDN = new TextBox();
            label3 = new Label();
            txtMatKhau = new TextBox();
            btnDangNhap = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label4 = new Label();
            label5 = new Label();
            rbChuTro = new RadioButton();
            rbKhach = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 71);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 155);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên Đăng Nhập";
            // 
            // txtTenDN
            // 
            txtTenDN.Location = new Point(390, 148);
            txtTenDN.Name = "txtTenDN";
            txtTenDN.Size = new Size(219, 27);
            txtTenDN.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(262, 206);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 3;
            label3.Text = "Mật Khẩu";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(390, 206);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(219, 27);
            txtMatKhau.TabIndex = 1;
            txtMatKhau.TextChanged += txtMatKhau_TextChanged;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(489, 296);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(169, 39);
            btnDangNhap.TabIndex = 2;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(301, 33);
            label4.Name = "label4";
            label4.Size = new Size(166, 38);
            label4.TabIndex = 4;
            label4.Text = "Đăng Nhập";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(262, 106);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 5;
            label5.Text = "Vai trò";
            // 
            // rbChuTro
            // 
            rbChuTro.AutoSize = true;
            rbChuTro.Location = new Point(366, 102);
            rbChuTro.Name = "rbChuTro";
            rbChuTro.Size = new Size(78, 24);
            rbChuTro.TabIndex = 6;
            rbChuTro.TabStop = true;
            rbChuTro.Text = "Chủ trọ";
            rbChuTro.UseVisualStyleBackColor = true;
            // 
            // rbKhach
            // 
            rbKhach.AutoSize = true;
            rbKhach.Location = new Point(480, 104);
            rbKhach.Name = "rbKhach";
            rbKhach.Size = new Size(103, 24);
            rbKhach.TabIndex = 7;
            rbKhach.TabStop = true;
            rbKhach.Text = "Khách thuê";
            rbKhach.UseVisualStyleBackColor = true;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rbKhach);
            Controls.Add(rbChuTro);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(label3);
            Controls.Add(txtTenDN);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDangNhap";
            FormClosing += frmDangNhap_FormClosing;           
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTenDN;
        private Label label3;
        private TextBox txtMatKhau;
        private Button btnDangNhap;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label4;
        private Label label5;
        private RadioButton rbChuTro;
        private RadioButton rbKhach;
    }
}