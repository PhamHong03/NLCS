using AddmissionCollege.DAO;
using AddmissionCollege.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddmissionCollege
{
    public partial class fMethod : Form
    {
        public fMethod()
        {
            InitializeComponent();
            LoadListMethod();
        }


        void LoadListMethod()
        {
            dataGridViewLoadMethod.Rows.Clear();
            if (dataGridViewLoadMethod.Columns.Count == 0)
            {
                dataGridViewLoadMethod.Columns.Add("ID", "ID");
                dataGridViewLoadMethod.Columns.Add("TEN_PT", "TÊN PHƯƠNG THỨC");
                dataGridViewLoadMethod.Columns.Add("MO_TA", "MÔ TẢ");

                dataGridViewLoadMethod.ColumnHeadersDefaultCellStyle.BackColor = Color.Tomato;
                dataGridViewLoadMethod.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                dataGridViewLoadMethod.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 13, FontStyle.Bold);
            }

            List<MethodXT> list = MethodDAO.Instance.LoadMethodList();
            HashSet<string> uniqueEntries = new HashSet<string>(); // Giúp theo dõi các bản ghi đã thêm

            foreach (MethodXT method in list)
            {
                // Tạo một chuỗi duy nhất để kiểm tra lặp lại
                string entry = $"{method.TEN_PT1}";

                if (uniqueEntries.Add(entry)) // Nếu thêm thành công, nghĩa là chưa tồn tại
                {
                    dataGridViewLoadMethod.Rows.Add(method.ID, method.TEN_PT1, method.MO_TA1);
                }
            }
            dataGridViewLoadMethod.Columns["ID"].Visible = false;
        }

        private void btnAddMethod_Click(object sender, EventArgs e)
        {
            string name = txtNameMethod.Text;
            string desc = txtDescMethod.Text;
            if (MethodDAO.Instance.InsertMethod(name, desc))
            {
                MessageBox.Show("Thêm phương thức thành công");
                LoadListMethod();
            }
            else
            {
                MessageBox.Show("Thêm lỗi, Vui lòng kiểm tra lại!");
            }
        }

        private void btnResetMethod_Click(object sender, EventArgs e)
        {
            txtIdMethod.Clear();
            txtNameMethod.Clear();
            txtDescMethod.Clear();
            txtSearchMethod.Clear();
        }

        private void btnDeleteMethod_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdMethod.Text);
            if (MethodDAO.Instance.DeleteMethod(id))
            {
                MessageBox.Show("Xóa phương thức thành công");
                LoadListMethod();
            }
            else
            {
                MessageBox.Show("Xóa lỗi, Vui lòng kiểm tra lại!");
            }
        }

        private void dataGridViewLoadMethod_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdMethod.Text = dataGridViewLoadMethod.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNameMethod.Text = dataGridViewLoadMethod.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDescMethod.Text = dataGridViewLoadMethod.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnEditMethod_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdMethod.Text);
            string name = txtNameMethod.Text;
            string desc = txtDescMethod.Text;

            if (MethodDAO.Instance.UpdateMethod(id, name, desc))
            {
                MessageBox.Show("Sửa phương thức thành công");
                LoadListMethod();
            }
            else
            {
                MessageBox.Show("Sửa lỗi, vui lòng kiểm tra lại");
            }
        }

        private void txtSearchMethod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string tukhoa = txtSearchMethod.Text;
                string query = "SELECT * FROM PHUONG_THUC_XT WHERE TEN_PT LIKE '%" + tukhoa + "%' OR MO_TA LIKE '%" + tukhoa + "%'";
                DataTable data = DataProvider.Instance.ExcuteQuery(query);
                dataGridViewLoadMethod.Rows.Clear();
                if (data.Rows.Count > 0)
                {
                    foreach (DataRow row in data.Rows)
                    {
                        dataGridViewLoadMethod.Rows.Add(row["ID"], row["TEN_PT"], row["MO_TA"]);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kết quả.");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
