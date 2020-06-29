namespace WindowsFormsApp2
{
    partial class AddProjectForm
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
            this.project_save_btn = new System.Windows.Forms.Button();
            this.project_description_box = new System.Windows.Forms.TextBox();
            this.project_title_box = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // project_save_btn
            // 
            this.project_save_btn.Location = new System.Drawing.Point(12, 397);
            this.project_save_btn.Name = "project_save_btn";
            this.project_save_btn.Size = new System.Drawing.Size(321, 41);
            this.project_save_btn.TabIndex = 6;
            this.project_save_btn.Text = "Сохранить";
            this.project_save_btn.UseVisualStyleBackColor = true;
            this.project_save_btn.Click += new System.EventHandler(this.project_save_btn_Click);
            // 
            // project_description_box
            // 
            this.project_description_box.Location = new System.Drawing.Point(12, 38);
            this.project_description_box.Multiline = true;
            this.project_description_box.Name = "project_description_box";
            this.project_description_box.Size = new System.Drawing.Size(321, 326);
            this.project_description_box.TabIndex = 5;
            // 
            // project_title_box
            // 
            this.project_title_box.Location = new System.Drawing.Point(12, 12);
            this.project_title_box.Name = "project_title_box";
            this.project_title_box.Size = new System.Drawing.Size(321, 20);
            this.project_title_box.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 371);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(321, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // AddProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.project_save_btn);
            this.Controls.Add(this.project_description_box);
            this.Controls.Add(this.project_title_box);
            this.Name = "AddProjectForm";
            this.Text = "AddProjectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button project_save_btn;
        private System.Windows.Forms.TextBox project_description_box;
        private System.Windows.Forms.TextBox project_title_box;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}