namespace DataBase
{
    partial class Authentication
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginText = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.Connect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginText
            // 
            this.LoginText.Location = new System.Drawing.Point(71, 26);
            this.LoginText.Name = "LoginText";
            this.LoginText.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.LoginText.Size = new System.Drawing.Size(201, 20);
            this.LoginText.TabIndex = 0;
            this.LoginText.Text = "system";
            this.LoginText.TextChanged += new System.EventHandler(this.LoginText_TextChanged);
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Location = new System.Drawing.Point(12, 29);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(33, 13);
            this.Login.TabIndex = 1;
            this.Login.Text = "Login";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(12, 55);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(53, 13);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password";
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(71, 52);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(201, 20);
            this.PasswordText.TabIndex = 2;
            this.PasswordText.Text = "root";
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(71, 78);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(201, 21);
            this.Connect.TabIndex = 4;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Authentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.LoginText);
            this.Name = "Authentication";
            this.Text = "Authentication";
            this.Load += new System.EventHandler(this.Authentication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginText;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.Button Connect;


    }
}

