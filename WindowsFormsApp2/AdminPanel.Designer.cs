namespace WindowsFormsApp2
{
    partial class AdminPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.project_tab = new System.Windows.Forms.TabPage();
            this.project_client_box = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.project_manager_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.project_title_box = new System.Windows.Forms.TextBox();
            this.project_filter_btn = new System.Windows.Forms.Button();
            this.projectGridView = new System.Windows.Forms.DataGridView();
            this.task_tab = new System.Windows.Forms.TabPage();
            this.task_client_box = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.task_manager_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.task_title_box = new System.Windows.Forms.TextBox();
            this.task_filter_btn = new System.Windows.Forms.Button();
            this.taskGridView = new System.Windows.Forms.DataGridView();
            this.user_tab = new System.Windows.Forms.TabPage();
            this.user_add_btn = new System.Windows.Forms.Button();
            this.user_filter_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.clientGridView = new System.Windows.Forms.DataGridView();
            this.managerGridView = new System.Windows.Forms.DataGridView();
            this.report_tab = new System.Windows.Forms.TabPage();
            this.report_ticket_btn = new System.Windows.Forms.Button();
            this.report_manager_btn = new System.Windows.Forms.Button();
            this.report_task_btn = new System.Windows.Forms.Button();
            this.report_project_btn = new System.Windows.Forms.Button();
            this.reportGridView = new System.Windows.Forms.DataGridView();
            this.ticket_tab = new System.Windows.Forms.TabPage();
            this.ticket_manager_box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ticket_title_box = new System.Windows.Forms.TextBox();
            this.ticket_filter_btn = new System.Windows.Forms.Button();
            this.ticketGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.project_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectGridView)).BeginInit();
            this.task_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskGridView)).BeginInit();
            this.user_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerGridView)).BeginInit();
            this.report_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportGridView)).BeginInit();
            this.ticket_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.project_tab);
            this.tabControl1.Controls.Add(this.task_tab);
            this.tabControl1.Controls.Add(this.user_tab);
            this.tabControl1.Controls.Add(this.report_tab);
            this.tabControl1.Controls.Add(this.ticket_tab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // project_tab
            // 
            this.project_tab.Controls.Add(this.project_client_box);
            this.project_tab.Controls.Add(this.label9);
            this.project_tab.Controls.Add(this.project_manager_box);
            this.project_tab.Controls.Add(this.label2);
            this.project_tab.Controls.Add(this.label1);
            this.project_tab.Controls.Add(this.project_title_box);
            this.project_tab.Controls.Add(this.project_filter_btn);
            this.project_tab.Controls.Add(this.projectGridView);
            this.project_tab.Location = new System.Drawing.Point(4, 22);
            this.project_tab.Name = "project_tab";
            this.project_tab.Padding = new System.Windows.Forms.Padding(3);
            this.project_tab.Size = new System.Drawing.Size(768, 400);
            this.project_tab.TabIndex = 0;
            this.project_tab.Text = "Проекты";
            this.project_tab.UseVisualStyleBackColor = true;
            // 
            // project_client_box
            // 
            this.project_client_box.Location = new System.Drawing.Point(629, 102);
            this.project_client_box.Name = "project_client_box";
            this.project_client_box.Size = new System.Drawing.Size(133, 20);
            this.project_client_box.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(629, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Клиент";
            // 
            // project_manager_box
            // 
            this.project_manager_box.Location = new System.Drawing.Point(629, 61);
            this.project_manager_box.Name = "project_manager_box";
            this.project_manager_box.Size = new System.Drawing.Size(133, 20);
            this.project_manager_box.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(629, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Менеджер";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(629, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название";
            // 
            // project_title_box
            // 
            this.project_title_box.Location = new System.Drawing.Point(629, 22);
            this.project_title_box.Name = "project_title_box";
            this.project_title_box.Size = new System.Drawing.Size(133, 20);
            this.project_title_box.TabIndex = 2;
            // 
            // project_filter_btn
            // 
            this.project_filter_btn.Location = new System.Drawing.Point(629, 358);
            this.project_filter_btn.Name = "project_filter_btn";
            this.project_filter_btn.Size = new System.Drawing.Size(133, 36);
            this.project_filter_btn.TabIndex = 1;
            this.project_filter_btn.Text = "Применить";
            this.project_filter_btn.UseVisualStyleBackColor = true;
            this.project_filter_btn.Click += new System.EventHandler(this.project_filter_btn_Click);
            // 
            // projectGridView
            // 
            this.projectGridView.AllowUserToAddRows = false;
            this.projectGridView.AllowUserToDeleteRows = false;
            this.projectGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectGridView.Location = new System.Drawing.Point(6, 6);
            this.projectGridView.Name = "projectGridView";
            this.projectGridView.ReadOnly = true;
            this.projectGridView.Size = new System.Drawing.Size(617, 388);
            this.projectGridView.TabIndex = 0;
            // 
            // task_tab
            // 
            this.task_tab.Controls.Add(this.task_client_box);
            this.task_tab.Controls.Add(this.label10);
            this.task_tab.Controls.Add(this.task_manager_box);
            this.task_tab.Controls.Add(this.label3);
            this.task_tab.Controls.Add(this.label4);
            this.task_tab.Controls.Add(this.task_title_box);
            this.task_tab.Controls.Add(this.task_filter_btn);
            this.task_tab.Controls.Add(this.taskGridView);
            this.task_tab.Location = new System.Drawing.Point(4, 22);
            this.task_tab.Name = "task_tab";
            this.task_tab.Padding = new System.Windows.Forms.Padding(3);
            this.task_tab.Size = new System.Drawing.Size(768, 400);
            this.task_tab.TabIndex = 1;
            this.task_tab.Text = "Задачи";
            this.task_tab.UseVisualStyleBackColor = true;
            // 
            // task_client_box
            // 
            this.task_client_box.Location = new System.Drawing.Point(629, 102);
            this.task_client_box.Name = "task_client_box";
            this.task_client_box.Size = new System.Drawing.Size(133, 20);
            this.task_client_box.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(629, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Клиент";
            // 
            // task_manager_box
            // 
            this.task_manager_box.Location = new System.Drawing.Point(629, 61);
            this.task_manager_box.Name = "task_manager_box";
            this.task_manager_box.Size = new System.Drawing.Size(133, 20);
            this.task_manager_box.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(629, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Менеджер";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(629, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Название";
            // 
            // task_title_box
            // 
            this.task_title_box.Location = new System.Drawing.Point(629, 22);
            this.task_title_box.Name = "task_title_box";
            this.task_title_box.Size = new System.Drawing.Size(133, 20);
            this.task_title_box.TabIndex = 7;
            // 
            // task_filter_btn
            // 
            this.task_filter_btn.Location = new System.Drawing.Point(629, 358);
            this.task_filter_btn.Name = "task_filter_btn";
            this.task_filter_btn.Size = new System.Drawing.Size(133, 36);
            this.task_filter_btn.TabIndex = 6;
            this.task_filter_btn.Text = "Применить";
            this.task_filter_btn.UseVisualStyleBackColor = true;
            this.task_filter_btn.Click += new System.EventHandler(this.task_filter_btn_Click);
            // 
            // taskGridView
            // 
            this.taskGridView.AllowUserToAddRows = false;
            this.taskGridView.AllowUserToDeleteRows = false;
            this.taskGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taskGridView.Location = new System.Drawing.Point(6, 6);
            this.taskGridView.Name = "taskGridView";
            this.taskGridView.ReadOnly = true;
            this.taskGridView.Size = new System.Drawing.Size(617, 388);
            this.taskGridView.TabIndex = 0;
            // 
            // user_tab
            // 
            this.user_tab.Controls.Add(this.user_add_btn);
            this.user_tab.Controls.Add(this.user_filter_btn);
            this.user_tab.Controls.Add(this.label6);
            this.user_tab.Controls.Add(this.label5);
            this.user_tab.Controls.Add(this.clientGridView);
            this.user_tab.Controls.Add(this.managerGridView);
            this.user_tab.Location = new System.Drawing.Point(4, 22);
            this.user_tab.Name = "user_tab";
            this.user_tab.Size = new System.Drawing.Size(768, 400);
            this.user_tab.TabIndex = 2;
            this.user_tab.Text = "Пользователи";
            this.user_tab.UseVisualStyleBackColor = true;
            // 
            // user_add_btn
            // 
            this.user_add_btn.Location = new System.Drawing.Point(303, 300);
            this.user_add_btn.Name = "user_add_btn";
            this.user_add_btn.Size = new System.Drawing.Size(161, 44);
            this.user_add_btn.TabIndex = 5;
            this.user_add_btn.Text = "Добавить";
            this.user_add_btn.UseVisualStyleBackColor = true;
            this.user_add_btn.Click += new System.EventHandler(this.user_add_btn_Click);
            // 
            // user_filter_btn
            // 
            this.user_filter_btn.Location = new System.Drawing.Point(303, 350);
            this.user_filter_btn.Name = "user_filter_btn";
            this.user_filter_btn.Size = new System.Drawing.Size(161, 44);
            this.user_filter_btn.TabIndex = 4;
            this.user_filter_btn.Text = "Обновить";
            this.user_filter_btn.UseVisualStyleBackColor = true;
            this.user_filter_btn.Click += new System.EventHandler(this.user_filter_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Менеджеры";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(467, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Клиенты";
            // 
            // clientGridView
            // 
            this.clientGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientGridView.Location = new System.Drawing.Point(470, 34);
            this.clientGridView.Name = "clientGridView";
            this.clientGridView.Size = new System.Drawing.Size(291, 360);
            this.clientGridView.TabIndex = 1;
            this.clientGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientGridView_CellDoubleClick);
            // 
            // managerGridView
            // 
            this.managerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.managerGridView.Location = new System.Drawing.Point(6, 34);
            this.managerGridView.Name = "managerGridView";
            this.managerGridView.Size = new System.Drawing.Size(291, 360);
            this.managerGridView.TabIndex = 0;
            this.managerGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.managerGridView_CellDoubleClick);
            // 
            // report_tab
            // 
            this.report_tab.Controls.Add(this.report_ticket_btn);
            this.report_tab.Controls.Add(this.report_manager_btn);
            this.report_tab.Controls.Add(this.report_task_btn);
            this.report_tab.Controls.Add(this.report_project_btn);
            this.report_tab.Controls.Add(this.reportGridView);
            this.report_tab.Location = new System.Drawing.Point(4, 22);
            this.report_tab.Name = "report_tab";
            this.report_tab.Size = new System.Drawing.Size(768, 400);
            this.report_tab.TabIndex = 3;
            this.report_tab.Text = "Отчеты";
            this.report_tab.UseVisualStyleBackColor = true;
            // 
            // report_ticket_btn
            // 
            this.report_ticket_btn.Location = new System.Drawing.Point(629, 144);
            this.report_ticket_btn.Name = "report_ticket_btn";
            this.report_ticket_btn.Size = new System.Drawing.Size(136, 40);
            this.report_ticket_btn.TabIndex = 4;
            this.report_ticket_btn.Text = "Тикеты";
            this.report_ticket_btn.UseVisualStyleBackColor = true;
            this.report_ticket_btn.Click += new System.EventHandler(this.report_ticket_btn_Click);
            // 
            // report_manager_btn
            // 
            this.report_manager_btn.Location = new System.Drawing.Point(629, 98);
            this.report_manager_btn.Name = "report_manager_btn";
            this.report_manager_btn.Size = new System.Drawing.Size(136, 40);
            this.report_manager_btn.TabIndex = 3;
            this.report_manager_btn.Text = "Менеджеры";
            this.report_manager_btn.UseVisualStyleBackColor = true;
            this.report_manager_btn.Click += new System.EventHandler(this.report_manager_btn_Click);
            // 
            // report_task_btn
            // 
            this.report_task_btn.Location = new System.Drawing.Point(629, 52);
            this.report_task_btn.Name = "report_task_btn";
            this.report_task_btn.Size = new System.Drawing.Size(136, 40);
            this.report_task_btn.TabIndex = 2;
            this.report_task_btn.Text = "Задачи";
            this.report_task_btn.UseVisualStyleBackColor = true;
            this.report_task_btn.Click += new System.EventHandler(this.report_task_btn_Click);
            // 
            // report_project_btn
            // 
            this.report_project_btn.Location = new System.Drawing.Point(629, 6);
            this.report_project_btn.Name = "report_project_btn";
            this.report_project_btn.Size = new System.Drawing.Size(136, 40);
            this.report_project_btn.TabIndex = 1;
            this.report_project_btn.Text = "Проекты";
            this.report_project_btn.UseVisualStyleBackColor = true;
            this.report_project_btn.Click += new System.EventHandler(this.report_project_btn_Click);
            // 
            // reportGridView
            // 
            this.reportGridView.AllowUserToAddRows = false;
            this.reportGridView.AllowUserToDeleteRows = false;
            this.reportGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportGridView.Location = new System.Drawing.Point(6, 6);
            this.reportGridView.Name = "reportGridView";
            this.reportGridView.ReadOnly = true;
            this.reportGridView.Size = new System.Drawing.Size(617, 388);
            this.reportGridView.TabIndex = 0;
            // 
            // ticket_tab
            // 
            this.ticket_tab.Controls.Add(this.ticket_manager_box);
            this.ticket_tab.Controls.Add(this.label7);
            this.ticket_tab.Controls.Add(this.label8);
            this.ticket_tab.Controls.Add(this.ticket_title_box);
            this.ticket_tab.Controls.Add(this.ticket_filter_btn);
            this.ticket_tab.Controls.Add(this.ticketGridView);
            this.ticket_tab.Location = new System.Drawing.Point(4, 22);
            this.ticket_tab.Name = "ticket_tab";
            this.ticket_tab.Size = new System.Drawing.Size(768, 400);
            this.ticket_tab.TabIndex = 4;
            this.ticket_tab.Text = "Тикеты";
            this.ticket_tab.UseVisualStyleBackColor = true;
            // 
            // ticket_manager_box
            // 
            this.ticket_manager_box.Location = new System.Drawing.Point(629, 61);
            this.ticket_manager_box.Name = "ticket_manager_box";
            this.ticket_manager_box.Size = new System.Drawing.Size(133, 20);
            this.ticket_manager_box.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(629, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Менеджер";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(629, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Название";
            // 
            // ticket_title_box
            // 
            this.ticket_title_box.Location = new System.Drawing.Point(629, 22);
            this.ticket_title_box.Name = "ticket_title_box";
            this.ticket_title_box.Size = new System.Drawing.Size(133, 20);
            this.ticket_title_box.TabIndex = 12;
            // 
            // ticket_filter_btn
            // 
            this.ticket_filter_btn.Location = new System.Drawing.Point(629, 358);
            this.ticket_filter_btn.Name = "ticket_filter_btn";
            this.ticket_filter_btn.Size = new System.Drawing.Size(133, 36);
            this.ticket_filter_btn.TabIndex = 11;
            this.ticket_filter_btn.Text = "Применить";
            this.ticket_filter_btn.UseVisualStyleBackColor = true;
            this.ticket_filter_btn.Click += new System.EventHandler(this.ticket_filter_btn_Click);
            // 
            // ticketGridView
            // 
            this.ticketGridView.AllowUserToAddRows = false;
            this.ticketGridView.AllowUserToDeleteRows = false;
            this.ticketGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketGridView.Location = new System.Drawing.Point(6, 6);
            this.ticketGridView.Name = "ticketGridView";
            this.ticketGridView.ReadOnly = true;
            this.ticketGridView.Size = new System.Drawing.Size(617, 388);
            this.ticketGridView.TabIndex = 0;
            this.ticketGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ticketGridView_CellDoubleClick);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.tabControl1.ResumeLayout(false);
            this.project_tab.ResumeLayout(false);
            this.project_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectGridView)).EndInit();
            this.task_tab.ResumeLayout(false);
            this.task_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskGridView)).EndInit();
            this.user_tab.ResumeLayout(false);
            this.user_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerGridView)).EndInit();
            this.report_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reportGridView)).EndInit();
            this.ticket_tab.ResumeLayout(false);
            this.ticket_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage project_tab;
        private System.Windows.Forms.TabPage task_tab;
        private System.Windows.Forms.DataGridView projectGridView;
        private System.Windows.Forms.TabPage user_tab;
        private System.Windows.Forms.TabPage report_tab;
        private System.Windows.Forms.TabPage ticket_tab;
        private System.Windows.Forms.TextBox project_manager_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox project_title_box;
        private System.Windows.Forms.Button project_filter_btn;
        private System.Windows.Forms.DataGridView taskGridView;
        private System.Windows.Forms.TextBox task_manager_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox task_title_box;
        private System.Windows.Forms.Button task_filter_btn;
        private System.Windows.Forms.DataGridView managerGridView;
        private System.Windows.Forms.DataGridView clientGridView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button user_add_btn;
        private System.Windows.Forms.Button user_filter_btn;
        private System.Windows.Forms.DataGridView reportGridView;
        private System.Windows.Forms.Button report_project_btn;
        private System.Windows.Forms.Button report_ticket_btn;
        private System.Windows.Forms.Button report_manager_btn;
        private System.Windows.Forms.Button report_task_btn;
        private System.Windows.Forms.TextBox project_client_box;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox task_client_box;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ticket_manager_box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ticket_title_box;
        private System.Windows.Forms.Button ticket_filter_btn;
        private System.Windows.Forms.DataGridView ticketGridView;
    }
}