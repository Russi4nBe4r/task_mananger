namespace WindowsFormsApp2
{
    partial class AuthForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.username_box = new System.Windows.Forms.TextBox();
            this.auth_btn = new System.Windows.Forms.Button();
            this.password_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "логин";
            // 
            // username_box
            // 
            this.username_box.Location = new System.Drawing.Point(54, 6);
            this.username_box.Name = "username_box";
            this.username_box.Size = new System.Drawing.Size(100, 20);
            this.username_box.TabIndex = 1;
            this.username_box.Text = "manager_1";
            // 
            // auth_btn
            // 
            this.auth_btn.Location = new System.Drawing.Point(79, 58);
            this.auth_btn.Name = "auth_btn";
            this.auth_btn.Size = new System.Drawing.Size(75, 23);
            this.auth_btn.TabIndex = 2;
            this.auth_btn.Text = "Войти";
            this.auth_btn.UseVisualStyleBackColor = true;
            this.auth_btn.Click += new System.EventHandler(this.auth_btn_Click);
            // 
            // password_box
            // 
            this.password_box.Location = new System.Drawing.Point(54, 32);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(100, 20);
            this.password_box.TabIndex = 4;
            this.password_box.Text = "manager_1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "пароль";
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(158, 87);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.auth_btn);
            this.Controls.Add(this.username_box);
            this.Controls.Add(this.label1);
            this.Name = "AuthForm";
            this.Text = "AuthForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username_box;
        private System.Windows.Forms.Button auth_btn;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.Label label2;
    }
}