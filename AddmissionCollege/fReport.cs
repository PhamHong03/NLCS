using AddmissionCollege.DAO;
using AddmissionCollege.DTO;
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

namespace AddmissionCollege
{
    public partial class fReport : Form
    {
        private SqlConnection conn;
        public fReport()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=LAPTOP-9S1O4HRM\\SQLEXPRESS;Initial Catalog=QuanLyTuyenSinhDaiHoc;Integrated Security=True;Trust Server Certificate=True");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void fReport_Load(object sender, EventArgs e)
        {
            try
            {
                // Lấy thống kê từ DAO
                StatisticsDAO statsDAO = new StatisticsDAO();
                Statistics stats = statsDAO.GetStatistics();

                // Hiển thị kết quả lên các Label
                labelCTDT.Text = stats.TongCTDT1.ToString();
                labelMajor.Text = stats.TongNganh1.ToString();
                labelMethod.Text = stats.TongPT1.ToString();
                labelCombinate.Text = stats.TongTH1.ToString();
                labelObject.Text = stats.TongDT1.ToString();
                labelArea.Text = stats.TongKV1.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
