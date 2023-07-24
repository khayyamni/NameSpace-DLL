//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Namespace_DLL.Controllers
//{
//    internal class PersonControllers
//    {
//        public void CheckUserIsMarried()
//        {
//            Console.WriteLine("Add age: ");

//        Age: string age = Console.ReadLine();

//            int personAge;

//            bool IsCorrectAgeFormat = int.TryParse(age, out personAge);

//            if (IsCorrectAgeFormat)
//            {
//                Console.WriteLine("Add full name");
//                string fullName = Console.ReadLine();

//                Console.WriteLine("Are you married ?  Yes/No");

//                Married: string married = Console.ReadLine();

//                bool personIsMarried = false;

//                if(married == "Yes")
//                {
//                    personIsMarried = true;
//                }
//                else if(married == "No")
//                {
//                    personIsMarried = false;
//                }
//                else
//                {
//                    Console.WriteLine("Pls add your married answer again");
//                    goto Married;
//                }

//                Person person = new Person()
//                {
//                    Id = 1,
//                    FullName = fullName,
//                    Age = personAge,
//                    IsMarried = personIsMarried
//                };


//                string result = GetPersonMarried(person);


//                Console.WriteLine(result);

//            }
//            else
//            {
//                Console.WriteLine("Pls add correct age format again: ");
//                goto Age;
//            }


//        }


//        private string GetPersonMarried(Person person)
//        {

//            PersonService service = new PersonService();

//            bool IsMarried = service.CheckIsMarried(person);

//            string result = IsMarried == true ? "Evlidir" : "Subaydir";


//            return result;
//        }

//    }
//}
