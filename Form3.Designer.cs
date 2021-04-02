namespace CallCenterProgram
{
    partial class Form3
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
            this.txtq = new System.Windows.Forms.TextBox();
            this.txtability = new System.Windows.Forms.TextBox();
            this.DeleteT = new System.Windows.Forms.Button();
            this.UpdateT = new System.Windows.Forms.Button();
            this.InsertT = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAbilities = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MainMenu = new System.Windows.Forms.Button();
            this.Employee = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtq);
            this.groupBox1.Controls.Add(this.txtability);
            this.groupBox1.Controls.Add(this.DeleteT);
            this.groupBox1.Controls.Add(this.UpdateT);
            this.groupBox1.Controls.Add(this.InsertT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAbilities);
            this.groupBox1.Location = new System.Drawing.Point(41, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Technician";
            // 
            // txtq
            // 
            this.txtq.Location = new System.Drawing.Point(115, 113);
            this.txtq.Name = "txtq";
            this.txtq.Size = new System.Drawing.Size(100, 20);
            this.txtq.TabIndex = 6;
            // 
            // txtability
            // 
            this.txtability.Location = new System.Drawing.Point(115, 60);
            this.txtability.Name = "txtability";
            this.txtability.Size = new System.Drawing.Size(100, 20);
            this.txtability.TabIndex = 5;
            // 
            // DeleteT
            // 
            this.DeleteT.Location = new System.Drawing.Point(282, 190);
            this.DeleteT.Name = "DeleteT";
            this.DeleteT.Size = new System.Drawing.Size(75, 23);
            this.DeleteT.TabIndex = 4;
            this.DeleteT.Text = "Delete";
            this.DeleteT.UseVisualStyleBackColor = true;
            this.DeleteT.Click += new System.EventHandler(this.DeleteT_Click);
            // 
            // UpdateT
            // 
            this.UpdateT.Location = new System.Drawing.Point(163, 191);
            this.UpdateT.Name = "UpdateT";
            this.UpdateT.Size = new System.Drawing.Size(75, 23);
            this.UpdateT.TabIndex = 3;
            this.UpdateT.Text = "Update";
            this.UpdateT.UseVisualStyleBackColor = true;
            this.UpdateT.Click += new System.EventHandler(this.UpdateT_Click);
            // 
            // InsertT
            // 
            this.InsertT.Location = new System.Drawing.Point(19, 191);
            this.InsertT.Name = "InsertT";
            this.InsertT.Size = new System.Drawing.Size(75, 23);
            this.InsertT.TabIndex = 2;
            this.InsertT.Text = "Insert";
            this.InsertT.UseVisualStyleBackColor = true;
            this.InsertT.Click += new System.EventHandler(this.InsertT_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Qualification";
            // 
            // txtAbilities
            // 
            this.txtAbilities.AutoSize = true;
            this.txtAbilities.Location = new System.Drawing.Point(30, 68);
            this.txtAbilities.Name = "txtAbilities";
            this.txtAbilities.Size = new System.Drawing.Size(42, 13);
            this.txtAbilities.TabIndex = 0;
            this.txtAbilities.Text = "Abilities";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Technician Form";
            // 
            // MainMenu
            // 
            this.MainMenu.Location = new System.Drawing.Point(41, 378);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(75, 23);
            this.MainMenu.TabIndex = 2;
            this.MainMenu.Text = "MainMenu";
            this.MainMenu.UseVisualStyleBackColor = true;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // Employee
            // 
            this.Employee.Location = new System.Drawing.Point(204, 377);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(75, 23);
            this.Employee.TabIndex = 3;
            this.Employee.Text = "Employee";
            this.Employee.UseVisualStyleBackColor = true;
            this.Employee.Click += new System.EventHandler(this.Employee_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(657, 377);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exits";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Employee);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtq;
        private System.Windows.Forms.TextBox txtability;
        private System.Windows.Forms.Button DeleteT;
        private System.Windows.Forms.Button UpdateT;
        private System.Windows.Forms.Button InsertT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtAbilities;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.Button Employee;
        private System.Windows.Forms.Button Exit;
    }
}