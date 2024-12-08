using System;
using System.Linq;
using System.Collections.Generic;

public class Bob
{
    public string Bobs(string statement){
        string[] responses = {"Sure.", "Calm down, I know what I'm doing!", "Whoa, chill out!", "Fine. Be that way!", "Whatever."};

            if(statement.EndsWith("?") && statement.All(char.IsUpper)){
                return responses[2];
            }else if(statement.EndsWith("?")){
                return responses[0];
            }else if(statement.All(char.IsUpper)){
                return responses[1];
            }else if(String.IsNullOrWhiteSpace(statement)){
                return responses[3];
            }else{
                return responses[4];
            }
    }

    public static void Main(string[] args)
    {
        Bob bob = new Bob();
        string word = "hey you";
        string result = bob.Bobs(word);
        Console.WriteLine (result);

    }
}
