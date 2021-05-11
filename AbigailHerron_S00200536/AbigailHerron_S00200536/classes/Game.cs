/*###########################################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 11/05/21
 GitHub Repository: https://github.com/AbigailHerron/OOD-Exam
 
 Description:
 Properties:
 Methods: DecreasePrice
 Constructors: Default
 ##########################################################################################################################*/
using System;
using System.Collections.Generic;
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
        public string Game_Image { get; set; }
        public int Metacritic_Score { get; set; }
        public decimal Price { get; set; }

        /*METHODS ---------------------------------------------------------------------------------------------------------*/
        /*Method: DecreasePrice()
                  1) Takes in a double value 
                  2) Decreases the price of the Game by percentage of the number value*/
        public void DecreasePrice(double number)
        {
            Price -=  (Price * (decimal) number);
        }// end DecreasePrice()

    }// end Game class


}// end AbigailHerron_S00200536 namespace
