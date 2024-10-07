namespace Event_MS.GUIs
{
    partial class LoginMember
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
            btnResetMember = new Button();
            btnSignMember = new Button();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            linkGoBack = new LinkLabel();
            txtMemberID = new TextBox();
            txtMemberName = new TextBox();
            txtMemberPassword = new TextBox();
            txtMemberEmail = new TextBox();
            txtMemberTP = new TextBox();
            SuspendLayout();
            // 
            // btnResetMember
            // 
            btnResetMember.BackColor = Color.MediumOrchid;
            btnResetMember.FlatStyle = FlatStyle.Popup;
            btnResetMember.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnResetMember.ForeColor = Color.White;
            btnResetMember.Location = new Point(428, 384);
            btnResetMember.Margin = new Padding(2, 2, 2, 2);
            btnResetMember.Name = "btnResetMember";
            btnResetMember.Size = new Size(132, 39);
            btnResetMember.TabIndex = 15;
            btnResetMember.Text = "Reset";
            btnResetMember.UseVisualStyleBackColor = false;
            btnResetMember.Click += btnResetMember_Click;
            // 
            // btnSignMember
            // 
            btnSignMember.BackColor = Color.MediumOrchid;
            btnSignMember.FlatStyle = FlatStyle.Popup;
            btnSignMember.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignMember.ForeColor = Color.White;
            btnSignMember.Location = new Point(225, 384);
            btnSignMember.Margin = new Padding(2, 2, 2, 2);
            btnSignMember.Name = "btnSignMember";
            btnSignMember.Size = new Size(132, 39);
            btnSignMember.TabIndex = 14;
            btnSignMember.Text = "Sign In";
            btnSignMember.UseVisualStyleBackColor = false;
            btnSignMember.Click += btnSignMember_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(170, 191);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(132, 31);
            label2.TabIndex = 11;
            label2.Text = "Password : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(170, 152);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 31);
            label1.TabIndex = 9;
            label1.Text = "Name : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Enabled = false;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(170, 239);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(91, 31);
            label3.TabIndex = 16;
            label3.Text = "Email : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Enabled = false;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(170, 283);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(147, 31);
            label4.TabIndex = 18;
            label4.Text = "Contact No :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Enabled = false;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(170, 104);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(56, 31);
            label5.TabIndex = 20;
            label5.Text = "ID : ";
            // 
            // linkGoBack
            // 
            linkGoBack.ActiveLinkColor = SystemColors.ActiveCaption;
            linkGoBack.AutoSize = true;
            linkGoBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            linkGoBack.LinkBehavior = LinkBehavior.HoverUnderline;
            linkGoBack.LinkColor = Color.White;
            linkGoBack.Location = new Point(26, 506);
            linkGoBack.Margin = new Padding(2, 0, 2, 0);
            linkGoBack.Name = "linkGoBack";
            linkGoBack.Size = new Size(92, 20);
            linkGoBack.TabIndex = 22;
            linkGoBack.TabStop = true;
            linkGoBack.Text = "<< Go Back";
            linkGoBack.LinkClicked += linkGoBack_LinkClicked;
            // 
            // txtMemberID
            // 
            txtMemberID.BackColor = Color.White;
            txtMemberID.BorderStyle = BorderStyle.None;
            txtMemberID.ForeColor = Color.Black;
            txtMemberID.Location = new Point(325, 104);
            txtMemberID.Margin = new Padding(2, 2, 2, 2);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(293, 20);
            txtMemberID.TabIndex = 36;
            // 
            // txtMemberName
            // 
            txtMemberName.BackColor = Color.White;
            txtMemberName.BorderStyle = BorderStyle.None;
            txtMemberName.ForeColor = Color.Black;
            txtMemberName.Location = new Point(325, 152);
            txtMemberName.Margin = new Padding(2, 2, 2, 2);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(293, 20);
            txtMemberName.TabIndex = 37;
            // 
            // txtMemberPassword
            // 
            txtMemberPassword.BackColor = Color.White;
            txtMemberPassword.BorderStyle = BorderStyle.None;
            txtMemberPassword.ForeColor = Color.Black;
            txtMemberPassword.Location = new Point(325, 194);
            txtMemberPassword.Margin = new Padding(2, 2, 2, 2);
            txtMemberPassword.Name = "txtMemberPassword";
            txtMemberPassword.Size = new Size(293, 20);
            txtMemberPassword.TabIndex = 38;
            // 
            // txtMemberEmail
            // 
            txtMemberEmail.BackColor = Color.White;
            txtMemberEmail.BorderStyle = BorderStyle.None;
            txtMemberEmail.ForeColor = Color.Black;
            txtMemberEmail.Location = new Point(325, 239);
            txtMemberEmail.Margin = new Padding(2, 2, 2, 2);
            txtMemberEmail.Name = "txtMemberEmail";
            txtMemberEmail.Size = new Size(293, 20);
            txtMemberEmail.TabIndex = 39;
            // 
            // txtMemberTP
            // 
            txtMemberTP.BackColor = Color.White;
            txtMemberTP.BorderStyle = BorderStyle.None;
            txtMemberTP.ForeColor = Color.Black;
            txtMemberTP.Location = new Point(325, 283);
            txtMemberTP.Margin = new Padding(2, 2, 2, 2);
            txtMemberTP.Name = "txtMemberTP";
            txtMemberTP.Size = new Size(293, 20);
            txtMemberTP.TabIndex = 40;
            // 
            // LoginMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(776, 542);
            Controls.Add(txtMemberTP);
            Controls.Add(txtMemberEmail);
            Controls.Add(txtMemberPassword);
            Controls.Add(txtMemberName);
            Controls.Add(txtMemberID);
            Controls.Add(linkGoBack);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnResetMember);
            Controls.Add(btnSignMember);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "LoginMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginMember";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnResetMember;
        private Button btnSignMember;
        private TextBox txtMPassword;
        private Label label2;
        private TextBox txtMName;
        private Label label1;
        private TextBox txtMEmail;
        private Label label3;
        private TextBox txtMTP;
        private Label label4;
        private TextBox txtMID;
        private Label label5;
        private LinkLabel linkGoBack;
        private TextBox MemberIDTXT;
        private TextBox MemberTPTextBox;
        private TextBox MemberEmailTextBox;
        private TextBox MemberPasswordTextBox;
        private TextBox MemberNameTextBox;
        private TextBox MemberIDTextBox;
        private TextBox txtMemberID;
        private TextBox txtMemberName;
        private TextBox txtMemberPassword;
        private TextBox txtMemberEmail;
        private TextBox txtMemberTP;
    }
}