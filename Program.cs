using System;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        
        static void Menu()
        {
            double totalMoney= 11.00;
            DisplayMenu();
            int userChoice = GetMenuChoice();

            
            if(userChoice == 1)
            {
                Console.WriteLine("Toy display");
                Console.WriteLine("1. Mr potato head mustache | $5.00");
                Console.WriteLine("2. Spaceship for buzz lightgear | $10.00");
                Console.WriteLine("3. Cowboy hat for woody | $15.00");
                Console.WriteLine("4. Purse for Barbie | $20.00");
                Console.WriteLine(" Enter your choice:");
            }
            else if (userChoice == 2)
            {
                Console.WriteLine("Give Hamm a coin");
                Console.WriteLine(" 1.Give Hamm a Penny");
                Console.WriteLine(" 2. Give hamm a nickel");
                Console.WriteLine("3. Give Hamm a dime");
                Console.WriteLine("4. Give Hamm a quarter");
                Console.WriteLine("Enter your choice");
            }
            else if (userChoice ==3)
            {
                Console.WriteLine(" User balance");
                Console.WriteLine("Hamm's balance");
            }
            else 
            {
                return;
            }
            
        }
        static void DisplayMenu()
        {
            Console.WriteLine("1. Buy an item");
            System.Console.WriteLine("2. Give Hamm a Coin");
            System.Console.WriteLine("3. Check Money Balance");
            System.Console.WriteLine("4. Exit the program");
        }
        static int GetMenuChoice()
        {
            System.Console.WriteLine("Enter your choice:");
            int menuChoice = int.Parse(Console.ReadLine()!);

            while(menuChoice < 1 || menuChoice > 4)
            {
                System.Console.WriteLine("Invalid choice. Please enter a choice from the menu");
                System.Console.WriteLine("Enter a choice");
                menuChoice = int.Parse(Console.ReadLine()!); //update read 
            }
            return menuChoice;
        }
        static void BuyItem(ref double totalMoney) 
        {
            DisplayToys();
            int toyChoice = int.Parse(Console.ReadLine()!);

            while(toyChoice < 1 || toyChoice > 4)
            {
                System.Console.WriteLine("Invalid choice. Please enter a choice from the menu");
                System.Console.WriteLine("Enter a choice:");
                toyChoice = int.Parse(Console.ReadLine()!); //update read
            }
            Transaction(toyChoice, ref totalMoney);
        }
        static void DisplayToys()
        {
            System.Console.WriteLine("1.");
        }
        static void Transaction(int toyChoice, ref double totalMoney)
        {
            if(toyChoice == 1 && totalMoney >= 5)
            {
                System.Console.WriteLine("You have purchased a Mr. Potato Head Mustache");
                totalMoney -=5;

            }
            else if( toyChoice == 2 && totalMoney>= 10)
            {
                System.Console.WriteLine("You have purchased a spaceship for Buzz lightgear");
                totalMoney -=10;
            }  
            else if(toyChoice == 3 && totalMoney >= 15)
            {
                System.Console.WriteLine("You have purchased a cowboy hat for woody");
                totalMoney-=15;
            }         
            else if(toyChoice == 4 && totalMoney >= 20)
            {
                System.Console.WriteLine("You have purhcased a purse for barbie");
                totalMoney -=20;
            }
            else
            {
                System.Console.WriteLine("Oops! You do not have enough money to purchase this item");

            }
            Console.WriteLine("Remaining balance"+totalMoney);
        }
    }
}
