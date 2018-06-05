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
    public partial class TimKiem : Form
    {
        public TimKiem()
        {
            InitializeComponent();
        }
        accessData acc = new accessData();
        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {

                switch (cbTimKiem.Text)
                {
                    case "Mã sản phẩm":
                        {
                            string sql = "SELECT *FROM SanPham WHERE MaSP like N'%" + txtNhap.Text + "%'";
                            DataTable ds = new DataTable();
                            SqlDataAdapter da = acc.executeDatatable(sql);
                            da.Fill(ds);
                            dgvTimKiem.DataSource = ds;
                            dgvTimKiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dgvTimKiem.Refresh();
                            break;
                        }
                    case "Tên sản phẩm":
                        {
                            string sql = "SELECT *FROM SanPham WHERE TenSP like N'%" + txtNhap.Text + "%'";
                            DataTable ds = new DataTable();
                            SqlDataAdapter da = acc.executeDatatable(sql);
                            da.Fill(ds);
                            dgvTimKiem.DataSource = ds;
                            dgvTimKiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dgvTimKiem.Refresh();
                            break;
                        }
                    case "Loại sản phẩm":
                        {
                            string sql = "SELECT *FROM SanPham WHERE MaLSP like N'%" + txtNhap.Text + "%'";
                            DataTable ds = new DataTable();
                            SqlDataAdapter da = acc.executeDatatable(sql);
                            da.Fill(ds);
                            dgvTimKiem.DataSource = ds;
                            dgvTimKiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dgvTimKiem.Refresh();
                            break;
                        }
                    case "Hãng sản xuất":
                        {
                            string sql = "SELECT *FROM SanPham WHERE MaHSX like N'%" + txtNhap.Text + "%'";
                            DataTable ds = new DataTable();
                            SqlDataAdapter da = acc.executeDatatable(sql);
                            da.Fill(ds);
                            dgvTimKiem.DataSource = ds;
                            dgvTimKiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dgvTimKiem.Refresh();
                            break;
                        }
                }

            }

            catch (Exception)
            {
                MessageBox.Show("error");
            }
            //try {
            //    string sql = "SELECT *FROM SanPham WHERE MaSP='" + tbxMaSP.Text + "';";
            //    SqlDataAdapter dap = acc.executeDatatable(sql);
            //    DataSet ds = new DataSet();
            //    DataTable dtbTimKiem = new DataTable();
            //    dap.Fill(ds);
            //    dgvTimKiem.DataSource = ds.Tables[0];
            //    dgvTimKiem.Refresh();
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("error");
            //}


        }

        private void TimKiem_Load(object sender, EventArgs e)
        {
            string sql = "select *from SanPham ";
            DataTable ds = new DataTable();
            SqlDataAdapter da = acc.executeDatatable(sql);
            da.Fill(ds);
            dgvTimKiem.DataSource = ds;
            dgvTimKiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTimKiem.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
