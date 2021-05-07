
namespace CallCenterProgram.Presentation
{
    partial class PackagePerformance
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvBestPackageOfTheMonth = new System.Windows.Forms.DataGridView();
            this.btnSearchPackage = new System.Windows.Forms.Button();
            this.txtSearchPackage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pbActive = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotalPackages = new System.Windows.Forms.Label();
            this.lblActivePackagesMonthly = new System.Windows.Forms.Label();
            this.dgvPackageByCity = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.lblResolutionTime = new System.Windows.Forms.Label();
            this.lblBusinessClients = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pbPercentBusinessClients = new System.Windows.Forms.ProgressBar();
            this.label12 = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.btnFilterDataByDate = new System.Windows.Forms.Button();
            this.btnBackToPackage = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblBestNumbersSold = new System.Windows.Forms.Label();
            this.PackageSales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBestPackageOfTheMonth)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackageByCity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Number Of Packages\r\n                Bought";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(420, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(405, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Number Of Active Packages";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(852, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(450, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Best Perfoming Package of the Month";
            // 
            // dgvBestPackageOfTheMonth
            // 
            this.dgvBestPackageOfTheMonth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBestPackageOfTheMonth.Location = new System.Drawing.Point(855, 92);
            this.dgvBestPackageOfTheMonth.Name = "dgvBestPackageOfTheMonth";
            this.dgvBestPackageOfTheMonth.RowHeadersWidth = 51;
            this.dgvBestPackageOfTheMonth.RowTemplate.Height = 24;
            this.dgvBestPackageOfTheMonth.Size = new System.Drawing.Size(658, 202);
            this.dgvBestPackageOfTheMonth.TabIndex = 5;
            // 
            // btnSearchPackage
            // 
            this.btnSearchPackage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.btnSearchPackage.Location = new System.Drawing.Point(888, 371);
            this.btnSearchPackage.Name = "btnSearchPackage";
            this.btnSearchPackage.Size = new System.Drawing.Size(147, 48);
            this.btnSearchPackage.TabIndex = 68;
            this.btnSearchPackage.Text = "SEARCH PACKAGE";
            this.btnSearchPackage.UseVisualStyleBackColor = true;
            this.btnSearchPackage.Click += new System.EventHandler(this.btnSearchPackage_Click);
            // 
            // txtSearchPackage
            // 
            this.txtSearchPackage.Location = new System.Drawing.Point(458, 384);
            this.txtSearchPackage.Name = "txtSearchPackage";
            this.txtSearchPackage.Size = new System.Drawing.Size(324, 22);
            this.txtSearchPackage.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.label5.Location = new System.Drawing.Point(249, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 21);
            this.label5.TabIndex = 66;
            this.label5.Text = "Enter Package ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(248, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 29);
            this.label4.TabIndex = 69;
            this.label4.Text = "Package Performance:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(248, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 29);
            this.label6.TabIndex = 71;
            this.label6.Text = "Sales by City:";
            // 
            // pbActive
            // 
            this.pbActive.Location = new System.Drawing.Point(435, 109);
            this.pbActive.MarqueeAnimationSpeed = 1;
            this.pbActive.Name = "pbActive";
            this.pbActive.Size = new System.Drawing.Size(364, 23);
            this.pbActive.Step = 1;
            this.pbActive.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbActive.TabIndex = 72;
            this.pbActive.Value = 45;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBestNumbersSold);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblTotalPackages);
            this.groupBox1.Controls.Add(this.lblActivePackagesMonthly);
            this.groupBox1.Controls.Add(this.pbActive);
            this.groupBox1.Controls.Add(this.dgvBestPackageOfTheMonth);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.groupBox1.Location = new System.Drawing.Point(33, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1711, 323);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Montly Performance Values";
            // 
            // lblTotalPackages
            // 
            this.lblTotalPackages.AutoSize = true;
            this.lblTotalPackages.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPackages.Location = new System.Drawing.Point(140, 109);
            this.lblTotalPackages.Name = "lblTotalPackages";
            this.lblTotalPackages.Size = new System.Drawing.Size(98, 69);
            this.lblTotalPackages.TabIndex = 74;
            this.lblTotalPackages.Text = "60";
            // 
            // lblActivePackagesMonthly
            // 
            this.lblActivePackagesMonthly.AutoSize = true;
            this.lblActivePackagesMonthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivePackagesMonthly.Location = new System.Drawing.Point(589, 149);
            this.lblActivePackagesMonthly.Name = "lblActivePackagesMonthly";
            this.lblActivePackagesMonthly.Size = new System.Drawing.Size(55, 38);
            this.lblActivePackagesMonthly.TabIndex = 73;
            this.lblActivePackagesMonthly.Text = "45";
            // 
            // dgvPackageByCity
            // 
            this.dgvPackageByCity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackageByCity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PackageSales,
            this.City});
            this.dgvPackageByCity.Location = new System.Drawing.Point(253, 476);
            this.dgvPackageByCity.Name = "dgvPackageByCity";
            this.dgvPackageByCity.RowHeadersWidth = 51;
            this.dgvPackageByCity.RowTemplate.Height = 24;
            this.dgvPackageByCity.Size = new System.Drawing.Size(509, 150);
            this.dgvPackageByCity.TabIndex = 74;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(788, 437);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(423, 29);
            this.label8.TabIndex = 75;
            this.label8.Text = "Average Package Resolution Time:";
            // 
            // lblResolutionTime
            // 
            this.lblResolutionTime.AutoSize = true;
            this.lblResolutionTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResolutionTime.Location = new System.Drawing.Point(862, 499);
            this.lblResolutionTime.Name = "lblResolutionTime";
            this.lblResolutionTime.Size = new System.Drawing.Size(297, 69);
            this.lblResolutionTime.TabIndex = 75;
            this.lblResolutionTime.Text = "5 minutes";
            // 
            // lblBusinessClients
            // 
            this.lblBusinessClients.AutoSize = true;
            this.lblBusinessClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusinessClients.Location = new System.Drawing.Point(1386, 499);
            this.lblBusinessClients.Name = "lblBusinessClients";
            this.lblBusinessClients.Size = new System.Drawing.Size(98, 69);
            this.lblBusinessClients.TabIndex = 76;
            this.lblBusinessClients.Text = "40";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1307, 408);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(231, 58);
            this.label11.TabIndex = 77;
            this.label11.Text = "% Business Client \r\n   Using Package:";
            // 
            // pbPercentBusinessClients
            // 
            this.pbPercentBusinessClients.Location = new System.Drawing.Point(1312, 585);
            this.pbPercentBusinessClients.Name = "pbPercentBusinessClients";
            this.pbPercentBusinessClients.Size = new System.Drawing.Size(236, 23);
            this.pbPercentBusinessClients.TabIndex = 75;
            this.pbPercentBusinessClients.Value = 40;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(248, 675);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(173, 29);
            this.label12.TabIndex = 78;
            this.label12.Text = "Filter by date:";
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(415, 729);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(200, 22);
            this.dateStart.TabIndex = 79;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.label13.Location = new System.Drawing.Point(249, 729);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 21);
            this.label13.TabIndex = 80;
            this.label13.Text = "Enter Start Date:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.label14.Location = new System.Drawing.Point(667, 730);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 21);
            this.label14.TabIndex = 82;
            this.label14.Text = "Enter End Date:";
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(833, 730);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(200, 22);
            this.dateEnd.TabIndex = 81;
            // 
            // btnFilterDataByDate
            // 
            this.btnFilterDataByDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.btnFilterDataByDate.Location = new System.Drawing.Point(1161, 719);
            this.btnFilterDataByDate.Name = "btnFilterDataByDate";
            this.btnFilterDataByDate.Size = new System.Drawing.Size(220, 48);
            this.btnFilterDataByDate.TabIndex = 83;
            this.btnFilterDataByDate.Text = "FILTER PACKAGE DATA";
            this.btnFilterDataByDate.UseVisualStyleBackColor = true;
            // 
            // btnBackToPackage
            // 
            this.btnBackToPackage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.btnBackToPackage.Location = new System.Drawing.Point(695, 818);
            this.btnBackToPackage.Name = "btnBackToPackage";
            this.btnBackToPackage.Size = new System.Drawing.Size(454, 48);
            this.btnBackToPackage.TabIndex = 84;
            this.btnBackToPackage.Text = "BACK TO PACKAGE FORM";
            this.btnBackToPackage.UseVisualStyleBackColor = true;
            this.btnBackToPackage.Click += new System.EventHandler(this.btnBackToPackage_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1549, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 58);
            this.label7.TabIndex = 75;
            this.label7.Text = "Numbers \r\n    Sold";
            // 
            // lblBestNumbersSold
            // 
            this.lblBestNumbersSold.AutoSize = true;
            this.lblBestNumbersSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestNumbersSold.Location = new System.Drawing.Point(1564, 149);
            this.lblBestNumbersSold.Name = "lblBestNumbersSold";
            this.lblBestNumbersSold.Size = new System.Drawing.Size(98, 69);
            this.lblBestNumbersSold.TabIndex = 76;
            this.lblBestNumbersSold.Text = "60";
            // 
            // PackageSales
            // 
            this.PackageSales.HeaderText = "Package Sales";
            this.PackageSales.MinimumWidth = 10;
            this.PackageSales.Name = "PackageSales";
            this.PackageSales.Width = 125;
            // 
            // City
            // 
            this.City.HeaderText = "City";
            this.City.MinimumWidth = 12;
            this.City.Name = "City";
            this.City.Width = 125;
            // 
            // PackagePerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1797, 895);
            this.Controls.Add(this.btnBackToPackage);
            this.Controls.Add(this.btnFilterDataByDate);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pbPercentBusinessClients);
            this.Controls.Add(this.lblBusinessClients);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblResolutionTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvPackageByCity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSearchPackage);
            this.Controls.Add(this.txtSearchPackage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.Name = "PackagePerformance";
            this.Text = "PackagePerformance";
            this.Load += new System.EventHandler(this.PackagePerformance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBestPackageOfTheMonth)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackageByCity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvBestPackageOfTheMonth;
        private System.Windows.Forms.Button btnSearchPackage;
        private System.Windows.Forms.TextBox txtSearchPackage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar pbActive;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotalPackages;
        private System.Windows.Forms.Label lblActivePackagesMonthly;
        private System.Windows.Forms.DataGridView dgvPackageByCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblResolutionTime;
        private System.Windows.Forms.Label lblBusinessClients;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ProgressBar pbPercentBusinessClients;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Button btnFilterDataByDate;
        private System.Windows.Forms.Button btnBackToPackage;
        private System.Windows.Forms.Label lblBestNumbersSold;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackageSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
    }
}