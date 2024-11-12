using AddmissionCollege.DAO;
using AddmissionCollege.DTO;
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
    public partial class fCombinate : Form
    {
        public fCombinate()
        {
            InitializeComponent();

        }

        private void fCombinate_Load(object sender, EventArgs e)
        {
            LoadListCombinate();
        }
        void LoadListCombinate()
        {
            dataGridViewLoadCombinate.Rows.Clear();
            if (dataGridViewLoadCombinate.Columns.Count == 0)
            {
                dataGridViewLoadCombinate.Columns.Add("ID", "MÃ TỔ HỢP");
                dataGridViewLoadCombinate.Columns.Add("TEN_TH", "TÊN TỔ HỢP");

                dataGridViewLoadCombinate.ColumnHeadersDefaultCellStyle.BackColor = Color.Tomato;
                dataGridViewLoadCombinate.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                dataGridViewLoadCombinate.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 13, FontStyle.Bold);
            }

            List<Combinate> list = CombinateDAO.Instance.LoadListCombinate();
            HashSet<string> uniqueEntries = new HashSet<string>();

            foreach (Combinate combinate in list)
            {
                string entry = $"{combinate.ID}|{combinate.TEN_TH1}";

                if (uniqueEntries.Add(entry))
                {
                    dataGridViewLoadCombinate.Rows.Add(combinate.ID, combinate.TEN_TH1);
                }
            }

            //dataGridViewLoadMajor.Columns["ID"].Visible = false;
        }

        private void btnAddCombinate_Click(object sender, EventArgs e)
        {
            string id = txtIdCombinate.Text;
            string name = txtNameCombinate.Text;
            if (CombinateDAO.Instance.InsertCombinate(id, name))
            {
                MessageBox.Show("Thêm tổ hợp thành công");
                LoadListCombinate();
            }
            else
            {
                MessageBox.Show("Thêm lỗi, vui lòng kiểm tra lại!");
            }
        }

        private void btnDeleteCombinate_Click(object sender, EventArgs e)
        {
            string id = txtIdCombinate.Text;
            if (CombinateDAO.Instance.DeleteCombinate(id))
            {
                MessageBox.Show("Xóa tổ hợp thành công");
                LoadListCombinate();
            }
            else
            {
                MessageBox.Show("Xóa lỗi, vui lòng kiểm tra lại!");
            }
        }

        private void dataGridViewLoadCombinate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdCombinate.Text = dataGridViewLoadCombinate.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNameCombinate.Text = dataGridViewLoadCombinate.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnEditCombinate_Click(object sender, EventArgs e)
        {
            string id = txtIdCombinate.Text;
            string name = txtNameCombinate.Text;
            if (CombinateDAO.Instance.UpdateCombinate(id, name))
            {
                MessageBox.Show("Cập nhật tổ hợp thành công");
                LoadListCombinate();
            }
            else
            {
                MessageBox.Show("Xóa lỗi, vui lòng kiểm tra lại!");
            }
        }

        private void btnResetCombinate_Click(object sender, EventArgs e)
        {
            txtIdCombinate.Clear();
            txtNameCombinate.Clear();
        }

        private void txtSearchCombinate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string tukhoa = txtSearchCombinate.Text;

                string query = "SELECT * FROM TO_HOP_XT WHERE TEN_TH LIKE '%" + tukhoa + "%' OR ID LIKE '%" + tukhoa + "%'";

                DataTable data = DataProvider.Instance.ExcuteQuery(query);

                dataGridViewLoadCombinate.Rows.Clear();

                if (data.Rows.Count > 0)
                {
                    foreach (DataRow row in data.Rows)
                    {
                        dataGridViewLoadCombinate.Rows.Add(row["ID"], row["TEN_TH"]);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kết quả.");
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchCombinate_Click(object sender, EventArgs e)
        {
            string tukhoa = txtSearchCombinate.Text;

            string query = "SELECT * FROM TO_HOP_XT WHERE TEN_TH LIKE '%" + tukhoa + "%' OR ID LIKE '%" + tukhoa + "%'";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            dataGridViewLoadCombinate.Rows.Clear();

            if (data.Rows.Count > 0)
            {
                foreach (DataRow row in data.Rows)
                {
                    dataGridViewLoadCombinate.Rows.Add(row["ID"], row["TEN_TH"]);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả.");
            }
        }

        private void btnPrintCombinate_Click(object sender, EventArgs e)
        {
            fPrintCombinate fPrintRoom = new fPrintCombinate();
            Point pictureBoxLocation = panel1.PointToScreen(Point.Empty);
            fPrintRoom.StartPosition = FormStartPosition.Manual;
            fPrintRoom.Location = pictureBoxLocation;
            fPrintRoom.Show();
        }
    }
}
