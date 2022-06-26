namespace Contact_Tracing
{
    partial class Form2
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
            this.ShwallBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ShwallBtn
            // 
            this.ShwallBtn.Location = new System.Drawing.Point(43, 128);
            this.ShwallBtn.Name = "ShwallBtn";
            this.ShwallBtn.Size = new System.Drawing.Size(121, 54);
            this.ShwallBtn.TabIndex = 1;
            this.ShwallBtn.Text = "Show";
            this.ShwallBtn.UseVisualStyleBackColor = true;
            this.ShwallBtn.Click += new System.EventHandler(this.ShwallBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Show All Data Gathered from Contact Tracing";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(482, 446);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShwallBtn);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ShwallBtn;
        private System.Windows.Forms.Label label1;
    }
}