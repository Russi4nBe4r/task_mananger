namespace WindowsFormsApp2
{
    partial class AddTicketForm
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
            this.ticket_title_box = new System.Windows.Forms.TextBox();
            this.ticket_description_box = new System.Windows.Forms.TextBox();
            this.ticket_project_box = new System.Windows.Forms.ComboBox();
            this.ticket_save_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ticket_title_box
            // 
            this.ticket_title_box.Location = new System.Drawing.Point(12, 12);
            this.ticket_title_box.Name = "ticket_title_box";
            this.ticket_title_box.Size = new System.Drawing.Size(321, 20);
            this.ticket_title_box.TabIndex = 0;
            // 
            // ticket_description_box
            // 
            this.ticket_description_box.Location = new System.Drawing.Point(12, 38);
            this.ticket_description_box.Multiline = true;
            this.ticket_description_box.Name = "ticket_description_box";
            this.ticket_description_box.Size = new System.Drawing.Size(321, 326);
            this.ticket_description_box.TabIndex = 1;
            // 
            // ticket_project_box
            // 
            this.ticket_project_box.FormattingEnabled = true;
            this.ticket_project_box.Items.AddRange(new object[] {
            " "});
            this.ticket_project_box.Location = new System.Drawing.Point(12, 370);
            this.ticket_project_box.Name = "ticket_project_box";
            this.ticket_project_box.Size = new System.Drawing.Size(321, 21);
            this.ticket_project_box.TabIndex = 2;
            this.ticket_project_box.SelectedIndexChanged += new System.EventHandler(this.ticket_project_box_SelectedIndexChanged);
            // 
            // ticket_save_btn
            // 
            this.ticket_save_btn.Location = new System.Drawing.Point(12, 397);
            this.ticket_save_btn.Name = "ticket_save_btn";
            this.ticket_save_btn.Size = new System.Drawing.Size(321, 41);
            this.ticket_save_btn.TabIndex = 3;
            this.ticket_save_btn.Text = "Сохранить";
            this.ticket_save_btn.UseVisualStyleBackColor = true;
            this.ticket_save_btn.Click += new System.EventHandler(this.ticket_save_btn_Click);
            // 
            // AddTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 450);
            this.Controls.Add(this.ticket_save_btn);
            this.Controls.Add(this.ticket_project_box);
            this.Controls.Add(this.ticket_description_box);
            this.Controls.Add(this.ticket_title_box);
            this.Name = "AddTicketForm";
            this.Text = "AddTicketForm";
            this.Load += new System.EventHandler(this.AddTicketForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ticket_title_box;
        private System.Windows.Forms.TextBox ticket_description_box;
        private System.Windows.Forms.ComboBox ticket_project_box;
        private System.Windows.Forms.Button ticket_save_btn;
    }
}