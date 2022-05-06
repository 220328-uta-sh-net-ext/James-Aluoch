using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_0_0
{
    internal class RestRevApp
    {
        //SqlRepository sqlRepository = new SqlRepository();

        public void Display()
        {
            //declare variables
            int choice =0;

            string star;

            //display menu
            star = "*** *** *** *** ***\n**** **** **** **** ****\n***** ***** ***** ***** *****\n*** *** *** *** ***\n** ** ** ** **\n";
            Console.WriteLine(star);
            //display Menu

            Console.WriteLine(" Options");
            Console.WriteLine("  Display Menu");
    

            Console.WriteLine("1: Enter 1 to add a new user");
            Console.WriteLine("2: Enter 2 to search user admin");
            Console.WriteLine("3: Enter 3 to display details of a restaurant as  user");
            Console.WriteLine("4: Enter 4 to add reviews to a restaurant as  user");
            Console.WriteLine("5: Enter 5 to view details of restaurant as  user");
            Console.WriteLine("6: Enter 6 to view reviews of restaurant as  user");
            Console.WriteLine("7: Enter 7 to calculate reviews of restaurant as user");
            Console.WriteLine("8: Enter 8 to search restaurant by name,rating,zipcode,address");
            Console.WriteLine("-1: Enter -1 to exit the program");
            Console.WriteLine("**  ** ** ** **\n *** *** *** *** ***\n **** **** **** **** ****\n*** *** *** *** ***\n** ** ** ** **\n");
            Console.WriteLine("Enter the menu options:");
            Console.ReadLine();

        }
        public string AddnewUser()
        {
            string inputChoice = Console.ReadLine();

            switch(inputChoice)
            {
                case "1":
                    return "Login";
                case "2":
                    return "signUp";
                case "3":
                    return "searchRestaurant";
                default:
                    Console.WriteLine("Please enter valid number:");
                    Console.ReadLine();
                    return "RestRevApp";
            }
        }

    }
}
