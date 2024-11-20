namespace myFirstProject
{
    internal class Employee
    {
        //Logical Representation, like blue print
        // the following are called (member fields)
        //hide/show [Encapsulation]
        public int ID;
       public  string Name;
        public string address;
        public int PhoneNumber;
        private int Salary;
      public void SetSalary(int s)
        {
            if (s >6000) 
            {
                Salary = s; 
            }
            else
            {
                Salary = 6000;
            }
        }
        //Display function
      public  void Display()
        {
            Console.WriteLine("Employees Details.:-\n"
                              +$"Name:{Name}|Salary:{Salary}|PhoneNumber:{PhoneNumber}");
        }
        public void addemployee()
        {
            string answer;
            Console.WriteLine("do you want to add a new employee?(y/n)");
            answer = Console.ReadLine();
            if (answer == "y")
            {
            Console.WriteLine("Enter the number of employees:");
            int numberOfEmployees = Convert.ToInt32(Console.ReadLine());

            // Create an array to store employees
            Employee[] employees = new Employee[numberOfEmployees];

            // Populate the array with user input
            for (int i = 0; i < numberOfEmployees; i++)
            {
                Console.WriteLine($"Enter details for employee {i + 1}:");

                Console.Write("ID: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Address: ");
                string address = Console.ReadLine();

                Console.Write("Phonenumber: ");
                int phonenumber = Convert.ToInt32(Console.ReadLine());

                Console.Write("Salary: ");
                int salary = Convert.ToInt32(Console.ReadLine());
                // Create a new Employee object and store it in the array
                employees[i] = new Employee { ID = id, Name = name, address = address, PhoneNumber = phonenumber, Salary = salary };
            }
                SetSalary(Salary);

                // Display the entered employee details
                Console.WriteLine("\nEmployee Details:");
            foreach (var employee in employees)
            {
                Console.WriteLine($"ID: {employee.ID}, Name: {employee.Name}, Address: {employee.address}, PhoneNumber: {employee.PhoneNumber}, Salary: {employee.Salary}");
            }
            }
            else if(answer == "n") 
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Please choose correct letter");
            }
        }
    }
}
