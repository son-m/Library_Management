namespace LibraryManagement
{
    partial class TransactionUserControl
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
            this.Enter_Borrower_ID = new System.Windows.Forms.Label();
            this.Book_ID = new System.Windows.Forms.Label();
            this.Book_ID_Box = new System.Windows.Forms.TextBox();
            this.Borrower_ID_Box = new System.Windows.Forms.TextBox();
            this.issuebook = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.search_borrower = new System.Windows.Forms.Button();
            this.clear_all = new System.Windows.Forms.Button();
            this.return_book = new System.Windows.Forms.Button();
            this.book_1 = new System.Windows.Forms.Label();
            this.Book1_label = new System.Windows.Forms.Label();
            this.book_2 = new System.Windows.Forms.Label();
            this.Book2_label = new System.Windows.Forms.Label();
            this.borrowedby = new System.Windows.Forms.Label();
            this.borrowed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Enter_Borrower_ID
            // 
            this.Enter_Borrower_ID.AutoSize = true;
            this.Enter_Borrower_ID.Location = new System.Drawing.Point(166, 168);
            this.Enter_Borrower_ID.Name = "Enter_Borrower_ID";
            this.Enter_Borrower_ID.Size = new System.Drawing.Size(139, 25);
            this.Enter_Borrower_ID.TabIndex = 0;
            this.Enter_Borrower_ID.Text = "Borrower\'s ID";
            // 
            // Book_ID
            // 
            this.Book_ID.AutoSize = true;
            this.Book_ID.Location = new System.Drawing.Point(166, 336);
            this.Book_ID.Name = "Book_ID";
            this.Book_ID.Size = new System.Drawing.Size(150, 25);
            this.Book_ID.TabIndex = 1;
            this.Book_ID.Text = "Enter Book_ID";
            // 
            // Book_ID_Box
            // 
            this.Book_ID_Box.Location = new System.Drawing.Point(404, 330);
            this.Book_ID_Box.Name = "Book_ID_Box";
            this.Book_ID_Box.Size = new System.Drawing.Size(100, 31);
            this.Book_ID_Box.TabIndex = 3;
            // 
            // Borrower_ID_Box
            // 
            this.Borrower_ID_Box.Location = new System.Drawing.Point(404, 168);
            this.Borrower_ID_Box.Name = "Borrower_ID_Box";
            this.Borrower_ID_Box.Size = new System.Drawing.Size(100, 31);
            this.Borrower_ID_Box.TabIndex = 4;
            this.Borrower_ID_Box.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // issuebook
            // 
            this.issuebook.Location = new System.Drawing.Point(204, 653);
            this.issuebook.Name = "issuebook";
            this.issuebook.Size = new System.Drawing.Size(204, 54);
            this.issuebook.TabIndex = 5;
            this.issuebook.Text = "Issue Book";
            this.issuebook.UseVisualStyleBackColor = true;
            this.issuebook.Click += new System.EventHandler(this.issuebook_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(449, 422);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(253, 54);
            this.button2.TabIndex = 7;
            this.button2.Text = "Search Book";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // search_borrower
            // 
            this.search_borrower.Location = new System.Drawing.Point(449, 243);
            this.search_borrower.Name = "search_borrower";
            this.search_borrower.Size = new System.Drawing.Size(253, 53);
            this.search_borrower.TabIndex = 9;
            this.search_borrower.Text = "Search Borrower";
            this.search_borrower.UseVisualStyleBackColor = true;
            this.search_borrower.Click += new System.EventHandler(this.search_borrower_Click);
            // 
            // clear_all
            // 
            this.clear_all.Location = new System.Drawing.Point(490, 526);
            this.clear_all.Name = "clear_all";
            this.clear_all.Size = new System.Drawing.Size(180, 55);
            this.clear_all.TabIndex = 11;
            this.clear_all.Text = "Clear All";
            this.clear_all.UseVisualStyleBackColor = true;
            this.clear_all.Click += new System.EventHandler(this.button4_Click);
            // 
            // return_book
            // 
            this.return_book.Location = new System.Drawing.Point(745, 653);
            this.return_book.Name = "return_book";
            this.return_book.Size = new System.Drawing.Size(193, 54);
            this.return_book.TabIndex = 13;
            this.return_book.Text = "Return Book";
            this.return_book.UseVisualStyleBackColor = true;
            this.return_book.Click += new System.EventHandler(this.return_book_Click);
            // 
            // book_1
            // 
            this.book_1.AutoSize = true;
            this.book_1.Location = new System.Drawing.Point(729, 87);
            this.book_1.Name = "book_1";
            this.book_1.Size = new System.Drawing.Size(79, 25);
            this.book_1.TabIndex = 14;
            this.book_1.Text = "Book 1";
            // 
            // Book1_label
            // 
            this.Book1_label.AutoSize = true;
            this.Book1_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Book1_label.Location = new System.Drawing.Point(949, 87);
            this.Book1_label.Name = "Book1_label";
            this.Book1_label.Size = new System.Drawing.Size(132, 27);
            this.Book1_label.TabIndex = 16;
            this.Book1_label.Text = "borrowed by";
            // 
            // book_2
            // 
            this.book_2.AutoSize = true;
            this.book_2.Location = new System.Drawing.Point(729, 168);
            this.book_2.Name = "book_2";
            this.book_2.Size = new System.Drawing.Size(79, 25);
            this.book_2.TabIndex = 18;
            this.book_2.Text = "Book 2";
            // 
            // Book2_label
            // 
            this.Book2_label.AutoSize = true;
            this.Book2_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Book2_label.Location = new System.Drawing.Point(949, 166);
            this.Book2_label.Name = "Book2_label";
            this.Book2_label.Size = new System.Drawing.Size(132, 27);
            this.Book2_label.TabIndex = 20;
            this.Book2_label.Text = "borrowed by";
            // 
            // borrowedby
            // 
            this.borrowedby.AutoSize = true;
            this.borrowedby.Location = new System.Drawing.Point(795, 350);
            this.borrowedby.Name = "borrowedby";
            this.borrowedby.Size = new System.Drawing.Size(134, 25);
            this.borrowedby.TabIndex = 21;
            this.borrowedby.Text = "Borrowed By";
            this.borrowedby.Click += new System.EventHandler(this.label1_Click);
            // 
            // borrowed
            // 
            this.borrowed.AutoSize = true;
            this.borrowed.Location = new System.Drawing.Point(975, 350);
            this.borrowed.Name = "borrowed";
            this.borrowed.Size = new System.Drawing.Size(103, 25);
            this.borrowed.TabIndex = 23;
            this.borrowed.Text = "Borrowed";
            // 
            // TransactionUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.borrowed);
            this.Controls.Add(this.borrowedby);
            this.Controls.Add(this.Book2_label);
            this.Controls.Add(this.book_2);
            this.Controls.Add(this.Book1_label);
            this.Controls.Add(this.book_1);
            this.Controls.Add(this.return_book);
            this.Controls.Add(this.clear_all);
            this.Controls.Add(this.search_borrower);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.issuebook);
            this.Controls.Add(this.Borrower_ID_Box);
            this.Controls.Add(this.Book_ID_Box);
            this.Controls.Add(this.Book_ID);
            this.Controls.Add(this.Enter_Borrower_ID);
            this.Name = "TransactionUserControl";
            this.Size = new System.Drawing.Size(1132, 883);
            this.Load += new System.EventHandler(this.TransactionUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Enter_Borrower_ID;
        private System.Windows.Forms.Label Book_ID;
        private System.Windows.Forms.TextBox Book_ID_Box;
        private System.Windows.Forms.TextBox Borrower_ID_Box;
        private System.Windows.Forms.Button issuebook;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button search_borrower;
        private System.Windows.Forms.Button clear_all;
        private System.Windows.Forms.Button return_book;
        private System.Windows.Forms.Label book_1;
        private System.Windows.Forms.Label Book1_label;
        private System.Windows.Forms.Label book_2;
        private System.Windows.Forms.Label Book2_label;
        private System.Windows.Forms.Label borrowedby;
        private System.Windows.Forms.Label borrowed;
    }
}
