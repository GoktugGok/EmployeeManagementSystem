namespace EmployeeManagementSystem
{
    partial class MainForm
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
            panel1 = new Panel();
            label2 = new Label();
            exit = new Label();
            panel2 = new Panel();
            label4 = new Label();
            logout_btn = new Button();
            salary_btn = new Button();
            addEmployee_btn = new Button();
            dashboard_btn = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            panel3 = new Panel();
            dashboard1 = new Dashboard();
            addEmployee1 = new AddEmployee();
            salary1 = new Salary();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 11, 97);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(exit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1257, 42);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 13);
            label2.Name = "label2";
            label2.Size = new Size(186, 16);
            label2.TabIndex = 1;
            label2.Text = "Employee Management System";
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Cursor = Cursors.Hand;
            exit.ForeColor = Color.White;
            exit.Location = new Point(1227, 11);
            exit.Name = "exit";
            exit.Size = new Size(17, 18);
            exit.TabIndex = 1;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(33, 11, 97);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(logout_btn);
            panel2.Controls.Add(salary_btn);
            panel2.Controls.Add(addEmployee_btn);
            panel2.Controls.Add(dashboard_btn);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(255, 678);
            panel2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(60, 639);
            label4.Name = "label4";
            label4.Size = new Size(63, 18);
            label4.TabIndex = 6;
            label4.Text = "Sing Out";
            // 
            // logout_btn
            // 
            logout_btn.BackColor = Color.RosyBrown;
            logout_btn.Cursor = Cursors.Hand;
            logout_btn.FlatStyle = FlatStyle.Popup;
            logout_btn.ForeColor = Color.SaddleBrown;
            logout_btn.Image = Properties.Resources.power_off;
            logout_btn.Location = new Point(15, 630);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(39, 36);
            logout_btn.TabIndex = 5;
            logout_btn.UseVisualStyleBackColor = false;
            logout_btn.Click += logout_btn_Click;
            // 
            // salary_btn
            // 
            salary_btn.BackColor = Color.DarkCyan;
            salary_btn.Cursor = Cursors.Hand;
            salary_btn.FlatAppearance.BorderSize = 0;
            salary_btn.ForeColor = Color.White;
            salary_btn.Image = Properties.Resources.salary;
            salary_btn.ImageAlign = ContentAlignment.MiddleLeft;
            salary_btn.Location = new Point(15, 401);
            salary_btn.Name = "salary_btn";
            salary_btn.Padding = new Padding(10, 0, 0, 0);
            salary_btn.Size = new Size(228, 48);
            salary_btn.TabIndex = 4;
            salary_btn.Text = "SALARY";
            salary_btn.UseVisualStyleBackColor = false;
            salary_btn.Click += salary_btn_Click;
            // 
            // addEmployee_btn
            // 
            addEmployee_btn.BackColor = Color.DarkCyan;
            addEmployee_btn.Cursor = Cursors.Hand;
            addEmployee_btn.FlatAppearance.BorderSize = 0;
            addEmployee_btn.ForeColor = Color.White;
            addEmployee_btn.Image = Properties.Resources.access_card;
            addEmployee_btn.ImageAlign = ContentAlignment.MiddleLeft;
            addEmployee_btn.Location = new Point(15, 333);
            addEmployee_btn.Name = "addEmployee_btn";
            addEmployee_btn.Padding = new Padding(10, 0, 0, 0);
            addEmployee_btn.Size = new Size(228, 48);
            addEmployee_btn.TabIndex = 3;
            addEmployee_btn.Text = "ADD EMPLOYEE";
            addEmployee_btn.UseVisualStyleBackColor = false;
            addEmployee_btn.Click += addEmployee_btn_Click;
            // 
            // dashboard_btn
            // 
            dashboard_btn.BackColor = Color.DarkCyan;
            dashboard_btn.Cursor = Cursors.Hand;
            dashboard_btn.FlatAppearance.BorderSize = 0;
            dashboard_btn.ForeColor = Color.Transparent;
            dashboard_btn.Image = Properties.Resources.speedometer1;
            dashboard_btn.ImageAlign = ContentAlignment.MiddleLeft;
            dashboard_btn.Location = new Point(14, 265);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Padding = new Padding(10, 0, 0, 0);
            dashboard_btn.Size = new Size(228, 48);
            dashboard_btn.TabIndex = 2;
            dashboard_btn.Text = "DASHBOARD";
            dashboard_btn.UseVisualStyleBackColor = false;
            dashboard_btn.Click += dashboard_btn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.employe_card;
            pictureBox1.Location = new Point(68, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(56, 172);
            label3.Name = "label3";
            label3.Size = new Size(135, 23);
            label3.TabIndex = 0;
            label3.Text = "Welcome, User";
            // 
            // panel3
            // 
            panel3.Controls.Add(dashboard1);
            panel3.Controls.Add(addEmployee1);
            panel3.Controls.Add(salary1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(255, 42);
            panel3.Name = "panel3";
            panel3.Size = new Size(1002, 678);
            panel3.TabIndex = 2;
            // 
            // dashboard1
            // 
            dashboard1.ForeColor = Color.Black;
            dashboard1.Location = new Point(-3, 0);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(1005, 678);
            dashboard1.TabIndex = 2;
            // 
            // addEmployee1
            // 
            addEmployee1.ForeColor = Color.Black;
            addEmployee1.Location = new Point(3, 0);
            addEmployee1.Name = "addEmployee1";
            addEmployee1.Size = new Size(999, 678);
            addEmployee1.TabIndex = 1;
            // 
            // salary1
            // 
            salary1.ForeColor = Color.Black;
            salary1.Location = new Point(0, 0);
            salary1.Name = "salary1";
            salary1.Size = new Size(1002, 678);
            salary1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 720);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label exit;
        private Label label2;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label3;
        private Button dashboard_btn;
        private Button logout_btn;
        private Button salary_btn;
        private Button addEmployee_btn;
        private Label label4;
        private Panel panel3;
        private Dashboard dashboard1;
        private AddEmployee addEmployee1;
        private Salary salary1;
    }
}