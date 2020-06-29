namespace WindowsFormsApp2
{
    partial class AddTaskForm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.task_save_btn = new System.Windows.Forms.Button();
            this.task_description_box = new System.Windows.Forms.TextBox();
            this.task_title_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 371);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(321, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // task_save_btn
            // 
            this.task_save_btn.Location = new System.Drawing.Point(12, 397);
            this.task_save_btn.Name = "task_save_btn";
            this.task_save_btn.Size = new System.Drawing.Size(321, 41);
            this.task_save_btn.TabIndex = 10;
            this.task_save_btn.Text = "Сохранить";
            this.task_save_btn.UseVisualStyleBackColor = true;
            this.task_save_btn.Click += new System.EventHandler(this.task_save_btn_Click);
            // 
            // task_description_box
            // 
            this.task_description_box.Location = new System.Drawing.Point(12, 38);
            this.task_description_box.Multiline = true;
            this.task_description_box.Name = "task_description_box";
            this.task_description_box.Size = new System.Drawing.Size(321, 326);
            this.task_description_box.TabIndex = 9;
            // 
            // task_title_box
            // 
            this.task_title_box.Location = new System.Drawing.Point(12, 12);
            this.task_title_box.Name = "task_title_box";
            this.task_title_box.Size = new System.Drawing.Size(321, 20);
            this.task_title_box.TabIndex = 8;
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.task_save_btn);
            this.Controls.Add(this.task_description_box);
            this.Controls.Add(this.task_title_box);
            this.Name = "AddTaskForm";
            this.Text = "AddTaskForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button task_save_btn;
        private System.Windows.Forms.TextBox task_description_box;
        private System.Windows.Forms.TextBox task_title_box;
    }
}