using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator
{
    internal class Arena
    {
        public Battle battle;
        public int pointsChallenger;
        public int pointsOpponent;
        public int drawPoints;
        public int rounds;
        public int battles;
        public Arena(Battle battle)
        {
            this.battle = battle;
            pointsChallenger = 0;
            pointsOpponent = 0;
            drawPoints = 0;
            rounds = 0;
            battles = 0;
        }

        public void checkResult(Trainer challenger, Trainer opponent)
        {
            Console.WriteLine("\nThis is the final result");
            Console.WriteLine("Total battles: " + battles);
            Console.WriteLine("Total rounds: " + rounds);
            Console.WriteLine("Total rounds win " + challenger.getName() + ": " + pointsChallenger);
            Console.WriteLine("Total rounds win " + opponent.getName() + ": " + pointsOpponent);
            Console.WriteLine("Total rounds draw: " + drawPoints);
        }

        public void ArenaBattle()
        {
            while (true)
            {
                string result = battle.pokemonBattle();

                if (result == "trainer 1")
                {
                    pointsChallenger += 1;
                }
                else if (result == "trainer 2")
                {
                    pointsOpponent += 1;
                }
                else
                {
                    drawPoints += 1;
                }

                battles += battle.getRoundsInBattle();
                rounds += 1;
                Console.WriteLine("Another round? (y/n)");
                string answer = Console.ReadLine();

                if (answer.ToLower() != "y")
                {
                    checkResult(battle.getChallenger(), battle.getOpponent());
                    Console.WriteLine("\nPress ENTER to exit");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    var x = battle.getChallenger();
                    var y = battle.getOpponent();
                    x.reviveAll();
                    y.reviveAll();
                    battle.setChallenger(x);
                    battle.setOpponent(y);
                }
            }
        }
    }
}