using System;
using System.Collections.Generic;

public class Anagram
{
    public List<string> Anagrams(string target, string[] candidates){
        List<string> anagrams = new List<string>();

        for(int i = 0; i < candidates.Length; i++){
            string loweredTarget = target.ToLower();
            string loweredCandidate = candidates[i].ToLower();

            if(loweredTarget.Length == loweredCandidate.Length){
                if(loweredTarget == loweredCandidate){
                    continue;
                }else{
                    char[] loweredTargetCharArr = loweredTarget.ToCharArray();
                    char[] loweredCandidateCharArr = loweredCandidate.ToCharArray();

                    Array.Sort(loweredTargetCharArr);
                    Array.Sort(loweredCandidateCharArr);

                    string sortedTarget = new String(loweredTargetCharArr);
                    string sortedCandidate = new String(loweredCandidateCharArr);

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
