using System;

namespace Pizza_order
{
    public class Pizza
    {
        public static decimal Cost;
        public static string Size;
        public static string Cheese;
        public static string Meat;

        //ok make switch case send choice to a table at end display table to user

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pizza Shop!");
            Console.WriteLine("Please use 1, 2, 3, or 4 when making a seletion.");

            //string[] Size = new string[] {small, medium, large };
            // Size[0] = "small";
            //Size[1] = "medium";
            // Size[2] = "large";

            string small = "Small";
            string medium = "Medium";
            string large = "Large";

            int ChoiceSize;
            do
            {
                Console.WriteLine("Please choose a size: 1)Small $9.99 2)Medium $12.99 3)Large $14.99.");
                string SizeChoice = Console.ReadLine();
                ChoiceSize = Convert.ToInt32(SizeChoice);
                switch (ChoiceSize)
                {
                    case 1:
                        Console.WriteLine("You have selected Small for $9.99");
                        string[] SizeSmall = { small };
                        Cost = 9.99m;
                        break;
                    case 2:
                        Console.WriteLine("You have selected Medium for $12.99");
                        string[] SizeMedium = { medium };
                        Cost = 12.99m;
                        break;
                    case 3:
                        Console.WriteLine("You have selected Large for $14.99");
                        string[] SizeLarge = { large };
                        Cost = 14.99m;
                        break;
                    default:
                        Console.WriteLine("Please select a choice useing 1, 2, 3, or 4.");
                        break;
                }
            }
            while (ChoiceSize > 3);
            

            int ChoiceSauce;
            do
            {
                Console.WriteLine("Please choose a sauce 1)marinera 2)alfredo 3)buffalo.");
                string SauceChoice = Console.ReadLine();
                ChoiceSauce = Convert.ToInt32(SauceChoice);

                switch (ChoiceSauce)
                {
                    case 1:
                        Console.WriteLine("You have selected marinera.");                        
                        break;
                    case 2:
                        Console.WriteLine("You have selected alfredo.");
                        break;
                    case 3:
                        Console.WriteLine("You have selected buffalo.");
                        break;
                    default:
                        Console.WriteLine("Please select a choice useing 1, 2, 3, or 4.");
                        break;
                }
            }
            while (ChoiceSauce > 3);

            int CheeseExtra;
            do
            {
                Console.WriteLine("Would you like extra cheese for $0.50? 1)Yes 2)No");
                string ExtraCheese = Console.ReadLine();

                CheeseExtra = int.Parse(ExtraCheese);
                switch (CheeseExtra)
                {
                    case 1:
                        Console.WriteLine("You have selected extra cheese.");
                        Cost += 0.50m;
                        break;
                    case 2:
                        Console.WriteLine("You have selected no extra cheese.");
                        break;
                    default:
                        Console.WriteLine("Please select a choice useing 1 and 2");
                        break;
                }
            }
            while (CheeseExtra > 2);


            int ChoiceMeat;
            do
            {
                Console.WriteLine("Please choose a meat 1)pepperoni 2)italian sausage 3)chicken.");
                string MeatChoice = Console.ReadLine();                
                ChoiceMeat = Convert.ToInt32(MeatChoice);
                switch (ChoiceMeat)
                {
                    case <= 1:
                        Console.WriteLine("You have selected pepperoni.");
                        break;
                    case <= 2:
                        Console.WriteLine("You have selected italian sausage.");
                        break;
                    case <= 3:
                        Console.WriteLine("You have selected chicken.");
                        break;
                    default:
                        Console.WriteLine("Please select a choice useing 1, 2 and 3.");
                        break;
                }
            } 
            while (ChoiceMeat >= 4);

            Console.WriteLine("Your order is a " );
        }       
       
                            
               
    }
}
