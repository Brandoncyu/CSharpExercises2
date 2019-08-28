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
                if (i % 2 == 1)
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

            //Arrays
            ///Single dimensional arrays
            Console.WriteLine("\nSingle dimensional arrays");
            int[] newArray = new int[10];

            int arrayNo = 0;

            while (arrayNo < 10)
            {
                newArray[arrayNo] = arrayNo + 1;
                arrayNo++;
            }
            Console.WriteLine("Use a for loop to print the contents of the array in reverse order.");

            for (int i = newArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(newArray[i]);
            }

            Console.WriteLine("\nWrite code that prints the sum of all numbers in the array");

            int arraySum = 0;

            for (int i = 0; i < newArray.Length; i++)
            {
                arraySum += newArray[i];
            }

            Console.WriteLine(arraySum);


            Console.WriteLine("\nWrite code that prints the sum of all numbers in the array");
            string arrayContents = string.Join(", ", newArray);

            Console.WriteLine(arrayContents);

            ///multiple dimensional arrays
            Console.WriteLine("\nMultiple dimensional arrays");
            Console.WriteLine("\nUse any loop(s) to store the product of the two indices in each element, Print the contents of the array using a foreach loop");
            var threeDArray = new int[3, 4];

            for (int i = 0; i < threeDArray.GetLength(0); i++)
            {
                for (int j = 0; j < threeDArray.GetLength(1); j++)
                {
                    threeDArray[i, j] = i * j;
                }
            }

            for (int i = 0; i < threeDArray.GetLength(0); i++)
            {
                for (int j = 0; j < threeDArray.GetLength(1); j++)
                {
                    Console.Write("int[{0}, {1}]: ", i, j);
                    Console.WriteLine(threeDArray[i, j]);
                }
            }

            //Function
            ///Basic Function
            Console.WriteLine("\nBasic Function");
            Console.WriteLine("\nWrite a function that prints out whatever string you pass into it. " +
                "Call the function to make sure it works.");
            StringPrint("Hello World");

            Console.WriteLine("\nWrite a function that concatenates three strings and returns the result. " +
                "Call the function to make sure it works.");
            string ConcatenateString = CocatenateString("Hello", " There", " World!");
            Console.WriteLine(ConcatenateString);

            Console.WriteLine("\nWrite a function that takes in an int array, an int index, and an int value. " +
                "The function should update the array at the specified index with the specified value. " +
                "If the index is out of range, the function should do nothing. " +
                "Call the function to make sure it works.");
            int[] functionArray = { 1, 2, 3, 5, 5 };

            int[] newFunctionArray = UpdateArray(functionArray, 3, 4);
            Console.WriteLine(string.Join(", ", newFunctionArray));

            Console.WriteLine("\nWrite a function that takes in a string and " +
                "returns a new string that contains every other word " +
                "(starting from the first) in the original. " +
                "Call the function to make sure it works.");

            string functionString = "To be or not to be";
            string returnedString = everyOtherString(functionString);

            Console.WriteLine(returnedString);

            Console.WriteLine("\nWrite a function that takes in a string, an " +
                "optional int parameter called index, and an optional int " +
                "parameter called length. The function should return a " +
                "substring of the original string starting at the specified " +
                "index, with the specified length. " +
                "Call the function to make sure it works.");

            string functionSubString = "Hello World";
            string returnedFunctionSubString = subStringFunc(functionSubString, 2, 2);

            Console.WriteLine(returnedFunctionSubString);

            ///Reference type equality
            Console.WriteLine("\nReference type equality");
            Console.WriteLine("\nWrite a function called AreArraysEqual that " +
                "returns bool. The function should take in two int arrays and " +
                "return whether they contain the same elements, " +
                "in the same order. Call the function to make sure it works.");

            int[] functionArray1 = { 1, 2, 3, 4, 5 };
            int[] functionArray2 = { 1, 2, 3, 4, 6 };

            Console.WriteLine(AreArraysEqual(functionArray1, functionArray2));

            ///Output parameters
            Console.WriteLine("\nOutput parameters");
            Console.WriteLine("\nWrite a function that returns void with two " +
                "int input parameters. The function should have four output " +
                "parameters that should return the sum, difference, product, " +
                "and quotient of the two inputs. " +
                "Call the function to make sure it works");
            int operatorInt1 = 6;
            int operatorInt2 = 3;
            int sum, difference, product, quotient;

            Operators(operatorInt1, operatorInt2, out sum, out difference, out product, out quotient);
            Console.WriteLine("operatorInt1: " + operatorInt1);
            Console.WriteLine("operatorInt2: " + operatorInt2);
            Console.WriteLine("out sum: "+ sum);
            Console.WriteLine("out difference: " + difference);
            Console.WriteLine("out product: " + product);
            Console.WriteLine("out quotient: " + quotient);

            ///Reference parameters
            Console.WriteLine("\nReference parameters");
            Console.WriteLine("\nWrite a function that takes in a string and a " +
                "reference to an int. The function should return the character " +
                "at the index specified by the int.");

            Console.WriteLine(ReferenceParam("Hello World!", -1));
            Console.WriteLine(ReferenceParam("Hello World!", 4));
            Console.WriteLine(ReferenceParam("Hello World!", 60));

            Console.ReadLine();
        }

        public static void StringPrint(string thing)
        {
            Console.WriteLine(thing);
        }

        public static string CocatenateString(string string1, string string2, string string3)
        {
            return string1 + string2 + string3;
        }

        public static int[] UpdateArray(int[] array, int index, int newValue)
        {
            if (index >= array.Length)
                return array;
            else
            {
                array[index] = newValue;
                return array;
            }
        }

        public static string everyOtherString(string string1)
        {
            string string2 = "";
            string[] stringArray = string1.Split();
            for (int i = 0; i < stringArray.Length; i += 2)
            {
                string2 += stringArray[i] + " ";
            }
            return string2;
        }

        public static string subStringFunc(string string1, int index = 0, int length = 0)
        {
            if (index >= string1.Length || length >= string1.Length)
                return "";

            if (length == 0)
                return string1.Substring(index);
            else
                return string1.Substring(index, index + length - 1);
        }

        public static bool AreArraysEqual(int[] array1, int[] array2)
        {
            return string.Join(", ", array1) == string.Join(", ", array2);
        }

        public static void Operators(int int1, int int2, out int add,
            out int minus, out int mult, out int div)
        {
            add = int1 + int2;
            minus = int1 - int2;
            mult = int1 * int2;
            div = int1 / int2;
        }

        public static char ReferenceParam(string string1, int index)
        {
            if (index < 0)
                return string1[0];
            else if (index > string1.Length - 1)
                return string1[string1.Length - 1];
            else
                return string1[index];
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
