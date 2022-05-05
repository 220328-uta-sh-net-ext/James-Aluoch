using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_0
{
    internal class RestaurantUI
    {

        //Create and configure our logger
        private static String cstring = @"Data source==(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Revature\James-Aluoch\1-C#\RestRevUI\Project-0\password_1.mdf;Integrated Security=True;Connect Timeout=30";

        /*
        //main loop through menu and calls methods  based on choice
        bool choice = true;
        Imenu menu = new MainMenu();

            //loop condition
            while (choice)
            {
              menu.Display();

               string AsUser = menu.UserChoice();

                switch (AsUser)
                {
                    case "AddNewUser":
                         //Call addNewUser method
                         Console.WriteLine("Add a new user");
                        //AddNewUser();
                        break;

                    case "SearchUserAdmin":
                         Console.WriteLine("Search for user Admin");
                        //SearchUserAdmin();
                        break;
                    case "DisplayRestaurantDetails":
                        Console.WriteLine("Display restaurant details");

                         //DisplayRestaurantDetails();
                        break;
                    case "AddReviewToRestaurantAsUser":
                        Console.WriteLine("Add review to restaurant as user");
                        //AddReviewToRestaurantAsUser();
                        break;
                    case "ViewDetailsofRestaurantAsUser":
                           Console.WriteLine("View details of restaurant as user");
                        //ViewDetailsofRestaurantAsUser();
                        break;
                    case "ViewReviewsOfRestaurantAsUser":
                         Console.WriteLine("view reeviews of restaurant as user");
                       // ViewReviewsOfRestaurantAsUser();
                        break;
                    case "CalcRevAveRatingForEachRest":

                        // CalcRevAveRatingForEachRest();
                        break;
                    case "SearchRestByNameRatZip":
                        //SearchRestByNameRatZip();
                        break;
                    case "MainMenu":
                        menu = new MainMenu();
                        break;
                    case "Exit":
                        choice = false;
                    default:
                        {
                          Console.WriteLine("Invalid entry. Please try again a different choice!");
                          Console.WriteLine("Please press enter to continue");
                          Console.ReadLine();
                            break;
                         }//end of default
                    }//end of switch
            }//end of while

        */
    }
}
