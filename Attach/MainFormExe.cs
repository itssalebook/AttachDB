using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

 namespace SalePoint
{
     public partial class MainFormExe : Form
     {
         public MainFormExe()
         {
            InitializeComponent();
         }

        string connectionString;
        SqlConnection con;
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (CHK.Checked == true)
                {
                     connectionString = " Data Source=" + ServerNameTextBox.Text + ";Initial Catalog=" + DatabaseComboBox.Text + ";Integrated Security =true;";
                }
                else
                {
                    connectionString = "Data Source=" + ServerNameTextBox.Text + ";Initial Catalog=" + DatabaseComboBox.Text + ";User ID=" + UserNameTextBox.Text + ";Password=" + PasswordTextBox.Text + ";";//Network Library=DBMSSOCN";
                }
                con = new SqlConnection(connectionString);



                SqlCommand cmd = new SqlCommand("SP_Databases", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                DatabaseComboBox.Items.Clear();

                while (reader.Read())
                {
                    DatabaseComboBox.Items.Add(reader[0]);
                   
                }
                reader.Close();
                con.Close();
                MessageBox.Show("Connected", "SQL");
               // con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {


               

                if (CHK.Checked == true)
                {
                    connectionString = " Data Source=" + ServerNameTextBox.Text + ";Initial Catalog=" + DatabaseComboBox.Text + ";Integrated Security =true;";
                }
                else
                {
                    connectionString = "Data Source=" + ServerNameTextBox.Text + ";Initial Catalog=" + DatabaseComboBox.Text + ";User ID=" + UserNameTextBox.Text + ";Password=" + PasswordTextBox.Text + ";";//Network Library=DBMSSOCN";
                }




                using (con = new SqlConnection(connectionString))
                {
                    textBox2.Visible = false;
                    textBox2.Text = "";
                    var fileContent = textBox1.Text;
                    var sqlqueries = fileContent.Split(new[] { "GO" }, StringSplitOptions.RemoveEmptyEntries);
                    con.Open();

                    //for ( var i = 0; i < sqlqueries.Length; i++)
                    //{
                    //    SqlCommand cmd = new SqlCommand(sqlqueries[i], con);
                    //    cmd.ExecuteNonQuery();
                    //}

                    foreach (var query in sqlqueries)
                    {
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                    }



                    MessageBox.Show(sqlqueries.Length + " Statements Executed Successfully", "Message");
                }
            }
            catch (Exception ex)
            {
                textBox2.Visible = true;
                textBox2.Text = textBox2.Text + ex.Message;
             }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            textBox2.Visible = false;
        }
    }
}
