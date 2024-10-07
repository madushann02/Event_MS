namespace Event_MS
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtUName = new TextBox();
            txtUPassword = new TextBox();
            label2 = new Label();
            linkMemberSignin = new LinkLabel();
            btnLogin = new Button();
            btnReset = new Button();
            radiobtnAmin = new RadioButton();
            radiobtnMember = new RadioButton();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(349, 575);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(442, 197);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(172, 41);
            label1.TabIndex = 1;
            label1.Text = "User Name";
            // 
            // txtUName
            // 
            txtUName.BackColor = Color.White;
            txtUName.BorderStyle = BorderStyle.None;
            txtUName.ForeColor = Color.Black;
            txtUName.Location = new Point(627, 190);
            txtUName.Margin = new Padding(2);
            txtUName.Multiline = true;
            txtUName.Name = "txtUName";
            txtUName.Size = new Size(384, 44);
            txtUName.TabIndex = 2;
            // 
            // txtUPassword
            // 
            txtUPassword.BackColor = Color.White;
            txtUPassword.BorderStyle = BorderStyle.None;
            txtUPassword.ForeColor = Color.Black;
            txtUPassword.Location = new Point(627, 267);
            txtUPassword.Margin = new Padding(2);
            txtUPassword.Multiline = true;
            txtUPassword.Name = "txtUPassword";
            txtUPassword.Size = new Size(384, 44);
            txtUPassword.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(442, 272);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(150, 41);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // linkMemberSignin
            // 
            linkMemberSignin.ActiveLinkColor = SystemColors.ActiveCaption;
            linkMemberSignin.AutoSize = true;
            linkMemberSignin.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            linkMemberSignin.LinkColor = Color.White;
            linkMemberSignin.Location = new Point(726, 500);
            linkMemberSignin.Margin = new Padding(2, 0, 2, 0);
            linkMemberSignin.Name = "linkMemberSignin";
            linkMemberSignin.Size = new Size(93, 32);
            linkMemberSignin.TabIndex = 5;
            linkMemberSignin.TabStop = true;
            linkMemberSignin.Text = "Sign in";
            linkMemberSignin.LinkClicked += linkMemberSignin_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(192, 0, 192);
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(627, 415);
            btnLogin.Margin = new Padding(2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(189, 50);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(192, 0, 192);
            btnReset.FlatStyle = FlatStyle.Popup;
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(822, 415);
            btnReset.Margin = new Padding(2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(189, 50);
            btnReset.TabIndex = 7;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click_1;
            // 
            // radiobtnAmin
            // 
            radiobtnAmin.AutoSize = true;
            radiobtnAmin.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            radiobtnAmin.ForeColor = Color.White;
            radiobtnAmin.Location = new Point(627, 356);
            radiobtnAmin.Margin = new Padding(2);
            radiobtnAmin.Name = "radiobtnAmin";
            radiobtnAmin.Size = new Size(111, 36);
            radiobtnAmin.TabIndex = 8;
            radiobtnAmin.TabStop = true;
            radiobtnAmin.Text = "Admin";
            radiobtnAmin.UseVisualStyleBackColor = true;
            // 
            // radiobtnMember
            // 
            radiobtnMember.AutoSize = true;
            radiobtnMember.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            radiobtnMember.ForeColor = Color.White;
            radiobtnMember.Location = new Point(822, 356);
            radiobtnMember.Margin = new Padding(2);
            radiobtnMember.Name = "radiobtnMember";
            radiobtnMember.Size = new Size(131, 36);
            radiobtnMember.TabIndex = 9;
            radiobtnMember.TabStop = true;
            radiobtnMember.Text = "Member";
            radiobtnMember.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Enabled = false;
            label3.Font = new Font("Segoe UI", 50F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(548, 24);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(457, 112);
            label3.TabIndex = 10;
            label3.Text = "WELCOME";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(1112, 577);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(radiobtnMember);
            Controls.Add(radiobtnAmin);
            Controls.Add(btnReset);
            Controls.Add(btnLogin);
            Controls.Add(linkMemberSignin);
            Controls.Add(txtUPassword);
            Controls.Add(label2);
            Controls.Add(txtUName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtUName;
        private TextBox txtUPassword;
        private Label label2;
        private LinkLabel linkMemberSignin;
        private Button btnLogin;
        private Button btnReset;
        private RadioButton radiobtnAmin;
        private RadioButton radiobtnMember;
        private Label label3;
    }
}