using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void admin_btn_Click(object sender, EventArgs e)
        {
            OpenPanel("1");
        }

        private void manager_btn_Click(object sender, EventArgs e)
        {
            OpenPanel("2");
        }

        private void client_btn_Click(object sender, EventArgs e)
        {
            OpenPanel("3");
        }

        private void OpenPanel(string type)
        {
            AuthForm authForm = new AuthForm(type);
            authForm.ShowDialog();

            switch (GlobalProperties.user_id)
            {
                case "1":
                    AdminPanel adminPanel = new AdminPanel();
                    adminPanel.ShowDialog();
                    break;
                case "2":
                    ManagerPanel managerPanel = new ManagerPanel();
                    managerPanel.ShowDialog();
                    break;
                case "3":
                    ClientPanel clientPanel = new ClientPanel();
                    clientPanel.ShowDialog();
                    break;
            }
        }
    }
}
