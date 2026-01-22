using System;

public class RunLengthEncoding
{
	public static string RunLengthEncodings(string originalPhrase){
        int count = 0;
        string newStr = "";
        for(int i = 0; i <= originalPhrase.Length - 1; i++){
            if(i < originalPhrase.Length - 1 && originalPhrase[i] == originalPhrase[i+1]){
                count += 1;
            }else{
                count += 1;
                if(count < 2){
                    newStr = newStr + originalPhrase[i];
                }else{
                    newStr = newStr + count.ToString() + originalPhrase[i];
                }
                count = 0;
            }
        }
        return newStr;
    }

	 public static void Main(string[] args)
    {
        string result = RunLengthEncodings("rrrreeeyypkll");
        Console.WriteLine (result);
    }
}
