using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    class Program
    {
        //WHAT METHODS AM I GOING TO NEED FOR THE GAME 
        // CALL GAME TITLE METHOD
        //THEN AFTER MY MAIN METHOD


        static void Main(string[] args)
        {
           
            gameTitle();

        }
        //GAME TITLE METHOD
        public static void gameTitle()
        {
            // THIS DISPLAYS TO THE USER AND WELCOME SCREEN
            Console.WriteLine("Welcome to FLORISH");


            // THIS EXPLAINS THE GAME TO THE USER
            Console.WriteLine("Here you will outline and expereince the life of a high school student. ");
            Console.WriteLine("In Florish, its been a rough summer, don't forget you've been sheltered your whole life so you don't really know how to have friends let alone make new ones at 1151 academy");
            Console.WriteLine("Things for you started off rough but with a little bit of hope I'm sure we can get through it together!");
            Console.WriteLine("Florish explores some of the issues a new student trying to get to school has to go through, after all ");
            Console.WriteLine("No one likes being the new kid...well at least not this one");
            Console.WriteLine("But enough said, welome to FLORISH ....YOUR JORNEY AWAITS!");

            //SO THE GAME PAUSES AND WAITS FOR THE USERS COMAND
            Console.ReadLine();
            //CLEARS OFF THE SCREEN BEFORE I GO TO THE NEXT SCREEN 
            Console.Clear();
            //CALLING FIRST METHOD 
            //NOW ITS TIME TO BUILD YOU RFIRST METHOD
            first();
            //
        }
        


        public static void first()
        {
            string choice;
            //TEACHING / SHOWING WHAT THE GAME PLOT LINE IS 
            Console.WriteLine("You wake up and your late for school, the bus already left, you can't drive and its the last time your able to be late," +
                "ONLY ONE WAY WOKRS...CAN YOU GUESS THE RIGHT PATH..!!!!");

            Console.WriteLine("1.Call an Uber");
            Console.WriteLine("2.Stay at home!");
            Console.WriteLine("3.Walk to school");
            //CONSOLE .WRITE SO INPUT TXT GOES NEXT TO THE TEXT
            Console.Write("Please pick 1-3 ");
            //
            choice = Console.ReadLine().ToLower();




            //CLEAR THE CONSOLE ONCE THE USER MAKES AN INPUT
            Console.Clear();
            //SWITCH CASE ALLOWS THE USER TO PICK AN INPUT 



            
            switch (choice)
            {

                case "1":
                // THIS EXPLAINS WHAT IS GOING ON IN THE FIRST OPTION 
                    Console.WriteLine("You rush to get your phone from your room in a panic.");
                    Console.WriteLine("On the way up the stairs you fall and hurt your knee, oh NOOOOO!");
                    Console.WriteLine("finally going though your phone you realize you have an extra $10 from yesterday..YAY ");
                    Console.WriteLine("You call the uber get your shoes on and take a ride to school late but at least you dont have to worry about being tardy !..");
                    Console.ReadLine();
                    Console.Clear();


                    break;
                case "2":

                    {
                        Console.WriteLine("");
                        Console.WriteLine("Maybe next time we can get up on time for school!");
                        Console.ReadLine();
                        break;
                    }

                case "3":
                    {
                        Console.WriteLine();
                        Console.WriteLine("wow owo");

                        
                        break;
                        
                        
                    }
            }

        }

    }
}
