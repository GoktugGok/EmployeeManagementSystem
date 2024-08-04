namespace EmployeeManagementSystem
{
    partial class AddEmployee
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            addEmployee_status = new ComboBox();
            label6 = new Label();
            addEmployee_clearBtn = new Button();
            addEmployee_deleteBtn = new Button();
            addEmployee_updateBtn = new Button();
            addEmployee_addBtn = new Button();
            addEmployee_Import = new Button();
            addEmployee_picture = new PictureBox();
            addEmployee_position = new ComboBox();
            position = new Label();
            addEmployee_phoneNumber = new TextBox();
            label5 = new Label();
            addEmployee_gender = new ComboBox();
            label4 = new Label();
            addEmployee_fullName = new TextBox();
            label3 = new Label();
            addEmployee_id = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addEmployee_picture).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(18, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(965, 334);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(33, 11, 97);
            dataGridViewCellStyle1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(24, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(915, 236);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(24, 26);
            label1.Name = "label1";
            label1.Size = new Size(165, 25);
            label1.TabIndex = 0;
            label1.Text = "Employee's Data";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(addEmployee_status);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(addEmployee_clearBtn);
            panel2.Controls.Add(addEmployee_deleteBtn);
            panel2.Controls.Add(addEmployee_updateBtn);
            panel2.Controls.Add(addEmployee_addBtn);
            panel2.Controls.Add(addEmployee_Import);
            panel2.Controls.Add(addEmployee_picture);
            panel2.Controls.Add(addEmployee_position);
            panel2.Controls.Add(position);
            panel2.Controls.Add(addEmployee_phoneNumber);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(addEmployee_gender);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(addEmployee_fullName);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(addEmployee_id);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(18, 383);
            panel2.Name = "panel2";
            panel2.Size = new Size(965, 277);
            panel2.TabIndex = 1;
            // 
            // addEmployee_status
            // 
            addEmployee_status.Font = new Font("Tahoma", 9F);
            addEmployee_status.FormattingEnabled = true;
            addEmployee_status.Items.AddRange(new object[] { "Active", "Inactive" });
            addEmployee_status.Location = new Point(483, 139);
            addEmployee_status.Name = "addEmployee_status";
            addEmployee_status.Size = new Size(195, 22);
            addEmployee_status.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 11.25F);
            label6.Location = new Point(414, 139);
            label6.Name = "label6";
            label6.Size = new Size(64, 18);
            label6.TabIndex = 18;
            label6.Text = "Status  :";
            // 
            // addEmployee_clearBtn
            // 
            addEmployee_clearBtn.BackColor = Color.FromArgb(33, 11, 97);
            addEmployee_clearBtn.FlatAppearance.BorderColor = Color.FromArgb(33, 11, 97);
            addEmployee_clearBtn.FlatAppearance.BorderSize = 0;
            addEmployee_clearBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(75, 8, 138);
            addEmployee_clearBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            addEmployee_clearBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            addEmployee_clearBtn.FlatStyle = FlatStyle.Flat;
            addEmployee_clearBtn.Font = new Font("Arial", 9.75F);
            addEmployee_clearBtn.ForeColor = Color.White;
            addEmployee_clearBtn.Location = new Point(616, 207);
            addEmployee_clearBtn.Name = "addEmployee_clearBtn";
            addEmployee_clearBtn.Size = new Size(114, 40);
            addEmployee_clearBtn.TabIndex = 17;
            addEmployee_clearBtn.Text = "Clear";
            addEmployee_clearBtn.UseVisualStyleBackColor = false;
            addEmployee_clearBtn.Click += addEmployee_clearBtn_Click;
            // 
            // addEmployee_deleteBtn
            // 
            addEmployee_deleteBtn.BackColor = Color.FromArgb(33, 11, 97);
            addEmployee_deleteBtn.FlatAppearance.BorderColor = Color.FromArgb(33, 11, 97);
            addEmployee_deleteBtn.FlatAppearance.BorderSize = 0;
            addEmployee_deleteBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(75, 8, 138);
            addEmployee_deleteBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            addEmployee_deleteBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            addEmployee_deleteBtn.FlatStyle = FlatStyle.Flat;
            addEmployee_deleteBtn.Font = new Font("Arial", 9.75F);
            addEmployee_deleteBtn.ForeColor = Color.White;
            addEmployee_deleteBtn.Location = new Point(496, 207);
            addEmployee_deleteBtn.Name = "addEmployee_deleteBtn";
            addEmployee_deleteBtn.Size = new Size(114, 40);
            addEmployee_deleteBtn.TabIndex = 16;
            addEmployee_deleteBtn.Text = "Delete";
            addEmployee_deleteBtn.UseVisualStyleBackColor = false;
            addEmployee_deleteBtn.Click += addEmployee_deleteBtn_Click;
            // 
            // addEmployee_updateBtn
            // 
            addEmployee_updateBtn.BackColor = Color.FromArgb(33, 11, 97);
            addEmployee_updateBtn.FlatAppearance.BorderColor = Color.FromArgb(33, 11, 97);
            addEmployee_updateBtn.FlatAppearance.BorderSize = 0;
            addEmployee_updateBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(75, 8, 138);
            addEmployee_updateBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            addEmployee_updateBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            addEmployee_updateBtn.FlatStyle = FlatStyle.Flat;
            addEmployee_updateBtn.Font = new Font("Arial", 9.75F);
            addEmployee_updateBtn.ForeColor = Color.White;
            addEmployee_updateBtn.Location = new Point(324, 207);
            addEmployee_updateBtn.Name = "addEmployee_updateBtn";
            addEmployee_updateBtn.Size = new Size(114, 40);
            addEmployee_updateBtn.TabIndex = 15;
            addEmployee_updateBtn.Text = "Update";
            addEmployee_updateBtn.UseVisualStyleBackColor = false;
            addEmployee_updateBtn.Click += addEmployee_updateBtn_Click;
            // 
            // addEmployee_addBtn
            // 
            addEmployee_addBtn.BackColor = Color.FromArgb(33, 11, 97);
            addEmployee_addBtn.FlatAppearance.BorderColor = Color.FromArgb(33, 11, 97);
            addEmployee_addBtn.FlatAppearance.BorderSize = 0;
            addEmployee_addBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(75, 8, 138);
            addEmployee_addBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            addEmployee_addBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            addEmployee_addBtn.FlatStyle = FlatStyle.Flat;
            addEmployee_addBtn.Font = new Font("Arial", 9.75F);
            addEmployee_addBtn.ForeColor = Color.White;
            addEmployee_addBtn.Location = new Point(204, 207);
            addEmployee_addBtn.Name = "addEmployee_addBtn";
            addEmployee_addBtn.Size = new Size(114, 40);
            addEmployee_addBtn.TabIndex = 14;
            addEmployee_addBtn.Text = "Add";
            addEmployee_addBtn.UseVisualStyleBackColor = false;
            addEmployee_addBtn.Click += addEmployee_addBtn_Click;
            // 
            // addEmployee_Import
            // 
            addEmployee_Import.BackColor = Color.FromArgb(33, 11, 97);
            addEmployee_Import.FlatAppearance.BorderSize = 0;
            addEmployee_Import.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            addEmployee_Import.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            addEmployee_Import.FlatStyle = FlatStyle.Flat;
            addEmployee_Import.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            addEmployee_Import.ForeColor = Color.White;
            addEmployee_Import.Location = new Point(831, 147);
            addEmployee_Import.Name = "addEmployee_Import";
            addEmployee_Import.Size = new Size(108, 37);
            addEmployee_Import.TabIndex = 13;
            addEmployee_Import.Text = "Import";
            addEmployee_Import.UseVisualStyleBackColor = false;
            addEmployee_Import.Click += addEmployee_Import_Click;
            // 
            // addEmployee_picture
            // 
            addEmployee_picture.BackColor = SystemColors.ButtonShadow;
            addEmployee_picture.BorderStyle = BorderStyle.FixedSingle;
            addEmployee_picture.Location = new Point(831, 35);
            addEmployee_picture.Name = "addEmployee_picture";
            addEmployee_picture.Size = new Size(108, 106);
            addEmployee_picture.SizeMode = PictureBoxSizeMode.StretchImage;
            addEmployee_picture.TabIndex = 12;
            addEmployee_picture.TabStop = false;
            // 
            // addEmployee_position
            // 
            addEmployee_position.Font = new Font("Tahoma", 9F);
            addEmployee_position.FormattingEnabled = true;
            addEmployee_position.Items.AddRange(new object[] { "Business Management", "Front-End Developer", "Back-End Developer", "Data Administrator", "UI/UX Design" });
            addEmployee_position.Location = new Point(483, 97);
            addEmployee_position.Name = "addEmployee_position";
            addEmployee_position.Size = new Size(195, 22);
            addEmployee_position.TabIndex = 11;
            // 
            // position
            // 
            position.AutoSize = true;
            position.Font = new Font("Tahoma", 11.25F);
            position.Location = new Point(406, 97);
            position.Name = "position";
            position.Size = new Size(71, 18);
            position.TabIndex = 10;
            position.Text = "Position  :";
            // 
            // addEmployee_phoneNumber
            // 
            addEmployee_phoneNumber.Font = new Font("Tahoma", 9F);
            addEmployee_phoneNumber.Location = new Point(484, 53);
            addEmployee_phoneNumber.Name = "addEmployee_phoneNumber";
            addEmployee_phoneNumber.Size = new Size(166, 22);
            addEmployee_phoneNumber.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 11.25F);
            label5.Location = new Point(363, 53);
            label5.Name = "label5";
            label5.Size = new Size(115, 18);
            label5.TabIndex = 8;
            label5.Text = "Phone Number :";
            // 
            // addEmployee_gender
            // 
            addEmployee_gender.Font = new Font("Tahoma", 9F);
            addEmployee_gender.FormattingEnabled = true;
            addEmployee_gender.Items.AddRange(new object[] { "Male", "Female", "Others" });
            addEmployee_gender.Location = new Point(145, 139);
            addEmployee_gender.Name = "addEmployee_gender";
            addEmployee_gender.Size = new Size(174, 22);
            addEmployee_gender.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F);
            label4.Location = new Point(69, 139);
            label4.Name = "label4";
            label4.Size = new Size(70, 18);
            label4.TabIndex = 6;
            label4.Text = "Gender  :";
            // 
            // addEmployee_fullName
            // 
            addEmployee_fullName.Font = new Font("Tahoma", 9F);
            addEmployee_fullName.Location = new Point(145, 97);
            addEmployee_fullName.Name = "addEmployee_fullName";
            addEmployee_fullName.Size = new Size(174, 22);
            addEmployee_fullName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F);
            label3.Location = new Point(57, 97);
            label3.Name = "label3";
            label3.Size = new Size(82, 18);
            label3.TabIndex = 4;
            label3.Text = "Full Name :";
            // 
            // addEmployee_id
            // 
            addEmployee_id.Font = new Font("Tahoma", 9F);
            addEmployee_id.Location = new Point(145, 53);
            addEmployee_id.Name = "addEmployee_id";
            addEmployee_id.Size = new Size(151, 22);
            addEmployee_id.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.25F);
            label2.Location = new Point(37, 53);
            label2.Name = "label2";
            label2.Size = new Size(102, 18);
            label2.TabIndex = 2;
            label2.Text = "Employee ID :";
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AddEmployee";
            Size = new Size(1002, 678);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)addEmployee_picture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label1;
        private Panel panel2;
        private TextBox addEmployee_fullName;
        private Label label3;
        private TextBox addEmployee_id;
        private Label label2;
        private TextBox addEmployee_phoneNumber;
        private Label label5;
        private ComboBox addEmployee_gender;
        private Label label4;
        private Button addEmployee_addBtn;
        private Button addEmployee_Import;
        private PictureBox addEmployee_picture;
        private ComboBox addEmployee_position;
        private Label position;
        private Button addEmployee_clearBtn;
        private Button addEmployee_deleteBtn;
        private Button addEmployee_updateBtn;
        private ComboBox addEmployee_status;
        private Label label6;
    }
}
