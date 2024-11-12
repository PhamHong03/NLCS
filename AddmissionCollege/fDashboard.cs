using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
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

    public partial class fDashboard : Form
    {
        public fDashboard()
        {
            InitializeComponent();
            LoadUserInfo();
        }

        private void fDashboard_Load(object sender, EventArgs e)
        {

        }


        private void LoadUserInfo()
        {
            label2.Text = LoggedInUser.UserName;  
            label3.Text = LoggedInUser.Role;    

        }

        public class LoggedInUser
        {
            public static string UserName { get; set; } = "Cẩm Hồng";  
            public static string Role { get; set; } = "Quản trị viên";      
        }
        private void button11_Click(object sender, EventArgs e)
        {
            fLogin f = new fLogin();
            f.Show();
            this.Close();
        }

        private void btnMajor_Click(object sender, EventArgs e)
        {
            //fMajor f = new fMajor();    
            //f.ShowDialog();
            //this.Close();
            //
            fMajor major = new fMajor();
            Point pictureBoxLocation = panelPictureBox.PointToScreen(Point.Empty); // Thay "myPictureBox" bằng tên PictureBox của bạn
            major.StartPosition = FormStartPosition.Manual; // Đặt vị trí thủ công
            major.Location = pictureBoxLocation; // Đặt vị trí
            major.Show(); // Hiển thị form
        }

        private void btnPriority_Click(object sender, EventArgs e)
        {
            fPriority priority = new fPriority();
            Point pictureBoxLocation = panelPictureBox.PointToScreen(Point.Empty);
            priority.StartPosition = FormStartPosition.Manual;
            priority.Location = pictureBoxLocation;
            priority.Show();
        }


        private void btnMethod_Click(object sender, EventArgs e)
        {
            fMethod method = new fMethod();
            Point pictureBoxLocation = panelPictureBox.PointToScreen(Point.Empty); // Thay "myPictureBox" bằng tên PictureBox của bạn
            method.StartPosition = FormStartPosition.Manual; // Đặt vị trí thủ công
            method.Location = pictureBoxLocation; // Đặt vị trí
            method.Show(); // Hiển thị form
        }



        private void btnArea_Click(object sender, EventArgs e)
        {
            fAreaPriority area = new fAreaPriority();
            Point pictureBoxLocation = panelPictureBox.PointToScreen(Point.Empty);
            area.StartPosition = FormStartPosition.Manual;
            area.Location = pictureBoxLocation;
            area.Show();
        }

        private void btnFee_Click(object sender, EventArgs e)
        {
            fFee fee = new fFee();
            Point pictureBoxLocation = panelPictureBox.PointToScreen(Point.Empty);
            fee.StartPosition = FormStartPosition.Manual;
            fee.Location = pictureBoxLocation;
            fee.Show();

        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            fCombinate fCombinate = new fCombinate();
            Point pictureBoxLocation = panelPictureBox.PointToScreen(Point.Empty);
            fCombinate.StartPosition = FormStartPosition.Manual;
            fCombinate.Location = pictureBoxLocation;
            fCombinate.Show();
        }

        private void btnAdmission_Click(object sender, EventArgs e)
        {
            fAddmission f = new fAddmission();
            Point pictureBoxLocation = panelPictureBox.PointToScreen(Point.Empty);
            f.StartPosition = FormStartPosition.Manual;
            f.Location = pictureBoxLocation;
            f.Show();
        }

        private void btnTH_N_Click(object sender, EventArgs e)
        {
            fMajorPlusCombinate f = new fMajorPlusCombinate();
            Point pictureBoxLocation = panelPictureBox.PointToScreen(Point.Empty);
            f.StartPosition = FormStartPosition.Manual;
            f.Location = pictureBoxLocation;
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
