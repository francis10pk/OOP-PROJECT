using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Food
{
    public class Meal
    {
        private string food;
        private decimal rate;
        private TimeSpan time;

        public Meal() { }
        public Meal(string food, decimal rate, TimeSpan time)
        {
            this.food = food;
            this.rate = rate;
            this.time = time;
        }

        public string Food { get => food; set => food = value; }
        public decimal Rate { get => rate; set => rate = value; }
        public TimeSpan Time { get => time; set => time = value; }
    }
}
