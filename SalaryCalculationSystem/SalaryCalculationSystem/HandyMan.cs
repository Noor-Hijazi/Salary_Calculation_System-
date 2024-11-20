using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculationSystem
{
    public sealed  class HandyMan:Employee
    {
        public decimal Hardship { get; set; }
        protected override decimal CalulateGrossPay()
        {
            return base.CalulateGrossPay() + Hardship;
        }

        public override string ShowSalarySlip()
        {
            decimal basicSalary = CalaulateBasicSalary(); ;
            decimal grossSalary = CalulateGrossPay();
            decimal taxAmount = CalucalateTaxAmout();
            decimal netSalary = CalucalateNetSalary();
            decimal overtime = CalaulateOverTime();
   


            return $"Employee: #{Id} ({FullName}). \n" +
                    $"Houres Logged: {LoggedHours} hrs. \n" +
                    $"Basic Salary: {basicSalary.ToString("C")}/hr \n" +
                    $"OverTime ({HRConstants.TaxRate}x): {overtime.ToString("C")}\n" +
                    $"Gross Pay: {Hardship.ToString("C")}\n" +
                    $"Gross Pay: {grossSalary.ToString("C")}\n" +
                    $"Tax Amount ({(HRConstants.TaxRate).ToString("%0")}): {taxAmount.ToString("C")}\n" +
                    $"--------------------------------------- \n" +
                    $"Net Salary: {netSalary.ToString("C")}\n";
            ;
        }
    }
}
