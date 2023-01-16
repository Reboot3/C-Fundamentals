// See https://aka.ms/new-console-template for more information



namespace AnderstandingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("HelloAlex");
            //Console.ReadLine();


            // int its my new variable
            //int x;
            //int y;
            //x = 7;
            //y = x + 3;
            //Console.WriteLine(y);
            //Console.ReadLine();


            //Console.WriteLine("What is your name?");
            //Console.Write("Type your first name: ");
            //string myFirstName;
            //myFirstName = Console.ReadLine();

            //string myLastName;
            //Console.Write("Type your last name: ");
            //myLastName = Console.ReadLine();

            //Console.WriteLine("Type your last name: ");
            //string myLastName = Console.ReadLine();

            //Console.WriteLine("Hello, " + myFirstName + " " + myLastName + "!");
            //Console.ReadLine();



            // Decisions

            /*Console.Write("Alex's Big Giweaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            string message = "";

            if (userValue == "1")
            {
                 message = "You won a new car!";
            }
            else if (userValue == "2")
            {
                 message = "You won a new house";
            }
            else if (userValue == "3")
            {
                message = "You won a new snowboard";
            }
            else
            {
                message = "Input is not recognized. ";
                //message = message + "You Lose. ";
                message += "You Lose. ";
            }
            Console.WriteLine(message);
            Console.ReadLine(); 
            */


            // Another style of decision statement (condition operator)
            //Console.Write("Alex's Big Giweaway");
            //Console.Write("Choose a door: 1, 2 or 3: ");
            //string userValue = Console.ReadLine();

            //string message = (userValue == "1") ? "boat" : "strand of lint";

            //Console.Write("You won a ");
            //Console.Write(message);
            //Console.Write(".");

            // In one line:
            //Console.WriteLine("You won a {0}.", message);

            // Replace two values or more
            //Console.WriteLine("You entered: {0}, " +
            //    "therefore you won a {1}.", userValue, message);


            //Console.ReadLine();



            // Variable declaration
            //int x, y, a, b;

            // Assignment operator
            //x = 3;
            //y = 2;
            //a = 1;
            //b = 0;

            // There are many mathematical operators ....

            // Addition operator
            //x = 3 + 4;

            // Subtraction operator
            //x = 10 * 5;

            // Division operator
            //x = 10 / 5;

            // Order of operations using parenthesis
            //x = (x + y) * (a - b);

            // There are many operators used to evaluete values ...

            // Equality operator
            //if (x == y)
            //{

            //}

            // Greater than operator
            //if (x > y)
            //{

            //}

            // Greater or equal to operator
            //if (x >= y)
            //{

            //}

            // Conditional AND operator ...
            //if ((x > y) && (a > b))
            //{

            //}

            // Conditional OR operator ...
            //if ((x > y) || (a > b))
            //{

            //}

            //In-line conditional operator:
            //string message = (x == 1) ? "Car" : "Boat";

            // Member access and Method invocation
            //Console.Write("Hi");



            // Iteration
            /*for (int i = 0; i < 19; i++)
            {
                //Console.WriteLine(i);
                if (i == 7)
                {
                    Console.WriteLine("Found seven !");
                    break;
                }
            }

            for (int myValue = 0; myValue < 12; myValue++)
            {
                Console.WriteLine(myValue);
            }


            Console.ReadLine();
            */

            // Work with arrays
            /*
            int number1 = 4;
            int number2 = 8;
            int number3 = 15;
            int number4 = 16;
            int number5 = 23;

            if (number1 == 16)
            {

            }
            else if (number2 == 16)
            {

            }
            else if (number3 == 16)
            {

            }
            */
            /*
            int[] numbers = new int[5];

            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;

            // Console.WriteLine(numbers[4]);
            Console.WriteLine(numbers.Length);
            Console.ReadLine();
            */


            //int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };

            string[] names = new string[] { "Eddie", "Alex", "Michael" };
            /*
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();
            */

            /*
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
            */

            string zig = "You can get what you want out of life if you help" +
                " enough other people get what they want.";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigChar in charArray)
            {
                Console.Write(zigChar);
            }
            Console.ReadLine();






        }
    }
}









