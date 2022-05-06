using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Data.SqlClient;
//using Humanizer;


namespace Login
{
    class program
    {
        static string connectionString = @"Data Sourcde=DESKTOP RUIEHG4; DATABASE=database1.mdf; UserID = jim; PASSWORD=password123";
        static Sqlconnection sqlconn = new Sqlconnection(connectionString);

        static void Main(String[] args)
        {
            using(sqlconn)
            {
                try
                {
                    sqlconn.Open();
                    Sqlcommand cmd = new Sqlcommand("SELECT COUNT(*) FROM userT WHERE username=@uname AND PASSWORD= @pass", sqlconn);

                    cmd.Parameters.AddwithValue("@uname", "JAMES");
                    cmd.Parameters.AddwithValue("@pass", "qwerty");
                    int result = (int)cmd.ExecuteScalar();
                    Console.WriteLine(result);
                    sqlconn.Close();
                    if (result > 0)
                    {
                        Console.WriteLine("You have successfully login");

                    }
                    else
                    {
                        Console.WriteLine("You have input the wrong username or password.Please try again!");

                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    Console.ReadLine();
                }
            }
        }
    }
}
