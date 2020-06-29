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
    public partial class AddTicketForm : Form
    {
        private Dictionary<int, string> projects;
        private Dictionary<int, string> managers;
        private string selectedProject = "0";
        private string selectedManager = "0";
        private bool manager;

        public AddTicketForm(bool manager = false)
        {
            InitializeComponent();

            this.projects = new Dictionary<int, string>();
            this.managers = new Dictionary<int, string>();
            this.manager = manager;
        }

        private void ticket_save_btn_Click(object sender, EventArgs e)
        {
            string title = ticket_title_box.Text.ToString();
            string description = ticket_description_box.Text.ToString();
            string project = (this.selectedProject == "0") ? "NULL": this.selectedProject;
            string modered_by = selectedManager;

            if (!this.manager)
            {
                if (modered_by == "0")
                {
                    string sql_manager = "SELECT TOP 1 user_id FROM (SELECT u.user_id, COUNT(t.ticket_id) AS tickets FROM users AS u LEFT JOIN tickets AS t ON t.modered_by=u.user_id WHERE u.type=2 GROUP BY u.user_id) AS t WHERE tickets IN (SELECT MIN(tickets) AS tickets FROM (SELECT u.user_id, COUNT(t.ticket_id) AS tickets FROM users AS u LEFT JOIN tickets AS t ON t.modered_by=u.user_id WHERE u.type=2 GROUP BY u.user_id) AS tickets)";

                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.course_dbConnectionString))
                    {
                        connection.Open();

                        SqlCommand command = new SqlCommand(sql_manager, connection);
                        SqlDataReader reader = command.ExecuteReader();

                        reader.Read();

                        modered_by = reader["user_id"].ToString();

                        connection.Close();
                    }
                }
            }
            else
            {
                modered_by = "1";
            }

            string sql = String.Format("INSERT INTO tickets (title, description, created_by, status, project, modered_by) VALUES ('{0}', '{1}', {2}, {3}, {4}, {5})", title, description, GlobalProperties.user_id, 1, project, modered_by);

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.course_dbConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Новый тикет добавлен");
                this.Close();
            }
        }

        private void AddTicketForm_Load(object sender, EventArgs e)
        {
            string sql = String.Format("SELECT * FROM projects WHERE client='{0}' ", GlobalProperties.user_id);

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.course_dbConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    int index = 1;
                    while (reader.Read())
                    {
                        ticket_project_box.Items.Add(reader["title"].ToString());
                        this.projects.Add(index, reader["project_id"].ToString());
                        this.managers.Add(index, reader["created_by"].ToString());

                        index++;
                    }
                }
            }

            if (this.manager)
            {
                ticket_project_box.Visible = false;
            }
        }

        private void ticket_project_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ticket_project_box.SelectedIndex == 0)
            {
                selectedProject = "0";
                selectedManager = "0";
            }
            else
            {
                selectedProject = projects[ticket_project_box.SelectedIndex];
                selectedManager = managers[ticket_project_box.SelectedIndex];
            }
        }
    }
}
