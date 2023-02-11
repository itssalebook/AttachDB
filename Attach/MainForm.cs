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
using SalePoint;
namespace MSSoftAttach
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        string connectionString;
        SqlConnection con;

        private void TxtConnect_Click(object sender, EventArgs e)
        {
            connectionString = "Data Source=.\\SQLEXPRESS; Integrated Security =true";

            con = new SqlConnection(connectionString);
            con.Open();
            MessageBox.Show("Connect Successfully", "Message");
        }

        private void FindDB_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFile = new OpenFileDialog();
            try
            {
                OpenFile.FileName = "";
                OpenFile.Title = "Database:";
                OpenFile.InitialDirectory = Application.StartupPath;
                OpenFile.Filter = "Database:(*.mdf)|*.mdf";

                DialogResult res = OpenFile.ShowDialog();
                if (res == DialogResult.OK)
                {
                    TxtMDFFile.Text = OpenFile.FileName;
                    TxtLDFFile.Text = OpenFile.FileName.Substring(0, OpenFile.FileName.Length -4) + "_log.ldf";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error...");
            }
        }

        private void TxtAttach_Click(object sender, EventArgs e)
        {
            connectionString = "Data Source=.\\SQLEXPRESS; Integrated Security =true";
            
            
            con = new SqlConnection(connectionString);

            string sqlquery = "EXEC sp_attach_db '" + TxtDBName.Text + "','" + TxtMDFFile.Text + "','" + TxtLDFFile.Text + "'";
   

            SqlCommand cmd = new SqlCommand(sqlquery, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
           
            MessageBox.Show("The File Attached Successfully", "Message");
            con.Close();
        }

        private void TxtDeAttach_Click(object sender, EventArgs e)
        {
            connectionString = "Data Source=.\\SQLEXPRESS; Integrated Security =true";

            con = new SqlConnection(connectionString);

            string sqlquery = "EXEC sp_detach_db '" + TxtDBName.Text + "'";
          

            SqlCommand cmd = new SqlCommand(sqlquery, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
              MessageBox.Show("The File Detached Successfully","Message");
              con.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MainFormExe ex = new MainFormExe();
            ex.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
