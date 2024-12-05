namespace WinFormsApp2
{
    partial class frmPhongTro
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtMaPhong = new TextBox();
            txtGiaPhong = new TextBox();
            txtDienTich = new TextBox();
            txtSoLuongKhach = new TextBox();
            txtTinhTrang = new TextBox();
            dataGridView1 = new DataGridView();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            cbCriteria = new ComboBox();
            txtSearch = new TextBox();
            btnFilter = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(362, 9);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 72);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã phòng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 126);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 2;
            label3.Text = "Tình trạng phòng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 163);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 3;
            label4.Text = "Số khách thuê";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(85, 251);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 4;
            label5.Text = "Diện tích";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(85, 202);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 5;
            label6.Text = "Giá phòng";
            // 
            // txtMaPhong
            // 
            txtMaPhong.Location = new Point(250, 69);
            txtMaPhong.Name = "txtMaPhong";
            txtMaPhong.Size = new Size(172, 27);
            txtMaPhong.TabIndex = 0;
            // 
            // txtGiaPhong
            // 
            txtGiaPhong.Location = new Point(250, 202);
            txtGiaPhong.Name = "txtGiaPhong";
            txtGiaPhong.Size = new Size(172, 27);
            txtGiaPhong.TabIndex = 3;
            // 
            // txtDienTich
            // 
            txtDienTich.Location = new Point(250, 248);
            txtDienTich.Name = "txtDienTich";
            txtDienTich.Size = new Size(172, 27);
            txtDienTich.TabIndex = 4;
            // 
            // txtSoLuongKhach
            // 
            txtSoLuongKhach.Location = new Point(250, 163);
            txtSoLuongKhach.Name = "txtSoLuongKhach";
            txtSoLuongKhach.Size = new Size(172, 27);
            txtSoLuongKhach.TabIndex = 2;
            // 
            // txtTinhTrang
            // 
            txtTinhTrang.Location = new Point(250, 119);
            txtTinhTrang.Name = "txtTinhTrang";
            txtTinhTrang.Size = new Size(172, 27);
            txtTinhTrang.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(100, 364);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(651, 147);
            dataGridView1.TabIndex = 11;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(435, 302);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(85, 29);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(541, 302);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(85, 29);
            btnSua.TabIndex = 6;
            btnSua.Text = "Cập Nhật";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(654, 302);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(85, 29);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // cbCriteria
            // 
            cbCriteria.FormattingEnabled = true;
            cbCriteria.Location = new Point(522, 69);
            cbCriteria.Name = "cbCriteria";
            cbCriteria.Size = new Size(128, 28);
            cbCriteria.TabIndex = 14;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(522, 119);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(128, 27);
            txtSearch.TabIndex = 15;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(522, 177);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(85, 29);
            btnFilter.TabIndex = 16;
            btnFilter.Text = "Lọc";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // frmPhongTro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 573);
            Controls.Add(btnFilter);
            Controls.Add(txtSearch);
            Controls.Add(cbCriteria);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnLuu);
            Controls.Add(dataGridView1);
            Controls.Add(txtTinhTrang);
            Controls.Add(txtSoLuongKhach);
            Controls.Add(txtDienTich);
            Controls.Add(txtGiaPhong);
            Controls.Add(txtMaPhong);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPhongTro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPhongTro";
            Load += frmPhongTro_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtMaPhong;
        private TextBox txtGiaPhong;
        private TextBox txtDienTich;
        private TextBox txtSoLuongKhach;
        private TextBox txtTinhTrang;
        private DataGridView dataGridView1;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private ListBox listBox1;
        private ListBox listBox2;
        private ComboBox cbCriteria;
        private TextBox txtSearch;
        private Button btnFilter;
    }
}