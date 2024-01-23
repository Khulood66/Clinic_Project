using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Clinic_Project.Views
{
    public partial class Login: Form
    {
        ClinicEntities1 db = new ClinicEntities1();
        int count;
        public Login()
        {
            InitializeComponent();
        }
        public void CheckLoginFiled() // لتحقق من ادخال حقل اسم الامن والباسورد
        {
            if (txtAdminName.Text == db.Doctors.Find(1).Username && txtAdminePassword.Text == db.Doctors.Find(1).pass)
            {
                lbl_adminNameRequired.Visible = false;
                lbl_passwordRequired.Visible = false;
                this.Hide();
                new Home().Show();
            }
            else if (txtAdminName.Text == "" && txtAdminePassword.Text == "")
            {
                lbl_adminNameRequired.Visible = true;
                lbl_passwordRequired.Visible = true;
                txtAdminName.Focus();
            }
            else if (txtAdminName.Text == "" && txtAdminePassword.Text != "")
            {
                lbl_adminNameRequired.Visible = true;
                lbl_passwordRequired.Visible = false;
                txtAdminName.Focus();

            }
            else if (txtAdminName.Text != "" && txtAdminePassword.Text == "")
            {
                lbl_passwordRequired.Visible = true;
                lbl_adminNameRequired.Visible = false;
                txtAdminePassword.Focus();

            }
            else
            {
                txtAdminName.Clear();
                txtAdminePassword.Clear();
                txtAdminName.Focus();
            }
        }
        
      
       
        public void btn_login_Click(object sender, EventArgs e)
        {
            ++count;
            if (count == 3) { Application.Exit(); }
            else
            {
                CheckLoginFiled();
                lblverfy.Visible = false;
            }
        }

        private void txtAdminName_TextChanged(object sender, EventArgs e)
        {
            lbl_adminNameRequired.Visible = false;
        }

        private void txtAdminePassword_TextChanged(object sender, EventArgs e)
        {

            lblverfy.Visible = true;
            lblverfy.Text = "What's The Day ToDay?";
            if (txtAdminePassword.Text == "Doctor")
            {
                txtAdminePassword.Visible = false;
                txtAdminePassword.Text = db.Doctors.Find(1).pass;
            }
        }
                   
        private void panel_Login_Paint(object sender, PaintEventArgs e)
        {
            panel_Login.BackColor = Color.FromArgb(180, 0, 10, 15);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
