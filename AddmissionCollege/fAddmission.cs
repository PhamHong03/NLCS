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
    public partial class fAddmission : Form
    {
        public fAddmission()
        {
            InitializeComponent();
            LoadListYear();
            LoadMajorList();
            loadCurriculum();
            loadListAdmision();
        }

        void loadListAdmision()
        {
            dataGridViewLoadAddmission.Rows.Clear();
            if (dataGridViewLoadAddmission.Columns.Count == 0)
            {
                dataGridViewLoadAddmission.Columns.Add("ID_N", "NGÀNH");
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
                string entry = $"{addmision.Id_n}|{addmision.Id_pt}|{addmision.Nam}|{addmision.ChiTieu}|{addmision.Diem}";

                if (uniqueEntries.Add(entry))
                {
                    dataGridViewLoadAddmission.Rows.Add(addmision.Id_n, addmision.Id_pt, addmision.Nam, addmision.ChiTieu, addmision.Diem);
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

    }
}
