using System;
using System.Linq;
using System.Collections.Generic;

public class Bob
{
    public string Bobs(string statement){
        string response = "";

        if(IsUpper(statement) == true && statement.EndsWith("?")){
            response = "Calm down, I know what I'm doing!";
        }else if(statement.EndsWith("?")){
            response = "Sure";
        }else if(String.IsNullOrWhiteSpace(statement)){
            response = "Fine. Be that way!";
        }else if(IsUpper(statement) == true){
            response = "Whoa, chill out!";
        }else{
            response = "Whatever";
        }
        return response;
    }
}
