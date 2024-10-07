namespace Event_MS.GUIs
{
    partial class MemberEvents
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
            panel3 = new Panel();
            btnMemberEvents = new Button();
            panel4 = new Panel();
            btnMemberBookings = new Button();
            panel6 = new Panel();
            btnEventBook = new Button();
            dgvEventM = new DataGridView();
            button1 = new Button();
            sidebar.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEventM).BeginInit();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.Fuchsia;
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(panel4);
            sidebar.Location = new Point(-2, 59);
            sidebar.Margin = new Padding(0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(1106, 78);
            sidebar.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnMemberEvents);
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(289, 75);
            panel3.TabIndex = 9;
            // 
            // btnMemberEvents
            // 
            btnMemberEvents.BackColor = Color.FromArgb(64, 0, 64);
            btnMemberEvents.FlatStyle = FlatStyle.Popup;
            btnMemberEvents.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnMemberEvents.ForeColor = Color.FromArgb(255, 192, 255);
            btnMemberEvents.Location = new Point(-7, -2);
            btnMemberEvents.Margin = new Padding(2);
            btnMemberEvents.Name = "btnMemberEvents";
            btnMemberEvents.Size = new Size(296, 77);
            btnMemberEvents.TabIndex = 7;
            btnMemberEvents.Text = "Events";
            btnMemberEvents.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnMemberBookings);
            panel4.Location = new Point(289, 0);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(289, 75);
            panel4.TabIndex = 9;
            // 
            // btnMemberBookings
            // 
            btnMemberBookings.BackColor = Color.FromArgb(255, 192, 255);
            btnMemberBookings.FlatStyle = FlatStyle.Popup;
            btnMemberBookings.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnMemberBookings.ForeColor = Color.Black;
            btnMemberBookings.Location = new Point(-7, -2);
            btnMemberBookings.Margin = new Padding(2);
            btnMemberBookings.Name = "btnMemberBookings";
            btnMemberBookings.Size = new Size(294, 77);
            btnMemberBookings.TabIndex = 7;
            btnMemberBookings.Text = "Bookings";
            btnMemberBookings.UseVisualStyleBackColor = false;
            btnMemberBookings.Click += btnMemberBookings_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(64, 0, 64);
            panel6.Controls.Add(btnEventBook);
            panel6.Controls.Add(dgvEventM);
            panel6.Location = new Point(0, 138);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(1104, 534);
            panel6.TabIndex = 11;
            // 
            // btnEventBook
            // 
            btnEventBook.BackColor = Color.Fuchsia;
            btnEventBook.FlatStyle = FlatStyle.Popup;
            btnEventBook.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEventBook.ForeColor = Color.White;
            btnEventBook.Location = new Point(965, 451);
            btnEventBook.Margin = new Padding(2);
            btnEventBook.Name = "btnEventBook";
            btnEventBook.Size = new Size(132, 39);
            btnEventBook.TabIndex = 8;
            btnEventBook.Text = "Book";
            btnEventBook.UseVisualStyleBackColor = false;
            btnEventBook.Click += btnEventBook_Click;
            // 
            // dgvEventM
            // 
            dgvEventM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEventM.BackgroundColor = Color.FromArgb(64, 0, 64);
            dgvEventM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEventM.GridColor = Color.FromArgb(236, 223, 204);
            dgvEventM.Location = new Point(17, 11);
            dgvEventM.Margin = new Padding(2);
            dgvEventM.Name = "dgvEventM";
            dgvEventM.RowHeadersWidth = 82;
            dgvEventM.Size = new Size(1080, 412);
            dgvEventM.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Fuchsia;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(972, 11);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(132, 39);
            button1.TabIndex = 10;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // MemberEvents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(1108, 688);
            Controls.Add(panel6);
            Controls.Add(sidebar);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "MemberEvents";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MemberEvents";
            Load += MemberEvents_Load;
            sidebar.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEventM).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel panel3;
        private Button btnMemberEvents;
        private Panel panel4;
        private Button btnMemberBookings;
        private Panel panel6;
        private Button btnEventBook;
        private DataGridView dgvEventM;
        private Button button1;
    }
}