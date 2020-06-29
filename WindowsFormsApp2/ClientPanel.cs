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
    public partial class ClientPanel : Form
    {
        public ClientPanel()
        {
            InitializeComponent();
        }

        private void project_filter_btn_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM projects ";

            string filter = String.Format("WHERE client='{0}' ", GlobalProperties.user_id);

            if (project_title_box.Text != String.Empty)
            {
                filter += String.Format("AND title LIKE '%{0}%' ", project_title_box.Text.ToString());
            }

            sql += filter;

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

            string filter = String.Format("WHERE client='{0}' ", GlobalProperties.user_id);

            if (task_title_box.Text != String.Empty)
            {
                filter += String.Format("AND title LIKE '%{0}%' ", task_title_box.Text.ToString());
            }

            if (task_project_box.Text != String.Empty)
            {
                filter += String.Format("AND project_id IN (SELECT project_id FROM projects WHERE title LIKE '%{0}%') ", task_project_box.Text.ToString());
            }

            sql += filter;

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.course_dbConnectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                taskGridView.DataSource = ds.Tables[0];
            }
        }

        private void ticket_add_btn_Click(object sender, EventArgs e)
        {
            AddTicketForm addTicketForm = new AddTicketForm();
            addTicketForm.ShowDialog();
        }

        private void ticket_filter_btn_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tickets ";

            string filter = String.Format("WHERE created_by='{0}'", GlobalProperties.user_id);

            if (task_title_box.Text != String.Empty)
            {
                filter += String.Format("AND title LIKE '%{0}%' ", task_title_box.Text.ToString());
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

        private void taskGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Task task = new Task(taskGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            task.ShowDialog();
        }

        private void report_project_btn_Click(object sender, EventArgs e)
        {
            string sql = "SELECT s.title, COUNT(p.project_id) AS projects FROM projects AS p JOIN project_statuses AS s ON p.status=s.status_id ";

            string filter = String.Format("WHERE p.client='{0}' ", GlobalProperties.user_id);

            sql += filter;

            sql += "GROUP BY s.title";

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.course_dbConnectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                reportGridView.DataSource = ds.Tables[0];
            }
        }

        private void report_task_btn_Click(object sender, EventArgs e)
        {
            string sql = "SELECT s.title, COUNT(t.task_id) AS tasks FROM tasks AS t JOIN task_statuses AS s ON t.status=s.status_id ";

            string filter = String.Format("WHERE t.client='{0}' ", GlobalProperties.user_id);

            sql += filter;

            sql += "GROUP BY s.title";

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.course_dbConnectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                reportGridView.DataSource = ds.Tables[0];
            }
        }

        private void report_ticket_btn_Click(object sender, EventArgs e)
        {
            string sql = "SELECT s.title, COUNT(t.ticket_id) AS tickets FROM tickets AS t JOIN ticket_statuses AS s ON t.status=s.status_id ";

            string filter = String.Format("WHERE t.created_by='{0}' ", GlobalProperties.user_id);

            sql += filter;

            sql += "GROUP BY s.title";

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.course_dbConnectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                reportGridView.DataSource = ds.Tables[0];
            }
        }
    }
}
