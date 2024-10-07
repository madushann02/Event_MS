using Event_MS.Classes;
using System.Runtime.InteropServices;

namespace Event_MS.GUIs
{
    public partial class AdminEvents : Form
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
        public AdminEvents()
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

        private void btnAdminMember_Click(object sender, EventArgs e)
        {
            AdminMember adminMember = new AdminMember();
            adminMember.Show();
            this.Hide();
        }

        private void btnAdminEAdd_Click(object sender, EventArgs e)
        {
            AddEvents addEvents = new AddEvents();
            addEvents.Show();
            this.Hide();
        }

        private void AdminEvents_Load(object sender, EventArgs e)
        {
            LoadAllEvents();
        }

        // Method to load all events and display them in the DataGridView
        private void LoadAllEvents()
        {
            List<ManageEvents> events = ManageEvents.GetAllEvents();
            dgvAdminE.DataSource = events;
        }

        private void btnAdminEDelete_Click(object sender, EventArgs e)
        {
            // Ensure a row is selected
            if (dgvAdminE.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an event to delete.");
                return;
            }

            // Get the selected event's ID
            int selectedEventId = Convert.ToInt32(dgvAdminE.SelectedRows[0].Cells["EventId"].Value);

            // Delete the event from the database
            ManageEvents.DeleteEvent(selectedEventId);

            // Refresh the event list after deletion
            LoadAllEvents();

            MessageBox.Show("Event deleted successfully!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
