using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherForcast
{
    public class Dice
    {
        public string DiceId { get; set; }

        public int Value { get; set; }

        public int MaxValue { get; set; }

        public int GetMaxValue() => MaxValue;
    }
}
