

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Common;
using System.Threading.Tasks;
using System.IO;
namespace RestRevApp
{
    class Program
    {
        private static String cstring = @"Data source==(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Revature\James-Aluoch\1-C#\RestRevUI\Project-0\password_1.mdf;Integrated Security=True;Connect Timeout=30";
        static void Main(String[] args)
        {

            //main loop through menu and calls methods  based on choice
            string choice;
            //priming read
            DisplayMenu();


            //initialize loop control variable
            choice = Console.ReadLine();

            //loop condition
            while (choice != "-1")
            {
                switch (choice)
                {
                    case "1":
                        //AddNewUser();
                        break;

                    case "2":
                        //SearchUserAdmin();
                        break;
                    case "3":
                        // DisplayRestaurantDetails();
                        break;
                    case "4":
                        // AddReviewToRestaurantAsUser();
                        break;
                    case "5":
                        //ViewDetailsofRestaurantAsUser();
                        break;
                    case "6":
                        // ViewReviewsOfRestaurantAsUser();
                        break;
                    case "7":
                        // CalcRevAveRatingForEachRest();
                        break;
                    case "8":
                        // SearchRestByNameRatZip();
                        break;
                    default:
                        {
                            Console.WriteLine("Invalid entry. Please try again a different choice!");

                            // Console.Clear();
                            DisplayMenu();
                            break;
                        }//end of default
                }//end of switch
                Console.Clear();
                DisplayMenu();
                choice = Console.ReadLine();
            }//end of while


        } //end main

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
            Console.WriteLine("8: Enter 8 to search restaurant by name,rating ,zipcode ,address:");
            Console.WriteLine("-1: To Exit the program:");

            Console.WriteLine("Please enter your choice:");
        }
    }
}
/*
            static void AddNewUser()
            {
                public string getUserPwd { get; set; }  
                public string getpass { get; set; }

                 public string getUserPwd;
                 public string getpassPassword;


                var usr = getuserPwd(cstring);
                if (usr.Rows.Count == 0)
                {
                    Console.WriteLine("Welcome, Please create a user. Password must be between 8-16 characters");
                    string userPwd = Console.ReadLine();
                    Console.WriteLine("Enter Password:: " + userPwd + "length:" + userPwd.length);

                    if (userPwd != null && userPwd.Length >= 8 && userPwd.Length <= 16) ;
                    {
                        var bolen = generateUserPassword(userPwd);
                        if (bolen)
                        {
                            Console.WriteLine("Your password has been created.");
                        }
                        else
                        {
                            Console.WriteLine("Master password cannot be blank. Also make sure length is between 8 -16 characters.");
                        }
                    }
                }
            }
            static bool generateUserPassword(string adminPwd)
            {
                //var bolen = false;
                using (SqlConnection cs = new SqlConnection(cstring))
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("SELECT * FROM USER", cs);
                        cmd.Parameters.AddWithValue("@pass", adminPwd);
                        cs.Open();
                        SqlDataAdapter da = new SqlDataAdapter();
                        cs.Close();

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine();
                        System.Console.WriteLine(ex.ToString());
                    }
                
                }
            } 

            static void AddNewUser()
            {
                AddNewUser usr = new AddNewUser();

                Console.Write("Please enter your login");
                usr.userName = Console.ReadLine();

                Console.Write("Please enter your password.");
                usr.Password = Console.ReadLine();
            }

            static void SearchUserAdmin()
            {
                  private string userName = "admin124", password = "Y8976";
                  private string userName { get; }
                  private string Password { get; set; }
                  private SearchUserAdmin(string userName, string password)
                  {
                       userName = userName;
                       Password = password;
                  }
            }
            static void DisplayRestaurantDetails()
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
        }
    }
}
/*
public string getuserPwd(string userPwd)
{
      return userPwd;
    
}
public void setuserPwd(string userPwd)
{
    this.userPwd = userPwd; 

}
public void userPassword()
{

    StreamReader sr = new StreamReader("password_1.mdf");
    string line = "";    

    while ((line = sr.ReadLine()) != null)
    {
        string[] component = line.Split(" ".ToCharArray().StringSplitOptions.RemoveEmptyEntries);
        users.Add(Components[0]);
        userPwd.Add(Components[1]);

    }
    sr.Close();
}
*/