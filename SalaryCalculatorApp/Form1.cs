using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorApp
{
    public partial class SalaryCalculatorUI : Form
    {
        public SalaryCalculatorUI()
        {
            InitializeComponent();
        }

        private void showSalaryButton_Click(object sender, EventArgs e)
        {
            SalaryCalculator salary=new SalaryCalculator();

            salary.employeeName = employeeNameTextBox.Text;
            salary.basicAmount = Convert.ToDouble(basicAmountTextBox.Text);
            salary.houseRent = Convert.ToDouble(houseRentTextBox.Text);
            salary.medicalAllowance = Convert.ToDouble(medicalAllowanceTextBox.Text);

            MessageBox.Show(salary.employeeName + " Your Salary is : " + salary.TotalSalary());
        }
    }
}
