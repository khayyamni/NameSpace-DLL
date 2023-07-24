

//using Namespace_DLL;
//using Namespace_DLL.Controllers;

//Employee employee = new Employee();

//employee.GetName();


//Console.WriteLine("Add age: ");

//Age: string age = Console.ReadLine();

//int personAge;

//bool IsCorrectAgeFormat = int.TryParse(age, out personAge);

//if (IsCorrectAgeFormat)
//{
//    Console.WriteLine("Add full name");
//    string fullName = Console.ReadLine();

//    Person person = new Person()
//    {
//        Id = 1,
//        FullName = fullName,
//        Age = personAge,
//        IsMarried = true
//    };

//    PersonService service = new PersonService();

//   bool IsMarried = service.CheckIsMarried(person);

//    string result = IsMarried == true ? "Evlidir" : "Subaydir";

//    Console.WriteLine(result);

//}
//else
//{
//    Console.WriteLine("Pls add correct age format again: ");
//    goto Age;
//}
//PersonControllers personControllers = new PersonControllers();

//personControllers.CheckUserIsMarried();


using Namespace_DLL.Controllers;

EmployeeController employeeController = new();
//employeeController.GetAverageAgeEmployees();

employeeController.SearchByPosition();












