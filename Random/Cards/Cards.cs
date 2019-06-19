using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class HandsOfCards
    {
        
        public static void Main()
        {
            PlayTheGame();
        }

        private static Dictionary<string,int> PlayTheGame()
        {
            //collect input data
            var players = new Dictionary<string, HashSet<string>>();
            var input = Console.ReadLine();

            while(input != "JOKER")
            {
                var separator = input.IndexOf(':');
                if(separator < 0)
                {
                    break;
                }
                var name = input.Substring(0, separator);
                if(!players.ContainsKey(name))
                {
                    players[name] = new HashSet<string>();
                }

                var cards = input.Substring(separator + 1).Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach(var card in cards)
                {
                    players[name].Add(card);
                }

                input = Console.ReadLine();
            }

            //calculate the total values of each player
            var gameResult = new Dictionary<string,int>();

            foreach (var player in players)
            {
                gameResult[player.Key] = //some code calculate
            }
        }
        private static int GetTotalValue(HashSet<string> hand)
        {
            var result = 0;
            foreach(var card in hand)
            {

            }
        }
    }
}
