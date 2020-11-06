using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DemoProject
{
    public partial class userdataform : Form
    {
        string connectionstring = "Data Source=LAPTOP-M8OIGI02\\SQLEXPRESS;Initial Catalog=FinalDemo;Integrated Security=True";
        public userdataform()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            SqlCommand sqlCmd;
            Decimal DEC;
            Decimal.TryParse(textsal.Text, out DEC);
            float exp;
            float.TryParse(textexp.Text, out exp);

            Regex regex = new Regex("^[a-zA-Z]+$");
            bool hasOnlyAlpha = regex.IsMatch(textfirstname.Text);

            Regex regex2 = new Regex("^[a-zA-Z]+$");
            bool hasOnlyAlphalast = regex2.IsMatch(textlastname.Text);

            

            if (string.IsNullOrWhiteSpace(textuserid.Text))
            {
                MessageBox.Show("Enter User ID !!!");
                textuserid.Select();
            }
            else if (string.IsNullOrWhiteSpace(textfirstname.Text) )
            {
                MessageBox.Show("Enter First Name !!!");
                textfirstname.Select();
            }
            else if (!hasOnlyAlpha)
            {
                MessageBox.Show("Enter valid First Name !!!");
                textfirstname.Select();
            }
            else if (string.IsNullOrWhiteSpace(textlastname.Text))
            {
                MessageBox.Show("Enter Last Name !!!");
                textlastname.Select();
            }
            else if (!hasOnlyAlphalast)
            {
                MessageBox.Show("Enter valid last Name !!!");
                textfirstname.Select();
            }
            else if (string.IsNullOrWhiteSpace(textdomain.Text))
            {
                MessageBox.Show("Enter Domain !!!");
                textdomain.Select();
            }
            else if (string.IsNullOrWhiteSpace(textexp.Text))
            {
                MessageBox.Show("Enter Work Experience !!!");
                textexp.Select();
            }
            else if (DEC <9999)
            {
                MessageBox.Show("Enter valid Salary !!!");
                textsal.Select();
            }
            else if (exp < 1.0)
            {
                MessageBox.Show("Enter valid Experience !!!");
                textexp.Select();
            }
            else if (dateTimePickerdob.Value.Equals(value: null))
            {
                MessageBox.Show("Select Date of birth !!!");
                dateTimePickerdob.Select();
            }
            else
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    DataTable dtData = new DataTable();
                    sqlCmd = new SqlCommand("spUSER_MANAGEMENT", con);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@ActionType", "SaveData");
                   
                    sqlCmd.Parameters.AddWithValue("@UserID", int.Parse(textuserid.Text));
                    sqlCmd.Parameters.AddWithValue("@FirstName", textfirstname.Text.ToString());
                    sqlCmd.Parameters.AddWithValue("@LastName", textlastname.Text.ToString());
                    sqlCmd.Parameters.Add("@DateOfBirth", SqlDbType.Date).Value = dateTimePickerdob.Value.Date;
                    //sqlCmd.Parameters.AddWithValue("@DateOfBirth", dateTimePickerdob.Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@Domain", textdomain.Text.ToString());
                    sqlCmd.Parameters.AddWithValue("@Experience", float.Parse(textexp.Text));
                    sqlCmd.Parameters.AddWithValue("@Salary",  textsal.Text.ToString());

                    int numRes = sqlCmd.ExecuteNonQuery();
                    if (numRes > 0)
                    {
                        MessageBox.Show("Record Saved Successfully !!!");
                        
                    }
                    else
                        MessageBox.Show("Please Try Again !!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:- " + ex.Message);
                }
            }
        }

        private void textuserid_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textuserid.Text))
            {
                e.Cancel = true;
                textuserid.Focus();
                errorProviderApp.SetError(textuserid, "User ID should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(textuserid, "");
            }
        }

        private void textexp_Validating(object sender, CancelEventArgs e)
        {
            float exp;
            float.TryParse(textexp.Text,out exp);
            if (string.IsNullOrWhiteSpace(textexp.Text))
            {
                e.Cancel = true;
                textuserid.Focus();
                errorProviderApp.SetError(textexp, "Experience should not be left blank!");
            }
            else if(exp < 1.0)
            {
                e.Cancel = true;
                textuserid.Focus();
                errorProviderApp.SetError(textexp, "It should greater than 1.0  and less than 10.0 ");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(textexp, "");
            }
        }

        private void textsal_Validating(object sender, CancelEventArgs e)
        {
            Decimal DEC;
            Decimal.TryParse(textsal.Text, out DEC);
            if (string.IsNullOrWhiteSpace(textsal.Text))
            {
                e.Cancel = true;
                textsal.Focus();
                errorProviderApp.SetError(textsal, "Salary should not be left blank!");
            }
            else if (DEC < 9999)
            {
                e.Cancel = true;
                textsal.Focus();
                errorProviderApp.SetError(textsal, "Salary should be greater >= 10,000.00 !");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(textexp, "");
            }
        }

        private void textuserid_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            


            if (textuserid.Text != "")
            {

                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    using (SqlCommand cmd = new SqlCommand("spUSER_MANAGEMENT", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ActionType", "FetchData");
                        cmd.Parameters.AddWithValue("@UserID", textuserid.Text.ToString());

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();

                            da.Fill(dt);
                            if (dt.Rows.Count > 0)
                            {
                                Status.Text = "Exists";
                                Status.Visible = true;
                                textfirstname.Text = dt.Rows[0]["FirstName"].ToString();
                                textlastname.Text = dt.Rows[0]["LastName"].ToString();
                                dateTimePickerdob.Text = dt.Rows[0]["DateOfBirth"].ToString();
                                textdomain.Text = dt.Rows[0]["Domain"].ToString();
                                textexp.Text = dt.Rows[0]["Experience"].ToString();
                                textsal.Text = dt.Rows[0]["Salary"].ToString();
                            }
                            else
                            {
                                Status.Text = "New";
                                Status.Visible = true;
                                textfirstname.Text = string.Empty;
                                textlastname.Text = string.Empty;
                                dateTimePickerdob.Text = string.Empty;
                                textdomain.Text = string.Empty;
                                textexp.Text = string.Empty;
                                textsal.Text = string.Empty;
                            }
                        }
                        
                    }
                    con.Close();
                   
                    
                    

                   

                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:- " + ex.Message);
                }
            }
        }

        private void userdataform_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
