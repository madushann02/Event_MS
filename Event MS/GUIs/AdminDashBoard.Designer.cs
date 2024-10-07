namespace Event_MS.GUIs
{
    partial class AdminDashBoard
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
            panel1 = new Panel();
            button1 = new Button();
            sidebar = new FlowLayoutPanel();
            panel2 = new Panel();
            btnAdminHome = new Button();
            panel3 = new Panel();
            btnAdminMember = new Button();
            panel4 = new Panel();
            btnAdminEvents = new Button();
            panel6 = new Panel();
            btnAdminDelete = new Button();
            btnAdminAdd = new Button();
            dgvAdmin = new DataGridView();
            panel1.SuspendLayout();
            sidebar.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdmin).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(192, 0, 192);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-1, -2);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1113, 63);
            panel1.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.Fuchsia;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(963, 13);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(132, 39);
            button1.TabIndex = 11;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(192, 0, 192);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(panel4);
            sidebar.Location = new Point(-6, 60);
            sidebar.Margin = new Padding(2);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(1160, 84);
            sidebar.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnAdminHome);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(289, 75);
            panel2.TabIndex = 8;
            // 
            // btnAdminHome
            // 
            btnAdminHome.BackColor = Color.Purple;
            btnAdminHome.FlatStyle = FlatStyle.Popup;
            btnAdminHome.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdminHome.ForeColor = Color.FromArgb(255, 192, 255);
            btnAdminHome.Location = new Point(7, 1);
            btnAdminHome.Margin = new Padding(2);
            btnAdminHome.Name = "btnAdminHome";
            btnAdminHome.Size = new Size(280, 72);
            btnAdminHome.TabIndex = 7;
            btnAdminHome.Text = "Home";
            btnAdminHome.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnAdminMember);
            panel3.Location = new Point(289, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(289, 75);
            panel3.TabIndex = 9;
            // 
            // btnAdminMember
            // 
            btnAdminMember.BackColor = Color.FromArgb(255, 192, 255);
            btnAdminMember.FlatStyle = FlatStyle.Popup;
            btnAdminMember.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdminMember.ForeColor = Color.Black;
            btnAdminMember.Location = new Point(-7, -2);
            btnAdminMember.Margin = new Padding(2);
            btnAdminMember.Name = "btnAdminMember";
            btnAdminMember.Size = new Size(296, 77);
            btnAdminMember.TabIndex = 7;
            btnAdminMember.Text = "Members";
            btnAdminMember.UseVisualStyleBackColor = false;
            btnAdminMember.Click += btnAdminMember_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnAdminEvents);
            panel4.Location = new Point(578, 0);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(289, 75);
            panel4.TabIndex = 9;
            // 
            // btnAdminEvents
            // 
            btnAdminEvents.BackColor = Color.FromArgb(255, 192, 255);
            btnAdminEvents.FlatStyle = FlatStyle.Popup;
            btnAdminEvents.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdminEvents.ForeColor = Color.Black;
            btnAdminEvents.Location = new Point(-7, -2);
            btnAdminEvents.Margin = new Padding(2);
            btnAdminEvents.Name = "btnAdminEvents";
            btnAdminEvents.Size = new Size(294, 77);
            btnAdminEvents.TabIndex = 7;
            btnAdminEvents.Text = "Events";
            btnAdminEvents.UseVisualStyleBackColor = false;
            btnAdminEvents.Click += btnAdminEvents_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(64, 0, 64);
            panel6.Controls.Add(btnAdminDelete);
            panel6.Controls.Add(btnAdminAdd);
            panel6.Controls.Add(dgvAdmin);
            panel6.Location = new Point(11, 148);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(1090, 532);
            panel6.TabIndex = 7;
            // 
            // btnAdminDelete
            // 
            btnAdminDelete.BackColor = Color.Fuchsia;
            btnAdminDelete.FlatStyle = FlatStyle.Popup;
            btnAdminDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdminDelete.ForeColor = Color.White;
            btnAdminDelete.Location = new Point(951, 446);
            btnAdminDelete.Margin = new Padding(2);
            btnAdminDelete.Name = "btnAdminDelete";
            btnAdminDelete.Size = new Size(132, 39);
            btnAdminDelete.TabIndex = 8;
            btnAdminDelete.Text = "Delete";
            btnAdminDelete.UseVisualStyleBackColor = false;
            btnAdminDelete.Click += btnAdminDelete_Click;
            // 
            // btnAdminAdd
            // 
            btnAdminAdd.BackColor = Color.Fuchsia;
            btnAdminAdd.FlatStyle = FlatStyle.Popup;
            btnAdminAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdminAdd.ForeColor = Color.White;
            btnAdminAdd.Location = new Point(788, 446);
            btnAdminAdd.Margin = new Padding(2);
            btnAdminAdd.Name = "btnAdminAdd";
            btnAdminAdd.Size = new Size(132, 39);
            btnAdminAdd.TabIndex = 7;
            btnAdminAdd.Text = "Add ";
            btnAdminAdd.UseVisualStyleBackColor = false;
            btnAdminAdd.Click += btnAdminAdd_Click;
            // 
            // dgvAdmin
            // 
            dgvAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAdmin.BackgroundColor = Color.FromArgb(64, 0, 64);
            dgvAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdmin.GridColor = Color.FromArgb(60, 61, 55);
            dgvAdmin.Location = new Point(17, 11);
            dgvAdmin.Margin = new Padding(2);
            dgvAdmin.Name = "dgvAdmin";
            dgvAdmin.RowHeadersWidth = 82;
            dgvAdmin.Size = new Size(1067, 412);
            dgvAdmin.TabIndex = 0;
            // 
            // AdminDashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 32, 30);
            ClientSize = new Size(1108, 688);
            Controls.Add(panel6);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(2);
            Name = "AdminDashBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashBoard";
            Load += AdminDashBoard_Load;
            panel1.ResumeLayout(false);
            sidebar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAdmin).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private FlowLayoutPanel sidebar;
        private Button btnAdminHome;
        private Panel panel2;
        private Panel panel3;
        private Button btnAdminMember;
        private Panel panel4;
        private Button btnAdminEvents;
        private Panel panel6;
        private DataGridView dgvAdmin;
        private Button btnAdminAdd;
        private Button btnAdminDelete;
        private Button button1;
    }
}