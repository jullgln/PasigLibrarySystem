namespace PasigLibrarySystem.LOG_IN
{
    partial class ForgotPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPass));
            Resetbtn = new Button();
            NewPasstxtbox = new TextBox();
            lbl1 = new Label();
            Usernametxtbox = new TextBox();
            H1 = new Label();
            pictureBox1 = new PictureBox();
            lbl3 = new Label();
            CNewPasstxtbox = new TextBox();
            lbl2 = new Label();
            Cancelbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Resetbtn
            // 
            Resetbtn.FlatStyle = FlatStyle.Flat;
            Resetbtn.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Resetbtn.Location = new Point(655, 402);
            Resetbtn.Name = "Resetbtn";
            Resetbtn.Size = new Size(187, 36);
            Resetbtn.TabIndex = 21;
            Resetbtn.Text = "Reset Password";
            Resetbtn.UseVisualStyleBackColor = true;
            Resetbtn.Click += Resetbtn_Click;
            // 
            // NewPasstxtbox
            // 
            NewPasstxtbox.BackColor = Color.Gainsboro;
            NewPasstxtbox.BorderStyle = BorderStyle.None;
            NewPasstxtbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NewPasstxtbox.Location = new Point(508, 257);
            NewPasstxtbox.Name = "NewPasstxtbox";
            NewPasstxtbox.Size = new Size(331, 26);
            NewPasstxtbox.TabIndex = 19;
            NewPasstxtbox.UseSystemPasswordChar = true;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Poppins Light", 12F);
            lbl1.Location = new Point(508, 145);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(94, 28);
            lbl1.TabIndex = 18;
            lbl1.Text = "Username";
            // 
            // Usernametxtbox
            // 
            Usernametxtbox.BackColor = Color.Gainsboro;
            Usernametxtbox.BorderStyle = BorderStyle.None;
            Usernametxtbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Usernametxtbox.Location = new Point(508, 176);
            Usernametxtbox.Name = "Usernametxtbox";
            Usernametxtbox.Size = new Size(331, 26);
            Usernametxtbox.TabIndex = 17;
            // 
            // H1
            // 
            H1.AutoSize = true;
            H1.Font = new Font("Poppins SemiBold", 24F, FontStyle.Bold);
            H1.Location = new Point(531, 48);
            H1.Name = "H1";
            H1.Size = new Size(293, 56);
            H1.TabIndex = 15;
            H1.Text = "Forgot Password";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-28, -7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(499, 573);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Poppins Light", 12F);
            lbl3.Location = new Point(508, 309);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(193, 28);
            lbl3.TabIndex = 23;
            lbl3.Text = "Confirm New Password";
            // 
            // CNewPasstxtbox
            // 
            CNewPasstxtbox.BackColor = Color.Gainsboro;
            CNewPasstxtbox.BorderStyle = BorderStyle.None;
            CNewPasstxtbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CNewPasstxtbox.Location = new Point(508, 340);
            CNewPasstxtbox.Name = "CNewPasstxtbox";
            CNewPasstxtbox.Size = new Size(331, 26);
            CNewPasstxtbox.TabIndex = 22;
            CNewPasstxtbox.UseSystemPasswordChar = true;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Poppins Light", 12F);
            lbl2.Location = new Point(508, 226);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(126, 28);
            lbl2.TabIndex = 24;
            lbl2.Text = "New Password";
            // 
            // Cancelbtn
            // 
            Cancelbtn.FlatStyle = FlatStyle.Flat;
            Cancelbtn.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cancelbtn.Location = new Point(508, 402);
            Cancelbtn.Name = "Cancelbtn";
            Cancelbtn.Size = new Size(126, 36);
            Cancelbtn.TabIndex = 26;
            Cancelbtn.Text = "Cancel";
            Cancelbtn.UseVisualStyleBackColor = true;
            Cancelbtn.Click += Cancelbtn_Click;
            // 
            // ForgotPass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(884, 511);
            Controls.Add(Cancelbtn);
            Controls.Add(lbl2);
            Controls.Add(lbl3);
            Controls.Add(CNewPasstxtbox);
            Controls.Add(Resetbtn);
            Controls.Add(NewPasstxtbox);
            Controls.Add(lbl1);
            Controls.Add(Usernametxtbox);
            Controls.Add(H1);
            Controls.Add(pictureBox1);
            Name = "ForgotPass";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgotPass";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl4;
        private TextBox emailtxtbox;
        private Button Resetbtn;
        private TextBox NewPasstxtbox;
        private Label lbl1;
        private TextBox Usernametxtbox;
        private Label H1;
        private TextBox nametxtbox;
        private PictureBox pictureBox1;
        private Label lbl3;
        private TextBox CNewPasstxtbox;
        private Label lbl2;
        private Button Cancelbtn;
    }
}