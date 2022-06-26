namespace Contact_Tracing
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
            this.lblbydate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblbydate
            // 
            this.lblbydate.AutoSize = true;
            this.lblbydate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbydate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(89)))), ((int)(((byte)(94)))));
            this.lblbydate.Location = new System.Drawing.Point(56, 42);
            this.lblbydate.Name = "lblbydate";
            this.lblbydate.Size = new System.Drawing.Size(0, 19);
            this.lblbydate.TabIndex = 0;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(214)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(281, 475);
            this.Controls.Add(this.lblbydate);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbydate;
    }
}