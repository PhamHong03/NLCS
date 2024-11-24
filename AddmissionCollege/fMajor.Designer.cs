namespace AddmissionCollege
{
    partial class fMajor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMajor));
            button1 = new Button();
            panel1 = new Panel();
            dataGridViewLoadMajor = new DataGridView();
            panel3 = new Panel();
            btnExportMajor = new Button();
            btnPrintMajor = new Button();
            txtTrainTimeMajor = new TextBox();
            label7 = new Label();
            btnResetMajor = new Button();
            btnAddMajor = new Button();
            btnDeleteMajor = new Button();
            comboBoxCurriculum = new ComboBox();
            btnEditMajor = new Button();
            label5 = new Label();
            txtIdMajor = new TextBox();
            label6 = new Label();
            txtNameMajor = new TextBox();
            label4 = new Label();
            txtSearchMajor = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoadMajor).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LavenderBlush;
            button1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            button1.ForeColor = Color.DarkBlue;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(1123, 98);
            button1.Name = "button1";
            button1.Size = new Size(161, 44);
            button1.TabIndex = 0;
            button1.Text = "Tìm kiếm ";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dataGridViewLoadMajor);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(txtSearchMajor);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1294, 817);
            panel1.TabIndex = 1;
            // 
            // dataGridViewLoadMajor
            // 
            dataGridViewLoadMajor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLoadMajor.BackgroundColor = Color.LavenderBlush;
            dataGridViewLoadMajor.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewLoadMajor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLoadMajor.Location = new Point(9, 324);
            dataGridViewLoadMajor.Name = "dataGridViewLoadMajor";
            dataGridViewLoadMajor.RowHeadersWidth = 51;
            dataGridViewLoadMajor.Size = new Size(1282, 485);
            dataGridViewLoadMajor.TabIndex = 0;
            dataGridViewLoadMajor.CellClick += dataGridViewLoadMajor_CellClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.AliceBlue;
            panel3.Controls.Add(btnExportMajor);
            panel3.Controls.Add(btnPrintMajor);
            panel3.Controls.Add(txtTrainTimeMajor);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(btnResetMajor);
            panel3.Controls.Add(btnAddMajor);
            panel3.Controls.Add(btnDeleteMajor);
            panel3.Controls.Add(comboBoxCurriculum);
            panel3.Controls.Add(btnEditMajor);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(txtIdMajor);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(txtNameMajor);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(7, 148);
            panel3.Name = "panel3";
            panel3.Size = new Size(1284, 170);
            panel3.TabIndex = 9;
            // 
            // btnExportMajor
            // 
            btnExportMajor.BackColor = Color.LavenderBlush;
            btnExportMajor.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnExportMajor.ForeColor = Color.DarkBlue;
            btnExportMajor.Location = new Point(1169, 26);
            btnExportMajor.Name = "btnExportMajor";
            btnExportMajor.Size = new Size(108, 45);
            btnExportMajor.TabIndex = 19;
            btnExportMajor.Text = "Xuất";
            btnExportMajor.UseVisualStyleBackColor = false;
            // 
            // btnPrintMajor
            // 
            btnPrintMajor.BackColor = Color.LavenderBlush;
            btnPrintMajor.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnPrintMajor.ForeColor = Color.DarkBlue;
            btnPrintMajor.Location = new Point(1169, 97);
            btnPrintMajor.Name = "btnPrintMajor";
            btnPrintMajor.Size = new Size(108, 45);
            btnPrintMajor.TabIndex = 18;
            btnPrintMajor.Text = "In file ";
            btnPrintMajor.UseVisualStyleBackColor = false;
            btnPrintMajor.Click += btnPrintMajor_Click;
            // 
            // txtTrainTimeMajor
            // 
            txtTrainTimeMajor.Location = new Point(654, 87);
            txtTrainTimeMajor.Multiline = true;
            txtTrainTimeMajor.Name = "txtTrainTimeMajor";
            txtTrainTimeMajor.PlaceholderText = "Nhập thời gian dào tạo ";
            txtTrainTimeMajor.Size = new Size(246, 48);
            txtTrainTimeMajor.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label7.ForeColor = Color.DarkBlue;
            label7.Location = new Point(434, 97);
            label7.Name = "label7";
            label7.Size = new Size(201, 25);
            label7.TabIndex = 16;
            label7.Text = "Thời gian đào tạo: ";
            // 
            // btnResetMajor
            // 
            btnResetMajor.BackColor = Color.LavenderBlush;
            btnResetMajor.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnResetMajor.ForeColor = Color.DarkBlue;
            btnResetMajor.Location = new Point(1045, 26);
            btnResetMajor.Name = "btnResetMajor";
            btnResetMajor.Size = new Size(108, 45);
            btnResetMajor.TabIndex = 15;
            btnResetMajor.Text = "Đặt lại ";
            btnResetMajor.UseVisualStyleBackColor = false;
            btnResetMajor.Click += btnResetMajor_Click;
            // 
            // btnAddMajor
            // 
            btnAddMajor.BackColor = Color.LavenderBlush;
            btnAddMajor.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnAddMajor.ForeColor = Color.DarkBlue;
            btnAddMajor.Location = new Point(1045, 97);
            btnAddMajor.Name = "btnAddMajor";
            btnAddMajor.Size = new Size(108, 45);
            btnAddMajor.TabIndex = 14;
            btnAddMajor.Text = "Thêm  ";
            btnAddMajor.UseVisualStyleBackColor = false;
            btnAddMajor.Click += btnAddMajor_Click;
            // 
            // btnDeleteMajor
            // 
            btnDeleteMajor.BackColor = Color.LavenderBlush;
            btnDeleteMajor.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnDeleteMajor.ForeColor = Color.DarkBlue;
            btnDeleteMajor.Location = new Point(921, 26);
            btnDeleteMajor.Name = "btnDeleteMajor";
            btnDeleteMajor.Size = new Size(108, 46);
            btnDeleteMajor.TabIndex = 8;
            btnDeleteMajor.Text = "Xóa ";
            btnDeleteMajor.UseVisualStyleBackColor = false;
            btnDeleteMajor.Click += btnDeleteMajor_Click;
            // 
            // comboBoxCurriculum
            // 
            comboBoxCurriculum.DisplayMember = "Ten_CT";
            comboBoxCurriculum.FormattingEnabled = true;
            comboBoxCurriculum.Items.AddRange(new object[] { "Chương trình đại trà", "Chương trình tiên tiến", "Chương trình chất lượng cao" });
            comboBoxCurriculum.Location = new Point(610, 32);
            comboBoxCurriculum.Name = "comboBoxCurriculum";
            comboBoxCurriculum.Size = new Size(290, 28);
            comboBoxCurriculum.TabIndex = 13;
            comboBoxCurriculum.ValueMember = "ID";
            // 
            // btnEditMajor
            // 
            btnEditMajor.BackColor = Color.LavenderBlush;
            btnEditMajor.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnEditMajor.ForeColor = Color.DarkBlue;
            btnEditMajor.Location = new Point(921, 98);
            btnEditMajor.Name = "btnEditMajor";
            btnEditMajor.Size = new Size(108, 45);
            btnEditMajor.TabIndex = 7;
            btnEditMajor.Text = "Sửa ";
            btnEditMajor.UseVisualStyleBackColor = false;
            btnEditMajor.Click += btnEditMajor_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label5.ForeColor = Color.DarkBlue;
            label5.Location = new Point(16, 91);
            label5.Name = "label5";
            label5.Size = new Size(127, 25);
            label5.TabIndex = 9;
            label5.Text = "Tên ngành:";
            // 
            // txtIdMajor
            // 
            txtIdMajor.Location = new Point(153, 16);
            txtIdMajor.Multiline = true;
            txtIdMajor.Name = "txtIdMajor";
            txtIdMajor.PlaceholderText = "Nhập mã ngành ";
            txtIdMajor.Size = new Size(261, 41);
            txtIdMajor.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label6.ForeColor = Color.DarkBlue;
            label6.Location = new Point(434, 32);
            label6.Name = "label6";
            label6.Size = new Size(164, 25);
            label6.TabIndex = 12;
            label6.Text = "Chương trình: ";
            // 
            // txtNameMajor
            // 
            txtNameMajor.Location = new Point(153, 81);
            txtNameMajor.Multiline = true;
            txtNameMajor.Name = "txtNameMajor";
            txtNameMajor.PlaceholderText = "Nhập tên ngành ";
            txtNameMajor.Size = new Size(261, 48);
            txtNameMajor.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label4.ForeColor = Color.DarkBlue;
            label4.Location = new Point(16, 26);
            label4.Name = "label4";
            label4.Size = new Size(130, 25);
            label4.TabIndex = 5;
            label4.Text = "Mã ngành: ";
            // 
            // txtSearchMajor
            // 
            txtSearchMajor.Location = new Point(791, 99);
            txtSearchMajor.Multiline = true;
            txtSearchMajor.Name = "txtSearchMajor";
            txtSearchMajor.PlaceholderText = "Nhập mã ngành ";
            txtSearchMajor.Size = new Size(326, 43);
            txtSearchMajor.TabIndex = 6;
            txtSearchMajor.KeyDown += txtSearchMajor_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(444, 60);
            label2.Name = "label2";
            label2.Size = new Size(411, 25);
            label2.TabIndex = 2;
            label2.Text = "---------------------------------------------------------";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(500, 19);
            label1.Name = "label1";
            label1.Size = new Size(299, 41);
            label1.TabIndex = 1;
            label1.Text = "CẬP NHẬT NGÀNH ";
            // 
            // fMajor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1301, 826);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fMajor";
            Text = "fMajor";
            Load += fMajor_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoadMajor).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txtSearchMajor;
        private Label label4;
        private Button btnEditMajor;
        private Button btnDeleteMajor;
        private TextBox txtNameMajor;
        private TextBox txtIdMajor;
        private Label label5;
        private Label label6;
        private Panel panel3;
        private Button btnAddMajor;
        private ComboBox comboBoxCurriculum;
        private DataGridView dataGridViewLoadMajor;
        private Button btnResetMajor;
        private TextBox txtTrainTimeMajor;
        private Label label7;
        private Button btnExportMajor;
        private Button btnPrintMajor;
    }
}