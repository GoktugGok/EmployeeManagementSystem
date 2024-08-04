namespace EmployeeManagementSystem
{
    partial class Salary
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
            label1 = new Label();
            panel1 = new Panel();
            salary_clearBtn = new Button();
            salary_updateBtn = new Button();
            salary_salary = new TextBox();
            label5 = new Label();
            salary_position = new TextBox();
            label4 = new Label();
            salary_name = new TextBox();
            label3 = new Label();
            salary_employeeID = new TextBox();
            E = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(16, 29);
            label1.Name = "label1";
            label1.Size = new Size(99, 23);
            label1.TabIndex = 0;
            label1.Text = "Employees";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(salary_clearBtn);
            panel1.Controls.Add(salary_updateBtn);
            panel1.Controls.Add(salary_salary);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(salary_position);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(salary_name);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(salary_employeeID);
            panel1.Controls.Add(E);
            panel1.Location = new Point(24, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(306, 627);
            panel1.TabIndex = 1;
            // 
            // salary_clearBtn
            // 
            salary_clearBtn.BackColor = Color.FromArgb(33, 11, 97);
            salary_clearBtn.FlatAppearance.BorderColor = Color.FromArgb(33, 11, 97);
            salary_clearBtn.FlatAppearance.BorderSize = 0;
            salary_clearBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(75, 8, 138);
            salary_clearBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            salary_clearBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            salary_clearBtn.FlatStyle = FlatStyle.Flat;
            salary_clearBtn.Font = new Font("Arial", 9.75F);
            salary_clearBtn.ForeColor = Color.White;
            salary_clearBtn.Location = new Point(165, 384);
            salary_clearBtn.Name = "salary_clearBtn";
            salary_clearBtn.Size = new Size(114, 40);
            salary_clearBtn.TabIndex = 17;
            salary_clearBtn.Text = "Clear";
            salary_clearBtn.UseVisualStyleBackColor = false;
            salary_clearBtn.Click += salary_clearBtn_Click;
            // 
            // salary_updateBtn
            // 
            salary_updateBtn.BackColor = Color.FromArgb(33, 11, 97);
            salary_updateBtn.FlatAppearance.BorderColor = Color.FromArgb(33, 11, 97);
            salary_updateBtn.FlatAppearance.BorderSize = 0;
            salary_updateBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(75, 8, 138);
            salary_updateBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            salary_updateBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            salary_updateBtn.FlatStyle = FlatStyle.Flat;
            salary_updateBtn.Font = new Font("Arial", 9.75F);
            salary_updateBtn.ForeColor = Color.White;
            salary_updateBtn.Location = new Point(23, 384);
            salary_updateBtn.Name = "salary_updateBtn";
            salary_updateBtn.Size = new Size(114, 40);
            salary_updateBtn.TabIndex = 16;
            salary_updateBtn.Text = "Update";
            salary_updateBtn.UseVisualStyleBackColor = false;
            salary_updateBtn.Click += salary_updateBtn_Click;
            // 
            // salary_salary
            // 
            salary_salary.Font = new Font("Microsoft Sans Serif", 9.75F);
            salary_salary.Location = new Point(23, 308);
            salary_salary.Multiline = true;
            salary_salary.Name = "salary_salary";
            salary_salary.Size = new Size(260, 31);
            salary_salary.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(23, 287);
            label5.Name = "label5";
            label5.Size = new Size(57, 18);
            label5.TabIndex = 6;
            label5.Text = "Salary :";
            // 
            // salary_position
            // 
            salary_position.Font = new Font("Microsoft Sans Serif", 9.75F);
            salary_position.Location = new Point(19, 236);
            salary_position.Multiline = true;
            salary_position.Name = "salary_position";
            salary_position.Size = new Size(260, 31);
            salary_position.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(19, 215);
            label4.Name = "label4";
            label4.Size = new Size(66, 18);
            label4.TabIndex = 4;
            label4.Text = "Position :";
            // 
            // salary_name
            // 
            salary_name.Font = new Font("Microsoft Sans Serif", 9.75F);
            salary_name.Location = new Point(19, 159);
            salary_name.Multiline = true;
            salary_name.Name = "salary_name";
            salary_name.Size = new Size(260, 31);
            salary_name.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(19, 138);
            label3.Name = "label3";
            label3.Size = new Size(82, 18);
            label3.TabIndex = 2;
            label3.Text = "Full Name :";
            // 
            // salary_employeeID
            // 
            salary_employeeID.Font = new Font("Microsoft Sans Serif", 9.75F);
            salary_employeeID.Location = new Point(19, 85);
            salary_employeeID.Multiline = true;
            salary_employeeID.Name = "salary_employeeID";
            salary_employeeID.Size = new Size(260, 31);
            salary_employeeID.TabIndex = 1;
            // 
            // E
            // 
            E.AutoSize = true;
            E.BackColor = SystemColors.Control;
            E.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            E.ForeColor = Color.Black;
            E.Location = new Point(19, 64);
            E.Name = "E";
            E.Size = new Size(102, 18);
            E.TabIndex = 0;
            E.Text = "Employee ID :";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(355, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(631, 627);
            panel2.TabIndex = 2;
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
            dataGridView1.Location = new Point(16, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(597, 548);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Salary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Salary";
            Size = new Size(1002, 678);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label E;
        private Panel panel2;
        private TextBox salary_salary;
        private Label label5;
        private TextBox salary_position;
        private Label label4;
        private TextBox salary_name;
        private Label label3;
        private TextBox salary_employeeID;
        private Button button2;
        private Button button4;
        private Button salary_clearBtn;
        private Button salary_updateBtn;
        private DataGridView dataGridView1;
    }
}
