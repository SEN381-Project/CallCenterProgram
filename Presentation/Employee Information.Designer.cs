namespace CallCenterProgram
{
    partial class Employee_Information
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
            this.btnTechnicianHP = new System.Windows.Forms.Button();
            this.btnEmployeeHP = new System.Windows.Forms.Button();
            this.btnManagerHP = new System.Windows.Forms.Button();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximizeToggle = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHomePageHP = new System.Windows.Forms.Button();
            this.pnlTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 58);
            this.label1.TabIndex = 24;
            this.label1.Text = "Employee Information";
            // 
            // btnTechnicianHP
            // 
            this.btnTechnicianHP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTechnicianHP.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTechnicianHP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.btnTechnicianHP.Location = new System.Drawing.Point(89, 305);
            this.btnTechnicianHP.Name = "btnTechnicianHP";
            this.btnTechnicianHP.Size = new System.Drawing.Size(301, 61);
            this.btnTechnicianHP.TabIndex = 28;
            this.btnTechnicianHP.Text = " Technician";
            this.btnTechnicianHP.UseVisualStyleBackColor = true;
            // 
            // btnEmployeeHP
            // 
            this.btnEmployeeHP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeHP.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeHP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.btnEmployeeHP.Location = new System.Drawing.Point(89, 177);
            this.btnEmployeeHP.Name = "btnEmployeeHP";
            this.btnEmployeeHP.Size = new System.Drawing.Size(301, 62);
            this.btnEmployeeHP.TabIndex = 27;
            this.btnEmployeeHP.Text = "Employee";
            this.btnEmployeeHP.UseVisualStyleBackColor = true;
            this.btnEmployeeHP.Click += new System.EventHandler(this.btnEmployeeHP_Click);
            // 
            // btnManagerHP
            // 
            this.btnManagerHP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagerHP.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagerHP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.btnManagerHP.Location = new System.Drawing.Point(89, 236);
            this.btnManagerHP.Name = "btnManagerHP";
            this.btnManagerHP.Size = new System.Drawing.Size(301, 63);
            this.btnManagerHP.TabIndex = 26;
            this.btnManagerHP.Text = "Manager";
            this.btnManagerHP.UseVisualStyleBackColor = true;
            this.btnManagerHP.Click += new System.EventHandler(this.btnManagerHP_Click);
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlTitleBar.Controls.Add(this.btnMinimize);
            this.pnlTitleBar.Controls.Add(this.btnMaximizeToggle);
            this.pnlTitleBar.Controls.Add(this.btnExit);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(516, 56);
            this.pnlTitleBar.TabIndex = 29;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnMinimize.BackgroundImage = global::CallCenterProgram.Properties.Resources.callcenterminimize;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.Black;
            this.btnMinimize.Location = new System.Drawing.Point(295, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(75, 56);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.UseVisualStyleBackColor = false;
            // 
            // btnMaximizeToggle
            // 
            this.btnMaximizeToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnMaximizeToggle.BackgroundImage = global::CallCenterProgram.Properties.Resources.callcentermaximize;
            this.btnMaximizeToggle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximizeToggle.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximizeToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizeToggle.ForeColor = System.Drawing.Color.Black;
            this.btnMaximizeToggle.Location = new System.Drawing.Point(370, 0);
            this.btnMaximizeToggle.Name = "btnMaximizeToggle";
            this.btnMaximizeToggle.Size = new System.Drawing.Size(75, 56);
            this.btnMaximizeToggle.TabIndex = 4;
            this.btnMaximizeToggle.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.BackgroundImage = global::CallCenterProgram.Properties.Resources.callcenterexit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(445, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(71, 56);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnHomePageHP
            // 
            this.btnHomePageHP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomePageHP.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomePageHP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.btnHomePageHP.Location = new System.Drawing.Point(89, 362);
            this.btnHomePageHP.Name = "btnHomePageHP";
            this.btnHomePageHP.Size = new System.Drawing.Size(301, 66);
            this.btnHomePageHP.TabIndex = 30;
            this.btnHomePageHP.Text = "Home Page";
            this.btnHomePageHP.UseVisualStyleBackColor = true;
            this.btnHomePageHP.Click += new System.EventHandler(this.btnHomePageHP_Click);
            // 
            // Employee_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(516, 450);
            this.Controls.Add(this.btnHomePageHP);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.btnTechnicianHP);
            this.Controls.Add(this.btnEmployeeHP);
            this.Controls.Add(this.btnManagerHP);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee_Information";
            this.Text = "Employee_Information";
            this.pnlTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTechnicianHP;
        private System.Windows.Forms.Button btnEmployeeHP;
        private System.Windows.Forms.Button btnManagerHP;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximizeToggle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHomePageHP;
    }
}