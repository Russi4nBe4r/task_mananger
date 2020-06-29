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
    public partial class AddTaskForm : Form
    {
        private string client_id;
        private string project_id;

        public AddTaskForm(string client_id, string project_id)
        {
            InitializeComponent();

            this.client_id = client_id;
            this.project_id = project_id;
        }

        private void task_save_btn_Click(object sender, EventArgs e)
        {
            string title = task_title_box.Text.ToString();
            string description = task_description_box.Text.ToString();
            string date = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd HH:mm:ss");

            string sql = String.Format("INSERT INTO tasks (title, description, created_by, created_at, deadline, status, client, project_id) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', 1, '{5}', '{6}')", title, description, GlobalProperties.user_id, DateTime.Now.Date.ToString("yyyy-MM-dd HH:mm:ss"), date, this.client_id, this.project_id);

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.course_dbConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Новая задача добавлена");
                this.Close();
            }
        }
    }
}
