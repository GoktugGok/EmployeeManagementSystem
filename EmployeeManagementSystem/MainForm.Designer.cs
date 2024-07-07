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
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 11, 97);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1257, 42);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(1227, 11);
            label1.Name = "label1";
            label1.Size = new Size(17, 18);
            label1.TabIndex = 1;
            label1.Text = "X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 11);
            label2.Name = "label2";
            label2.Size = new Size(186, 16);
            label2.TabIndex = 1;
            label2.Text = "Employee Management System";
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(255, 678);
            panel2.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 720);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel2;
    }
}