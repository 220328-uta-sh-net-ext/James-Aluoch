
static void Main(string[] args) 
{  
        string s1, s2;
        //Gets words from user.  
        Console.WriteLine("Enter first string");  
        s1 = Console.ReadLine();  
        Console.WriteLine("Enter second string");  
        s2 = Console.ReadLine();  
        Anagram anagram = new Anagram();  
        //Check if words are anagram  
        if (anagram.areAnagram(s1, s2) == true)
         {  
             Console.WriteLine("Both string are anagram string.");  
         } else 
         {  
            Console.WriteLine("Both string are not anagram string.");  
        }  
        Console.ReadLine();  
    
}  



