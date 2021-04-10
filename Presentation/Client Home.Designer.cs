
namespace CallCenterProgram
{
    partial class Client_Home
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
            this.btnViewBusinessClients = new System.Windows.Forms.Button();
            this.btnViewIndividualClients = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewBusinessClients
            // 
            this.btnViewBusinessClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewBusinessClients.Location = new System.Drawing.Point(28, 25);
            this.btnViewBusinessClients.Name = "btnViewBusinessClients";
            this.btnViewBusinessClients.Size = new System.Drawing.Size(150, 43);
            this.btnViewBusinessClients.TabIndex = 0;
            this.btnViewBusinessClients.Text = "View Business Clients";
            this.btnViewBusinessClients.UseVisualStyleBackColor = true;
            // 
            // btnViewIndividualClients
            // 
            this.btnViewIndividualClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewIndividualClients.Location = new System.Drawing.Point(196, 25);
            this.btnViewIndividualClients.Name = "btnViewIndividualClients";
            this.btnViewIndividualClients.Size = new System.Drawing.Size(150, 43);
            this.btnViewIndividualClients.TabIndex = 1;
            this.btnViewIndividualClients.Text = "View Individual Clients";
            this.btnViewIndividualClients.UseVisualStyleBackColor = true;
            // 
            // btnMain
            // 
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMain.Location = new System.Drawing.Point(28, 84);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(318, 23);
            this.btnMain.TabIndex = 2;
            this.btnMain.Text = "Main Page";
            this.btnMain.UseVisualStyleBackColor = true;
            // 
            // Client_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(378, 199);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnViewIndividualClients);
            this.Controls.Add(this.btnViewBusinessClients);
            this.Font = new System.Drawing.Font("Roboto Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.Name = "Client_Home";
            this.Text = "Client_Home";
            this.Load += new System.EventHandler(this.Client_Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewBusinessClients;
        private System.Windows.Forms.Button btnViewIndividualClients;
        private System.Windows.Forms.Button btnMain;
    }
}