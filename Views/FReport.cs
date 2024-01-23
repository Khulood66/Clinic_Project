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
    public partial class FReport : Form
    {
        ClinicEntities1 db = new ClinicEntities1();
        Petient p1;
       
        public struct M 
        {
           public string name { get; set; }
           public decimal dose { get; set; }
           public string Frequancy { get; set; }
           public string Description { get; set; }

        }
        public FReport()
        {
            InitializeComponent();
        }
        private void FReport_Load(object sender, EventArgs e)
        {
            p1 = db.Petients.FirstOrDefault();
            DisplyPetiantSammary();
            file();
        }
        //fun to Encrypte text by base64
        private string BaseEncrypte(string plain)
        {
            return Convert.ToBase64String(Encoding.Unicode.GetBytes(plain));
        }
        //fun to Dencrypte text by base64

        private string BaseDencrypte(string Cypher)
        {
            return Encoding.Unicode.GetString(Convert.FromBase64String(Cypher));
        }

       
        private void DisplyPetiantSammary()
        {
            try
            {
                Pname.Text = BaseDencrypte(p1.F_name) + " " + BaseDencrypte(p1.L_name);
                Page.Text = p1.age.ToString() + "YOld";
                Pphone.Text = BaseDencrypte(p1.phone);
                Pemail.Text = BaseDencrypte(p1.email);
                Psix.Text = BaseDencrypte(p1.sex);
                //MessageBox.Show($"{BaseDencrypte(p1.F_name)} { BaseDencrypte(p1.L_name)}");
                totalSetion.Text = db.Appoitments.Where(x => x.petaint_id == p1.Id).Count().ToString();
                active.Text = p1.active.ToString();

                DGVmedication.DataSource= db.Medications.Where(y => y.petiant_id == p1.Id).Select(x => new
                {
                    Name = x.name,
                    Dose = x.dose,
                    Frequancy = x.period,
                    Description = x.description
                }).ToList();


                //object o = db.Medications.Where(y => y.petiant_id == p1.Id).Select(x => new
                //{
                //    Name = BaseDencrypte( x.name),
                //    Dose =x.dose,
                //    Frequancy = BaseDencrypte(x.period),
                //    Description = BaseDencrypte(x.description)
                //}).ToList();

                //DGVmedication.DataSource = o;
            }
            catch (Exception)
            {

                MessageBox.Show("Error In retrive Data.");
            }
        }

        private void txtSearch_MouseEnter(object sender, EventArgs e)
        {
           labSearch.Visible = false;
           
        }

        private void txtSearch_MouseLeave(object sender, EventArgs e)
        {
            if(txtSearch.Text=="")
            labSearch.Visible = true;
        }
        private void file()
        {
            int y = 36;
            int num = db.Medications.Where(x => x.Examination_Fname != null&&x.petiant_id==p1.Id).Count();
            //MessageBox.Show($"{num}");
            for(int i = 0; i < num; i++)
            {
                Button b1 = new Button();
                b1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                b1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                b1.Location = new Point(3, y);
                b1.Image = Properties.Resources.file21;
                b1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                b1.Name = "button"+i;
                b1.Padding = new System.Windows.Forms.Padding(20, 0, 30, 0);
                b1.Size = new System.Drawing.Size(200, 53);
                b1.Text = "CheckUp"+(i+1);
                b1.UseVisualStyleBackColor = true;
                //this.Controls.Add(b1);
                panel2.Controls.Add(b1);
                b1.Show();
                y += 59;

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string s = BaseEncrypte(txtSearch.Text);
            try
            {
                panel2.Controls.Clear();
                p1 = db.Petients.Where(x => x.F_name==s).Single();
                DisplyPetiantSammary();
                file();
            }
            catch (Exception) { };

        }
    }
}
