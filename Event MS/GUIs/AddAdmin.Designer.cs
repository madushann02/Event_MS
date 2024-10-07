namespace Event_MS.GUIs
{
    partial class AddAdmin
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
            linkGoBack = new LinkLabel();
            txtAdminID = new TextBox();
            label5 = new Label();
            txtAdminTP = new TextBox();
            label4 = new Label();
            txtAdminEmail = new TextBox();
            label3 = new Label();
            btnResetAdmin = new Button();
            btnSignAdmin = new Button();
            txtAdminPassword = new TextBox();
            label2 = new Label();
            txtAdminName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // linkGoBack
            // 
            linkGoBack.ActiveLinkColor = SystemColors.ActiveCaption;
            linkGoBack.AutoSize = true;
            linkGoBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            linkGoBack.LinkBehavior = LinkBehavior.HoverUnderline;
            linkGoBack.LinkColor = Color.White;
            linkGoBack.Location = new Point(30, 403);
            linkGoBack.Margin = new Padding(2, 0, 2, 0);
            linkGoBack.Name = "linkGoBack";
            linkGoBack.Size = new Size(66, 20);
            linkGoBack.TabIndex = 36;
            linkGoBack.TabStop = true;
            linkGoBack.Text = "Go Back";
            linkGoBack.LinkClicked += linkGoBack_LinkClicked;
            // 
            // txtAdminID
            // 
            txtAdminID.BackColor = Color.White;
            txtAdminID.BorderStyle = BorderStyle.None;
            txtAdminID.ForeColor = Color.Black;
            txtAdminID.Location = new Point(204, 47);
            txtAdminID.Margin = new Padding(2);
            txtAdminID.Name = "txtAdminID";
            txtAdminID.Size = new Size(293, 20);
            txtAdminID.TabIndex = 35;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Enabled = false;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(42, 38);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(56, 31);
            label5.TabIndex = 34;
            label5.Text = "ID : ";
            // 
            // txtAdminTP
            // 
            txtAdminTP.BackColor = Color.White;
            txtAdminTP.BorderStyle = BorderStyle.None;
            txtAdminTP.ForeColor = Color.Black;
            txtAdminTP.Location = new Point(204, 226);
            txtAdminTP.Margin = new Padding(2);
            txtAdminTP.Name = "txtAdminTP";
            txtAdminTP.Size = new Size(293, 20);
            txtAdminTP.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Enabled = false;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(42, 217);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(147, 31);
            label4.TabIndex = 32;
            label4.Text = "Contact No :";
            // 
            // txtAdminEmail
            // 
            txtAdminEmail.BackColor = Color.White;
            txtAdminEmail.BorderStyle = BorderStyle.None;
            txtAdminEmail.ForeColor = Color.Black;
            txtAdminEmail.Location = new Point(204, 181);
            txtAdminEmail.Margin = new Padding(2);
            txtAdminEmail.Name = "txtAdminEmail";
            txtAdminEmail.Size = new Size(293, 20);
            txtAdminEmail.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Enabled = false;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(42, 173);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(91, 31);
            label3.TabIndex = 30;
            label3.Text = "Email : ";
            // 
            // btnResetAdmin
            // 
            btnResetAdmin.BackColor = Color.Fuchsia;
            btnResetAdmin.FlatStyle = FlatStyle.Popup;
            btnResetAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnResetAdmin.ForeColor = Color.White;
            btnResetAdmin.Location = new Point(301, 323);
            btnResetAdmin.Margin = new Padding(2);
            btnResetAdmin.Name = "btnResetAdmin";
            btnResetAdmin.Size = new Size(132, 39);
            btnResetAdmin.TabIndex = 29;
            btnResetAdmin.Text = "Reset";
            btnResetAdmin.UseVisualStyleBackColor = false;
            btnResetAdmin.Click += btnResetAdmin_Click;
            // 
            // btnSignAdmin
            // 
            btnSignAdmin.BackColor = Color.Fuchsia;
            btnSignAdmin.FlatStyle = FlatStyle.Popup;
            btnSignAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignAdmin.ForeColor = Color.White;
            btnSignAdmin.Location = new Point(98, 323);
            btnSignAdmin.Margin = new Padding(2);
            btnSignAdmin.Name = "btnSignAdmin";
            btnSignAdmin.Size = new Size(132, 39);
            btnSignAdmin.TabIndex = 28;
            btnSignAdmin.Text = "Sign In";
            btnSignAdmin.UseVisualStyleBackColor = false;
            btnSignAdmin.Click += btnSignAdmin_Click;
            // 
            // txtAdminPassword
            // 
            txtAdminPassword.BackColor = Color.White;
            txtAdminPassword.BorderStyle = BorderStyle.None;
            txtAdminPassword.ForeColor = Color.Black;
            txtAdminPassword.Location = new Point(204, 133);
            txtAdminPassword.Margin = new Padding(2);
            txtAdminPassword.Name = "txtAdminPassword";
            txtAdminPassword.Size = new Size(293, 20);
            txtAdminPassword.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(42, 124);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(132, 31);
            label2.TabIndex = 26;
            label2.Text = "Password : ";
            // 
            // txtAdminName
            // 
            txtAdminName.BackColor = Color.White;
            txtAdminName.BorderStyle = BorderStyle.None;
            txtAdminName.ForeColor = Color.Black;
            txtAdminName.Location = new Point(204, 91);
            txtAdminName.Margin = new Padding(2);
            txtAdminName.Name = "txtAdminName";
            txtAdminName.Size = new Size(293, 20);
            txtAdminName.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(42, 86);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 31);
            label1.TabIndex = 24;
            label1.Text = "Name : ";
            // 
            // AddAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(529, 453);
            Controls.Add(linkGoBack);
            Controls.Add(txtAdminID);
            Controls.Add(label5);
            Controls.Add(txtAdminTP);
            Controls.Add(label4);
            Controls.Add(txtAdminEmail);
            Controls.Add(label3);
            Controls.Add(btnResetAdmin);
            Controls.Add(btnSignAdmin);
            Controls.Add(txtAdminPassword);
            Controls.Add(label2);
            Controls.Add(txtAdminName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "AddAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkGoBack;
        private TextBox txtAdminID;
        private Label label5;
        private TextBox txtAdminTP;
        private Label label4;
        private TextBox txtAdminEmail;
        private Label label3;
        private Button btnResetAdmin;
        private Button btnSignAdmin;
        private TextBox txtAdminPassword;
        private Label label2;
        private TextBox txtAdminName;
        private Label label1;
    }
}