using System;

namespace Dice_Game
{
  class Program
  {
    static void Main(string[] args)
    {
      int playerRndNum;
      int enemyRndNum;

      int playerPoints = 0;
      int enemyPoints = 0;

      Random rdn = new Random();

      for (int i = 0; i < 10; i++)
      {
          Console.WriteLine("Press any key to roll the dice.");

          Console.ReadKey();
        
          playerRndNum = rdn.Next(1, 7); //this will generate any number from 1 to 6
          Console.WriteLine($"You rolled a {playerRndNum}");

//this is to allow 1s before printing enemy number
//like TimeOut in JS
          Console.WriteLine("...");
          System.Threading.Thread.Sleep(1000);

          enemyRndNum = rdn.Next(1,7);
          Console.WriteLine($"Enemy AI rolled a {enemyRndNum}");

          if(playerRndNum > enemyRndNum)
          {
            playerPoints++;
            Console.WriteLine($"Player wins round {i+1}!");
          } else if (playerRndNum < enemyRndNum)
          {
            enemyPoints++;
            Console.WriteLine($"Enemy wins round {i+1}!");
          } else
          {
            Console.WriteLine("Draw!");
          }

          Console.WriteLine($"The score is now Player: {playerPoints} Enemy: {enemyPoints}");
          Console.WriteLine();
      }
        
      

      if(playerPoints > enemyPoints)
      {
        Console.WriteLine("Player wins!");
      } else if (playerPoints < enemyPoints)
      {
        Console.WriteLine("Sorry, enemy wins!");
      }
      else
      {
        Console.WriteLine("It's a draw");
      }
      Console.ReadKey();
    }
  }
}
