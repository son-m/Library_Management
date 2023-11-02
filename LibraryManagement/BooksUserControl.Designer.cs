namespace LibraryManagement
{
    partial class BooksUserControl
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
            this.BOOK_ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BOOK_NAME = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.bookid = new System.Windows.Forms.TextBox();
            this.bookname = new System.Windows.Forms.TextBox();
            this.Isno = new System.Windows.Forms.TextBox();
            this.publisher = new System.Windows.Forms.TextBox();
            this.author = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.depid = new System.Windows.Forms.Label();
            this.departmentid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BOOK_ID
            // 
            this.BOOK_ID.AutoSize = true;
            this.BOOK_ID.Location = new System.Drawing.Point(195, 100);
            this.BOOK_ID.Name = "BOOK_ID";
            this.BOOK_ID.Size = new System.Drawing.Size(104, 25);
            this.BOOK_ID.TabIndex = 0;
            this.BOOK_ID.Text = "BOOK_ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 569);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "BOOK_ID";
            // 
            // BOOK_NAME
            // 
            this.BOOK_NAME.AutoSize = true;
            this.BOOK_NAME.Location = new System.Drawing.Point(195, 633);
            this.BOOK_NAME.Name = "BOOK_NAME";
            this.BOOK_NAME.Size = new System.Drawing.Size(145, 25);
            this.BOOK_NAME.TabIndex = 2;
            this.BOOK_NAME.Text = "BOOK_NAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 736);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "PUBLISHER";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(717, 633);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "IS Book No.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(717, 736);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "AUTHOR";
            // 
            // searchbox
            // 
            this.searchbox.Location = new System.Drawing.Point(372, 94);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(100, 31);
            this.searchbox.TabIndex = 6;
            // 
            // bookid
            // 
            this.bookid.Location = new System.Drawing.Point(610, 563);
            this.bookid.Name = "bookid";
            this.bookid.Size = new System.Drawing.Size(100, 31);
            this.bookid.TabIndex = 7;
            // 
            // bookname
            // 
            this.bookname.Location = new System.Drawing.Point(372, 630);
            this.bookname.Name = "bookname";
            this.bookname.Size = new System.Drawing.Size(100, 31);
            this.bookname.TabIndex = 8;
            // 
            // Isno
            // 
            this.Isno.Location = new System.Drawing.Point(865, 627);
            this.Isno.Name = "Isno";
            this.Isno.Size = new System.Drawing.Size(100, 31);
            this.Isno.TabIndex = 9;
            // 
            // publisher
            // 
            this.publisher.Location = new System.Drawing.Point(372, 736);
            this.publisher.Name = "publisher";
            this.publisher.Size = new System.Drawing.Size(100, 31);
            this.publisher.TabIndex = 10;
            // 
            // author
            // 
            this.author.Location = new System.Drawing.Point(865, 733);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(100, 31);
            this.author.TabIndex = 11;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(327, 467);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(131, 48);
            this.update.TabIndex = 14;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(81, 467);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(146, 48);
            this.Add.TabIndex = 15;
            this.Add.Text = "Add New";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(842, 467);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(123, 48);
            this.clear.TabIndex = 17;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(547, 90);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(172, 44);
            this.search.TabIndex = 19;
            this.search.Text = "Search Books";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(595, 467);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(124, 48);
            this.Delete.TabIndex = 21;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(63, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1024, 246);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // depid
            // 
            this.depid.AutoSize = true;
            this.depid.Location = new System.Drawing.Point(442, 797);
            this.depid.Name = "depid";
            this.depid.Size = new System.Drawing.Size(155, 25);
            this.depid.TabIndex = 23;
            this.depid.Text = "Department_ID";
            // 
            // departmentid
            // 
            this.departmentid.Location = new System.Drawing.Point(619, 797);
            this.departmentid.Name = "departmentid";
            this.departmentid.Size = new System.Drawing.Size(100, 31);
            this.departmentid.TabIndex = 24;
            // 
            // BooksUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.departmentid);
            this.Controls.Add(this.depid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.search);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.update);
            this.Controls.Add(this.author);
            this.Controls.Add(this.publisher);
            this.Controls.Add(this.Isno);
            this.Controls.Add(this.bookname);
            this.Controls.Add(this.bookid);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BOOK_NAME);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BOOK_ID);
            this.Name = "BooksUserControl";
            this.Size = new System.Drawing.Size(1132, 883);
            this.Load += new System.EventHandler(this.BooksUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BOOK_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label BOOK_NAME;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.TextBox bookid;
        private System.Windows.Forms.TextBox bookname;
        private System.Windows.Forms.TextBox Isno;
        private System.Windows.Forms.TextBox publisher;
        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label depid;
        private System.Windows.Forms.TextBox departmentid;
    }
}
