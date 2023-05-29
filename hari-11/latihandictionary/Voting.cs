namespace VotingLib;
using System;
using System.Collections.Generic;
using System.Linq;

public class Voting
{
    Dictionary<string, int> candidateVotes;

    public Voting()
    {
        candidateVotes = new Dictionary<string, int>();
    }

    // Method untuk menambahkan kandidat dengan inisialisasi suara awal 0
    public void AddCandidate(string CandidateName)
    {
        candidateVotes.TryAdd(CandidateName.ToUpper(), 0);
    }

    // Method untuk menambahkan jumlah vote pada kandidat
    // tambahkan contain keys untuk memastikan input sesuai dengan key
    public void AddVote(string CandidateName)
    {
        candidateVotes[CandidateName.ToUpper()] += 1;
    }

    // Method untuk akses element dictionary
    public void AccessVote()
    {
        foreach (KeyValuePair<string, int> kvp in candidateVotes)
        {
            Console.WriteLine($"\nCandidate: {kvp.Key}, Jumlah Vote: {kvp.Value}");
        }
    }

    // Methode untuk menghapus semua element tersimpan
    public void ClearCandidateVotes()
    {
        candidateVotes.Clear();
    }
}