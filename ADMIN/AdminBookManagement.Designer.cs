namespace PasigLibrarySystem.ADMIN
{
    partial class AdminBookManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminBookManagement));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            headerpanel = new Panel();
            LogOutbtn = new Button();
            welcomelbl = new Label();
            H1 = new Label();
            pictureBox1 = new PictureBox();
            taskbarpanel = new Panel();
            panel1 = new Panel();
            pictureBox7 = new PictureBox();
            memberlbl = new Label();
            highlightpanel = new Panel();
            pictureBox8 = new PictureBox();
            BookManagelbl = new Label();
            panel3 = new Panel();
            pictureBox9 = new PictureBox();
            rep_invlbl = new Label();
            searchtxt = new TextBox();
            searchbtn = new Button();
            tableview = new DataGridView();
            editbtn = new Button();
            deletebtn = new Button();
            addbtn = new Button();
            viewdetailsbtn = new Button();
            filtertxt = new ComboBox();
            headerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            taskbarpanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            highlightpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tableview).BeginInit();
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
            welcomelbl.Location = new Point(946, 31);
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
            taskbarpanel.Controls.Add(panel1);
            taskbarpanel.Controls.Add(highlightpanel);
            taskbarpanel.Controls.Add(panel3);
            taskbarpanel.Location = new Point(-1, 78);
            taskbarpanel.Name = "taskbarpanel";
            taskbarpanel.Size = new Size(236, 602);
            taskbarpanel.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(memberlbl);
            panel1.Location = new Point(-8, 126);
            panel1.Name = "panel1";
            panel1.Size = new Size(288, 82);
            panel1.TabIndex = 8;
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
            memberlbl.ForeColor = Color.FromArgb(15, 46, 103);
            memberlbl.Location = new Point(71, 13);
            memberlbl.Name = "memberlbl";
            memberlbl.Size = new Size(121, 56);
            memberlbl.TabIndex = 7;
            memberlbl.Text = "Member \r\nManagement";
            memberlbl.Click += memberlbl_Click;
            // 
            // highlightpanel
            // 
            highlightpanel.BackColor = Color.Black;
            highlightpanel.Controls.Add(pictureBox8);
            highlightpanel.Controls.Add(BookManagelbl);
            highlightpanel.Location = new Point(-11, 227);
            highlightpanel.Name = "highlightpanel";
            highlightpanel.Size = new Size(288, 82);
            highlightpanel.TabIndex = 2;
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
            BookManagelbl.ForeColor = Color.White;
            BookManagelbl.Location = new Point(74, 12);
            BookManagelbl.Name = "BookManagelbl";
            BookManagelbl.Size = new Size(121, 56);
            BookManagelbl.TabIndex = 7;
            BookManagelbl.Text = "Book\r\nManagement";
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
            // searchtxt
            // 
            searchtxt.Font = new Font("Poppins", 12F);
            searchtxt.Location = new Point(279, 123);
            searchtxt.Name = "searchtxt";
            searchtxt.PlaceholderText = "Search by Title, Author, Category or ISBN";
            searchtxt.Size = new Size(407, 31);
            searchtxt.TabIndex = 57;
            // 
            // searchbtn
            // 
            searchbtn.FlatStyle = FlatStyle.Flat;
            searchbtn.Font = new Font("Poppins Medium", 10F, FontStyle.Bold);
            searchbtn.Location = new Point(721, 124);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(125, 32);
            searchbtn.TabIndex = 56;
            searchbtn.Text = "Search";
            searchbtn.UseVisualStyleBackColor = true;
            // 
            // tableview
            // 
            tableview.AllowUserToAddRows = false;
            tableview.AllowUserToDeleteRows = false;
            tableview.BackgroundColor = Color.White;
            tableview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            tableview.DefaultCellStyle = dataGridViewCellStyle1;
            tableview.Location = new Point(279, 188);
            tableview.Name = "tableview";
            tableview.ReadOnly = true;
            tableview.Size = new Size(941, 381);
            tableview.TabIndex = 58;
            // 
            // editbtn
            // 
            editbtn.FlatStyle = FlatStyle.Flat;
            editbtn.Font = new Font("Poppins Medium", 10F, FontStyle.Bold);
            editbtn.Location = new Point(1095, 596);
            editbtn.Name = "editbtn";
            editbtn.Size = new Size(125, 32);
            editbtn.TabIndex = 59;
            editbtn.Text = "Edit";
            editbtn.UseVisualStyleBackColor = true;
            editbtn.Click += editbtn_Click;
            // 
            // deletebtn
            // 
            deletebtn.FlatStyle = FlatStyle.Flat;
            deletebtn.Font = new Font("Poppins Medium", 10F, FontStyle.Bold);
            deletebtn.Location = new Point(936, 596);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(125, 32);
            deletebtn.TabIndex = 60;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = true;
            // 
            // addbtn
            // 
            addbtn.FlatStyle = FlatStyle.Flat;
            addbtn.Font = new Font("Poppins Medium", 10F, FontStyle.Bold);
            addbtn.Location = new Point(279, 596);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(125, 32);
            addbtn.TabIndex = 61;
            addbtn.Text = "Add Book";
            addbtn.UseVisualStyleBackColor = true;
            addbtn.Click += button3_Click;
            // 
            // viewdetailsbtn
            // 
            viewdetailsbtn.FlatStyle = FlatStyle.Flat;
            viewdetailsbtn.Font = new Font("Poppins Medium", 10F, FontStyle.Bold);
            viewdetailsbtn.Location = new Point(443, 596);
            viewdetailsbtn.Name = "viewdetailsbtn";
            viewdetailsbtn.Size = new Size(125, 32);
            viewdetailsbtn.TabIndex = 62;
            viewdetailsbtn.Text = "View Details";
            viewdetailsbtn.UseVisualStyleBackColor = true;
            viewdetailsbtn.Click += button4_Click;
            // 
            // filtertxt
            // 
            filtertxt.Font = new Font("Poppins", 10F);
            filtertxt.FormattingEnabled = true;
            filtertxt.Items.AddRange(new object[] { "Books", "Journal" });
            filtertxt.Location = new Point(874, 123);
            filtertxt.Name = "filtertxt";
            filtertxt.Size = new Size(121, 31);
            filtertxt.TabIndex = 63;
            // 
            // AdminBookManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(filtertxt);
            Controls.Add(viewdetailsbtn);
            Controls.Add(addbtn);
            Controls.Add(deletebtn);
            Controls.Add(editbtn);
            Controls.Add(tableview);
            Controls.Add(searchtxt);
            Controls.Add(searchbtn);
            Controls.Add(headerpanel);
            Controls.Add(taskbarpanel);
            Name = "AdminBookManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "S";
            headerpanel.ResumeLayout(false);
            headerpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            taskbarpanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            highlightpanel.ResumeLayout(false);
            highlightpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)tableview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel headerpanel;
        private Button LogOutbtn;
        private Label welcomelbl;
        private Label H1;
        private PictureBox pictureBox1;
        private Panel taskbarpanel;
        private Panel panel1;
        private PictureBox pictureBox7;
        private Label memberlbl;
        private Panel highlightpanel;
        private PictureBox pictureBox8;
        private Label BookManagelbl;
        private Panel panel3;
        private PictureBox pictureBox9;
        private Label rep_invlbl;
        private TextBox searchtxt;
        private Button searchbtn;
        private DataGridView tableview;
        private Button editbtn;
        private Button deletebtn;
        private Button addbtn;
        private Button viewdetailsbtn;
        private ComboBox filtertxt;
    }
}