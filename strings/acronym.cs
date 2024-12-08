using System;

public class Acronym
{
    public string Splitter(string phrase){
        string[] splittingPhrase = phrase.Split(' ');

        string acronym = "";

        foreach(string split in splittingPhrase){
            acronym = acronym + split[0];
        }
        return acronym;
    }

    public static void Main(string[] args)
    {
        Acronym acro = new Acronym();
        string givenPhrase = "As Soon As Possible";

        string result = acro.Splitter(givenPhrase);
        Console.WriteLine (result); 
    }
}
