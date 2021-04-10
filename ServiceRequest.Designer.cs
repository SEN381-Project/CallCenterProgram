namespace CallCenterProgram
{
    partial class frmServiceRequest
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvIncident = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIncidentID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCreateJob = new System.Windows.Forms.Button();
            this.btnEscalateJob = new System.Windows.Forms.Button();
            this.btnReassignJob = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncident)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Roboto", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(245, 19);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(279, 46);
            this.lblHeading.TabIndex = 1;
            this.lblHeading.Text = "Service Request";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtIncidentID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dgvIncident);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(36, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 303);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "View";
            // 
            // dgvIncident
            // 
            this.dgvIncident.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncident.Location = new System.Drawing.Point(19, 41);
            this.dgvIncident.Name = "dgvIncident";
            this.dgvIncident.Size = new System.Drawing.Size(705, 228);
            this.dgvIncident.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(402, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Incident ID:";
            // 
            // txtIncidentID
            // 
            this.txtIncidentID.Location = new System.Drawing.Point(525, 275);
            this.txtIncidentID.Name = "txtIncidentID";
            this.txtIncidentID.Size = new System.Drawing.Size(118, 20);
            this.txtIncidentID.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(649, 273);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnCreateJob
            // 
            this.btnCreateJob.Location = new System.Drawing.Point(36, 405);
            this.btnCreateJob.Name = "btnCreateJob";
            this.btnCreateJob.Size = new System.Drawing.Size(200, 23);
            this.btnCreateJob.TabIndex = 7;
            this.btnCreateJob.Text = "Create Job";
            this.btnCreateJob.UseVisualStyleBackColor = true;
            // 
            // btnEscalateJob
            // 
            this.btnEscalateJob.Location = new System.Drawing.Point(579, 405);
            this.btnEscalateJob.Name = "btnEscalateJob";
            this.btnEscalateJob.Size = new System.Drawing.Size(200, 23);
            this.btnEscalateJob.TabIndex = 8;
            this.btnEscalateJob.Text = "Escalate Job";
            this.btnEscalateJob.UseVisualStyleBackColor = true;
            // 
            // btnReassignJob
            // 
            this.btnReassignJob.Location = new System.Drawing.Point(307, 405);
            this.btnReassignJob.Name = "btnReassignJob";
            this.btnReassignJob.Size = new System.Drawing.Size(200, 23);
            this.btnReassignJob.TabIndex = 9;
            this.btnReassignJob.Text = "Re-Assign Job";
            this.btnReassignJob.UseVisualStyleBackColor = true;
            // 
            // frmServiceRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReassignJob);
            this.Controls.Add(this.btnEscalateJob);
            this.Controls.Add(this.btnCreateJob);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblHeading);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmServiceRequest";
            this.Text = "Service Request";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncident)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtIncidentID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvIncident;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateJob;
        private System.Windows.Forms.Button btnEscalateJob;
        private System.Windows.Forms.Button btnReassignJob;
    }
}