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
    public partial class fAreaPriority : Form
    {
        public fAreaPriority()
        {
            InitializeComponent();
            LoadAreaList();
            LoadAreaCombobox();
            LoadListYear();
            LoadAreaGradeList();
        }

        void LoadAreaList()
        {
            dataGridViewLoadArea.Rows.Clear();
            // Kiểm tra và tạo các cột chỉ một lần
            if (dataGridViewLoadArea.Columns.Count == 0)
            {
                dataGridViewLoadArea.Columns.Add("ID", "ID");
                dataGridViewLoadArea.Columns.Add("TEN_KV", "TÊN KHU VỰC");
                dataGridViewLoadArea.Columns.Add("MO_TA", "MÔ TẢ");

                // Thiết lập các thuộc tính cho tiêu đề cột
                dataGridViewLoadArea.ColumnHeadersDefaultCellStyle.BackColor = Color.Tomato;
                dataGridViewLoadArea.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridViewLoadArea.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 13, FontStyle.Bold);
            }

            // Lấy danh sách các GradeObject
            List<Area> list = AreaDAO.Instance.LoadAreaList();

            // Thêm dữ liệu vào dataGridView
            foreach (Area area in list)
            {
                dataGridViewLoadArea.Rows.Add(area.ID, area.TEN_KV1, area.MO_TA1);
            }

            // Ẩn cột ID sau khi thêm xong
            dataGridViewLoadArea.Columns["ID"].Visible = false;
        }

        private void dataGridViewLoadArea_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdArea.Text = dataGridViewLoadArea.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNameArea.Text = dataGridViewLoadArea.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDescArea.Text = dataGridViewLoadArea.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnResetArea_Click(object sender, EventArgs e)
        {
            txtIdArea.Clear();
            txtNameArea.Clear();
            txtDescArea.Clear();
        }

        private void btnAddArea_Click(object sender, EventArgs e)
        {
            string name = txtNameArea.Text;
            string desc = txtDescArea.Text;
            if (AreaDAO.Instance.InsertArea(name, desc))
            {
                MessageBox.Show("Thêm khu vực thành công");
                LoadAreaList();
            }
            else
            {
                MessageBox.Show("Thêm lỗi, vui lòng kiểm tra lại!");
            }
        }

        private void btnDeleteArea_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdArea.Text);
            if (AreaDAO.Instance.DeleteArea(id))
            {
                MessageBox.Show("Xóa khu vực thành công");
                LoadAreaList();
            }
            else
            {
                MessageBox.Show("Xóa lỗi, vui lòng kiểm tra lại!");
            }
        }

        private void btnEditArea_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdArea.Text);
            string name = txtNameArea.Text;
            string desc = txtDescArea.Text;
            if (AreaDAO.Instance.UpdateArea(id, name, desc))
            {
                MessageBox.Show("Cập nhật khu vực thành công");
                LoadAreaList();
            }
            else
            {
                MessageBox.Show("Cập nhật lỗi, vui lòng kiểm tra lại!");
            }
        }

        private void txtSearchArea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string tukhoa = txtSearchArea.Text;

                // Câu truy vấn SQL để tìm kiếm
                string query = "SELECT * FROM KHU_VUC WHERE TEN_KV LIKE '%" + tukhoa + "%' OR MO_TA LIKE '%" + tukhoa + "%'";

                // Thực thi truy vấn và lấy kết quả trả về dưới dạng DataTable
                DataTable data = DataProvider.Instance.ExcuteQuery(query);

                // Xóa dữ liệu cũ trong DataGridView
                dataGridViewLoadArea.Rows.Clear();

                // Kiểm tra nếu có dữ liệu trả về
                if (data.Rows.Count > 0)
                {
                    // Thêm dữ liệu mới vào DataGridView
                    foreach (DataRow row in data.Rows)
                    {
                        dataGridViewLoadArea.Rows.Add(row["Id"], row["TEN_KV"], row["MO_TA"]);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kết quả.");
                }
            }
        }

        void LoadListYear()
        {
            List<Year> listYear = YearDAO.Instance.LoadYear();

            if (listYear != null && listYear.Count > 0)
            {
                // Sử dụng HashSet để loại bỏ bản sao
                HashSet<string> uniqueYears = new HashSet<string>();
                List<Year> distinctYears = new List<Year>();

                foreach (var year in listYear)
                {
                    // Chỉ thêm nếu không có trong HashSet
                    if (uniqueYears.Add(year.NAM1))
                    {
                        distinctYears.Add(year);
                    }
                }
                comBoBoxYearArea.DataSource = distinctYears;
                comBoBoxYearArea.DisplayMember = "NAM1";
                comBoBoxYearArea.ValueMember = "ID";
            }
            else
            {
                MessageBox.Show("Danh sách năm rỗng á!");
            }
        }

        void LoadAreaCombobox()
        {
            List<Area> area = AreaDAO.Instance.LoadAreaList();

            if (area != null && area.Count > 0)
            {
                // Sử dụng HashSet để loại bỏ bản sao
                HashSet<string> uniqueObjects = new HashSet<string>();
                List<Area> distinctList = new List<Area>();

                foreach (var obj in area)
                {
                    // Chỉ thêm nếu không có trong HashSet
                    if (uniqueObjects.Add(obj.TEN_KV1))
                    {
                        distinctList.Add(obj);
                    }
                }

                comBoboxAreaPriority.DataSource = distinctList;
                comBoboxAreaPriority.DisplayMember = "Ten_KV1";
                comBoboxAreaPriority.ValueMember = "Id";
            }
            else
            {
                MessageBox.Show("Danh sách đối tượng rỗng á!");
            }
        }

        private void dataGridViewLoadGradeArea_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdGradeArea.Text = dataGridViewLoadGradeArea.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtGradeArea.Text = dataGridViewLoadGradeArea.Rows[e.RowIndex].Cells[1].Value.ToString();
            comBoboxAreaPriority.Text = dataGridViewLoadGradeArea.Rows[e.RowIndex].Cells[2].Value.ToString();
            comBoBoxYearArea.Text = dataGridViewLoadGradeArea.Rows[e.RowIndex].Cells[3].Value.ToString();
        }


        void LoadAreaGradeList()
        {
            dataGridViewLoadGradeArea.Rows.Clear();
            // Kiểm tra và tạo các cột chỉ một lần
            if (dataGridViewLoadGradeArea.Columns.Count == 0)
            {
                dataGridViewLoadGradeArea.Columns.Add("ID", "ID");
                dataGridViewLoadGradeArea.Columns.Add("DIEM", "ĐIỂM");
                dataGridViewLoadGradeArea.Columns.Add("Name_area", "TÊN KHU VỰC");
                dataGridViewLoadGradeArea.Columns.Add("Nam", "NĂM");

                // Thiết lập các thuộc tính cho tiêu đề cột
                dataGridViewLoadGradeArea.ColumnHeadersDefaultCellStyle.BackColor = Color.Tomato;
                dataGridViewLoadGradeArea.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridViewLoadGradeArea.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 13, FontStyle.Bold);
            }

            // Lấy danh sách các GradeObject
            List<AreaGrade> list = AreaGradeDAO.Instance.LoadAreaGradeList();

            // Thêm dữ liệu vào dataGridView
            foreach (AreaGrade area in list)
            {
                dataGridViewLoadGradeArea.Rows.Add(area.ID, area.Diem, area.Name_area, area.Nam);
            }

            // Ẩn cột ID sau khi thêm xong
            dataGridViewLoadGradeArea.Columns["ID"].Visible = false;
        }

        private void btnAddGradeArea_Click(object sender, EventArgs e)
        {
            float diem = float.Parse(txtGradeArea.Text);
            int id_area = int.Parse(comBoboxAreaPriority.SelectedValue.ToString());
            int nam = int.Parse(comBoBoxYearArea.SelectedValue.ToString());

            if (AreaGradeDAO.Instance.InsertGradeArea(diem, id_area, nam))
            {
                MessageBox.Show("Thêm điểm khu vực thành công");
                LoadAreaGradeList();
            }
            else
            {
                MessageBox.Show("Thêm lỗi, vui lòng kiểm tra lại");
            }
        }

        private void btnResetGradeArea_Click(object sender, EventArgs e)
        {
            txtIdGradeArea.Clear();
            txtGradeArea.Clear();
            txtSearchGradeArea.Clear();
        }

        private void btnDeleteGradeArea_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdGradeArea.Text);

            if (AreaGradeDAO.Instance.DeleteGradeArea(id))
            {
                MessageBox.Show("Xóa điểm khu vực thành công");
                LoadAreaGradeList();
            }
            else
            {
                MessageBox.Show("Xóa lỗi, vui lòng kiểm tra lại");
            }
        }

        private void btnEditGradeArea_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdGradeArea.Text);
            float grade = float.Parse(txtGradeArea.Text);
            int id_object = int.Parse(comBoboxAreaPriority.SelectedValue.ToString());
            int nam = int.Parse(comBoBoxYearArea.SelectedValue.ToString());

            if (AreaGradeDAO.Instance.UpdateGradeArea(id, grade, id_object, nam))
            {
                MessageBox.Show("Sửa điểm khu vực thành công");
                LoadAreaGradeList();
            }
            else
            {
                MessageBox.Show("Sửa lỗi, vui lòng kiểm tra lại");
            }
        }

        private void txtSearchGradeArea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string tukhoa = txtSearchGradeArea.Text;

                // Câu truy vấn SQL để tìm kiếm
                string query = "SELECT * FROM DIEM_KHU_VUC WHERE DIEM LIKE '%" + tukhoa + "%'";

                // Thực thi truy vấn và lấy kết quả trả về dưới dạng DataTable
                DataTable data = DataProvider.Instance.ExcuteQuery(query);

                // Xóa dữ liệu cũ trong DataGridView
                dataGridViewLoadGradeArea.Rows.Clear();

                // Kiểm tra nếu có dữ liệu trả về
                if (data.Rows.Count > 0)
                {
                    // Thêm dữ liệu mới vào DataGridView
                    foreach (DataRow row in data.Rows)
                    {
                        dataGridViewLoadGradeArea.Rows.Add(row["Id"], row["DIEM"], row["ID_KV"], row["ID_NAM"]);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kết quả.");
                }
            }
        }
    }
}
