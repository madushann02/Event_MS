using Event_MS.Classes;
using System.Runtime.InteropServices;

namespace Event_MS.GUIs
{

    public partial class LoginMember : Form
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
        public LoginMember()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //public TextBox MemberIDTextBox
        //{
        //    get { return txtMemberID; } // Assuming 'memberIDTXT' is the actual name of the TextBox control.
        //}

        //public TextBox MemberNameTextBox
        //{
        //    get { return txtMemberName; } // Assuming 'txtMName' is the name of the TextBox control.
        //}

        //public TextBox MemberPasswordTextBox
        //{
        //    get { return txtMemberPassword; } // Assuming 'txtMPassword' is the name of the TextBox control.
        //}

        //public TextBox MemberEmailTextBox
        //{
        //    get { return txtMemberEmail; } // Assuming 'txtMEmail' is the name of the TextBox control.
        //}

        //public TextBox MemberTPTextBox
        //{
        //    get { return txtMemberTP; } // Assuming 'txtMTP' is the name of the TextBox control.
        //}

        private void btnSignMember_Click(object sender, EventArgs e)
        {
            string id = txtMemberID.Text;
            string name = txtMemberName.Text;
            string password = txtMemberPassword.Text;
            string email = txtMemberEmail.Text;
            string tp = txtMemberTP.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(id) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(tp))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Assuming Member is a valid class and DataBase.AddMember is a valid method
            Member member = new Member(id, name, password, email, tp);
            Member.AddMember(member);


            // Hide this form and show the login form
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btnResetMember_Click(object sender, EventArgs e)
        {
            txtMemberID.Clear();
            txtMemberName.Clear();
            txtMemberPassword.Clear();
            txtMemberEmail.Clear();
            txtMemberTP.Clear();
        }

        private void linkGoBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
