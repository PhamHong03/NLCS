namespace AddmissionCollege
{
    partial class fMajorPlusCombinate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMajorPlusCombinate));
            label2 = new Label();
            label1 = new Label();
            dataGridViewLoadListMajorCom = new DataGridView();
            groupBox1 = new GroupBox();
            btnPrintMPlusC = new Button();
            btnExportMPlusC = new Button();
            btnDeleteMPlusC = new Button();
            btnEditMPlusC = new Button();
            btnAddMPlusC = new Button();
            comboBoxLoadCombinateList = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            comboBoxLoadMajorList = new ComboBox();
            txtSearchMajorCom = new TextBox();
            btnSearchMajorCom = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoadListMajorCom).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(379, 61);
            label2.Name = "label2";
            label2.Size = new Size(558, 25);
            label2.TabIndex = 4;
            label2.Text = "------------------------------------------------------------------------------";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(410, 20);
            label1.Name = "label1";
            label1.Size = new Size(466, 41);
            label1.TabIndex = 3;
            label1.Text = "DANH SÁCH NGÀNH - TỔ HỢP ";
            // 
            // dataGridViewLoadListMajorCom
            // 
            dataGridViewLoadListMajorCom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLoadListMajorCom.BackgroundColor = Color.AliceBlue;
            dataGridViewLoadListMajorCom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLoadListMajorCom.Location = new Point(12, 315);
            dataGridViewLoadListMajorCom.Name = "dataGridViewLoadListMajorCom";
            dataGridViewLoadListMajorCom.RowHeadersWidth = 51;
            dataGridViewLoadListMajorCom.Size = new Size(1283, 514);
            dataGridViewLoadListMajorCom.TabIndex = 5;
            dataGridViewLoadListMajorCom.CellClick += dataGridViewLoadListMajorCom_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.GhostWhite;
            groupBox1.Controls.Add(btnPrintMPlusC);
            groupBox1.Controls.Add(btnExportMPlusC);
            groupBox1.Controls.Add(btnDeleteMPlusC);
            groupBox1.Controls.Add(btnEditMPlusC);
            groupBox1.Controls.Add(btnAddMPlusC);
            groupBox1.Controls.Add(comboBoxLoadCombinateList);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBoxLoadMajorList);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            groupBox1.Location = new Point(12, 173);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1283, 136);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ngành - Tổ hợp ";
            // 
            // btnPrintMPlusC
            // 
            btnPrintMPlusC.BackColor = Color.Honeydew;
            btnPrintMPlusC.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnPrintMPlusC.ForeColor = Color.Teal;
            btnPrintMPlusC.Location = new Point(1135, 78);
            btnPrintMPlusC.Name = "btnPrintMPlusC";
            btnPrintMPlusC.Size = new Size(111, 41);
            btnPrintMPlusC.TabIndex = 9;
            btnPrintMPlusC.Text = "In file ";
            btnPrintMPlusC.UseVisualStyleBackColor = false;
            // 
            // btnExportMPlusC
            // 
            btnExportMPlusC.BackColor = Color.Honeydew;
            btnExportMPlusC.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnExportMPlusC.ForeColor = Color.Teal;
            btnExportMPlusC.Location = new Point(1135, 31);
            btnExportMPlusC.Name = "btnExportMPlusC";
            btnExportMPlusC.Size = new Size(111, 41);
            btnExportMPlusC.TabIndex = 8;
            btnExportMPlusC.Text = "Xuất file ";
            btnExportMPlusC.UseVisualStyleBackColor = false;
            // 
            // btnDeleteMPlusC
            // 
            btnDeleteMPlusC.BackColor = Color.Honeydew;
            btnDeleteMPlusC.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnDeleteMPlusC.ForeColor = Color.Teal;
            btnDeleteMPlusC.Location = new Point(1010, 31);
            btnDeleteMPlusC.Name = "btnDeleteMPlusC";
            btnDeleteMPlusC.Size = new Size(105, 41);
            btnDeleteMPlusC.TabIndex = 6;
            btnDeleteMPlusC.Text = "Xóa ";
            btnDeleteMPlusC.UseVisualStyleBackColor = false;
            btnDeleteMPlusC.Click += btnDeleteMPlusC_Click;
            // 
            // btnEditMPlusC
            // 
            btnEditMPlusC.BackColor = Color.Honeydew;
            btnEditMPlusC.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnEditMPlusC.ForeColor = Color.Teal;
            btnEditMPlusC.Location = new Point(1010, 78);
            btnEditMPlusC.Name = "btnEditMPlusC";
            btnEditMPlusC.Size = new Size(105, 41);
            btnEditMPlusC.TabIndex = 5;
            btnEditMPlusC.Text = "Sửa ";
            btnEditMPlusC.UseVisualStyleBackColor = false;
            // 
            // btnAddMPlusC
            // 
            btnAddMPlusC.BackColor = Color.Honeydew;
            btnAddMPlusC.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnAddMPlusC.ForeColor = Color.Teal;
            btnAddMPlusC.Location = new Point(887, 31);
            btnAddMPlusC.Name = "btnAddMPlusC";
            btnAddMPlusC.Size = new Size(105, 41);
            btnAddMPlusC.TabIndex = 4;
            btnAddMPlusC.Text = "Thêm ";
            btnAddMPlusC.UseVisualStyleBackColor = false;
            btnAddMPlusC.Click += btnAddMPlusC_Click;
            // 
            // comboBoxLoadCombinateList
            // 
            comboBoxLoadCombinateList.DisplayMember = "TEN_TH";
            comboBoxLoadCombinateList.Font = new Font("Times New Roman", 10.8F);
            comboBoxLoadCombinateList.FormattingEnabled = true;
            comboBoxLoadCombinateList.Location = new Point(601, 62);
            comboBoxLoadCombinateList.Name = "comboBoxLoadCombinateList";
            comboBoxLoadCombinateList.Size = new Size(245, 28);
            comboBoxLoadCombinateList.TabIndex = 3;
            comboBoxLoadCombinateList.ValueMember = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(507, 65);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 2;
            label4.Text = "Tổ hợp: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 65);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 1;
            label3.Text = "Ngành: ";
            // 
            // comboBoxLoadMajorList
            // 
            comboBoxLoadMajorList.DisplayMember = "TEN_NGANH";
            comboBoxLoadMajorList.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            comboBoxLoadMajorList.FormattingEnabled = true;
            comboBoxLoadMajorList.Location = new Point(103, 62);
            comboBoxLoadMajorList.Name = "comboBoxLoadMajorList";
            comboBoxLoadMajorList.Size = new Size(338, 28);
            comboBoxLoadMajorList.TabIndex = 0;
            comboBoxLoadMajorList.ValueMember = "ID";
            // 
            // txtSearchMajorCom
            // 
            txtSearchMajorCom.Location = new Point(899, 107);
            txtSearchMajorCom.Multiline = true;
            txtSearchMajorCom.Name = "txtSearchMajorCom";
            txtSearchMajorCom.PlaceholderText = "Nhập tìm kiếm ";
            txtSearchMajorCom.Size = new Size(257, 43);
            txtSearchMajorCom.TabIndex = 16;
            // 
            // btnSearchMajorCom
            // 
            btnSearchMajorCom.BackColor = Color.Lavender;
            btnSearchMajorCom.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSearchMajorCom.ForeColor = Color.Teal;
            btnSearchMajorCom.Image = (Image)resources.GetObject("btnSearchMajorCom.Image");
            btnSearchMajorCom.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearchMajorCom.Location = new Point(1162, 107);
            btnSearchMajorCom.Name = "btnSearchMajorCom";
            btnSearchMajorCom.Size = new Size(128, 43);
            btnSearchMajorCom.TabIndex = 17;
            btnSearchMajorCom.Text = "Tìm kiếm ";
            btnSearchMajorCom.TextAlign = ContentAlignment.MiddleRight;
            btnSearchMajorCom.UseVisualStyleBackColor = false;
            // 
            // fMajorPlusCombinate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1307, 841);
            Controls.Add(txtSearchMajorCom);
            Controls.Add(btnSearchMajorCom);
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewLoadListMajorCom);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fMajorPlusCombinate";
            Text = "fMajorPlusCombinate";
            Load += fMajorPlusCombinate_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoadListMajorCom).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private DataGridView dataGridViewLoadListMajorCom;
        private GroupBox groupBox1;
        private TextBox txtSearchMajorCom;
        private Button btnSearchMajorCom;
        private Label label4;
        private Label label3;
        private ComboBox comboBoxLoadMajorList;
        private Button btnAddMPlusC;
        private ComboBox comboBoxLoadCombinateList;
        private Button btnPrintMPlusC;
        private Button btnExportMPlusC;
        private Button btnDeleteMPlusC;
        private Button btnEditMPlusC;
    }
}