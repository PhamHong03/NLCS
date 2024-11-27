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
    public partial class fPrintFee : Form
    {
        public fPrintFee()
        {
            InitializeComponent();
            LoadFeeList();


        }

        private void fPrintFee_Load(object sender, EventArgs e)
        {

        }

        void LoadFeeList()
        {
            dataGridView1.Rows.Clear();
            if (dataGridView1.Columns.Count == 0)
            {
                //dataGridViewLoadFee.Columns.Add("ID", "ID");
                dataGridView1.Columns.Add("Nganh", "NGÀNH");
                dataGridView1.Columns.Add("CT", "CHƯƠNG TRÌNH");
                dataGridView1.Columns.Add("nam", "THỜI GIAN");
                dataGridView1.Columns.Add("hp", "HỌC PHÍ");

                dataGridView1.Columns["hp"].DefaultCellStyle.Format = "C0";
                dataGridView1.Columns["hp"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("vi-VN");


                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Tomato;
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 13, FontStyle.Bold);
            }

            List<Fee> list = FeeDAO.Instance.loadListFee();
            HashSet<string> uniqueEntries = new HashSet<string>();

            foreach (Fee fee in list)
            {
                string entry = $"{fee.Nganh1}|{fee.CT1}|{fee.Nam}|{fee.Hp}";

                if (uniqueEntries.Add(entry))
                {
                    dataGridView1.Rows.Add(fee.Nganh1, fee.CT1, fee.Nam, fee.Hp);
                }
            }
        }

    }
}
