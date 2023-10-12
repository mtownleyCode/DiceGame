using DiceRoller.Helpers;
using DiceRoller.Models;

bool continuePlaying = true;

PlayerInput playerInput = new PlayerInput();
Player player = new Player();


Console.WriteLine("Welcome to the Dice Game App.");

while (continuePlaying)
{
    playerInput.GetSidesOfDice(player);

    Console.WriteLine();
        
    playerInput.RollDice(player);
    
    Console.WriteLine();

    continuePlaying = playerInput.ContinuePlaying();

}
