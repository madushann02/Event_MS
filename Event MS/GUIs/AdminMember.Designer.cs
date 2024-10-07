namespace Event_MS.GUIs
{
    partial class AdminMember
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
            btnAdminMDelete = new Button();
            dgvAdminM = new DataGridView();
            button1 = new Button();
            sidebar.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdminM).BeginInit();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(192, 0, 192);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(panel4);
            sidebar.Location = new Point(-1, 61);
            sidebar.Margin = new Padding(0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(1107, 82);
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
            btnAdminMember.BackColor = Color.FromArgb(64, 0, 64);
            btnAdminMember.FlatStyle = FlatStyle.Popup;
            btnAdminMember.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdminMember.ForeColor = Color.FromArgb(255, 192, 255);
            btnAdminMember.Location = new Point(-7, -2);
            btnAdminMember.Margin = new Padding(2);
            btnAdminMember.Name = "btnAdminMember";
            btnAdminMember.Size = new Size(296, 77);
            btnAdminMember.TabIndex = 7;
            btnAdminMember.Text = "Members";
            btnAdminMember.UseVisualStyleBackColor = false;
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
            panel6.Controls.Add(btnAdminMDelete);
            panel6.Controls.Add(dgvAdminM);
            panel6.Location = new Point(1, 145);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(1105, 529);
            panel6.TabIndex = 11;
            // 
            // btnAdminMDelete
            // 
            btnAdminMDelete.BackColor = Color.FromArgb(192, 0, 192);
            btnAdminMDelete.FlatStyle = FlatStyle.Popup;
            btnAdminMDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdminMDelete.ForeColor = Color.White;
            btnAdminMDelete.Location = new Point(964, 465);
            btnAdminMDelete.Margin = new Padding(2);
            btnAdminMDelete.Name = "btnAdminMDelete";
            btnAdminMDelete.Size = new Size(132, 39);
            btnAdminMDelete.TabIndex = 8;
            btnAdminMDelete.Text = "Delete";
            btnAdminMDelete.UseVisualStyleBackColor = false;
            btnAdminMDelete.Click += btnAdminMDelete_Click;
            // 
            // dgvAdminM
            // 
            dgvAdminM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAdminM.BackgroundColor = Color.FromArgb(64, 0, 64);
            dgvAdminM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdminM.GridColor = Color.FromArgb(236, 223, 204);
            dgvAdminM.Location = new Point(17, 11);
            dgvAdminM.Margin = new Padding(2);
            dgvAdminM.Name = "dgvAdminM";
            dgvAdminM.RowHeadersWidth = 82;
            dgvAdminM.Size = new Size(1079, 412);
            dgvAdminM.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Fuchsia;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(965, 11);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(132, 39);
            button1.TabIndex = 12;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AdminMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 192);
            ClientSize = new Size(1108, 688);
            Controls.Add(button1);
            Controls.Add(panel6);
            Controls.Add(sidebar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "AdminMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminMember";
            Load += AdminMember_Load;
            sidebar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAdminM).EndInit();
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
        private Button btnAdminMDelete;
        private DataGridView dgvAdminM;
        private Button button1;
    }
}