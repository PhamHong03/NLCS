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

        private void fReport_Load(object sender, EventArgs e)
        {
            try
            {
                // Lấy thống kê từ DAO
                StatisticsDAO statsDAO = new StatisticsDAO();
                Statistics stats = statsDAO.GetStatistics();

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

        private void labelCTDT_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void labelPrintMajor_Click(object sender, EventArgs e)
        {
            fPrintMajor fPrintRoom = new fPrintMajor();
            Point pictureBoxLocation = panel7.PointToScreen(Point.Empty);
            fPrintRoom.StartPosition = FormStartPosition.Manual;
            fPrintRoom.Location = pictureBoxLocation;
            fPrintRoom.Show();
        }

        private void labelPrintCombinate_Click(object sender, EventArgs e)
        {
            fPrintCombinate fPrintRoom = new fPrintCombinate();
            Point pictureBoxLocation = panel7.PointToScreen(Point.Empty);
            fPrintRoom.StartPosition = FormStartPosition.Manual;
            fPrintRoom.Location = pictureBoxLocation;
            fPrintRoom.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            fPrintMethod fPrintRoom = new fPrintMethod();
            Point pictureBoxLocation = panel7.PointToScreen(Point.Empty);
            fPrintRoom.StartPosition = FormStartPosition.Manual;
            fPrintRoom.Location = pictureBoxLocation;
            fPrintRoom.Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            fPrintArea fPrintRoom = new fPrintArea();
            Point pictureBoxLocation = panel7.PointToScreen(Point.Empty);
            fPrintRoom.StartPosition = FormStartPosition.Manual;
            fPrintRoom.Location = pictureBoxLocation;
            fPrintRoom.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            fPrintObject fPrintRoom = new fPrintObject();
            Point pictureBoxLocation = panel7.PointToScreen(Point.Empty);
            fPrintRoom.StartPosition = FormStartPosition.Manual;
            fPrintRoom.Location = pictureBoxLocation;
            fPrintRoom.Show();
        }

        private void btnFee_Click(object sender, EventArgs e)
        {
            ThongKeHocPhi fPrintRoom = new ThongKeHocPhi();
            Point pictureBoxLocation = panel7.PointToScreen(Point.Empty);
            fPrintRoom.StartPosition = FormStartPosition.Manual;
            fPrintRoom.Location = pictureBoxLocation;
            fPrintRoom.Show();
        }
    }
}
