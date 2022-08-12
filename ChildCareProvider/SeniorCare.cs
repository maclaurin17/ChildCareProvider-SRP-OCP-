using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorCareProvider
{/// <summary>
/// The abstract class SeniorCare is used to fullfil the Open Close principle
/// </summary>
    public abstract class SeniorCare
    {
        public abstract double Salary();
    }

    public class DementiaCare : SeniorCare
    {
        private double _salary;
        private double _bonus;
        private double _transport;
        public override double Salary()
        {
            throw new NotImplementedException();
        }
    }

    public class HospitalEscorts : SeniorCare
    {
        private string name { get; set; }
        private int age { get; set; }
        private string mobileNo { get; set; }  


        public override double Salary()
        {
            throw new NotImplementedException();
        }
    }

}
