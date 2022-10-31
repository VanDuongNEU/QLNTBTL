using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLNTBTL.Class
{
    class Functions
    {
        public static SqlConnection conn;  //Khai báo đối tượng kết nối        

        public static void Connect()
        {
            string constr;
            conn = new SqlConnection();   //Khởi tạo đối tượng
            constr = "Data Source = DESKTOP-ABOQEK5\\BTLQLNT;" +
                "Initial Catalog = QLNT; Integrated Security = True";
            conn.ConnectionString = constr;
            conn.Open();                  //Mở kết nối
            //Kiểm tra kết nối
            if (conn.State == ConnectionState.Open)
                MessageBox.Show("Kết nối thành công");
            else MessageBox.Show("Không thể kết nối với dữ liệu");

        }
        public static void Disconnect()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();   	//Đóng kết nối
                conn.Dispose(); 	//Giải phóng tài nguyên
                conn = null;
            }
        }

        internal static DataTable GetDataToTable(string sql)
        {
            throw new NotImplementedException();
        }
    }
}
