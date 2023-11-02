namespace LibraryManagement
{
    partial class BorrowUserControl
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
            this.register = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contact_number = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.delete_user = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(661, 470);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(180, 72);
            this.register.TabIndex = 36;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(288, 632);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 31);
            this.textBox4.TabIndex = 33;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(288, 582);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 31);
            this.textBox3.TabIndex = 32;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(288, 525);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 31);
            this.textBox2.TabIndex = 31;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(288, 470);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 31);
            this.textBox1.TabIndex = 30;
            // 
            // contact_number
            // 
            this.contact_number.AutoSize = true;
            this.contact_number.Location = new System.Drawing.Point(87, 632);
            this.contact_number.Name = "contact_number";
            this.contact_number.Size = new System.Drawing.Size(110, 25);
            this.contact_number.TabIndex = 27;
            this.contact_number.Text = "Phone no.";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(87, 582);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(91, 25);
            this.Address.TabIndex = 26;
            this.Address.Text = "Address";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(87, 525);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(119, 25);
            this.name.TabIndex = 25;
            this.name.Text = "User Name";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(87, 468);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(83, 25);
            this.id.TabIndex = 24;
            this.id.Text = "User ID";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(52, 117);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 82;
            this.dataGridView3.RowTemplate.Height = 33;
            this.dataGridView3.Size = new System.Drawing.Size(1029, 280);
            this.dataGridView3.TabIndex = 23;
            // 
            // delete_user
            // 
            this.delete_user.Location = new System.Drawing.Point(661, 582);
            this.delete_user.Name = "delete_user";
            this.delete_user.Size = new System.Drawing.Size(180, 75);
            this.delete_user.TabIndex = 37;
            this.delete_user.Text = "Delete User";
            this.delete_user.UseVisualStyleBackColor = true;
            this.delete_user.Click += new System.EventHandler(this.delete_user_Click);
            // 
            // BorrowUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.delete_user);
            this.Controls.Add(this.register);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.contact_number);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Controls.Add(this.dataGridView3);
            this.Name = "BorrowUserControl";
            this.Size = new System.Drawing.Size(1132, 883);
            this.Load += new System.EventHandler(this.BorrowUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button register;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label contact_number;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button delete_user;
    }
}
