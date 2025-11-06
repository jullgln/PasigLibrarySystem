namespace PasigLibrarySystem
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            H1 = new Label();
            lbl2 = new Label();
            textBox1 = new TextBox();
            lbl1 = new Label();
            Usernametxtbox = new TextBox();
            link1 = new LinkLabel();
            LogInbtn = new Button();
            label1 = new Label();
            link2 = new LinkLabel();
            lbl3 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // H1
            // 
            H1.AutoSize = true;
            H1.Font = new Font("Poppins", 22F, FontStyle.Bold);
            H1.Location = new Point(476, 80);
            H1.Name = "H1";
            H1.Size = new Size(392, 53);
            H1.TabIndex = 5;
            H1.Text = "Pasig City Public Library";
            H1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Poppins Light", 12F);
            lbl2.Location = new Point(506, 234);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(88, 28);
            lbl2.TabIndex = 13;
            lbl2.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Gainsboro;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(506, 265);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(331, 26);
            textBox1.TabIndex = 12;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Poppins Light", 12F);
            lbl1.Location = new Point(506, 159);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(94, 28);
            lbl1.TabIndex = 11;
            lbl1.Text = "Username";
            // 
            // Usernametxtbox
            // 
            Usernametxtbox.BackColor = Color.Gainsboro;
            Usernametxtbox.BorderStyle = BorderStyle.None;
            Usernametxtbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Usernametxtbox.Location = new Point(506, 190);
            Usernametxtbox.Name = "Usernametxtbox";
            Usernametxtbox.Size = new Size(331, 26);
            Usernametxtbox.TabIndex = 10;
            // 
            // link1
            // 
            link1.AutoSize = true;
            link1.Font = new Font("Poppins", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            link1.LinkColor = Color.FromArgb(15, 46, 103);
            link1.Location = new Point(506, 305);
            link1.Name = "link1";
            link1.Size = new Size(127, 23);
            link1.TabIndex = 15;
            link1.TabStop = true;
            link1.Text = "Forgot Password?";
            link1.LinkClicked += link1_LinkClicked;
            // 
            // LogInbtn
            // 
            LogInbtn.FlatStyle = FlatStyle.Flat;
            LogInbtn.Font = new Font("Poppins Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogInbtn.Location = new Point(734, 303);
            LogInbtn.Name = "LogInbtn";
            LogInbtn.Size = new Size(103, 32);
            LogInbtn.TabIndex = 16;
            LogInbtn.Text = "Log In";
            LogInbtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(15, 46, 103);
            label1.Location = new Point(504, 329);
            label1.Name = "label1";
            label1.Size = new Size(340, 24);
            label1.TabIndex = 17;
            label1.Text = "______________________________";
            // 
            // link2
            // 
            link2.AutoSize = true;
            link2.Font = new Font("Poppins", 10F);
            link2.LinkColor = Color.FromArgb(15, 46, 103);
            link2.Location = new Point(720, 361);
            link2.Name = "link2";
            link2.Size = new Size(123, 25);
            link2.TabIndex = 18;
            link2.TabStop = true;
            link2.Text = "Create Account";
            link2.LinkClicked += link2_LinkClicked;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Poppins", 10F);
            lbl3.Location = new Point(506, 362);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(178, 25);
            lbl3.TabIndex = 19;
            lbl3.Text = "Don't have an account?";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-11, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(463, 514);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(884, 511);
            Controls.Add(pictureBox2);
            Controls.Add(lbl3);
            Controls.Add(link2);
            Controls.Add(LogInbtn);
            Controls.Add(link1);
            Controls.Add(lbl2);
            Controls.Add(textBox1);
            Controls.Add(lbl1);
            Controls.Add(Usernametxtbox);
            Controls.Add(H1);
            Controls.Add(label1);
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogIn";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label H1;
        private Label lbl2;
        private TextBox textBox1;
        private Label lbl1;
        private TextBox Usernametxtbox;
        private LinkLabel link1;
        private Button LogInbtn;
        private Label label1;
        private LinkLabel link2;
        private Label lbl3;
        private PictureBox pictureBox2;
    }
}