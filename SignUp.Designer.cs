namespace PasigLibrarySystem
{
    partial class SignUp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            pictureBox1 = new PictureBox();
            H1 = new Label();
            lbl1 = new Label();
            nametxtbox = new TextBox();
            lbl2 = new Label();
            Usernametxtbox = new TextBox();
            lbl3 = new Label();
            textBox1 = new TextBox();
            Registerbtn = new Button();
            lbl4 = new Label();
            emailtxtbox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-29, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(499, 573);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // H1
            // 
            H1.AutoSize = true;
            H1.Font = new Font("Poppins SemiBold", 26F, FontStyle.Bold);
            H1.Location = new Point(525, 35);
            H1.Name = "H1";
            H1.Size = new Size(307, 62);
            H1.TabIndex = 4;
            H1.Text = "Create Account";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Poppins Light", 12F);
            lbl1.Location = new Point(511, 112);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(60, 28);
            lbl1.TabIndex = 5;
            lbl1.Text = "Name";
            // 
            // nametxtbox
            // 
            nametxtbox.BackColor = Color.Gainsboro;
            nametxtbox.BorderStyle = BorderStyle.None;
            nametxtbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nametxtbox.Location = new Point(511, 143);
            nametxtbox.Name = "nametxtbox";
            nametxtbox.Size = new Size(331, 26);
            nametxtbox.TabIndex = 1;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Poppins Light", 12F);
            lbl2.Location = new Point(511, 271);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(94, 28);
            lbl2.TabIndex = 7;
            lbl2.Text = "Username";
            // 
            // Usernametxtbox
            // 
            Usernametxtbox.BackColor = Color.Gainsboro;
            Usernametxtbox.BorderStyle = BorderStyle.None;
            Usernametxtbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Usernametxtbox.Location = new Point(511, 302);
            Usernametxtbox.Name = "Usernametxtbox";
            Usernametxtbox.Size = new Size(331, 26);
            Usernametxtbox.TabIndex = 6;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Poppins Light", 12F);
            lbl3.Location = new Point(511, 354);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(88, 28);
            lbl3.TabIndex = 9;
            lbl3.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Gainsboro;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(511, 385);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(331, 26);
            textBox1.TabIndex = 8;
            // 
            // Registerbtn
            // 
            Registerbtn.FlatStyle = FlatStyle.Flat;
            Registerbtn.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Registerbtn.Location = new Point(618, 438);
            Registerbtn.Name = "Registerbtn";
            Registerbtn.Size = new Size(123, 36);
            Registerbtn.TabIndex = 10;
            Registerbtn.Text = "Register";
            Registerbtn.UseVisualStyleBackColor = true;
            Registerbtn.Click += Registerbtn_Click;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("Poppins Light", 12F);
            lbl4.Location = new Point(511, 191);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(55, 28);
            lbl4.TabIndex = 12;
            lbl4.Text = "Email";
            // 
            // emailtxtbox
            // 
            emailtxtbox.BackColor = Color.Gainsboro;
            emailtxtbox.BorderStyle = BorderStyle.None;
            emailtxtbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailtxtbox.Location = new Point(511, 222);
            emailtxtbox.Name = "emailtxtbox";
            emailtxtbox.Size = new Size(331, 26);
            emailtxtbox.TabIndex = 11;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(884, 511);
            Controls.Add(lbl4);
            Controls.Add(emailtxtbox);
            Controls.Add(Registerbtn);
            Controls.Add(lbl3);
            Controls.Add(textBox1);
            Controls.Add(lbl2);
            Controls.Add(Usernametxtbox);
            Controls.Add(lbl1);
            Controls.Add(H1);
            Controls.Add(nametxtbox);
            Controls.Add(pictureBox1);
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox Usernametxtbox;
        private Label H1;
        private Label lbl1;
        private TextBox nametxtbox;
        private Label lbl2;
        private Label lbl3;
        private TextBox textBox1;
        private Button Registerbtn;
        private Label lbl4;
        private TextBox emailtxtbox;
    }
}
