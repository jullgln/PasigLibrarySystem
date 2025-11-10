namespace PasigLibrarySystem.USER
{
    partial class ReserveForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReserveForm));
            headerpanel = new Panel();
            H1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            lbl7 = new Label();
            displayborrowdate = new Label();
            lbl6 = new Label();
            displaybooktitle = new Label();
            displaybookid = new Label();
            lbl4 = new Label();
            lbl3 = new Label();
            displayname = new Label();
            lbl1 = new Label();
            Cancelbtn = new Button();
            reservebtn = new Button();
            headerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // headerpanel
            // 
            headerpanel.BackColor = Color.FromArgb(15, 46, 103);
            headerpanel.Controls.Add(H1);
            headerpanel.Controls.Add(pictureBox1);
            headerpanel.ForeColor = SystemColors.ControlText;
            headerpanel.Location = new Point(-16, 0);
            headerpanel.Name = "headerpanel";
            headerpanel.Size = new Size(918, 88);
            headerpanel.TabIndex = 5;
            // 
            // H1
            // 
            H1.AutoSize = true;
            H1.Font = new Font("Poppins", 22F, FontStyle.Bold);
            H1.ForeColor = Color.White;
            H1.Location = new Point(140, 18);
            H1.Name = "H1";
            H1.Size = new Size(294, 53);
            H1.TabIndex = 6;
            H1.Text = "Reservation Form";
            H1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, -18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lbl7);
            groupBox1.Controls.Add(displayborrowdate);
            groupBox1.Controls.Add(lbl6);
            groupBox1.Controls.Add(displaybooktitle);
            groupBox1.Controls.Add(displaybookid);
            groupBox1.Controls.Add(lbl4);
            groupBox1.Controls.Add(lbl3);
            groupBox1.Location = new Point(29, 159);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(821, 256);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Light", 12F);
            label1.Location = new Point(206, 198);
            label1.Name = "label1";
            label1.Size = new Size(105, 28);
            label1.TabIndex = 30;
            label1.Text = "Return Date";
            // 
            // lbl7
            // 
            lbl7.AutoSize = true;
            lbl7.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl7.ForeColor = Color.FromArgb(15, 46, 103);
            lbl7.Location = new Point(22, 198);
            lbl7.Name = "lbl7";
            lbl7.Size = new Size(103, 28);
            lbl7.TabIndex = 29;
            lbl7.Text = "Valid Until";
            // 
            // displayborrowdate
            // 
            displayborrowdate.AutoSize = true;
            displayborrowdate.Font = new Font("Poppins Light", 12F);
            displayborrowdate.Location = new Point(206, 140);
            displayborrowdate.Name = "displayborrowdate";
            displayborrowdate.Size = new Size(109, 28);
            displayborrowdate.TabIndex = 28;
            displayborrowdate.Text = "Borrow Date";
            // 
            // lbl6
            // 
            lbl6.AutoSize = true;
            lbl6.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl6.ForeColor = Color.FromArgb(15, 46, 103);
            lbl6.Location = new Point(22, 140);
            lbl6.Name = "lbl6";
            lbl6.Size = new Size(165, 28);
            lbl6.TabIndex = 27;
            lbl6.Text = "Reservation Date";
            // 
            // displaybooktitle
            // 
            displaybooktitle.AutoSize = true;
            displaybooktitle.Font = new Font("Poppins Light", 12F);
            displaybooktitle.Location = new Point(206, 84);
            displaybooktitle.Name = "displaybooktitle";
            displaybooktitle.Size = new Size(69, 28);
            displaybooktitle.TabIndex = 23;
            displaybooktitle.Text = "Book ID";
            // 
            // displaybookid
            // 
            displaybookid.AutoSize = true;
            displaybookid.Font = new Font("Poppins Light", 12F);
            displaybookid.Location = new Point(206, 29);
            displaybookid.Name = "displaybookid";
            displaybookid.Size = new Size(69, 28);
            displaybookid.TabIndex = 22;
            displaybookid.Text = "Book ID";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl4.ForeColor = Color.FromArgb(15, 46, 103);
            lbl4.Location = new Point(22, 84);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(98, 28);
            lbl4.TabIndex = 20;
            lbl4.Text = "Book Title";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3.ForeColor = Color.FromArgb(15, 46, 103);
            lbl3.Location = new Point(22, 29);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(77, 28);
            lbl3.TabIndex = 19;
            lbl3.Text = "Book ID";
            // 
            // displayname
            // 
            displayname.AutoSize = true;
            displayname.Font = new Font("Poppins Light", 12F);
            displayname.Location = new Point(130, 109);
            displayname.Name = "displayname";
            displayname.Size = new Size(117, 28);
            displayname.TabIndex = 26;
            displayname.Text = "namedisplay";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1.ForeColor = Color.FromArgb(15, 46, 103);
            lbl1.Location = new Point(51, 109);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(66, 28);
            lbl1.TabIndex = 25;
            lbl1.Text = "Name";
            // 
            // Cancelbtn
            // 
            Cancelbtn.FlatStyle = FlatStyle.Flat;
            Cancelbtn.Font = new Font("Poppins Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cancelbtn.Location = new Point(618, 447);
            Cancelbtn.Name = "Cancelbtn";
            Cancelbtn.Size = new Size(103, 32);
            Cancelbtn.TabIndex = 28;
            Cancelbtn.Text = "Cancel";
            Cancelbtn.UseVisualStyleBackColor = true;
            // 
            // reservebtn
            // 
            reservebtn.FlatStyle = FlatStyle.Flat;
            reservebtn.Font = new Font("Poppins Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reservebtn.Location = new Point(747, 447);
            reservebtn.Name = "reservebtn";
            reservebtn.Size = new Size(103, 32);
            reservebtn.TabIndex = 27;
            reservebtn.Text = "Reserve";
            reservebtn.UseVisualStyleBackColor = true;
            // 
            // ReserveBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 511);
            Controls.Add(Cancelbtn);
            Controls.Add(reservebtn);
            Controls.Add(displayname);
            Controls.Add(lbl1);
            Controls.Add(groupBox1);
            Controls.Add(headerpanel);
            Name = "ReserveBookForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReserveBooks";
            headerpanel.ResumeLayout(false);
            headerpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel headerpanel;
        private Label H1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label1;
        private Label lbl7;
        private Label displayborrowdate;
        private Label lbl6;
        private Label displaybooktitle;
        private Label displaybookid;
        private Label lbl4;
        private Label lbl3;
        private Label displayname;
        private Label lbl1;
        private Button Cancelbtn;
        private Button reservebtn;
    }
}