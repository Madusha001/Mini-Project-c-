namespace School_Managment_System
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            lblCount = new Label();
            label2 = new Label();
            panel4 = new Panel();
            lblCount1 = new Label();
            label4 = new Label();
            panel5 = new Panel();
            lblCount2 = new Label();
            label5 = new Label();
            panel6 = new Panel();
            lblCount3 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(871, 35);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(221, 32);
            label1.TabIndex = 0;
            label1.Text = "Admin Dashboard";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Green;
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(153, 483);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 109);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MediumVioletRed;
            panel3.Controls.Add(lblCount);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(170, 56);
            panel3.Name = "panel3";
            panel3.Size = new Size(170, 170);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCount.ForeColor = Color.White;
            lblCount.Location = new Point(92, 23);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(23, 25);
            lblCount.TabIndex = 1;
            lblCount.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 23);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 0;
            label2.Text = "Student:";
            label2.Click += label2_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.MediumVioletRed;
            panel4.Controls.Add(lblCount1);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(364, 56);
            panel4.Name = "panel4";
            panel4.Size = new Size(170, 170);
            panel4.TabIndex = 3;
            // 
            // lblCount1
            // 
            lblCount1.AutoSize = true;
            lblCount1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCount1.ForeColor = Color.White;
            lblCount1.Location = new Point(96, 23);
            lblCount1.Name = "lblCount1";
            lblCount1.Size = new Size(23, 25);
            lblCount1.TabIndex = 2;
            lblCount1.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 23);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 1;
            label4.Text = "Subjects:";
            // 
            // panel5
            // 
            panel5.BackColor = Color.MediumVioletRed;
            panel5.Controls.Add(lblCount2);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(570, 56);
            panel5.Name = "panel5";
            panel5.Size = new Size(170, 170);
            panel5.TabIndex = 4;
            // 
            // lblCount2
            // 
            lblCount2.AutoSize = true;
            lblCount2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCount2.ForeColor = Color.White;
            lblCount2.Location = new Point(105, 23);
            lblCount2.Name = "lblCount2";
            lblCount2.Size = new Size(23, 25);
            lblCount2.TabIndex = 3;
            lblCount2.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(17, 23);
            label5.Name = "label5";
            label5.Size = new Size(92, 25);
            label5.TabIndex = 2;
            label5.Text = "Teachers:";
            // 
            // panel6
            // 
            panel6.BackColor = Color.MediumVioletRed;
            panel6.Controls.Add(lblCount3);
            panel6.Controls.Add(label6);
            panel6.Location = new Point(170, 286);
            panel6.Name = "panel6";
            panel6.Size = new Size(170, 170);
            panel6.TabIndex = 5;
            // 
            // lblCount3
            // 
            lblCount3.AutoSize = true;
            lblCount3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCount3.ForeColor = Color.White;
            lblCount3.Location = new Point(122, 21);
            lblCount3.Name = "lblCount3";
            lblCount3.Size = new Size(23, 25);
            lblCount3.TabIndex = 7;
            lblCount3.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(12, 21);
            label6.Name = "label6";
            label6.Size = new Size(115, 25);
            label6.TabIndex = 6;
            label6.Text = "Enrollment:";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(871, 518);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label label2;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Label lblCount;
        private Label lblCount1;
        private Label label4;
        private Label lblCount2;
        private Label label5;
        private Label label6;
        private Label lblCount3;
    }
}