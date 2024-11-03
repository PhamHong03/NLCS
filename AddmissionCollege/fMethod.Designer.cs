namespace AddmissionCollege
{
    partial class fMethod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMethod));
            panel1 = new Panel();
            txtSearchMethod = new TextBox();
            panel3 = new Panel();
            txtDescMethod = new TextBox();
            label3 = new Label();
            btnResetMethod = new Button();
            btnDeleteMethod = new Button();
            btnEditMethod = new Button();
            btnAddMethod = new Button();
            txtNameMethod = new TextBox();
            label5 = new Label();
            txtIdMethod = new TextBox();
            label4 = new Label();
            label2 = new Label();
            btnSearchMethod = new Button();
            label1 = new Label();
            panel2 = new Panel();
            dataGridViewLoadMethod = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoadMethod).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtSearchMethod);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnSearchMethod);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1297, 428);
            panel1.TabIndex = 0;
            // 
            // txtSearchMethod
            // 
            txtSearchMethod.Location = new Point(715, 114);
            txtSearchMethod.Multiline = true;
            txtSearchMethod.Name = "txtSearchMethod";
            txtSearchMethod.PlaceholderText = "Nhập mã phương thức ";
            txtSearchMethod.Size = new Size(393, 54);
            txtSearchMethod.TabIndex = 8;
            txtSearchMethod.KeyDown += txtSearchMethod_KeyDown;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Azure;
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(txtDescMethod);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(btnResetMethod);
            panel3.Controls.Add(btnDeleteMethod);
            panel3.Controls.Add(btnEditMethod);
            panel3.Controls.Add(btnAddMethod);
            panel3.Controls.Add(txtNameMethod);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(txtIdMethod);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(6, 196);
            panel3.Name = "panel3";
            panel3.Size = new Size(1291, 225);
            panel3.TabIndex = 2;
            // 
            // txtDescMethod
            // 
            txtDescMethod.Location = new Point(642, 23);
            txtDescMethod.Multiline = true;
            txtDescMethod.Name = "txtDescMethod";
            txtDescMethod.PlaceholderText = "Nhập mô tả phương thức ";
            txtDescMethod.Size = new Size(284, 45);
            txtDescMethod.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(535, 37);
            label3.Name = "label3";
            label3.Size = new Size(89, 31);
            label3.TabIndex = 19;
            label3.Text = "Mô tả: ";
            // 
            // btnResetMethod
            // 
            btnResetMethod.BackColor = Color.LavenderBlush;
            btnResetMethod.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnResetMethod.ForeColor = Color.Teal;
            btnResetMethod.Location = new Point(1144, 39);
            btnResetMethod.Name = "btnResetMethod";
            btnResetMethod.Size = new Size(130, 58);
            btnResetMethod.TabIndex = 18;
            btnResetMethod.Text = "Đặt lại ";
            btnResetMethod.UseVisualStyleBackColor = false;
            btnResetMethod.Click += btnResetMethod_Click;
            // 
            // btnDeleteMethod
            // 
            btnDeleteMethod.BackColor = Color.LavenderBlush;
            btnDeleteMethod.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnDeleteMethod.ForeColor = Color.Teal;
            btnDeleteMethod.Location = new Point(986, 39);
            btnDeleteMethod.Name = "btnDeleteMethod";
            btnDeleteMethod.Size = new Size(130, 58);
            btnDeleteMethod.TabIndex = 17;
            btnDeleteMethod.Text = "Xóa ";
            btnDeleteMethod.UseVisualStyleBackColor = false;
            btnDeleteMethod.Click += btnDeleteMethod_Click;
            // 
            // btnEditMethod
            // 
            btnEditMethod.BackColor = Color.LavenderBlush;
            btnEditMethod.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnEditMethod.ForeColor = Color.Teal;
            btnEditMethod.Location = new Point(986, 128);
            btnEditMethod.Name = "btnEditMethod";
            btnEditMethod.Size = new Size(130, 58);
            btnEditMethod.TabIndex = 16;
            btnEditMethod.Text = "Sửa ";
            btnEditMethod.UseVisualStyleBackColor = false;
            btnEditMethod.Click += btnEditMethod_Click;
            // 
            // btnAddMethod
            // 
            btnAddMethod.BackColor = Color.LavenderBlush;
            btnAddMethod.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnAddMethod.ForeColor = Color.Teal;
            btnAddMethod.Image = (Image)resources.GetObject("btnAddMethod.Image");
            btnAddMethod.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddMethod.Location = new Point(1144, 122);
            btnAddMethod.Name = "btnAddMethod";
            btnAddMethod.Size = new Size(130, 64);
            btnAddMethod.TabIndex = 15;
            btnAddMethod.Text = "Thêm ";
            btnAddMethod.TextAlign = ContentAlignment.MiddleRight;
            btnAddMethod.UseVisualStyleBackColor = false;
            btnAddMethod.Click += btnAddMethod_Click;
            // 
            // txtNameMethod
            // 
            txtNameMethod.Location = new Point(243, 127);
            txtNameMethod.Multiline = true;
            txtNameMethod.Name = "txtNameMethod";
            txtNameMethod.PlaceholderText = "Nhạp tên phương thức ";
            txtNameMethod.Size = new Size(245, 45);
            txtNameMethod.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(17, 143);
            label5.Name = "label5";
            label5.Size = new Size(209, 31);
            label5.TabIndex = 2;
            label5.Text = "Tên phương thức: ";
            // 
            // txtIdMethod
            // 
            txtIdMethod.Location = new Point(231, 23);
            txtIdMethod.Multiline = true;
            txtIdMethod.Name = "txtIdMethod";
            txtIdMethod.ReadOnly = true;
            txtIdMethod.Size = new Size(257, 47);
            txtIdMethod.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(19, 39);
            label4.Name = "label4";
            label4.Size = new Size(206, 31);
            label4.TabIndex = 0;
            label4.Text = "Mã phương thức: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.Location = new Point(352, 61);
            label2.Name = "label2";
            label2.Size = new Size(635, 25);
            label2.TabIndex = 1;
            label2.Text = "-----------------------------------------------------------------------------------------";
            // 
            // btnSearchMethod
            // 
            btnSearchMethod.BackColor = Color.LavenderBlush;
            btnSearchMethod.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            btnSearchMethod.ForeColor = Color.Teal;
            btnSearchMethod.Image = (Image)resources.GetObject("btnSearchMethod.Image");
            btnSearchMethod.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearchMethod.Location = new Point(1114, 114);
            btnSearchMethod.Name = "btnSearchMethod";
            btnSearchMethod.Size = new Size(166, 54);
            btnSearchMethod.TabIndex = 7;
            btnSearchMethod.Text = "Tìm kiếm ";
            btnSearchMethod.TextAlign = ContentAlignment.MiddleRight;
            btnSearchMethod.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(379, 20);
            label1.Name = "label1";
            label1.Size = new Size(579, 41);
            label1.TabIndex = 0;
            label1.Text = "CẬP NHẬT PHƯƠNG THỨC XÉT TUYỂN ";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LavenderBlush;
            panel2.Controls.Add(dataGridViewLoadMethod);
            panel2.Location = new Point(2, 428);
            panel2.Name = "panel2";
            panel2.Size = new Size(1310, 402);
            panel2.TabIndex = 1;
            // 
            // dataGridViewLoadMethod
            // 
            dataGridViewLoadMethod.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLoadMethod.BackgroundColor = Color.LavenderBlush;
            dataGridViewLoadMethod.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLoadMethod.Location = new Point(0, 0);
            dataGridViewLoadMethod.Name = "dataGridViewLoadMethod";
            dataGridViewLoadMethod.RowHeadersWidth = 51;
            dataGridViewLoadMethod.Size = new Size(1297, 402);
            dataGridViewLoadMethod.TabIndex = 0;
            dataGridViewLoadMethod.CellClick += dataGridViewLoadMethod_CellClick;
            // 
            // button1
            // 
            button1.BackColor = Color.LavenderBlush;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            button1.ForeColor = Color.Teal;
            button1.Location = new Point(796, 128);
            button1.Name = "button1";
            button1.Size = new Size(130, 58);
            button1.TabIndex = 21;
            button1.Text = "Xuất file";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.LavenderBlush;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            button2.ForeColor = Color.Teal;
            button2.Location = new Point(642, 125);
            button2.Name = "button2";
            button2.Size = new Size(130, 58);
            button2.TabIndex = 22;
            button2.Text = "In file ";
            button2.UseVisualStyleBackColor = false;
            // 
            // fMethod
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1305, 830);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fMethod";
            Text = "Method";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoadMethod).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel3;
        private Panel panel2;
        private TextBox txtSearchMethod;
        private Button btnSearchMethod;
        private Label label4;
        private TextBox txtIdMethod;
        private TextBox txtNameMethod;
        private Label label5;
        private Button btnDeleteMethod;
        private Button btnEditMethod;
        private Button btnAddMethod;
        private Button btnResetMethod;
        private DataGridView dataGridViewLoadMethod;
        private TextBox txtDescMethod;
        private Label label3;
        private Button button2;
        private Button button1;
    }
}