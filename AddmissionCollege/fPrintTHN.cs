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
    public partial class fPrintTHN : Form
    {
        public fPrintTHN()
        {
            InitializeComponent();
            listMajorCombinate();
        }

        private void fPrintTHN_Load(object sender, EventArgs e)
        {

        }

        void listMajorCombinate()
        {
            dataGridView1.Rows.Clear();
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("TEN_NGANH", "NGÀNH");
                dataGridView1.Columns.Add("TO_HOP", "TỔ HỢP");

                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Tomato;
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 13, FontStyle.Bold);
            }

            List<MajorCom> list = MajorComDAO.Instance.loadMajorCombinate();
            HashSet<string> uniqueEntries = new HashSet<string>();

            foreach (MajorCom majorCom in list)
            {
                string entry = $"{majorCom.TEN_NGANH}|{majorCom.TO_HOP}";

                if (uniqueEntries.Add(entry))
                {
                    dataGridView1.Rows.Add(majorCom.TEN_NGANH, majorCom.TO_HOP);
                }
            }

        }
    }
}
