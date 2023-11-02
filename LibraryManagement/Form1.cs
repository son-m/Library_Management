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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\""+ "|DataDirectory|\\Database1.mdf\";Integrated Security=True");
        SqlCommand cmd; 
        SqlDataReader dr;

        private String getUserName()
        {
            // to fetch data from the database
            con.Open();
            String syntax = "SELECT Value FROM SystemTable where Property = 'Username'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp = dr[0].ToString();
            con.Close();
            return temp;
        }

        private String getPassWord()
        {
            // to fetch data from the database
            con.Open();
            String syntax = "SELECT Value FROM SystemTable where Property = 'Password'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp = dr[0].ToString();
            con.Close();
            return temp;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            String Uname = getUserName(), Upass = getPassWord(), name, pass;
            name = textBox1.Text;
            pass = textBox2.Text;

            if(name.Equals(Uname) && pass.Equals(Upass))
            {
                //login
                label4.Hide();
                //MessageBox.Show("Log In Success");
                AppBody obj = new AppBody();
                this.Hide();
                obj.Show();
            }
            else
            {
                //dont login
                label4.Show();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
