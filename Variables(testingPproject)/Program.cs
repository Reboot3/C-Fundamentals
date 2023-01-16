// See https://aka.ms/new-console-template for more information



namespace Variables
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
            Console.Write("Alex's Big Giweaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            string message = (userValue == "1") ? "boat" : "strand of lint";

            //Console.Write("You won a ");
            //Console.Write(message);
            //Console.Write(".");

            // In one line:
            //Console.WriteLine("You won a {0}.", message);

            // Replace two values or more
            Console.WriteLine("You entered: {0}, " +
                "therefore you won a {1}.", userValue, message);


            Console.ReadLine();




        }
    }
}









