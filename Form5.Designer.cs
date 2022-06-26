namespace Contact_Tracing
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
            this.lbldsgn = new System.Windows.Forms.Label();
            this.Passtbox = new System.Windows.Forms.TextBox();
            this.Usertbox = new System.Windows.Forms.TextBox();
            this.userlbl = new System.Windows.Forms.Label();
            this.passlbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Sbmtbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbldsgn
            // 
            this.lbldsgn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(89)))), ((int)(((byte)(94)))));
            this.lbldsgn.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldsgn.ForeColor = System.Drawing.Color.White;
            this.lbldsgn.Location = new System.Drawing.Point(12, 28);
            this.lbldsgn.Name = "lbldsgn";
            this.lbldsgn.Size = new System.Drawing.Size(266, 78);
            this.lbldsgn.TabIndex = 0;
            this.lbldsgn.Text = "Login to your Admin Account";
            this.lbldsgn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Passtbox
            // 
            this.Passtbox.Location = new System.Drawing.Point(122, 168);
            this.Passtbox.Name = "Passtbox";
            this.Passtbox.Size = new System.Drawing.Size(122, 20);
            this.Passtbox.TabIndex = 1;
            // 
            // Usertbox
            // 
            this.Usertbox.Location = new System.Drawing.Point(122, 142);
            this.Usertbox.Name = "Usertbox";
            this.Usertbox.Size = new System.Drawing.Size(122, 20);
            this.Usertbox.TabIndex = 2;
            // 
            // userlbl
            // 
            this.userlbl.AutoSize = true;
            this.userlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(89)))), ((int)(((byte)(94)))));
            this.userlbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlbl.ForeColor = System.Drawing.Color.White;
            this.userlbl.Location = new System.Drawing.Point(46, 145);
            this.userlbl.Name = "userlbl";
            this.userlbl.Size = new System.Drawing.Size(62, 15);
            this.userlbl.TabIndex = 3;
            this.userlbl.Text = "Username";
            // 
            // passlbl
            // 
            this.passlbl.AutoSize = true;
            this.passlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(89)))), ((int)(((byte)(94)))));
            this.passlbl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlbl.ForeColor = System.Drawing.Color.White;
            this.passlbl.Location = new System.Drawing.Point(46, 168);
            this.passlbl.Name = "passlbl";
            this.passlbl.Size = new System.Drawing.Size(59, 15);
            this.passlbl.TabIndex = 4;
            this.passlbl.Text = "Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(89)))), ((int)(((byte)(94)))));
            this.pictureBox1.Location = new System.Drawing.Point(12, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 74);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Sbmtbtn
            // 
            this.Sbmtbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(89)))), ((int)(((byte)(94)))));
            this.Sbmtbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sbmtbtn.ForeColor = System.Drawing.Color.White;
            this.Sbmtbtn.Location = new System.Drawing.Point(203, 204);
            this.Sbmtbtn.Name = "Sbmtbtn";
            this.Sbmtbtn.Size = new System.Drawing.Size(75, 31);
            this.Sbmtbtn.TabIndex = 6;
            this.Sbmtbtn.Text = "Submit";
            this.Sbmtbtn.UseVisualStyleBackColor = false;
            this.Sbmtbtn.Click += new System.EventHandler(this.Sbmtbtn_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(214)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(292, 237);
            this.Controls.Add(this.Sbmtbtn);
            this.Controls.Add(this.passlbl);
            this.Controls.Add(this.userlbl);
            this.Controls.Add(this.Usertbox);
            this.Controls.Add(this.Passtbox);
            this.Controls.Add(this.lbldsgn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldsgn;
        private System.Windows.Forms.TextBox Passtbox;
        private System.Windows.Forms.TextBox Usertbox;
        private System.Windows.Forms.Label passlbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label userlbl;
        private System.Windows.Forms.Button Sbmtbtn;
    }
}