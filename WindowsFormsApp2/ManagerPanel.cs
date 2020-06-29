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
    public partial class ManagerPanel : Form
    {
        public ManagerPanel()
        {
            InitializeComponent();
        }

        private void project_filter_btn_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM projects ";

            string filter = String.Format("WHERE created_by='{0}' ", GlobalProperties.user_id);

            if (project_title_box.Text != String.Empty)
            {
                filter += String.Format("AND title LIKE '%{0}%' ", project_title_box.Text.ToString());
            }

            if (project_client_box.Text != String.Empty)
            {
                filter += String.Format("AND client IN (SELECT user_id FROM users AS u WHERE u.username LIKE '%{0}%') ", project_client_box.Text.ToString());
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

            string filter = String.Format("WHERE created_by='{0}' ", GlobalProperties.user_id);

            if (task_title_box.Text != String.Empty)
            {
                filter += String.Format("AND title LIKE '%{0}%' ", task_title_box.Text.ToString());
            }

            if (task_project_box.Text != String.Empty)
            {
                filter += String.Format("AND project_id IN (SELECT project_id FROM projects AS p WHERE p.title LIKE '%{0}%') ", task_project_box.Text.ToString());
            }

            if (task_client_box.Text != String.Empty)
            {
                filter += String.Format("AND task_id IN (SELECT task_id FROM tasks AS t JOIN users AS u On t.client=u.user_id WHERE u.username LIKE '%{0}%') ", task_client_box.Text.ToString());
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

        private void ticket_filter_btn_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tickets ";

            string filter = String.Format("WHERE modered_by='{0}' ", GlobalProperties.user_id);

            if (ticket_title_box.Text != String.Empty)
            {
                filter += String.Format("AND title LIKE '%{0}%' ", ticket_title_box.Text.ToString());
            }

            if (ticket_client_box.Text != String.Empty)
            {
                filter += String.Format("AND created_by IN (SELECT user_id FROM users WHERE username LIKE '%{0}%') ", ticket_client_box.Text.ToString());
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

        private void mticket_filter_btn_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tickets ";

            string filter = String.Format("WHERE created_by='{0}' ", GlobalProperties.user_id);

            if (mticket_title_box.Text != String.Empty)
            {
                filter += String.Format("AND title LIKE '%{0}%' ", mticket_title_box.Text.ToString());
            }

            sql += filter;

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.course_dbConnectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                mticketGridView.DataSource = ds.Tables[0];
            }
        }

        private void mticket_grid_view_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Ticket ticket = new Ticket(mticketGridView.Rows[e.RowIndex].Cells[0].Value.ToString(), false);
            ticket.ShowDialog();
        }

        private void mticket_add_btn_Click(object sender, EventArgs e)
        {
            AddTicketForm addTicketForm = new AddTicketForm(true);
            addTicketForm.ShowDialog();
        }
    }
}
