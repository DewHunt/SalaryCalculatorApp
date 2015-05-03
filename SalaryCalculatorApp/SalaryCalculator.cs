using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorApp
{
    class SalaryCalculator
    {
        public string employeeName;
        public double basicAmount, houseRent, medicalAllowance, totalHouseRent, totalMedicalAllowance, totalSalary;

        public double CalculateHouseRent()
        {
            totalHouseRent = (basicAmount*houseRent)/100;
            return totalHouseRent;
        }

        public double CalculateMedicalAllowance()
        {
            totalMedicalAllowance = (basicAmount*medicalAllowance)/100;
            return totalMedicalAllowance;
        }

        public double TotalSalary()
        {
            totalSalary = basicAmount + CalculateHouseRent() + CalculateMedicalAllowance();
            return totalSalary;
        }
    }
}
