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
    public partial class Dashboard : Form
    {
        ClinicEntities1 db = new ClinicEntities1();
        int num;
        
        public Dashboard()
        {
            InitializeComponent();
            var con = from p in db.Petients
                      from app in db.Appoitments
                      where p.Id == app.petaint_id && app.Day == DateTime.Today
                      select new
                      {
                          Name = p.F_name + " " + p.L_name,
                          Gender = p.sex,
                          Day = app.Day

                      };
            DGVTodayAppointment.DataSource = con.ToList();
            //num=db.Petients.Where(x=>x.Date<=DateTime.Now &&x.Date>)

        }
        
        private void DisplayTodayApportenty()
        {
            var con = from p in db.Petients
                      from app in db.Appoitments
                      where p.Id == app.petaint_id && app.Day == DateTime.Today
                      select new
                      {
                          Name = p.F_name + " " + p.L_name,
                          Gender = p.sex,
                          Day = (db.Appoitments.Where(x => x.petaint_id == p.Id).Count()) >= 0 ? " pla " : "gg",

                      };
            DGVTodayAppointment.DataSource = con.ToList();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            DisplayTodayApportenty();
        }
    }
}
