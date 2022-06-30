namespace Contact_Tracing
{
    partial class user1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userlbl = new System.Windows.Forms.Label();
            this.StartBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(135, 211);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(453, 431);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // userlbl
            // 
            this.userlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(89)))), ((int)(((byte)(94)))));
            this.userlbl.Font = new System.Drawing.Font("Segoe Script", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlbl.ForeColor = System.Drawing.Color.White;
            this.userlbl.Location = new System.Drawing.Point(43, 17);
            this.userlbl.Name = "userlbl";
            this.userlbl.Size = new System.Drawing.Size(641, 177);
            this.userlbl.TabIndex = 40;
            this.userlbl.Text = "Scan your Qr Code Here";
            this.userlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartBTN
            // 
            this.StartBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(89)))), ((int)(((byte)(94)))));
            this.StartBTN.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBTN.ForeColor = System.Drawing.Color.White;
            this.StartBTN.Location = new System.Drawing.Point(296, 652);
            this.StartBTN.Name = "StartBTN";
            this.StartBTN.Size = new System.Drawing.Size(141, 58);
            this.StartBTN.TabIndex = 41;
            this.StartBTN.Text = "Start";
            this.StartBTN.UseVisualStyleBackColor = false;
            // 
            // user1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(214)))), ((int)(((byte)(211)))));
            this.Controls.Add(this.StartBTN);
            this.Controls.Add(this.userlbl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "user1";
            this.Size = new System.Drawing.Size(731, 722);
            this.Load += new System.EventHandler(this.user1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label userlbl;
        private System.Windows.Forms.Button StartBTN;
    }
}
