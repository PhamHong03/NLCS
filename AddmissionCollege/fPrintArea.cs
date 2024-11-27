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
    public partial class fPrintArea : Form
    {
        public fPrintArea()
        {
            InitializeComponent();
            LoadAreaList();
        }

        private void fPrintArea_Load(object sender, EventArgs e)
        {

        }

        void LoadAreaList()
        {
            dataGridView1.Rows.Clear();
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("ID", "ID");
                dataGridView1.Columns.Add("TEN_KV", "TÊN KHU VỰC");
                dataGridView1.Columns.Add("MO_TA", "MÔ TẢ");

                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Tomato;
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 13, FontStyle.Bold);
            }

            List<Area> list = AreaDAO.Instance.LoadAreaList();

            foreach (Area area in list)
            {
                dataGridView1.Rows.Add(area.ID, area.TEN_KV1, area.MO_TA1);
            }

            dataGridView1.Columns["ID"].Visible = false;
        }
    }
}
