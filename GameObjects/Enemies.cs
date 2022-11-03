using Experiences;

namespace Enemies
{
    class Enemy
    {
        string type;
        public Dictionary<string, int> attacks = new Dictionary<string, int>();
        int health;
        int attack;
        int defense;

        public Enemy(string Type)
        {
            type = Type;

            // Selects enemy stats & attacks based off type of enemy
            switch (type)
            {
                case "rat":
                    health = Experience.RollStats(1, 25);
                    attack = Experience.RollStats(1, 10);
                    defense = Experience.RollStats(1, 10);
                    attacks.Add("Scratch", 2);
                    attacks.Add("Bite", 3);
                    break;
                case "spider":
                    health = Experience.RollStats(10, 50);
                    attack = Experience.RollStats(7, 20);
                    defense = Experience.RollStats(1, 10);
                    attacks.Add("Crunch", 3);
                    attacks.Add("String Shot", 4);
                    break;
                case "golem":
                    health = Experience.RollStats(50, 100);
                    attack = Experience.RollStats(10, 25);
                    defense = Experience.RollStats(1, 15);
                    attacks.Add("Punch", 5);
                    attacks.Add("Slam", 7);
                    break;
            }
        }
    }
}