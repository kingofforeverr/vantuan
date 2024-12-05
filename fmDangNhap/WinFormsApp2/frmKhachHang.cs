//using Microsoft.Data.SqlClient;
//using System;
//using System.Data;
//using System.Data.SqlClient;
//namespace WinFormsApp2
//{
//    public partial class frmKhachHang : Form
//    {
//        string sCon = "Data Source=HIKARI\\TUAN;Initial Catalog=quanlykhachhang;Integrated Security=True;Trust Server Certificate=True";
//        public frmKhachHang()
//        {
//            InitializeComponent();
//        }
        




       

        

//        private void frmKhachHang_Load(object sender, EventArgs e)
//        {
//            //kết nối DB
//            SqlConnection con = new SqlConnection(sCon);
//            try
//            {
//                con.Open();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
//            }
//            // lấy dữ liệu về
//            string sQuery = "select * from khachhang";
//            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);//option 3

//            DataSet ds = new DataSet();

//            adapter.Fill(ds, "KhachHang");//option 3

//            //fill vào datagridview
//            dataGridView1.DataSource = ds.Tables["KhachHang"];

//            con.Close();
//        }

//        private void btnLuu_Click(object sender, EventArgs e)
//        {
//            //khỏi tạo kết nối
//            SqlConnection con = new SqlConnection(sCon);

//            try
//            {
//                con.Open();
//            }
//            catch(Exception ex)
//            {
//                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");

//            }
//            //bước 2
//            //chuẩn bị dữ liệu
//            //kiểm tra tính hợp lệ
//            string sMaKH = txtMaKH.Text;
//            string sTenKH = txtTenKH.Text;
//            string sDiaChi = txtDiaChi.Text;
//            string sNgaySinh = dateTimePicker1.Value.ToString("yyyy-MM-dd");
//            int iGioiTinh = 0;
//            if (rbNam.Checked == true)
//            {
//                iGioiTinh = 1;
//            }
//            //sqlcommand

//            string sQuery = "insert into khachhang values(@makh, @tenkh,@gioitinh,@ngaysinh,@diachi)";

//            SqlCommand cmd = new SqlCommand(sQuery, con);
//            cmd.Parameters.AddWithValue("@makh", sMaKH);
//            cmd.Parameters.AddWithValue("@tenkh", sTenKH);
//            cmd.Parameters.AddWithValue("@gioitinh", iGioiTinh);
//            cmd.Parameters.AddWithValue("@ngaysinh", sNgaySinh);
//            cmd.Parameters.AddWithValue("@diachi", sDiaChi);

//            try
//            {
//                cmd.ExecuteNonQuery();
//                MessageBox.Show("Thêm mới thành công");
//            }
//            catch(Exception ex) 
//            {
//                    MessageBox.Show("xảy ra lỗi trong quá trình thêm mới");
//            }
//            con.Close();

//        }
//    }
//}

using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class frmKhachHang : Form
    {
        //string sCon = "Data Source=HIKARI\\TUAN;Initial Catalog=quanlykhachhang;Integrated Security=True;Trust Server Certificate=True";
        string sCon = "Data Source=HIKARI\\TUAN;Initial Catalog=QuanLyPhongTro;Integrated Security=True;Trust Server Certificate=True";

        public frmKhachHang()
        {
            InitializeComponent();
        }
        private void frmKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Thêm logic bạn muốn xử lý khi form đóng
            //MessageBox.Show("Xin chào và hẹn gặp lại:))", "Thông báo");
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadData(); // Gọi phương thức nạp dữ liệu khi form load
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Khởi tạo kết nối
            SqlConnection con = new SqlConnection(sCon);

            try
            {
                con.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
                return;
            }

            // Chuẩn bị dữ liệu
            string sMaKH = txtCanCuoc.Text;
            // Kiểm tra nếu mã khách hàng đã tồn tại
            string checkQuery = "SELECT COUNT(*) FROM khachthue WHERE cccd = @cccd";
            SqlCommand checkCmd = new SqlCommand(checkQuery, con);
            checkCmd.Parameters.AddWithValue("@cccd", sMaKH);

            int count = (int)checkCmd.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("Mã khách hàng đã tồn tại. Vui lòng nhập mã khác.");
                con.Close();
                return;
            }
            string sTenKH = txtTenKH.Text;
            string sSdt = txtSoDienThoai.Text;
            string sNgaySinh = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string iGioiTinh = rbNam.Checked ? "NAM" : "NU";
            string sMaPhong = txtMaPhong.Text;
            string sQueQuan = txtQueQuan.Text;
            // Câu lệnh SQL
            string sQuery = "INSERT INTO khachthue VALUES (@makh, @tenkh, @ngaysinh, @sdt, @gioitinh, @quequan, @maphong)";
            SqlCommand cmd = new SqlCommand(sQuery, con);

            // Thêm tham số
            cmd.Parameters.AddWithValue("@makh", sMaKH);
            cmd.Parameters.AddWithValue("@tenkh", sTenKH);
            cmd.Parameters.AddWithValue("@gioitinh", iGioiTinh);
            cmd.Parameters.AddWithValue("@ngaysinh", sNgaySinh);
            cmd.Parameters.AddWithValue("@sdt", sSdt);
            cmd.Parameters.AddWithValue("@quequan", sQueQuan);
            cmd.Parameters.AddWithValue("@maphong", sMaPhong);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công!");

                // Tải lại dữ liệu
                LoadData();
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình thêm mới.");
            }
            finally
            {
                con.Close();
            }
        }

        private void LoadData()
        {
            // Kết nối DB
            SqlConnection con = new SqlConnection(sCon);

            try
            {
                con.Open();

                // Lấy dữ liệu
                string sQuery = "SELECT * FROM khachthue";
                SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

                DataSet ds = new DataSet();
                adapter.Fill(ds, "KhachThue");

                // Gắn dữ liệu vào DataGridView
                dataGridView1.DataSource = ds.Tables["KhachThue"];
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình tải dữ liệu.");
            }
            finally
            {
                con.Close();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);

            try
            {
                con.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
                return;
            }

            string sMaKH = txtCanCuoc.Text;
            string sTenKH = txtTenKH.Text;
            string sNgaySinh = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string sSdt = txtSoDienThoai.Text;
            string iGioiTinh = rbNam.Checked ? "NAM" : "NU";
            string sQueQuan = txtQueQuan.Text;
            string sMaPhong = txtMaPhong.Text;
            string sQuery = "UPDATE khachthue SET TenKhachThue = @tenkh, sodienthoai = @sdt, " +
                            "ngaysinh = @ngaysinh, gioitinh = @gioitinh ,quequan=@quequan,maphong=@maphong " +
                            "WHERE cccd = @cccd";

            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@cccd", sMaKH);
            cmd.Parameters.AddWithValue("@tenkh", sTenKH);
            cmd.Parameters.AddWithValue("@ngaysinh", sNgaySinh);
            cmd.Parameters.AddWithValue("@sdt", sSdt);
            cmd.Parameters.AddWithValue("@gioitinh", iGioiTinh);
            cmd.Parameters.AddWithValue("@quequan", sQueQuan);
            cmd.Parameters.AddWithValue("@maphong", sMaPhong);


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!");
                LoadData(); // Tải lại dữ liệu sau khi cập nhật
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình cập nhật.");
            }
            finally
            {
                con.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCanCuoc.Text = dataGridView1.Rows[e.RowIndex].Cells["CCCD"].Value.ToString();
            txtTenKH.Text = dataGridView1.Rows[e.RowIndex].Cells["TenKhachThue"].Value.ToString();
            txtMaPhong.Text = dataGridView1.Rows[e.RowIndex].Cells["MaPhong"].Value.ToString();
            txtQueQuan.Text = dataGridView1.Rows[e.RowIndex].Cells["QueQuan"].Value.ToString();
            txtSoDienThoai.Text = dataGridView1.Rows[e.RowIndex].Cells["SoDienThoai"].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime
            (dataGridView1.Rows[e.RowIndex].Cells["NgaySinh"].Value);
            string iGioiTinh = dataGridView1.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString();
            if (iGioiTinh == "NAM")
            {
                rbNam.Checked = true;
            }
            else
            {
                rbNu.Checked = true;
            }
            //txtMaKH.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi trong quá trình kết nối DB");
            }

            string sCanCuoc = txtCanCuoc.Text;

            string sQuery = "delete from khachthue where cccd=@cccd";
            SqlCommand cmd = new SqlCommand(sQuery, con);

            cmd.Parameters.AddWithValue("@cccd", sCanCuoc);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thông tin khách hàng thành công");
                LoadData();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Xảy ra lỗi trong quá trình xóa thông tin.");

            }
            con.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmDangNhap frmLogin = new frmDangNhap();
            frmLogin.Show();

            // Đóng form admin hiện tại
            this.Close();
        }
    }
}
