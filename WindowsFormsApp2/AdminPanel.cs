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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void project_filter_btn_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM projects ";

            string filter = "WHERE ";

            if (project_title_box.Text != String.Empty)
            {
                if (filter != "WHERE ")
                {
                    filter += "AND ";
                }

                filter += String.Format("title LIKE '%{0}%' ", project_title_box.Text.ToString());
            }

            if (project_manager_box.Text != String.Empty)
            {
                if (filter != "WHERE ")
                {
                    filter += "AND ";
                }

                filter += String.Format("created_by IN (SELECT user_id FROM users WHERE username LIKE '%{0}%' AND type=2) ", project_manager_box.Text.ToString());
            }

            if (project_client_box.Text != String.Empty)
            {
                if (filter != "WHERE ")
                {
                    filter += "AND ";
                }

                filter += String.Format("client IN (SELECT user_id FROM users WHERE username LIKE '%{0}%' AND type=3) ", project_client_box.Text.ToString());
            }

            if (filter != "WHERE ")
            {
                sql += filter;
            }

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.course_dbConnectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                projectGridView.DataSource = ds.Tables[0];
            }
        }

        private void task_filter_btn_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tasks ";

            string filter = "WHERE ";

            if (task_title_box.Text != String.Empty)
            {
                if (filter != "WHERE ")
                {
                    filter += "AND ";
                }

                filter += String.Format("title LIKE '%{0}%' ", task_title_box.Text.ToString());
            }

            if (task_manager_box.Text != String.Empty)
            {
                if (filter != "WHERE ")
                {
                    filter += "AND ";
                }

                filter += String.Format("created_by IN (SELECT user_id FROM users WHERE username LIKE '%{0}%' AND type=2) ", task_manager_box.Text.ToString());
            }

            if (task_client_box.Text != String.Empty)
            {
                if (filter != "WHERE ")
                {
                    filter += "AND ";
                }

                filter += String.Format("client IN (SELECT user_id FROM users WHERE username LIKE '%{0}%' AND type=3) ", task_client_box.Text.ToString());
            }

            if (filter != "WHERE ")
            {
                sql += filter;
            }

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.course_dbConnectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                taskGridView.DataSource = ds.Tables[0];
            }
        }

        private void user_filter_btn_Click(object sender, EventArgs e)
        {
            string sql_manager = "SELECT * FROM users WHERE type=2";

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.course_dbConnectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql_manager, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                managerGridView.DataSource = ds.Tables[0];
            }

            string sql_client = "SELECT * FROM users WHERE type=3";

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.course_dbConnectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql_client, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                clientGridView.DataSource = ds.Tables[0];
            }
        }

        private void user_add_btn_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.ShowDialog();
        }

        private void managerGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UserForm userForm = new UserForm(managerGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            userForm.ShowDialog();
        }

        private void clientGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UserForm userForm = new UserForm(clientGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            userForm.ShowDialog();
        }

        private void report_project_btn_Click(object sender, EventArgs e)
        {
            string sql_manager = "SELECT s.title, COUNT(p.project_id) FROM projects AS p JOIN statuses AS s ON p.status=s.status_id GROUP BY s.title";

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.course_dbConnectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql_manager, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                reportGridView.DataSource = ds.Tables[0];

                connection.Close();
            }
        }

        private void report_task_btn_Click(object sender, EventArgs e)
        {
            string sql_manager = "SELECT s.title, COUNT(t.task_id) FROM tasks AS t JOIN statuses AS s ON t.status=s.status_id GROUP BY s.title";

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.course_dbConnectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql_manager, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                reportGridView.DataSource = ds.Tables[0];

                connection.Close();
            }
        }

        private void report_manager_btn_Click(object sender, EventArgs e)
        {
            string sql_manager = "SELECT u.username, COUNT(p.project_id) AS projects, COUNT(t.task_id) AS tasks FROM users AS u JOIN tasks AS t ON t.created_by=u.user_id JOIN projects AS p ON p.created_by=u.user_id WHERE u.type=2 GROUP BY u.username";

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.course_dbConnectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql_manager, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                reportGridView.DataSource = ds.Tables[0];

                connection.Close();
            }
        }

        private void report_ticket_btn_Click(object sender, EventArgs e)
        {
            string sql_manager = "SELECT u.username, COUNT(t.ticket_id) AS tickets FROM users AS u JOIN tickets AS t ON t.created_by=u.user_id GROUP BY u.username";

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.course_dbConnectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql_manager, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                reportGridView.DataSource = ds.Tables[0];

                connection.Close();
            }
        }

        private void ticket_filter_btn_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tickets ";

            string filter = String.Format("WHERE modered_by={0} ", GlobalProperties.user_id);

            if (ticket_title_box.Text != String.Empty)
            {
                filter += String.Format("AND title LIKE '%{0}%' ", ticket_title_box.Text.ToString());
            }

            if (ticket_manager_box.Text != String.Empty)
            {
                filter += String.Format("AND created_by IN (SELECT user_id FROM users WHERE username LIKE '%{0}%' AND type=2) ", ticket_manager_box.Text.ToString());
            }

            sql += filter;

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.course_dbConnectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                ticketGridView.DataSource = ds.Tables[0];
            }
        }

        private void ticketGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Ticket ticket = new Ticket(ticketGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            ticket.ShowDialog();
        }
    }
}
