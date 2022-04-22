 

public static void Main(string[] args)
{
            Console.WriteLine(new Program().Palindrome("madam"));
        
         static bool Palindrome(string s) 
		{
            int end = s.Length-1;

            for (int i = 0, j = end; i < end; i++, j--)
            {
                char firstLetter = s[i];	//Char.ToLower(s[i]);
                char lastLetter = s[j];	//Char.ToLower(s[i]);

                if (firstLetter != lastLetter) return false;
            }   
            return true;
        }        

}
