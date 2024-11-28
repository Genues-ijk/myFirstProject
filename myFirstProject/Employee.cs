using System.Runtime.CompilerServices;

namespace myFirstProject
{
    internal class Employee
    {
        //Logical Representation, like blue print
        // the following are called (member fields)
        //hide/show [Encapsulation]
       private int id;
        private string name;
        private string address;
        private int phonenumber;
        private int salary;

      //public void SetSalary(int s)
      //  {
      //      if (s >6000) 
      //      {
      //          Salary = s; 
      //      }
      //      else
      //      {
      //          Salary = 6000;
      //      }
      //  }

        //private property
        public int Salary
        {
            get 
            {
                return salary;
            }
            set 
            {
                if(value>6000)
                {
                    salary = value;
                }
                else 
                {
                    Console.WriteLine("you salary is not more than 6000!");
                }
            }
        }


        //constructor
public Employee()
        {
            Console.WriteLine("empty constructor!");
        }

        //constructor with id
        public Employee(int id):this()
        {
            id = 0;
            Console.WriteLine("id");
        }
        public Employee(int id, string name, int salary):this()
        {

            id = 1;
            name = "rayan";
            salary = 121212;
            Console.WriteLine("id,name,salary");
           
        }
        //display
        public void Display()
        {
            Console.WriteLine("Employees Details.:-\n"
                              + $"ID:{id}|Name:{name}|Salary:{Salary}");
        }

        //  //Display function
        //public void Display()
        //{
        //    Console.WriteLine("Employees Details.:-\n"
        //                      + $"ID:{id}|Name:{name}|Salary:{Salary}|PhoneNumber:{phonenumber}|Address:{address}");
        //}
        //public void addemployee()
        //{
        //    string answer;
        //    Console.WriteLine("do you want to add a new employee?(y/n)");
        //    answer = Console.ReadLine();
        //    if (answer == "y")
        //    {
        //    Console.WriteLine("Enter the number of employees:");
        //    int numberOfEmployees = Convert.ToInt32(Console.ReadLine());

        //    // Create an array to store employees
        //    Employee[] employees = new Employee[numberOfEmployees];

        //    // Populate the array with user input
        //    for (int i = 0; i < numberOfEmployees; i++)
        //    {
        //        Console.WriteLine($"Enter details for employee {i + 1}:");

        //        Console.Write("ID: ");
        //        int id = Convert.ToInt32(Console.ReadLine());

        //        Console.Write("Name: ");
        //        string name = Console.ReadLine();

        //        Console.Write("Address: ");
        //        string address = Console.ReadLine();

        //        Console.Write("Phonenumber: ");
        //        int phonenumber = Convert.ToInt32(Console.ReadLine());

        //        Console.Write("Salary: ");
        //        int salary = Convert.ToInt32(Console.ReadLine());
        //        // Create a new Employee object and store it in the array
        //        employees[i] = new Employee { ID = id, Name = name, address = address, PhoneNumber = phonenumber, Salary = salary };
        //    }
        //        SetSalary(Salary);

        //        // Display the entered employee details
        //        Console.WriteLine("\nEmployee Details:");
        //    foreach (var employee in employees)
        //    {
        //        Console.WriteLine($"ID: {employee.ID}, Name: {employee.Name}, Address: {employee.address}, PhoneNumber: {employee.PhoneNumber}, Salary: {employee.Salary}");
        //    }
        //    }
        //    else if(answer == "n") 
        //    {
        //        Environment.Exit(0);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Please choose correct letter");
        //    }
        //}
    }
}
