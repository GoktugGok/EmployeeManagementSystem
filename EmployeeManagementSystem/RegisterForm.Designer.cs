namespace EmployeeManagementSystem
{
    partial class RegisterForm
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
            register_showPass = new CheckBox();
            register_btn = new Button();
            register_password = new TextBox();
            label4 = new Label();
            register_username = new TextBox();
            label3 = new Label();
            label2 = new Label();
            exit = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            register_signInBtn = new Button();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // register_showPass
            // 
            register_showPass.AutoSize = true;
            register_showPass.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            register_showPass.Location = new Point(434, 252);
            register_showPass.Name = "register_showPass";
            register_showPass.Size = new Size(112, 18);
            register_showPass.TabIndex = 17;
            register_showPass.Text = "Show Password";
            register_showPass.UseVisualStyleBackColor = true;
            register_showPass.CheckedChanged += register_showPass_CheckedChanged;
            // 
            // register_btn
            // 
            register_btn.BackColor = Color.FromArgb(33, 11, 97);
            register_btn.Cursor = Cursors.Hand;
            register_btn.FlatAppearance.BorderSize = 0;
            register_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            register_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            register_btn.FlatStyle = FlatStyle.Flat;
            register_btn.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            register_btn.ForeColor = Color.White;
            register_btn.Location = new Point(270, 295);
            register_btn.Name = "register_btn";
            register_btn.Size = new Size(108, 40);
            register_btn.TabIndex = 16;
            register_btn.Text = "SIGN UP";
            register_btn.UseVisualStyleBackColor = false;
            register_btn.Click += register_btn_Click;
            // 
            // register_password
            // 
            register_password.Location = new Point(270, 216);
            register_password.Multiline = true;
            register_password.Name = "register_password";
            register_password.PasswordChar = '*';
            register_password.Size = new Size(276, 30);
            register_password.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(270, 195);
            label4.Name = "label4";
            label4.Size = new Size(74, 18);
            label4.TabIndex = 14;
            label4.Text = "Password:";
            // 
            // register_username
            // 
            register_username.Location = new Point(270, 149);
            register_username.Multiline = true;
            register_username.Name = "register_username";
            register_username.Size = new Size(276, 30);
            register_username.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(270, 128);
            label3.Name = "label3";
            label3.Size = new Size(80, 18);
            label3.TabIndex = 12;
            label3.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(269, 59);
            label2.Name = "label2";
            label2.Size = new Size(184, 24);
            label2.TabIndex = 11;
            label2.Text = "Register Account";
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            exit.Location = new Point(544, 9);
            exit.Name = "exit";
            exit.Size = new Size(17, 18);
            exit.TabIndex = 9;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(75, 8, 138);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(register_signInBtn);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = SystemColors.Window;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(253, 414);
            panel1.TabIndex = 10;
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
            // register_signInBtn
            // 
            register_signInBtn.BackColor = Color.FromArgb(33, 11, 97);
            register_signInBtn.Cursor = Cursors.Hand;
            register_signInBtn.FlatAppearance.BorderSize = 0;
            register_signInBtn.FlatAppearance.MouseDownBackColor = Color.Purple;
            register_signInBtn.FlatAppearance.MouseOverBackColor = Color.Purple;
            register_signInBtn.FlatStyle = FlatStyle.Flat;
            register_signInBtn.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            register_signInBtn.ForeColor = Color.White;
            register_signInBtn.Location = new Point(11, 363);
            register_signInBtn.Name = "register_signInBtn";
            register_signInBtn.Size = new Size(226, 33);
            register_signInBtn.TabIndex = 10;
            register_signInBtn.Text = "SIGN IN";
            register_signInBtn.UseVisualStyleBackColor = false;
            register_signInBtn.Click += register_signInBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.White;
            label5.Location = new Point(60, 333);
            label5.Name = "label5";
            label5.Size = new Size(115, 16);
            label5.TabIndex = 9;
            label5.Text = "Login your Account";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(575, 414);
            Controls.Add(register_showPass);
            Controls.Add(register_btn);
            Controls.Add(register_password);
            Controls.Add(label4);
            Controls.Add(register_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(exit);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox register_showPass;
        private Button register_btn;
        private TextBox register_password;
        private Label label4;
        private TextBox register_username;
        private Label label3;
        private Label label2;
        private Label exit;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label6;
        private Button register_signInBtn;
        private Label label5;
    }
}