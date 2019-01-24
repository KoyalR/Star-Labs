using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial_Two
{
    class Program
    {

        static void Main(string[] args)
        {

            int TotalClothingCost = 0;

        Shirt:
            Console.WriteLine("Hello and Welcome to Star Clothing. We have various items such as: Shirts, Jeans, Golfers as well as Formal Pants!");
            Console.WriteLine("Please make your selection below");
            Console.WriteLine("Please Select Your Shirt Size : \n1 - Small \n2 - Medium \n3 - Large \n4 - I dont wear shirts");
            int UserChoice = int.Parse(Console.ReadLine());

            switch (UserChoice)
            {
                case 1:
                    TotalClothingCost += 10;  
                    break;
                case 2:
                    TotalClothingCost += 20;  
                    break;
                case 3:
                    TotalClothingCost += 30;  
                    break;
                case 4:
                    TotalClothingCost += 0;
                    break;
                default:
                    Console.WriteLine("Your choice {0} is invaid us", UserChoice);
                    goto Shirt;
            }

            Golfers:

            Console.WriteLine("Please Select Your Golfer Size : \n1 - Small \n2 - Medium \n3 - Large \n4 - I dont wear Golfers");
            int UserChoice1 = int.Parse(Console.ReadLine());

            switch (UserChoice1)
            {
                case 1:
                    TotalClothingCost += 20;  
                    break;
                case 2:
                    TotalClothingCost += 40;
                    break;
                case 3:
                    TotalClothingCost += 60;
                    break;
                case 4:
                    TotalClothingCost += 0;
                    break;
                default:
                    Console.WriteLine("Your choice {0} is invaid us", UserChoice1);
                    goto Shirt;
            }

            Jeans:

            Console.WriteLine("Please Select Your Jean Size : \n1 - Small \n2 - Medium \n3 - Large \n4 - I dont wear jeans");
            int UserChoice2 = int.Parse(Console.ReadLine());

            switch (UserChoice2)
            {
                case 1:
                    TotalClothingCost += 10;  
                    break;
                case 2:
                    TotalClothingCost += 20;  
                    break;
                case 3:
                    TotalClothingCost += 30;  
                    break;
                case 4:
                    TotalClothingCost += 0;
                    break;
                default:
                    Console.WriteLine("Your choice {0} is invaid us", UserChoice2);
                    goto Shirt;
            }

            Formal:

            Console.WriteLine("Please Select Your Pants Size : \n1 - Small \n2 - Medium \n3 - Large \n4 - I dont wear Formal Pants");
            int UserChoice3 = int.Parse(Console.ReadLine());

            switch (UserChoice3)
            {
                case 1:
                    TotalClothingCost += 40; 
                    break;
                case 2:
                    TotalClothingCost += 50;
                    break;
                case 3:
                    TotalClothingCost += 60;
                    break;
                case 4:
                    TotalClothingCost += 0;
                    break;
                default:
                    Console.WriteLine("Your choice {0} is invaid us", UserChoice3);
                    goto Shirt;
            }
        Decide:
            Console.WriteLine("Do you want to do more shopping - YES or NO?");
            string UserDessition = Console.ReadLine();

            switch (UserDessition.ToUpper())
            {
                case "YES":
                    goto Shirt;
                case "NO":
                    break;
                default:
                    Console.WriteLine("Your Choice {0} is invalid, please try again.");
                    goto Decide;

            }

            Console.WriteLine("Thanks you for shopping us.");
            Console.WriteLine("Your total price is = {0}", TotalClothingCost);

            Console.ReadLine();
        }
    }
}


    