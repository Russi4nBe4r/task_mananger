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
    public partial class UserForm : Form
    {
        private string user_id;
        private string user_type = "2";

        public UserForm(string id = "0")
        {
            InitializeComponent();

            this.user_id = id;
        }

        private void manager_radio_CheckedChanged(object sender, EventArgs e)
        {
            this.user_type = "2";
        }

        private void client_radio_CheckedChanged(object sender, EventArgs e)
        {
            this.user_type = "3";
        }

        private void user_save_btn_Click(object sender, EventArgs e)
        {
            if (this.user_id == "0")
            {
                string sql_insert = String.Format("INSERT INTO users (username, password, type) VALUES ('{0}', '{1}', {2})", username.Text.ToString(), password.Text.ToString(), this.user_type);
                using (SqlConnection connection = new SqlConnection(WindowsFormsApp2.Properties.Settings.Default.course_dbConnectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(sql_insert, connection);
                    this.user_id = (string)command.ExecuteScalar();

                    MessageBox.Show("Добавлен новый пользователь");
                }
            }
            else
            {
                string sql_update = String.Format("UPDATE users SET username='{0}', password='{1}', type={2} WHERE user_id='{3}'", username.Text.ToString(), password.Text.ToString(), this.user_type, this.user_id);
                using (SqlConnection connection = new SqlConnection(WindowsFormsApp2.Properties.Settings.Default.course_dbConnectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(sql_update, connection);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Изменения сохранены успешно");
                }
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            if (this.user_id == "0")
            {
                manager_radio.Checked = true;
            }
            else
            {
                string sql = String.Format("SELECT * FROM users WHERE user_id={0}", this.user_id);

                using (SqlConnection connection = new SqlConnection(WindowsFormsApp2.Properties.Settings.Default.course_dbConnectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();

                        username.Text = reader["username"].ToString();
                        password.Text = reader["password"].ToString();

                        switch (reader["type"].ToString())
                        {
                            case "2":
                                this.user_type = "2";
                                manager_radio.Checked = true;
                                break;
                            case "3":
                                this.user_type = "3";
                                client_radio.Checked = true;
                                break;
                        }
                    }
                }
            }
        }
    }
}
