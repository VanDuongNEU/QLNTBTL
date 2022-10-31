using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNTBTL
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void frmmain_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Class.Functions.Disconnect(); //Đóng kết nối
            Application.Exit(); //Thoát
        }

        private void lOẠITHUỐCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLoaiThuoc f_loaithuoc = new FrmLoaiThuoc();
            f_loaithuoc.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmDMHH f_dmhh = new FrmDMHH();
            f_dmhh.ShowDialog();
        }

        private void nHÂNVIÊNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNhanVien f_nhanvien = new FrmNhanVien();
            f_nhanvien.ShowDialog();
        }

        private void kHÁCHHÀNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKhachHang f_khachhang = new FrmKhachHang();
            f_khachhang.ShowDialog();
        }

        private void hÓAĐƠNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHoaDon f_hoadon = new FrmHoaDon();
            f_hoadon.ShowDialog();
        }
    }
}
