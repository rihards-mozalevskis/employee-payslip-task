using System.Text;

namespace EmployeePayslip.Tests
{
    public class EmployeePayslipTests
    {

        /// <summary>
        /// Basic net salary calculation
        /// </summary>
        [Fact]
        public void Test1()
        {
            decimal grossSalary = 500m;
            decimal expectedNetSalary = 358m;

            decimal actualResult = 0;

            Assert.Equal(expectedNetSalary, actualResult);
        }

        /// <summary>
        /// Basic net salary calculation
        /// </summary>
        [Fact]
        public void Test2()
        {
            decimal grossSalary = 4000m;
            decimal expectedNetSalary = 2794.01m;

            decimal actualResult = 0;

            Assert.Equal(expectedNetSalary, actualResult);
        }

        /// <summary>
        /// Salary with One dependent person
        /// </summary>
        [Fact]
        public void Test3()
        {
            decimal grossSalary = 4000m;

            decimal expectedNetSalary = 2844.01m;
            decimal expectedIncomeTax = 735.99m;

            DateTime dependentPersonBirtDate = new DateTime(2020, 1, 1);
            DateTime dependentTill = dependentPersonBirtDate.AddYears(21);
            string dependetPersonFullName = "test dependent";

            int payslipMonth = DateTime.Now.Month;
            int payslipYear = DateTime.Now.Year;

            decimal actualResult = 0;
            decimal actualIncomeTaxAmount = 0;

            Assert.Equal(expectedNetSalary, actualResult);
            Assert.Equal(expectedIncomeTax, actualIncomeTaxAmount);
        }

        /// <summary>
        /// Dependent person expired 
        /// </summary>
        [Fact]
        public void Test4()
        {
            decimal grossSalary = 4000m;
            decimal expectedNetSalary = 2794.01m;

            DateTime dependentPersonBirtDate = new DateTime(2010, 1, 1);
            DateTime dependentTill = DateTime.Now.AddMonths(-1);
            string dependetPersonFullName = "test dependent";

            int payslipMonth = DateTime.Now.Month;
            int payslipYear = DateTime.Now.Year;

            decimal actualResult = 0;

            Assert.Equal(expectedNetSalary, actualResult);
        }

        /// <summary>
        /// InsuranceTaxEmployer test
        /// </summary>
        [Fact]
        public void Test5()
        {
            decimal grossSalary = 4000m;
            decimal expectedInsuranceTaxEmployer = 943.60m;

            decimal actualResult = 0;

            Assert.Equal(expectedInsuranceTaxEmployer, actualResult);
        }
    }
}