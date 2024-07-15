using System;

namespace InheritanceAssignment
{
    interface IGovtRules
    {
        double EmployeePF(double basicSalary);
        string LeaveDetails();
        double GratuityAmount(float serviceCompleted, double basicSalary);
    }

    class TCS : IGovtRules
    {
        public int Empid { get; }
        public string Name { get; }
        public string Dept { get; }
        public string Designation { get; }
        public double BasicSalary { get; }

        public TCS(int empId, string name, string dept, string designation, double basicSalary)
        {
            Empid = empId;
            Name = name;
            Dept = dept;
            Designation = designation;
            BasicSalary = basicSalary;
        }

        public double EmployeePF(double basicSalary)
        {
            double PfAmount = basicSalary * 0.12;
            double EmployerContribution = basicSalary * 0.0833;
            double PensionContribution = basicSalary * 0.0367;
            return PfAmount + EmployerContribution + PensionContribution;
        }

        public string LeaveDetails()
        {
            return "1 day of Casual Leave per month\n" +
                   "12 days of Sick Leave per year\n" +
                   "10 days of Privilege Leave per year";
        }

        public double GratuityAmount(float serviceCompleted, double basicSalary)
        {
            if (serviceCompleted > 20)
            {
                return 3 * basicSalary;
            }
            else if (serviceCompleted > 10)
            {
                return 2 * basicSalary;
            }
            else if (serviceCompleted > 5)
            {
                return basicSalary;
            }
            return 0;
        }
    }

    class Accenture : IGovtRules
    {
        public int Empid { get; }
        public string Name { get; }
        public string Dept { get; }
        public string Designation { get; }
        public double BasicSalary { get; }

        public Accenture(int empId, string name, string dept, string designation, double basicSalary)
        {
            Empid = empId;
            Name = name;
            Dept = dept;
            Designation = designation;
            BasicSalary = basicSalary;
        }

        public double EmployeePF(double basicSalary)
        {
            double employeePF = basicSalary * 0.12;
            double EmployerContribution = basicSalary * 0.12;
            return employeePF + EmployerContribution;
        }

        public string LeaveDetails()
        {
            return "2 days of Casual Leave per month\n" +
                   "5 days of Sick Leave per year\n" +
                   "5 days of Privilege Leave per year";
        }

        public double GratuityAmount(float serviceCompleted, double basicSalary)
        {
            // Gratuity not applicable for Accenture
            return 0;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the company you are working in (TCS/Accenture): ");
            string CompanyName = Console.ReadLine();

            IGovtRules employee = null;

            if (CompanyName == "TCS")
            {
                employee = new TCS(1, "John Doe", "IT", "Developer", 50000);
            }
            else if (CompanyName == "Accenture")
            {
                employee = new Accenture(2, "Jane Smith", "HR", "Manager", 60000);
            }

            if (employee != null)
            {
                Console.WriteLine($"Employee PF: {employee.EmployeePF(20000)}");
                Console.WriteLine($"Leave Details:\n{employee.LeaveDetails()}");
                Console.WriteLine($"Gratuity Amount (6 years): {employee.GratuityAmount(6, 20000)}");
            }
            else
            {
                Console.WriteLine("Invalid company name entered.");
            }
        }
    }
}