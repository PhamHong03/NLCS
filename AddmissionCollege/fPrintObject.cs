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
    public partial class fPrintObject : Form
    {
        public fPrintObject()
        {
            InitializeComponent();
            LoadObjectPriority();   
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void LoadObjectPriority()
        {
            dataGridView1.Rows.Clear();
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("ID", "ID");
                dataGridView1.Columns.Add("Ten_DT", "TÊN ĐỐI TƯỢNG");
                dataGridView1.Columns.Add("CHINH_SACH", "CHÍNH SÁCH");

                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Tomato;
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 13, FontStyle.Bold);
            }

            List<ObjectPriority> list = ObjectPriorityDAO.Instance.loadObjectPriority();
            HashSet<string> uniqueEntries = new HashSet<string>(); // Giúp theo dõi các bản ghi đã thêm

            foreach (ObjectPriority objectPriority in list)
            {
                string entry = $"{objectPriority.Ten_DT1}|{objectPriority.CHINH_SACH1}";

                if (uniqueEntries.Add(entry))
                {
                    dataGridView1.Rows.Add(objectPriority.Id, objectPriority.Ten_DT1, objectPriority.CHINH_SACH1);
                }
            }

            dataGridView1.Columns["ID"].Visible = false;
        }
    }
}
