namespace WindowsFormsApp2
{
    partial class Task
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
            this.answer_update_btn = new System.Windows.Forms.Button();
            this.task_answer_btn = new System.Windows.Forms.Button();
            this.task_answer_box = new System.Windows.Forms.TextBox();
            this.commentGridView = new System.Windows.Forms.DataGridView();
            this.task_description_box = new System.Windows.Forms.TextBox();
            this.task_title_box = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.commentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // answer_update_btn
            // 
            this.answer_update_btn.Location = new System.Drawing.Point(688, 161);
            this.answer_update_btn.Name = "answer_update_btn";
            this.answer_update_btn.Size = new System.Drawing.Size(100, 35);
            this.answer_update_btn.TabIndex = 13;
            this.answer_update_btn.Text = "Обновить";
            this.answer_update_btn.UseVisualStyleBackColor = true;
            this.answer_update_btn.Click += new System.EventHandler(this.answer_update_btn_Click);
            // 
            // task_answer_btn
            // 
            this.task_answer_btn.Location = new System.Drawing.Point(688, 38);
            this.task_answer_btn.Name = "task_answer_btn";
            this.task_answer_btn.Size = new System.Drawing.Size(100, 35);
            this.task_answer_btn.TabIndex = 12;
            this.task_answer_btn.Text = "Ответить";
            this.task_answer_btn.UseVisualStyleBackColor = true;
            this.task_answer_btn.Click += new System.EventHandler(this.task_answer_btn_Click);
            // 
            // task_answer_box
            // 
            this.task_answer_box.Location = new System.Drawing.Point(688, 12);
            this.task_answer_box.Name = "task_answer_box";
            this.task_answer_box.Size = new System.Drawing.Size(100, 20);
            this.task_answer_box.TabIndex = 11;
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
            this.commentGridView.TabIndex = 10;
            // 
            // task_description_box
            // 
            this.task_description_box.Enabled = false;
            this.task_description_box.Location = new System.Drawing.Point(12, 38);
            this.task_description_box.Multiline = true;
            this.task_description_box.Name = "task_description_box";
            this.task_description_box.Size = new System.Drawing.Size(328, 158);
            this.task_description_box.TabIndex = 9;
            // 
            // task_title_box
            // 
            this.task_title_box.Enabled = false;
            this.task_title_box.Location = new System.Drawing.Point(12, 12);
            this.task_title_box.Name = "task_title_box";
            this.task_title_box.Size = new System.Drawing.Size(328, 20);
            this.task_title_box.TabIndex = 8;
            // 
            // Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.answer_update_btn);
            this.Controls.Add(this.task_answer_btn);
            this.Controls.Add(this.task_answer_box);
            this.Controls.Add(this.commentGridView);
            this.Controls.Add(this.task_description_box);
            this.Controls.Add(this.task_title_box);
            this.Name = "Task";
            this.Text = "Task";
            this.Load += new System.EventHandler(this.Task_Load);
            ((System.ComponentModel.ISupportInitialize)(this.commentGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button answer_update_btn;
        private System.Windows.Forms.Button task_answer_btn;
        private System.Windows.Forms.TextBox task_answer_box;
        private System.Windows.Forms.DataGridView commentGridView;
        private System.Windows.Forms.TextBox task_description_box;
        private System.Windows.Forms.TextBox task_title_box;
    }
}