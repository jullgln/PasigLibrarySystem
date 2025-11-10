namespace PasigLibrarySystem.USER
{
    partial class ReturnForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnForm));
            headerpanel = new Panel();
            H1 = new Label();
            pictureBox1 = new PictureBox();
            displayemail = new Label();
            displayname = new Label();
            lbl2 = new Label();
            lbl1 = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            lbl7 = new Label();
            displayborrowdate = new Label();
            lbl6 = new Label();
            displaybooktitle = new Label();
            displaybookid = new Label();
            lbl4 = new Label();
            lbl3 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Cancelbtn = new Button();
            borrowbtn = new Button();
            label7 = new Label();
            textBox1 = new TextBox();
            settleaccbtn = new Button();
            label6 = new Label();
            label8 = new Label();
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
            headerpanel.TabIndex = 3;
            // 
            // H1
            // 
            H1.AutoSize = true;
            H1.Font = new Font("Poppins", 22F, FontStyle.Bold);
            H1.ForeColor = Color.White;
            H1.Location = new Point(140, 18);
            H1.Name = "H1";
            H1.Size = new Size(212, 53);
            H1.TabIndex = 6;
            H1.Text = "Return Form";
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
            // displayemail
            // 
            displayemail.AutoSize = true;
            displayemail.Font = new Font("Poppins Light", 12F);
            displayemail.Location = new Point(615, 119);
            displayemail.Name = "displayemail";
            displayemail.Size = new Size(115, 28);
            displayemail.TabIndex = 21;
            displayemail.Text = "emaildisplay";
            // 
            // displayname
            // 
            displayname.AutoSize = true;
            displayname.Font = new Font("Poppins Light", 12F);
            displayname.Location = new Point(112, 119);
            displayname.Name = "displayname";
            displayname.Size = new Size(117, 28);
            displayname.TabIndex = 20;
            displayname.Text = "namedisplay";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2.ForeColor = Color.FromArgb(15, 46, 103);
            lbl2.Location = new Point(544, 119);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(61, 28);
            lbl2.TabIndex = 19;
            lbl2.Text = "Email";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1.ForeColor = Color.FromArgb(15, 46, 103);
            lbl1.Location = new Point(33, 119);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(66, 28);
            lbl1.TabIndex = 18;
            lbl1.Text = "Name";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lbl7);
            groupBox1.Controls.Add(settleaccbtn);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(displayborrowdate);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(lbl6);
            groupBox1.Controls.Add(displaybooktitle);
            groupBox1.Controls.Add(displaybookid);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lbl4);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lbl3);
            groupBox1.Location = new Point(31, 150);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(827, 233);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Light", 12F);
            label1.Location = new Point(182, 187);
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
            lbl7.Location = new Point(22, 187);
            lbl7.Name = "lbl7";
            lbl7.Size = new Size(117, 28);
            lbl7.TabIndex = 29;
            lbl7.Text = "Return Date";
            // 
            // displayborrowdate
            // 
            displayborrowdate.AutoSize = true;
            displayborrowdate.Font = new Font("Poppins Light", 12F);
            displayborrowdate.Location = new Point(182, 134);
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
            lbl6.Location = new Point(22, 134);
            lbl6.Name = "lbl6";
            lbl6.Size = new Size(143, 28);
            lbl6.TabIndex = 27;
            lbl6.Text = "Borrowed Date";
            // 
            // displaybooktitle
            // 
            displaybooktitle.AutoSize = true;
            displaybooktitle.Font = new Font("Poppins Light", 12F);
            displaybooktitle.Location = new Point(182, 76);
            displaybooktitle.Name = "displaybooktitle";
            displaybooktitle.Size = new Size(69, 28);
            displaybooktitle.TabIndex = 23;
            displaybooktitle.Text = "Book ID";
            // 
            // displaybookid
            // 
            displaybookid.AutoSize = true;
            displaybookid.Font = new Font("Poppins Light", 12F);
            displaybookid.Location = new Point(182, 24);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(15, 46, 103);
            label2.Location = new Point(53, 409);
            label2.Name = "label2";
            label2.Size = new Size(117, 28);
            label2.TabIndex = 31;
            label2.Text = "Return Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins Light", 12F);
            label3.Location = new Point(213, 409);
            label3.Name = "label3";
            label3.Size = new Size(105, 28);
            label3.TabIndex = 31;
            label3.Text = "Return Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(15, 46, 103);
            label4.Location = new Point(450, 34);
            label4.Name = "label4";
            label4.Size = new Size(48, 28);
            label4.TabIndex = 32;
            label4.Text = "Fine";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins Light", 12F);
            label5.Location = new Point(547, 34);
            label5.Name = "label5";
            label5.Size = new Size(34, 28);
            label5.TabIndex = 33;
            label5.Text = "__";
            // 
            // Cancelbtn
            // 
            Cancelbtn.FlatStyle = FlatStyle.Flat;
            Cancelbtn.Font = new Font("Poppins Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cancelbtn.Location = new Point(627, 451);
            Cancelbtn.Name = "Cancelbtn";
            Cancelbtn.Size = new Size(103, 32);
            Cancelbtn.TabIndex = 36;
            Cancelbtn.Text = "Cancel";
            Cancelbtn.UseVisualStyleBackColor = true;
            // 
            // borrowbtn
            // 
            borrowbtn.FlatStyle = FlatStyle.Flat;
            borrowbtn.Font = new Font("Poppins Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            borrowbtn.Location = new Point(755, 451);
            borrowbtn.Name = "borrowbtn";
            borrowbtn.Size = new Size(103, 32);
            borrowbtn.TabIndex = 35;
            borrowbtn.Text = "Return";
            borrowbtn.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(15, 46, 103);
            label7.Location = new Point(450, 85);
            label7.Name = "label7";
            label7.Size = new Size(82, 28);
            label7.TabIndex = 37;
            label7.Text = "Amount";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(547, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 25);
            textBox1.TabIndex = 38;
            // 
            // settleaccbtn
            // 
            settleaccbtn.FlatStyle = FlatStyle.Flat;
            settleaccbtn.Font = new Font("Poppins Medium", 10F, FontStyle.Bold);
            settleaccbtn.Location = new Point(643, 130);
            settleaccbtn.Name = "settleaccbtn";
            settleaccbtn.Size = new Size(147, 32);
            settleaccbtn.TabIndex = 39;
            settleaccbtn.Text = "Settle Account";
            settleaccbtn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(15, 46, 103);
            label6.Location = new Point(450, 170);
            label6.Name = "label6";
            label6.Size = new Size(82, 28);
            label6.TabIndex = 40;
            label6.Text = "Change";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins Light", 12F);
            label8.Location = new Point(547, 170);
            label8.Name = "label8";
            label8.Size = new Size(23, 28);
            label8.TabIndex = 41;
            label8.Text = "_";
            // 
            // ReturnForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 511);
            Controls.Add(Cancelbtn);
            Controls.Add(borrowbtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(displayemail);
            Controls.Add(displayname);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(headerpanel);
            Name = "ReturnForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReturnForm";
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
        private Label displayemail;
        private Label displayname;
        private Label lbl2;
        private Label lbl1;
        private GroupBox groupBox1;
        private Label displaybooktitle;
        private Label displaybookid;
        private Label lbl4;
        private Label lbl3;
        private Label displayborrowdate;
        private Label lbl6;
        private Label label1;
        private Label lbl7;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button Cancelbtn;
        private Button borrowbtn;
        private Label label7;
        private TextBox textBox1;
        private Button settleaccbtn;
        private Label label6;
        private Label label8;
    }
}