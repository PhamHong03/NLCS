using AddmissionCollege.DAO;
using AddmissionCollege.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddmissionCollege
{
    public partial class ThongKeHocPhi : Form
    {
        public ThongKeHocPhi()
        {
            InitializeComponent();
            LoadListYear();
        }

        private void ThongKeHocPhi_Load(object sender, EventArgs e)
        {

        }


        void LoadListYear()
        {
            List<Year> listYear = YearDAO.Instance.LoadYear();

            if (listYear != null && listYear.Count > 0)
            {
                HashSet<string> uniqueYears = new HashSet<string>();
                List<Year> distinctYears = new List<Year>();

                foreach (var year in listYear)
                {
                    if (uniqueYears.Add(year.NAM1))
                    {
                        distinctYears.Add(year);
                    }
                }
                comboBox1.DataSource = distinctYears;
                comboBox1.DisplayMember = "NAM1";
                comboBox1.ValueMember = "ID";
            }
            else
            {
                MessageBox.Show("Danh sách năm rỗng á!");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
                string selectedYearId = comboBox1.SelectedValue.ToString();

                if (!string.IsNullOrWhiteSpace(selectedYearId))
                {
                    decimal totalFee = FeeDAO.Instance.GetTotalFeeByYear(selectedYearId);
                    label4.Text = totalFee.ToString("N0") + " đ"; // Hiển thị định dạng tiền tệ
                }
                else
                {
                    label4.Text = "0 đ";
                }
            }
            else
            {
                label4.Text = "0 đ";
            }
        }
    }
}
