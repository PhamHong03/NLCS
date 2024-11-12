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
    public partial class fPrintMethod : Form
    {
        public fPrintMethod()
        {
            InitializeComponent();
            LoadListMethod();
        }

        private void fPrintMethod_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void LoadListMethod()
        {
            dataGridView1.Rows.Clear();
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("ID", "ID");
                dataGridView1.Columns.Add("TEN_PT", "TÊN PHƯƠNG THỨC");
                dataGridView1.Columns.Add("MO_TA", "MÔ TẢ");

                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Tomato;
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 13, FontStyle.Bold);
            }

            List<MethodXT> list = MethodDAO.Instance.LoadMethodList();
            HashSet<string> uniqueEntries = new HashSet<string>();

            foreach (MethodXT method in list)
            {
                string entry = $"{method.TEN_PT1}";

                if (uniqueEntries.Add(entry))
                {
                    dataGridView1.Rows.Add(method.ID, method.TEN_PT1, method.MO_TA1);
                }
            }
            dataGridView1.Columns["ID"].Visible = true;
        }
    }
}
