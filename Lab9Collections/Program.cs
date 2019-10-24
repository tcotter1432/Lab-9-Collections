using System;
using System.Collections.Generic;

namespace Lab9Collections
{
    class Program
    {
        static List<Student> cSharpClass = new List<Student>();

        static void Main(string[] args)
        {
            PopulateList();
            bool isTrawling = true;
            Console.WriteLine("Welcome the Improved(TM) Interdimensional C-Sharp class!");
            while (isTrawling)
            {
                //Main Menu
                Console.WriteLine("What would you like to do today?\n 1. View a current student.\n 2. Add a new student. \n 3. Exit");
                switch(Console.ReadLine())
                {
                    case ("1"):
                        CurrentStudents();
                    break;
                    case ("2"):
                        AddStudent();
                    break;
                    case ("3"):
                        Console.WriteLine("Have a good one!");
                        isTrawling = false;
                    break;
                    default:
                        Console.WriteLine("Invalid input, please try again.");
                    break;

                }
            }
        }

        public static void CurrentStudents()
        {
            Console.WriteLine("Which student would you like to get information about? (Note: enter \"roster\" to see the class, enter \"back\" to go back.)");
            string input = Console.ReadLine();

            if (input == "roster")
            {
                PrintNames();
                CurrentStudents();
            }
            else if (input == "back")
            { 
                return; 
            }
            else
            {
                try
                {
                    int.Parse(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input!");
                    CurrentStudents();
                }
                int inputInt = int.Parse(input);
                if (inputInt > cSharpClass.Count || inputInt <= 0)
                {
                    Console.WriteLine("Invalid input!");
                    CurrentStudents();
                }
                else
                {
                    bool onStudent = true;
                    while (onStudent)
                    {
                        
                        Console.WriteLine($"What would you like to know about {cSharpClass[inputInt-1].GetName()}? \n 1. Favorite Weapon\n 2. Home World\n 3. Best Friend\n 4. Mortal Enemy\n 5. Fun Fact\n 6. Go Back");
                        switch (Console.ReadLine())
                        {
                            case ("1"):
                                Console.WriteLine($"{cSharpClass[inputInt - 1].GetName()}'s favorite weapon is {cSharpClass[inputInt - 1].GetFavoriteWeapon()}!");
                            break;
                            case ("2"):
                                Console.WriteLine($"{cSharpClass[inputInt - 1].GetName()}'s home world is {cSharpClass[inputInt - 1].GetHomeWorld()}!");
                            break;
                            case ("3"):
                                Console.WriteLine($"{cSharpClass[inputInt - 1].GetName()}'s best friend is {cSharpClass[inputInt - 1].GetBestFriend()}!");
                            break;
                            case ("4"):
                                Console.WriteLine($"{cSharpClass[inputInt - 1].GetName()}'s mortal enemy is {cSharpClass[inputInt - 1].GetMortalEnemy()}!");
                            break;
                            case ("5"):
                                Console.WriteLine(cSharpClass[inputInt - 1].GetFunFact());
                            break;
                            case ("6"):
                                onStudent = false;
                                CurrentStudents();
                            break;
                            default:
                                Console.WriteLine("Invalid input!");
                            break;
                        }
                    }
                }
            }
        }

        public static void PrintNames()
        {
            for(int i = 0; i < cSharpClass.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {cSharpClass[i].GetName()}");
            }
        }

        //Method to add a student to the List
        public static void AddStudent()
        {
            //Get their name
            Console.Write("What is their name? ");
            string name = Console.ReadLine();

            //Favorite Weapon
            Console.Write("What is their favorite weapon? ");
            string favoriteWeapon = Console.ReadLine();

            //Home World
            Console.Write("Where are they from? ");
            string homeWorld = Console.ReadLine();

            //Best Friend
            Console.Write("Who is their best friend? ");
            string bestFriend = Console.ReadLine();

            //Mortal Enemy
            Console.Write("Who have they spent most of their life trying to destroy? ");
            string mortalEnemy = Console.ReadLine();

            //Fun Fact
            Console.Write("What is something interesting about them and/or them and this class? ");
            string funFact = Console.ReadLine();

            //Add the new student to the list
            cSharpClass.Add(new Student(name, favoriteWeapon, homeWorld, bestFriend, mortalEnemy, funFact));
            Console.WriteLine($"\nWelcome to the class {name}!");

        }

        //initial List population
        public static void PopulateList()
        {
            cSharpClass.Add(new Student("Link", "The Master Sword", "Hyrule", "Princess Zelda", "Ganondorf", "He never speaks in class. Ever."));
            cSharpClass.Add(new Student("Ryne", "A Pair of Daggers", "The First", "Thancred", "The Light", "She was originally called \"Minfillia\"."));
            cSharpClass.Add(new Student("Male Corrin", "the Yato", "Valla", "Beruka", "Anankanos", "He doesn't get why there's a female version of himself in the class."));
            cSharpClass.Add(new Student("DoomGuy", "the BFG", "????", "Ammunition", "Hell", "He doesn't know why he's here."));
            cSharpClass.Add(new Student("Geralt of Rivia", "a set of Steel and Silver Swords", "The Witcher World", "Triss Merigold", "The Wild Hunt", "He took a contract, and it involved portals."));
            cSharpClass.Add(new Student("The Emperor of Mankind", "the Legiones Astartes", "Holy Terra", "N/A", "Horus", "The Golden Throne uses C# to run."));
            cSharpClass.Add(new Student("Chuck Norris", "a Roundhouse Kick", "Earth", "God", "no one living", "He already knows everything about C#."));
            cSharpClass.Add(new Student("Ganondorf", "a Giant Sword", "Hyrule", "N/A", "Link", "He spends most, if not all, of class giving withering glares towards Zelda and Link."));
            cSharpClass.Add(new Student("Princess Zelda", "a Bow of Light", "Hyrule","Link","Gannondorf", "She's always sitting on the far side of Link from Gannondorf for some reason."));
            cSharpClass.Add(new Student("Female Corrin", "the Yato", "Valla", "Silas", "Anankanos", "She's confused as to why there's a male version of herself as well."));

        }
    }

    //Student Class
    class Student
    {
        //Class Variables
        string name;
        string favoriteWeapon;
        string homeWorld;
        string bestFriend;
        string mortalEnemy;
        string funFact;

        //Constructor
        public Student(string iName, string iFavoriteWeapon, string iHomeWorld, string iBestFriend, string iMortalEnemy, string iFunFact)
        {
            name = iName;
            favoriteWeapon = iFavoriteWeapon;
            homeWorld = iHomeWorld;
            bestFriend = iBestFriend;
            mortalEnemy = iMortalEnemy;
            funFact = iFunFact;
        }

        //Get methods for class variables
        public string GetName()
        {
            return name;
        }

        public string GetFavoriteWeapon()
        {
            return favoriteWeapon;
        }

        public string GetHomeWorld()
        {
            return homeWorld;
        }
        
        public string GetBestFriend()
        {
            return bestFriend;
        }

        public string GetMortalEnemy()
        {
            return mortalEnemy;
        }

        public string GetFunFact()
        {
            return funFact;
        }
    }
}