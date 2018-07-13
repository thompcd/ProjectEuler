using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libraries;

namespace DailyProgrammer
{
    public class _361_TallyProgram : DailyProgrammerChallenge
    {
        //challenge input

        //string _scoreString = "EbAAdbBEaBaaBBdAccbeebaec";
        string _scoreString = String.Empty;

        public override void LoadParameters(string input)
        {
            _scoreString = input;
        }

        public override string Solve()
        {
            var playerList = new List<Player> { };

            foreach (char c in _scoreString)
            {
                if (!playerList.Any(p => p.Name.ToLower().Equals(c.ToString().ToLower())))
                {
                    //create player only for ascii alphabet chars
                    if ((65 <= c && c <= 90) || (97 <= c && c <= 122))
                    {
                        playerList.Add(new Player(c.ToString().ToLower()));
                    }
                    //move to next char otherwise
                    else continue;
                }

                var player = playerList.FirstOrDefault(p => p.Name == c.ToString().ToLower());
                player.AddScore(c);
            }
            //sort from highest to lowest score
            playerList.Sort((p1, p2) => p2.Score.CompareTo(p1.Score));
            var sb = new StringBuilder();
            foreach (var player in playerList)
            {
                sb.AppendLine(player.ToString());
            }
            return sb.ToString();
        }

        private class Player
        {
            public Player(string name, int score = 0)
            {
                Name = name;
            }

            public string Name { get; private set; }

            public int Score { get; private set; }

            public override string ToString()
            {
                return Name + " : " + Score.ToString();
            }

            public void AddScore(char c)
            {
                //ascii uppers
                if (65 <= c && c <= 90)
                    Score--;
                //ascii lowers
                if (97 <= c && c <= 122)
                    Score++;
            }
        }
    }
}
