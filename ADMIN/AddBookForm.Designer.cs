namespace PasigLibrarySystem.ADMIN
{
    partial class AddBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBookForm));
            headerpanel = new Panel();
            H1 = new Label();
            pictureBox1 = new PictureBox();
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
            idtxt = new TextBox();
            titletxt = new TextBox();
            authortxt = new TextBox();
            publishertxt = new TextBox();
            publishdatetxt = new TextBox();
            ISBNtxt = new TextBox();
            pagecounttxt = new TextBox();
            textBox9 = new TextBox();
            statustxt = new TextBox();
            addbookbtn = new Button();
            lbl12 = new Label();
            typecbox = new ComboBox();
            genrecbox = new ComboBox();
            lbl11 = new Label();
            abstractxt = new TextBox();
            Cancelbtn = new Button();
            label1 = new Label();
            txtlang = new TextBox();
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
            headerpanel.TabIndex = 6;
            // 
            // H1
            // 
            H1.AutoSize = true;
            H1.Font = new Font("Poppins", 22F, FontStyle.Bold);
            H1.ForeColor = Color.White;
            H1.Location = new Point(160, 24);
            H1.Name = "H1";
            H1.Size = new Size(208, 65);
            H1.TabIndex = 6;
            H1.Text = "Add Book";
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
            // lbl10
            // 
            lbl10.AutoSize = true;
            lbl10.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl10.ForeColor = Color.FromArgb(15, 46, 103);
            lbl10.Location = new Point(576, 367);
            lbl10.Name = "lbl10";
            lbl10.Size = new Size(163, 36);
            lbl10.TabIndex = 44;
            lbl10.Text = "Shelf Number";
            // 
            // lbl9
            // 
            lbl9.AutoSize = true;
            lbl9.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl9.ForeColor = Color.FromArgb(15, 46, 103);
            lbl9.Location = new Point(576, 299);
            lbl9.Name = "lbl9";
            lbl9.Size = new Size(85, 36);
            lbl9.TabIndex = 43;
            lbl9.Text = "Status";
            // 
            // lbl8
            // 
            lbl8.AutoSize = true;
            lbl8.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl8.ForeColor = Color.FromArgb(15, 46, 103);
            lbl8.Location = new Point(576, 233);
            lbl8.Name = "lbl8";
            lbl8.Size = new Size(63, 36);
            lbl8.TabIndex = 42;
            lbl8.Text = "ISBN";
            // 
            // lbl6
            // 
            lbl6.AutoSize = true;
            lbl6.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl6.ForeColor = Color.FromArgb(15, 46, 103);
            lbl6.Location = new Point(56, 483);
            lbl6.Name = "lbl6";
            lbl6.Size = new Size(117, 36);
            lbl6.TabIndex = 41;
            lbl6.Text = "Publisher";
            // 
            // lbl7
            // 
            lbl7.AutoSize = true;
            lbl7.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl7.ForeColor = Color.FromArgb(15, 46, 103);
            lbl7.Location = new Point(56, 544);
            lbl7.Name = "lbl7";
            lbl7.Size = new Size(143, 36);
            lbl7.TabIndex = 40;
            lbl7.Text = "Page Count";
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl5.ForeColor = Color.FromArgb(15, 46, 103);
            lbl5.Location = new Point(54, 424);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(152, 36);
            lbl5.TabIndex = 39;
            lbl5.Text = "Publish Date";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl4.ForeColor = Color.FromArgb(15, 46, 103);
            lbl4.Location = new Point(575, 172);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(80, 36);
            lbl4.TabIndex = 38;
            lbl4.Text = "Genre";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3.ForeColor = Color.FromArgb(15, 46, 103);
            lbl3.Location = new Point(53, 361);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(89, 36);
            lbl3.TabIndex = 37;
            lbl3.Text = "Author";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2.ForeColor = Color.FromArgb(15, 46, 103);
            lbl2.Location = new Point(53, 296);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(120, 36);
            lbl2.TabIndex = 36;
            lbl2.Text = "Book Title";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1.ForeColor = Color.FromArgb(15, 46, 103);
            lbl1.Location = new Point(53, 229);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(36, 36);
            lbl1.TabIndex = 35;
            lbl1.Text = "ID";
            // 
            // idtxt
            // 
            idtxt.Enabled = false;
            idtxt.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idtxt.Location = new Point(238, 229);
            idtxt.Margin = new Padding(3, 4, 3, 4);
            idtxt.Name = "idtxt";
            idtxt.ReadOnly = true;
            idtxt.Size = new Size(298, 30);
            idtxt.TabIndex = 45;
            // 
            // titletxt
            // 
            titletxt.Font = new Font("Poppins", 9F);
            titletxt.Location = new Point(238, 296);
            titletxt.Margin = new Padding(3, 4, 3, 4);
            titletxt.Name = "titletxt";
            titletxt.Size = new Size(298, 30);
            titletxt.TabIndex = 46;
            // 
            // authortxt
            // 
            authortxt.Font = new Font("Poppins", 9F);
            authortxt.Location = new Point(238, 361);
            authortxt.Margin = new Padding(3, 4, 3, 4);
            authortxt.Name = "authortxt";
            authortxt.Size = new Size(298, 30);
            authortxt.TabIndex = 47;
            // 
            // publishertxt
            // 
            publishertxt.Font = new Font("Poppins", 9F);
            publishertxt.Location = new Point(238, 483);
            publishertxt.Margin = new Padding(3, 4, 3, 4);
            publishertxt.Name = "publishertxt";
            publishertxt.Size = new Size(298, 30);
            publishertxt.TabIndex = 50;
            // 
            // publishdatetxt
            // 
            publishdatetxt.Font = new Font("Poppins", 9F);
            publishdatetxt.Location = new Point(238, 424);
            publishdatetxt.Margin = new Padding(3, 4, 3, 4);
            publishdatetxt.Name = "publishdatetxt";
            publishdatetxt.Size = new Size(298, 30);
            publishdatetxt.TabIndex = 49;
            // 
            // ISBNtxt
            // 
            ISBNtxt.Enabled = false;
            ISBNtxt.Font = new Font("Poppins", 9F);
            ISBNtxt.Location = new Point(744, 233);
            ISBNtxt.Margin = new Padding(3, 4, 3, 4);
            ISBNtxt.Name = "ISBNtxt";
            ISBNtxt.ReadOnly = true;
            ISBNtxt.Size = new Size(210, 30);
            ISBNtxt.TabIndex = 52;
            // 
            // pagecounttxt
            // 
            pagecounttxt.Font = new Font("Poppins", 9F);
            pagecounttxt.Location = new Point(238, 544);
            pagecounttxt.Margin = new Padding(3, 4, 3, 4);
            pagecounttxt.Name = "pagecounttxt";
            pagecounttxt.Size = new Size(298, 30);
            pagecounttxt.TabIndex = 51;
            // 
            // textBox9
            // 
            textBox9.Enabled = false;
            textBox9.Font = new Font("Poppins", 9F);
            textBox9.Location = new Point(744, 367);
            textBox9.Margin = new Padding(3, 4, 3, 4);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(210, 30);
            textBox9.TabIndex = 54;
            // 
            // statustxt
            // 
            statustxt.Enabled = false;
            statustxt.Font = new Font("Poppins", 9F);
            statustxt.Location = new Point(744, 299);
            statustxt.Margin = new Padding(3, 4, 3, 4);
            statustxt.Name = "statustxt";
            statustxt.ReadOnly = true;
            statustxt.Size = new Size(210, 30);
            statustxt.TabIndex = 53;
            // 
            // addbookbtn
            // 
            addbookbtn.FlatStyle = FlatStyle.Flat;
            addbookbtn.Font = new Font("Poppins Medium", 10F, FontStyle.Bold);
            addbookbtn.Location = new Point(811, 605);
            addbookbtn.Margin = new Padding(3, 4, 3, 4);
            addbookbtn.Name = "addbookbtn";
            addbookbtn.Size = new Size(143, 43);
            addbookbtn.TabIndex = 62;
            addbookbtn.Text = "Add Book";
            addbookbtn.UseVisualStyleBackColor = true;
            addbookbtn.Click += addbookbtn_Click;
            // 
            // lbl12
            // 
            lbl12.AutoSize = true;
            lbl12.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl12.ForeColor = Color.FromArgb(15, 46, 103);
            lbl12.Location = new Point(56, 167);
            lbl12.Name = "lbl12";
            lbl12.Size = new Size(128, 36);
            lbl12.TabIndex = 64;
            lbl12.Text = "Book Type";
            // 
            // typecbox
            // 
            typecbox.Font = new Font("Poppins", 9F);
            typecbox.FormattingEnabled = true;
            typecbox.Location = new Point(238, 167);
            typecbox.Margin = new Padding(3, 4, 3, 4);
            typecbox.Name = "typecbox";
            typecbox.Size = new Size(298, 34);
            typecbox.TabIndex = 65;
            // 
            // genrecbox
            // 
            genrecbox.Font = new Font("Poppins", 9F);
            genrecbox.FormattingEnabled = true;
            genrecbox.Items.AddRange(new object[] { "Fantasy", "Romance", "Horror", "Sci-fi" });
            genrecbox.Location = new Point(744, 164);
            genrecbox.Margin = new Padding(3, 4, 3, 4);
            genrecbox.Name = "genrecbox";
            genrecbox.Size = new Size(210, 34);
            genrecbox.TabIndex = 66;
            // 
            // lbl11
            // 
            lbl11.AutoSize = true;
            lbl11.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl11.ForeColor = Color.FromArgb(15, 46, 103);
            lbl11.Location = new Point(576, 424);
            lbl11.Name = "lbl11";
            lbl11.Size = new Size(110, 36);
            lbl11.TabIndex = 67;
            lbl11.Text = "Abstract";
            // 
            // abstractxt
            // 
            abstractxt.Font = new Font("Poppins", 9F);
            abstractxt.Location = new Point(576, 465);
            abstractxt.Margin = new Padding(3, 4, 3, 4);
            abstractxt.Multiline = true;
            abstractxt.Name = "abstractxt";
            abstractxt.Size = new Size(378, 111);
            abstractxt.TabIndex = 68;
            // 
            // Cancelbtn
            // 
            Cancelbtn.FlatStyle = FlatStyle.Flat;
            Cancelbtn.Font = new Font("Poppins Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cancelbtn.Location = new Point(658, 605);
            Cancelbtn.Margin = new Padding(3, 4, 3, 4);
            Cancelbtn.Name = "Cancelbtn";
            Cancelbtn.Size = new Size(118, 43);
            Cancelbtn.TabIndex = 69;
            Cancelbtn.Text = "Cancel";
            Cancelbtn.UseVisualStyleBackColor = true;
            Cancelbtn.Click += Cancelbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(15, 46, 103);
            label1.Location = new Point(58, 605);
            label1.Name = "label1";
            label1.Size = new Size(126, 36);
            label1.TabIndex = 70;
            label1.Text = "Language";
            // 
            // txtlang
            // 
            txtlang.Font = new Font("Poppins", 9F);
            txtlang.Location = new Point(238, 605);
            txtlang.Margin = new Padding(3, 4, 3, 4);
            txtlang.Name = "txtlang";
            txtlang.Size = new Size(298, 30);
            txtlang.TabIndex = 71;
            // 
            // AddBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 681);
            Controls.Add(txtlang);
            Controls.Add(label1);
            Controls.Add(Cancelbtn);
            Controls.Add(abstractxt);
            Controls.Add(lbl11);
            Controls.Add(genrecbox);
            Controls.Add(typecbox);
            Controls.Add(lbl12);
            Controls.Add(addbookbtn);
            Controls.Add(textBox9);
            Controls.Add(statustxt);
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
            Name = "AddBookForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBookForm";
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
        private TextBox idtxt;
        private TextBox titletxt;
        private TextBox authortxt;
        private TextBox publishertxt;
        private TextBox publishdatetxt;
        private TextBox ISBNtxt;
        private TextBox pagecounttxt;
        private TextBox textBox9;
        private TextBox statustxt;
        private Button addbookbtn;
        private Label lbl12;
        private ComboBox typecbox;
        private ComboBox genrecbox;
        private Label lbl11;
        private TextBox abstractxt;
        private Button Cancelbtn;
        private Label label1;
        private TextBox txtlang;
    }
}