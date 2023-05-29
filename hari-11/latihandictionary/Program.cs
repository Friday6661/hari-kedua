using VotingLib;
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        Voting BestPlayer = new Voting();
        BestPlayer.AddCandidate("John");
        BestPlayer.AddCandidate("Stephen");
        BestPlayer.AddVote("John");
        BestPlayer.AccessVote();
        BestPlayer.ClearCandidateVotes();
        BestPlayer.AccessVote();
    }
}