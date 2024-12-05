using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class frmDangNhap : Form
    {
        //chuỗi kết nối
        string sCon = "Data Source=HIKARI\\TUAN;Initial Catalog=QuanLyPhongTro;Integrated Security=True;Trust Server Certificate=True";
        public frmDangNhap()
        {
            InitializeComponent();
            //this.txtMatKhau.PasswordChar = '*';
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string sTenDN = txtTenDN.Text;
            string sMatKhau = txtMatKhau.Text;

            if (!rbChuTro.Checked && !rbKhach.Checked)
            {
                MessageBox.Show("Vui lòng chọn vai trò (Chủ trọ hoặc Khách thuê).", "Thông báo");
                return;
            }

            string sVaitro = rbChuTro.Checked ? "Chủ trọ" : "Khách thuê";

            if (string.IsNullOrEmpty(sTenDN) || string.IsNullOrEmpty(sMatKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.", "Thông báo");
                return;
            }

            // Mở kết nối
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kết nối DB: " + ex.Message);
                return; // Thoát nếu không thể kết nối
            }

            SqlCommand cmd = new SqlCommand("checkLogin", con);
            cmd.CommandType = CommandType.StoredProcedure;

            // Thêm các tham số
            cmd.Parameters.AddWithValue("@username", sTenDN);
            cmd.Parameters.AddWithValue("@chucvu", sVaitro);
            cmd.Parameters.AddWithValue("@password", sMatKhau);

            // Thêm biến đầu ra
            SqlParameter resultParam = new SqlParameter("@kq", SqlDbType.Int);
            resultParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(resultParam);

            // Thực thi thủ tục
            cmd.ExecuteNonQuery();

            // Lấy giá trị của biến đầu ra
            int result = (int)resultParam.Value;

            // Kiểm tra kết quả
            if (result == 1)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                OpenFunctionForm(sVaitro);
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.", "Thông báo");
            }

            con.Close();
        }
        private void OpenFunctionForm(string loaiNguoiDung)
        {
            // Chuyển sang màn hình chức năng dựa trên loại người dùng
            switch (loaiNguoiDung)
            {
                case "Chủ trọ": // Admin
                    frmKhachHang adminForm = new frmKhachHang();
                    adminForm.Show();
                    break;

                case "Khách thuê": // User
                    frmCaculator userForm = new frmCaculator();
                    userForm.Show();
                    break;

                default:
                    MessageBox.Show("Không xác định được quyền của người dùng.", "Thông báo");
                    break;
            }

            // Ẩn form đăng nhập
            this.Hide();
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Xin chào và hẹn gặp lại", "Thông báo");
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            //txtMatKhau.PasswordChar = '*';
        }

        
    }
}
