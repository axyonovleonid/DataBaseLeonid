namespace DataBase
{
    partial class Form4
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
            this.au_cancel = new System.Windows.Forms.Button();
            this.au_add = new System.Windows.Forms.Button();
            this.au_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // au_cancel
            // 
            this.au_cancel.Location = new System.Drawing.Point(12, 52);
            this.au_cancel.Name = "au_cancel";
            this.au_cancel.Size = new System.Drawing.Size(70, 23);
            this.au_cancel.TabIndex = 17;
            this.au_cancel.Text = "Отмена";
            this.au_cancel.UseVisualStyleBackColor = true;
            this.au_cancel.Click += new System.EventHandler(this.pu_cancel_Click);
            // 
            // au_add
            // 
            this.au_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.au_add.Location = new System.Drawing.Point(88, 52);
            this.au_add.Name = "au_add";
            this.au_add.Size = new System.Drawing.Size(148, 23);
            this.au_add.TabIndex = 16;
            this.au_add.Text = "Изменить";
            this.au_add.UseVisualStyleBackColor = true;
            this.au_add.Click += new System.EventHandler(this.pu_add_Click);
            // 
            // au_name
            // 
            this.au_name.Location = new System.Drawing.Point(101, 12);
            this.au_name.Name = "au_name";
            this.au_name.Size = new System.Drawing.Size(136, 20);
            this.au_name.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Наименование";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 95);
            this.Controls.Add(this.au_cancel);
            this.Controls.Add(this.au_add);
            this.Controls.Add(this.au_name);
            this.Controls.Add(this.label7);
            this.Name = "Form4";
            this.Text = "Статья";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button au_cancel;
        private System.Windows.Forms.Button au_add;
        private System.Windows.Forms.TextBox au_name;
        private System.Windows.Forms.Label label7;
    }
}