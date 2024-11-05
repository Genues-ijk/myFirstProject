namespace myFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region declare the variables
            int a, b,sum,sub,mul,div;
            string n1,n2, c, d,fullname;
            #endregion

            #region + - * and / operations
            Console.WriteLine("Greetings, I'm calculator, Give me any two numbers and I will do my '+,-,* and /' operations and then give you the result!");
            Console.WriteLine("firstnumber:");
            n1 = Console.ReadLine();
            Console.WriteLine("secondnumber:");
            n2 = Console.ReadLine();
            a = Convert.ToInt32(n1);
            b = Convert.ToInt32(n2);
            sum = a + b;
            sub = a - b;
            mul = a * b;
            div = a / b;
            Console.WriteLine($"The result is showing as the following:-\n {a}+{b}={sum}\n {a}-{b}={sub}\n{a}*{b}={mul}\n{a}/{b}={div}");
            Console.WriteLine("Now let me show you some of my skills, give me your first and last name and I will give you the lehgth of your fullname!");
            Console.WriteLine("firstname:");
            c = Console.ReadLine();
            Console.WriteLine("lastname:");
            d = Console.ReadLine();
            fullname = c + d;  
            Console.WriteLine(@"The length of your full name fullname ="+ fullname.Length);
            #endregion
            //--the end-----
        }
    }
}
