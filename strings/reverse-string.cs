using System;

public class ReverseString
{
	public static string ReverseStrings(string phrase){
        string reversedString = "";
        forEach(char letter in phrase){
            reversedString = letter + reversedString;
        }
        return reversedString;
    }

	 public static void Main(string[] args)
    {
        string result = ReverseStrings("strops");
        Console.WriteLine (result);
    }
}
