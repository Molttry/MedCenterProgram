using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MedCenterProgram
{
     public class Nurse_Admin
    {
        public string name, type;
       public List<DateTime> duty;
        public List<DateTime> Fill(string[] parts)
        {
            List<DateTime> stuffduty = new List<DateTime>();
            for (int i = 2; i < parts.Length; i++)
            {
                stuffduty.Add(DateTime.Parse(parts[i]));
            }
            return stuffduty;
        }
    }
     public class Doctor : Nurse_Admin
    {
       public string profession;
       public List<DateTime> Fill(string[] parts)
        {
            List<DateTime> doctorduty = new List<DateTime>();
            for (int i=3; i<parts.Length; i++)
            {
                doctorduty.Add(DateTime.Parse(parts[i]));
            }
            return doctorduty;
        } 
    }
   
}