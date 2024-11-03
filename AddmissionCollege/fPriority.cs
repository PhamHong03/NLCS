using AddmissionCollege.DAO;
using AddmissionCollege.DTO;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddmissionCollege
{
    public partial class fPriority : Form
    {
        public fPriority()
        {
            InitializeComponent();
            LoadObjectPriority();
            LoadGradeObject();
            LoadObjectPriorityComboBox();
            LoadListYear();
        }


        //void LoadObjectPriority()
        //{
        //    dataGridViewObjectLoad.Rows.Clear();
        //    if (dataGridViewObjectLoad.Columns.Count == 0)
        //    {
        //        dataGridViewObjectLoad.Columns.Add("ID", "ID");
        //        dataGridViewObjectLoad.Columns.Add("Ten_DT", "TÊN ĐỐI TƯỢNG");
        //        dataGridViewObjectLoad.Columns.Add("CHINH_SACH", "CHÍNH SÁCH");

        //        dataGridViewObjectLoad.ColumnHeadersDefaultCellStyle.BackColor = Color.Tomato;
        //        dataGridViewObjectLoad.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        //        dataGridViewObjectLoad.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 13, FontStyle.Bold);
        //    }


        //    List<ObjectPriority> list = ObjectPriorityDAO.Instance.loadObjectPriority();


        //    foreach (ObjectPriority objectPriority in list)
        //    {
        //        dataGridViewObjectLoad.Rows.Add(objectPriority.Id, objectPriority.Ten_DT1, objectPriority.CHINH_SACH1);
        //        dataGridViewObjectLoad.Columns["Id"].Visible = false;
        //    }
        //}
        void LoadObjectPriority()
        {
            dataGridViewObjectLoad.Rows.Clear();
            if (dataGridViewObjectLoad.Columns.Count == 0)
            {
                dataGridViewObjectLoad.Columns.Add("ID", "ID");
                dataGridViewObjectLoad.Columns.Add("Ten_DT", "TÊN ĐỐI TƯỢNG");
                dataGridViewObjectLoad.Columns.Add("CHINH_SACH", "CHÍNH SÁCH");

                dataGridViewObjectLoad.ColumnHeadersDefaultCellStyle.BackColor = Color.Tomato;
                dataGridViewObjectLoad.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                dataGridViewObjectLoad.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 13, FontStyle.Bold);
            }

            List<ObjectPriority> list = ObjectPriorityDAO.Instance.loadObjectPriority();
            HashSet<string> uniqueEntries = new HashSet<string>(); // Giúp theo dõi các bản ghi đã thêm

            foreach (ObjectPriority objectPriority in list)
            {
                // Tạo một chuỗi duy nhất để kiểm tra lặp lại
                string entry = $"{objectPriority.Ten_DT1}|{objectPriority.CHINH_SACH1}";

                if (uniqueEntries.Add(entry)) // Nếu thêm thành công, nghĩa là chưa tồn tại
                {
                    dataGridViewObjectLoad.Rows.Add(objectPriority.Id, objectPriority.Ten_DT1, objectPriority.CHINH_SACH1);
                }
            }

            dataGridViewObjectLoad.Columns["ID"].Visible = false;
        }
        //void LoadObjectPriorityComboBox()
        //{
        //    List<ObjectPriority> priorityList = ObjectPriorityDAO.Instance.loadObjectPriority();

        //    if (priorityList != null && priorityList.Count > 0)
        //    {
        //        comboBoxPriorityObject.DataSource = priorityList;
        //        comboBoxPriorityObject.DisplayMember = "Ten_DT1";
        //        comboBoxPriorityObject.ValueMember = "Id";
        //    }
        //    else
        //    {
        //        MessageBox.Show("Danh sách đối tượng rỗng á!");
        //    }
        //}
        void LoadObjectPriorityComboBox()
        {
            List<ObjectPriority> priorityList = ObjectPriorityDAO.Instance.loadObjectPriority();

            if (priorityList != null && priorityList.Count > 0)
            {
                // Sử dụng HashSet để loại bỏ bản sao
                HashSet<string> uniqueObjects = new HashSet<string>();
                List<ObjectPriority> distinctList = new List<ObjectPriority>();

                foreach (var obj in priorityList)
                {
                    // Chỉ thêm nếu không có trong HashSet
                    if (uniqueObjects.Add(obj.Ten_DT1))
                    {
                        distinctList.Add(obj);
                    }
                }

                comboBoxPriorityObject.DataSource = distinctList;
                comboBoxPriorityObject.DisplayMember = "Ten_DT1";
                comboBoxPriorityObject.ValueMember = "Id";
            }
            else
            {
                MessageBox.Show("Danh sách đối tượng rỗng á!");
            }
        }

        //void LoadListYear()
        //{
        //    List<Year> listYear = YearDAO.Instance.LoadYear();
        //    if (listYear != null && listYear.Count > 0)
        //    {
        //        comboBoxYearObject.DataSource = listYear;
        //        comboBoxYearObject.DisplayMember = "NAM1";
        //        comboBoxYearObject.ValueMember = "ID";
        //    }
        //    else
        //    {
        //        MessageBox.Show("Danh sách năm rỗng á!");
        //    }

        //}
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
                comboBoxYearObject.DataSource = distinctYears;
                comboBoxYearObject.DisplayMember = "NAM1";
                comboBoxYearObject.ValueMember = "ID";
            }
            else
            {
                MessageBox.Show("Danh sách năm rỗng á!");
            }
        }

        private void btnAddObject_Click(object sender, EventArgs e)
        {
            string ten = txtNameObject.Text;
            string policy = txtPolicyPriorityObject.Text;

            if (ObjectPriorityDAO.Instance.InsertObject(ten, policy))
            {
                MessageBox.Show("Thêm đối tượng thành công");
                LoadObjectPriority();
            }
            else
            {
                MessageBox.Show("Thêm lỗi, vui lòng kiểm tra lại");
            }

        }
        private void dataGridViewObjectLoad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDObject.Text = dataGridViewObjectLoad.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNameObject.Text = dataGridViewObjectLoad.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPolicyPriorityObject.Text = dataGridViewObjectLoad.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
        private void btnResetObject_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        public void ClearAll()
        {
            txtIDObject.Clear();
            txtNameObject.Clear();
            txtPolicyPriorityObject.Clear();
        }

        private void btnDeleteObject_Click(object sender, EventArgs e)
        {
            string id = txtIDObject.Text;

            if (ObjectPriorityDAO.Instance.DeleteObject(id))
            {
                MessageBox.Show("Xóa đối tượng thành công");
                LoadObjectPriority();
            }
            else
            {
                MessageBox.Show("Xóa lỗi, vui lòng kiểm tra lại");
            }
        }

        private void btnEditObject_Click(object sender, EventArgs e)
        {
            string id = txtIDObject.Text;
            string name = txtNameObject.Text;
            string policy = txtPolicyPriorityObject.Text;

            if (ObjectPriorityDAO.Instance.UpdateObject(id, name, policy))
            {
                MessageBox.Show("Sửa đối tượng thành công");
                LoadObjectPriority();
            }
            else
            {
                MessageBox.Show("Sửa lỗi, vui lòng kiểm tra lại");
            }
        }

        private void comboBoxPriorityObject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchObjectPriority_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string tukhoa = txtSearchObjectPriority.Text;

                // Câu truy vấn SQL để tìm kiếm
                string query = "SELECT * FROM DOI_TUONG WHERE TEN_DT LIKE N'%" + tukhoa + "%'";

                // Thực thi truy vấn và lấy kết quả trả về dưới dạng DataTable
                DataTable data = DataProvider.Instance.ExcuteQuery(query);

                // Xóa dữ liệu cũ trong DataGridView
                dataGridViewObjectLoad.Rows.Clear();

                // Kiểm tra nếu có dữ liệu trả về
                if (data.Rows.Count > 0)
                {
                    // Thêm dữ liệu mới vào DataGridView
                    foreach (DataRow row in data.Rows)
                    {
                        dataGridViewObjectLoad.Rows.Add(row["Id"], row["TEN_DT"], row["CHINH_SACH"]);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kết quả.");
                }
            }
        }
        private void btnLoadData_Click(object sender, EventArgs e)
        {
            //LoadObjectPriority();
        }
        void LoadGradeObject()
        {
            dataGridViewGradePriorityObject.Rows.Clear(); // Xóa tất cả các hàng trước khi thêm mới
                                                          // Kiểm tra và tạo các cột chỉ một lần
            if (dataGridViewGradePriorityObject.Columns.Count == 0)
            {
                dataGridViewGradePriorityObject.Columns.Add("ID", "ID");
                dataGridViewGradePriorityObject.Columns.Add("DIEM", "ĐIỂM");
                dataGridViewGradePriorityObject.Columns.Add("Name_object", "ĐỐI TƯỢNG");
                dataGridViewGradePriorityObject.Columns.Add("Nam", "NĂM");

                // Thiết lập các thuộc tính cho tiêu đề cột
                dataGridViewGradePriorityObject.ColumnHeadersDefaultCellStyle.BackColor = Color.Tomato;
                dataGridViewGradePriorityObject.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridViewGradePriorityObject.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 13, FontStyle.Bold);
            }

            // Lấy danh sách các GradeObject
            List<GradeObject> list = GradeObjectDAO.Instance.loadGradeObject();

            // Thêm dữ liệu vào dataGridView
            foreach (GradeObject grade in list)
            {
                dataGridViewGradePriorityObject.Rows.Add(grade.ID, grade.Diem, grade.Name_object, grade.Nam);
            }

            // Ẩn cột ID sau khi thêm xong
            dataGridViewGradePriorityObject.Columns["ID"].Visible = false;
        }


        private void btnAddgradeObject_Click(object sender, EventArgs e)
        {
            float diem = float.Parse(txtGradeObject.Text);
            int id_object = int.Parse(comboBoxPriorityObject.SelectedValue.ToString());
            int nam = int.Parse(comboBoxYearObject.SelectedValue.ToString());

            if (GradeObjectDAO.Instance.InsertGradeObject(diem, id_object, nam))
            {
                MessageBox.Show("Thêm điểm đối tượng thành công");
                LoadGradeObject();
            }
            else
            {
                MessageBox.Show("Thêm lỗi, vui lòng kiểm tra lại");
            }
        }

        private void btnResetGradeObject_Click(object sender, EventArgs e)
        {
            txtIdGradeObject.Clear();
            txtGradeObject.Clear();
        }

        private void dataGridViewGradePriorityObject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdGradeObject.Text = dataGridViewGradePriorityObject.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtGradeObject.Text = dataGridViewGradePriorityObject.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBoxPriorityObject.Text = dataGridViewGradePriorityObject.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBoxYearObject.Text = dataGridViewGradePriorityObject.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnDeleteGradeObject_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdGradeObject.Text);

            if (GradeObjectDAO.Instance.DeleteGradeObject(id))
            {
                MessageBox.Show("Xóa điểm đối tượng thành công");
                LoadGradeObject();
            }
            else
            {
                MessageBox.Show("Xóa lỗi, vui lòng kiểm tra lại");
            }
        }

        private void btnEditgradeObject_Click(object sender, EventArgs e)
        {
            string id = txtIdGradeObject.Text;
            float grade = float.Parse(txtGradeObject.Text);
            int id_object = int.Parse(comboBoxPriorityObject.SelectedValue.ToString());
            int nam = int.Parse(comboBoxYearObject.SelectedValue.ToString());

            if (GradeObjectDAO.Instance.UpdateGradeObject(id, grade, id_object, nam))
            {
                MessageBox.Show("Sửa điểm đối tượng thành công");
                LoadGradeObject();
            }
            else
            {
                MessageBox.Show("Sửa lỗi, vui lòng kiểm tra lại");
            }
        }

        private void txtSearchGradeObject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string tukhoa = txtSearchGradeObject.Text;

                // Câu truy vấn SQL để tìm kiếm
                string query = "SELECT * FROM DIEM_DOI_TUONG WHERE DIEM LIKE '%" + tukhoa + "%'";

                // Thực thi truy vấn và lấy kết quả trả về dưới dạng DataTable
                DataTable data = DataProvider.Instance.ExcuteQuery(query);

                // Xóa dữ liệu cũ trong DataGridView
                dataGridViewGradePriorityObject.Rows.Clear();

                // Kiểm tra nếu có dữ liệu trả về
                if (data.Rows.Count > 0)
                {
                    // Thêm dữ liệu mới vào DataGridView
                    foreach (DataRow row in data.Rows)
                    {
                        dataGridViewGradePriorityObject.Rows.Add(row["Id"], row["DIEM"], row["ID_DT"], row["ID_NAM"]);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kết quả.");
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
