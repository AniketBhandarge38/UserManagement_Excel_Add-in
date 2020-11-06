using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoProject
{
    public partial class SearchUser : Form
    {
        string connectionstring = "Data Source=LAPTOP-M8OIGI02\\SQLEXPRESS;Initial Catalog=FinalDemo;Integrated Security=True";
        public SearchUser()
        {
            InitializeComponent();
        }

        private void SearchUser_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
       

        private void textenterfirstname_TextChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();


            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "spUSER_MANAGEMENT";
            command.Parameters.AddWithValue("@ActionType", "FetchRecord");
            command.Parameters.AddWithValue("@FirstName", textenterfirstname.Text.ToString());
            adapter = new SqlDataAdapter(command);
            adapter.Fill(ds);
            connection.Close();
            dataGriduserview.ReadOnly = true;
            dataGriduserview.DataSource = ds.Tables[0];

        }

        private void dataGriduserview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
