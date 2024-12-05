namespace WinFormsApp2
{
    partial class frmCaculator
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
            txtSo1 = new TextBox();
            txtKetQua = new TextBox();
            txtSo2 = new TextBox();
            btnCong = new Button();
            btnChia = new Button();
            btnTru = new Button();
            btnNhan = new Button();
            SuspendLayout();
            // 
            // txtSo1
            // 
            txtSo1.Location = new Point(166, 85);
            txtSo1.Name = "txtSo1";
            txtSo1.Size = new Size(107, 27);
            txtSo1.TabIndex = 0;
            txtSo1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtKetQua
            // 
            txtKetQua.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtKetQua.Location = new Point(311, 153);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(107, 34);
            txtKetQua.TabIndex = 1;
            txtKetQua.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSo2
            // 
            txtSo2.Location = new Point(469, 85);
            txtSo2.Name = "txtSo2";
            txtSo2.Size = new Size(107, 27);
            txtSo2.TabIndex = 2;
            txtSo2.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCong
            // 
            btnCong.Location = new Point(85, 242);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(95, 32);
            btnCong.TabIndex = 3;
            btnCong.Text = "Cộng";
            btnCong.UseVisualStyleBackColor = true;
            btnCong.Click += btnCong_Click;
            // 
            // btnChia
            // 
            btnChia.Location = new Point(616, 242);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(95, 32);
            btnChia.TabIndex = 4;
            btnChia.Text = "Chia";
            btnChia.UseVisualStyleBackColor = true;
            // 
            // btnTru
            // 
            btnTru.Location = new Point(259, 242);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(95, 32);
            btnTru.TabIndex = 5;
            btnTru.Text = "Trừ";
            btnTru.UseVisualStyleBackColor = true;
            // 
            // btnNhan
            // 
            btnNhan.Location = new Point(457, 242);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(95, 32);
            btnNhan.TabIndex = 6;
            btnNhan.Text = "Nhân";
            btnNhan.UseVisualStyleBackColor = true;
            // 
            // frmCaculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNhan);
            Controls.Add(btnTru);
            Controls.Add(btnChia);
            Controls.Add(btnCong);
            Controls.Add(txtSo2);
            Controls.Add(txtKetQua);
            Controls.Add(txtSo1);
            Name = "frmCaculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCaculator";
            FormClosing += frmCaculator_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSo1;
        private TextBox txtKetQua;
        private TextBox txtSo2;
        private Button btnCong;
        private Button btnChia;
        private Button btnTru;
        private Button btnNhan;
    }
}