using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensVsRobots
{
    //set access modifier to public
    public class Game
    {
        //create a var to store user input for char name
        string inputCharacterName;


        //create a method to play game
        public void PlayGame()
        {
            //ask the user for input
            Console.WriteLine("What is your character's name:");

            //cache the user input and store in local var
            inputCharacterName = Console.ReadLine();

            //instatiate a ranger
            Ranger myRanger1 = new Ranger(inputCharacterName);

            //clear the console
            Console.Clear();

            //update the HUD
            myRanger1.CharacterHUD();

            Console.ReadLine();

            //clear the console
            //ask for user input
            Console.WriteLine("What is the name of the Wizard in your Adventure Party?\n");

            //cache user input and pass thorugh to the Wizard constructor
            inputCharacterName = Console.ReadLine();

            //instantiate a Wizard
            Wizard myWizard1 = new Wizard(inputCharacterName);

            //clear the console
            Console.Clear();

            //call the HUD for the wizard
            myWizard1.CharacterHUD();

            Console.ReadLine();

            

        }

        //character creation method
        public void CreateCharacterMethod()
        {
            //instatiate a character and pass in the
            //user provided character name
            //Character myCharacter1 = new Character();

            //instead of using the basic constructor
            //use the overloaded constrauctor
            //that reads-in the user provided value
            Character myCharacter1 = new Character(inputCharacterName);

            //print char name to screen
            Console.WriteLine($"The value stored in the myCharacter1 object is: {myCharacter1.GetCharacterName}");

            Console.ReadLine();

        }

        //creaet a method to spawn an NPC
        public void UseTheNPC()
        {
            //clear the console
            Console.Clear();
            
            Console.WriteLine("Press enter to instantiante an NPC (Orc):");

            Console.ReadLine();

            //instantiate
            Orc myNpc1 = new Orc();

            //pull up the HUD for the Orc
            myNpc1.NPCHUD();

            Console.ReadLine();

        
        }




