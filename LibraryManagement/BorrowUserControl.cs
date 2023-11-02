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
using System.Net;
using System.Security.Policy;

namespace LibraryManagement
{
    public partial class BorrowUserControl : UserControl
    {
        private static BorrowUserControl _instance;
        public static BorrowUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BorrowUserControl();
                }
                return _instance;
            }
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\LibraryManagement\LibraryManagement\Database1.mdf;Integrated Security=True");
        public BorrowUserControl()
        {
            InitializeComponent();
        }

        public void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowAllUsers_SP", Con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                Con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("       <<<INVALID SQL OPERATION>>>:  \n" + ex);
                }
                Con.Close();

                dataGridView3.DataSource = DS.Tables[0];

                /*this.dataGridView3.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView3.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView3.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView3.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView3.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView3.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView3.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView3.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void BorrowUserControl_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }

        private void register_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UsersAdd_SP", Con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Borrow_ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Address", textBox3.Text);
            cmd.Parameters.AddWithValue("@Contact_number", textBox4.Text);

            Con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("           <<<INVALID SQL OPERATION>>>:  \n" + ex);
            }
            Con.Close();
            refresh_DataGridView();
        }

        private void delete_user_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UserDelete_SP", Con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Borrow_ID", textBox1.Text);

                Con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("           <<<INVALID SQL OPERATION>>>:  \n" + ex);
                }
                Con.Close();

                refresh_DataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
    }
}
