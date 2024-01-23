
namespace Clinic_Project
{
    partial class Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlHeder = new System.Windows.Forms.Panel();
            this.btnSetting = new System.Windows.Forms.PictureBox();
            this.btnAlert = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.PictureBox();
            this.btnLogo = new System.Windows.Forms.PictureBox();
            this.panel_content = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnlHeder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAlert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.btnInput);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Location = new System.Drawing.Point(0, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 503);
            this.panel1.TabIndex = 0;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.SystemColors.Control;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(0, 140);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(166, 64);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnInput
            // 
            this.btnInput.BackColor = System.Drawing.SystemColors.Control;
            this.btnInput.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInput.Location = new System.Drawing.Point(0, 70);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(166, 64);
            this.btnInput.TabIndex = 1;
            this.btnInput.Text = "Patient";
            this.btnInput.UseVisualStyleBackColor = false;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.SystemColors.Control;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Location = new System.Drawing.Point(-1, 1);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(166, 64);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnlHeder
            // 
            this.pnlHeder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.pnlHeder.Controls.Add(this.btnSetting);
            this.pnlHeder.Controls.Add(this.btnAlert);
            this.pnlHeder.Controls.Add(this.pictureBox2);
            this.pnlHeder.Controls.Add(this.txtSearch);
            this.pnlHeder.Controls.Add(this.btnCancel);
            this.pnlHeder.Controls.Add(this.btnLogo);
            this.pnlHeder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeder.Location = new System.Drawing.Point(0, 0);
            this.pnlHeder.Name = "pnlHeder";
            this.pnlHeder.Size = new System.Drawing.Size(983, 97);
            this.pnlHeder.TabIndex = 0;
            // 
            // btnSetting
            // 
            this.btnSetting.Image = global::Clinic_Project.Properties.Resources.setting;
            this.btnSetting.Location = new System.Drawing.Point(798, 38);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(21, 22);
            this.btnSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSetting.TabIndex = 5;
            this.btnSetting.TabStop = false;
            // 
            // btnAlert
            // 
            this.btnAlert.Image = global::Clinic_Project.Properties.Resources.alert;
            this.btnAlert.Location = new System.Drawing.Point(759, 38);
            this.btnAlert.Name = "btnAlert";
            this.btnAlert.Size = new System.Drawing.Size(21, 22);
            this.btnAlert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAlert.TabIndex = 1;
            this.btnAlert.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::Clinic_Project.Properties.Resources.search2;
            this.pictureBox2.Location = new System.Drawing.Point(403, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 15);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(399, 38);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(295, 22);
            this.txtSearch.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::Clinic_Project.Properties.Resources.cancel;
            this.btnCancel.Location = new System.Drawing.Point(958, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(20, 20);
            this.btnCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCancel.TabIndex = 3;
            this.btnCancel.TabStop = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLogo
            // 
            this.btnLogo.Image = global::Clinic_Project.Properties.Resources.logo;
            this.btnLogo.Location = new System.Drawing.Point(38, 12);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(54, 69);
            this.btnLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLogo.TabIndex = 1;
            this.btnLogo.TabStop = false;
            // 
            // panel_content
            // 
            this.panel_content.Location = new System.Drawing.Point(171, 114);
            this.panel_content.Name = "panel_content";
            this.panel_content.Size = new System.Drawing.Size(807, 543);
            this.panel_content.TabIndex = 3;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 661);
            this.Controls.Add(this.panel_content);
            this.Controls.Add(this.pnlHeder);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.pnlHeder.ResumeLayout(false);
            this.pnlHeder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAlert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlHeder;
        private System.Windows.Forms.PictureBox btnLogo;
        private System.Windows.Forms.PictureBox btnSetting;
        private System.Windows.Forms.PictureBox btnAlert;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox btnCancel;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panel_content;
    }
}