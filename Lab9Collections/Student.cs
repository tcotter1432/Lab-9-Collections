using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9Collections
{
    //Student Class
    class Student
    {
        #region Fields
        private string name;
        private string favoriteWeapon;
        private string homeWorld;
        private string bestFriend;
        private string mortalEnemy;
        private string funFact;
        #endregion
        #region Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string FavoriteWeapon
        {
            get { return favoriteWeapon; }
            set { favoriteWeapon = value; }
        }
        public string HomeWorld
        {
            get { return homeWorld; }
            set { homeWorld = value; }
        }
        public string BestFriend
        {
            get { return bestFriend; }
            set { bestFriend = value; }
        }
        public string MortalEnemy
        {
            get { return mortalEnemy; }
            set { mortalEnemy = value; }
        }
        public string FunFact
        {
            get { return funFact; }
            set { funFact = value; }
        }
        #endregion

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
    }
}