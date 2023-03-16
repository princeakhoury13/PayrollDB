namespace EmployeePayroll
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Payroll !");

            EmployeeRepo employeeRepo = new EmployeeRepo();
            
            EmployeeModel employeeModel = new EmployeeModel();

            employeeModel.EmployeeName = "Prince Praveen";
            employeeModel.PhoneNumber= "45327";
            employeeModel.Address = "New York";
            employeeModel.Department = "MVS";
            employeeModel.Gender = 'M';
            employeeModel.BasePay = 220000.00;
            employeeModel.Deductions = 100.00;
            employeeModel.TaxablePay = 250.00;
            employeeModel.Tax = 300.00;
            employeeModel.NetPay = 21000.00;
            employeeModel.City = "NYC";
            employeeModel.Country = "USA";

            //employeeRepo.AddEmployee(employeeModel);

            employeeRepo.GetAllEmployee();



        }
    }
}