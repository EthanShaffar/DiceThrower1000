using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Thrower_1k
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calling ThrowDice function with 3 different values
            //"(num)d(num)"
            ThrowDice("10d6");
            ThrowDice("3d20");
            ThrowDice("100d6");
            Console.ReadKey();
        }
        //This function will take a string (2d20) and split it out.
        //taking the 1st number as amount going to throw.
        //taking the 2nd number as the sides of the dice.
        static void ThrowDice(string diceString)
        {
            //list the input needs to be split into an array and convert to numbers
            var diceStat = diceString.Split('d');
            var diceNum = Convert.ToInt32(diceStat[0]);
            var diceSide = Convert.ToInt32(diceStat[1]);
            //need to take the side variable and put into a random calculation amount.
            var random = new Random();
            Console.WriteLine("Throwing: " + diceString);
            Console.WriteLine("Results: ");
            //Taking the Amount of die used as length/times, we loop through 
            //the range with the random for results.
            for (var i = 1; i <= diceNum; i++)
            {
                var calcSide = random.Next(1, diceSide + 1);
                Console.Write(calcSide+ " ");
                
            }
            Console.WriteLine(" "); //Make it look pretty ^,^
        }
    }
}
