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
    public partial class Ticket : Form
    {
        private string ticket_id;
        private bool allow;
        private string client_id;
        private string project_id;

        public Ticket(string ticket_id, bool allow = true)
        {
            InitializeComponent();

            this.ticket_id = ticket_id;
            this.allow = allow;

            this.client_id = "0";
            this.project_id = "0";
        }

        private void answer_update_btn_Click(object sender, EventArgs e)
        {
            string sql = String.Format("SELECT * FROM ticket_comments WHERE ticket_id='{0}'", this.ticket_id);

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.course_dbConnectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                commentGridView.DataSource = ds.Tables[0];
            }
        }

        private void ticket_answer_btn_Click(object sender, EventArgs e)
        {
            if (ticket_answer_box.Text != String.Empty)
            {
                string message = ticket_answer_box.Text.ToString();
                string date = DateTime.Now.Date.ToString("yyyy-MM-dd HH:mm:ss");

                string sql = String.Format("INSERT INTO ticket_comments (ticket_id, message, created_by, created_at) VALUES('{0}', '{1}', {2}, '{3}')", this.ticket_id, message, GlobalProperties.user_id, date);

                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.course_dbConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();

                    connection.Close();
                }

                sql = String.Format("UPDATE tickets SET status=2 WHERE ticket_id='{0}'", this.ticket_id);

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

        private void ticket_close_btn_Click(object sender, EventArgs e)
        {
            ticket_answer_box.Enabled = false;
            ticket_answer_btn.Enabled = false;
            ticket_close_btn.Enabled = false;

            string sql = String.Format("UPDATE tickets SET status=3 WHERE ticket_id='{0}'", this.ticket_id);

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.course_dbConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            string sql = String.Format("SELECT t.project, t.created_by, t.status, t.title, t.description, u.username FROM tickets AS t JOIN users AS u ON u.user_id=t.created_by WHERE ticket_id='{0}'", this.ticket_id);

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.course_dbConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    ticket_title_box.Text = reader["title"].ToString();
                    ticket_description_box.Text = reader["description"].ToString();
                    ticket_user_box.Text = reader["username"].ToString();

                    if (reader["status"].ToString() == "3")
                    {
                        ticket_answer_box.Enabled = false;
                        ticket_answer_btn.Enabled = false;
                        ticket_close_btn.Enabled = false;
                    }

                    if (reader["project"].ToString() == String.Empty)
                    {
                        ticket_add_task_btn.Enabled = false;
                    }
                    else
                    {
                        ticket_add_project_btn.Enabled = false;
                        this.project_id = reader["project"].ToString();
                    }

                    this.client_id = reader["created_by"].ToString();
                }
            }

            sql = String.Format("SELECT * FROM ticket_comments WHERE ticket_id='{0}'", this.ticket_id);

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.course_dbConnectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                commentGridView.DataSource = ds.Tables[0];
            }

            if (GlobalProperties.userType != "2" || !this.allow)
            {
                ticket_add_project_btn.Visible = false;
                ticket_add_task_btn.Visible = false;
            }
        }

        private void ticket_add_project_btn_Click(object sender, EventArgs e)
        {
            AddProjectForm addProjectForm = new AddProjectForm(this.client_id);
            addProjectForm.ShowDialog();
        }

        private void ticket_add_task_btn_Click(object sender, EventArgs e)
        {
            AddTaskForm addTaskForm = new AddTaskForm(this.client_id, this.project_id);
            addTaskForm.ShowDialog();
        }
    }
}
