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
    public partial class fPrintMajor : Form
    {
        public fPrintMajor()
        {
            InitializeComponent();
            LoadMajorList();    
        }

        private void fPrintMajor_Load(object sender, EventArgs e)
        {

        }


        void LoadMajorList()
        {
            dataGridView1.Rows.Clear();
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("ID", "MÃ NGÀNH");
                dataGridView1.Columns.Add("TEN_NGANH", "TÊN NGÀNH");
                dataGridView1.Columns.Add("THOI_GIAN_DAO_TAO", "THỜI GIAN");
                dataGridView1.Columns.Add("Type", "CHƯƠNG TRÌNH");

                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Tomato;
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 13, FontStyle.Bold);
            }

            List<Major> list = MajorDAO.Instance.loadMajorList();
            HashSet<string> uniqueEntries = new HashSet<string>();

            foreach (Major major in list)
            {
                string entry = $"{major.ID}|{major.TEN_NGANH1}|{major.THOI_GIAN_DAO_TAO1}|{major.Type}";

                if (uniqueEntries.Add(entry))
                {
                    dataGridView1.Rows.Add(major.ID, major.TEN_NGANH1, major.THOI_GIAN_DAO_TAO1, major.Type);
                }
            }
        }
    }
}
