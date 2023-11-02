namespace LibraryManagement
{
    partial class DepartmentUserControl
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
            this.department = new System.Windows.Forms.Label();
            this.rack_code = new System.Windows.Forms.Label();
            this.department_ID = new System.Windows.Forms.Label();
            this.department_name = new System.Windows.Forms.Label();
            this.department_ID_box = new System.Windows.Forms.TextBox();
            this.department_name_box = new System.Windows.Forms.TextBox();
            this.rack_code_box = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Add_Department = new System.Windows.Forms.Button();
            this.Delete_Department = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // department
            // 
            this.department.AutoSize = true;
            this.department.Location = new System.Drawing.Point(433, 84);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(189, 25);
            this.department.TabIndex = 1;
            this.department.Text = "Department_Table";
            // 
            // rack_code
            // 
            this.rack_code.AutoSize = true;
            this.rack_code.Location = new System.Drawing.Point(334, 780);
            this.rack_code.Name = "rack_code";
            this.rack_code.Size = new System.Drawing.Size(120, 25);
            this.rack_code.TabIndex = 2;
            this.rack_code.Text = "Rack_code";
            // 
            // department_ID
            // 
            this.department_ID.AutoSize = true;
            this.department_ID.Location = new System.Drawing.Point(133, 636);
            this.department_ID.Name = "department_ID";
            this.department_ID.Size = new System.Drawing.Size(155, 25);
            this.department_ID.TabIndex = 4;
            this.department_ID.Text = "Department_ID";
            // 
            // department_name
            // 
            this.department_name.AutoSize = true;
            this.department_name.Location = new System.Drawing.Point(712, 636);
            this.department_name.Name = "department_name";
            this.department_name.Size = new System.Drawing.Size(191, 25);
            this.department_name.TabIndex = 6;
            this.department_name.Text = "Department_Name";
            // 
            // department_ID_box
            // 
            this.department_ID_box.Location = new System.Drawing.Point(339, 633);
            this.department_ID_box.Name = "department_ID_box";
            this.department_ID_box.Size = new System.Drawing.Size(100, 31);
            this.department_ID_box.TabIndex = 7;
            // 
            // department_name_box
            // 
            this.department_name_box.Location = new System.Drawing.Point(939, 630);
            this.department_name_box.Name = "department_name_box";
            this.department_name_box.Size = new System.Drawing.Size(100, 31);
            this.department_name_box.TabIndex = 9;
            // 
            // rack_code_box
            // 
            this.rack_code_box.Location = new System.Drawing.Point(522, 774);
            this.rack_code_box.Name = "rack_code_box";
            this.rack_code_box.Size = new System.Drawing.Size(100, 31);
            this.rack_code_box.TabIndex = 11;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(49, 144);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 82;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(1028, 360);
            this.dataGridView2.TabIndex = 12;
            // 
            // Add_Department
            // 
            this.Add_Department.Location = new System.Drawing.Point(283, 562);
            this.Add_Department.Name = "Add_Department";
            this.Add_Department.Size = new System.Drawing.Size(124, 34);
            this.Add_Department.TabIndex = 13;
            this.Add_Department.Text = "ADD Department";
            this.Add_Department.UseVisualStyleBackColor = true;
            this.Add_Department.Click += new System.EventHandler(this.Add_Department_Click);
            // 
            // Delete_Department
            // 
            this.Delete_Department.Location = new System.Drawing.Point(622, 562);
            this.Delete_Department.Name = "Delete_Department";
            this.Delete_Department.Size = new System.Drawing.Size(215, 34);
            this.Delete_Department.TabIndex = 15;
            this.Delete_Department.Text = "Delete_Department";
            this.Delete_Department.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Delete_Department.UseVisualStyleBackColor = true;
            // 
            // DepartmentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Delete_Department);
            this.Controls.Add(this.Add_Department);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.rack_code_box);
            this.Controls.Add(this.department_name_box);
            this.Controls.Add(this.department_ID_box);
            this.Controls.Add(this.department_name);
            this.Controls.Add(this.department_ID);
            this.Controls.Add(this.rack_code);
            this.Controls.Add(this.department);
            this.Name = "DepartmentUserControl";
            this.Size = new System.Drawing.Size(1132, 883);
            this.Load += new System.EventHandler(this.DepartmentUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label department;
        private System.Windows.Forms.Label rack_code;
        private System.Windows.Forms.Label department_ID;
        private System.Windows.Forms.Label department_name;
        private System.Windows.Forms.TextBox department_ID_box;
        private System.Windows.Forms.TextBox department_name_box;
        private System.Windows.Forms.TextBox rack_code_box;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Add_Department;
        private System.Windows.Forms.Button Delete_Department;
    }
}
