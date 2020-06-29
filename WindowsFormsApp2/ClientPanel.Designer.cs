namespace WindowsFormsApp2
{
    partial class ClientPanel
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.project_title_box = new System.Windows.Forms.TextBox();
            this.project_filter_btn = new System.Windows.Forms.Button();
            this.projectGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.task_project_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.task_title_box = new System.Windows.Forms.TextBox();
            this.task_filter_btn = new System.Windows.Forms.Button();
            this.taskGridView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ticket_add_btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ticket_title_box = new System.Windows.Forms.TextBox();
            this.ticket_filter_btn = new System.Windows.Forms.Button();
            this.ticketGridView = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.report_ticket_btn = new System.Windows.Forms.Button();
            this.report_task_btn = new System.Windows.Forms.Button();
            this.report_project_btn = new System.Windows.Forms.Button();
            this.reportGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.project_title_box);
            this.tabPage1.Controls.Add(this.project_filter_btn);
            this.tabPage1.Controls.Add(this.projectGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Проекты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(616, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Название";
            // 
            // project_title_box
            // 
            this.project_title_box.Location = new System.Drawing.Point(616, 22);
            this.project_title_box.Name = "project_title_box";
            this.project_title_box.Size = new System.Drawing.Size(133, 20);
            this.project_title_box.TabIndex = 5;
            // 
            // project_filter_btn
            // 
            this.project_filter_btn.Location = new System.Drawing.Point(616, 358);
            this.project_filter_btn.Name = "project_filter_btn";
            this.project_filter_btn.Size = new System.Drawing.Size(133, 36);
            this.project_filter_btn.TabIndex = 4;
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
            this.projectGridView.Size = new System.Drawing.Size(604, 388);
            this.projectGridView.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.task_project_box);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.task_title_box);
            this.tabPage2.Controls.Add(this.task_filter_btn);
            this.tabPage2.Controls.Add(this.taskGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Задачи";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // task_project_box
            // 
            this.task_project_box.Location = new System.Drawing.Point(629, 61);
            this.task_project_box.Name = "task_project_box";
            this.task_project_box.Size = new System.Drawing.Size(133, 20);
            this.task_project_box.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(629, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Проект";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(629, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Название";
            // 
            // task_title_box
            // 
            this.task_title_box.Location = new System.Drawing.Point(629, 22);
            this.task_title_box.Name = "task_title_box";
            this.task_title_box.Size = new System.Drawing.Size(133, 20);
            this.task_title_box.TabIndex = 13;
            // 
            // task_filter_btn
            // 
            this.task_filter_btn.Location = new System.Drawing.Point(629, 358);
            this.task_filter_btn.Name = "task_filter_btn";
            this.task_filter_btn.Size = new System.Drawing.Size(133, 36);
            this.task_filter_btn.TabIndex = 12;
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
            this.taskGridView.TabIndex = 11;
            this.taskGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.taskGridView_CellDoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ticket_add_btn);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.ticket_title_box);
            this.tabPage3.Controls.Add(this.ticket_filter_btn);
            this.tabPage3.Controls.Add(this.ticketGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Тикеты";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ticket_add_btn
            // 
            this.ticket_add_btn.Location = new System.Drawing.Point(629, 316);
            this.ticket_add_btn.Name = "ticket_add_btn";
            this.ticket_add_btn.Size = new System.Drawing.Size(133, 36);
            this.ticket_add_btn.TabIndex = 18;
            this.ticket_add_btn.Text = "Создать";
            this.ticket_add_btn.UseVisualStyleBackColor = true;
            this.ticket_add_btn.Click += new System.EventHandler(this.ticket_add_btn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(629, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Название";
            // 
            // ticket_title_box
            // 
            this.ticket_title_box.Location = new System.Drawing.Point(629, 22);
            this.ticket_title_box.Name = "ticket_title_box";
            this.ticket_title_box.Size = new System.Drawing.Size(133, 20);
            this.ticket_title_box.TabIndex = 16;
            // 
            // ticket_filter_btn
            // 
            this.ticket_filter_btn.Location = new System.Drawing.Point(629, 358);
            this.ticket_filter_btn.Name = "ticket_filter_btn";
            this.ticket_filter_btn.Size = new System.Drawing.Size(133, 36);
            this.ticket_filter_btn.TabIndex = 15;
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
            this.ticketGridView.TabIndex = 14;
            this.ticketGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ticketGridView_CellDoubleClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.report_ticket_btn);
            this.tabPage4.Controls.Add(this.report_task_btn);
            this.tabPage4.Controls.Add(this.report_project_btn);
            this.tabPage4.Controls.Add(this.reportGridView);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(768, 400);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Отчеты";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // report_ticket_btn
            // 
            this.report_ticket_btn.Location = new System.Drawing.Point(628, 98);
            this.report_ticket_btn.Name = "report_ticket_btn";
            this.report_ticket_btn.Size = new System.Drawing.Size(136, 40);
            this.report_ticket_btn.TabIndex = 9;
            this.report_ticket_btn.Text = "Тикеты";
            this.report_ticket_btn.UseVisualStyleBackColor = true;
            this.report_ticket_btn.Click += new System.EventHandler(this.report_ticket_btn_Click);
            // 
            // report_task_btn
            // 
            this.report_task_btn.Location = new System.Drawing.Point(628, 52);
            this.report_task_btn.Name = "report_task_btn";
            this.report_task_btn.Size = new System.Drawing.Size(136, 40);
            this.report_task_btn.TabIndex = 7;
            this.report_task_btn.Text = "Задачи";
            this.report_task_btn.UseVisualStyleBackColor = true;
            this.report_task_btn.Click += new System.EventHandler(this.report_task_btn_Click);
            // 
            // report_project_btn
            // 
            this.report_project_btn.Location = new System.Drawing.Point(628, 6);
            this.report_project_btn.Name = "report_project_btn";
            this.report_project_btn.Size = new System.Drawing.Size(136, 40);
            this.report_project_btn.TabIndex = 6;
            this.report_project_btn.Text = "Проекты";
            this.report_project_btn.UseVisualStyleBackColor = true;
            this.report_project_btn.Click += new System.EventHandler(this.report_project_btn_Click);
            // 
            // reportGridView
            // 
            this.reportGridView.AllowUserToAddRows = false;
            this.reportGridView.AllowUserToDeleteRows = false;
            this.reportGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportGridView.Location = new System.Drawing.Point(5, 6);
            this.reportGridView.Name = "reportGridView";
            this.reportGridView.ReadOnly = true;
            this.reportGridView.Size = new System.Drawing.Size(617, 388);
            this.reportGridView.TabIndex = 5;
            // 
            // ClientPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "ClientPanel";
            this.Text = "ClientPanel";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reportGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView projectGridView;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox project_title_box;
        private System.Windows.Forms.Button project_filter_btn;
        private System.Windows.Forms.TextBox task_project_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox task_title_box;
        private System.Windows.Forms.Button task_filter_btn;
        private System.Windows.Forms.DataGridView taskGridView;
        private System.Windows.Forms.Button ticket_add_btn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ticket_title_box;
        private System.Windows.Forms.Button ticket_filter_btn;
        private System.Windows.Forms.DataGridView ticketGridView;
        private System.Windows.Forms.Button report_ticket_btn;
        private System.Windows.Forms.Button report_task_btn;
        private System.Windows.Forms.Button report_project_btn;
        private System.Windows.Forms.DataGridView reportGridView;
    }
}