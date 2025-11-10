namespace PasigLibrarySystem.ADMIN
{
    partial class AddAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAdmin));
            headerpanel = new Panel();
            H1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            lbl3 = new Label();
            lbl2 = new Label();
            lbl1 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            roletxt = new TextBox();
            idtxt = new TextBox();
            nametxt = new TextBox();
            passtxt = new TextBox();
            usernametxt = new TextBox();
            emailtxt = new TextBox();
            register = new Button();
            Cancelbtn = new Button();
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
            headerpanel.Location = new Point(-16, 0);
            headerpanel.Name = "headerpanel";
            headerpanel.Size = new Size(918, 88);
            headerpanel.TabIndex = 7;
            // 
            // H1
            // 
            H1.AutoSize = true;
            H1.Font = new Font("Poppins", 22F, FontStyle.Bold);
            H1.ForeColor = Color.White;
            H1.Location = new Point(140, 18);
            H1.Name = "H1";
            H1.Size = new Size(194, 53);
            H1.TabIndex = 6;
            H1.Text = "Add Admin";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(15, 46, 103);
            label2.Location = new Point(60, 255);
            label2.Name = "label2";
            label2.Size = new Size(66, 28);
            label2.TabIndex = 68;
            label2.Text = "Name";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3.ForeColor = Color.FromArgb(15, 46, 103);
            lbl3.Location = new Point(60, 418);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(99, 28);
            lbl3.TabIndex = 67;
            lbl3.Text = "Password";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2.ForeColor = Color.FromArgb(15, 46, 103);
            lbl2.Location = new Point(60, 364);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(61, 28);
            lbl2.TabIndex = 66;
            lbl2.Text = "Email";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1.ForeColor = Color.FromArgb(15, 46, 103);
            lbl1.Location = new Point(60, 308);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(104, 28);
            lbl1.TabIndex = 65;
            lbl1.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(15, 46, 103);
            label1.Location = new Point(60, 132);
            label1.Name = "label1";
            label1.Size = new Size(50, 28);
            label1.TabIndex = 69;
            label1.Text = "Role";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(15, 46, 103);
            label3.Location = new Point(60, 183);
            label3.Name = "label3";
            label3.Size = new Size(29, 28);
            label3.TabIndex = 70;
            label3.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(15, 46, 103);
            label4.Location = new Point(60, 211);
            label4.Name = "label4";
            label4.Size = new Size(791, 24);
            label4.TabIndex = 71;
            label4.Text = "_______________________________________________________________________";
            // 
            // roletxt
            // 
            roletxt.Enabled = false;
            roletxt.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roletxt.Location = new Point(226, 132);
            roletxt.Name = "roletxt";
            roletxt.ReadOnly = true;
            roletxt.Size = new Size(185, 25);
            roletxt.TabIndex = 72;
            roletxt.Text = "Admin";
            // 
            // idtxt
            // 
            idtxt.Enabled = false;
            idtxt.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idtxt.Location = new Point(226, 183);
            idtxt.Name = "idtxt";
            idtxt.ReadOnly = true;
            idtxt.Size = new Size(185, 25);
            idtxt.TabIndex = 73;
            // 
            // nametxt
            // 
            nametxt.Font = new Font("Poppins", 9F);
            nametxt.Location = new Point(226, 255);
            nametxt.Name = "nametxt";
            nametxt.Size = new Size(317, 25);
            nametxt.TabIndex = 74;
            // 
            // passtxt
            // 
            passtxt.Font = new Font("Poppins", 9F);
            passtxt.Location = new Point(226, 418);
            passtxt.Name = "passtxt";
            passtxt.Size = new Size(317, 25);
            passtxt.TabIndex = 75;
            passtxt.UseSystemPasswordChar = true;
            // 
            // usernametxt
            // 
            usernametxt.Font = new Font("Poppins", 9F);
            usernametxt.Location = new Point(226, 308);
            usernametxt.Name = "usernametxt";
            usernametxt.Size = new Size(317, 25);
            usernametxt.TabIndex = 75;
            // 
            // emailtxt
            // 
            emailtxt.Font = new Font("Poppins", 9F);
            emailtxt.Location = new Point(226, 364);
            emailtxt.Name = "emailtxt";
            emailtxt.Size = new Size(317, 25);
            emailtxt.TabIndex = 76;
            // 
            // register
            // 
            register.FlatStyle = FlatStyle.Flat;
            register.Font = new Font("Poppins Medium", 10F, FontStyle.Bold);
            register.Location = new Point(739, 453);
            register.Name = "register";
            register.Size = new Size(112, 32);
            register.TabIndex = 77;
            register.Text = "Register";
            register.UseVisualStyleBackColor = true;
            register.Click += register_Click;
            // 
            // Cancelbtn
            // 
            Cancelbtn.FlatStyle = FlatStyle.Flat;
            Cancelbtn.Font = new Font("Poppins Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cancelbtn.Location = new Point(609, 453);
            Cancelbtn.Name = "Cancelbtn";
            Cancelbtn.Size = new Size(103, 32);
            Cancelbtn.TabIndex = 78;
            Cancelbtn.Text = "Cancel";
            Cancelbtn.UseVisualStyleBackColor = true;
            Cancelbtn.Click += Cancelbtn_Click;
            // 
            // AddAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 511);
            Controls.Add(Cancelbtn);
            Controls.Add(register);
            Controls.Add(emailtxt);
            Controls.Add(usernametxt);
            Controls.Add(passtxt);
            Controls.Add(nametxt);
            Controls.Add(idtxt);
            Controls.Add(roletxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(headerpanel);
            Name = "AddAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddAdmin";
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
        private Label label2;
        private Label lbl3;
        private Label lbl2;
        private Label lbl1;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox roletxt;
        private TextBox idtxt;
        private TextBox nametxt;
        private TextBox passtxt;
        private TextBox usernametxt;
        private TextBox emailtxt;
        private Button register;
        private Button Cancelbtn;
    }
}