using AddmissionCollege.DAO;

namespace AddmissionCollege
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string password = txtPasswordLogin.Text;
            string user = txtUserNameLogin.Text;
            if (Login(user, password))
            {
                fDashboard dashboard = new fDashboard();
                this.Hide();
                dashboard.ShowDialog();
                this.Show();
            }
            else
            {
                labelError.Visible = true;
                txtPasswordLogin.Clear();
                txtUserNameLogin.Clear();
            }
        }


        bool Login(string username, string password)
        {

            return AccountDAO.Instance.Login(username, password);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
