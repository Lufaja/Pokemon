using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator
{
    internal class Battle
    {
        private Trainer challenger;
        private Trainer opponent;
        private int roundsInBattle;

        public Battle(Trainer trainer1, Trainer trainer2)
        {
            this.challenger = trainer1;
            this.opponent = trainer2;
        }

        public Trainer getChallenger()
        {
            return challenger;
        }
        public Trainer getOpponent()
        {
            return opponent;
        }
        public int getRoundsInBattle()
        {
            return roundsInBattle;
        }
        public void setChallenger(Trainer challenger)
        {
            this.challenger = challenger;
        }
        public void setOpponent(Trainer opponent)
        {
            this.opponent = opponent;
        }
        public void setRoundsinBattle(int roundsInBattle)
        {
            this.roundsInBattle = roundsInBattle;
        }
        public string pokemonBattle()
        {
            Console.Write('\n');
            int numBattle = 0;
            int pointChallenger = 0;
            int pointOpponent = 0;
            int drawPoints = 0;
            string winner = "none";
            Pokeball challengerPokeball = challenger.pickRandomPokeball();
            Pokeball opponentPokeball = opponent.pickRandomPokeball(); 
            Pokemon challengerPokemon = null;
            Pokemon opponentPokemon = null;

            while (true)
            {
                if (!challenger.checkBelt() || !opponent.checkBelt())
                {
                    challenger.CallBack(challengerPokemon);
                    opponent.CallBack(opponentPokemon);
                    break;
                }

                if (winner == "trainer 1")
                {
                    opponentPokeball = opponent.pickRandomPokeball();
                    opponentPokemon = opponent.Throw(opponentPokeball);
                }
                else if (winner == "trainer 2")
                {
                    challengerPokeball = challenger.pickRandomPokeball();
                    challengerPokemon = challenger.Throw(challengerPokeball);
                }
                else
                {
                    challengerPokeball = challenger.pickRandomPokeball();
                    challengerPokemon = challenger.Throw(challengerPokeball);
                    opponentPokeball = opponent.pickRandomPokeball();
                    opponentPokemon = opponent.Throw(opponentPokeball);
                }
                if (challengerPokemon.getStrength() == opponentPokemon.getWeakness())
                {
                    opponentPokemon.setAlive(false);
                    opponent.CallBack(opponentPokemon);
                    Console.WriteLine(challenger.getName() + " wins!\n");
                    winner = "trainer 1";
                    pointChallenger += 1;
                }
                else if (opponentPokemon.getStrength() == challengerPokemon.getWeakness())
                {
                    challengerPokemon.setAlive(false);
                    challenger.CallBack(challengerPokemon);
                    Console.WriteLine(opponent.getName() + " wins!\n");
                    winner = "trainer 2";
                    pointOpponent += 1;
                }
                else
                {
                    if (winner == "trainer 1")
                    {
                        challengerPokemon.setAlive(false);
                        challenger.CallBack(challengerPokemon);
                        winner = "trainer 2";
                    }
                    else if (winner == "trainer 2")
                    {
                        opponentPokemon.setAlive(false);
                        opponent.CallBack(opponentPokemon);
                        winner = "trainer 1";
                    }
                    else
                    {
                        opponentPokemon.setAlive(false);
                        challengerPokemon.setAlive(false);
                        challenger.CallBack(challengerPokemon);
                        opponent.CallBack(opponentPokemon);
                    }
                    Console.WriteLine("Its a draw!\n");
                    drawPoints += 1;
                }
                numBattle += 1;
            }

            Console.WriteLine("End");
            Console.WriteLine("Battles fought: " + numBattle);
            Console.WriteLine("points " + challenger.getName() + ": " + pointChallenger);
            Console.WriteLine("points " + opponent.getName() + ": " + pointOpponent);
            Console.WriteLine("Draws: " + drawPoints);
            roundsInBattle = numBattle;

            if (pointChallenger > pointOpponent)
            {
                Console.WriteLine(challenger.getName() + " wins the battle!");
                return "trainer 1";
            }
            else if (pointOpponent > pointChallenger)
            {
                Console.WriteLine(opponent.getName() + " wins the battle!");
                return "trainer 2";
            }
            else
            {
                Console.WriteLine("You guys drawed");
                return "draw";
            }
        }
    }
}
