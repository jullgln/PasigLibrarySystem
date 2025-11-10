namespace PasigLibrarySystem.USER
{
    partial class BorrowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowForm));
            headerpanel = new Panel();
            H1 = new Label();
            pictureBox1 = new PictureBox();
            lbl1 = new Label();
            lbl2 = new Label();
            displayname = new Label();
            displayemail = new Label();
            groupBox1 = new GroupBox();
            authortxt = new Label();
            titletxt = new Label();
            idtxt = new Label();
            lbl5 = new Label();
            lbl4 = new Label();
            lbl3 = new Label();
            lbl6 = new Label();
            lbl7 = new Label();
            borrowbtn = new Button();
            Cancelbtn = new Button();
            borrowdatetxt = new Label();
            datepicker = new DateTimePicker();
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
            headerpanel.TabIndex = 2;
            // 
            // H1
            // 
            H1.AutoSize = true;
            H1.Font = new Font("Poppins", 22F, FontStyle.Bold);
            H1.ForeColor = Color.White;
            H1.Location = new Point(140, 18);
            H1.Name = "H1";
            H1.Size = new Size(351, 53);
            H1.TabIndex = 6;
            H1.Text = "Book Borrowing Form";
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
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1.ForeColor = Color.FromArgb(15, 46, 103);
            lbl1.Location = new Point(29, 126);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(66, 28);
            lbl1.TabIndex = 13;
            lbl1.Text = "Name";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2.ForeColor = Color.FromArgb(15, 46, 103);
            lbl2.Location = new Point(488, 126);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(61, 28);
            lbl2.TabIndex = 15;
            lbl2.Text = "Email";
            // 
            // displayname
            // 
            displayname.AutoSize = true;
            displayname.Font = new Font("Poppins Light", 12F);
            displayname.Location = new Point(108, 126);
            displayname.Name = "displayname";
            displayname.Size = new Size(117, 28);
            displayname.TabIndex = 16;
            displayname.Text = "namedisplay";
            // 
            // displayemail
            // 
            displayemail.AutoSize = true;
            displayemail.Font = new Font("Poppins Light", 12F);
            displayemail.Location = new Point(559, 126);
            displayemail.Name = "displayemail";
            displayemail.Size = new Size(115, 28);
            displayemail.TabIndex = 17;
            displayemail.Text = "emaildisplay";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(authortxt);
            groupBox1.Controls.Add(titletxt);
            groupBox1.Controls.Add(idtxt);
            groupBox1.Controls.Add(lbl5);
            groupBox1.Controls.Add(lbl4);
            groupBox1.Controls.Add(lbl3);
            groupBox1.Location = new Point(29, 176);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(827, 177);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            // 
            // authortxt
            // 
            authortxt.AutoSize = true;
            authortxt.Font = new Font("Poppins Light", 12F);
            authortxt.Location = new Point(156, 128);
            authortxt.Name = "authortxt";
            authortxt.Size = new Size(69, 28);
            authortxt.TabIndex = 24;
            authortxt.Text = "Book ID";
            // 
            // titletxt
            // 
            titletxt.AutoSize = true;
            titletxt.Font = new Font("Poppins Light", 12F);
            titletxt.Location = new Point(156, 76);
            titletxt.Name = "titletxt";
            titletxt.Size = new Size(69, 28);
            titletxt.TabIndex = 23;
            titletxt.Text = "Book ID";
            // 
            // idtxt
            // 
            idtxt.AutoSize = true;
            idtxt.Font = new Font("Poppins Light", 12F);
            idtxt.Location = new Point(156, 24);
            idtxt.Name = "idtxt";
            idtxt.Size = new Size(69, 28);
            idtxt.TabIndex = 22;
            idtxt.Text = "Book ID";
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl5.ForeColor = Color.FromArgb(15, 46, 103);
            lbl5.Location = new Point(22, 128);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(71, 28);
            lbl5.TabIndex = 21;
            lbl5.Text = "Author";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl4.ForeColor = Color.FromArgb(15, 46, 103);
            lbl4.Location = new Point(22, 76);
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
            lbl3.Location = new Point(22, 24);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(77, 28);
            lbl3.TabIndex = 19;
            lbl3.Text = "Book ID";
            // 
            // lbl6
            // 
            lbl6.AutoSize = true;
            lbl6.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl6.ForeColor = Color.FromArgb(15, 46, 103);
            lbl6.Location = new Point(51, 373);
            lbl6.Name = "lbl6";
            lbl6.Size = new Size(120, 28);
            lbl6.TabIndex = 22;
            lbl6.Text = "Borrow Date";
            // 
            // lbl7
            // 
            lbl7.AutoSize = true;
            lbl7.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl7.ForeColor = Color.FromArgb(15, 46, 103);
            lbl7.Location = new Point(51, 417);
            lbl7.Name = "lbl7";
            lbl7.Size = new Size(117, 28);
            lbl7.TabIndex = 23;
            lbl7.Text = "Return Date";
            // 
            // borrowbtn
            // 
            borrowbtn.FlatStyle = FlatStyle.Flat;
            borrowbtn.Font = new Font("Poppins Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            borrowbtn.Location = new Point(751, 448);
            borrowbtn.Name = "borrowbtn";
            borrowbtn.Size = new Size(103, 32);
            borrowbtn.TabIndex = 24;
            borrowbtn.Text = "Borrow";
            borrowbtn.UseVisualStyleBackColor = true;
            borrowbtn.Click += borrowbtn_Click;
            // 
            // Cancelbtn
            // 
            Cancelbtn.FlatStyle = FlatStyle.Flat;
            Cancelbtn.Font = new Font("Poppins Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cancelbtn.Location = new Point(622, 448);
            Cancelbtn.Name = "Cancelbtn";
            Cancelbtn.Size = new Size(103, 32);
            Cancelbtn.TabIndex = 25;
            Cancelbtn.Text = "Cancel";
            Cancelbtn.UseVisualStyleBackColor = true;
            Cancelbtn.Click += Cancelbtn_Click;
            // 
            // borrowdatetxt
            // 
            borrowdatetxt.AutoSize = true;
            borrowdatetxt.Font = new Font("Poppins Light", 12F);
            borrowdatetxt.Location = new Point(185, 373);
            borrowdatetxt.Name = "borrowdatetxt";
            borrowdatetxt.Size = new Size(109, 28);
            borrowdatetxt.TabIndex = 26;
            borrowdatetxt.Text = "Borrow Date";
            // 
            // datepicker
            // 
            datepicker.CalendarFont = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            datepicker.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datepicker.Location = new Point(185, 417);
            datepicker.MinDate = new DateTime(2025, 11, 10, 0, 0, 0, 0);
            datepicker.Name = "datepicker";
            datepicker.Size = new Size(237, 25);
            datepicker.TabIndex = 27;
            // 
            // BorrowForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 511);
            Controls.Add(datepicker);
            Controls.Add(borrowdatetxt);
            Controls.Add(Cancelbtn);
            Controls.Add(borrowbtn);
            Controls.Add(lbl7);
            Controls.Add(lbl6);
            Controls.Add(groupBox1);
            Controls.Add(displayemail);
            Controls.Add(displayname);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(headerpanel);
            Name = "BorrowForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserBorrowForm";
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
        private Label lbl1;
        private Label lbl2;
        private Label displayname;
        private Label displayemail;
        private GroupBox groupBox1;
        private Label lbl5;
        private Label lbl4;
        private Label lbl3;
        private Label lbl6;
        private Label lbl7;
        private Button borrowbtn;
        private Button Cancelbtn;
        private Label titletxt;
        private Label idtxt;
        private Label borrowdatetxt;
        private DateTimePicker datepicker;
        private Label authortxt;
    }
}