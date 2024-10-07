using Event_MS.Classes;
using System.Runtime.InteropServices;
using System.Drawing;

namespace Event_MS.GUIs
{
    public partial class AddAdmin : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );

        public AddAdmin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            // Change form background color
            this.BackColor = Color.LightBlue;

            // Change font family and size for all controls
            Font newFont = new Font("Arial", 12, FontStyle.Regular);
            foreach (Control control in this.Controls)
            {
                control.Font = newFont;
            }

            // Adjust layout
            txtAdminID.Location = new Point(50, 50);
            txtAdminName.Location = new Point(50, 100);
            txtAdminPassword.Location = new Point(50, 150);
            txtAdminEmail.Location = new Point(50, 200);
            txtAdminTP.Location = new Point(50, 250);
            btnSignAdmin.Location = new Point(50, 300);
            btnResetAdmin.Location = new Point(150, 300);
        }

        private void linkGoBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminDashBoard adminDashBoard = new AdminDashBoard();
            adminDashBoard.Show();
            this.Hide();
        }

        private void btnSignAdmin_Click(object sender, EventArgs e)
        {
            string id = txtAdminID.Text;
            string name = txtAdminName.Text;
            string password = txtAdminPassword.Text;
            string email = txtAdminEmail.Text;
            string tp = txtAdminTP.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(id) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(tp))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            Admin admin = new Admin(id, name, password, email, tp);
            Admin.AddAdmin(admin);

            // Hide this form and show the login form
            this.Hide();
            AdminDashBoard adminDash = new AdminDashBoard();
            adminDash.Show();
        }

        private void btnResetAdmin_Click(object sender, EventArgs e)
        {
            txtAdminID.Clear();
            txtAdminName.Clear();
            txtAdminPassword.Clear();
            txtAdminEmail.Clear();
            txtAdminTP.Clear();
        }
    }
}
