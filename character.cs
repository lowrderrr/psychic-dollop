using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensVsRobots
{

    
    //set access modifier to public
    
    public class Character
    {

        //declare our variables
        //common characteristics of the class
        //nonuns
        protected string characterName;
        protected string characterClass;
        protected string characterAlignment;
        protected int healthPoints;
        protected int xp;
        protected int damage;


        //create a basic constructor
        public Character()
        {
            this.characterName = "Player 1";
        
        }

        //create an overloaded constructor to read-in
        //value for character name
        public Character(string _characterName)
        {
            //main job is to instatiate object

            //set default values for objects
            this.healthPoints = 100;
            this.xp = 0;
            this.characterAlignment = "neutral";


            //set custom values
            //marry the input parameter with the local variable
            this.characterName = _characterName;
        
        
        }

        //public proptery to permit the reading of the charName varible
        public string GetCharacterName
        {

            //creaet get operation to "read" value stored in charName var
            get { return this.characterName; }
        
        }

        //create a method that will publish a heads up display of character info
        public void CharacterHUD()
        {
            //creaet several console.writeline() to printo char info to screen
            Console.WriteLine($"Character Name: {this.characterName}");
            Console.WriteLine($"Character Class: {this.characterClass}");
            Console.WriteLine($"Character Alignment: {this.characterAlignment}");
            Console.WriteLine($"Healthpoints: {this.healthPoints}");
            Console.WriteLine($"XP: {this.xp}");
            Console.WriteLine($"Default Damage: {this.damage}\n");



        }



    }
}
