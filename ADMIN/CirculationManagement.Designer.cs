namespace PasigLibrarySystem.ADMIN
{
    partial class CirculationManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CirculationManagement));
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            cbxFilter = new ComboBox();
            label1 = new Label();
            backBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(cbxFilter);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(backBtn);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1291, 595);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(77, 167);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1182, 329);
            dataGridView1.TabIndex = 3;
            // 
            // cbxFilter
            // 
            cbxFilter.FormattingEnabled = true;
            cbxFilter.Items.AddRange(new object[] { "ALL", "BORROWED", "RETURNED", "RESERVED", "LOST" });
            cbxFilter.Location = new Point(137, 122);
            cbxFilter.Name = "cbxFilter";
            cbxFilter.Size = new Size(151, 28);
            cbxFilter.TabIndex = 2;
            cbxFilter.SelectedIndexChanged += cbxFilter_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(77, 121);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 1;
            label1.Text = "Filter:";
            // 
            // backBtn
            // 
            backBtn.Location = new Point(1165, 533);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(94, 29);
            backBtn.TabIndex = 0;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // CirculationManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1293, 595);
            Controls.Add(panel1);
            Name = "CirculationManagement";
            Text = "CirculationManagement";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cbxFilter;
        private Label label1;
        private Button backBtn;
        private DataGridView dataGridView1;
    }
}