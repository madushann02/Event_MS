namespace Event_MS.GUIs
{
    partial class AdminEvents
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
            sidebar = new FlowLayoutPanel();
            panel2 = new Panel();
            btnAdminHome = new Button();
            panel3 = new Panel();
            btnAdminMember = new Button();
            panel4 = new Panel();
            btnAdminEvents = new Button();
            panel6 = new Panel();
            btnAdminEDelete = new Button();
            btnAdminEAdd = new Button();
            dgvAdminE = new DataGridView();
            button1 = new Button();
            sidebar.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdminE).BeginInit();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(192, 0, 192);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(panel4);
            sidebar.Location = new Point(-5, 63);
            sidebar.Margin = new Padding(0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(1174, 83);
            sidebar.TabIndex = 7;
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
            btnAdminHome.BackColor = Color.FromArgb(255, 192, 255);
            btnAdminHome.FlatStyle = FlatStyle.Popup;
            btnAdminHome.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdminHome.ForeColor = Color.Black;
            btnAdminHome.Location = new Point(-7, 2);
            btnAdminHome.Margin = new Padding(2);
            btnAdminHome.Name = "btnAdminHome";
            btnAdminHome.Size = new Size(294, 72);
            btnAdminHome.TabIndex = 7;
            btnAdminHome.Text = "Home";
            btnAdminHome.UseVisualStyleBackColor = false;
            btnAdminHome.Click += btnAdminHome_Click;
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
            btnAdminEvents.BackColor = Color.Purple;
            btnAdminEvents.FlatStyle = FlatStyle.Popup;
            btnAdminEvents.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdminEvents.ForeColor = Color.White;
            btnAdminEvents.Location = new Point(-7, -2);
            btnAdminEvents.Margin = new Padding(2);
            btnAdminEvents.Name = "btnAdminEvents";
            btnAdminEvents.Size = new Size(294, 77);
            btnAdminEvents.TabIndex = 7;
            btnAdminEvents.Text = "Events";
            btnAdminEvents.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(64, 0, 64);
            panel6.Controls.Add(btnAdminEDelete);
            panel6.Controls.Add(btnAdminEAdd);
            panel6.Controls.Add(dgvAdminE);
            panel6.Location = new Point(-3, 148);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(1172, 532);
            panel6.TabIndex = 11;
            // 
            // btnAdminEDelete
            // 
            btnAdminEDelete.BackColor = Color.FromArgb(192, 0, 192);
            btnAdminEDelete.FlatStyle = FlatStyle.Popup;
            btnAdminEDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdminEDelete.ForeColor = Color.White;
            btnAdminEDelete.Location = new Point(1020, 464);
            btnAdminEDelete.Margin = new Padding(2);
            btnAdminEDelete.Name = "btnAdminEDelete";
            btnAdminEDelete.Size = new Size(132, 39);
            btnAdminEDelete.TabIndex = 8;
            btnAdminEDelete.Text = "Delete";
            btnAdminEDelete.UseVisualStyleBackColor = false;
            btnAdminEDelete.Click += btnAdminEDelete_Click;
            // 
            // btnAdminEAdd
            // 
            btnAdminEAdd.BackColor = Color.FromArgb(192, 0, 192);
            btnAdminEAdd.FlatStyle = FlatStyle.Popup;
            btnAdminEAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdminEAdd.ForeColor = Color.White;
            btnAdminEAdd.Location = new Point(857, 464);
            btnAdminEAdd.Margin = new Padding(2);
            btnAdminEAdd.Name = "btnAdminEAdd";
            btnAdminEAdd.Size = new Size(132, 39);
            btnAdminEAdd.TabIndex = 7;
            btnAdminEAdd.Text = "Add ";
            btnAdminEAdd.UseVisualStyleBackColor = false;
            btnAdminEAdd.Click += btnAdminEAdd_Click;
            // 
            // dgvAdminE
            // 
            dgvAdminE.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAdminE.BackgroundColor = Color.FromArgb(64, 0, 64);
            dgvAdminE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdminE.GridColor = Color.FromArgb(236, 223, 204);
            dgvAdminE.Location = new Point(17, 11);
            dgvAdminE.Margin = new Padding(2);
            dgvAdminE.Name = "dgvAdminE";
            dgvAdminE.RowHeadersWidth = 82;
            dgvAdminE.Size = new Size(1135, 412);
            dgvAdminE.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Fuchsia;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1032, 11);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(132, 39);
            button1.TabIndex = 12;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AdminEvents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 192);
            ClientSize = new Size(1175, 688);
            Controls.Add(button1);
            Controls.Add(panel6);
            Controls.Add(sidebar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "AdminEvents";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminEvents";
            Load += AdminEvents_Load;
            sidebar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAdminE).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel panel2;
        private Button btnAdminHome;
        private Panel panel3;
        private Button btnAdminMember;
        private Panel panel4;
        private Button btnAdminEvents;
        private Panel panel6;
        private Button btnAdminEDelete;
        private Button btnAdminEAdd;
        private DataGridView dgvAdminE;
        private Button button1;
    }
}