using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLNTBTL.Class;

namespace QLNTBTL
{

    public partial class FrmLoaiThuoc : Form
    {
        DataTable tblLoaiThuoc; //Chứa dữ liệu bảng loại thuốc
        private void FrmLoaiThuoc_Load(object sender, EventArgs e)
        {
            txtMaLoaiT.Enabled = false;
            btnLuu.Enabled = false;
            LoadDataGridView(); //Hiển thị bảng tblLoaithuoc
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM tblLoaiThuoc";
            tblLoaiThuoc = Class.Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            grddataLoaiThuoc.DataSource = tblLoaiThuoc; //Nguồn dữ liệu            
            grddataLoaiThuoc.Columns[0].HeaderText = "Mã Loại Thuốc";
            grddataLoaiThuoc.Columns[1].HeaderText = "Mã Loại Thuốc";
            grddataLoaiThuoc.Columns[0].Width = 100;
            grddataLoaiThuoc.Columns[1].Width = 300;
            grddataLoaiThuoc.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            grddataLoaiThuoc.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }
        //Lấy dữ liệu vào bảng
        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(); //Định nghĩa đối tượng thuộc lớp SqlDataAdapter
            //Tạo đối tượng thuộc lớp SqlCommand
            dap.SelectCommand = new SqlCommand();
            dap.SelectCommand.Connection = Functions.conn; //Kết nối cơ sở dữ liệu
            dap.SelectCommand.CommandText = sql; //Lệnh SQL
            //Khai báo đối tượng table thuộc lớp DataTable
            DataTable table = new DataTable();
            dap.Fill(table);
            return table;
        }

        private void grddataLoaiThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grddataLoaiThuoc_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaLoaiT.Focus();
                return;
            }
            if (tblLoaiThuoc.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaLoaiT.Text = grddataLoaiThuoc.CurrentRow.Cells["MaChatLieu"].Value.ToString();
            txtTenLoaiThuoc.Text = grddataLoaiThuoc.CurrentRow.Cells["TenChatLieu"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
      
        }
    }
}
