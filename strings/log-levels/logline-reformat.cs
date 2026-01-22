using System;

public class Logline
{

    public string Message(string logline){
        string[] logArray = logline.Split(':');
        return logArray[1].Trim();
    }

    public string Level(string logline){
        string[] newLevel = logline.Split(":");
        string result = newLevel[0].ToLower();
        string result1 = result.TrimStart('[');
        string result2 = result1.TrimEnd(']');
        return result2;
    }

    public string Reformat(string logline){

        string first = Message(logline);
        string second = Level(logline);

        return $"{first} ({second})";
    }

    public static void Main(string[] args)
    {
        Logline log = new Logline();
        string leveled = "[ERROR]: Invalid operation";

        string result = log.Reformat(leveled);
        Console.WriteLine (result);
    }
}
