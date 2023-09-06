namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Eric Sällström YH .NET23

            int number = 16;

            if (number > 10) // checking if the variable number is larger than 10
            {
                Console.WriteLine("Talet är stort!"); // if number is larger than 10, this message is printed
            }
            else
            {
                Console.WriteLine("Oj. Lågt tal!"); // else, if number is smaller than 10, this message gets printed
            }

            Console.WriteLine("Vad heter du? ");
            string name = Console.ReadLine()!; // the string variable name gets its value from the user input

            Console.WriteLine($"Hej {name}!"); // a message that greets the user with his/her name

            for (int i = 0; i <= number; i++) // I'm using a for loop that checks every number from 0 to the value of
                                              // the variable number                                              
            {
                Console.WriteLine(i); // printing every number/value that the for loop is checking 
            }
        }
    }
}