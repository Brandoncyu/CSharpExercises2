using System;

namespace CSharpExercises2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conditionals
            ///If/Else
            Console.WriteLine("If/Else");
            int x1 = 101;
            if (x1 < 100)
                Console.WriteLine("This is less than 100");
            else if (x1 == 100)
                Console.WriteLine("This is exactly 100");
            else
                Console.WriteLine("This is more than 100");

            ///Switch
            Console.WriteLine("\nSwitch");

            var dunno = Dunno.Where;

            switch (dunno)
            {
                case Dunno.Who:
                    Console.WriteLine("Dunno Who");
                    break;
                case Dunno.Where:
                    Console.WriteLine("Dunno Where");
                    break;
                case Dunno.What:
                    Console.WriteLine("Dunno What");
                    break;
                case Dunno.When:
                    Console.WriteLine("Dunno When");
                    break;
                case Dunno.Why:
                    Console.WriteLine("Dunno Why");
                    break;
                case Dunno.How:
                    Console.WriteLine("Dunno How");
                    break;
                default:
                    break;
            }

            ///Order of Operations
            Console.WriteLine("\nOrder of Operations");
            string s1 = "string";

            if (s1.Length < 5 || (s1.Length >= 10 && s1.Length % 2 == 0))
                Console.WriteLine("Good Guess!");
            else
                Console.WriteLine("Bad Guess!");

            ///Nested Conditionals
            Console.WriteLine("\nNested Conditionals");
            if (s1.Length < 5)
            {
                Console.WriteLine("Good Guess!");
            } else if (s1.Length >= 10)
            {
                if (s1.Length % 2 == 0)
                    Console.WriteLine("Good Guess!");
                else
                    Console.WriteLine("Bad Guess!");
            }
            else
            {
                Console.WriteLine("Bad Guess!");
            }

            //Loops
            ///While
            Console.WriteLine("\nWhile");
            int x2 = 0;
            string loopString = "01234567890";
            while (x2 < loopString.Length)
            {
                if (x2 % 2 == 1)
                    Console.Write(loopString[x2]);

                x2++;
            }

            ///Do While
            Console.WriteLine("\n\nDo While");
            int x3 = 0;
            do
            {
                if (x3 % 2 == 1)
                    Console.Write(loopString[x3]);

                x3++;
            } while (x3 < loopString.Length);

            ///For
            Console.WriteLine("\n\nFor");
            for (int i = 0; i < loopString.Length; i++)
            {
                if(i % 2 == 1)
                    Console.Write(loopString[i]);
            }

            ///ForEach
            Console.WriteLine("\n\nForEach");
            foreach (var number in loopString)
            {
                int printNumber = int.Parse(number.ToString());
                if (printNumber % 2 == 1)
                    Console.Write(printNumber);

            }

            //Loop Flow Control
            Console.WriteLine("\n\nForEach");
            string loopFlowString = "String Thing";
            char loopFlowChar = 'g';

            for (int i = 0; i < loopFlowString.Length; i++)
            {
                if (loopFlowString[i] == loopFlowChar)
                {
                    Console.WriteLine(i);
                    break;
                }
            }

            Console.ReadLine();
        }

        public enum Dunno
        {
            Who,
            Where,
            What,
            When,
            Why,
            How
        }
    }
}
