using System;

public class Isogram
{
	public string Isograms(string phrase){
		string tempPhrase = "";

        for(int i = 0; i < phrase.Length - 1; i++){
            if(tempPhrase.IndexOf(phrase[i]) != -1){
                return false;
            }else{
                tempPhrase = tempPhrase + phrase[i];
            }
        }
        return true;
	}

	 public static void Main(string[] args)
    {
        bool isogram = Isogram("Real");
        Console.WriteLine (isogram);
    }
}
