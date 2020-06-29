namespace WindowsFormsApp2
{
    partial class Ticket
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
            this.ticket_user_box = new System.Windows.Forms.TextBox();
            this.ticket_title_box = new System.Windows.Forms.TextBox();
            this.ticket_description_box = new System.Windows.Forms.TextBox();
            this.commentGridView = new System.Windows.Forms.DataGridView();
            this.ticket_answer_box = new System.Windows.Forms.TextBox();
            this.ticket_answer_btn = new System.Windows.Forms.Button();
            this.answer_update_btn = new System.Windows.Forms.Button();
            this.ticket_close_btn = new System.Windows.Forms.Button();
            this.ticket_add_project_btn = new System.Windows.Forms.Button();
            this.ticket_add_task_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.commentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ticket_user_box
            // 
            this.ticket_user_box.Enabled = false;
            this.ticket_user_box.Location = new System.Drawing.Point(12, 12);
            this.ticket_user_box.Name = "ticket_user_box";
            this.ticket_user_box.Size = new System.Drawing.Size(100, 20);
            this.ticket_user_box.TabIndex = 0;
            // 
            // ticket_title_box
            // 
            this.ticket_title_box.Enabled = false;
            this.ticket_title_box.Location = new System.Drawing.Point(118, 12);
            this.ticket_title_box.Name = "ticket_title_box";
            this.ticket_title_box.Size = new System.Drawing.Size(222, 20);
            this.ticket_title_box.TabIndex = 1;
            // 
            // ticket_description_box
            // 
            this.ticket_description_box.Enabled = false;
            this.ticket_description_box.Location = new System.Drawing.Point(12, 38);
            this.ticket_description_box.Multiline = true;
            this.ticket_description_box.Name = "ticket_description_box";
            this.ticket_description_box.Size = new System.Drawing.Size(328, 158);
            this.ticket_description_box.TabIndex = 2;
            // 
            // commentGridView
            // 
            this.commentGridView.AllowUserToAddRows = false;
            this.commentGridView.AllowUserToDeleteRows = false;
            this.commentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.commentGridView.Location = new System.Drawing.Point(12, 202);
            this.commentGridView.Name = "commentGridView";
            this.commentGridView.ReadOnly = true;
            this.commentGridView.Size = new System.Drawing.Size(776, 236);
            this.commentGridView.TabIndex = 3;
            // 
            // ticket_answer_box
            // 
            this.ticket_answer_box.Location = new System.Drawing.Point(688, 12);
            this.ticket_answer_box.Name = "ticket_answer_box";
            this.ticket_answer_box.Size = new System.Drawing.Size(100, 20);
            this.ticket_answer_box.TabIndex = 4;
            // 
            // ticket_answer_btn
            // 
            this.ticket_answer_btn.Location = new System.Drawing.Point(688, 38);
            this.ticket_answer_btn.Name = "ticket_answer_btn";
            this.ticket_answer_btn.Size = new System.Drawing.Size(100, 35);
            this.ticket_answer_btn.TabIndex = 5;
            this.ticket_answer_btn.Text = "Ответить";
            this.ticket_answer_btn.UseVisualStyleBackColor = true;
            this.ticket_answer_btn.Click += new System.EventHandler(this.ticket_answer_btn_Click);
            // 
            // answer_update_btn
            // 
            this.answer_update_btn.Location = new System.Drawing.Point(688, 161);
            this.answer_update_btn.Name = "answer_update_btn";
            this.answer_update_btn.Size = new System.Drawing.Size(100, 35);
            this.answer_update_btn.TabIndex = 6;
            this.answer_update_btn.Text = "Обновить";
            this.answer_update_btn.UseVisualStyleBackColor = true;
            this.answer_update_btn.Click += new System.EventHandler(this.answer_update_btn_Click);
            // 
            // ticket_close_btn
            // 
            this.ticket_close_btn.Location = new System.Drawing.Point(688, 120);
            this.ticket_close_btn.Name = "ticket_close_btn";
            this.ticket_close_btn.Size = new System.Drawing.Size(100, 35);
            this.ticket_close_btn.TabIndex = 7;
            this.ticket_close_btn.Text = "Закрыть";
            this.ticket_close_btn.UseVisualStyleBackColor = true;
            this.ticket_close_btn.Click += new System.EventHandler(this.ticket_close_btn_Click);
            // 
            // ticket_add_project_btn
            // 
            this.ticket_add_project_btn.Location = new System.Drawing.Point(582, 161);
            this.ticket_add_project_btn.Name = "ticket_add_project_btn";
            this.ticket_add_project_btn.Size = new System.Drawing.Size(100, 35);
            this.ticket_add_project_btn.TabIndex = 8;
            this.ticket_add_project_btn.Text = "Создать проект";
            this.ticket_add_project_btn.UseVisualStyleBackColor = true;
            this.ticket_add_project_btn.Click += new System.EventHandler(this.ticket_add_project_btn_Click);
            // 
            // ticket_add_task_btn
            // 
            this.ticket_add_task_btn.Location = new System.Drawing.Point(476, 161);
            this.ticket_add_task_btn.Name = "ticket_add_task_btn";
            this.ticket_add_task_btn.Size = new System.Drawing.Size(100, 35);
            this.ticket_add_task_btn.TabIndex = 9;
            this.ticket_add_task_btn.Text = "Создать задачу";
            this.ticket_add_task_btn.UseVisualStyleBackColor = true;
            this.ticket_add_task_btn.Click += new System.EventHandler(this.ticket_add_task_btn_Click);
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ticket_add_task_btn);
            this.Controls.Add(this.ticket_add_project_btn);
            this.Controls.Add(this.ticket_close_btn);
            this.Controls.Add(this.answer_update_btn);
            this.Controls.Add(this.ticket_answer_btn);
            this.Controls.Add(this.ticket_answer_box);
            this.Controls.Add(this.commentGridView);
            this.Controls.Add(this.ticket_description_box);
            this.Controls.Add(this.ticket_title_box);
            this.Controls.Add(this.ticket_user_box);
            this.Name = "Ticket";
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.Ticket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.commentGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ticket_user_box;
        private System.Windows.Forms.TextBox ticket_title_box;
        private System.Windows.Forms.TextBox ticket_description_box;
        private System.Windows.Forms.DataGridView commentGridView;
        private System.Windows.Forms.TextBox ticket_answer_box;
        private System.Windows.Forms.Button ticket_answer_btn;
        private System.Windows.Forms.Button answer_update_btn;
        private System.Windows.Forms.Button ticket_close_btn;
        private System.Windows.Forms.Button ticket_add_project_btn;
        private System.Windows.Forms.Button ticket_add_task_btn;
    }
}