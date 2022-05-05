using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_0
{
    internal class AddNewUser
    {
       try
       {
            //DirectoryEntry DE = new DirectoryEntry("@"Data source == (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Revature\James-Aluoch\1-C#\RestRevUI\Project-0\password_1.mdf;Integrated Security=True;Connect Timeout=30");
            //DirectoryEntryNewUser = DE.Children.Add("TestUser", "User");
            //NewUser.Invoke("SetPassword",new object[] {"#Kmn87654"});
            //NewUser.Invoke("Put", new object[]{"Admin","Test User});
            //NewUser.CommitChanges();
            //DirectoryEntrygrp;

        string connetionString;
         SqlConnection cnn;
         connetionString = @"Data Source=WIN-50GP30FGO75;Initial Catalog=DatabaseDB;User ID=Jim123;Password=Jim@2028";@"Data Source=WIN-50GP30FGO75;Initial Catalog=DatabaseDB;User ID=Jim123;Password=Jim@2028";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            MessageBox.Show("Connection Open  !");
            cnn.Close();

           //grp = DE.Children.Find("Guests","group");
       /* if(grp != null)
        {
           grp.Invoke("Add", new object[] {NewUser.Path.ToString() });
            Console.WriteLine("Account created successfully");
            Console.ReadLine();
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.ReadLine();
        }
       */
        
    }
}
