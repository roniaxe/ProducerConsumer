namespace DashboardForm
{
    partial class Dashboard
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
            this.addBtn = new System.Windows.Forms.Button();
            this.addQnTextBox = new System.Windows.Forms.TextBox();
            quantityTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new System.Drawing.Point(104, 81);
            quantityTextBox.Multiline = true;
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.ReadOnly = true;
            quantityTextBox.Size = new System.Drawing.Size(203, 114);
            quantityTextBox.TabIndex = 0;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(525, 130);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 20);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // addQnTextBox
            // 
            this.addQnTextBox.Location = new System.Drawing.Point(606, 130);
            this.addQnTextBox.Name = "addQnTextBox";
            this.addQnTextBox.Size = new System.Drawing.Size(100, 20);
            this.addQnTextBox.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 506);
            this.Controls.Add(this.addQnTextBox);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(quantityTextBox);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox addQnTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
    }
}

