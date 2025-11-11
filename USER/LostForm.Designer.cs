namespace PasigLibrarySystem.USER
{
    partial class LostForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LostForm));
            headerpanel = new Panel();
            H1 = new Label();
            pictureBox1 = new PictureBox();
            displayname = new Label();
            lbl1 = new Label();
            groupBox1 = new GroupBox();
            finetxt = new Label();
            lbl5 = new Label();
            lostdatetxt = new Label();
            lbl4 = new Label();
            borrowdatetxt = new Label();
            lbl3 = new Label();
            titletxt = new Label();
            idtxt = new Label();
            lbl6 = new Label();
            lbl2 = new Label();
            settleaccbtn = new Button();
            Cancelbtn = new Button();
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
            headerpanel.Location = new Point(-18, 0);
            headerpanel.Margin = new Padding(3, 4, 3, 4);
            headerpanel.Name = "headerpanel";
            headerpanel.Size = new Size(1049, 117);
            headerpanel.TabIndex = 4;
            // 
            // H1
            // 
            H1.AutoSize = true;
            H1.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Bold);
            H1.ForeColor = Color.White;
            H1.Location = new Point(160, 24);
            H1.Name = "H1";
            H1.Size = new Size(194, 42);
            H1.TabIndex = 6;
            H1.Text = "Lost Form";
            H1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, -24);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // displayname
            // 
            displayname.AutoSize = true;
            displayname.Font = new Font("Microsoft Sans Serif", 12F);
            displayname.Location = new Point(141, 157);
            displayname.Name = "displayname";
            displayname.Size = new Size(122, 25);
            displayname.TabIndex = 22;
            displayname.Text = "namedisplay";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1.ForeColor = Color.FromArgb(15, 46, 103);
            lbl1.Location = new Point(50, 157);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(68, 25);
            lbl1.TabIndex = 21;
            lbl1.Text = "Name";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(finetxt);
            groupBox1.Controls.Add(lbl5);
            groupBox1.Controls.Add(lostdatetxt);
            groupBox1.Controls.Add(lbl4);
            groupBox1.Controls.Add(borrowdatetxt);
            groupBox1.Controls.Add(lbl3);
            groupBox1.Controls.Add(titletxt);
            groupBox1.Controls.Add(idtxt);
            groupBox1.Controls.Add(lbl6);
            groupBox1.Controls.Add(lbl2);
            groupBox1.Location = new Point(33, 233);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(945, 308);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            // 
            // finetxt
            // 
            finetxt.AutoSize = true;
            finetxt.Font = new Font("Microsoft Sans Serif", 12F);
            finetxt.Location = new Point(213, 244);
            finetxt.Name = "finetxt";
            finetxt.Size = new Size(115, 25);
            finetxt.TabIndex = 32;
            finetxt.Text = "Return Date";
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl5.ForeColor = Color.FromArgb(15, 46, 103);
            lbl5.Location = new Point(25, 244);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(54, 25);
            lbl5.TabIndex = 31;
            lbl5.Text = "Fine";
            // 
            // lostdatetxt
            // 
            lostdatetxt.AutoSize = true;
            lostdatetxt.Font = new Font("Microsoft Sans Serif", 12F);
            lostdatetxt.Location = new Point(208, 176);
            lostdatetxt.Name = "lostdatetxt";
            lostdatetxt.Size = new Size(115, 25);
            lostdatetxt.TabIndex = 30;
            lostdatetxt.Text = "Return Date";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl4.ForeColor = Color.FromArgb(15, 46, 103);
            lbl4.Location = new Point(25, 176);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(173, 25);
            lbl4.TabIndex = 29;
            lbl4.Text = "Lost Report Date";
            // 
            // borrowdatetxt
            // 
            borrowdatetxt.AutoSize = true;
            borrowdatetxt.Font = new Font("Microsoft Sans Serif", 12F);
            borrowdatetxt.Location = new Point(208, 111);
            borrowdatetxt.Name = "borrowdatetxt";
            borrowdatetxt.Size = new Size(119, 25);
            borrowdatetxt.TabIndex = 28;
            borrowdatetxt.Text = "Borrow Date";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3.ForeColor = Color.FromArgb(15, 46, 103);
            lbl3.Location = new Point(25, 111);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(154, 25);
            lbl3.TabIndex = 27;
            lbl3.Text = "Borrowed Date";
            // 
            // titletxt
            // 
            titletxt.AutoSize = true;
            titletxt.Font = new Font("Microsoft Sans Serif", 12F);
            titletxt.Location = new Point(585, 39);
            titletxt.Name = "titletxt";
            titletxt.Size = new Size(81, 25);
            titletxt.TabIndex = 23;
            titletxt.Text = "Book ID";
            // 
            // idtxt
            // 
            idtxt.AutoSize = true;
            idtxt.Font = new Font("Microsoft Sans Serif", 12F);
            idtxt.Location = new Point(208, 39);
            idtxt.Name = "idtxt";
            idtxt.Size = new Size(81, 25);
            idtxt.TabIndex = 22;
            idtxt.Text = "Book ID";
            // 
            // lbl6
            // 
            lbl6.AutoSize = true;
            lbl6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl6.ForeColor = Color.FromArgb(15, 46, 103);
            lbl6.Location = new Point(402, 39);
            lbl6.Name = "lbl6";
            lbl6.Size = new Size(109, 25);
            lbl6.TabIndex = 20;
            lbl6.Text = "Book Title";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2.ForeColor = Color.FromArgb(15, 46, 103);
            lbl2.Location = new Point(25, 39);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(88, 25);
            lbl2.TabIndex = 19;
            lbl2.Text = "Book ID";
            // 
            // settleaccbtn
            // 
            settleaccbtn.FlatStyle = FlatStyle.Flat;
            settleaccbtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            settleaccbtn.Location = new Point(770, 612);
            settleaccbtn.Margin = new Padding(3, 4, 3, 4);
            settleaccbtn.Name = "settleaccbtn";
            settleaccbtn.Size = new Size(208, 43);
            settleaccbtn.TabIndex = 44;
            settleaccbtn.Text = "Settle Account";
            settleaccbtn.UseVisualStyleBackColor = true;
            settleaccbtn.Click += settleaccbtn_Click;
            // 
            // Cancelbtn
            // 
            Cancelbtn.FlatStyle = FlatStyle.Flat;
            Cancelbtn.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cancelbtn.Location = new Point(618, 612);
            Cancelbtn.Margin = new Padding(3, 4, 3, 4);
            Cancelbtn.Name = "Cancelbtn";
            Cancelbtn.Size = new Size(118, 43);
            Cancelbtn.TabIndex = 45;
            Cancelbtn.Text = "Cancel";
            Cancelbtn.UseVisualStyleBackColor = true;
            Cancelbtn.Click += Cancelbtn_Click;
            // 
            // LostForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 681);
            Controls.Add(Cancelbtn);
            Controls.Add(settleaccbtn);
            Controls.Add(groupBox1);
            Controls.Add(displayname);
            Controls.Add(lbl1);
            Controls.Add(headerpanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LostForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LostForm";
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
        private Label displayname;
        private Label lbl1;
        private GroupBox groupBox1;
        private Label lostdatetxt;
        private Label lbl4;
        private Label borrowdatetxt;
        private Label lbl3;
        private Label titletxt;
        private Label idtxt;
        private Label lbl6;
        private Label lbl2;
        private Label lbl5;
        private Button settleaccbtn;
        private Button Cancelbtn;
        private Label finetxt;
    }
}