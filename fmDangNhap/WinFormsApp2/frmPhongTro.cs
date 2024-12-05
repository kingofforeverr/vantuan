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
    public partial class frmPhongTro : Form
    {
        string sCon = "Data Source=HIKARI\\TUAN;Initial Catalog=QuanLyPhongTro;Integrated Security=True;Trust Server Certificate=True";

        public frmPhongTro()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi quá trình kết nối DB");
            }
            string sMaPhong = txtMaPhong.Text;
            //check mã phòng tồn tại
            string sCheckQuery = "SELECT COUNT(*) FROM PhongTro WHERE MaPhong = @maphong";
            SqlCommand checkcmd = new SqlCommand(sCheckQuery, con);
            checkcmd.Parameters.AddWithValue("@maphong", sMaPhong);

            int count = (int)checkcmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Mã phòng đã tồn tại vui lòng nhập mã khác");
                con.Close();
                return;
            }

            string sTinhTrang = txtTinhTrang.Text;
            string sSoLuongKhach = txtSoLuongKhach.Text;
            int iSoLuongKhach = Convert.ToInt32(sSoLuongKhach);
            string sGiaPhong = txtGiaPhong.Text;
            decimal dGiaPhong = Convert.ToDecimal(sGiaPhong);
            string sDienTich = txtDienTich.Text;
            decimal dDienTich = Convert.ToDecimal(sDienTich);
            //thêm mới
            string sQuery = "insert into PhongTro values(@maphong,@tinhtrang, @soluong,@giaphong, @dientich)";

            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@maphong", sMaPhong);
            cmd.Parameters.AddWithValue("@tinhtrang", sTinhTrang);
            cmd.Parameters.AddWithValue("@soluong", iSoLuongKhach);
            cmd.Parameters.AddWithValue("@giaphong", dGiaPhong);
            cmd.Parameters.AddWithValue("@dientich", dDienTich);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mới phòng thành công");

            }
            catch
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình thêm mới");

            }
            con.Close();

        }

        private void frmPhongTro_Load(object sender, EventArgs e)
        {
            LoadData();
            cbCriteria.Items.Add("Tên");
            cbCriteria.Items.Add("Tình trạng phòng");
            cbCriteria.Items.Add("Quê quán");
            cbCriteria.Items.Add("Số điện thoại");
            cbCriteria.SelectedIndex = 0;
        }
        private void LoadData()
        {
            using (SqlConnection con = new SqlConnection(sCon))
            {
                string query = "select * from PhongTro";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            // Lấy tiêu chí lọc
            string criteria = cbCriteria.SelectedItem.ToString();
            string keyword = txtSearch.Text;

            // Xây dựng câu truy vấn động
            string query = "SELECT * FROM PhongTro ";

            // Thêm điều kiện lọc
            if (!string.IsNullOrEmpty(keyword))
            {
                if (criteria == "Tên")
                    query += " AND TenKhachThue LIKE @keyword";
                else if (criteria == "Tình trạng phòng")
                    query += " AND TinhTrangPhong = @keyword";
                else if (criteria == "Quê quán")
                    query += " AND QueQuan LIKE @keyword";
                else if (criteria == "Số điện thoại")
                    query += " AND SoDienThoai LIKE @keyword";
            }

            // Thực thi câu lệnh SQL
            using (SqlConnection con = new SqlConnection(sCon))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@keyword", keyword );

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Hiển thị kết quả vào DataGridView
                dataGridView1.DataSource = dt;
            }
        }
    }
}
