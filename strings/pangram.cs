using System;

public class Pangram
{
	public static bool isPangram(string sentence){
		string lowercaseSentence = sentence.ToLower();

        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        for(int i = 0; i <= alphabet.Length - 1; i++){
            if(!lowercaseSentence.Contains(alphabet[i])){
                return false;
            }
        }
        return true;
	}

	 public static void Main(string[] args)
    {
        bool result = isPangram("The quick brown fox jumps over the lazy dog");
        Console.WriteLine (result);
    }
}
