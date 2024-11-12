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
    public partial class fPrintCombinate : Form
    {
        public fPrintCombinate()
        {
            InitializeComponent();
            LoadListCombinate();    
        }

        private void fPrintCombinate_Load(object sender, EventArgs e)
        {

        }

        void LoadListCombinate()
        {
            dataGridView1.Rows.Clear();
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("ID", "MÃ TỔ HỢP");
                dataGridView1.Columns.Add("TEN_TH", "TÊN TỔ HỢP");

                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Tomato;
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 13, FontStyle.Bold);
            }

            List<Combinate> list = CombinateDAO.Instance.LoadListCombinate();
            HashSet<string> uniqueEntries = new HashSet<string>();

            foreach (Combinate combinate in list)
            {
                string entry = $"{combinate.ID}|{combinate.TEN_TH1}";

                if (uniqueEntries.Add(entry))
                {
                    dataGridView1.Rows.Add(combinate.ID, combinate.TEN_TH1);
                }
            }

            //dataGridViewLoadMajor.Columns["ID"].Visible = false;
        }
    }
}
