namespace DataBase
{
    partial class Form3
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
            this.ai_name = new System.Windows.Forms.TextBox();
            this.ai_add = new System.Windows.Forms.Button();
            this.ai_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // ai_name
            // 
            this.ai_name.Location = new System.Drawing.Point(88, 12);
            this.ai_name.Name = "ai_name";
            this.ai_name.Size = new System.Drawing.Size(136, 20);
            this.ai_name.TabIndex = 2;
            this.ai_name.TextChanged += new System.EventHandler(this.pi_l_name_TextChanged);
            // 
            // ai_add
            // 
            this.ai_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ai_add.Location = new System.Drawing.Point(88, 46);
            this.ai_add.Name = "ai_add";
            this.ai_add.Size = new System.Drawing.Size(136, 23);
            this.ai_add.TabIndex = 4;
            this.ai_add.Text = "Добавить";
            this.ai_add.UseVisualStyleBackColor = true;
            this.ai_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // ai_cancel
            // 
            this.ai_cancel.Location = new System.Drawing.Point(12, 46);
            this.ai_cancel.Name = "ai_cancel";
            this.ai_cancel.Size = new System.Drawing.Size(70, 23);
            this.ai_cancel.TabIndex = 5;
            this.ai_cancel.Text = "Отмена";
            this.ai_cancel.UseVisualStyleBackColor = true;
            this.ai_cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 80);
            this.Controls.Add(this.ai_cancel);
            this.Controls.Add(this.ai_add);
            this.Controls.Add(this.ai_name);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Статья";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ai_name;
        private System.Windows.Forms.Button ai_add;
        private System.Windows.Forms.Button ai_cancel;
    }
}