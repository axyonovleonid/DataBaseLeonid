namespace DataBase
{
    partial class Form5
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
            this.oi_cancel = new System.Windows.Forms.Button();
            this.oi_add = new System.Windows.Forms.Button();
            this.oi_credit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.oi_article = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.oi_debit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.oi_time = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // oi_cancel
            // 
            this.oi_cancel.Location = new System.Drawing.Point(12, 127);
            this.oi_cancel.Name = "oi_cancel";
            this.oi_cancel.Size = new System.Drawing.Size(70, 23);
            this.oi_cancel.TabIndex = 6;
            this.oi_cancel.Text = "Отмена";
            this.oi_cancel.UseVisualStyleBackColor = true;
            this.oi_cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // oi_add
            // 
            this.oi_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oi_add.Location = new System.Drawing.Point(88, 127);
            this.oi_add.Name = "oi_add";
            this.oi_add.Size = new System.Drawing.Size(136, 23);
            this.oi_add.TabIndex = 5;
            this.oi_add.Text = "Добавить";
            this.oi_add.UseVisualStyleBackColor = true;
            this.oi_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // oi_credit
            // 
            this.oi_credit.Location = new System.Drawing.Point(88, 65);
            this.oi_credit.Name = "oi_credit";
            this.oi_credit.Size = new System.Drawing.Size(136, 20);
            this.oi_credit.TabIndex = 3;
            this.oi_credit.TextChanged += new System.EventHandler(this.pu_l_name_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Кредит";
            // 
            // oi_article
            // 
            this.oi_article.FormattingEnabled = true;
            this.oi_article.Location = new System.Drawing.Point(88, 12);
            this.oi_article.Name = "oi_article";
            this.oi_article.Size = new System.Drawing.Size(136, 21);
            this.oi_article.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Статья";
            // 
            // oi_debit
            // 
            this.oi_debit.Location = new System.Drawing.Point(88, 39);
            this.oi_debit.Name = "oi_debit";
            this.oi_debit.Size = new System.Drawing.Size(136, 20);
            this.oi_debit.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Дебет";
            // 
            // oi_time
            // 
            this.oi_time.Location = new System.Drawing.Point(88, 92);
            this.oi_time.Name = "oi_time";
            this.oi_time.Size = new System.Drawing.Size(136, 20);
            this.oi_time.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Время";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 162);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oi_time);
            this.Controls.Add(this.oi_debit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oi_article);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.oi_credit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.oi_cancel);
            this.Controls.Add(this.oi_add);
            this.Name = "Form5";
            this.Text = "Операция";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button oi_cancel;
        private System.Windows.Forms.Button oi_add;
        private System.Windows.Forms.TextBox oi_credit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox oi_article;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox oi_debit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker oi_time;
        private System.Windows.Forms.Label label2;
    }
}