using Event_MS.Classes;
using System.Runtime.InteropServices;

namespace Event_MS.GUIs
{
    public partial class AdminMember : Form
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
        public AdminMember()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }


        private void btnAdminHome_Click(object sender, EventArgs e)
        {
            AdminDashBoard adminDashBoard = new AdminDashBoard();
            adminDashBoard.Show();
            this.Hide();
        }

        private void btnAdminEvents_Click(object sender, EventArgs e)
        {
            AdminEvents adminEvents = new AdminEvents();
            adminEvents.Show();
            this.Hide();
        }


        private void AdminMember_Load(object sender, EventArgs e)
        {
            LoadAllMembers();

        }

        // Method to load all members and display them in the DataGridView
        private void LoadAllMembers()
        {
            // Fetch all members from the database
            List<Member> members = Member.GetAllMembers();

            // Bind the members list to the DataGridView or ListView
            dgvAdminM.DataSource = members;
        }

        private void btnAdminMDelete_Click(object sender, EventArgs e)
        {
            if (dgvAdminM.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a member to delete.");
                return;
            }

            // Get the selected member's ID
            int selectedMemberId = Convert.ToInt32(dgvAdminM.SelectedRows[0].Cells["id"].Value);
            Member.DeleteMemberById(selectedMemberId);


            // Refresh the member list after deletion
            LoadAllMembers();

            MessageBox.Show("Member deleted successfully!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
