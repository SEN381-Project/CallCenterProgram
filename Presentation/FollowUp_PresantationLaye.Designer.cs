﻿namespace CallCenterProgram
{
    partial class FollowUp_PresantationLayer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtfollupD = new System.Windows.Forms.TextBox();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.txtfollowupid = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MainMenu = new System.Windows.Forms.Button();
            this.Exits = new System.Windows.Forms.Button();
            this.Feedback = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSetReminder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtfollupD);
            this.groupBox1.Controls.Add(this.txtstatus);
            this.groupBox1.Controls.Add(this.txtfollowupid);
            this.groupBox1.Controls.Add(this.Delete);
            this.groupBox1.Controls.Add(this.Update);
            this.groupBox1.Controls.Add(this.Insert);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox1.Location = new System.Drawing.Point(599, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 293);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FollowUp";
            // 
            // txtfollupD
            // 
            this.txtfollupD.Location = new System.Drawing.Point(8, 164);
            this.txtfollupD.Name = "txtfollupD";
            this.txtfollupD.Size = new System.Drawing.Size(100, 27);
            this.txtfollupD.TabIndex = 8;
            // 
            // txtstatus
            // 
            this.txtstatus.Location = new System.Drawing.Point(6, 112);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(100, 27);
            this.txtstatus.TabIndex = 7;
            // 
            // txtfollowupid
            // 
            this.txtfollowupid.Location = new System.Drawing.Point(6, 54);
            this.txtfollowupid.Name = "txtfollowupid";
            this.txtfollowupid.Size = new System.Drawing.Size(100, 27);
            this.txtfollowupid.TabIndex = 6;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.SystemColors.Desktop;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Location = new System.Drawing.Point(8, 253);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(100, 40);
            this.Delete.TabIndex = 5;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.SystemColors.Desktop;
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update.Location = new System.Drawing.Point(8, 222);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(100, 31);
            this.Update.TabIndex = 4;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Insert
            // 
            this.Insert.BackColor = System.Drawing.SystemColors.Desktop;
            this.Insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Insert.Location = new System.Drawing.Point(8, 187);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(100, 38);
            this.Insert.TabIndex = 3;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = false;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "FollowUpDate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "FollowUpId:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(2, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 293);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(598, 293);
            this.dataGridView1.TabIndex = 0;
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.SystemColors.Desktop;
            this.MainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainMenu.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu.Location = new System.Drawing.Point(2, 404);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(95, 46);
            this.MainMenu.TabIndex = 3;
            this.MainMenu.Text = "MainMenu";
            this.MainMenu.UseVisualStyleBackColor = false;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // Exits
            // 
            this.Exits.BackColor = System.Drawing.SystemColors.Desktop;
            this.Exits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exits.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exits.Location = new System.Drawing.Point(700, 404);
            this.Exits.Name = "Exits";
            this.Exits.Size = new System.Drawing.Size(99, 46);
            this.Exits.TabIndex = 4;
            this.Exits.Text = "Exits";
            this.Exits.UseVisualStyleBackColor = false;
            this.Exits.Click += new System.EventHandler(this.Exits_Click);
            // 
            // Feedback
            // 
            this.Feedback.BackColor = System.Drawing.SystemColors.Desktop;
            this.Feedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Feedback.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Feedback.Location = new System.Drawing.Point(119, 404);
            this.Feedback.Name = "Feedback";
            this.Feedback.Size = new System.Drawing.Size(94, 46);
            this.Feedback.TabIndex = 5;
            this.Feedback.Text = "Feedback";
            this.Feedback.UseVisualStyleBackColor = false;
            this.Feedback.Click += new System.EventHandler(this.Feedback_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(245, -2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 38);
            this.label6.TabIndex = 10;
            this.label6.Text = "FollowUp Form";
            // 
            // btnSetReminder
            // 
            this.btnSetReminder.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnSetReminder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetReminder.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetReminder.Location = new System.Drawing.Point(2, 341);
            this.btnSetReminder.Name = "btnSetReminder";
            this.btnSetReminder.Size = new System.Drawing.Size(797, 62);
            this.btnSetReminder.TabIndex = 11;
            this.btnSetReminder.Text = "Set Reminder";
            this.btnSetReminder.UseVisualStyleBackColor = false;
            this.btnSetReminder.Click += new System.EventHandler(this.btnSetReminder_Click);
            // 
            // FollowUp_PresantationLayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSetReminder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Feedback);
            this.Controls.Add(this.Exits);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FollowUp_PresantationLayer";
            this.Text = "FollowUp";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfollupD;
        private System.Windows.Forms.TextBox txtstatus;
        private System.Windows.Forms.TextBox txtfollowupid;
        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.Button Exits;
        private System.Windows.Forms.Button Feedback;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSetReminder;
    }
}