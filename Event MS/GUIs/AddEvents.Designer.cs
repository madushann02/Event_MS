namespace Event_MS.GUIs
{
    partial class AddEvents
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
            txtEventID = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnEventRset = new Button();
            btnEventAdd = new Button();
            txtEventTypeee = new TextBox();
            label2 = new Label();
            txtEventName = new TextBox();
            label1 = new Label();
            txtEventVenue = new TextBox();
            txtEventTicket = new TextBox();
            txtEventTicketquantity = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // linkGoBack
            // 
            linkGoBack.ActiveLinkColor = SystemColors.ActiveCaption;
            linkGoBack.AutoSize = true;
            linkGoBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            linkGoBack.LinkBehavior = LinkBehavior.HoverUnderline;
            linkGoBack.LinkColor = Color.White;
            linkGoBack.Location = new Point(26, 451);
            linkGoBack.Margin = new Padding(2, 0, 2, 0);
            linkGoBack.Name = "linkGoBack";
            linkGoBack.Size = new Size(66, 20);
            linkGoBack.TabIndex = 50;
            linkGoBack.TabStop = true;
            linkGoBack.Text = "Go Back";
            linkGoBack.LinkClicked += linkGoBack_LinkClicked;
            // 
            // txtEventID
            // 
            txtEventID.BackColor = Color.White;
            txtEventID.BorderStyle = BorderStyle.None;
            txtEventID.ForeColor = Color.Black;
            txtEventID.Location = new Point(290, 97);
            txtEventID.Margin = new Padding(2);
            txtEventID.Name = "txtEventID";
            txtEventID.Size = new Size(293, 20);
            txtEventID.TabIndex = 49;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Enabled = false;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(109, 88);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(61, 32);
            label5.TabIndex = 48;
            label5.Text = "ID : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Enabled = false;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(109, 294);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(160, 32);
            label4.TabIndex = 46;
            label4.Text = "Ticket Price :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Enabled = false;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(109, 222);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(168, 32);
            label3.TabIndex = 44;
            label3.Text = "Event Venue :";
            // 
            // btnEventRset
            // 
            btnEventRset.BackColor = Color.FromArgb(192, 0, 192);
            btnEventRset.FlatStyle = FlatStyle.Popup;
            btnEventRset.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEventRset.ForeColor = Color.White;
            btnEventRset.Location = new Point(368, 368);
            btnEventRset.Margin = new Padding(2);
            btnEventRset.Name = "btnEventRset";
            btnEventRset.Size = new Size(132, 39);
            btnEventRset.TabIndex = 43;
            btnEventRset.Text = "Reset";
            btnEventRset.UseVisualStyleBackColor = false;
            // 
            // btnEventAdd
            // 
            btnEventAdd.BackColor = Color.FromArgb(192, 0, 192);
            btnEventAdd.FlatStyle = FlatStyle.Popup;
            btnEventAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEventAdd.ForeColor = Color.White;
            btnEventAdd.Location = new Point(165, 368);
            btnEventAdd.Margin = new Padding(2);
            btnEventAdd.Name = "btnEventAdd";
            btnEventAdd.Size = new Size(132, 39);
            btnEventAdd.TabIndex = 42;
            btnEventAdd.Text = "Add";
            btnEventAdd.UseVisualStyleBackColor = false;
            btnEventAdd.Click += btnEventAdd_Click;
            // 
            // txtEventTypeee
            // 
            txtEventTypeee.BackColor = Color.White;
            txtEventTypeee.BorderStyle = BorderStyle.None;
            txtEventTypeee.ForeColor = Color.Black;
            txtEventTypeee.Location = new Point(290, 186);
            txtEventTypeee.Margin = new Padding(2);
            txtEventTypeee.Name = "txtEventTypeee";
            txtEventTypeee.Size = new Size(293, 20);
            txtEventTypeee.TabIndex = 41;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(109, 174);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(152, 32);
            label2.TabIndex = 40;
            label2.Text = "Event Type :";
            // 
            // txtEventName
            // 
            txtEventName.BackColor = Color.White;
            txtEventName.BorderStyle = BorderStyle.None;
            txtEventName.ForeColor = Color.Black;
            txtEventName.Location = new Point(290, 145);
            txtEventName.Margin = new Padding(2);
            txtEventName.Name = "txtEventName";
            txtEventName.Size = new Size(293, 20);
            txtEventName.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(109, 136);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(172, 32);
            label1.TabIndex = 38;
            label1.Text = "Event Name : ";
            // 
            // txtEventVenue
            // 
            txtEventVenue.BackColor = Color.White;
            txtEventVenue.BorderStyle = BorderStyle.None;
            txtEventVenue.ForeColor = Color.Black;
            txtEventVenue.Location = new Point(290, 231);
            txtEventVenue.Margin = new Padding(2);
            txtEventVenue.Name = "txtEventVenue";
            txtEventVenue.Size = new Size(293, 20);
            txtEventVenue.TabIndex = 51;
            // 
            // txtEventTicket
            // 
            txtEventTicket.BackColor = Color.White;
            txtEventTicket.BorderStyle = BorderStyle.None;
            txtEventTicket.ForeColor = Color.Black;
            txtEventTicket.Location = new Point(290, 303);
            txtEventTicket.Margin = new Padding(2);
            txtEventTicket.Name = "txtEventTicket";
            txtEventTicket.Size = new Size(293, 20);
            txtEventTicket.TabIndex = 52;
            // 
            // txtEventTicketquantity
            // 
            txtEventTicketquantity.BackColor = Color.White;
            txtEventTicketquantity.BorderStyle = BorderStyle.None;
            txtEventTicketquantity.ForeColor = Color.Black;
            txtEventTicketquantity.Location = new Point(290, 269);
            txtEventTicketquantity.Margin = new Padding(2);
            txtEventTicketquantity.Name = "txtEventTicketquantity";
            txtEventTicketquantity.Size = new Size(293, 20);
            txtEventTicketquantity.TabIndex = 54;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Enabled = false;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(109, 260);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(107, 32);
            label6.TabIndex = 53;
            label6.Text = "Tickets :";
            // 
            // AddEvents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(650, 489);
            Controls.Add(txtEventTicketquantity);
            Controls.Add(label6);
            Controls.Add(txtEventTicket);
            Controls.Add(txtEventVenue);
            Controls.Add(linkGoBack);
            Controls.Add(txtEventID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnEventRset);
            Controls.Add(btnEventAdd);
            Controls.Add(txtEventTypeee);
            Controls.Add(label2);
            Controls.Add(txtEventName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "AddEvents";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddEvents";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkGoBack;
        private TextBox txtEventID;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnEventRset;
        private Button btnEventAdd;
        private TextBox txtEventType;
        private Label label2;
        private TextBox txtEventName;
        private Label label1;
        private TextBox aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaatxtEventTicket;
        private TextBox txtEventVenue;
        private TextBox txtEventTicket;
        private TextBox txtEventTypeee;
        private TextBox txtEventTicketquantity;
        private Label label6;
    }
}