namespace AddmissionCollege
{
    partial class fAreaPriority
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAreaPriority));
            panel1 = new Panel();
            panel3 = new Panel();
            dataGridViewLoadGradeArea = new DataGridView();
            panel5 = new Panel();
            comBoBoxYearArea = new ComboBox();
            label11 = new Label();
            txtSearchGradeArea = new TextBox();
            btnSearchGradeArea = new Button();
            btnDeleteGradeArea = new Button();
            btnResetGradeArea = new Button();
            btnEditGradeArea = new Button();
            btnAddGradeArea = new Button();
            comBoboxAreaPriority = new ComboBox();
            txtGradeArea = new TextBox();
            txtIdGradeArea = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            dataGridViewLoadArea = new DataGridView();
            panel4 = new Panel();
            txtDescArea = new TextBox();
            txtSearchArea = new TextBox();
            btnSearchArea = new Button();
            btnDeleteArea = new Button();
            btnResetArea = new Button();
            btnEditArea = new Button();
            btnAddArea = new Button();
            txtNameArea = new TextBox();
            txtIdArea = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoadGradeArea).BeginInit();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoadArea).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1306, 830);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridViewLoadGradeArea);
            panel3.Controls.Add(panel5);
            panel3.Location = new Point(655, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(648, 824);
            panel3.TabIndex = 1;
            // 
            // dataGridViewLoadGradeArea
            // 
            dataGridViewLoadGradeArea.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLoadGradeArea.BackgroundColor = Color.LavenderBlush;
            dataGridViewLoadGradeArea.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewLoadGradeArea.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLoadGradeArea.Location = new Point(0, 406);
            dataGridViewLoadGradeArea.Name = "dataGridViewLoadGradeArea";
            dataGridViewLoadGradeArea.RowHeadersWidth = 51;
            dataGridViewLoadGradeArea.Size = new Size(643, 418);
            dataGridViewLoadGradeArea.TabIndex = 2;
            dataGridViewLoadGradeArea.CellClick += dataGridViewLoadGradeArea_CellClick;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Ivory;
            panel5.Controls.Add(comBoBoxYearArea);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(txtSearchGradeArea);
            panel5.Controls.Add(btnSearchGradeArea);
            panel5.Controls.Add(btnDeleteGradeArea);
            panel5.Controls.Add(btnResetGradeArea);
            panel5.Controls.Add(btnEditGradeArea);
            panel5.Controls.Add(btnAddGradeArea);
            panel5.Controls.Add(comBoboxAreaPriority);
            panel5.Controls.Add(txtGradeArea);
            panel5.Controls.Add(txtIdGradeArea);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(640, 401);
            panel5.TabIndex = 1;
            // 
            // comBoBoxYearArea
            // 
            comBoBoxYearArea.DisplayMember = "NAM";
            comBoBoxYearArea.FormattingEnabled = true;
            comBoBoxYearArea.Location = new Point(92, 114);
            comBoBoxYearArea.Name = "comBoBoxYearArea";
            comBoBoxYearArea.Size = new Size(118, 28);
            comBoBoxYearArea.TabIndex = 45;
            comBoBoxYearArea.ValueMember = "ID";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label11.ForeColor = Color.DarkRed;
            label11.Location = new Point(14, 113);
            label11.Name = "label11";
            label11.Size = new Size(61, 23);
            label11.TabIndex = 44;
            label11.Text = "Năm: ";
            // 
            // txtSearchGradeArea
            // 
            txtSearchGradeArea.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 163);
            txtSearchGradeArea.Location = new Point(250, 104);
            txtSearchGradeArea.Multiline = true;
            txtSearchGradeArea.Name = "txtSearchGradeArea";
            txtSearchGradeArea.PlaceholderText = "Nhập mã hoặc tên";
            txtSearchGradeArea.Size = new Size(240, 41);
            txtSearchGradeArea.TabIndex = 43;
            txtSearchGradeArea.TextChanged += txtSearchGradeArea_TextChanged;
            txtSearchGradeArea.KeyDown += txtSearchGradeArea_KeyDown;
            // 
            // btnSearchGradeArea
            // 
            btnSearchGradeArea.BackColor = Color.Azure;
            btnSearchGradeArea.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnSearchGradeArea.ForeColor = Color.Firebrick;
            btnSearchGradeArea.Image = (Image)resources.GetObject("btnSearchGradeArea.Image");
            btnSearchGradeArea.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearchGradeArea.Location = new Point(507, 99);
            btnSearchGradeArea.Name = "btnSearchGradeArea";
            btnSearchGradeArea.Size = new Size(121, 46);
            btnSearchGradeArea.TabIndex = 42;
            btnSearchGradeArea.Text = "Tìm kiếm ";
            btnSearchGradeArea.TextAlign = ContentAlignment.MiddleRight;
            btnSearchGradeArea.UseVisualStyleBackColor = false;
            // 
            // btnDeleteGradeArea
            // 
            btnDeleteGradeArea.BackColor = Color.Azure;
            btnDeleteGradeArea.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnDeleteGradeArea.ForeColor = Color.Firebrick;
            btnDeleteGradeArea.Location = new Point(340, 341);
            btnDeleteGradeArea.Name = "btnDeleteGradeArea";
            btnDeleteGradeArea.Size = new Size(78, 46);
            btnDeleteGradeArea.TabIndex = 41;
            btnDeleteGradeArea.Text = "Xóa ";
            btnDeleteGradeArea.UseVisualStyleBackColor = false;
            btnDeleteGradeArea.Click += btnDeleteGradeArea_Click;
            // 
            // btnResetGradeArea
            // 
            btnResetGradeArea.BackColor = Color.Azure;
            btnResetGradeArea.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnResetGradeArea.ForeColor = Color.Firebrick;
            btnResetGradeArea.Location = new Point(457, 341);
            btnResetGradeArea.Name = "btnResetGradeArea";
            btnResetGradeArea.Size = new Size(78, 46);
            btnResetGradeArea.TabIndex = 40;
            btnResetGradeArea.Text = "Đặt lại ";
            btnResetGradeArea.UseVisualStyleBackColor = false;
            btnResetGradeArea.Click += btnResetGradeArea_Click;
            // 
            // btnEditGradeArea
            // 
            btnEditGradeArea.BackColor = Color.Azure;
            btnEditGradeArea.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnEditGradeArea.ForeColor = Color.Firebrick;
            btnEditGradeArea.Location = new Point(214, 341);
            btnEditGradeArea.Name = "btnEditGradeArea";
            btnEditGradeArea.Size = new Size(78, 46);
            btnEditGradeArea.TabIndex = 39;
            btnEditGradeArea.Text = "Sửa ";
            btnEditGradeArea.UseVisualStyleBackColor = false;
            btnEditGradeArea.Click += btnEditGradeArea_Click;
            // 
            // btnAddGradeArea
            // 
            btnAddGradeArea.BackColor = Color.Azure;
            btnAddGradeArea.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnAddGradeArea.ForeColor = Color.Firebrick;
            btnAddGradeArea.Location = new Point(92, 341);
            btnAddGradeArea.Name = "btnAddGradeArea";
            btnAddGradeArea.Size = new Size(78, 46);
            btnAddGradeArea.TabIndex = 38;
            btnAddGradeArea.Text = "Thêm ";
            btnAddGradeArea.UseVisualStyleBackColor = false;
            btnAddGradeArea.Click += btnAddGradeArea_Click;
            // 
            // comBoboxAreaPriority
            // 
            comBoboxAreaPriority.DisplayMember = "Ten_KV";
            comBoboxAreaPriority.FormattingEnabled = true;
            comBoboxAreaPriority.Location = new Point(250, 285);
            comBoboxAreaPriority.Name = "comBoboxAreaPriority";
            comBoboxAreaPriority.Size = new Size(285, 28);
            comBoboxAreaPriority.TabIndex = 37;
            // 
            // txtGradeArea
            // 
            txtGradeArea.Location = new Point(250, 229);
            txtGradeArea.Name = "txtGradeArea";
            txtGradeArea.Size = new Size(285, 27);
            txtGradeArea.TabIndex = 36;
            // 
            // txtIdGradeArea
            // 
            txtIdGradeArea.Location = new Point(250, 176);
            txtIdGradeArea.Name = "txtIdGradeArea";
            txtIdGradeArea.ReadOnly = true;
            txtIdGradeArea.Size = new Size(285, 27);
            txtIdGradeArea.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label8.ForeColor = Color.DarkRed;
            label8.Location = new Point(79, 288);
            label8.Name = "label8";
            label8.Size = new Size(112, 25);
            label8.TabIndex = 34;
            label8.Text = "Khu vực: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label9.ForeColor = Color.DarkRed;
            label9.Location = new Point(79, 231);
            label9.Name = "label9";
            label9.Size = new Size(153, 25);
            label9.TabIndex = 33;
            label9.Text = "Điểm ưu tiên: ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label10.ForeColor = Color.DarkRed;
            label10.Location = new Point(79, 175);
            label10.Name = "label10";
            label10.Size = new Size(176, 25);
            label10.TabIndex = 32;
            label10.Text = "Mã KV ưu tiên: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.ForeColor = Color.Firebrick;
            label4.Location = new Point(157, 52);
            label4.Name = "label4";
            label4.Size = new Size(364, 28);
            label4.TabIndex = 31;
            label4.Text = "--------------------------------------------";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            label3.ForeColor = Color.HotPink;
            label3.Location = new Point(171, 14);
            label3.Name = "label3";
            label3.Size = new Size(391, 35);
            label3.TabIndex = 30;
            label3.Text = "ĐIỂM KHU VỰC ƯU TIÊN ";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridViewLoadArea);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(649, 823);
            panel2.TabIndex = 0;
            // 
            // dataGridViewLoadArea
            // 
            dataGridViewLoadArea.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLoadArea.BackgroundColor = Color.LavenderBlush;
            dataGridViewLoadArea.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLoadArea.Location = new Point(0, 405);
            dataGridViewLoadArea.Name = "dataGridViewLoadArea";
            dataGridViewLoadArea.RowHeadersWidth = 51;
            dataGridViewLoadArea.Size = new Size(646, 415);
            dataGridViewLoadArea.TabIndex = 1;
            dataGridViewLoadArea.CellClick += dataGridViewLoadArea_CellClick;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Azure;
            panel4.Controls.Add(txtDescArea);
            panel4.Controls.Add(txtSearchArea);
            panel4.Controls.Add(btnSearchArea);
            panel4.Controls.Add(btnDeleteArea);
            panel4.Controls.Add(btnResetArea);
            panel4.Controls.Add(btnEditArea);
            panel4.Controls.Add(btnAddArea);
            panel4.Controls.Add(txtNameArea);
            panel4.Controls.Add(txtIdArea);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(3, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(647, 401);
            panel4.TabIndex = 0;
            // 
            // txtDescArea
            // 
            txtDescArea.Location = new Point(200, 277);
            txtDescArea.Name = "txtDescArea";
            txtDescArea.Size = new Size(307, 27);
            txtDescArea.TabIndex = 29;
            // 
            // txtSearchArea
            // 
            txtSearchArea.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 163);
            txtSearchArea.Location = new Point(200, 102);
            txtSearchArea.Multiline = true;
            txtSearchArea.Name = "txtSearchArea";
            txtSearchArea.PlaceholderText = "Nhập mã hoặc tên";
            txtSearchArea.Size = new Size(307, 41);
            txtSearchArea.TabIndex = 28;
            txtSearchArea.KeyDown += txtSearchArea_KeyDown;
            // 
            // btnSearchArea
            // 
            btnSearchArea.BackColor = Color.Ivory;
            btnSearchArea.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnSearchArea.ForeColor = Color.SaddleBrown;
            btnSearchArea.Image = (Image)resources.GetObject("btnSearchArea.Image");
            btnSearchArea.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearchArea.Location = new Point(513, 100);
            btnSearchArea.Name = "btnSearchArea";
            btnSearchArea.Size = new Size(130, 46);
            btnSearchArea.TabIndex = 27;
            btnSearchArea.Text = "Tìm kiếm ";
            btnSearchArea.TextAlign = ContentAlignment.MiddleRight;
            btnSearchArea.UseVisualStyleBackColor = false;
            // 
            // btnDeleteArea
            // 
            btnDeleteArea.BackColor = Color.Ivory;
            btnDeleteArea.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnDeleteArea.ForeColor = Color.SaddleBrown;
            btnDeleteArea.Location = new Point(293, 343);
            btnDeleteArea.Name = "btnDeleteArea";
            btnDeleteArea.Size = new Size(78, 46);
            btnDeleteArea.TabIndex = 26;
            btnDeleteArea.Text = "Xóa ";
            btnDeleteArea.UseVisualStyleBackColor = false;
            btnDeleteArea.Click += btnDeleteArea_Click;
            // 
            // btnResetArea
            // 
            btnResetArea.BackColor = Color.Ivory;
            btnResetArea.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnResetArea.ForeColor = Color.SaddleBrown;
            btnResetArea.Location = new Point(420, 339);
            btnResetArea.Name = "btnResetArea";
            btnResetArea.Size = new Size(78, 46);
            btnResetArea.TabIndex = 25;
            btnResetArea.Text = "Đặt lại ";
            btnResetArea.UseVisualStyleBackColor = false;
            btnResetArea.Click += btnResetArea_Click;
            // 
            // btnEditArea
            // 
            btnEditArea.BackColor = Color.Ivory;
            btnEditArea.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnEditArea.ForeColor = Color.SaddleBrown;
            btnEditArea.Location = new Point(180, 342);
            btnEditArea.Name = "btnEditArea";
            btnEditArea.Size = new Size(78, 46);
            btnEditArea.TabIndex = 24;
            btnEditArea.Text = "Sửa ";
            btnEditArea.UseVisualStyleBackColor = false;
            btnEditArea.Click += btnEditArea_Click;
            // 
            // btnAddArea
            // 
            btnAddArea.BackColor = Color.Ivory;
            btnAddArea.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnAddArea.ForeColor = Color.SaddleBrown;
            btnAddArea.Location = new Point(62, 342);
            btnAddArea.Name = "btnAddArea";
            btnAddArea.Size = new Size(78, 46);
            btnAddArea.TabIndex = 23;
            btnAddArea.Text = "Thêm ";
            btnAddArea.UseVisualStyleBackColor = false;
            btnAddArea.Click += btnAddArea_Click;
            // 
            // txtNameArea
            // 
            txtNameArea.Location = new Point(200, 220);
            txtNameArea.Name = "txtNameArea";
            txtNameArea.Size = new Size(307, 27);
            txtNameArea.TabIndex = 22;
            // 
            // txtIdArea
            // 
            txtIdArea.Location = new Point(200, 164);
            txtIdArea.Name = "txtIdArea";
            txtIdArea.ReadOnly = true;
            txtIdArea.Size = new Size(307, 27);
            txtIdArea.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label7.ForeColor = Color.DarkRed;
            label7.Location = new Point(45, 276);
            label7.Name = "label7";
            label7.Size = new Size(87, 25);
            label7.TabIndex = 20;
            label7.Text = "Mô tả: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label6.ForeColor = Color.DarkRed;
            label6.Location = new Point(42, 222);
            label6.Name = "label6";
            label6.Size = new Size(150, 25);
            label6.TabIndex = 19;
            label6.Text = "Tên khu vực: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label5.ForeColor = Color.DarkRed;
            label5.Location = new Point(45, 162);
            label5.Name = "label5";
            label5.Size = new Size(147, 25);
            label5.TabIndex = 18;
            label5.Text = "Mã khu vực: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(135, 58);
            label2.Name = "label2";
            label2.Size = new Size(348, 28);
            label2.TabIndex = 1;
            label2.Text = "------------------------------------------";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(180, 20);
            label1.Name = "label1";
            label1.Size = new Size(301, 35);
            label1.TabIndex = 0;
            label1.Text = "KHU VỰC ƯU TIÊN ";
            // 
            // fAreaPriority
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1300, 829);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "fAreaPriority";
            Text = "AreaPriority";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoadGradeArea).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoadArea).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private DataGridView dataGridViewLoadGradeArea;
        private Panel panel5;
        private DataGridView dataGridViewLoadArea;
        private Panel panel4;
        private Label label1;
        private Label label2;
        private TextBox txtDescArea;
        private TextBox txtSearchArea;
        private Button btnSearchArea;
        private Button btnDeleteArea;
        private Button btnResetArea;
        private Button btnEditArea;
        private Button btnAddArea;
        private TextBox txtNameArea;
        private TextBox txtIdArea;
        private Label label7;
        private Label label6;
        private Label label5;
        private ComboBox comBoBoxYearArea;
        private Label label11;
        private TextBox txtSearchGradeArea;
        private Button btnSearchGradeArea;
        private Button btnDeleteGradeArea;
        private Button btnResetGradeArea;
        private Button btnEditGradeArea;
        private Button btnAddGradeArea;
        private ComboBox comBoboxAreaPriority;
        private TextBox txtGradeArea;
        private TextBox txtIdGradeArea;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label4;
        private Label label3;
    }
}