using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Project
{
    public partial class Home : Form
    {
        private Button currentBtn;
        private Form currentForm;
        public Home()
        {
            InitializeComponent();
        }

        private void ActivateButton(object senderBtn, Form f)
        {
            DisActiveButton();
            if (senderBtn != null && f != null)
            {

                currentForm = f;
                //Button
                currentBtn = (Button)senderBtn;
                currentBtn.ForeColor = Color.White;
                currentBtn.BackColor = Color.FromArgb(204, 219, 245);
                f.TopLevel = false;
                panel_content.Controls.Add(f);
                f.Show();
            }
        }
        private void DisActiveButton()
        {
            if (currentBtn != null && currentForm != null)
            {
                currentBtn.ForeColor = Color.FromName("ControlText");
                currentBtn.BackColor = Color.FromArgb(198, 197, 197);
                currentBtn.FlatAppearance.BorderSize = 0;
                panel_content.Controls.Clear();
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, new Dashboard());
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, new patiantInput());
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, new FReport());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}

