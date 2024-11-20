using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculationSystem
{
    public abstract  class Employee
    {
        public int Id {  get; set; }
        public string FName { get; set; }
        public string LName { get; set; }

        public decimal HourlyRate { get; set; }
        public int ExpctedHoures { get; set; }  // 40

        public int  LoggedHours {  get; set; } //45

        public string FullName => $"{FName}  {LName}";



        protected decimal CalaulateBasicSalary()
        {
            int hourDivetion = LoggedHours - ExpctedHoures; // 45-40 => 5 
                                // 45  -   5 = 40 (regulerly houres ) 
            int regularlyHours = LoggedHours - Math.Max(hourDivetion , 0);//5- // if 0 is grater than the hourDivetion so there is no overthime and will calaulate just the basic in two situations (negative or posetive)
            return regularlyHours * HourlyRate ; 
        }
        protected decimal CalaulateOverTime()
        {
            // 45 - 40  => 5 
            int hourDivetion = LoggedHours - ExpctedHoures; // if the + => there is overthime otherwise no overtime 
            // 5 * 1.5 => 
            return Math.Max(hourDivetion , 0) * HRConstants.OverTimeRate * HourlyRate;

        }

        protected virtual decimal CalulateGrossPay()
        {
            return CalaulateBasicSalary() + CalaulateOverTime();
        }

        protected decimal CalucalateTaxAmout()
        {
            return CalulateGrossPay() * HRConstants.TaxRate;
        }

        protected decimal CalucalateNetSalary()
        {
            return CalulateGrossPay() - CalucalateTaxAmout();
        }


        public abstract string ShowSalarySlip();





    }
}
