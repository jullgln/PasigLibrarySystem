namespace PasigLibrarySystem.ADMIN
{
    partial class AdminMemberManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMemberManagement));
            headerpanel = new Panel();
            LogOutbtn = new Button();
            welcomelbl = new Label();
            H1 = new Label();
            pictureBox1 = new PictureBox();
            taskbarpanel = new Panel();
            panel = new Panel();
            pictureBox2 = new PictureBox();
            Homelbl = new Label();
            highlightpanel = new Panel();
            pictureBox7 = new PictureBox();
            memberlbl = new Label();
            panel2 = new Panel();
            pictureBox8 = new PictureBox();
            BookManagelbl = new Label();
            panel3 = new Panel();
            pictureBox9 = new PictureBox();
            rep_invlbl = new Label();
            panel4 = new Panel();
            pictureBox6 = new PictureBox();
            Settingslbl = new Label();
            headerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            taskbarpanel.SuspendLayout();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            highlightpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // headerpanel
            // 
            headerpanel.BackColor = Color.FromArgb(15, 46, 103);
            headerpanel.Controls.Add(LogOutbtn);
            headerpanel.Controls.Add(welcomelbl);
            headerpanel.Controls.Add(H1);
            headerpanel.Controls.Add(pictureBox1);
            headerpanel.ForeColor = SystemColors.ControlText;
            headerpanel.Location = new Point(-33, 0);
            headerpanel.Name = "headerpanel";
            headerpanel.Size = new Size(1316, 88);
            headerpanel.TabIndex = 4;
            // 
            // LogOutbtn
            // 
            LogOutbtn.FlatStyle = FlatStyle.Flat;
            LogOutbtn.Font = new Font("Poppins Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogOutbtn.Location = new Point(1160, 27);
            LogOutbtn.Name = "LogOutbtn";
            LogOutbtn.Size = new Size(93, 35);
            LogOutbtn.TabIndex = 17;
            LogOutbtn.Text = " Log Out";
            LogOutbtn.TextAlign = ContentAlignment.BottomCenter;
            LogOutbtn.UseVisualStyleBackColor = true;
            LogOutbtn.Click += LogOutbtn_Click;
            // 
            // welcomelbl
            // 
            welcomelbl.AutoSize = true;
            welcomelbl.Font = new Font("Poppins Light", 13F);
            welcomelbl.ForeColor = Color.White;
            welcomelbl.Location = new Point(1008, 31);
            welcomelbl.Name = "welcomelbl";
            welcomelbl.Size = new Size(150, 31);
            welcomelbl.TabIndex = 7;
            welcomelbl.Text = "Welcome, User!";
            welcomelbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // H1
            // 
            H1.AutoSize = true;
            H1.Font = new Font("Poppins", 22F, FontStyle.Bold);
            H1.ForeColor = Color.White;
            H1.Location = new Point(157, 18);
            H1.Name = "H1";
            H1.Size = new Size(354, 53);
            H1.TabIndex = 6;
            H1.Text = "Public Library System";
            H1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, -18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // taskbarpanel
            // 
            taskbarpanel.BackColor = Color.White;
            taskbarpanel.Controls.Add(panel);
            taskbarpanel.Controls.Add(highlightpanel);
            taskbarpanel.Controls.Add(panel2);
            taskbarpanel.Controls.Add(panel3);
            taskbarpanel.Controls.Add(panel4);
            taskbarpanel.Location = new Point(-1, 78);
            taskbarpanel.Name = "taskbarpanel";
            taskbarpanel.Size = new Size(236, 602);
            taskbarpanel.TabIndex = 5;
            // 
            // panel
            // 
            panel.BackColor = Color.Transparent;
            panel.Controls.Add(pictureBox2);
            panel.Controls.Add(Homelbl);
            panel.Location = new Point(-9, 26);
            panel.Name = "panel";
            panel.Size = new Size(288, 82);
            panel.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(33, 19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // Homelbl
            // 
            Homelbl.AutoSize = true;
            Homelbl.Font = new Font("Poppins", 13F);
            Homelbl.ForeColor = Color.FromArgb(15, 46, 103);
            Homelbl.Location = new Point(74, 26);
            Homelbl.Name = "Homelbl";
            Homelbl.Size = new Size(68, 31);
            Homelbl.TabIndex = 7;
            Homelbl.Text = "Home";
            Homelbl.TextAlign = ContentAlignment.TopCenter;
            Homelbl.Click += Homelbl_Click;
            // 
            // highlightpanel
            // 
            highlightpanel.BackColor = Color.Black;
            highlightpanel.Controls.Add(pictureBox7);
            highlightpanel.Controls.Add(memberlbl);
            highlightpanel.Location = new Point(-8, 126);
            highlightpanel.Name = "highlightpanel";
            highlightpanel.Size = new Size(288, 82);
            highlightpanel.TabIndex = 8;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(33, 21);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(37, 37);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 0;
            pictureBox7.TabStop = false;
            // 
            // memberlbl
            // 
            memberlbl.AutoSize = true;
            memberlbl.Font = new Font("Poppins", 12F);
            memberlbl.ForeColor = Color.White;
            memberlbl.Location = new Point(71, 13);
            memberlbl.Name = "memberlbl";
            memberlbl.Size = new Size(121, 56);
            memberlbl.TabIndex = 7;
            memberlbl.Text = "Member \r\nManagement";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(pictureBox8);
            panel2.Controls.Add(BookManagelbl);
            panel2.Location = new Point(-11, 227);
            panel2.Name = "panel2";
            panel2.Size = new Size(288, 82);
            panel2.TabIndex = 2;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(33, 20);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(37, 37);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 0;
            pictureBox8.TabStop = false;
            // 
            // BookManagelbl
            // 
            BookManagelbl.AutoSize = true;
            BookManagelbl.Font = new Font("Poppins", 12F);
            BookManagelbl.ForeColor = Color.FromArgb(15, 46, 103);
            BookManagelbl.Location = new Point(74, 12);
            BookManagelbl.Name = "BookManagelbl";
            BookManagelbl.Size = new Size(121, 56);
            BookManagelbl.TabIndex = 7;
            BookManagelbl.Text = "Book\r\nManagement";
            BookManagelbl.Click += BookManagelbl_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(pictureBox9);
            panel3.Controls.Add(rep_invlbl);
            panel3.Location = new Point(-7, 325);
            panel3.Name = "panel3";
            panel3.Size = new Size(288, 82);
            panel3.TabIndex = 2;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(33, 22);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(37, 37);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 0;
            pictureBox9.TabStop = false;
            // 
            // rep_invlbl
            // 
            rep_invlbl.AutoSize = true;
            rep_invlbl.Font = new Font("Poppins", 12F);
            rep_invlbl.ForeColor = Color.FromArgb(15, 46, 103);
            rep_invlbl.Location = new Point(74, 13);
            rep_invlbl.Name = "rep_invlbl";
            rep_invlbl.Size = new Size(109, 56);
            rep_invlbl.TabIndex = 7;
            rep_invlbl.Text = "Reports and\r\n Inventory";
            rep_invlbl.Click += rep_invlbl_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(pictureBox6);
            panel4.Controls.Add(Settingslbl);
            panel4.Location = new Point(-8, 497);
            panel4.Name = "panel4";
            panel4.Size = new Size(288, 82);
            panel4.TabIndex = 2;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(31, 21);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(37, 37);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 14;
            pictureBox6.TabStop = false;
            // 
            // Settingslbl
            // 
            Settingslbl.AutoSize = true;
            Settingslbl.Font = new Font("Poppins", 13F);
            Settingslbl.ForeColor = Color.FromArgb(15, 46, 103);
            Settingslbl.Location = new Point(71, 25);
            Settingslbl.Name = "Settingslbl";
            Settingslbl.Size = new Size(87, 31);
            Settingslbl.TabIndex = 15;
            Settingslbl.Text = "Settings";
            Settingslbl.TextAlign = ContentAlignment.TopCenter;
            Settingslbl.Click += Settingslbl_Click;
            // 
            // AdminMemberManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(headerpanel);
            Controls.Add(taskbarpanel);
            Name = "AdminMemberManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Member_Management";
            headerpanel.ResumeLayout(false);
            headerpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            taskbarpanel.ResumeLayout(false);
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            highlightpanel.ResumeLayout(false);
            highlightpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel headerpanel;
        private Button LogOutbtn;
        private Label welcomelbl;
        private Label H1;
        private PictureBox pictureBox1;
        private Panel taskbarpanel;
        private Panel panel;
        private PictureBox pictureBox2;
        private Label Homelbl;
        private Panel highlightpanel;
        private PictureBox pictureBox7;
        private Label memberlbl;
        private Panel panel2;
        private PictureBox pictureBox8;
        private Label BookManagelbl;
        private Panel panel3;
        private PictureBox pictureBox9;
        private Label rep_invlbl;
        private Panel panel4;
        private PictureBox pictureBox6;
        private Label Settingslbl;
    }
}