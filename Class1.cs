using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


    public class Team
    {
        public string teamName = String.Empty;
        public int noOfPlayers;
        public Team(string tn, int pc)
        {
            teamName = tn;
            noOfPlayers = pc;
        }
        public bool AddPlayer(int count)
        {
            if (noOfPlayers < 0)
            {
                return false;
            }
            else
            {
                noOfPlayers = noOfPlayers - count;
                return true;
            }

        }

    }

    public class Subteam : Team
    {
        public Subteam(string tName, int nPlayer)
        : base(tName, nPlayer)
        {
        }
        public void ChangeTeamName(string name)
        {
            teamName = name;
        }
    }
    public static void Main(String[] args)
    {
    }
}