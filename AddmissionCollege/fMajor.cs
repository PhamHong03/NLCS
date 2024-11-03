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
    public partial class fMajor : Form
    {
        public fMajor()
        {
            InitializeComponent();
            loadCurriculum();
            LoadMajorList();
            //LoadListYear();
        }

        private void fMajor_Load(object sender, EventArgs e)
        {


        }

        void LoadMajorList()
        {
            dataGridViewLoadMajor.Rows.Clear();
            if (dataGridViewLoadMajor.Columns.Count == 0)
            {
                dataGridViewLoadMajor.Columns.Add("ID", "MÃ NGÀNH");
                dataGridViewLoadMajor.Columns.Add("TEN_NGANH", "TÊN NGÀNH");
                dataGridViewLoadMajor.Columns.Add("THOI_GIAN_DAO_TAO", "THỜI GIAN");
                dataGridViewLoadMajor.Columns.Add("Type", "CHƯƠNG TRÌNH");

                dataGridViewLoadMajor.ColumnHeadersDefaultCellStyle.BackColor = Color.Tomato;
                dataGridViewLoadMajor.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                dataGridViewLoadMajor.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 13, FontStyle.Bold);
            }

            List<Major> list = MajorDAO.Instance.loadMajorList();
            HashSet<string> uniqueEntries = new HashSet<string>(); // Giúp theo dõi các bản ghi đã thêm

            foreach (Major major in list)
            {
                // Tạo một chuỗi duy nhất để kiểm tra lặp lại
                string entry = $"{major.ID}|{major.TEN_NGANH1}|{major.THOI_GIAN_DAO_TAO1}|{major.Type}";

                if (uniqueEntries.Add(entry)) // Nếu thêm thành công, nghĩa là chưa tồn tại
                {
                    dataGridViewLoadMajor.Rows.Add(major.ID, major.TEN_NGANH1, major.THOI_GIAN_DAO_TAO1, major.Type);
                }
            }

            //dataGridViewLoadMajor.Columns["ID"].Visible = false;

        }
        void loadCurriculum()
        {

            List<Curriculum> curriculum = CurriculumDAO.Instance.LoadCurriculumList();

            if (curriculum != null && curriculum.Count > 0)
            {
                comboBoxCurriculum.DataSource = curriculum;
                comboBoxCurriculum.DisplayMember = "Name";
                comboBoxCurriculum.ValueMember = "ID";
            }
            else
            {
                MessageBox.Show("Danh sách rỗng á!");
            }
        }

        //void LoadListYear()
        //{
        //    List<Year> listYear = YearDAO.Instance.LoadYear();

        //    if (listYear != null && listYear.Count > 0)
        //    {
        //        // Sử dụng HashSet để loại bỏ bản sao
        //        HashSet<string> uniqueYears = new HashSet<string>();
        //        List<Year> distinctYears = new List<Year>();

        //        foreach (var year in listYear)
        //        {
        //            // Chỉ thêm nếu không có trong HashSet
        //            if (uniqueYears.Add(year.NAM1))
        //            {
        //                distinctYears.Add(year);
        //            }
        //        }
        //        comboBoxLoadYear.DataSource = distinctYears;
        //        comboBoxLoadYear.DisplayMember = "NAM1";
        //        comboBoxLoadYear.ValueMember = "ID";
        //    }
        //    else
        //    {
        //        MessageBox.Show("Danh sách năm rỗng á!");
        //    }
        //}

        private void btnAddMajor_Click(object sender, EventArgs e)
        {
            string id = txtIdMajor.Text;
            string name = txtNameMajor.Text;
            string timeTrain = txtTrainTimeMajor.Text;
            int chuong_trinh = int.Parse(comboBoxCurriculum.SelectedValue.ToString());
            if (MajorDAO.Instance.InsertMajor(id, name, timeTrain, chuong_trinh))
            {
                MessageBox.Show("Thêm ngành thành công!");
                LoadMajorList();
            }
            else
            {
                MessageBox.Show("Thêm lỗi, vui lòng kiểm tra lại!");
            }
        }

        private void dataGridViewLoadMajor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdMajor.Text = dataGridViewLoadMajor.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNameMajor.Text = dataGridViewLoadMajor.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTrainTimeMajor.Text = dataGridViewLoadMajor.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBoxCurriculum.Text = dataGridViewLoadMajor.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnDeleteMajor_Click(object sender, EventArgs e)
        {
            string id = txtIdMajor.Text;
            if (MajorDAO.Instance.DeleteMajor(id))
            {
                MessageBox.Show("Xóa ngành thành công!");
                LoadMajorList();
            }
            else
            {
                MessageBox.Show("Xóa lỗi, vui lòng kiểm tra lại!");
            }
        }

        private void btnResetMajor_Click(object sender, EventArgs e)
        {
            txtIdMajor.Clear();
            txtNameMajor.Clear();
            txtTrainTimeMajor.Clear();

        }

        private void btnEditMajor_Click(object sender, EventArgs e)
        {
            string id = txtIdMajor.Text;
            string name = txtNameMajor.Text;
            string timeTrain = txtTrainTimeMajor.Text;
            int chuong_trinh = int.Parse(comboBoxCurriculum.SelectedValue.ToString());

            if (MajorDAO.Instance.UpdateMajor(id, name, timeTrain, chuong_trinh))
            {
                MessageBox.Show("Cập nhật ngành thành công!");
                LoadMajorList();
            }
            else
            {
                MessageBox.Show("Cập nhật lỗi, vui lòng kiểm tra lại!");
            }
        }

        private void txtSearchMajor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string tukhoa = txtSearchMajor.Text;
                //string query = "SELECT * FROM NGANH WHERE TEN_NGANH LIKE N'%"+tukhoa+ "%' ";
                string query = "SELECT n.ID, n.TEN_NGANH, n.THOI_GIAN_DAO_TAO, ct.TEN_CT " +
                       "FROM NGANH n " +
                       "JOIN CHUONG_TRINH ct ON n.ID_CT = ct.ID " +
                       "WHERE n.ID LIKE N'%" + tukhoa + "%'";
                DataTable data = DataProvider.Instance.ExcuteQuery(query);
                dataGridViewLoadMajor.Rows.Clear();
                if (data.Rows.Count > 0)
                {
                    foreach (DataRow row in data.Rows)
                    {
                        dataGridViewLoadMajor.Rows.Add(row["ID"], row["TEN_NGANH"], row["THOI_GIAN_DAO_TAO"], row["TEN_CT"]);
                        //LoadMajorList();
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
