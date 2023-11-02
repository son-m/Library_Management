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
    public partial class DepartmentUserControl : UserControl
    {

        private static DepartmentUserControl _instance;
        public static DepartmentUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DepartmentUserControl();
                }
                return _instance;
            }
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\LibraryManagement\LibraryManagement\Database1.mdf;Integrated Security=True");

        public DepartmentUserControl()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowAllDepartment_SP", Con);
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

                dataGridView2.DataSource = DS.Tables[0];

                /*this.dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView2.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        private void Add_Department_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Departments_SP", Con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Department_ID", department_ID_box.Text);
            cmd.Parameters.AddWithValue("@Department_name", department_name_box.Text);
            cmd.Parameters.AddWithValue("@Rack_code", rack_code_box.Text);

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

        private void DepartmentUserControl_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }
    }
}
