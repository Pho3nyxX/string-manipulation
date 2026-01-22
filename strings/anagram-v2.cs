using System;
using System.Collections.Generic;

public class Anagram
{
    public List<string> Anagrams(string target, string[] candidates){

        List<string> anagrams = new List<string>();

        for(int i = 0; i < candidates.Length; i++){

            if(target.Length == candidates[i].Length){
                string loweredTarget = target.ToLower();
                string loweredCandidate = candidates[i].ToLower();

                if(!(loweredTarget == loweredCandidate)){
                    // string does not allow sorting so
                    // converting to array to sort
                    // then converting back to string
                    char[] loweredTargetArr = loweredTarget.ToCharArray();
                    char[] loweredCandidateArr = loweredCandidate.ToCharArray();

                    Array.Sort(loweredTargetArr);
                    Array.Sort(loweredCandidateArr);

                    string sortedTarget = new String (loweredTargetArr);
                    string sortedCandidate = new String(loweredCandidateArr);

                    if(sortedTarget == sortedCandidate){
                        anagrams.Add(loweredCandidate);
                    }
                }
            }
        }
        return anagrams;
    }

    public static void Main(string[] args)
    {
       Anagram gram = new Anagram();
        string word = "sTonE";
        string[] wordsCandidates = {"stone", "bone", "tOnes", "Sonet"};

        List<string> result = gram.Anagrams(word, wordsCandidates);
        foreach(string res in result){
            Console.WriteLine (res + ",");
        }
    }
}
