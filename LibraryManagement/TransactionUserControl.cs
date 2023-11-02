using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace LibraryManagement
{
    public partial class TransactionUserControl : UserControl
    {
        private static TransactionUserControl _instance;
        public static TransactionUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TransactionUserControl();
                }
                return _instance;
            }
        }
        public TransactionUserControl()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public string Book1, Book2, Borrower;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\LibraryManagement\LibraryManagement\Database1.mdf;Integrated Security=True");
        public SqlCommand cmd;
        public SqlDataReader dr;
        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            String syntax = "SELECT Borrower_ID FROM Books WHERE Book_ID ='" + Book_ID_Box.Text + "'";
            cmd = new SqlCommand(syntax, Con);
            dr = cmd.ExecuteReader();
            dr.Read();

            Book1_label.Text = Book1 = dr[0].ToString();
            Con.Close();


            Con.Open();
            syntax = "SELECT Book2_ID FROM Borrow_Table WHERE Borrow_ID ='" + Borrower_ID_Box.Text + "'";
            cmd = new SqlCommand(syntax, Con);
            dr = cmd.ExecuteReader();
            dr.Read();

            borrowed.Text = Borrower = dr[0].ToString();
            Con.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TransactionUserControl_Load(object sender, EventArgs e)
        {

        }

        private void issuebook_Click(object sender, EventArgs e)
        {
            button2.PerformClick();
            if(Borrower != "") // someone has borrowed the book
            {
                MessageBox.Show("Book is already Borrowed by some other Borrower with Borrower id : \n" + Borrower);
                return;
            }

            search_borrower.PerformClick();
            if(Book1 != "" && Book2 != "") // already issued two books
            {
                MessageBox.Show("Borrower has already borrowed maximum number of books");
                return;
            }

            // all is well, book can issued now

            // first set the value of Book1 or Book2 as the Book_ID of the book being issued
            try
            {
                if(Book1 != "")
                {
                    cmd = new SqlCommand("Transact_update_Book1_SP", Con); 
                }
                else
                {
                    cmd = new SqlCommand("Transact_update_Book2_SP", Con);

                }
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Book_ID", Book_ID_Box.Text);
                cmd.Parameters.AddWithValue("Borrower_ID", Borrower_ID_Box.Text);

                Con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("        <<<INVALID SQL OPERATION>>>: \n" + ex);
                }
                Con.Close();

            }
            catch(Exception ex )
            {
                MessageBox.Show("" + ex);
            }


            // now we will also update the borrower's ID in the books table
            cmd = new SqlCommand("Transact_update_Borrowers_SP", Con);
            cmd.CommandType= CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Book_ID", Book_ID_Box.Text);
            cmd.Parameters.AddWithValue("Borrower_ID", Borrower_ID_Box.Text);

            Con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("        <<<INVALID SQL OPERATION>>>: \n" + ex);
            }
            Con.Close();

            /* this completes the entire transaction. so now to update the values, we perform
             the click event on both the buttons so that the user can see the chnages made */

            button2.PerformClick();
            search_borrower.PerformClick();
            MessageBox.Show("Successfully Issued");
        }

        private void return_book_Click(object sender, EventArgs e)
        {
            button2.PerformClick();
            search_borrower.PerformClick();
            if (Book_ID_Box.Text != Book1 && Book_ID_Box.Text != Book2)    
            {
                MessageBox.Show("Entered Book is not borrowed by entered User");
                return;
            }

            try
            {
                if(Book1 == Book_ID_Box.Text)
                {
                    cmd = new SqlCommand("Transact_update_Book1_SP", Con); 
                }
                else
                {
                    cmd = new SqlCommand("Transact_update_Book2_SP", Con);

                }
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Book_ID", "NULL");
                cmd.Parameters.AddWithValue("Borrower_ID", Borrower_ID_Box.Text);

                Con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("        <<<INVALID SQL OPERATION>>>: \n" + ex);
                }
                Con.Close();

            }
            catch(Exception ex )
            {
                MessageBox.Show("" + ex);
            }


            // now we will also update the borrower's ID in the books table
            cmd = new SqlCommand("Transact_update_Borrowers_SP", Con);
            cmd.CommandType= CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Book_ID", Book_ID_Box.Text);
            cmd.Parameters.AddWithValue("Borrower_ID", "NULL");

            Con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("        <<<INVALID SQL OPERATION>>>: \n" + ex);
            }
            Con.Close();

            /* this completes the entire transaction. so now to update the values, we perform
             the click event on both the buttons so that the user can see the chnages made */

            button2.PerformClick();
            search_borrower.PerformClick();
            MessageBox.Show("Successfully Returned");
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void search_borrower_Click(object sender, EventArgs e)
        {
            Con.Open();
            String syntax = "SELECT Book1_ID FROM Borrow_Table WHERE Borrow_ID ='" + Borrower_ID_Box.Text + "'";
            cmd = new SqlCommand(syntax, Con);
            dr = cmd.ExecuteReader();
            dr.Read();

            Book1_label.Text = Book1 = dr[0].ToString();
            Con.Close();


            Con.Open();
            syntax = "SELECT Book2_ID FROM Borrow_Table WHERE Borrow_ID ='" + Borrower_ID_Box.Text + "'";
            cmd = new SqlCommand(syntax, Con);
            dr = cmd.ExecuteReader();
            dr.Read();

            Book1_label.Text = Book2 = dr[0].ToString();
            Con.Close();

        }
    }
}
