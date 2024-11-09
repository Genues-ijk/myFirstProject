namespace myFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region Assignment1
            //#region declare the variables
            //int a, b,sum,sub,mul,div;
            //string n1,n2, c, d,fullname;
            //#endregion

            //#region + - * and / operations
            //Console.WriteLine("Greetings, I'm calculator, Give me any two numbers and I will do my '+,-,* and /' operations and then give you the result!");
            //Console.WriteLine("firstnumber:");
            //n1 = Console.ReadLine();
            //Console.WriteLine("secondnumber:");
            //n2 = Console.ReadLine();
            //a = Convert.ToInt32(n1);
            //b = Convert.ToInt32(n2);
            //sum = a + b;
            //sub = a - b;
            //mul = a * b;
            //div = a / b;
            //Console.WriteLine($"The result is showing as the following:-\n {a}+{b}={sum}\n {a}-{b}={sub}\n{a}*{b}={mul}\n{a}/{b}={div}");
            //Console.WriteLine("Now let me show you some of my skills, give me your first and last name and I will give you the lehgth of your fullname!");
            //Console.WriteLine("firstname:");
            //c = Console.ReadLine();
            //Console.WriteLine("lastname:");
            //d = Console.ReadLine();
            //fullname = c + d;  
            //Console.WriteLine("The length of your full name fullname ="+ fullname.Length);
            //#endregion
            //#endregion

            #region Assignment 2

            decimal degree;
            Console.WriteLine("Enter Your degree to check if you're pass or fail:-");
            degree = Convert.ToDecimal(Console.ReadLine());

            if (degree >= 0 && degree <= 50)
            {
                Console.WriteLine("(Fail):Try hard next time");
            }
            else if (degree >= 50 && degree <= 65)
            {
                Console.WriteLine("(Fair):Fair enogh parctice more!");
            }
            else if (degree >=65 && degree <= 75)
            {
                Console.WriteLine("(Good):Good you worked hard!");
            }
            else if (degree >=75 && degree <= 85)
            {
                Console.WriteLine("(VeryGood): great!");
            }
            else if(degree >=85 && degree==100)
            {
                Console.WriteLine("(Excelent):You are genius!");
            }
            else
            {
                Console.WriteLine("Incorrect degree!, try again.");
            }
            Console.WriteLine("-------------------------------------\nNothing hard but there's work hard to get what you want!.\n-------------------------------------");
            #endregion
            #region Assginment 3
            int choice;
            char switcher;

            do
            {
                Console.WriteLine("Choose one of the following:-\n1) Good Morning. \n2) Good Evening. \n3) Good Afternoon. \n4) Good Night.");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Good Morning.");
                        break;
                    case 2:
                        Console.WriteLine("Good Evening.");
                        break;
                    case 3:
                        Console.WriteLine("Good Afternoon.");
                        break;
                    case 4:
                        Console.WriteLine("Good Night.");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice !.");
                        break;
                }
                Console.WriteLine("Do you want to continue?(y/n): ");
                switcher = Convert.ToChar(Console.ReadLine());

            } while (switcher == 'y');
            #endregion

        }
    }
}
