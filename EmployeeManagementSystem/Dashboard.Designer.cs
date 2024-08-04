namespace EmployeeManagementSystem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            panel4 = new Panel();
            label6 = new Label();
            dashboard_IE = new Label();
            pictureBox3 = new PictureBox();
            panel5 = new Panel();
            label5 = new Label();
            dashboard_AE = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            dashboard_TE = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(15, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(973, 208);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(75, 8, 138);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(dashboard_IE);
            panel4.Controls.Add(pictureBox3);
            panel4.Location = new Point(658, 27);
            panel4.Name = "panel4";
            panel4.Size = new Size(288, 157);
            panel4.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(136, 114);
            label6.Name = "label6";
            label6.Size = new Size(145, 19);
            label6.TabIndex = 2;
            label6.Text = "Inactive Employees";
            // 
            // dashboard_IE
            // 
            dashboard_IE.AutoSize = true;
            dashboard_IE.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dashboard_IE.ForeColor = Color.Transparent;
            dashboard_IE.Location = new Point(231, 49);
            dashboard_IE.Name = "dashboard_IE";
            dashboard_IE.Size = new Size(30, 33);
            dashboard_IE.TabIndex = 4;
            dashboard_IE.Text = "0";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(21, 49);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(70, 68);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(75, 8, 138);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(dashboard_AE);
            panel5.Controls.Add(pictureBox2);
            panel5.Location = new Point(339, 27);
            panel5.Name = "panel5";
            panel5.Size = new Size(288, 157);
            panel5.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(139, 114);
            label5.Name = "label5";
            label5.Size = new Size(133, 19);
            label5.TabIndex = 3;
            label5.Text = "Active Employees";
            // 
            // dashboard_AE
            // 
            dashboard_AE.AutoSize = true;
            dashboard_AE.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dashboard_AE.ForeColor = Color.Transparent;
            dashboard_AE.Location = new Point(233, 49);
            dashboard_AE.Name = "dashboard_AE";
            dashboard_AE.Size = new Size(30, 33);
            dashboard_AE.TabIndex = 3;
            dashboard_AE.Text = "0";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(23, 49);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 68);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(75, 8, 138);
            panel3.Controls.Add(dashboard_TE);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(22, 27);
            panel3.Name = "panel3";
            panel3.Size = new Size(288, 157);
            panel3.TabIndex = 0;
            // 
            // dashboard_TE
            // 
            dashboard_TE.AutoSize = true;
            dashboard_TE.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dashboard_TE.ForeColor = Color.Transparent;
            dashboard_TE.Location = new Point(227, 49);
            dashboard_TE.Name = "dashboard_TE";
            dashboard_TE.Size = new Size(30, 33);
            dashboard_TE.TabIndex = 2;
            dashboard_TE.Text = "0";
            dashboard_TE.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(142, 114);
            label1.Name = "label1";
            label1.Size = new Size(126, 19);
            label1.TabIndex = 1;
            label1.Text = "Total Employees";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox4);
            panel2.Location = new Point(15, 266);
            panel2.Name = "panel2";
            panel2.Size = new Size(973, 388);
            panel2.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Fill;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(971, 386);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Dashboard";
            Size = new Size(1002, 678);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private Panel panel5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label dashboard_TE;
        private Label label1;
        private Label label6;
        private Label dashboard_IE;
        private Label label5;
        private Label dashboard_AE;
        private PictureBox pictureBox4;
    }
}
