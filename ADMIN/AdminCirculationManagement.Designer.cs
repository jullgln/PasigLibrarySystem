namespace PasigLibrarySystem.ADMIN
{
    partial class AdminCirculationManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminCirculationManagement));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            headerpanel = new Panel();
            LogOutbtn = new Button();
            welcomelbl = new Label();
            H1 = new Label();
            pictureBox1 = new PictureBox();
            taskbarpanel = new Panel();
            highlightpanel = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panel = new Panel();
            pictureBox7 = new PictureBox();
            memberlbl = new Label();
            panel2 = new Panel();
            pictureBox8 = new PictureBox();
            BookManagelbl = new Label();
            panel3 = new Panel();
            pictureBox9 = new PictureBox();
            rep_invlbl = new Label();
            cbxFilter = new ComboBox();
            dataGridView1 = new DataGridView();
            lbl3 = new Label();
            headerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            taskbarpanel.SuspendLayout();
            highlightpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            headerpanel.Location = new Point(-38, 0);
            headerpanel.Margin = new Padding(3, 4, 3, 4);
            headerpanel.Name = "headerpanel";
            headerpanel.Size = new Size(1504, 117);
            headerpanel.TabIndex = 5;
            // 
            // LogOutbtn
            // 
            LogOutbtn.FlatStyle = FlatStyle.Flat;
            LogOutbtn.Font = new Font("Poppins Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogOutbtn.Location = new Point(1271, 36);
            LogOutbtn.Margin = new Padding(3, 4, 3, 4);
            LogOutbtn.Name = "LogOutbtn";
            LogOutbtn.Size = new Size(161, 47);
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
            welcomelbl.Location = new Point(1066, 41);
            welcomelbl.Name = "welcomelbl";
            welcomelbl.Size = new Size(184, 39);
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
            // taskbarpanel
            // 
            taskbarpanel.BackColor = Color.White;
            taskbarpanel.Controls.Add(highlightpanel);
            taskbarpanel.Controls.Add(panel);
            taskbarpanel.Controls.Add(panel2);
            taskbarpanel.Controls.Add(panel3);
            taskbarpanel.Location = new Point(-1, 104);
            taskbarpanel.Margin = new Padding(3, 4, 3, 4);
            taskbarpanel.Name = "taskbarpanel";
            taskbarpanel.Size = new Size(270, 803);
            taskbarpanel.TabIndex = 6;
            // 
            // highlightpanel
            // 
            highlightpanel.BackColor = Color.Black;
            highlightpanel.Controls.Add(pictureBox2);
            highlightpanel.Controls.Add(label1);
            highlightpanel.Location = new Point(-6, 572);
            highlightpanel.Margin = new Padding(3, 4, 3, 4);
            highlightpanel.Name = "highlightpanel";
            highlightpanel.Size = new Size(329, 109);
            highlightpanel.TabIndex = 8;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(85, 17);
            label1.Name = "label1";
            label1.Size = new Size(152, 72);
            label1.TabIndex = 7;
            label1.Text = "Circulation\r\nManagement";
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
            memberlbl.ForeColor = Color.FromArgb(15, 46, 103);
            memberlbl.Location = new Point(81, 17);
            memberlbl.Name = "memberlbl";
            memberlbl.Size = new Size(152, 72);
            memberlbl.TabIndex = 7;
            memberlbl.Text = "Member \r\nManagement";
            memberlbl.Click += memberlbl_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(pictureBox8);
            panel2.Controls.Add(BookManagelbl);
            panel2.Location = new Point(-13, 303);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(329, 109);
            panel2.TabIndex = 2;
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
            BookManagelbl.ForeColor = Color.FromArgb(15, 46, 103);
            BookManagelbl.Location = new Point(85, 16);
            BookManagelbl.Name = "BookManagelbl";
            BookManagelbl.Size = new Size(152, 72);
            BookManagelbl.TabIndex = 7;
            BookManagelbl.Text = "Book\r\nManagement";
            BookManagelbl.Click += BookManagelbl_Click;
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
            // cbxFilter
            // 
            cbxFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxFilter.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxFilter.FormattingEnabled = true;
            cbxFilter.Items.AddRange(new object[] { "ALL", "BORROWED", "RETURNED", "RESERVED", "LOST" });
            cbxFilter.Location = new Point(448, 169);
            cbxFilter.Name = "cbxFilter";
            cbxFilter.Size = new Size(151, 34);
            cbxFilter.TabIndex = 7;
            cbxFilter.SelectedIndexChanged += cbxFilter_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(326, 250);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1045, 577);
            dataGridView1.TabIndex = 8;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Poppins", 13F);
            lbl3.ForeColor = Color.FromArgb(15, 46, 103);
            lbl3.Location = new Point(326, 169);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(106, 39);
            lbl3.TabIndex = 68;
            lbl3.Text = "Filter by:";
            lbl3.TextAlign = ContentAlignment.TopCenter;
            // 
            // AdminCirculationManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 908);
            Controls.Add(lbl3);
            Controls.Add(dataGridView1);
            Controls.Add(cbxFilter);
            Controls.Add(headerpanel);
            Controls.Add(taskbarpanel);
            Name = "AdminCirculationManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminCirculationManagement";
            Load += AdminCirculationManagement_Load;
            headerpanel.ResumeLayout(false);
            headerpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            taskbarpanel.ResumeLayout(false);
            highlightpanel.ResumeLayout(false);
            highlightpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Panel highlightpanel;
        private PictureBox pictureBox2;
        private Label label1;
        private Panel panel;
        private PictureBox pictureBox7;
        private Label memberlbl;
        private Panel panel2;
        private PictureBox pictureBox8;
        private Label BookManagelbl;
        private Panel panel3;
        private PictureBox pictureBox9;
        private Label rep_invlbl;
        private ComboBox cbxFilter;
        private DataGridView dataGridView1;
        private Label lbl3;
    }
}