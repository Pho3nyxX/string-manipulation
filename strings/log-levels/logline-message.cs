using System;

public class Logline
{

    public string Message(string logline){
        string[] logArray = logline.Split(':');
        return logArray[1].Trim();
    }

    static void Main(string[] args)
    {
        Logline log = new Logline();
        string logEntry = "[ERROR]: Invalid operation";
        string result = log.Message(logEntry);
        Console.WriteLine (result);
    }
}
