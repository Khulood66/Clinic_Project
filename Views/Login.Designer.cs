namespace Clinic_Project.Views
{
    partial class Login
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
            this.txtAdminName = new System.Windows.Forms.TextBox();
            this.label_loginTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtAdminePassword = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_ForgetPass = new System.Windows.Forms.Label();
            this.lbl_adminNameRequired = new System.Windows.Forms.Label();
            this.lbl_passwordRequired = new System.Windows.Forms.Label();
            this.panel_Login = new System.Windows.Forms.Panel();
            this.lblverfy = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.PictureBox();
            this.panel_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(224)))), ((int)(((byte)(183)))));
            this.panel1.Location = new System.Drawing.Point(69, 268);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 1);
            this.panel1.TabIndex = 6;
            // 
            // txtAdminName
            // 
            this.txtAdminName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(61)))));
            this.txtAdminName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdminName.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminName.ForeColor = System.Drawing.Color.White;
            this.txtAdminName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtAdminName.Location = new System.Drawing.Point(88, 234);
            this.txtAdminName.MaxLength = 10;
            this.txtAdminName.Name = "txtAdminName";
            this.txtAdminName.Size = new System.Drawing.Size(224, 27);
            this.txtAdminName.TabIndex = 1;
            this.txtAdminName.TextChanged += new System.EventHandler(this.txtAdminName_TextChanged);
            // 
            // label_loginTitle
            // 
            this.label_loginTitle.AutoSize = true;
            this.label_loginTitle.BackColor = System.Drawing.Color.Transparent;
            this.label_loginTitle.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_loginTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(219)))), ((int)(((byte)(245)))));
            this.label_loginTitle.Location = new System.Drawing.Point(157, 110);
            this.label_loginTitle.Name = "label_loginTitle";
            this.label_loginTitle.Size = new System.Drawing.Size(88, 37);
            this.label_loginTitle.TabIndex = 9;
            this.label_loginTitle.Text = "Login";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(224)))), ((int)(((byte)(183)))));
            this.panel2.Location = new System.Drawing.Point(69, 353);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 1);
            this.panel2.TabIndex = 11;
            // 
            // txtAdminePassword
            // 
            this.txtAdminePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(61)))));
            this.txtAdminePassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdminePassword.ForeColor = System.Drawing.Color.White;
            this.txtAdminePassword.Location = new System.Drawing.Point(88, 325);
            this.txtAdminePassword.Name = "txtAdminePassword";
            this.txtAdminePassword.Size = new System.Drawing.Size(224, 20);
            this.txtAdminePassword.TabIndex = 2;
            this.txtAdminePassword.UseSystemPasswordChar = true;
            this.txtAdminePassword.TextChanged += new System.EventHandler(this.txtAdminePassword_TextChanged);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_login.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(224)))), ((int)(((byte)(183)))));
            this.btn_login.Location = new System.Drawing.Point(142, 417);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(131, 44);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_ForgetPass
            // 
            this.lbl_ForgetPass.Location = new System.Drawing.Point(0, 0);
            this.lbl_ForgetPass.Name = "lbl_ForgetPass";
            this.lbl_ForgetPass.Size = new System.Drawing.Size(100, 23);
            this.lbl_ForgetPass.TabIndex = 21;
            // 
            // lbl_adminNameRequired
            // 
            this.lbl_adminNameRequired.AutoSize = true;
            this.lbl_adminNameRequired.BackColor = System.Drawing.Color.Transparent;
            this.lbl_adminNameRequired.Font = new System.Drawing.Font("Comic Sans MS", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adminNameRequired.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_adminNameRequired.Location = new System.Drawing.Point(332, 238);
            this.lbl_adminNameRequired.Name = "lbl_adminNameRequired";
            this.lbl_adminNameRequired.Size = new System.Drawing.Size(49, 15);
            this.lbl_adminNameRequired.TabIndex = 17;
            this.lbl_adminNameRequired.Text = "Required";
            this.lbl_adminNameRequired.Visible = false;
            // 
            // lbl_passwordRequired
            // 
            this.lbl_passwordRequired.AutoSize = true;
            this.lbl_passwordRequired.Font = new System.Drawing.Font("Comic Sans MS", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_passwordRequired.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_passwordRequired.Location = new System.Drawing.Point(332, 320);
            this.lbl_passwordRequired.Name = "lbl_passwordRequired";
            this.lbl_passwordRequired.Size = new System.Drawing.Size(49, 15);
            this.lbl_passwordRequired.TabIndex = 18;
            this.lbl_passwordRequired.Text = "Required";
            this.lbl_passwordRequired.Visible = false;
            // 
            // panel_Login
            // 
            this.panel_Login.AutoSize = true;
            this.panel_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_Login.Controls.Add(this.lblverfy);
            this.panel_Login.Controls.Add(this.btnCancel);
            this.panel_Login.Controls.Add(this.lbl_passwordRequired);
            this.panel_Login.Controls.Add(this.lbl_adminNameRequired);
            this.panel_Login.Controls.Add(this.lbl_ForgetPass);
            this.panel_Login.Controls.Add(this.btn_login);
            this.panel_Login.Controls.Add(this.txtAdminePassword);
            this.panel_Login.Controls.Add(this.panel2);
            this.panel_Login.Controls.Add(this.label_loginTitle);
            this.panel_Login.Controls.Add(this.txtAdminName);
            this.panel_Login.Controls.Add(this.panel1);
            this.panel_Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Login.Location = new System.Drawing.Point(0, 0);
            this.panel_Login.Name = "panel_Login";
            this.panel_Login.Size = new System.Drawing.Size(417, 540);
            this.panel_Login.TabIndex = 0;
            this.panel_Login.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Login_Paint);
            // 
            // lblverfy
            // 
            this.lblverfy.AutoSize = true;
            this.lblverfy.BackColor = System.Drawing.Color.Transparent;
            this.lblverfy.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblverfy.ForeColor = System.Drawing.Color.White;
            this.lblverfy.Location = new System.Drawing.Point(111, 297);
            this.lblverfy.Name = "lblverfy";
            this.lblverfy.Size = new System.Drawing.Size(0, 18);
            this.lblverfy.TabIndex = 20;
            this.lblverfy.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::Clinic_Project.Properties.Resources.cancel;
            this.btnCancel.Location = new System.Drawing.Point(396, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(18, 20);
            this.btnCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCancel.TabIndex = 19;
            this.btnCancel.TabStop = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Clinic_Project.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(417, 540);
            this.Controls.Add(this.panel_Login);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel_Login.ResumeLayout(false);
            this.panel_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAdminName;
        private System.Windows.Forms.Label label_loginTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtAdminePassword;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_ForgetPass;
        private System.Windows.Forms.Label lbl_adminNameRequired;
        private System.Windows.Forms.Label lbl_passwordRequired;
        private System.Windows.Forms.Panel panel_Login;
        private System.Windows.Forms.PictureBox btnCancel;
        private System.Windows.Forms.Label lblverfy;
    }
}