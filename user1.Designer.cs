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
            this.components = new System.ComponentModel.Container();
            this.Scanner = new System.Windows.Forms.PictureBox();
            this.userlbl = new System.Windows.Forms.Label();
            this.StartBTN = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Devices = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Scanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Scanner
            // 
            this.Scanner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Scanner.ImageLocation = "";
            this.Scanner.Location = new System.Drawing.Point(182, 298);
            this.Scanner.Name = "Scanner";
            this.Scanner.Size = new System.Drawing.Size(375, 318);
            this.Scanner.TabIndex = 0;
            this.Scanner.TabStop = false;
            // 
            // userlbl
            // 
            this.userlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(89)))), ((int)(((byte)(94)))));
            this.userlbl.Font = new System.Drawing.Font("Segoe Script", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlbl.ForeColor = System.Drawing.Color.White;
            this.userlbl.Location = new System.Drawing.Point(42, 9);
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
            this.StartBTN.Location = new System.Drawing.Point(296, 661);
            this.StartBTN.Name = "StartBTN";
            this.StartBTN.Size = new System.Drawing.Size(141, 58);
            this.StartBTN.TabIndex = 41;
            this.StartBTN.Text = "Start";
            this.StartBTN.UseVisualStyleBackColor = false;
            this.StartBTN.Click += new System.EventHandler(this.StartBTN_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(89)))), ((int)(((byte)(94)))));
            this.pictureBox2.Location = new System.Drawing.Point(157, 269);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(430, 377);
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // Devices
            // 
            this.Devices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Devices.FormattingEnabled = true;
            this.Devices.Location = new System.Drawing.Point(262, 232);
            this.Devices.Name = "Devices";
            this.Devices.Size = new System.Drawing.Size(201, 21);
            this.Devices.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(89)))), ((int)(((byte)(94)))));
            this.label1.Location = new System.Drawing.Point(294, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 37);
            this.label1.TabIndex = 44;
            this.label1.Text = "Camera";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // user1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(214)))), ((int)(((byte)(211)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Devices);
            this.Controls.Add(this.StartBTN);
            this.Controls.Add(this.userlbl);
            this.Controls.Add(this.Scanner);
            this.Controls.Add(this.pictureBox2);
            this.Name = "user1";
            this.Size = new System.Drawing.Size(731, 722);
            this.Load += new System.EventHandler(this.user1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Scanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Scanner;
        private System.Windows.Forms.Label userlbl;
        private System.Windows.Forms.Button StartBTN;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox Devices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}
