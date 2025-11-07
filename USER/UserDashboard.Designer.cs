namespace PasigLibrarySystem.USER
{
    partial class UserDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashboard));
            taskbarpanel = new Panel();
            highlightpanel = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            headerpanel = new Panel();
            H1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            taskbarpanel.SuspendLayout();
            highlightpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            headerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // taskbarpanel
            // 
            taskbarpanel.BackColor = Color.White;
            taskbarpanel.Controls.Add(pictureBox3);
            taskbarpanel.Controls.Add(label2);
            taskbarpanel.Controls.Add(highlightpanel);
            taskbarpanel.Location = new Point(-1, 78);
            taskbarpanel.Name = "taskbarpanel";
            taskbarpanel.Size = new Size(229, 602);
            taskbarpanel.TabIndex = 0;
            // 
            // highlightpanel
            // 
            highlightpanel.BackColor = Color.Black;
            highlightpanel.Controls.Add(pictureBox2);
            highlightpanel.Controls.Add(label1);
            highlightpanel.Location = new Point(-9, 26);
            highlightpanel.Name = "highlightpanel";
            highlightpanel.Size = new Size(288, 82);
            highlightpanel.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(58, 19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(101, 23);
            label1.Name = "label1";
            label1.Size = new Size(80, 37);
            label1.TabIndex = 7;
            label1.Text = "Home";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // headerpanel
            // 
            headerpanel.BackColor = Color.FromArgb(15, 46, 103);
            headerpanel.Controls.Add(H1);
            headerpanel.Controls.Add(pictureBox1);
            headerpanel.ForeColor = SystemColors.ControlText;
            headerpanel.Location = new Point(-33, 0);
            headerpanel.Name = "headerpanel";
            headerpanel.Size = new Size(1316, 88);
            headerpanel.TabIndex = 1;
            // 
            // H1
            // 
            H1.AutoSize = true;
            H1.Font = new Font("Poppins", 22F, FontStyle.Bold);
            H1.ForeColor = Color.White;
            H1.Location = new Point(157, 18);
            H1.Name = "H1";
            H1.Size = new Size(354, 53);
            H1.TabIndex = 6;
            H1.Text = "Public Library System";
            H1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, -18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(49, 138);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(37, 37);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(15, 46, 103);
            label2.Location = new Point(90, 142);
            label2.Name = "label2";
            label2.Size = new Size(63, 37);
            label2.TabIndex = 9;
            label2.Text = "User";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // UserDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(headerpanel);
            Controls.Add(taskbarpanel);
            Name = "UserDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserDashboard";
            taskbarpanel.ResumeLayout(false);
            taskbarpanel.PerformLayout();
            highlightpanel.ResumeLayout(false);
            highlightpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            headerpanel.ResumeLayout(false);
            headerpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel taskbarpanel;
        private Panel headerpanel;
        private PictureBox pictureBox1;
        private Label H1;
        private Panel highlightpanel;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox3;
        private Label label2;
    }
}