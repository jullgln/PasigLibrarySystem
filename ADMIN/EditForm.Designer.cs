namespace PasigLibrarySystem.ADMIN
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            headerpanel = new Panel();
            H1 = new Label();
            pictureBox1 = new PictureBox();
            Cancelbtn = new Button();
            abstractxt = new TextBox();
            lbl11 = new Label();
            genrecbox = new ComboBox();
            typecbox = new ComboBox();
            label2 = new Label();
            savebtn = new Button();
            shelfNumtxt = new TextBox();
            ISBNtxt = new TextBox();
            pagecounttxt = new TextBox();
            publishertxt = new TextBox();
            publishdatetxt = new TextBox();
            authortxt = new TextBox();
            titletxt = new TextBox();
            idtxt = new TextBox();
            lbl10 = new Label();
            lbl9 = new Label();
            lbl8 = new Label();
            lbl6 = new Label();
            lbl7 = new Label();
            lbl5 = new Label();
            lbl4 = new Label();
            lbl3 = new Label();
            lbl2 = new Label();
            lbl1 = new Label();
            statuscbox = new ComboBox();
            headerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            headerpanel.TabIndex = 7;
            // 
            // H1
            // 
            H1.AutoSize = true;
            H1.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Bold);
            H1.ForeColor = Color.White;
            H1.Location = new Point(160, 24);
            H1.Name = "H1";
            H1.Size = new Size(187, 42);
            H1.TabIndex = 6;
            H1.Text = "Edit Book";
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
            // Cancelbtn
            // 
            Cancelbtn.FlatStyle = FlatStyle.Flat;
            Cancelbtn.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cancelbtn.Location = new Point(675, 612);
            Cancelbtn.Margin = new Padding(3, 4, 3, 4);
            Cancelbtn.Name = "Cancelbtn";
            Cancelbtn.Size = new Size(118, 43);
            Cancelbtn.TabIndex = 95;
            Cancelbtn.Text = "Cancel";
            Cancelbtn.UseVisualStyleBackColor = true;
            Cancelbtn.Click += Cancelbtn_Click;
            // 
            // abstractxt
            // 
            abstractxt.Font = new Font("Microsoft Sans Serif", 9F);
            abstractxt.Location = new Point(577, 472);
            abstractxt.Margin = new Padding(3, 4, 3, 4);
            abstractxt.Multiline = true;
            abstractxt.Name = "abstractxt";
            abstractxt.Size = new Size(378, 111);
            abstractxt.TabIndex = 94;
            // 
            // lbl11
            // 
            lbl11.AutoSize = true;
            lbl11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl11.ForeColor = Color.FromArgb(15, 46, 103);
            lbl11.Location = new Point(577, 431);
            lbl11.Name = "lbl11";
            lbl11.Size = new Size(92, 25);
            lbl11.TabIndex = 93;
            lbl11.Text = "Abstract";
            // 
            // genrecbox
            // 
            genrecbox.Font = new Font("Microsoft Sans Serif", 9F);
            genrecbox.FormattingEnabled = true;
            genrecbox.Items.AddRange(new object[] { "Fantasy", "Romance", "Sci-fi", "Horror" });
            genrecbox.Location = new Point(745, 171);
            genrecbox.Margin = new Padding(3, 4, 3, 4);
            genrecbox.Name = "genrecbox";
            genrecbox.Size = new Size(210, 26);
            genrecbox.TabIndex = 92;
            // 
            // typecbox
            // 
            typecbox.Font = new Font("Microsoft Sans Serif", 9F);
            typecbox.FormattingEnabled = true;
            typecbox.Location = new Point(239, 173);
            typecbox.Margin = new Padding(3, 4, 3, 4);
            typecbox.Name = "typecbox";
            typecbox.Size = new Size(298, 26);
            typecbox.TabIndex = 91;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(15, 46, 103);
            label2.Location = new Point(57, 173);
            label2.Name = "label2";
            label2.Size = new Size(116, 25);
            label2.TabIndex = 90;
            label2.Text = "Book Type";
            // 
            // savebtn
            // 
            savebtn.FlatStyle = FlatStyle.Flat;
            savebtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            savebtn.Location = new Point(831, 612);
            savebtn.Margin = new Padding(3, 4, 3, 4);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(125, 43);
            savebtn.TabIndex = 89;
            savebtn.Text = "Save";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += savebtn_Click;
            // 
            // shelfNumtxt
            // 
            shelfNumtxt.Enabled = false;
            shelfNumtxt.Font = new Font("Microsoft Sans Serif", 9F);
            shelfNumtxt.Location = new Point(745, 373);
            shelfNumtxt.Margin = new Padding(3, 4, 3, 4);
            shelfNumtxt.Name = "shelfNumtxt";
            shelfNumtxt.ReadOnly = true;
            shelfNumtxt.Size = new Size(210, 24);
            shelfNumtxt.TabIndex = 88;
            // 
            // ISBNtxt
            // 
            ISBNtxt.Enabled = false;
            ISBNtxt.Font = new Font("Microsoft Sans Serif", 9F);
            ISBNtxt.Location = new Point(745, 240);
            ISBNtxt.Margin = new Padding(3, 4, 3, 4);
            ISBNtxt.Name = "ISBNtxt";
            ISBNtxt.ReadOnly = true;
            ISBNtxt.Size = new Size(210, 24);
            ISBNtxt.TabIndex = 86;
            // 
            // pagecounttxt
            // 
            pagecounttxt.Font = new Font("Microsoft Sans Serif", 9F);
            pagecounttxt.Location = new Point(239, 551);
            pagecounttxt.Margin = new Padding(3, 4, 3, 4);
            pagecounttxt.Name = "pagecounttxt";
            pagecounttxt.Size = new Size(298, 24);
            pagecounttxt.TabIndex = 85;
            // 
            // publishertxt
            // 
            publishertxt.Font = new Font("Microsoft Sans Serif", 9F);
            publishertxt.Location = new Point(239, 489);
            publishertxt.Margin = new Padding(3, 4, 3, 4);
            publishertxt.Name = "publishertxt";
            publishertxt.Size = new Size(298, 24);
            publishertxt.TabIndex = 84;
            // 
            // publishdatetxt
            // 
            publishdatetxt.Font = new Font("Microsoft Sans Serif", 9F);
            publishdatetxt.Location = new Point(239, 431);
            publishdatetxt.Margin = new Padding(3, 4, 3, 4);
            publishdatetxt.Name = "publishdatetxt";
            publishdatetxt.Size = new Size(298, 24);
            publishdatetxt.TabIndex = 83;
            // 
            // authortxt
            // 
            authortxt.Font = new Font("Microsoft Sans Serif", 9F);
            authortxt.Location = new Point(239, 368);
            authortxt.Margin = new Padding(3, 4, 3, 4);
            authortxt.Name = "authortxt";
            authortxt.Size = new Size(298, 24);
            authortxt.TabIndex = 82;
            // 
            // titletxt
            // 
            titletxt.Font = new Font("Microsoft Sans Serif", 9F);
            titletxt.Location = new Point(239, 303);
            titletxt.Margin = new Padding(3, 4, 3, 4);
            titletxt.Name = "titletxt";
            titletxt.Size = new Size(298, 24);
            titletxt.TabIndex = 81;
            // 
            // idtxt
            // 
            idtxt.Enabled = false;
            idtxt.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idtxt.Location = new Point(239, 236);
            idtxt.Margin = new Padding(3, 4, 3, 4);
            idtxt.Name = "idtxt";
            idtxt.ReadOnly = true;
            idtxt.Size = new Size(298, 24);
            idtxt.TabIndex = 80;
            // 
            // lbl10
            // 
            lbl10.AutoSize = true;
            lbl10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl10.ForeColor = Color.FromArgb(15, 46, 103);
            lbl10.Location = new Point(577, 373);
            lbl10.Name = "lbl10";
            lbl10.Size = new Size(143, 25);
            lbl10.TabIndex = 79;
            lbl10.Text = "Shelf Number";
            // 
            // lbl9
            // 
            lbl9.AutoSize = true;
            lbl9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl9.ForeColor = Color.FromArgb(15, 46, 103);
            lbl9.Location = new Point(577, 305);
            lbl9.Name = "lbl9";
            lbl9.Size = new Size(74, 25);
            lbl9.TabIndex = 78;
            lbl9.Text = "Status";
            // 
            // lbl8
            // 
            lbl8.AutoSize = true;
            lbl8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl8.ForeColor = Color.FromArgb(15, 46, 103);
            lbl8.Location = new Point(577, 240);
            lbl8.Name = "lbl8";
            lbl8.Size = new Size(62, 25);
            lbl8.TabIndex = 77;
            lbl8.Text = "ISBN";
            // 
            // lbl6
            // 
            lbl6.AutoSize = true;
            lbl6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl6.ForeColor = Color.FromArgb(15, 46, 103);
            lbl6.Location = new Point(57, 489);
            lbl6.Name = "lbl6";
            lbl6.Size = new Size(102, 25);
            lbl6.TabIndex = 76;
            lbl6.Text = "Publisher";
            // 
            // lbl7
            // 
            lbl7.AutoSize = true;
            lbl7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl7.ForeColor = Color.FromArgb(15, 46, 103);
            lbl7.Location = new Point(57, 551);
            lbl7.Name = "lbl7";
            lbl7.Size = new Size(126, 25);
            lbl7.TabIndex = 75;
            lbl7.Text = "Page Count";
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl5.ForeColor = Color.FromArgb(15, 46, 103);
            lbl5.Location = new Point(55, 431);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(134, 25);
            lbl5.TabIndex = 74;
            lbl5.Text = "Publish Date";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl4.ForeColor = Color.FromArgb(15, 46, 103);
            lbl4.Location = new Point(576, 179);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(71, 25);
            lbl4.TabIndex = 73;
            lbl4.Text = "Genre";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3.ForeColor = Color.FromArgb(15, 46, 103);
            lbl3.Location = new Point(54, 368);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(76, 25);
            lbl3.TabIndex = 72;
            lbl3.Text = "Author";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2.ForeColor = Color.FromArgb(15, 46, 103);
            lbl2.Location = new Point(54, 303);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(109, 25);
            lbl2.TabIndex = 71;
            lbl2.Text = "Book Title";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1.ForeColor = Color.FromArgb(15, 46, 103);
            lbl1.Location = new Point(54, 236);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(33, 25);
            lbl1.TabIndex = 70;
            lbl1.Text = "ID";
            // 
            // statuscbox
            // 
            statuscbox.Font = new Font("Microsoft Sans Serif", 9F);
            statuscbox.FormattingEnabled = true;
            statuscbox.Items.AddRange(new object[] { "AVAILABLE", "BORROWED", "RESERVED", "LOST", "DISPOSED" });
            statuscbox.Location = new Point(745, 307);
            statuscbox.Margin = new Padding(3, 4, 3, 4);
            statuscbox.Name = "statuscbox";
            statuscbox.Size = new Size(210, 26);
            statuscbox.TabIndex = 96;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 681);
            Controls.Add(statuscbox);
            Controls.Add(Cancelbtn);
            Controls.Add(abstractxt);
            Controls.Add(lbl11);
            Controls.Add(genrecbox);
            Controls.Add(typecbox);
            Controls.Add(label2);
            Controls.Add(savebtn);
            Controls.Add(shelfNumtxt);
            Controls.Add(ISBNtxt);
            Controls.Add(pagecounttxt);
            Controls.Add(publishertxt);
            Controls.Add(publishdatetxt);
            Controls.Add(authortxt);
            Controls.Add(titletxt);
            Controls.Add(idtxt);
            Controls.Add(lbl10);
            Controls.Add(lbl9);
            Controls.Add(lbl8);
            Controls.Add(lbl6);
            Controls.Add(lbl7);
            Controls.Add(lbl5);
            Controls.Add(lbl4);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(headerpanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditForm";
            headerpanel.ResumeLayout(false);
            headerpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel headerpanel;
        private Label H1;
        private PictureBox pictureBox1;
        private Button Cancelbtn;
        private TextBox abstractxt;
        private Label lbl11;
        private ComboBox genrecbox;
        private ComboBox typecbox;
        private Label label2;
        private Button savebtn;
        private TextBox shelfNumtxt;
        private TextBox ISBNtxt;
        private TextBox pagecounttxt;
        private TextBox publishertxt;
        private TextBox publishdatetxt;
        private TextBox authortxt;
        private TextBox titletxt;
        private TextBox idtxt;
        private Label lbl10;
        private Label lbl9;
        private Label lbl8;
        private Label lbl6;
        private Label lbl7;
        private Label lbl5;
        private Label lbl4;
        private Label lbl3;
        private Label lbl2;
        private Label lbl1;
        private ComboBox statuscbox;
    }
}