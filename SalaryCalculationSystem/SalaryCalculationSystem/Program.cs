using SalaryCalculationSystem;
using System;
using System.ComponentModel.DataAnnotations;

namespace SalaryColculationSystem
{
    public class Program
    {
       public static  void Main(string[] args)
        {
            List<Employee> employees =new()
            {
                new Mangers
                {
                    Id = 123,
                    FName ="Noor",
                    LName ="Hijazi",
                    HourlyRate = 10m,
                    ExpctedHoures = 40,
                    LoggedHours = 40,
                    Allowance = 100,
                },
                new SalesAgent
                {
                     Id = 1230,
                    FName ="Reem",
                    LName ="Ahmad",
                    HourlyRate = 10m,
                    ExpctedHoures = 40,
                    LoggedHours = 45,
                    TotalSales = 10000m,
             
                },
                new HandyMan
                {
                    Id = 1222,
                    FName ="Ali",
                    LName ="Yazan",
                    HourlyRate = 5m,
                    ExpctedHoures = 40,
                    LoggedHours = 65,
                    Hardship = 75m,
                },
                new SoftwareEngineer
                {
                    Id = 1333,
                    FName ="Yazeed",
                    LName ="Hijazi",
                    HourlyRate = 10m,
                    ExpctedHoures = 40,
                    LoggedHours = 40,
                    TraningAllowance = 50m,
                    StroyPontCompleted = 8
                }
            };

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.GetType().Name);
                Console.WriteLine("----------------------\n");
                Console.WriteLine(employee.ShowSalarySlip());
            }
        }
    }

}