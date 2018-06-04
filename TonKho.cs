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
namespace QuanLyKhoHang
{
    public partial class TonKho : Form
    {
        public TonKho()
        {
            InitializeComponent();
        }

        accessData acc = new accessData();
        //private void btnThem_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string sql = "insert into TonKho Values(N'" + tbxMaSP.Text + "','" + tbxMaHSX.Text + "','" + tbxSoLuong.Text + "')";
        //        acc.excuteNonQuery(sql);
        //        MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        TonKho_Load(sender, e);
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("error");
        //    }
        //}

        //private void btnSua_Click(object sender, EventArgs e)
        //{           
        //    if (tbxMaSP.Text != "")
        //    {
        //        string sql = "UPDATE TonKho SET MaSP ='" + tbxMaSP.Text + "', MaHSX ='" + tbxMaHSX.Text + "',SoLuong ='" + tbxSoLuong.Text + "' WHERE MaSP='" + tbxMaSP.Text + "'";
        //        acc.excuteNonQuery(sql);
        //        MessageBox.Show("Cập Nhật Thành Công");
        //        TonKho_Load(sender, e);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Nhập sai mã sản phẩm!", "Thông báo");
        //    }
        //}

        //private void btnXoa_Click(object sender, EventArgs e)
        //{          
        //    string sql = "delete from TonKho where MaSP='" + tbxMaSP.Text + "'";
        //    acc.excuteNonQuery(sql);            
        //    tbxMaSP.Clear();               
        //    tbxMaHSX.Clear();
        //    tbxSoLuong.Clear();          
        //    MessageBox.Show("Xoá thành công !");
        //    TonKho_Load(sender, e);
        //}

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiaoDien menu = new GiaoDien();
            menu.ShowDialog();
        }

        private void TonKho_Load(object sender, EventArgs e)
        {

            string sql1 = "CapNhat";
            string sql2 = "sp_TonKho";
            string sql3 = "sp_Nhap";
            string sql4 = "sp_Xuat";
            try
            {
                if (acc.excuteNonQuery(sql1) == true)
                {
                    DataTable ds1 = new DataTable();
                    DataTable ds2 = new DataTable();
                    DataTable ds3 = new DataTable();
                    SqlDataAdapter dap1 = acc.executeDatatable(sql2);
                    SqlDataAdapter dap2= acc.executeDatatable(sql3);
                    SqlDataAdapter dap3 = acc.executeDatatable(sql4);
                    dap1.Fill(ds1);
                    dgvTonKho.DataSource = ds1;
                    dgvTonKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dap2.Fill(ds2);
                    dgvNhapHang.DataSource = ds2;
                    dgvNhapHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dap3.Fill(ds3);
                    dgvHangXuat.DataSource = ds3;
                    dgvHangXuat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    txtTong1.Text = acc.executeScalar("select sum(a.Soluong) from SanPham a").ToString();
                    txtTong2.Text = acc.executeScalar("select sum(a.Soluong) from PhieuNhap a").ToString();
                    txtTong3.Text = acc.executeScalar("select sum(a.Soluong) from PhieuXuat a").ToString();
                    txtTien1.Text = acc.executeScalar("sp_Tien_Kho").ToString();
                    txtTien2.Text = acc.executeScalar("select convert(nvarchar(20),sum(a.Soluong*a.DonGia)) from PhieuNhap a").ToString();
                    txtTien3.Text = acc.executeScalar("select convert(nvarchar(20),sum(a.Soluong*a.DonGia)) from PhieuXuat a").ToString();

                }
            }
            catch
            {
                MessageBox.Show("cap nhat khong thanh cong","bao loi");
            }
        }
    }
}
