using System;

public class program
{
   
    public static bool StrangePair(string str1, string str2)
    {

        if (string.IsNullOrEmpty(str1) && string.IsNullOrEmpty(str2))
        {
            return true;
        }

        if (str1.StartsWith(str2.Substring(str2.Length - 1)) && str2.StartsWith(str1.Substring(str1.Length - 1)))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static void Main()
    {
        String text1;
        String text2;
        Console.WriteLine("Enter a text:");
        text1 = Console.ReadLine();
        text2 = Console.ReadLine();
        bool value= StrangePair(text1,text2);

        Console.WriteLine(value);
        Console.ReadLine();
    }
       
       







    
}