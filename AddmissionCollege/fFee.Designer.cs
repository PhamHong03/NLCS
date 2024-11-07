namespace AddmissionCollege
{
    partial class fFee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fFee));
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            textBox3 = new TextBox();
            btnSearchFee = new Button();
            panel2 = new Panel();
            comboBoxCT = new ComboBox();
            label3 = new Label();
            btnExportFee = new Button();
            btnFeePrint = new Button();
            btnAddFee = new Button();
            btnResetFee = new Button();
            btnDeleteFee = new Button();
            btnEditFee = new Button();
            comboBoxLoadMajor = new ComboBox();
            comboBoxLoadYear = new ComboBox();
            txtFee = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            dataGridViewLoadFee = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoadFee).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.Location = new Point(456, 64);
            label2.Name = "label2";
            label2.Size = new Size(355, 25);
            label2.TabIndex = 3;
            label2.Text = "-------------------------------------------------";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(483, 23);
            label1.Name = "label1";
            label1.Size = new Size(310, 41);
            label1.TabIndex = 2;
            label1.Text = "CẬP NHẬT HỌC PHÍ ";
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(btnSearchFee);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1292, 319);
            panel1.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(881, 88);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Nhập tìm kiếm ";
            textBox3.Size = new Size(257, 43);
            textBox3.TabIndex = 15;
            // 
            // btnSearchFee
            // 
            btnSearchFee.BackColor = Color.Lavender;
            btnSearchFee.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSearchFee.ForeColor = Color.MidnightBlue;
            btnSearchFee.Image = (Image)resources.GetObject("btnSearchFee.Image");
            btnSearchFee.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearchFee.Location = new Point(1144, 88);
            btnSearchFee.Name = "btnSearchFee";
            btnSearchFee.Size = new Size(128, 43);
            btnSearchFee.TabIndex = 15;
            btnSearchFee.Text = "Tìm kiếm ";
            btnSearchFee.TextAlign = ContentAlignment.MiddleRight;
            btnSearchFee.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Azure;
            panel2.Controls.Add(comboBoxCT);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnExportFee);
            panel2.Controls.Add(btnFeePrint);
            panel2.Controls.Add(btnAddFee);
            panel2.Controls.Add(btnResetFee);
            panel2.Controls.Add(btnDeleteFee);
            panel2.Controls.Add(btnEditFee);
            panel2.Controls.Add(comboBoxLoadMajor);
            panel2.Controls.Add(comboBoxLoadYear);
            panel2.Controls.Add(txtFee);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(3, 147);
            panel2.Name = "panel2";
            panel2.Size = new Size(1289, 172);
            panel2.TabIndex = 4;
            // 
            // comboBoxCT
            // 
            comboBoxCT.DisplayMember = "Ten_CT";
            comboBoxCT.FormattingEnabled = true;
            comboBoxCT.Location = new Point(602, 108);
            comboBoxCT.Name = "comboBoxCT";
            comboBoxCT.Size = new Size(252, 28);
            comboBoxCT.TabIndex = 16;
            comboBoxCT.ValueMember = "ID";
            comboBoxCT.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(442, 109);
            label3.Name = "label3";
            label3.Size = new Size(149, 28);
            label3.TabIndex = 15;
            label3.Text = "Chương trình: ";
            // 
            // btnExportFee
            // 
            btnExportFee.BackColor = Color.Lavender;
            btnExportFee.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnExportFee.ForeColor = Color.MidnightBlue;
            btnExportFee.Location = new Point(1174, 102);
            btnExportFee.Name = "btnExportFee";
            btnExportFee.Size = new Size(95, 43);
            btnExportFee.TabIndex = 14;
            btnExportFee.Text = "Xuất file ";
            btnExportFee.UseVisualStyleBackColor = false;
            // 
            // btnFeePrint
            // 
            btnFeePrint.BackColor = Color.Lavender;
            btnFeePrint.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnFeePrint.ForeColor = Color.MidnightBlue;
            btnFeePrint.Location = new Point(1174, 34);
            btnFeePrint.Name = "btnFeePrint";
            btnFeePrint.Size = new Size(95, 43);
            btnFeePrint.TabIndex = 13;
            btnFeePrint.Text = "In file ";
            btnFeePrint.UseVisualStyleBackColor = false;
            // 
            // btnAddFee
            // 
            btnAddFee.BackColor = Color.Lavender;
            btnAddFee.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnAddFee.ForeColor = Color.MidnightBlue;
            btnAddFee.Location = new Point(925, 107);
            btnAddFee.Name = "btnAddFee";
            btnAddFee.Size = new Size(95, 43);
            btnAddFee.TabIndex = 12;
            btnAddFee.Text = "Thêm ";
            btnAddFee.UseVisualStyleBackColor = false;
            btnAddFee.Click += btnAddFee_Click;
            // 
            // btnResetFee
            // 
            btnResetFee.BackColor = Color.Lavender;
            btnResetFee.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnResetFee.ForeColor = Color.MidnightBlue;
            btnResetFee.Location = new Point(1053, 103);
            btnResetFee.Name = "btnResetFee";
            btnResetFee.Size = new Size(95, 43);
            btnResetFee.TabIndex = 11;
            btnResetFee.Text = "Đặt lại ";
            btnResetFee.UseVisualStyleBackColor = false;
            btnResetFee.Click += btnResetFee_Click;
            // 
            // btnDeleteFee
            // 
            btnDeleteFee.BackColor = Color.Lavender;
            btnDeleteFee.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnDeleteFee.ForeColor = Color.MidnightBlue;
            btnDeleteFee.Location = new Point(1053, 35);
            btnDeleteFee.Name = "btnDeleteFee";
            btnDeleteFee.Size = new Size(95, 43);
            btnDeleteFee.TabIndex = 10;
            btnDeleteFee.Text = "Xóa ";
            btnDeleteFee.UseVisualStyleBackColor = false;
            btnDeleteFee.Click += btnDeleteFee_Click;
            // 
            // btnEditFee
            // 
            btnEditFee.BackColor = Color.Lavender;
            btnEditFee.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnEditFee.ForeColor = Color.MidnightBlue;
            btnEditFee.Location = new Point(925, 34);
            btnEditFee.Name = "btnEditFee";
            btnEditFee.Size = new Size(95, 43);
            btnEditFee.TabIndex = 9;
            btnEditFee.Text = "Sửa ";
            btnEditFee.UseVisualStyleBackColor = false;
            btnEditFee.Click += btnEditFee_Click;
            // 
            // comboBoxLoadMajor
            // 
            comboBoxLoadMajor.FormattingEnabled = true;
            comboBoxLoadMajor.Location = new Point(548, 35);
            comboBoxLoadMajor.Name = "comboBoxLoadMajor";
            comboBoxLoadMajor.Size = new Size(306, 28);
            comboBoxLoadMajor.TabIndex = 8;
            // 
            // comboBoxLoadYear
            // 
            comboBoxLoadYear.FormattingEnabled = true;
            comboBoxLoadYear.Location = new Point(206, 113);
            comboBoxLoadYear.Name = "comboBoxLoadYear";
            comboBoxLoadYear.Size = new Size(187, 28);
            comboBoxLoadYear.TabIndex = 7;
            // 
            // txtFee
            // 
            txtFee.Location = new Point(169, 40);
            txtFee.Name = "txtFee";
            txtFee.Size = new Size(183, 27);
            txtFee.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = Color.MidnightBlue;
            label7.Location = new Point(35, 40);
            label7.Name = "label7";
            label7.Size = new Size(96, 28);
            label7.TabIndex = 4;
            label7.Text = "Học phí: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(442, 35);
            label5.Name = "label5";
            label5.Size = new Size(86, 28);
            label5.TabIndex = 2;
            label5.Text = "Ngành: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(35, 113);
            label4.Name = "label4";
            label4.Size = new Size(144, 28);
            label4.TabIndex = 1;
            label4.Text = "Năm học phí: ";
            // 
            // dataGridViewLoadFee
            // 
            dataGridViewLoadFee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLoadFee.BackgroundColor = Color.LavenderBlush;
            dataGridViewLoadFee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLoadFee.Location = new Point(1, 328);
            dataGridViewLoadFee.Name = "dataGridViewLoadFee";
            dataGridViewLoadFee.RowHeadersWidth = 51;
            dataGridViewLoadFee.Size = new Size(1292, 504);
            dataGridViewLoadFee.TabIndex = 5;
            dataGridViewLoadFee.CellClick += dataGridViewLoadFee_CellClick;
            // 
            // fFee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1305, 835);
            Controls.Add(dataGridViewLoadFee);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fFee";
            Text = "fFee";
            Load += fFee_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoadFee).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Label label1;
        private Panel panel1;
        private DataGridView dataGridViewLoadFee;
        private Panel panel2;
        private Label label7;
        private Label label5;
        private Label label4;
        private Button btnEditFee;
        private ComboBox comboBoxLoadMajor;
        private ComboBox comboBoxLoadYear;
        private TextBox txtFee;
        private Button btnSearchFee;
        private Button btnExportFee;
        private Button btnFeePrint;
        private Button btnAddFee;
        private Button btnResetFee;
        private Button btnDeleteFee;
        private TextBox textBox3;
        private ComboBox comboBoxCT;
        private Label label3;
    }
}