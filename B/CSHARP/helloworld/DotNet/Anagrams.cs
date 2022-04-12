
using System;

public class ProgramAnagram{
    public class Anagram{
         public static bool AnagramAnagram(string s1,string s2)
        {
            if(s1.Length != s2.Length)
              {
                  return false;
              }
              //Convert String to character aarray
              char[] s1CharArray = s1.ToLower().ToCharArray();
              char[] s2CharArray = s2.ToLower().ToCharArray();
              //Sort Array
              Array.Sort(s1CharArray);
              Array.Sort(s2CharArray);
              //Check each character and position
              for(int i=0; i <s1CharArray.Length; i++)
              {
                   if (s1CharArray[i].ToString() != s2CharArray[i].ToString()) 
                   {  
                         return false;  
                   }
              }
              return true;

        }
    }
}

