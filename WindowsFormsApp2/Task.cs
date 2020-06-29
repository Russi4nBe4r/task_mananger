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
    public partial class Task : Form
    {
        private string task_id;

        public Task(string task_id)
        {
            InitializeComponent();

            this.task_id = task_id;
        }

        private void Task_Load(object sender, EventArgs e)
        {
            string sql = String.Format("SELECT * FROM tasks WHERE task_id='{0}'", this.task_id);

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.course_dbConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    task_title_box.Text = reader["title"].ToString();
                    task_description_box.Text = reader["description"].ToString();

                    if (reader["status"].ToString() == "3")
                    {
                        task_answer_box.Enabled = false;
                        task_answer_btn.Enabled = false;
                    }
                }
            }

            sql = String.Format("SELECT * FROM task_comments WHERE task_id='{0}'", this.task_id);

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.course_dbConnectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                commentGridView.DataSource = ds.Tables[0];
            }
        }

        private void answer_update_btn_Click(object sender, EventArgs e)
        {
            string sql = String.Format("SELECT * FROM task_comments WHERE task_id='{0}'", this.task_id);

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.course_dbConnectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                commentGridView.DataSource = ds.Tables[0];
            }
        }

        private void task_answer_btn_Click(object sender, EventArgs e)
        {
            if (task_answer_box.Text != String.Empty)
            {
                string message = task_answer_box.Text.ToString();
                string date = DateTime.Now.Date.ToString("yyyy-MM-dd HH:mm:ss");

                string sql = String.Format("INSERT INTO task_comments (task_id, message, created_by, created_at) VALUES('{0}', '{1}', {2}, '{3}')", this.task_id, message, GlobalProperties.user_id, date);

                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.course_dbConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();

                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Вы не ввели сообщение");
            }
        }
    }
}
