using System;

namespace Exercicio02.Entitites
{
    class Candidate
    {
        public Candidate(string name, int votes)
        {
            Name = name;
            Votes = votes;
        }

        public string Name { get; set; }
        public int Votes { get; set; }

        
    }
}
