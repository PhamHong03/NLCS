namespace AddmissionCollege
{
    partial class fPriority
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPriority));
            panel1 = new Panel();
            panel3 = new Panel();
            comboBoxYearObject = new ComboBox();
            label11 = new Label();
            txtSearchGradeObject = new TextBox();
            btnSearchGradeObject = new Button();
            btnDeleteGradeObject = new Button();
            btnResetGradeObject = new Button();
            btnEditgradeObject = new Button();
            btnAddgradeObject = new Button();
            comboBoxPriorityObject = new ComboBox();
            txtGradeObject = new TextBox();
            txtIdGradeObject = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            dataGridViewGradePriorityObject = new DataGridView();
            label4 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            btnLoadData = new Button();
            txtPolicyPriorityObject = new TextBox();
            txtSearchObjectPriority = new TextBox();
            btnSearchObject = new Button();
            btnDeleteObject = new Button();
            btnResetObject = new Button();
            btnEditObject = new Button();
            btnAddObject = new Button();
            txtNameObject = new TextBox();
            txtIDObject = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            dataGridViewObjectLoad = new DataGridView();
            label3 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGradePriorityObject).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewObjectLoad).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1307, 825);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.AliceBlue;
            panel3.Controls.Add(comboBoxYearObject);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(txtSearchGradeObject);
            panel3.Controls.Add(btnSearchGradeObject);
            panel3.Controls.Add(btnDeleteGradeObject);
            panel3.Controls.Add(btnResetGradeObject);
            panel3.Controls.Add(btnEditgradeObject);
            panel3.Controls.Add(btnAddgradeObject);
            panel3.Controls.Add(comboBoxPriorityObject);
            panel3.Controls.Add(txtGradeObject);
            panel3.Controls.Add(txtIdGradeObject);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(dataGridViewGradePriorityObject);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(631, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(658, 816);
            panel3.TabIndex = 1;
            // 
            // comboBoxYearObject
            // 
            comboBoxYearObject.DisplayMember = "NAM";
            comboBoxYearObject.FormattingEnabled = true;
            comboBoxYearObject.Location = new Point(71, 129);
            comboBoxYearObject.Name = "comboBoxYearObject";
            comboBoxYearObject.Size = new Size(118, 28);
            comboBoxYearObject.TabIndex = 29;
            comboBoxYearObject.ValueMember = "ID";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label11.ForeColor = Color.DarkRed;
            label11.Location = new Point(3, 127);
            label11.Name = "label11";
            label11.Size = new Size(62, 25);
            label11.TabIndex = 28;
            label11.Text = "Năm: ";
            // 
            // txtSearchGradeObject
            // 
            txtSearchGradeObject.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 163);
            txtSearchGradeObject.Location = new Point(252, 117);
            txtSearchGradeObject.Multiline = true;
            txtSearchGradeObject.Name = "txtSearchGradeObject";
            txtSearchGradeObject.PlaceholderText = "Nhập mã hoặc tên";
            txtSearchGradeObject.Size = new Size(251, 41);
            txtSearchGradeObject.TabIndex = 27;
            txtSearchGradeObject.KeyDown += txtSearchGradeObject_KeyDown;
            // 
            // btnSearchGradeObject
            // 
            btnSearchGradeObject.BackColor = Color.Lavender;
            btnSearchGradeObject.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSearchGradeObject.Image = (Image)resources.GetObject("btnSearchGradeObject.Image");
            btnSearchGradeObject.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearchGradeObject.Location = new Point(509, 112);
            btnSearchGradeObject.Name = "btnSearchGradeObject";
            btnSearchGradeObject.Size = new Size(114, 46);
            btnSearchGradeObject.TabIndex = 26;
            btnSearchGradeObject.Text = "Tìm kiếm ";
            btnSearchGradeObject.TextAlign = ContentAlignment.MiddleRight;
            btnSearchGradeObject.UseVisualStyleBackColor = false;
            // 
            // btnDeleteGradeObject
            // 
            btnDeleteGradeObject.BackColor = Color.Lavender;
            btnDeleteGradeObject.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnDeleteGradeObject.Location = new Point(342, 354);
            btnDeleteGradeObject.Name = "btnDeleteGradeObject";
            btnDeleteGradeObject.Size = new Size(78, 46);
            btnDeleteGradeObject.TabIndex = 25;
            btnDeleteGradeObject.Text = "Xóa ";
            btnDeleteGradeObject.UseVisualStyleBackColor = false;
            btnDeleteGradeObject.Click += btnDeleteGradeObject_Click;
            // 
            // btnResetGradeObject
            // 
            btnResetGradeObject.BackColor = Color.Lavender;
            btnResetGradeObject.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnResetGradeObject.Location = new Point(459, 354);
            btnResetGradeObject.Name = "btnResetGradeObject";
            btnResetGradeObject.Size = new Size(78, 46);
            btnResetGradeObject.TabIndex = 24;
            btnResetGradeObject.Text = "Đặt lại ";
            btnResetGradeObject.UseVisualStyleBackColor = false;
            btnResetGradeObject.Click += btnResetGradeObject_Click;
            // 
            // btnEditgradeObject
            // 
            btnEditgradeObject.BackColor = Color.Lavender;
            btnEditgradeObject.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnEditgradeObject.Location = new Point(216, 354);
            btnEditgradeObject.Name = "btnEditgradeObject";
            btnEditgradeObject.Size = new Size(78, 46);
            btnEditgradeObject.TabIndex = 23;
            btnEditgradeObject.Text = "Sửa ";
            btnEditgradeObject.UseVisualStyleBackColor = false;
            btnEditgradeObject.Click += btnEditgradeObject_Click;
            // 
            // btnAddgradeObject
            // 
            btnAddgradeObject.BackColor = Color.Lavender;
            btnAddgradeObject.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnAddgradeObject.Location = new Point(94, 354);
            btnAddgradeObject.Name = "btnAddgradeObject";
            btnAddgradeObject.Size = new Size(78, 46);
            btnAddgradeObject.TabIndex = 22;
            btnAddgradeObject.Text = "Thêm ";
            btnAddgradeObject.UseVisualStyleBackColor = false;
            btnAddgradeObject.Click += btnAddgradeObject_Click;
            // 
            // comboBoxPriorityObject
            // 
            comboBoxPriorityObject.DisplayMember = "Ten_DT";
            comboBoxPriorityObject.FormattingEnabled = true;
            comboBoxPriorityObject.Location = new Point(252, 298);
            comboBoxPriorityObject.Name = "comboBoxPriorityObject";
            comboBoxPriorityObject.Size = new Size(285, 28);
            comboBoxPriorityObject.TabIndex = 21;
            comboBoxPriorityObject.SelectedIndexChanged += comboBoxPriorityObject_SelectedIndexChanged;
            // 
            // txtGradeObject
            // 
            txtGradeObject.Location = new Point(252, 242);
            txtGradeObject.Name = "txtGradeObject";
            txtGradeObject.Size = new Size(285, 27);
            txtGradeObject.TabIndex = 20;
            // 
            // txtIdGradeObject
            // 
            txtIdGradeObject.Location = new Point(252, 189);
            txtIdGradeObject.Name = "txtIdGradeObject";
            txtIdGradeObject.ReadOnly = true;
            txtIdGradeObject.Size = new Size(285, 27);
            txtIdGradeObject.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label8.ForeColor = Color.DarkRed;
            label8.Location = new Point(81, 301);
            label8.Name = "label8";
            label8.Size = new Size(108, 25);
            label8.TabIndex = 18;
            label8.Text = "Đối tượng: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label9.ForeColor = Color.DarkRed;
            label9.Location = new Point(81, 244);
            label9.Name = "label9";
            label9.Size = new Size(132, 25);
            label9.TabIndex = 17;
            label9.Text = "Điểm ưu tiên: ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label10.ForeColor = Color.DarkRed;
            label10.Location = new Point(81, 188);
            label10.Name = "label10";
            label10.Size = new Size(143, 25);
            label10.TabIndex = 16;
            label10.Text = "Mã DT ưu tiên: ";
            // 
            // dataGridViewGradePriorityObject
            // 
            dataGridViewGradePriorityObject.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewGradePriorityObject.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewGradePriorityObject.BackgroundColor = Color.Honeydew;
            dataGridViewGradePriorityObject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGradePriorityObject.Location = new Point(3, 419);
            dataGridViewGradePriorityObject.Name = "dataGridViewGradePriorityObject";
            dataGridViewGradePriorityObject.RowHeadersWidth = 51;
            dataGridViewGradePriorityObject.Size = new Size(655, 394);
            dataGridViewGradePriorityObject.TabIndex = 3;
            dataGridViewGradePriorityObject.CellClick += dataGridViewGradePriorityObject_CellClick;
//            dataGridViewGradePriorityObject.CellContentClick += dataGridViewGradePriorityObject_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(155, 62);
            label4.Name = "label4";
            label4.Size = new Size(404, 28);
            label4.TabIndex = 2;
            label4.Text = "-------------------------------------------------";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.ForeColor = Color.HotPink;
            label2.Location = new Point(173, 27);
            label2.Name = "label2";
            label2.Size = new Size(386, 38);
            label2.TabIndex = 1;
            label2.Text = "ĐIỂM ĐỐI TƯỢNG ƯU TIÊN ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Lavender;
            panel2.Controls.Add(btnLoadData);
            panel2.Controls.Add(txtPolicyPriorityObject);
            panel2.Controls.Add(txtSearchObjectPriority);
            panel2.Controls.Add(btnSearchObject);
            panel2.Controls.Add(btnDeleteObject);
            panel2.Controls.Add(btnResetObject);
            panel2.Controls.Add(btnEditObject);
            panel2.Controls.Add(btnAddObject);
            panel2.Controls.Add(txtNameObject);
            panel2.Controls.Add(txtIDObject);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(dataGridViewObjectLoad);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.ForeColor = Color.DarkRed;
            panel2.Location = new Point(6, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(624, 819);
            panel2.TabIndex = 0;
           // panel2.Paint += panel2_Paint;
            // 
            // btnLoadData
            // 
            btnLoadData.BackColor = Color.Lavender;
            btnLoadData.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnLoadData.ForeColor = Color.DimGray;
            btnLoadData.Image = (Image)resources.GetObject("btnLoadData.Image");
            btnLoadData.Location = new Point(556, 348);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(35, 37);
            btnLoadData.TabIndex = 17;
            btnLoadData.UseVisualStyleBackColor = false;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // txtPolicyPriorityObject
            // 
            txtPolicyPriorityObject.Location = new Point(208, 283);
            txtPolicyPriorityObject.Name = "txtPolicyPriorityObject";
            txtPolicyPriorityObject.Size = new Size(279, 27);
            txtPolicyPriorityObject.TabIndex = 16;
            // 
            // txtSearchObjectPriority
            // 
            txtSearchObjectPriority.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 163);
            txtSearchObjectPriority.Location = new Point(180, 108);
            txtSearchObjectPriority.Multiline = true;
            txtSearchObjectPriority.Name = "txtSearchObjectPriority";
            txtSearchObjectPriority.PlaceholderText = "Nhập mã hoặc tên";
            txtSearchObjectPriority.Size = new Size(307, 41);
            txtSearchObjectPriority.TabIndex = 15;
            txtSearchObjectPriority.KeyDown += txtSearchObjectPriority_KeyDown;
            // 
            // btnSearchObject
            // 
            btnSearchObject.BackColor = Color.Azure;
            btnSearchObject.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSearchObject.Image = (Image)resources.GetObject("btnSearchObject.Image");
            btnSearchObject.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearchObject.Location = new Point(493, 106);
            btnSearchObject.Name = "btnSearchObject";
            btnSearchObject.Size = new Size(114, 46);
            btnSearchObject.TabIndex = 14;
            btnSearchObject.Text = "Tìm kiếm ";
            btnSearchObject.TextAlign = ContentAlignment.MiddleRight;
            btnSearchObject.UseVisualStyleBackColor = false;
            // 
            // btnDeleteObject
            // 
            btnDeleteObject.BackColor = Color.Azure;
            btnDeleteObject.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnDeleteObject.Location = new Point(273, 349);
            btnDeleteObject.Name = "btnDeleteObject";
            btnDeleteObject.Size = new Size(78, 46);
            btnDeleteObject.TabIndex = 13;
            btnDeleteObject.Text = "Xóa ";
            btnDeleteObject.UseVisualStyleBackColor = false;
            btnDeleteObject.Click += btnDeleteObject_Click;
            // 
            // btnResetObject
            // 
            btnResetObject.BackColor = Color.Azure;
            btnResetObject.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnResetObject.Location = new Point(400, 345);
            btnResetObject.Name = "btnResetObject";
            btnResetObject.Size = new Size(78, 46);
            btnResetObject.TabIndex = 11;
            btnResetObject.Text = "Đặt lại ";
            btnResetObject.UseVisualStyleBackColor = false;
            btnResetObject.Click += btnResetObject_Click;
            // 
            // btnEditObject
            // 
            btnEditObject.BackColor = Color.Azure;
            btnEditObject.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnEditObject.Location = new Point(157, 349);
            btnEditObject.Name = "btnEditObject";
            btnEditObject.Size = new Size(78, 46);
            btnEditObject.TabIndex = 10;
            btnEditObject.Text = "Sửa ";
            btnEditObject.UseVisualStyleBackColor = false;
            btnEditObject.Click += btnEditObject_Click;
            // 
            // btnAddObject
            // 
            btnAddObject.BackColor = Color.Azure;
            btnAddObject.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnAddObject.Location = new Point(39, 349);
            btnAddObject.Name = "btnAddObject";
            btnAddObject.Size = new Size(78, 46);
            btnAddObject.TabIndex = 9;
            btnAddObject.Text = "Thêm ";
            btnAddObject.UseVisualStyleBackColor = false;
            btnAddObject.Click += btnAddObject_Click;
            // 
            // txtNameObject
            // 
            txtNameObject.Location = new Point(195, 226);
            txtNameObject.Name = "txtNameObject";
            txtNameObject.Size = new Size(292, 27);
            txtNameObject.TabIndex = 7;
            // 
            // txtIDObject
            // 
            txtIDObject.Location = new Point(180, 170);
            txtIDObject.Name = "txtIDObject";
            txtIDObject.ReadOnly = true;
            txtIDObject.Size = new Size(307, 27);
            txtIDObject.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label7.ForeColor = Color.DarkRed;
            label7.Location = new Point(25, 282);
            label7.Name = "label7";
            label7.Size = new Size(180, 25);
            label7.TabIndex = 5;
            label7.Text = "Chính sách ưu tiên: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label6.ForeColor = Color.DarkRed;
            label6.Location = new Point(22, 228);
            label6.Name = "label6";
            label6.Size = new Size(141, 25);
            label6.TabIndex = 4;
            label6.Text = "Tên đối tượng: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label5.ForeColor = Color.DarkRed;
            label5.Location = new Point(25, 168);
            label5.Name = "label5";
            label5.Size = new Size(138, 25);
            label5.TabIndex = 3;
            label5.Text = "Mã đối tượng: ";
            // 
            // dataGridViewObjectLoad
            // 
            dataGridViewObjectLoad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewObjectLoad.BackgroundColor = Color.Honeydew;
            dataGridViewObjectLoad.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewObjectLoad.ColumnHeadersHeight = 29;
            dataGridViewObjectLoad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewObjectLoad.GridColor = SystemColors.WindowText;
            dataGridViewObjectLoad.Location = new Point(0, 419);
            dataGridViewObjectLoad.Name = "dataGridViewObjectLoad";
            dataGridViewObjectLoad.RowHeadersWidth = 51;
            dataGridViewObjectLoad.Size = new Size(624, 397);
            dataGridViewObjectLoad.TabIndex = 2;
            dataGridViewObjectLoad.CellClick += dataGridViewObjectLoad_CellClick;
            //dataGridViewObjectLoad.CellContentClick += dataGridViewObjectLoad_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(106, 62);
            label3.Name = "label3";
            label3.Size = new Size(372, 28);
            label3.TabIndex = 1;
            label3.Text = "---------------------------------------------";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(143, 24);
            label1.Name = "label1";
            label1.Size = new Size(306, 38);
            label1.TabIndex = 0;
            label1.Text = "ĐỐI TƯỢNG ƯU TIÊN ";
            // 
            // fPriority
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1301, 826);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fPriority";
            Text = "Quản lý ưu tiên đối tượng, khu vực ";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGradePriorityObject).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewObjectLoad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label1;
        private DataGridView dataGridViewGradePriorityObject;
        private DataGridView dataGridViewObjectLoad;
        private Button btnAddObject;
        private TextBox txtNameObject;
        private TextBox txtIDObject;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button btnEditObject;
        private Button btnSearchObject;
        private Button btnDeleteObject;
        private Button btnResetObject;
        private TextBox txtSearchGradeObject;
        private Button btnSearchGradeObject;
        private Button btnDeleteGradeObject;
        private Button btnResetGradeObject;
        private Button btnEditgradeObject;
        private Button btnAddgradeObject;
        private ComboBox comboBoxPriorityObject;
        private TextBox txtGradeObject;
        private TextBox txtIdGradeObject;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtSearchObjectPriority;
        private ComboBox comboBoxYearObject;
        private Label label11;
        private TextBox txtPolicyPriorityObject;
        private Button btnLoadData;
    }
}