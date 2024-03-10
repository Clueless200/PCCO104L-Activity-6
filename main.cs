using System;
class Program{
    static void Main(string[] args){

    bool conChoice = false;
        while (!conChoice){  
        Console.Write("Select activity from 1 - 5: ");
        string choices = Console.ReadLine();

        if(choices.ToLower() == "exit"){
            Console.Write("Closing program...");
            break;
        }

         if (!int.TryParse(choices, out int actchoice)){
            Console.WriteLine("Invalid input.");
            continue;
        }

        switch (choices)
            {
                case "1":
                    Activity1();
                    break;
                case "2":
                    Activity2();
                    break;
                case "3":
                    Activity3();
                    break;
                case "4":
                    Activity4();
                    break;
                case "5":
                    Activity5();
                    break;
                default:
                    Console.WriteLine("Activity does not exist.");
                    break;
            }
        }
    }

    static void Activity1()
    {
        var go = true;
        Console.WriteLine("Activity 1: PH money denomination");
        while (go)
        {
            Console.Write("Enter a value: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                Console.WriteLine("\nReturning to main menu...");
                break;
            }

            decimal bills;
            if (!decimal.TryParse(input, out bills))
            {
                Console.WriteLine("Invalid denomination. only decimal and integer will be accep");
                continue;
            }

            if (bills == 0.01m || bills == 0.05m || bills == 0.25m)
            {
                Console.WriteLine("No person is found");
            }
            else if (bills == 1)
            {
                Console.WriteLine("Jose Rizal is found in Php." + bills);
            }
            else if (bills == 5)
            {
                Console.WriteLine("Emilio Aguinaldo in Php." + bills);
            }
            else if (bills == 10)
            {
                Console.WriteLine("Andres Bonifacio & Apolinario Mabini is found in Php. " + bills);
            }
            else if (bills == 20)
            {
                Console.WriteLine("Manuel L. Quezon is found in Php. " + bills);
            }
            else if (bills == 50)
            {
                Console.WriteLine("Sergio Osmena is found in Php. " + bills);
            }
            else if (bills == 100)
            {
                Console.WriteLine("Manuel Roxas is found in Php. " + bills);
            }
            else if (bills == 200)
            {
                Console.WriteLine("Diosdado Macapagal is found in Php. " + bills);
            }
            else if (bills == 500)
            {
                Console.WriteLine("Benigno Sr. & Corazon Aquino is found in Php. " + bills);
            }
            else if (bills == 1000)
            {
                Console.WriteLine("Jose Abad Santos, Vicent Lim, & Josefa Llanes Escoda is found in Php. " + bills);
            }
            else
            {
                Console.WriteLine("Invalid Denomination");
            }
        }
    }

         static void Activity2()
         {
        for (int i = 1; i < 31; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i + " - Foo");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine(i + " - Bar");
            }
            else if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine(i + " - FooBar");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }

       static void Activity3(){

        int previousNum = 0;
        string message = "";

        while (true)
        {
            Console.Write("Enter something: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                Console.WriteLine("Program Exitting.");
                break;
            }

            int num;
            bool isNumeric = int.TryParse(input, out num);

            if (isNumeric)
            {
                int currentNum = int.Parse(input);
                int sum = previousNum + currentNum;
                Console.WriteLine($"Adding {previousNum} to {currentNum} = {sum}.");
                previousNum = currentNum;
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(message))
                {
                    Console.WriteLine($"Current Message is: {message}{input}");
                }
                else
                {
                    Console.WriteLine($"Current Message is: {input}");
                }
                message += input + " ";
            }
        }
    }

            static void Activity4(){
            int num;
            while (true)
            {
                Console.WriteLine("Enter a number: ");
                string sam = Console.ReadLine();

                if (int.TryParse(sam, out num))
                {
                    if (num == 0)
                    {
                        Console.WriteLine("Exiting Program ");
                        break;
                    }
                    else if (num == 0)
                    {
                        break;
                    }

                    {
                        printTriangle(num);
                    }
                }
                else
                {
                    Console.WriteLine($"Invalid Value : {sam}. ");
                }
            }
        }
        static void printTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }



            static void Activity5() {
    Console.WriteLine("\nActivity 5: Sum vs Append");
    Console.Write("Enter something: ");

    var message1 = "";
    var previousNum = 0; 
    var tuloy1 = true;

    while (tuloy1) {
        string input = Console.ReadLine();
        if (input.ToLower() == "exit") {
            Console.WriteLine("\nClosing program...");
            break;
        }

        bool isNumeric = int.TryParse(input, out int num);

        if (isNumeric) {
            int currentNum = int.Parse(input);
            int sum = previousNum + currentNum;
            Console.WriteLine($"Adding {previousNum} to {currentNum} = {sum}");
            previousNum = currentNum;
        }
        else {
            message1 += input + " ";
        }
        Console.WriteLine("Current message: " + message1);
        Console.Write("Enter something: ");
        }
    }

}