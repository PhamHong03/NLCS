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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace AddmissionCollege
{
    public partial class fAddmission : Form
    {
        public fAddmission()
        {
            InitializeComponent();
            LoadListYear();
            LoadMajorList();
            listMethod();
            //loadCurriculum();
            loadListAdmision();
        }

        void loadListAdmision()
        {
            dataGridViewLoadAddmission.Rows.Clear();
            if (dataGridViewLoadAddmission.Columns.Count == 0)
            {
                dataGridViewLoadAddmission.Columns.Add("ID_N", "MÃ NGÀNH");
                dataGridViewLoadAddmission.Columns.Add("TEN_NGANH", "NGÀNH");
                dataGridViewLoadAddmission.Columns.Add("PhuongThuc", "PHƯƠNG THỨC");
                dataGridViewLoadAddmission.Columns.Add("CHI_TIEU", "CHỈ TIÊU");
                dataGridViewLoadAddmission.Columns.Add("DIEM_TRUNG_TUYEN", "ĐIỂM");
                dataGridViewLoadAddmission.Columns.Add("NAM", "NĂM");


                dataGridViewLoadAddmission.ColumnHeadersDefaultCellStyle.BackColor = Color.Tomato;
                dataGridViewLoadAddmission.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                dataGridViewLoadAddmission.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 13, FontStyle.Bold);
            }

            List<Addmision> list = AddmisionDAO.Instance.listAddmision();
            HashSet<string> uniqueEntries = new HashSet<string>();

            foreach (Addmision addmision in list)
            {
                string entry = $"{addmision.Id_n}|{addmision.Ten_Nganh}|{addmision.PhuongThuc1}|{addmision.Nam}|{addmision.ChiTieu}|{addmision.Diem}";

                if (uniqueEntries.Add(entry))
                {
                    dataGridViewLoadAddmission.Rows.Add(addmision.Id_n, addmision.Ten_Nganh, addmision.PhuongThuc1, addmision.ChiTieu, addmision.Diem, addmision.Nam);
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
                comboBoxLoadYearAdm.DataSource = distinctYears;
                comboBoxLoadYearAdm.DisplayMember = "NAM1";
                comboBoxLoadYearAdm.ValueMember = "ID";
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
                comboBoxLoadMajorAdm.MaxDropDownItems = 15;
                comboBoxLoadMajorAdm.IntegralHeight = false;
                comboBoxLoadMajorAdm.DataSource = distinctList;
                comboBoxLoadMajorAdm.DisplayMember = "TEN_NGANH1";
                comboBoxLoadMajorAdm.ValueMember = "ID";
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
                comboBoxLoadMethodAdm.DataSource = curriculum;
                comboBoxLoadMethodAdm.DisplayMember = "Name";
                comboBoxLoadMethodAdm.ValueMember = "ID";
            }
            else
            {
                MessageBox.Show("Danh sách rỗng á!");
            }
        }
        void listMethod()
        {
            List<MethodXT> methodXT = MethodDAO.Instance.LoadMethodList();

            if (methodXT != null && methodXT.Count > 0)
            {
                comboBoxLoadMethodAdm.DataSource = methodXT;
                comboBoxLoadMethodAdm.DisplayMember = "TEN_PT1";
                comboBoxLoadMethodAdm.ValueMember = "ID";
            }
            else
            {
                MessageBox.Show("Danh sách rỗng á!");
            }
        }

        private void btnAddAddmision_Click(object sender, EventArgs e)
        {
            string id_n = comboBoxLoadMajorAdm.SelectedValue.ToString();
            string id_pt = comboBoxLoadMethodAdm.SelectedValue.ToString();
            string nam = comboBoxLoadYearAdm.SelectedValue.ToString();
            int chiTieu = int.Parse(txtChiTieu.Text);
            float diem = float.Parse(txtDiemTrungtuyen.Text);
            if (AddmisionDAO.Instance.insertAdmission(id_n, id_pt, nam, chiTieu, diem))
            {
                MessageBox.Show("Thêm xét tuyển thành công!");
                loadListAdmision();
            }
            else
            {
                MessageBox.Show("Thêm lỗi, vui lòng kiểm tra lại!");
            }
        }

        private void dataGridViewLoadAddmission_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxLoadMajorAdm.Text = dataGridViewLoadAddmission.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBoxLoadMethodAdm.Text = dataGridViewLoadAddmission.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBoxLoadYearAdm.Text = dataGridViewLoadAddmission.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtChiTieu.Text = dataGridViewLoadAddmission.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDiemTrungtuyen.Text = dataGridViewLoadAddmission.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnDeleteAddmision_Click(object sender, EventArgs e)
        {
            string id_n = comboBoxLoadMajorAdm.SelectedValue.ToString();
            string id_pt = comboBoxLoadMethodAdm.SelectedValue.ToString();

            if (AddmisionDAO.Instance.deleteAdmission(id_n, id_pt))
            {

                MessageBox.Show("Xóa xét tuyển thành công");
                loadListAdmision();
            }
            else
            {
                MessageBox.Show("Xóa lỗi, vui lòng kiểm tra lại");
            }
        }

        private void btnEditAddmision_Click(object sender, EventArgs e)
        {
            string id_n = comboBoxLoadMajorAdm.SelectedValue.ToString();
            string id_pt = comboBoxLoadMethodAdm.SelectedValue.ToString();
            string nam = comboBoxLoadYearAdm.SelectedValue.ToString();
            int chiTieu = int.Parse(txtChiTieu.Text);
            float diem = float.Parse(txtDiemTrungtuyen.Text);
            if (AddmisionDAO.Instance.updateAdmission(id_n, id_pt, nam, chiTieu, diem))
            {
                MessageBox.Show("Cập nhật xét tuyển thành công!");
                loadListAdmision();
            }
            else
            {
                MessageBox.Show("Cập nhật lỗi, vui lòng kiểm tra lại!");
            }
        }

        private void btnResetResetAdmision_Click(object sender, EventArgs e)
        {
            txtChiTieu.Clear();
            txtDiemTrungtuyen.Clear();
        }

        private void btnSearchAddmision_Click(object sender, EventArgs e)
        {
            string tukhoa = txtSearchAddmision.Text;

            string query = " SELECT XT.ID_N, N.TEN_NGANH, N.ID, PT.TEN_PT AS PhuongThuc, XT.ID_NAM AS NAM, XT.CHI_TIEU, XT.DIEM_TRUNG_TUYEN FROM XET_TUYEN AS XT JOIN NGANH AS N ON XT.ID_N = N.ID JOIN PHUONG_THUC_XT AS PT ON XT.ID_PT = PT.ID WHERE N.TEN_NGANH LIKE '%" + tukhoa + "%' OR N.ID LIKE '%" + tukhoa + "%' OR PT.TEN_PT LIKE '%" + tukhoa + "%';";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            dataGridViewLoadAddmission.Rows.Clear();

            if (data.Rows.Count > 0)
            {
                foreach (DataRow row in data.Rows)
                {
                    dataGridViewLoadAddmission.Rows.Add(row["ID_N"], row["TEN_NGANH"], row["PhuongThuc"], row["CHI_TIEU"], row["DIEM_TRUNG_TUYEN"], row["NAM"]);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả.");
            }
        }
        private void txtSearchAddmision_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string tukhoa = txtSearchAddmision.Text;

                string query = "SELECT XT.ID_N, N.TEN_NGANH, NX.NAM, PT.TEN_PT AS PhuongThuc, XT.CHI_TIEU, XT.DIEM_TRUNG_TUYEN, CT.TEN_CT AS ChuongTrinh FROM XET_TUYEN XT JOIN NGANH N ON XT.ID_N = N.ID JOIN NAM_XT NX ON XT.ID_NAM = NX.ID JOIN PHUONG_THUC_XT PT ON XT.ID_PT = PT.ID JOIN CHUONG_TRINH CT ON N.ID_CT = CT.ID WHERE XT.ID_N LIKE '%" + tukhoa + "%' OR N.ID LIKE '%" + tukhoa + "%' OR PT.TEN_PT LIKE '%" + tukhoa + "%';";

                DataTable data = DataProvider.Instance.ExcuteQuery(query);

                dataGridViewLoadAddmission.Rows.Clear();

                if (data.Rows.Count > 0)
                {
                    foreach (DataRow row in data.Rows)
                    {
                        dataGridViewLoadAddmission.Rows.Add(row["ID_N"], row["TEN_NGANH"], row["PhuongThuc"], row["CHI_TIEU"], row["DIEM_TRUNG_TUYEN"], row["NAM"]);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kết quả.");
                }

            }
        }

        private void txtSearchAddmision_TextChanged(object sender, EventArgs e)
        {

        }


        private void comboBoxLoadYearAdm_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedYear = comboBoxLoadYearAdm.SelectedValue?.ToString();

            dataGridViewLoadAddmission.Rows.Clear();
            if (dataGridViewLoadAddmission.Columns.Count == 0)
            {
                dataGridViewLoadAddmission.Columns.Add("ID_N", "MÃ NGÀNH");
                dataGridViewLoadAddmission.Columns.Add("TEN_NGANH", "NGÀNH");
                dataGridViewLoadAddmission.Columns.Add("PhuongThuc", "PHƯƠNG THỨC");
                dataGridViewLoadAddmission.Columns.Add("CHI_TIEU", "CHỈ TIÊU");
                dataGridViewLoadAddmission.Columns.Add("DIEM_TRUNG_TUYEN", "ĐIỂM");
                dataGridViewLoadAddmission.Columns.Add("NAM", "NĂM");

                dataGridViewLoadAddmission.ColumnHeadersDefaultCellStyle.BackColor = Color.Tomato;
                dataGridViewLoadAddmission.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                dataGridViewLoadAddmission.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 13, FontStyle.Bold);
            }

            List<Addmision> list = AddmisionDAO.Instance.listFollowYear(selectedYear);
            HashSet<string> uniqueEntries = new HashSet<string>();

            foreach (Addmision addmision in list)
            {
                string entry = $"{addmision.Id_n}|{addmision.Ten_Nganh}|{addmision.PhuongThuc1}|{addmision.Nam}|{addmision.ChiTieu}|{addmision.Diem}";

                if (uniqueEntries.Add(entry))
                {
                    dataGridViewLoadAddmission.Rows.Add(addmision.Id_n, addmision.Ten_Nganh, addmision.PhuongThuc1, addmision.ChiTieu, addmision.Diem, addmision.Nam);
                }
            }

        }

        private void btnPrintAddmision_Click(object sender, EventArgs e)
        {
            fPrintAdmission fPrintRoom = new fPrintAdmission();
            Point pictureBoxLocation = panel1.PointToScreen(Point.Empty);
            fPrintRoom.StartPosition = FormStartPosition.Manual;
            fPrintRoom.Location = pictureBoxLocation;
            fPrintRoom.Show();
        }
    }
}
