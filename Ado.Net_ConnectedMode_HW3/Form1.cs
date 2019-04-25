using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ado.Net_ConnectedMode_HW3
{
    public partial class Form1 : Form
    {
        SqlConnectionStringBuilder SqlConnectionBuilder = new SqlConnectionStringBuilder();
        string user = "admin", password = "12345";

        public Form1()
        {
            InitializeComponent();

            
        }

        private void Authorization(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty & textBox2.Text != String.Empty)
            {
                user = textBox1.Text;
                password = textBox2.Text;
                SqlConnectionBuilder.DataSource= @"(LocalDb)\MSSQLLocalDB;";
                SqlConnectionBuilder.InitialCatalog= "bookshops";
                SqlConnectionBuilder.UserID = User;
                SqlConnectionBuilder.Password = Password;
                SqlConnection connectoin = new SqlConnection(SqlConnectionBuilder.ConnectionString);
                try
                {
                    connectoin.Open();
                    if(connectoin.State == ConnectionState.Open)
                        MessageBox.Show("You are champ!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connectoin?.Close();
                }
                
            }
        }
    }
}
