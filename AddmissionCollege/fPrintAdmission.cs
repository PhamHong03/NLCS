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
    public partial class fPrintAdmission : Form
    {
        public fPrintAdmission()
        {
            InitializeComponent();
            loadListAdmision();
        }

        private void fPrintAdmission_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        void loadListAdmision()
        {
            dataGridView1.Rows.Clear();
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("ID_N", "MÃ NGÀNH");
                dataGridView1.Columns.Add("TEN_NGANH", "NGÀNH");
                dataGridView1.Columns.Add("PhuongThuc", "PHƯƠNG THỨC");
                dataGridView1.Columns.Add("CHI_TIEU", "CHỈ TIÊU");
                dataGridView1.Columns.Add("DIEM_TRUNG_TUYEN", "ĐIỂM");
                dataGridView1.Columns.Add("NAM", "NĂM");


                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Tomato;
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 13, FontStyle.Bold);
            }

            List<Addmision> list = AddmisionDAO.Instance.listAddmision();
            HashSet<string> uniqueEntries = new HashSet<string>();

            foreach (Addmision addmision in list)
            {
                string entry = $"{addmision.Id_n}|{addmision.Ten_Nganh}|{addmision.PhuongThuc1}|{addmision.Nam}|{addmision.ChiTieu}|{addmision.Diem}";

                if (uniqueEntries.Add(entry))
                {
                    dataGridView1.Rows.Add(addmision.Id_n, addmision.Ten_Nganh, addmision.PhuongThuc1, addmision.ChiTieu, addmision.Diem, addmision.Nam);
                }
            }
        }

    }
}
