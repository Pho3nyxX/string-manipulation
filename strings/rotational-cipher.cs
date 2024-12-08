using System;

public class RotationalCipher
{
	public static string rotationalCipher(string word, int rotationalNumber){
		string cipherOutput = "";
        for(int i = 0; i <= word.Length -1; i++){
            cipherOutput = cipherOutput + (char)(word[i] + rotationalNumber);
        }
        return cipherOutput;
	}

	 public static void Main(string[] args)
    {
        string cipherResult = rotationalCipher("smile", 3);
        Console.WriteLine(cipherResult);
    }
}
