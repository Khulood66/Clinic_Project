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
    public partial class FEncryptionFile : Form
    {
        public OpenFileDialog of = new OpenFileDialog();


        public FEncryptionFile()
        {
            InitializeComponent();
             
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            if (of.ShowDialog()== DialogResult.OK) { textBox1.Text = of.FileName; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Class1 encryptfile = new Class1(textBox2.Text);
                encryptfile.encrypt(textBox1.Text);
                MessageBox.Show("Successfull Encryption File.");
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Class1 encryptfile = new Class1(textBox2.Text);
                    encryptfile.decrypt(textBox1.Text);
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
