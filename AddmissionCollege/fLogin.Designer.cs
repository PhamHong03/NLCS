namespace AddmissionCollege
{
    partial class fLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            panel1 = new Panel();
            button1 = new Button();
            label6 = new Label();
            btnLoginOut = new Button();
            labelError = new Label();
            linkLabel3 = new LinkLabel();
            label3 = new Label();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            btnLogin = new Button();
            panel3 = new Panel();
            label5 = new Label();
            txtPasswordLogin = new TextBox();
            panel2 = new Panel();
            label4 = new Label();
            txtUserNameLogin = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnLoginOut);
            panel1.Controls.Add(labelError);
            panel1.Controls.Add(linkLabel3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(812, 482);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(779, 0);
            button1.Name = "button1";
            button1.Size = new Size(33, 31);
            button1.TabIndex = 14;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(156, 134);
            label6.Name = "label6";
            label6.Size = new Size(144, 20);
            label6.TabIndex = 13;
            label6.Text = "*Vui lòng đăng nhập ";
            label6.Visible = false;
            // 
            // btnLoginOut
            // 
            btnLoginOut.Image = (Image)resources.GetObject("btnLoginOut.Image");
            btnLoginOut.Location = new Point(865, 0);
            btnLoginOut.Name = "btnLoginOut";
            btnLoginOut.Size = new Size(35, 35);
            btnLoginOut.TabIndex = 12;
            btnLoginOut.UseVisualStyleBackColor = true;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 163);
            labelError.ForeColor = Color.Red;
            labelError.Location = new Point(227, 439);
            labelError.Name = "labelError";
            labelError.Size = new Size(373, 20);
            labelError.TabIndex = 11;
            labelError.Text = "*Tên đăng nhập hoặc mật khẩu sai. Vui lòng kiểm tra lại ";
            labelError.Visible = false;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(726, 392);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(67, 20);
            linkLabel3.TabIndex = 10;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Đăng ký ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(554, 392);
            label3.Name = "label3";
            label3.Size = new Size(166, 20);
            label3.TabIndex = 9;
            label3.Text = "Bạn chưa có tài khoản? ";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            linkLabel2.LinkColor = Color.RoyalBlue;
            linkLabel2.Location = new Point(67, 404);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(84, 23);
            linkLabel2.TabIndex = 8;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Trợ giúp ";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 163);
            linkLabel1.LinkColor = Color.Red;
            linkLabel1.Location = new Point(213, 320);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(118, 20);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Quên mật khẩu? ";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LavenderBlush;
            btnLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnLogin.ForeColor = Color.DarkBlue;
            btnLogin.Location = new Point(334, 353);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(156, 59);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Đăng Nhập ";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label5);
            panel3.Controls.Add(txtPasswordLogin);
            panel3.Location = new Point(121, 246);
            panel3.Name = "panel3";
            panel3.Size = new Size(542, 59);
            panel3.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label5.ForeColor = Color.DarkBlue;
            label5.Location = new Point(35, 21);
            label5.Name = "label5";
            label5.Size = new Size(103, 25);
            label5.TabIndex = 5;
            label5.Text = "Mật khẩu: ";
            // 
            // txtPasswordLogin
            // 
            txtPasswordLogin.Location = new Point(203, 0);
            txtPasswordLogin.Multiline = true;
            txtPasswordLogin.Name = "txtPasswordLogin";
            txtPasswordLogin.PasswordChar = '*';
            txtPasswordLogin.PlaceholderText = "Mật khẩu ";
            txtPasswordLogin.Size = new Size(318, 46);
            txtPasswordLogin.TabIndex = 3;
            txtPasswordLogin.Text = "123";
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtUserNameLogin);
            panel2.Location = new Point(121, 166);
            panel2.Name = "panel2";
            panel2.Size = new Size(542, 74);
            panel2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.ForeColor = Color.DarkBlue;
            label4.Location = new Point(26, 26);
            label4.Name = "label4";
            label4.Size = new Size(148, 25);
            label4.TabIndex = 4;
            label4.Text = "Tên đăng nhập: ";
            // 
            // txtUserNameLogin
            // 
            txtUserNameLogin.Location = new Point(203, 14);
            txtUserNameLogin.Multiline = true;
            txtUserNameLogin.Name = "txtUserNameLogin";
            txtUserNameLogin.PlaceholderText = "Tên đăng nhập ";
            txtUserNameLogin.Size = new Size(318, 46);
            txtUserNameLogin.TabIndex = 3;
            txtUserNameLogin.Text = "hong";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 163);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(356, 87);
            label2.Name = "label2";
            label2.Size = new Size(117, 19);
            label2.TabIndex = 1;
            label2.Text = "(Quản trị viên )";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(147, 26);
            label1.Name = "label1";
            label1.Size = new Size(568, 46);
            label1.TabIndex = 0;
            label1.Text = "HỆ THỐNG TUYỂN SINH ĐẠI HỌC ";
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(818, 497);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập ";
            FormClosing += fLogin_FormClosing;
            Load += fLogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel3;
        private TextBox txtPasswordLogin;
        private Panel panel2;
        private TextBox txtUserNameLogin;
        private Button btnLogin;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel3;
        private Label label3;
        private LinkLabel linkLabel2;
        private Label labelError;
        private Button btnLoginOut;
        private Label label4;
        private Label label6;
        private Label label5;
        private Button button1;
    }
}
