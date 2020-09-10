using System;
using WeatherForcast;
using Xunit;

namespace DiceTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {             // Arrange            
            Dice dice = new Dice { MaxValue = 6 };              
            // Act             
            int expected = 6;            
            int actual = dice.GetMaxValue();             
            // Assert             
            Assert.Equal(actual, expected);         
        }
    }
}
