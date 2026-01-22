using System;

public class RotationalCipher
{
	public static string RotationalCiphers(string word, int rotationalNumber){
		string cipherOutput = "";
        for(int i = 0; i <= word.Length -1; i++){
            cipherOutput = cipherOutput + (char)(word[i] + rotationalNumber);
        }
        return cipherOutput;
	}

	public static void Main(string[] args)
    {
        string cipherResult = RotationalCiphers("smile", 3);
        Console.WriteLine(cipherResult);
    }
}
