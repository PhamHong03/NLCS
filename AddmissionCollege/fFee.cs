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
    public partial class fFee : Form
    {
        public fFee()
        {
            InitializeComponent();
            LoadFeeList();
            LoadListYear();
            LoadMajorList();
            loadCurriculum();
        }

        private void fFee_Load(object sender, EventArgs e)
        {

        }

        void LoadFeeList()
        {
            dataGridViewLoadFee.Rows.Clear();
            if (dataGridViewLoadFee.Columns.Count == 0)
            {
                //dataGridViewLoadFee.Columns.Add("ID", "ID");
                dataGridViewLoadFee.Columns.Add("Nganh", "NGÀNH");
                dataGridViewLoadFee.Columns.Add("CT", "CHƯƠNG TRÌNH");
                dataGridViewLoadFee.Columns.Add("nam", "THỜI GIAN");
                dataGridViewLoadFee.Columns.Add("hp", "HỌC PHÍ");

                dataGridViewLoadFee.Columns["hp"].DefaultCellStyle.Format = "C0";
                dataGridViewLoadFee.Columns["hp"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("vi-VN");


                dataGridViewLoadFee.ColumnHeadersDefaultCellStyle.BackColor = Color.Tomato;
                dataGridViewLoadFee.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                dataGridViewLoadFee.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 13, FontStyle.Bold);
            }

            List<Fee> list = FeeDAO.Instance.loadListFee();
            HashSet<string> uniqueEntries = new HashSet<string>();

            foreach (Fee fee in list)
            {
                string entry = $"{fee.Nganh1}|{fee.CT1}|{fee.Nam}|{fee.Hp}";

                if (uniqueEntries.Add(entry))
                {
                    dataGridViewLoadFee.Rows.Add(fee.Nganh1, fee.CT1, fee.Nam, fee.Hp);
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
                comboBoxLoadYear.DataSource = distinctYears;
                comboBoxLoadYear.DisplayMember = "NAM1";
                comboBoxLoadYear.ValueMember = "ID";
            }
            else
            {
                MessageBox.Show("Danh sách năm rỗng á!");
            }
        }


        void LoadMajorList()
        {
            List<Major> major = MajorDAO.Instance.loadMajorList();

            if (major != null && major.Count > 0)
            {
                HashSet<string> uniqueObjects = new HashSet<string>();
                List<Major> distinctList = new List<Major>();

                foreach (var obj in major)
                {

                    if (uniqueObjects.Add(obj.ID))
                    {
                        distinctList.Add(obj);
                    }
                }
                comboBoxLoadMajor.MaxDropDownItems = 15;
                comboBoxLoadMajor.IntegralHeight = false;
                comboBoxLoadMajor.DataSource = distinctList;
                comboBoxLoadMajor.DisplayMember = "TEN_NGANH1";
                comboBoxLoadMajor.ValueMember = "ID";
            }
            else
            {
                MessageBox.Show("Danh sách ngành rỗng á!");
            }
        }


        void loadCurriculum()
        {

            List<Curriculum> curriculum = CurriculumDAO.Instance.LoadCurriculumList();

            if (curriculum != null && curriculum.Count > 0)
            {
                comboBoxCT.DataSource = curriculum;
                comboBoxCT.DisplayMember = "Name";
                comboBoxCT.ValueMember = "ID";
            }
            else
            {
                MessageBox.Show("Danh sách rỗng á!");
            }
        }

        private void btnAddFee_Click(object sender, EventArgs e)
        {
            string id_n = comboBoxLoadMajor.SelectedValue.ToString();
            string id_ct = comboBoxCT.SelectedValue.ToString();
            string nam = comboBoxLoadYear.SelectedValue.ToString();
            float hp = float.Parse(txtFee.Text);
            if (FeeDAO.Instance.InsertFee(id_n, id_ct, nam, hp))
            {
                MessageBox.Show("Thêm học phí cho ngành thành công");
                LoadFeeList();
            }
            else
            {
                MessageBox.Show("Thêm lỗi, vui lòng kiểm tra lại!");
            }
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewLoadFee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxLoadMajor.Text = dataGridViewLoadFee.Rows[e.RowIndex].Cells[0].Value.ToString();
            comboBoxCT.Text = dataGridViewLoadFee.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBoxLoadYear.Text = dataGridViewLoadFee.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtFee.Text = dataGridViewLoadFee.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnDeleteFee_Click(object sender, EventArgs e)
        {
            string id_N = comboBoxLoadMajor.SelectedValue.ToString();
            if (FeeDAO.Instance.DeleteFee(id_N))
            {
                MessageBox.Show("Xóa học phí cho ngành thành công");
                LoadFeeList();
            }
            else
            {
                MessageBox.Show("Xóa lỗi, vui lòng kiểm tra lại!");
            }

        }

        private void btnResetFee_Click(object sender, EventArgs e)
        {
            txtFee.Clear();

        }

        private void btnEditFee_Click(object sender, EventArgs e)
        {
            string id_n = comboBoxLoadMajor.SelectedValue.ToString();
            string id_ct = comboBoxCT.SelectedValue.ToString();
            string nam = comboBoxLoadYear.SelectedValue.ToString();
            float hp = float.Parse(txtFee.Text);
            if (FeeDAO.Instance.EditFee(id_n, id_ct, nam, hp))
            {
                MessageBox.Show("Cập nhật học phí cho ngành thành công");
                LoadFeeList();
            }
            else
            {
                MessageBox.Show("Cập nhật lỗi, vui lòng kiểm tra lại!");
            }
        }



        private void btnSearchFee_Click(object sender, EventArgs e)
        {
            string tukhoa = txtSearchFee.Text;

            string query = "SELECT N.TEN_NGANH AS Nganh, CT.TEN_CT AS CT, HP.ID_NAM AS nam, HP.HOC_PHI_BINH_QUAN AS hp FROM HOC_PHI AS HP JOIN NGANH AS N ON HP.ID_N = N.ID JOIN CHUONG_TRINH AS CT ON HP.ID_CT = CT.ID WHERE N.TEN_NGANH LIKE '%" + tukhoa + "%' OR CT.TEN_CT LIKE '%" + tukhoa + "%'";


            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            dataGridViewLoadFee.Rows.Clear();

            if (data.Rows.Count > 0)
            {
                foreach (DataRow row in data.Rows)
                {
                    dataGridViewLoadFee.Rows.Add(row["Nganh"], row["CT"], row["nam"], row["hp"]);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả.");
            }
        }

        private void txtSearchFee_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchFee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string tukhoa = txtSearchFee.Text;

                string query = "SELECT N.TEN_NGANH AS Nganh, CT.TEN_CT AS CT, HP.ID_NAM AS nam, HP.HOC_PHI_BINH_QUAN AS hp FROM HOC_PHI AS HP JOIN NGANH AS N ON HP.ID_N = N.ID JOIN CHUONG_TRINH AS CT ON HP.ID_CT = CT.ID WHERE N.TEN_NGANH LIKE '%" + tukhoa + "%' OR CT.TEN_CT LIKE '%" + tukhoa + "%'";


                DataTable data = DataProvider.Instance.ExcuteQuery(query);

                dataGridViewLoadFee.Rows.Clear();

                if (data.Rows.Count > 0)
                {
                    foreach (DataRow row in data.Rows)
                    {
                        dataGridViewLoadFee.Rows.Add(row["Nganh"], row["CT"], row["nam"], row["hp"]);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kết quả.");
                }

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

