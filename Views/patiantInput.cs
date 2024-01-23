using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Clinic_Project
{
    public partial class patiantInput : Form
    {
        ClinicEntities1 db = new ClinicEntities1();
        //SqlConnection con = new SqlConnection("Server = (local); DataBase=Clinic; Integrated Security = true");
        Petient p1;
        List<Medication> m;
        List<Appoitment> appo;
        List<Chech_Up> chups;
        Medication m1;
        Appoitment appo1;
        Chech_Up ch1;
        int Mid;
        int AppId;
        int ChId;
        int numContent = 0;

        public patiantInput()
        {
            InitializeComponent();
        }
        private void patiantInput_Load(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnNewDetials.Enabled = false;
            txtFname.Focus();
        }
        //Fun to Clear Controls after each transiction
        private void ClearControls()
        {
            txtFname.Clear();
            txtLname.Clear();
            txtEmail.Clear();
            txtAge.Clear();
            txtChdigno.Clear();
            txtchResult.Clear();
            txtChtype.Clear();
            txtMdesc.Clear();
            txtMdose.Clear();
            txtMname.Clear();
            txtMpariod.Clear();
            txtPhone.Clear();
            txtPhone.Clear();
            day.ResetText();
            endTime.ResetText();
            startTime.ResetText();
            mesPhone.Visible = false;

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

        //Fun to Check if Controls are Empty before Adding new Element
        private bool CheckControlEmpty()
        {
            if (txtPhone.Text == "" || txtMpariod.Text == "" || txtMname.Text == "" || txtMdose.Text == "" || txtMdesc.Text == "" || txtLname.Text == "" || txtFname.Text == "" || txtEmail.Text == "" || txtChtype.Text == "" || txtchResult.Text == "" || txtChdigno.Text == "" || txtAge.Text == "")
            {
                MessageBox.Show("Please Complete the inputs ", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (txtPhone.Text.Length != 9)
                {
                    mesPhone.Visible = true;
                    txtPhone.Clear();
                    txtPhone.Focus();
                }
                return true;
            }
            else return false;
        }

        //Fun Add New Patient
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckControlEmpty())
            {
                return;
            }
            else
            {
                try
                {
                    string sex;

                    sex = Female.Checked ? "Female" : "male";
                    m1 = new Medication(BaseEncrypte(txtMname.Text), decimal.Parse(txtMdose.Text), BaseEncrypte(txtMpariod.Text), BaseEncrypte(txtMdesc.Text));
                    MessageBox.Show($"{BaseEncrypte(txtMname.Text)},{decimal.Parse(txtMdose.Text)},{ BaseEncrypte(txtMpariod.Text)}, {BaseEncrypte(txtMdesc.Text) }");
                    appo1 = new Appoitment(day.Value, startTime.Value, endTime.Value);
                    ch1 = new Chech_Up(BaseEncrypte(txtChtype.Text), BaseEncrypte(txtchResult.Text), BaseEncrypte(txtChdigno.Text));
                    Petient p = new Petient(BaseEncrypte(txtFname.Text), BaseEncrypte(txtLname.Text), int.Parse(txtAge.Text), BaseEncrypte(sex), BaseEncrypte(txtPhone.Text), BaseEncrypte(txtEmail.Text), date.Value);
                    MessageBox.Show($"{BaseEncrypte(txtFname.Text)},{BaseEncrypte(txtLname.Text)},{ int.Parse(txtAge.Text)}, {BaseEncrypte(sex)},{ BaseEncrypte(txtPhone.Text)}, {BaseEncrypte(txtEmail.Text)},{ date.Value},pInfo");
                    appo1.Petient = p;
                    db.Appoitments.Add(appo1);
                    m1.Petient = p;
                    db.Medications.Add(m1);
                    ch1.Petient = p;
                    db.Chech_Up.Add(ch1);
                    MessageBox.Show("ppp");
                    db.Petients.Add(p);
                    MessageBox.Show("pp2");
                    db.SaveChanges();
                    ClearControls();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }

            }
        }

        //Fun to navegate Petaint Hestory
        public void PInfoMoving(Petient p1, string nextOrpreviose)
        {
            try
            {
                if (txtKey.Text != "" && txtKey.Text == "Doctor")
                {
                    m = db.Medications.Where(x => x.petiant_id == p1.Id).ToList();

                    appo = db.Appoitments.Where(x => x.petaint_id == p1.Id).ToList();
                    chups = db.Chech_Up.Where(x => x.petiant_Id == p1.Id).ToList();
                    if (nextOrpreviose == "next")
                    {
                        if (numContent < m.Count)
                        {

                            //Medication
                            txtMname.Text = BaseDencrypte(m[numContent].name);
                            txtMdose.Text = m[numContent].dose.ToString();
                            txtMpariod.Text = BaseDencrypte(m[numContent].period);
                            txtMdesc.Text = BaseDencrypte(m[numContent].description);
                            Mid = m[numContent].Id;
                            //Appointement
                            day.Value = appo[numContent].Day;
                            startTime.Value = appo[numContent].S_time;
                            endTime.Value = appo[numContent].E_time;
                            AppId = appo[numContent].Id;
                            //CheckUps
                            txtChtype.Text = BaseDencrypte(chups[numContent].type);
                            txtchResult.Text = BaseDencrypte(chups[numContent].Result);
                            txtChdigno.Text = BaseDencrypte(chups[numContent].diagnosis);
                            ChId = chups[numContent].Id;
                            numContent++;
                        }
                    }
                    else
                    {
                        if (numContent <= m.Count && numContent > 1)
                        {
                            numContent -= 1;
                            //Medication
                            txtMname.Text = BaseDencrypte(m[numContent - 1].name);
                            txtMdose.Text = m[numContent - 1].dose.ToString();
                            txtMpariod.Text = BaseDencrypte(m[numContent - 1].period);
                            txtMdesc.Text = BaseDencrypte(m[numContent - 1].description);
                            Mid = m[numContent - 1].Id;

                            //CheckUps
                            txtChtype.Text = BaseDencrypte(chups[numContent - 1].type);
                            txtchResult.Text = BaseDencrypte(chups[numContent - 1].Result);
                            txtChdigno.Text = BaseDencrypte(chups[numContent - 1].diagnosis);
                            AppId = appo[numContent - 1].Id;

                            //Appointement
                            day.Value = appo[numContent - 1].Day;
                            startTime.Value = appo[numContent - 1].S_time;
                            endTime.Value = appo[numContent - 1].E_time;
                            ChId = chups[numContent - 1].Id;



                        }
                    }
                }
                else
                {
                    m = db.Medications.Where(x => x.petiant_id == p1.Id).ToList();

                    appo = db.Appoitments.Where(x => x.petaint_id == p1.Id).ToList();
                    chups = db.Chech_Up.Where(x => x.petiant_Id == p1.Id).ToList();
                    if (nextOrpreviose == "next")
                    {
                        if (numContent < m.Count)
                        {

                            //Medication
                            txtMname.Text = m[numContent].name;
                            txtMdose.Text = m[numContent].dose.ToString();
                            txtMpariod.Text = m[numContent].period;
                            txtMdesc.Text = m[numContent].description;
                            Mid = m[numContent].Id;
                            //Appointement
                            day.Value = appo[numContent].Day;
                            startTime.Value = appo[numContent].S_time;
                            endTime.Value = appo[numContent].E_time;
                            AppId = appo[numContent].Id;
                            //CheckUps
                            txtChtype.Text = chups[numContent].type;
                            txtchResult.Text =chups[numContent].Result;
                            txtChdigno.Text = chups[numContent].diagnosis;
                            ChId = chups[numContent].Id;
                            numContent++;
                        }
                    }
                    else
                    {
                        if (numContent <= m.Count && numContent > 1)
                        {
                            numContent -= 1;
                            //Medication
                            txtMname.Text = m[numContent - 1].name;
                            txtMdose.Text = m[numContent - 1].dose.ToString();
                            txtMpariod.Text =m[numContent - 1].period;
                            txtMdesc.Text = m[numContent - 1].description;
                            Mid = m[numContent - 1].Id;

                            //CheckUps
                            txtChtype.Text = chups[numContent - 1].type;
                            txtchResult.Text = chups[numContent - 1].Result;
                            txtChdigno.Text = chups[numContent - 1].diagnosis;
                            AppId = appo[numContent - 1].Id;

                            //Appointement
                            day.Value = appo[numContent - 1].Day;
                            startTime.Value = appo[numContent - 1].S_time;
                            endTime.Value = appo[numContent - 1].E_time;
                            ChId = chups[numContent - 1].Id;



                        }
                    }
                }
            }
            catch (Exception)
            {
                return;
            }


        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            PInfoMoving(p1, "next");
        }
        private void btnBrefies_Click(object sender, EventArgs e)
        {
            PInfoMoving(p1, "previose");
        }

        //Fun to Edite Details of Petiont
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                
                    p1.F_name =BaseEncrypte( txtFname.Text);
                    p1.L_name = BaseEncrypte(txtLname.Text);
                    p1.age = int.Parse(txtAge.Text);
                    p1.email = BaseEncrypte(txtEmail.Text);
                    p1.phone = BaseEncrypte(txtPhone.Text);
                    //if (Female.Checked) p1.sex = "Female";
                    //else p1.sex = "Male";
                    p1.sex = Female.Checked ? BaseEncrypte("Female") : BaseEncrypte("Male");
                    p1.Date = date.Value;

                    m1 = db.Medications.Where(x => x.Petient.Id==p1.Id &&x.Id==Mid).Single();
                    m1.name = BaseEncrypte(txtMname.Text);
                    m1.dose = decimal.Parse(txtMdose.Text);
                    m1.period = BaseEncrypte( txtMpariod.Text);
                    m1.description = BaseEncrypte( txtMdesc.Text);

                    appo1 = db.Appoitments.Where(x => x.Petient.Id== p1.Id&&x.Id==AppId).Single();
                    appo1.Day = day.Value;
                    appo1.S_time = startTime.Value;
                    appo1.E_time = endTime.Value;

                    ch1 = db.Chech_Up.Where(x => x.Petient.Id== p1.Id&&x.Id==ChId).Single();
                    ch1.type = BaseEncrypte(txtChtype.Text);
                    ch1.Result = BaseEncrypte(txtchResult.Text);
                    ch1.diagnosis = BaseEncrypte( txtChdigno.Text);

                    db.SaveChanges();
                    MessageBox.Show("Succeess Editing");

                
            }
            catch (Exception)
            {
                MessageBox.Show("Fialed Editing");

            }
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            Views.FEncryptionFile frm1 = new Views.FEncryptionFile();
            frm1.ShowDialog();
            if (frm1.of.FileName != "")
            {
                OpenFileDialog op = frm1.of;

                m1 = new Medication(BaseEncrypte( txtMname.Text), decimal.Parse(txtMdose.Text),BaseEncrypte( txtMpariod.Text),BaseEncrypte (txtMdesc.Text));
                m1.Examination_Fname = op.FileName;
                m1.Ex_extention = Path.GetExtension(op.FileName.Substring(15));
                m1.Ex_Fcontent = Convert.ToBase64String(File.ReadAllBytes(op.FileName));
                m1.Petient = p1;
                db.Medications.Add(m1);
                db.SaveChanges();
                MessageBox.Show($"Successfully Added File");
            }



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnNewDetials_Click(object sender, EventArgs e)
        {
            try
            {
                m1 = new Medication(BaseEncrypte(txtMname.Text), decimal.Parse(txtMdose.Text), BaseEncrypte(txtMpariod.Text), BaseEncrypte(txtMdesc.Text));
                appo1 = new Appoitment(day.Value, startTime.Value, endTime.Value);
                ch1 = new Chech_Up(BaseEncrypte(txtChtype.Text), BaseEncrypte(txtchResult.Text), BaseEncrypte(txtChdigno.Text));
                appo1.Petient = p1;
                db.Appoitments.Add(appo1);
                m1.Petient = p1;
                db.Medications.Add(m1);
                ch1.Petient = p1;
                db.Chech_Up.Add(ch1);
                db.SaveChanges();
                MessageBox.Show($"Success Addition New details in {BaseDencrypte( p1.F_name) + ' ' + BaseDencrypte( p1.L_name)} ");
            }
            catch (Exception)
            {

                MessageBox.Show("There's an Error in Add More Details Process");
            }
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if(txtKey.Text!="" && txtKey.Text == "Doctor")
            {
                string s = BaseEncrypte(txtSearch.Text);
                ClearControls();
                btnSave.Enabled = false;
                btnNewDetials.Enabled = true;
                btnEdit.Enabled = true;
                try
                {
                    p1 = db.Petients.Where(x => x.F_name == s).Single();

                    if (p1 != null)
                    {
                        txtFname.Text = BaseDencrypte(p1.F_name);
                        txtLname.Text = BaseDencrypte(p1.L_name);
                        txtAge.Text = p1.age.ToString();
                        txtEmail.Text = BaseDencrypte(p1.email);
                        txtPhone.Text = BaseDencrypte(p1.phone);
                        Female.Checked = (p1.sex == BaseEncrypte("Female")) ? true : Male.Checked = true;
                        date.Value = p1.Date;


                    }
                }
                catch (Exception)
                {
                    MessageBox.Show($"There's No patient With this name ({txtSearch.Text}) in DB.");
                    ClearControls();
                    btnSave.Enabled = true;
                }

            }
            else
            {
                MessageBox.Show("Access Denayed");
                string s = BaseEncrypte(txtSearch.Text);
                ClearControls();
                btnSave.Enabled = false;
                btnNewDetials.Enabled = true;
                btnEdit.Enabled = true;
                try
                {
                    p1 = db.Petients.Where(x => x.F_name == s).Single();

                    if (p1 != null)
                    {
                        txtFname.Text = p1.F_name;
                        txtLname.Text = p1.L_name;
                        txtAge.Text = p1.age.ToString();
                        txtEmail.Text = p1.email;
                        txtPhone.Text = p1.phone;
                        Female.Checked = (p1.sex == "Female") ? true : Male.Checked = true;
                        date.Value = p1.Date;


                    }
                }
                catch (Exception)
                {
                    MessageBox.Show($"There's No patient With this name ({txtSearch.Text}) in DB.");
                    ClearControls();
                    btnSave.Enabled = true;
                }

            }
           
        }
    }
    }
   
    

