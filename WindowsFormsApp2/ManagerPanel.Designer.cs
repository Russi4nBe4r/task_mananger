namespace WindowsFormsApp2
{
    partial class ManagerPanel
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
            this.label8 = new System.Windows.Forms.Label();
            this.ticket_title_box = new System.Windows.Forms.TextBox();
            this.ticket_filter_btn = new System.Windows.Forms.Button();
            this.ticketGridView = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.project_client_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.task_client_box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ticket_client_box = new System.Windows.Forms.TextBox();
            this.mticket_add_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.mticket_title_box = new System.Windows.Forms.TextBox();
            this.mticket_filter_btn = new System.Windows.Forms.Button();
            this.mticketGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mticketGridView)).BeginInit();
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
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.project_client_box);
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
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.task_client_box);
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
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.ticket_client_box);
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
            this.tabPage4.Controls.Add(this.mticket_add_btn);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.mticket_title_box);
            this.tabPage4.Controls.Add(this.mticket_filter_btn);
            this.tabPage4.Controls.Add(this.mticketGridView);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(768, 400);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Мои тикеты";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(616, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Клиент";
            // 
            // project_client_box
            // 
            this.project_client_box.Location = new System.Drawing.Point(616, 61);
            this.project_client_box.Name = "project_client_box";
            this.project_client_box.Size = new System.Drawing.Size(133, 20);
            this.project_client_box.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(629, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Клиент";
            // 
            // task_client_box
            // 
            this.task_client_box.Location = new System.Drawing.Point(629, 101);
            this.task_client_box.Name = "task_client_box";
            this.task_client_box.Size = new System.Drawing.Size(133, 20);
            this.task_client_box.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(629, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Клиент";
            // 
            // ticket_client_box
            // 
            this.ticket_client_box.Location = new System.Drawing.Point(629, 62);
            this.ticket_client_box.Name = "ticket_client_box";
            this.ticket_client_box.Size = new System.Drawing.Size(133, 20);
            this.ticket_client_box.TabIndex = 18;
            // 
            // mticket_add_btn
            // 
            this.mticket_add_btn.Location = new System.Drawing.Point(629, 316);
            this.mticket_add_btn.Name = "mticket_add_btn";
            this.mticket_add_btn.Size = new System.Drawing.Size(133, 36);
            this.mticket_add_btn.TabIndex = 23;
            this.mticket_add_btn.Text = "Создать";
            this.mticket_add_btn.UseVisualStyleBackColor = true;
            this.mticket_add_btn.Click += new System.EventHandler(this.mticket_add_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(629, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Название";
            // 
            // mticket_title_box
            // 
            this.mticket_title_box.Location = new System.Drawing.Point(629, 22);
            this.mticket_title_box.Name = "mticket_title_box";
            this.mticket_title_box.Size = new System.Drawing.Size(133, 20);
            this.mticket_title_box.TabIndex = 21;
            // 
            // mticket_filter_btn
            // 
            this.mticket_filter_btn.Location = new System.Drawing.Point(629, 358);
            this.mticket_filter_btn.Name = "mticket_filter_btn";
            this.mticket_filter_btn.Size = new System.Drawing.Size(133, 36);
            this.mticket_filter_btn.TabIndex = 20;
            this.mticket_filter_btn.Text = "Применить";
            this.mticket_filter_btn.UseVisualStyleBackColor = true;
            this.mticket_filter_btn.Click += new System.EventHandler(this.mticket_filter_btn_Click);
            // 
            // mticketGridView
            // 
            this.mticketGridView.AllowUserToAddRows = false;
            this.mticketGridView.AllowUserToDeleteRows = false;
            this.mticketGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mticketGridView.Location = new System.Drawing.Point(6, 6);
            this.mticketGridView.Name = "mticketGridView";
            this.mticketGridView.ReadOnly = true;
            this.mticketGridView.Size = new System.Drawing.Size(617, 388);
            this.mticketGridView.TabIndex = 19;
            this.mticketGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mticket_grid_view_CellDoubleClick);
            // 
            // ManagerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "ManagerPanel";
            this.Text = "ManagerPanel";
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
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mticketGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox project_title_box;
        private System.Windows.Forms.Button project_filter_btn;
        private System.Windows.Forms.DataGridView projectGridView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox task_project_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox task_title_box;
        private System.Windows.Forms.Button task_filter_btn;
        private System.Windows.Forms.DataGridView taskGridView;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ticket_title_box;
        private System.Windows.Forms.Button ticket_filter_btn;
        private System.Windows.Forms.DataGridView ticketGridView;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox project_client_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox task_client_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ticket_client_box;
        private System.Windows.Forms.Button mticket_add_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox mticket_title_box;
        private System.Windows.Forms.Button mticket_filter_btn;
        private System.Windows.Forms.DataGridView mticketGridView;
    }
}