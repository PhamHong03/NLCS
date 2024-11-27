namespace AddmissionCollege
{
    partial class ThongKeHocPhi
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DisplayMember = "NAM_XT";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(237, 162);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(190, 28);
            comboBox1.TabIndex = 0;
            comboBox1.ValueMember = "ID";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(67, 155);
            label1.Name = "label1";
            label1.Size = new Size(164, 35);
            label1.TabIndex = 1;
            label1.Text = "Chọn năm: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(419, 36);
            label2.Name = "label2";
            label2.Size = new Size(496, 35);
            label2.TabIndex = 6;
            label2.Text = "THỐNG KÊ HỌC PHÍ THEO NĂM ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.ForeColor = Color.DarkBlue;
            label3.Location = new Point(109, 28);
            label3.Name = "label3";
            label3.Size = new Size(232, 35);
            label3.TabIndex = 7;
            label3.Text = "Tổng thu học phí";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label4.Location = new Point(145, 140);
            label4.Name = "label4";
            label4.Size = new Size(166, 39);
            label4.TabIndex = 8;
            label4.Text = "Doanh thu ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LavenderBlush;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(401, 304);
            panel1.Name = "panel1";
            panel1.Size = new Size(463, 307);
            panel1.TabIndex = 9;
            // 
            // ThongKeHocPhi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1294, 841);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ThongKeHocPhi";
            Text = "ThongKeHocPhi";
            Load += ThongKeHocPhi_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
    }
}