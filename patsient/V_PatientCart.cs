using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace patsient
{ 
    public partial class V_PatientCart : Form
    {
        private int Patientid;
        private string PatientFull_name;
        private int PatientAge;
        private string PatientSex;
        private diagnos diagnoz;
        private string PatientEntrance;
        private int PatientHeight;
        private string patientSpesialls;
        private Wards ward;
        private string othrs;
       

        public V_PatientCart()
        {
            this.Patientid = 0;
            this.PatientFull_name = " ";
            this.PatientAge = 0;
       
        this.Patientid = 0;
        this.PatientFull_name=" ";
       this.PatientAge=0;
     this.PatientSex=" ";
      this.diagnoz=new diagnos();
      this.PatientEntrance=" ";
       this.PatientHeight=0;
       this.patientSpesialls=" ";
       this.ward=new Wards();
            this.othrs = " ";
    }




        private void New_Click(object sender, EventArgs e)
        {

        }

        private void PatientCart_Load(object sender, EventArgs e)
        {

        }
    }
}
