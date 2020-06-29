namespace WindowsFormsApp2
{
    partial class BaseForm
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
            this.admin_btn = new System.Windows.Forms.Button();
            this.manager_btn = new System.Windows.Forms.Button();
            this.client_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // admin_btn
            // 
            this.admin_btn.Location = new System.Drawing.Point(12, 12);
            this.admin_btn.Name = "admin_btn";
            this.admin_btn.Size = new System.Drawing.Size(223, 75);
            this.admin_btn.TabIndex = 0;
            this.admin_btn.Text = "Администратор";
            this.admin_btn.UseVisualStyleBackColor = true;
            this.admin_btn.Click += new System.EventHandler(this.admin_btn_Click);
            // 
            // manager_btn
            // 
            this.manager_btn.Location = new System.Drawing.Point(12, 93);
            this.manager_btn.Name = "manager_btn";
            this.manager_btn.Size = new System.Drawing.Size(223, 75);
            this.manager_btn.TabIndex = 1;
            this.manager_btn.Text = "Менеджер";
            this.manager_btn.UseVisualStyleBackColor = true;
            this.manager_btn.Click += new System.EventHandler(this.manager_btn_Click);
            // 
            // client_btn
            // 
            this.client_btn.Location = new System.Drawing.Point(12, 174);
            this.client_btn.Name = "client_btn";
            this.client_btn.Size = new System.Drawing.Size(223, 75);
            this.client_btn.TabIndex = 2;
            this.client_btn.Text = "Клиент";
            this.client_btn.UseVisualStyleBackColor = true;
            this.client_btn.Click += new System.EventHandler(this.client_btn_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 254);
            this.Controls.Add(this.client_btn);
            this.Controls.Add(this.manager_btn);
            this.Controls.Add(this.admin_btn);
            this.Name = "BaseForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button admin_btn;
        private System.Windows.Forms.Button manager_btn;
        private System.Windows.Forms.Button client_btn;
    }
}

