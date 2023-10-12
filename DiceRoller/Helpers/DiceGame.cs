using DiceRoller.Models;
using System.ComponentModel.Design;

namespace DiceRoller.Helpers
{
    public class DiceGame
    {
        public void RollTheDice(Player player)
        {
            var rnd = new Random();

            player.dice1 = rnd.Next(1, player.inputtedNumber + 1);
            player.dice2 = rnd.Next(1, player.inputtedNumber + 1);

            if (player.inputtedNumber == 5)
            {
                Console.WriteLine(CheckGenericScenarios(player.dice1, player.dice2, "Extra Challenges"));
                Console.WriteLine(CheckWinLoseScenarios(player.dice1, player.dice2, "Extra Challenges"));
            }
            else if (player.inputtedNumber == 6)
            {
                Console.WriteLine(CheckGenericScenarios(player.dice1, player.dice2));
                Console.WriteLine(CheckWinLoseScenarios(player.dice1, player.dice2));
            }

        }

        private static string CheckGenericScenarios(int dice1, int dice2)
        {
            if (dice1 == 1 && dice2 == 1)
            {
                return "Snake Eyes";
            }
            else if ((dice1 == 1 || dice1 == 2) &&
                     (dice2 == 1 || dice2 == 2) && 
                      dice2 != dice1)
            {
                return "Ace Duece";
            }
            else if (dice1 == 6 && dice2 == 6)
            {
                return "Box Cars";
            }
            else { return ""; }
        }

        private static string CheckWinLoseScenarios(int dice1, int dice2)
        {
            if (dice1 + dice2 == 7 ||
                dice1 + dice2 == 11)
            {
                return "You Win!";
            }
            else if (dice1 + dice1 == 2 || 
                     dice1 + dice2 == 3 ||
                     dice1 + dice2 == 12)
            {
                return "Craps";
            }
            else { return ""; }
            
        }

        private static string CheckGenericScenarios(int dice1, int dice2, string extra)
        {
            if (dice1 == 2 && dice2 == 2)
            {
                return "Ballerina";
            }
            else if ((dice1 == 2 || dice1 == 3) &&
                     (dice2 == 2 || dice2 == 3) && 
                      dice2 != dice1)
            {
                return "Michael Jordan";
            }
            else if (dice1 == 4 & dice2 == 4)
            {
                return "Square Pair";
            }
            else { return ""; }
        }

        private static string CheckWinLoseScenarios(int dice1, int dice2, string extra)
        {
            if (dice1 + dice2 == 21)
            {
                return "Blackjack! Ooops, wrong game.";
            }
            else if ((dice1 == 1 || dice1 == 2) &&
                     (dice2 == 1 || dice2 == 2) &&
                      dice2 != dice1)
            {
                return "Got 'em with the old 1 2";
            }
            else { return ""; }

        }

    }

}
