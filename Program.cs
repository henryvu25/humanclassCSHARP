using System;
using System.Collections.Generic;

namespace test
{
    public class Wizard
    {
        public string name;
        public int magic = 20;
        public int health = 100;
        public Wizard(string passName)
        {
            name = passName;
        }
    

    }
    public class Human
    {
        public string name { get;set; }
        public string nickname { get;set; }
        public int magic { get;set; }
        public int strength = 3;
        public int intelligence = 3;
        public int dexterity = 3;
        public int health = 100;

        public Human(string passName)
        {
            name = passName;
        }
        public Human(string passName, int passMagic)
        {
            name = passName;
            magic = passMagic;
        }
        public Human(string passNickname, int passMagic, int passStrength = 9)
        {
            nickname = passNickname;
            magic = passMagic;
            strength = passStrength;
        }
        public Human(string passName, int passStrength = 3, int passIntelligence = 3, int passDexterity = 3, int passHealth = 100)
        {
            name = passName;
            strength = passStrength;
            intelligence = passIntelligence;
            dexterity = passDexterity;
            health = passHealth;
        }

        public void attack(object name)
        {
            Human enemy = name as Human;
            if(enemy != null)
            {
                enemy.health = enemy.health - (5*strength);
            }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human("Henry");
            System.Console.WriteLine($"{human1.name}'s health is {human1.health}");

            Human human2 = new Human("Jon", 5 , 10, 1, 100);
            System.Console.WriteLine(human2.dexterity);

            Human human3 = new Human("Merlin", 5);
            System.Console.WriteLine(human3.nickname);

            Human human4 = new Human("jayboy", 5, passStrength:9);
            System.Console.WriteLine(human4.strength);

            Wizard wizard1 = new Wizard("Harry");

            human4.attack(wizard1);
            System.Console.WriteLine(wizard1.health);
            human4.attack(human1);
            System.Console.WriteLine(human1.health);
        }
    }
}
