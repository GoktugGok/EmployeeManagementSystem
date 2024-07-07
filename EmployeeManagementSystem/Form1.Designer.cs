namespace EmployeeManagementSystem
{
    partial class Form1
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            login_signupBtn = new Button();
            label5 = new Label();
            exit = new Label();
            label2 = new Label();
            label3 = new Label();
            login_username = new TextBox();
            login_password = new TextBox();
            label4 = new Label();
            login_btn = new Button();
            login_showPass = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(75, 8, 138);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(login_signupBtn);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = SystemColors.Window;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(253, 414);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.employe_card;
            pictureBox1.Location = new Point(75, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(14, 203);
            label6.Name = "label6";
            label6.Size = new Size(229, 19);
            label6.TabIndex = 11;
            label6.Text = "Employee Management System";
            // 
            // login_signupBtn
            // 
            login_signupBtn.BackColor = Color.FromArgb(33, 11, 97);
            login_signupBtn.Cursor = Cursors.Hand;
            login_signupBtn.FlatAppearance.BorderSize = 0;
            login_signupBtn.FlatAppearance.MouseDownBackColor = Color.Purple;
            login_signupBtn.FlatAppearance.MouseOverBackColor = Color.Purple;
            login_signupBtn.FlatStyle = FlatStyle.Flat;
            login_signupBtn.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            login_signupBtn.ForeColor = Color.White;
            login_signupBtn.Location = new Point(11, 363);
            login_signupBtn.Name = "login_signupBtn";
            login_signupBtn.Size = new Size(226, 33);
            login_signupBtn.TabIndex = 10;
            login_signupBtn.Text = "SIGN UP";
            login_signupBtn.UseVisualStyleBackColor = false;
            login_signupBtn.Click += login_signupBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.White;
            label5.Location = new Point(61, 328);
            label5.Name = "label5";
            label5.Size = new Size(132, 16);
            label5.TabIndex = 9;
            label5.Text = "Register your Account";
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            exit.Location = new Point(546, 9);
            exit.Name = "exit";
            exit.Size = new Size(17, 18);
            exit.TabIndex = 0;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(271, 59);
            label2.Name = "label2";
            label2.Size = new Size(157, 24);
            label2.TabIndex = 1;
            label2.Text = "Login Account";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(272, 128);
            label3.Name = "label3";
            label3.Size = new Size(80, 18);
            label3.TabIndex = 3;
            label3.Text = "Username:";
            // 
            // login_username
            // 
            login_username.Location = new Point(272, 149);
            login_username.Multiline = true;
            login_username.Name = "login_username";
            login_username.Size = new Size(276, 30);
            login_username.TabIndex = 4;
            // 
            // login_password
            // 
            login_password.Location = new Point(272, 216);
            login_password.Multiline = true;
            login_password.Name = "login_password";
            login_password.Size = new Size(276, 30);
            login_password.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(272, 195);
            label4.Name = "label4";
            label4.Size = new Size(74, 18);
            label4.TabIndex = 5;
            label4.Text = "Password:";
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.FromArgb(33, 11, 97);
            login_btn.Cursor = Cursors.Hand;
            login_btn.FlatAppearance.BorderSize = 0;
            login_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            login_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            login_btn.ForeColor = Color.White;
            login_btn.Location = new Point(272, 295);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(108, 40);
            login_btn.TabIndex = 7;
            login_btn.Text = "LOGIN";
            login_btn.UseVisualStyleBackColor = false;
            // 
            // login_showPass
            // 
            login_showPass.AutoSize = true;
            login_showPass.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            login_showPass.Location = new Point(436, 252);
            login_showPass.Name = "login_showPass";
            login_showPass.Size = new Size(112, 18);
            login_showPass.TabIndex = 8;
            login_showPass.Text = "Show Password";
            login_showPass.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(575, 414);
            Controls.Add(login_showPass);
            Controls.Add(login_btn);
            Controls.Add(login_password);
            Controls.Add(label4);
            Controls.Add(login_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(exit);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "l";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label exit;
        private Label label2;
        private Label label3;
        private TextBox login_username;
        private TextBox login_password;
        private Label label4;
        private Button login_btn;
        private CheckBox login_showPass;
        private Button login_signupBtn;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label6;
    }
}
