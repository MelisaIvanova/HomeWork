using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Football
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating players

            var playerOne = new Goalkeeper { Name = "Ray Clemence", Number = 5, Age = 30, Height = 181 };
            var playerTwo = new Defender { Name = "Sergio Ramos", Number = 1, Age = 29, Height = 170 };
            var playerThree = new Midfield { Name = "Lino Gramus", Number = 9, Age = 22, Height = 174 };
            var playerFour = new Striker { Name = "Cristiano Ronaldo", Number = 7, Age = 38, Height = 180 };
            //Creating coach
            var coach = new Coach { Name = "Kevin Sumlin", Age = 40 };
            //Creating Team
            var team = new Team { Coach = coach, Players = new List<Football_player> { playerOne, playerTwo, playerThree, playerFour } };
            //Calculating the average age of the team
            var averageAge = team.AverageAge();
            //Creating Referee
            var referee = new Referee { Name = "Mark Clattenburg", Age = 48 };
            //Create AssistantReferee
            var assistantRefereeOne = new Referee { Name = "Georgi Filous", Age = 33 };
            var assistantRefereeTwo = new Referee { Name = "Martin Denez", Age = 29 };

            //Create Goal
            var goal = new Goal { Player = playerThree, Minute = 18 };


            //Create a game instance
            var game = new Game
            {
                Referee = referee,
                Team1 = team,
                Team2 = team,
                Goals = new List<string> { $"10' Player:{playerFour} Name = Cristiano Ronaldo, Number = 7, Age = 38, Height = 180", $"25' Player:{playerTwo} Name = Sergio Ramos, Number = 1, Age = 29, Height = 170 " },
                Result = "2-0",
                Winner = "Team 2",
               Assistant=$"{assistantRefereeOne}: Name = Georgi Filous, Age = 33 "

                
            };

            //Print the result of the game//
            game.PrintResult();






        }
    }
}