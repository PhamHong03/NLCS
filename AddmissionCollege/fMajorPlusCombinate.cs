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
    public partial class fMajorPlusCombinate : Form
    {

        public fMajorPlusCombinate()
        {
            InitializeComponent();
            LoadMajorList();
            LoadCombinateList();
            listMajorCombinate();
        }

        private void fMajorPlusCombinate_Load(object sender, EventArgs e)
        {

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
                comboBoxLoadMajorList.MaxDropDownItems = 15;
                comboBoxLoadMajorList.IntegralHeight = false;
                comboBoxLoadMajorList.DataSource = distinctList;
                comboBoxLoadMajorList.DisplayMember = "TEN_NGANH1";
                comboBoxLoadMajorList.ValueMember = "ID";
            }
            else
            {
                MessageBox.Show("Danh sách ngành rỗng á!");
            }
        }

        void LoadCombinateList()
        {
            List<Combinate> com = CombinateDAO.Instance.LoadListCombinate();

            if (com != null && com.Count > 0)
            {
                HashSet<string> uniqueObjects = new HashSet<string>();
                List<Combinate> distinctList = new List<Combinate>();

                foreach (var obj in com)
                {

                    if (uniqueObjects.Add(obj.ID))
                    {
                        distinctList.Add(obj);
                    }
                }

                comboBoxLoadCombinateList.MaxDropDownItems = 15;
                comboBoxLoadCombinateList.IntegralHeight = false;
                comboBoxLoadCombinateList.DataSource = distinctList;
                comboBoxLoadCombinateList.DisplayMember = "TEN_TH1";
                comboBoxLoadCombinateList.ValueMember = "ID";
            }
            else
            {
                MessageBox.Show("Danh sách tổ hợp rỗng á!");
            }
        }



        void listMajorCombinate()
        {
            dataGridViewLoadListMajorCom.Rows.Clear();
            if (dataGridViewLoadListMajorCom.Columns.Count == 0)
            {
                dataGridViewLoadListMajorCom.Columns.Add("TEN_NGANH", "NGÀNH");
                dataGridViewLoadListMajorCom.Columns.Add("TO_HOP", "TỔ HỢP");

                dataGridViewLoadListMajorCom.ColumnHeadersDefaultCellStyle.BackColor = Color.Tomato;
                dataGridViewLoadListMajorCom.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                dataGridViewLoadListMajorCom.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 13, FontStyle.Bold);
            }

            List<MajorCom> list = MajorComDAO.Instance.loadMajorCombinate();
            HashSet<string> uniqueEntries = new HashSet<string>();

            foreach (MajorCom majorCom in list)
            {
                string entry = $"{majorCom.TEN_NGANH}|{majorCom.TO_HOP}";

                if (uniqueEntries.Add(entry))
                {
                    dataGridViewLoadListMajorCom.Rows.Add(majorCom.TEN_NGANH, majorCom.TO_HOP);
                }
            }

        }

        private void btnAddMPlusC_Click(object sender, EventArgs e)
        {
            string id_n = comboBoxLoadMajorList.SelectedValue.ToString();
            string id_th = comboBoxLoadCombinateList.SelectedValue.ToString();
            if (MajorComDAO.Instance.InsertMajorCom(id_n, id_th))
            {
                MessageBox.Show("Thêm tổ hợp ngành thành công");
                listMajorCombinate();
            }
            else
            {
                MessageBox.Show("Thêm lỗi, vui lòng kiểm tra lại!");
            }
        }

        private void btnDeleteMPlusC_Click(object sender, EventArgs e)
        {
            string id_n = comboBoxLoadMajorList.SelectedValue.ToString();
            if (MajorComDAO.Instance.DeleteMajorCom(id_n))
            {
                MessageBox.Show("Xóa tổ hợp ngành thành công");
                listMajorCombinate();
            }
            else
            {
                MessageBox.Show("Xóa lỗi, vui lòng kiểm tra lại!");
            }
        }

        private void dataGridViewLoadListMajorCom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxLoadMajorList.Text = dataGridViewLoadListMajorCom.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void txtSearchMajorCom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string tukhoa = txtSearchMajorCom.Text;

                string query = "SELECT N.TEN_NGANH AS NGANH, STRING_AGG(TH.ID, ', ') AS TO_HOP FROM NGANH_TO_HOP NTH JOIN NGANH N ON NTH.ID_N = N.ID JOIN TO_HOP_XT TH ON NTH.ID_TH = TH.ID WHERE N.TEN_NGANH LIKE '%" + tukhoa + "%' OR TH.ID LIKE '%" + tukhoa + "%' GROUP BY N.TEN_NGANH";


                DataTable data = DataProvider.Instance.ExcuteQuery(query);

                dataGridViewLoadListMajorCom.Rows.Clear();

                if (data.Rows.Count > 0)
                {
                    foreach (DataRow row in data.Rows)
                    {
                        dataGridViewLoadListMajorCom.Rows.Add(row["NGANH"], row["TO_HOP"]);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kết quả.");
                }
            }
        }

        private void btnSearchMajorCom_Click(object sender, EventArgs e)
        {
            string tukhoa = txtSearchMajorCom.Text;

            string query = "SELECT N.TEN_NGANH AS NGANH, STRING_AGG(TH.ID, ', ') AS TO_HOP FROM NGANH_TO_HOP NTH JOIN NGANH N ON NTH.ID_N = N.ID JOIN TO_HOP_XT TH ON NTH.ID_TH = TH.ID WHERE N.TEN_NGANH LIKE '%" + tukhoa + "%' OR TH.ID LIKE '%" + tukhoa + "%' GROUP BY N.TEN_NGANH";


            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            dataGridViewLoadListMajorCom.Rows.Clear();

            if (data.Rows.Count > 0)
            {
                foreach (DataRow row in data.Rows)
                {
                    dataGridViewLoadListMajorCom.Rows.Add(row["NGANH"], row["TO_HOP"]);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả.");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
