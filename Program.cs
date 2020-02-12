using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
  class Program
  {
    static void Main(string[] args)
    {
      static string displayComputerInput(string input)
      {
        // Display computer input to console
        var message = "The computer chose " + input + ".";
        return message;
      }

      // Welcome user
      Console.WriteLine("Welcome to the fantastic Rock, Paper, Scissors, Spock, and Lizard game!");

      var continuePlaying = true;
      while (continuePlaying)
      {
        var tieMessage = "Tie game, try again!";
        var winMessage = "You win!";
        var loseMessage = "You lose, try again!";
        // Inform the user of 3 levels of difficulty
        Console.WriteLine("This game has 3 levels of difficulty: Easy, Normal, and Impossible. Please select an option.");
        // Ask user to choose difficulty
        var difficulty = Console.ReadLine().ToLower();
        // valid the difficulty level 
        while (difficulty != "easy" && difficulty != "normal" && difficulty != "impossible")
        {
          Console.WriteLine("I'm sorry, you did not choose a valid difficulty. Please try again.");
          difficulty = Console.ReadLine().ToLower();
        }
        // Inform user about 3 choices: rock paper or scissors
        Console.WriteLine("Please select an option. You have five choices: rock, paper, or scissors, spock, and lizard.");
        // Get feedback from user and store it in userInput variable
        var userInput = Console.ReadLine().ToLower();
        // validate userInput
        while (userInput != "rock" && userInput != "paper" && userInput != "scissors" && userInput != "spock" && userInput != "lizard")
        {
          Console.WriteLine("You did not enter a valid option for the game.");
          Console.WriteLine("Please select an option. You have five choices: rock, paper, scissors, spock, or lizard.");
          userInput = Console.ReadLine();
        }

        // Display user input to console
        Console.WriteLine("You chose " + userInput + ".");

        // var gameresults = new Dictionary<string, string>{
        //   new {"rock-rock", "tie game"}
        // }

        // Console.WriteLine(gameresults[userInput + "-" + computerChoice])


        // Set up game difficulties
        // Declare computer input variable to later assign a value in the if statements
        var computerInput = "";
        if (difficulty == "easy")
        {
          if (userInput == "rock")
          {
            computerInput = "scissors";
            // Display computer input to console
            Console.WriteLine(displayComputerInput(computerInput));
            Console.WriteLine(winMessage);
          }
          else if (userInput == "paper")
          {
            computerInput = "rock";
            // Display computer input to console
            Console.WriteLine(displayComputerInput(computerInput));
            Console.WriteLine(winMessage);
          }
          else if (userInput == "scissors")
          {
            computerInput = "paper";
            // Display computer input to console
            Console.WriteLine(displayComputerInput(computerInput));
            Console.WriteLine(winMessage);
          }
          else if (userInput == "lizard")
          {
            computerInput = "spock";
            // Display computer input to console
            Console.WriteLine(displayComputerInput(computerInput));
            Console.WriteLine(winMessage + " Lizard poisons Spock.");
          }
          else if (userInput == "spock")
          {
            computerInput = "rock";
            // Display computer input to console
            Console.WriteLine(displayComputerInput(computerInput));
            Console.WriteLine(winMessage + " Spock vaporizes rock.");
          }
        }
        else if (difficulty == "normal")
        {
          // Get random input from computer
          // List that the computer can pick
          string[] options = { "rock", "paper", "scissors", "spock", "lizard" };
          var random = new Random();
          // Generate a random index less than the length of the array and store into computerInput variable
          var computerInputInt = random.Next(options.Length);

          var computerInputStr = options[computerInputInt].ToLower();

          Console.WriteLine("The computer chose " + computerInputStr + ".");

          if (userInput == "rock")
          {
            if (computerInputStr == "rock")
            {
              Console.WriteLine(tieMessage);
            }
            else if (computerInputStr == "paper")
            {
              Console.WriteLine(loseMessage);
            }
            else if (computerInputStr == "scissors")
            {
              Console.WriteLine(winMessage);
            }
            else if (computerInputStr == "lizard")
            {
              Console.WriteLine(winMessage + " Rock crushes lizard.");
            }
            else if (computerInputStr == "spock")
            {
              Console.WriteLine(loseMessage + " Spock vaporizes rock.");
            }
          }
          else if (userInput == "paper")
          {
            if (computerInputStr == "paper")
            {
              Console.WriteLine(tieMessage);
            }
            else if (computerInputStr == "rock")
            {
              Console.WriteLine(winMessage);
            }
            else if (computerInputStr == "scissors")
            {
              Console.WriteLine(loseMessage);
            }
            else if (computerInputStr == "lizard")
            {
              Console.WriteLine(loseMessage + " Lizard eats paper.");
            }
            else if (computerInputStr == "spock")
            {
              Console.WriteLine(winMessage + " Paper disproves Spock.");
            }
          }
          else if (userInput == "scissors")
          {
            if (computerInputStr == "scissors")
            {
              Console.WriteLine(tieMessage);
            }
            else if (computerInputStr == "rock")
            {
              Console.WriteLine(loseMessage);
            }
            else if (computerInputStr == "paper")
            {
              Console.WriteLine(winMessage);
            }
            else if (computerInputStr == "lizard")
            {
              Console.WriteLine(winMessage + " Scissors decapitates lizard.");
            }
            else if (computerInputStr == "spock")
            {
              Console.WriteLine(loseMessage + " Spock smashes scissors.");
            }
          }
          else if (userInput == "spock")
          {
            if (computerInputStr == "spock")
            {
              Console.WriteLine(tieMessage);
            }
            else if (computerInputStr == "rock")
            {
              Console.WriteLine(winMessage + " Spock vaporizes rock.");
            }
            else if (computerInputStr == "paper")
            {
              Console.WriteLine(loseMessage + " Paper disproves Spock.");
            }
            else if (computerInputStr == "lizard")
            {
              Console.WriteLine(loseMessage + " Lizard poisons Spock.");
            }
            else if (computerInputStr == "scissors")
            {
              Console.WriteLine(winMessage + " Spock smashes scissors.");
            }
          }
          else if (userInput == "lizard")
          {
            if (computerInputStr == "scissors")
            {
              Console.WriteLine(loseMessage + " Scissors decapitates lizard.");
            }
            else if (computerInputStr == "rock")
            {
              Console.WriteLine(loseMessage + " Rock crushes lizard.");
            }
            else if (computerInputStr == "paper")
            {
              Console.WriteLine(winMessage + " Lizard eats paper.");
            }
            else if (computerInputStr == "lizard")
            {
              Console.WriteLine(tieMessage);
            }
            else if (computerInputStr == "spock")
            {
              Console.WriteLine(winMessage + " Lizard poisons Spock.");
            }
          }
        }
        else if (difficulty == "impossible")
        {
          if (userInput == "rock")
          {
            computerInput = "paper";
            // Display computer input to console
            Console.WriteLine(displayComputerInput(computerInput));
            Console.WriteLine(loseMessage);
          }
          else if (userInput == "paper")
          {
            computerInput = "scissors";
            // Display computer input to console
            Console.WriteLine(displayComputerInput(computerInput));
            Console.WriteLine(loseMessage);
          }
          else if (userInput == "scissors")
          {
            computerInput = "rock";
            // Display computer input to console
            Console.WriteLine(displayComputerInput(computerInput));
            Console.WriteLine(loseMessage);
          }
          else if (userInput == "spock")
          {
            computerInput = "lizard";
            Console.WriteLine(displayComputerInput(computerInput));
            Console.WriteLine(loseMessage);
          }
          else if (userInput == "lizard")
          {
            computerInput = "rock";
            Console.WriteLine(displayComputerInput(computerInput));
            Console.WriteLine(loseMessage);
          }
        }

        // Ask user if they want to continue playing
        Console.WriteLine("Would you like to play again?");
        var answer = Console.ReadLine().ToLower();
        // Validate the answer and determine if to stop the game
        while (answer != "yes" && answer != "no")
        {
          Console.WriteLine("Not a valid answer, please reply with yes or no");
          answer = Console.ReadLine().ToLower();
        }
        if (answer == "no")
        {
          continuePlaying = false;
          Console.WriteLine("Thanks for playing. See you next time!");
        }
      }
    }
  }
}
