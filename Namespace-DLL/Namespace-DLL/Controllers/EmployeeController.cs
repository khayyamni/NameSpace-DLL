using Namespace_DLL.Services;

//namespace Namespace_DLL.Controllers
//{
//    internal class EmployeeController
//    {
//        public void GetAverageAgeEmployees()
//        {
//            EmployeeService employeeService = new EmployeeService();
//            int averageAge =   employeeService.GetAverageAgeForEmployees();
//            Console.WriteLine(averageAge);
//        }
//    }
//}

namespace Namespace_DLL.Controllers
{

    internal class EmployeeController
    {
        public void GetAverageAgeEmployees()
        {
            EmployeeService employeeService = new EmployeeService();
            int averageAge = employeeService.GetAverageAgeForEmployees();
            Console.WriteLine(averageAge);


        }

        public void SearchByPosition()
        {
            EmployeeService employeeService = new();
            Console.WriteLine("Add search text");
            string position = Console.ReadLine();
            employeeService.SeracByPosition(position);
        }
    }
}
