using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patsient
{
    class PatientCart
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
        private string others;

        //свойство рост
      
            public PatientCart()
            {
        this.Patientid = 0;
        this.PatientFull_name=" ";
       this.PatientAge=0;
     this.PatientSex=" ";
      this.diagnoz=new diagnos();
      this.PatientEntrance=" ";
       this.PatientHeight=0;
       this.patientSpesialls=" ";
       this.ward=new Wards();
            this.others = "";
    }
     
}
