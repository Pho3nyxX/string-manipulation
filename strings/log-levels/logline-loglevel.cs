using System;

public class Logline
{
        public string Level(string logline){
        string[] newLevel = logline.Split(":");
        string result = newLevel[0].ToLower();
        string result1 = result.TrimStart('[');
        string result2 = result1.TrimEnd(']');
        return result2;
    }

    public static void Main(string[] args)
    {
        Logline log = new Logline();
        string leveled = "[ERROR]: Invalid operation";
        string result = log.Level(leveled);
        Console.WriteLine (result);
    }
}
