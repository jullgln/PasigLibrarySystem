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
            searchtxt = new TextBox();
            searchbtn = new Button();
            tableview = new DataGridView();
            editbtn = new Button();
            deletebtn = new Button();
            addbtn = new Button();
            viewdetailsbtn = new Button();
            taskbarpanel = new Panel();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            circlbl = new Label();
            panel = new Panel();
            pictureBox7 = new PictureBox();
            memberlbl = new Label();
            highlightpanel = new Panel();
            pictureBox8 = new PictureBox();
            BookManagelbl = new Label();
            panel3 = new Panel();
            pictureBox9 = new PictureBox();
            rep_invlbl = new Label();
            headerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tableview).BeginInit();
            taskbarpanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            highlightpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
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
            headerpanel.Location = new Point(-17, 0);
            headerpanel.Margin = new Padding(3, 4, 3, 4);
            headerpanel.Name = "headerpanel";
            headerpanel.Size = new Size(1504, 117);
            headerpanel.TabIndex = 4;
            // 
            // LogOutbtn
            // 
            LogOutbtn.FlatStyle = FlatStyle.Flat;
            LogOutbtn.Font = new Font("Poppins", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogOutbtn.Location = new Point(1268, 41);
            LogOutbtn.Margin = new Padding(3, 4, 3, 4);
            LogOutbtn.Name = "LogOutbtn";
            LogOutbtn.Size = new Size(164, 35);
            LogOutbtn.TabIndex = 17;
            LogOutbtn.Text = " Log Out";
            LogOutbtn.TextAlign = ContentAlignment.BottomCenter;
            LogOutbtn.UseVisualStyleBackColor = true;
            LogOutbtn.Click += LogOutbtn_Click;
            // 
            // welcomelbl
            // 
            welcomelbl.AutoSize = true;
            welcomelbl.Font = new Font("Poppins", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            welcomelbl.ForeColor = Color.White;
            welcomelbl.Location = new Point(1066, 41);
            welcomelbl.Name = "welcomelbl";
            welcomelbl.Size = new Size(195, 40);
            welcomelbl.TabIndex = 7;
            welcomelbl.Text = "Welcome, User!";
            welcomelbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // H1
            // 
            H1.AutoSize = true;
            H1.Font = new Font("Poppins", 22F, FontStyle.Bold);
            H1.ForeColor = Color.White;
            H1.Location = new Point(179, 24);
            H1.Name = "H1";
            H1.Size = new Size(439, 65);
            H1.TabIndex = 6;
            H1.Text = "Public Library System";
            H1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(39, -24);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // searchtxt
            // 
            searchtxt.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchtxt.Location = new Point(319, 164);
            searchtxt.Margin = new Padding(3, 4, 3, 4);
            searchtxt.Name = "searchtxt";
            searchtxt.PlaceholderText = "Search by Title, Author, Category or ISBN";
            searchtxt.Size = new Size(465, 37);
            searchtxt.TabIndex = 57;
            // 
            // searchbtn
            // 
            searchbtn.FlatStyle = FlatStyle.Flat;
            searchbtn.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchbtn.Location = new Point(824, 165);
            searchbtn.Margin = new Padding(3, 4, 3, 4);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(143, 43);
            searchbtn.TabIndex = 56;
            searchbtn.Text = "Search";
            searchbtn.UseVisualStyleBackColor = true;
            searchbtn.Click += searchbtn_Click;
            // 
            // tableview
            // 
            tableview.AllowUserToAddRows = false;
            tableview.AllowUserToDeleteRows = false;
            tableview.BackgroundColor = Color.White;
            tableview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            tableview.DefaultCellStyle = dataGridViewCellStyle1;
            tableview.Location = new Point(319, 251);
            tableview.Margin = new Padding(3, 4, 3, 4);
            tableview.Name = "tableview";
            tableview.ReadOnly = true;
            tableview.RowHeadersWidth = 51;
            tableview.Size = new Size(1075, 508);
            tableview.TabIndex = 58;
            // 
            // editbtn
            // 
            editbtn.FlatStyle = FlatStyle.Flat;
            editbtn.Font = new Font("Poppins", 10.2F, FontStyle.Bold);
            editbtn.Location = new Point(1251, 795);
            editbtn.Margin = new Padding(3, 4, 3, 4);
            editbtn.Name = "editbtn";
            editbtn.Size = new Size(143, 43);
            editbtn.TabIndex = 59;
            editbtn.Text = "Edit";
            editbtn.UseVisualStyleBackColor = true;
            editbtn.Click += editbtn_Click;
            // 
            // deletebtn
            // 
            deletebtn.FlatStyle = FlatStyle.Flat;
            deletebtn.Font = new Font("Poppins", 10.2F, FontStyle.Bold);
            deletebtn.Location = new Point(1070, 795);
            deletebtn.Margin = new Padding(3, 4, 3, 4);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(143, 43);
            deletebtn.TabIndex = 60;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = true;
            deletebtn.Click += deletebtn_Click;
            // 
            // addbtn
            // 
            addbtn.FlatStyle = FlatStyle.Flat;
            addbtn.Font = new Font("Poppins", 10.2F, FontStyle.Bold);
            addbtn.Location = new Point(319, 795);
            addbtn.Margin = new Padding(3, 4, 3, 4);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(143, 43);
            addbtn.TabIndex = 61;
            addbtn.Text = "Add Book";
            addbtn.UseVisualStyleBackColor = true;
            addbtn.Click += button3_Click;
            // 
            // viewdetailsbtn
            // 
            viewdetailsbtn.FlatStyle = FlatStyle.Flat;
            viewdetailsbtn.Font = new Font("Poppins", 10.2F, FontStyle.Bold);
            viewdetailsbtn.Location = new Point(506, 795);
            viewdetailsbtn.Margin = new Padding(3, 4, 3, 4);
            viewdetailsbtn.Name = "viewdetailsbtn";
            viewdetailsbtn.Size = new Size(143, 43);
            viewdetailsbtn.TabIndex = 62;
            viewdetailsbtn.Text = "View Details";
            viewdetailsbtn.UseVisualStyleBackColor = true;
            viewdetailsbtn.Click += button4_Click;
            // 
            // taskbarpanel
            // 
            taskbarpanel.BackColor = Color.White;
            taskbarpanel.Controls.Add(panel1);
            taskbarpanel.Controls.Add(panel);
            taskbarpanel.Controls.Add(highlightpanel);
            taskbarpanel.Controls.Add(panel3);
            taskbarpanel.Location = new Point(-1, 104);
            taskbarpanel.Margin = new Padding(3, 4, 3, 4);
            taskbarpanel.Name = "taskbarpanel";
            taskbarpanel.Size = new Size(270, 803);
            taskbarpanel.TabIndex = 64;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(circlbl);
            panel1.Location = new Point(-6, 572);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(329, 109);
            panel1.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(38, 29);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // circlbl
            // 
            circlbl.AutoSize = true;
            circlbl.Font = new Font("Poppins", 12F);
            circlbl.ForeColor = Color.FromArgb(15, 46, 103);
            circlbl.Location = new Point(85, 17);
            circlbl.Name = "circlbl";
            circlbl.Size = new Size(152, 72);
            circlbl.TabIndex = 7;
            circlbl.Text = "Circulation\r\nManagement";
            circlbl.Click += circlbl_Click;
            // 
            // panel
            // 
            panel.BackColor = Color.Transparent;
            panel.Controls.Add(pictureBox7);
            panel.Controls.Add(memberlbl);
            panel.Location = new Point(-9, 168);
            panel.Margin = new Padding(3, 4, 3, 4);
            panel.Name = "panel";
            panel.Size = new Size(329, 109);
            panel.TabIndex = 8;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(38, 28);
            pictureBox7.Margin = new Padding(3, 4, 3, 4);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(42, 49);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 0;
            pictureBox7.TabStop = false;
            // 
            // memberlbl
            // 
            memberlbl.AutoSize = true;
            memberlbl.Font = new Font("Poppins", 12F);
            memberlbl.ForeColor = Color.Black;
            memberlbl.Location = new Point(81, 17);
            memberlbl.Name = "memberlbl";
            memberlbl.Size = new Size(152, 72);
            memberlbl.TabIndex = 7;
            memberlbl.Text = "Member \r\nManagement";
            memberlbl.Click += memberlbl_Click;
            // 
            // highlightpanel
            // 
            highlightpanel.BackColor = Color.Black;
            highlightpanel.Controls.Add(pictureBox8);
            highlightpanel.Controls.Add(BookManagelbl);
            highlightpanel.Location = new Point(-13, 303);
            highlightpanel.Margin = new Padding(3, 4, 3, 4);
            highlightpanel.Name = "highlightpanel";
            highlightpanel.Size = new Size(329, 109);
            highlightpanel.TabIndex = 2;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(38, 27);
            pictureBox8.Margin = new Padding(3, 4, 3, 4);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(42, 49);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 0;
            pictureBox8.TabStop = false;
            // 
            // BookManagelbl
            // 
            BookManagelbl.AutoSize = true;
            BookManagelbl.Font = new Font("Poppins", 12F);
            BookManagelbl.ForeColor = Color.White;
            BookManagelbl.Location = new Point(85, 16);
            BookManagelbl.Name = "BookManagelbl";
            BookManagelbl.Size = new Size(152, 72);
            BookManagelbl.TabIndex = 7;
            BookManagelbl.Text = "Book\r\nManagement";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(pictureBox9);
            panel3.Controls.Add(rep_invlbl);
            panel3.Location = new Point(-8, 433);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(329, 109);
            panel3.TabIndex = 2;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(38, 29);
            pictureBox9.Margin = new Padding(3, 4, 3, 4);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(42, 49);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 0;
            pictureBox9.TabStop = false;
            // 
            // rep_invlbl
            // 
            rep_invlbl.AutoSize = true;
            rep_invlbl.Font = new Font("Poppins", 12F);
            rep_invlbl.ForeColor = Color.FromArgb(15, 46, 103);
            rep_invlbl.Location = new Point(85, 17);
            rep_invlbl.Name = "rep_invlbl";
            rep_invlbl.Size = new Size(136, 72);
            rep_invlbl.TabIndex = 7;
            rep_invlbl.Text = "Reports and\r\n Inventory";
            rep_invlbl.Click += rep_invlbl_Click;
            // 
            // AdminBookManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 903);
            Controls.Add(viewdetailsbtn);
            Controls.Add(addbtn);
            Controls.Add(deletebtn);
            Controls.Add(editbtn);
            Controls.Add(tableview);
            Controls.Add(searchtxt);
            Controls.Add(searchbtn);
            Controls.Add(headerpanel);
            Controls.Add(taskbarpanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminBookManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "S";
            Load += AdminBookManagement_Load;
            headerpanel.ResumeLayout(false);
            headerpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tableview).EndInit();
            taskbarpanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            highlightpanel.ResumeLayout(false);
            highlightpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel headerpanel;
        private Button LogOutbtn;
        private Label welcomelbl;
        private Label H1;
        private PictureBox pictureBox1;
        private TextBox searchtxt;
        private Button searchbtn;
        private DataGridView tableview;
        private Button editbtn;
        private Button deletebtn;
        private Button addbtn;
        private Button viewdetailsbtn;
        private Panel taskbarpanel;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label circlbl;
        private Panel panel;
        private PictureBox pictureBox7;
        private Label memberlbl;
        private Panel highlightpanel;
        private PictureBox pictureBox8;
        private Label BookManagelbl;
        private Panel panel3;
        private PictureBox pictureBox9;
        private Label rep_invlbl;
    }
}