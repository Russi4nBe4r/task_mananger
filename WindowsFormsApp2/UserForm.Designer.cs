namespace WindowsFormsApp2
{
    partial class UserForm
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
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.client_radio = new System.Windows.Forms.RadioButton();
            this.manager_radio = new System.Windows.Forms.RadioButton();
            this.user_save_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(56, 6);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 20);
            this.username.TabIndex = 1;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(56, 32);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // client_radio
            // 
            this.client_radio.AutoSize = true;
            this.client_radio.Location = new System.Drawing.Point(162, 35);
            this.client_radio.Name = "client_radio";
            this.client_radio.Size = new System.Drawing.Size(61, 17);
            this.client_radio.TabIndex = 4;
            this.client_radio.TabStop = true;
            this.client_radio.Text = "Клиент";
            this.client_radio.UseVisualStyleBackColor = true;
            this.client_radio.CheckedChanged += new System.EventHandler(this.client_radio_CheckedChanged);
            // 
            // manager_radio
            // 
            this.manager_radio.AutoSize = true;
            this.manager_radio.Location = new System.Drawing.Point(162, 7);
            this.manager_radio.Name = "manager_radio";
            this.manager_radio.Size = new System.Drawing.Size(78, 17);
            this.manager_radio.TabIndex = 5;
            this.manager_radio.TabStop = true;
            this.manager_radio.Text = "Менеджер";
            this.manager_radio.UseVisualStyleBackColor = true;
            this.manager_radio.CheckedChanged += new System.EventHandler(this.manager_radio_CheckedChanged);
            // 
            // user_save_btn
            // 
            this.user_save_btn.Location = new System.Drawing.Point(56, 58);
            this.user_save_btn.Name = "user_save_btn";
            this.user_save_btn.Size = new System.Drawing.Size(100, 23);
            this.user_save_btn.TabIndex = 6;
            this.user_save_btn.Text = "Сохранить";
            this.user_save_btn.UseVisualStyleBackColor = true;
            this.user_save_btn.Click += new System.EventHandler(this.user_save_btn_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 87);
            this.Controls.Add(this.user_save_btn);
            this.Controls.Add(this.manager_radio);
            this.Controls.Add(this.client_radio);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton client_radio;
        private System.Windows.Forms.RadioButton manager_radio;
        private System.Windows.Forms.Button user_save_btn;
    }
}