using System;
using System.Collections.Generic;

namespace CruelPlan
{
    public class Gandalf
    {
        private int happinesPoints;

        public Gandalf()
        {
            this.happinesPoints = 0;
        }

        public int HappinesPoints
        {
            get { return this.happinesPoints; }
        }

        public void EatFood(string food)
        {
            Dictionary<string, int> foodHapinessPoints = new Dictionary<string, int>();
            foodHapinessPoints["cram"] = 2;
            foodHapinessPoints["lembas"] = 3;
            foodHapinessPoints["apple"] = 1;
            foodHapinessPoints["melon"] = 1;
            foodHapinessPoints["honeycake"] = 5;
            foodHapinessPoints["mushrooms"] = -10;

            if (foodHapinessPoints.ContainsKey(food))
            {
                this.happinesPoints += foodHapinessPoints[food];
            }
            else
            {
                this.happinesPoints--;
            }
        }

        public string Mood()
        {
            string mood = "";

            if (this.happinesPoints < - 5)
            {
                mood = "Angry";
            }

            if (this.happinesPoints >= -5 && this.happinesPoints <= 0)
            {
                mood = "Sad";
            }

            if (this.happinesPoints >= 1 && this.happinesPoints <= 15)
            {
                mood = "Happy";
            }

            if (this.happinesPoints > 15)
            {
                mood = "JavaScript";
            }

            return mood;
        }
    }
}
