namespace AddmissionCollege
{
    partial class fAddmission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAddmission));
            txtSearchAddmision = new TextBox();
            btnSearchAddmision = new Button();
            label1 = new Label();
            label2 = new Label();
            groupBoxAddmison = new GroupBox();
            btnExportAddmison = new Button();
            btnPrintAddmision = new Button();
            btnAddAddmision = new Button();
            btnResetResetAdmision = new Button();
            btnDeleteAddmision = new Button();
            btnEditAddmision = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            comboBoxLoadMethodAdm = new ComboBox();
            label4 = new Label();
            comboBoxLoadMajorAdm = new ComboBox();
            label3 = new Label();
            dataGridViewLoadAddmission = new DataGridView();
            label7 = new Label();
            comboBoxLoadYearAdm = new ComboBox();
            groupBoxAddmison.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoadAddmission).BeginInit();
            SuspendLayout();
            // 
            // txtSearchAddmision
            // 
            txtSearchAddmision.Location = new Point(882, 78);
            txtSearchAddmision.Multiline = true;
            txtSearchAddmision.Name = "txtSearchAddmision";
            txtSearchAddmision.PlaceholderText = "Nhập tìm kiếm ";
            txtSearchAddmision.Size = new Size(257, 43);
            txtSearchAddmision.TabIndex = 18;
            // 
            // btnSearchAddmision
            // 
            btnSearchAddmision.BackColor = Color.Lavender;
            btnSearchAddmision.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSearchAddmision.ForeColor = Color.MidnightBlue;
            btnSearchAddmision.Image = (Image)resources.GetObject("btnSearchAddmision.Image");
            btnSearchAddmision.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearchAddmision.Location = new Point(1145, 78);
            btnSearchAddmision.Name = "btnSearchAddmision";
            btnSearchAddmision.Size = new Size(128, 43);
            btnSearchAddmision.TabIndex = 19;
            btnSearchAddmision.Text = "Tìm kiếm ";
            btnSearchAddmision.TextAlign = ContentAlignment.MiddleRight;
            btnSearchAddmision.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(550, 9);
            label1.Name = "label1";
            label1.Size = new Size(186, 41);
            label1.TabIndex = 16;
            label1.Text = "XÉT TUYỂN ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.Location = new Point(472, 50);
            label2.Name = "label2";
            label2.Size = new Size(355, 25);
            label2.TabIndex = 17;
            label2.Text = "-------------------------------------------------";
            // 
            // groupBoxAddmison
            // 
            groupBoxAddmison.BackColor = Color.AliceBlue;
            groupBoxAddmison.Controls.Add(btnExportAddmison);
            groupBoxAddmison.Controls.Add(btnPrintAddmision);
            groupBoxAddmison.Controls.Add(btnAddAddmision);
            groupBoxAddmison.Controls.Add(btnResetResetAdmision);
            groupBoxAddmison.Controls.Add(btnDeleteAddmision);
            groupBoxAddmison.Controls.Add(btnEditAddmision);
            groupBoxAddmison.Controls.Add(textBox2);
            groupBoxAddmison.Controls.Add(textBox1);
            groupBoxAddmison.Controls.Add(label6);
            groupBoxAddmison.Controls.Add(label5);
            groupBoxAddmison.Controls.Add(comboBoxLoadMethodAdm);
            groupBoxAddmison.Controls.Add(label4);
            groupBoxAddmison.Controls.Add(comboBoxLoadMajorAdm);
            groupBoxAddmison.Controls.Add(label3);
            groupBoxAddmison.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBoxAddmison.ForeColor = Color.DarkBlue;
            groupBoxAddmison.Location = new Point(6, 127);
            groupBoxAddmison.Name = "groupBoxAddmison";
            groupBoxAddmison.Size = new Size(1294, 144);
            groupBoxAddmison.TabIndex = 20;
            groupBoxAddmison.TabStop = false;
            groupBoxAddmison.Text = "Thông tin xét tuyển ";
//            groupBoxAddmison.Enter += groupBoxAddmison_Enter;
            // 
            // btnExportAddmison
            // 
            btnExportAddmison.BackColor = Color.Lavender;
            btnExportAddmison.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnExportAddmison.ForeColor = Color.MidnightBlue;
            btnExportAddmison.Location = new Point(1181, 84);
            btnExportAddmison.Name = "btnExportAddmison";
            btnExportAddmison.Size = new Size(95, 43);
            btnExportAddmison.TabIndex = 20;
            btnExportAddmison.Text = "Xuất file ";
            btnExportAddmison.UseVisualStyleBackColor = false;
            // 
            // btnPrintAddmision
            // 
            btnPrintAddmision.BackColor = Color.Lavender;
            btnPrintAddmision.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnPrintAddmision.ForeColor = Color.MidnightBlue;
            btnPrintAddmision.Location = new Point(1181, 15);
            btnPrintAddmision.Name = "btnPrintAddmision";
            btnPrintAddmision.Size = new Size(95, 43);
            btnPrintAddmision.TabIndex = 19;
            btnPrintAddmision.Text = "In file ";
            btnPrintAddmision.UseVisualStyleBackColor = false;
            //btnPrintAddmision.Click += btnPrintAddmision_Click;
            // 
            // btnAddAddmision
            // 
            btnAddAddmision.BackColor = Color.Lavender;
            btnAddAddmision.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnAddAddmision.ForeColor = Color.MidnightBlue;
            btnAddAddmision.Location = new Point(880, 88);
            btnAddAddmision.Name = "btnAddAddmision";
            btnAddAddmision.Size = new Size(95, 43);
            btnAddAddmision.TabIndex = 18;
            btnAddAddmision.Text = "Thêm ";
            btnAddAddmision.UseVisualStyleBackColor = false;
            // 
            // btnResetResetAdmision
            // 
            btnResetResetAdmision.BackColor = Color.Lavender;
            btnResetResetAdmision.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnResetResetAdmision.ForeColor = Color.MidnightBlue;
            btnResetResetAdmision.Location = new Point(1034, 83);
            btnResetResetAdmision.Name = "btnResetResetAdmision";
            btnResetResetAdmision.Size = new Size(95, 43);
            btnResetResetAdmision.TabIndex = 17;
            btnResetResetAdmision.Text = "Đặt lại ";
            btnResetResetAdmision.UseVisualStyleBackColor = false;
            // 
            // btnDeleteAddmision
            // 
            btnDeleteAddmision.BackColor = Color.Lavender;
            btnDeleteAddmision.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnDeleteAddmision.ForeColor = Color.MidnightBlue;
            btnDeleteAddmision.Location = new Point(1034, 15);
            btnDeleteAddmision.Name = "btnDeleteAddmision";
            btnDeleteAddmision.Size = new Size(95, 43);
            btnDeleteAddmision.TabIndex = 16;
            btnDeleteAddmision.Text = "Xóa ";
            btnDeleteAddmision.UseVisualStyleBackColor = false;
            // 
            // btnEditAddmision
            // 
            btnEditAddmision.BackColor = Color.Lavender;
            btnEditAddmision.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnEditAddmision.ForeColor = Color.MidnightBlue;
            btnEditAddmision.Location = new Point(880, 15);
            btnEditAddmision.Name = "btnEditAddmision";
            btnEditAddmision.Size = new Size(95, 43);
            btnEditAddmision.TabIndex = 15;
            btnEditAddmision.Text = "Sửa ";
            btnEditAddmision.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(671, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 30);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(624, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(197, 30);
            textBox1.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label6.Location = new Point(510, 101);
            label6.Name = "label6";
            label6.Size = new Size(155, 22);
            label6.TabIndex = 5;
            label6.Text = "Điểm trúng tuyển: ";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            //label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label5.Location = new Point(510, 49);
            label5.Name = "label5";
            label5.Size = new Size(83, 22);
            label5.TabIndex = 4;
            label5.Text = "Chỉ tiêu: ";
            // 
            // comboBoxLoadMethodAdm
            // 
            comboBoxLoadMethodAdm.DisplayMember = "TEN_CT";
            comboBoxLoadMethodAdm.Font = new Font("Times New Roman", 12F);
            comboBoxLoadMethodAdm.FormattingEnabled = true;
            comboBoxLoadMethodAdm.Location = new Point(179, 93);
            comboBoxLoadMethodAdm.Name = "comboBoxLoadMethodAdm";
            comboBoxLoadMethodAdm.Size = new Size(272, 30);
            comboBoxLoadMethodAdm.TabIndex = 3;
            comboBoxLoadMethodAdm.ValueMember = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label4.Location = new Point(53, 101);
            label4.Name = "label4";
            label4.Size = new Size(120, 22);
            label4.TabIndex = 2;
            label4.Text = "Phương thức: ";
            // 
            // comboBoxLoadMajorAdm
            // 
            comboBoxLoadMajorAdm.DisplayMember = "TEN_NGANH";
            comboBoxLoadMajorAdm.Font = new Font("Times New Roman", 12F);
            comboBoxLoadMajorAdm.FormattingEnabled = true;
            comboBoxLoadMajorAdm.Location = new Point(130, 41);
            comboBoxLoadMajorAdm.Name = "comboBoxLoadMajorAdm";
            comboBoxLoadMajorAdm.Size = new Size(321, 30);
            comboBoxLoadMajorAdm.TabIndex = 1;
            comboBoxLoadMajorAdm.ValueMember = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label3.Location = new Point(53, 49);
            label3.Name = "label3";
            label3.Size = new Size(71, 22);
            label3.TabIndex = 0;
            label3.Text = "Ngành: ";
            // 
            // dataGridViewLoadAddmission
            // 
            dataGridViewLoadAddmission.BackgroundColor = Color.LavenderBlush;
            dataGridViewLoadAddmission.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLoadAddmission.Location = new Point(8, 277);
            dataGridViewLoadAddmission.Name = "dataGridViewLoadAddmission";
            dataGridViewLoadAddmission.RowHeadersWidth = 51;
            dataGridViewLoadAddmission.Size = new Size(1292, 552);
            dataGridViewLoadAddmission.TabIndex = 21;
            //dataGridViewLoadAddmission.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label7.ForeColor = Color.DarkBlue;
            label7.Location = new Point(21, 78);
            label7.Name = "label7";
            label7.Size = new Size(58, 22);
            label7.TabIndex = 21;
            label7.Text = "Năm: ";
           // label7.Click += label7_Click;
            // 
            // comboBoxLoadYearAdm
            // 
            comboBoxLoadYearAdm.DisplayMember = "NAM";
            comboBoxLoadYearAdm.Font = new Font("Times New Roman", 12F);
            comboBoxLoadYearAdm.FormattingEnabled = true;
            comboBoxLoadYearAdm.Location = new Point(85, 70);
            comboBoxLoadYearAdm.Name = "comboBoxLoadYearAdm";
            comboBoxLoadYearAdm.Size = new Size(174, 30);
            comboBoxLoadYearAdm.TabIndex = 21;
            comboBoxLoadYearAdm.ValueMember = "ID";
            // 
            // fAddmission
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1307, 841);
            Controls.Add(comboBoxLoadYearAdm);
            Controls.Add(label7);
            Controls.Add(dataGridViewLoadAddmission);
            Controls.Add(groupBoxAddmison);
            Controls.Add(txtSearchAddmision);
            Controls.Add(btnSearchAddmision);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fAddmission";
            Text = "fAddmission";
            groupBoxAddmison.ResumeLayout(false);
            groupBoxAddmison.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoadAddmission).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearchAddmision;
        private Button btnSearchAddmision;
        private Label label1;
        private Label label2;
        private GroupBox groupBoxAddmison;
        private DataGridView dataGridViewLoadAddmission;
        private ComboBox comboBoxLoadMethodAdm;
        private Label label4;
        private ComboBox comboBoxLoadMajorAdm;
        private Label label3;
        private Label label6;
        private Label label5;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button btnExportAddmison;
        private Button btnPrintAddmision;
        private Button btnAddAddmision;
        private Button btnResetResetAdmision;
        private Button btnDeleteAddmision;
        private Button btnEditAddmision;
        private Label label7;
        private ComboBox comboBoxLoadYearAdm;
    }
}