namespace CallCenterProgram
{
    partial class Form1
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
            this.btnTesting = new System.Windows.Forms.Button();
            this.btnClientHome = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTesting
            // 
            this.btnTesting.Location = new System.Drawing.Point(205, 298);
            this.btnTesting.Margin = new System.Windows.Forms.Padding(2);
            this.btnTesting.Name = "btnTesting";
            this.btnTesting.Size = new System.Drawing.Size(149, 58);
            this.btnTesting.TabIndex = 0;
            this.btnTesting.Text = "TESTING";
            this.btnTesting.UseVisualStyleBackColor = true;
            this.btnTesting.Click += new System.EventHandler(this.btnTesting_Click);
            // 
            // btnClientHome
            // 
            this.btnClientHome.Location = new System.Drawing.Point(12, 13);
            this.btnClientHome.Name = "btnClientHome";
            this.btnClientHome.Size = new System.Drawing.Size(75, 23);
            this.btnClientHome.TabIndex = 1;
            this.btnClientHome.Text = "ClientHome";
            this.btnClientHome.UseVisualStyleBackColor = true;
            this.btnClientHome.Click += new System.EventHandler(this.btnClientHome_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(517, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(71, 62);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClientHome);
            this.Controls.Add(this.btnTesting);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTesting;
        private System.Windows.Forms.Button btnClientHome;
        private System.Windows.Forms.Button btnExit;
    }
}

