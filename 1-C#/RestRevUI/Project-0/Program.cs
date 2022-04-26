using System.Text;
using System.Threading.Tasks;
namespace RestRevApp
{
    class program
    {
        static void Main(string[] args)
        { 
            //main loop through menu and calls methods  based on choice
             string choice;
            //priming read
             DisplayMenu();
            //initialize loop control variable
            choice = Console.ReadLine();

            //loop condition
            while(choice != "-1")
            {
                switch(choice)
                {
                    case  "1":
                            AddNewUser();
                        break;

                     case  "2": 
                            SearchUserAdmin();
                        break;
                    case "3":
                            DisplayRestaurantDetails();
                        break;
                    case "4":
                            AddReviewToRestaurantAsUser();
                        break;
                    case  "5":
                            ViewDetailsofRestaurantAsUser();
                        break;
                    case  "6":
                            ViewReviewsOfRestaurantAsUser();
                        break;
                    case "7":
                            CalcRevAveRatingForEachRest();
                        break;
                    case  "8":
                            SearchRestByNameRatZip();
                        break;
                    default:
                        {
                            Console.WriteLine("Invalid entry. Please try again a different choice!");

                           // Console.Clear();
                            DisplayMenu();
                            break;
                        }//end of default
                }//end of switch
            }
            // DisplayMenu();
            choice = Console.ReadLine();
        }
    }//end while
}//end main
 static void DisplayMenu()
{
   
    Console.WriteLine("Menu");
    Console.WriteLine("1: Enter 1 to add a new user:");
    Console.WriteLine("2: Enter 2 to search  user admin:");
    Console.WriteLine("3: Enter 3 to display details of a restaurant as a user:");
    Console.WriteLine("4: Enter 4 to add reviews to a restaurant as a user:");
    Console.WriteLine("5: Enter 5 to view details of restaurant as user:");
    Console.WriteLine("6: Enter 6 to view reviews of restaurant as a user:");
    Console.WriteLine("7: Enter 7 to Calculate reviews' average rating for each restaurant");
    Console.WriteLine("8: To search restaurant by name,rating ,zipcode ,address:");
    Console.WriteLine("-1: To Exit the program:");

    Console.WriteLine("Please enter your choice:"); 
          
static void AddNewUser()
{

}
static void SearchUserAdmin()
{

}
static void  DisplayRestaurantDetails()
{

}
static void AddReviewToRestaurantAsUser()
{

}
static void ViewDetailsofRestaurantAsUser()
{

}
static void ViewReviewsOfRestaurantAsUser()
{

}
static void CalcAveRatingForEachRest()
{

}
static void SearchRestByNameRatZip()
{

}