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

namespace WindowsFormsApp2
{
    public partial class AuthForm : Form
    {
        private string user_type;

        public AuthForm(string user_type)
        {
            InitializeComponent();

            this.user_type = user_type;
        }

        private void auth_btn_Click(object sender, EventArgs e)
        {
            string username = username_box.Text.ToString();
            string password = password_box.Text.ToString();

            string sql = String.Format("SELECT user_id FROM users WHERE username='{0}' AND password='{1}' AND type={2}", username, password, this.user_type);

            using (SqlConnection connection = new SqlConnection(WindowsFormsApp2.Properties.Settings.Default.course_dbConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    GlobalProperties.user_id = reader["user_id"].ToString();
                    GlobalProperties.userType = this.user_type;

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
            }
        }
    }
}
