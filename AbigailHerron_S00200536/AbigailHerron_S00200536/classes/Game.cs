/*###########################################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 11/05/21
 GitHub Repository: https://github.com/AbigailHerron/OOD-Exam
 

Description: This document containes the Game class, and the GameData class (which is used to create a database)

     Class: Game
     Description: A blueprint for a Game object
     Properties: GameID, Name, Description, Platform, Game_Image, Metacritic_Score, Price
     Methods: DecreasePrice, ToString (override)
     Constructors: Default

     Class: GameData
     Description: Is a sub-class of DbContext, and is used to create the GameDataDb database
     Properties: Games (DbSet)
     Constructors: Default (base)
 ##########################################################################################################################*/
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbigailHerron_S00200536
{
    public class Game
    {
        /*PROPERTIES ------------------------------------------------------------------------------------------------------*/
        public int GameID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Platform { get; set; }
        public string GameImage { get; set; }
        public int CriticScore { get; set; }
        public decimal Price { get; set; }

        /*METHODS ---------------------------------------------------------------------------------------------------------*/
        /*Method: DecreasePrice()
                  1) Takes in a double value 
                  2) Decreases the price of the Game by percentage of the number value*/
        public void DecreasePrice(double number)
        {
            Price -=  (Price * (decimal) number);
        }// end DecreasePrice()



        /*Method: ToString()
                  1) Overrides original ToString() method
                  2) Returns the Name property of the Game object*/
        public override string ToString()
        {
            return this.Name;
        }// end ToString()
    }// end Game class


    public class GameData : DbContext
    {
        public GameData() : base("GameDataDb") { } // making the database

        public DbSet<Game> Games { get; set; } // Database table for Game objects
    }// end GameData sub-class

}// end AbigailHerron_S00200536 namespace
