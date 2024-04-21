using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // CultureInfo newCulture = new CultureInfo("tr-TR");
            ConvertExample();
            StringFormatExample();
            IndexofExamples();
            StringSplitExample();
            CreateMethodExample();
            MetodExampleRefereneTypeVsValueType();
            

        }

        public static void ConvertExample()
        {
            // CultureInfo newCulture = new CultureInfo("en-US");            
            Console.WriteLine("Converting Examples");



            decimal myDecimal = 1.23456789m;
            float myFloat = (float)myDecimal;
            Console.WriteLine(myFloat);

            double a = 1.8;
            double b = 2.8;
            Console.WriteLine((int)(a + b));
            Console.WriteLine(Convert.ToInt32(a + b));

            string numberString = "123.45";
            decimal number;

            bool success = Decimal.TryParse(numberString, out number);


            if (success)
            {
                Console.WriteLine("Conversion successful. The decimal number is: " + number);

            }
            else
            {
                Console.WriteLine("Conversion failed.");
            }

        }

        public static void StringFormatExample()
        {
            Console.WriteLine("String Format Examples");
            string name = "John";
            string age = "30";
            string city = "New York";

            // Create a string with the format string and the arguments.
            string message = string.Format("My name is {0} and I am {1} years old. I live in {2}.", name, age, city);
            Console.WriteLine(message);


            string first = "Hello";
            string second = "World";
            Console.WriteLine($"{first} {second}!");
            Console.WriteLine($"{second} {first}!");
            Console.WriteLine($"{first} {first} {first}!");
        }

        public static void IndexofExamples()
        {
            Console.WriteLine("IndexOf Examples");
            string str = "Hello World";
            int index = str.IndexOf("World");
            Console.WriteLine(index);


            string message = "Find what is (inside the parentheses)";

            int openingPosition = message.IndexOf('(');
            int closingPosition = message.IndexOf(')');

            Console.WriteLine(openingPosition);
            Console.WriteLine(closingPosition);

            string messages = "What is the value <tr>between the tags</tr>?";

            const string tag = "<tr>";
            const string endTag = "</tr>";

            int openingPositions = messages.IndexOf(tag);
            int closingPositions = messages.IndexOf(endTag);

            openingPositions += tag.Length;
            int length = closingPositions - openingPositions;
            Console.WriteLine(messages.Substring(openingPositions, length));

            string data = "12345John Smith          5000  3  ";
            string updatedData = data.Remove(5, 20);
            Console.WriteLine(updatedData);



        }

        public static void StringSplitExample()
        {
            Console.WriteLine("String Split Examples");
            string str = "Hello World";
            string[] words = str.Split(' ');
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }

        public static void CreateMethodExample()
        {
            Console.WriteLine("Create Method Examples");
            Console.WriteLine("Generating random numbers:");
            DisplayRandomNumbers();

            void DisplayRandomNumbers()
            {
                Random random = new Random();

                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"{random.Next(1, 100)} ");
                }

                Console.WriteLine();
            }

        }
        public static void MetodExampleRefereneTypeVsValueType()
        {
            Console.WriteLine("Metod Example Referene Type Vs Value Type");
            int a = 3;
            int b = 4;
            int c = 0;

            Multiply(a, b, c);
            Console.WriteLine($"global statement: {a} x {b} = {c}");

            void Multiply(int a, int b, int c)
            {
                c = a * b;
                Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
            }


            int[] array = { 1, 2, 3, 4, 5 };

            PrintArray(array);
            Clear(array);
            PrintArray(array);

            void PrintArray(int[] array)
            {
                foreach (int a in array)
                {
                    Console.Write($"{a} ");
                }
                Console.WriteLine();
            }

            void Clear(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = 0;
                }
            }
        }

    }
}
