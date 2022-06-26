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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.ShwallBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.datebtn = new System.Windows.Forms.Button();
            this.frm2Date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ShwallBtn
            // 
            this.ShwallBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShwallBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(89)))), ((int)(((byte)(94)))));
            this.ShwallBtn.Location = new System.Drawing.Point(83, 101);
            this.ShwallBtn.Name = "ShwallBtn";
            this.ShwallBtn.Size = new System.Drawing.Size(96, 58);
            this.ShwallBtn.TabIndex = 1;
            this.ShwallBtn.Text = "Show";
            this.ShwallBtn.UseVisualStyleBackColor = true;
            this.ShwallBtn.Click += new System.EventHandler(this.ShwallBtn_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(89)))), ((int)(((byte)(94)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 138);
            this.label1.TabIndex = 2;
            this.label1.Text = "Show All Records from Contact Tracing";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // datebtn
            // 
            this.datebtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(89)))), ((int)(((byte)(94)))));
            this.datebtn.Location = new System.Drawing.Point(83, 302);
            this.datebtn.Name = "datebtn";
            this.datebtn.Size = new System.Drawing.Size(96, 60);
            this.datebtn.TabIndex = 3;
            this.datebtn.Text = "Submit";
            this.datebtn.UseVisualStyleBackColor = true;
            this.datebtn.Click += new System.EventHandler(this.datebtn_Click);
            // 
            // frm2Date
            // 
            this.frm2Date.CustomFormat = "MM/dd/yyyy";
            this.frm2Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.frm2Date.Location = new System.Drawing.Point(83, 250);
            this.frm2Date.Name = "frm2Date";
            this.frm2Date.Size = new System.Drawing.Size(110, 20);
            this.frm2Date.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(89)))), ((int)(((byte)(94)))));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 202);
            this.label2.TabIndex = 6;
            this.label2.Text = "Show All Records by Date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(214)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(267, 421);
            this.Controls.Add(this.frm2Date);
            this.Controls.Add(this.datebtn);
            this.Controls.Add(this.ShwallBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "ADMIN";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ShwallBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button datebtn;
        private System.Windows.Forms.DateTimePicker frm2Date;
        private System.Windows.Forms.Label label2;
    }
}