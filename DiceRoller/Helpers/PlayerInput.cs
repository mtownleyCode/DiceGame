using DiceRoller.Models;

namespace DiceRoller.Helpers
{
    public class PlayerInput
    {
        public void GetSidesOfDice(Player player)
        {
            int validInput;
            
            bool redoLoop = true;

            Console.WriteLine();

            while (redoLoop)
            {
                Console.WriteLine("Enter the number of sides to the dice:");

                if (!int.TryParse(Console.ReadLine(), out validInput) ||
                    validInput < 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter a valid number of sides that is greater than 0.");
                    Console.WriteLine();

                    redoLoop = true;

                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"You chose to have { validInput } sided dice.");
                    
                    player.inputtedNumber = validInput;
                    
                    redoLoop = false;
                }

            }

        }

        public void RollDice(Player player)
        {
            string validAnswer = "";

            bool redoLoop = true;

            DiceGame diceGame = new DiceGame();

            while (redoLoop)
            {
                Console.WriteLine("Would you like to roll the dice now? yes/no");

                validAnswer = Console.ReadLine().ToLower();

                if (!string.IsNullOrEmpty(validAnswer))
                {

                    if (validAnswer != "yes" &&
                        validAnswer != "no")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Enter a valid answer. yes or no");

                    }
                    else if (validAnswer == "yes")
                    {
                        Console.WriteLine();

                        if (player.inputtedNumber == 5 ||
                            player.inputtedNumber == 6)
                        {
                            diceGame.RollTheDice(player);
                        }
                        
                        redoLoop = false;
                    }

                    else { redoLoop = false;  }
                }

            }

        }

        public bool ContinuePlaying()
        {
            string validAnswer = "";

            bool redoLoop = true;
            bool continueDiceGame = false;

            while (redoLoop)
            {
                Console.WriteLine("Do you want to play again? yes/no");

                validAnswer = Console.ReadLine().ToLower();

                if (validAnswer != "yes" &&
                    validAnswer != "no")
                {
                    Console.WriteLine("Enter yes or no only.");
                    Console.WriteLine();
                    redoLoop = true;
                }

                else
                {
                    if (validAnswer == "yes")
                    {
                        Console.WriteLine();
                        Console.WriteLine("You chose to continue.");
                        continueDiceGame = true;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Have a nice day. Goodbye.");
                        continueDiceGame = false;
                    }

                    redoLoop = false;
                }

            }

            return continueDiceGame;

        }
    }
}
