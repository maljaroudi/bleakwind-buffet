/*
 * Author: Zachery Brunner
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class PhillyPoacherTests
    {
        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
            PhillyPoacher entree = new PhillyPoacher();
            Assert.True(entree.Sirloin);
        }

        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
            PhillyPoacher entree = new PhillyPoacher();
            Assert.True(entree.Onion);
        }

        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            PhillyPoacher entree = new PhillyPoacher();
            Assert.True(entree.Roll);
        }

        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            PhillyPoacher entree = new PhillyPoacher();
            entree.Sirloin = false;
            Assert.False(entree.Sirloin);
        }

        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            PhillyPoacher entree = new PhillyPoacher();
            entree.Onion = false;
            Assert.False(entree.Onion);
        }

        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            PhillyPoacher entree = new PhillyPoacher();
            entree.Roll = false;
            Assert.False(entree.Roll);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            PhillyPoacher entree = new PhillyPoacher();
            Assert.Equal(7.23, entree.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            PhillyPoacher entree = new PhillyPoacher();
            Assert.Equal(784.0, entree.Calories);
        }

        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
            PhillyPoacher entree = new PhillyPoacher();
            entree.Sirloin = includeSirloin;
            entree.Onion = includeOnion;
            entree.Roll = includeRoll;
            if (!includeSirloin) Assert.Contains("Hold sirloin", entree.SpecialInstructions);
            if (!includeOnion) Assert.Contains("Hold onions", entree.SpecialInstructions);
            if (!includeRoll) Assert.Contains("Hold roll", entree.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            PhillyPoacher entree = new PhillyPoacher();
            Assert.Equal("Philly Poacher", entree.ToString());

        }

        [Fact]
        public void ShouldBeAssignableToInterfaceClass()
        {
            PhillyPoacher entree = new PhillyPoacher();
            Assert.IsAssignableFrom<IOrderItem>(entree);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            PhillyPoacher entree = new PhillyPoacher();
            Assert.IsAssignableFrom<Entree>(entree);
        }



        [Theory]
        [InlineData("Sirloin")]
        [InlineData("Onion")]
        [InlineData("Roll")]
        public void HoldingShouldNotifyPropertiesChange(string s)
        {
            PhillyPoacher entree = new PhillyPoacher();
            System.Action p = () =>
            {
                entree.Sirloin = false;
                entree.Onion = false;
                entree.Roll = false;
            };
            Assert.PropertyChanged(entree, "SpecialInstructions", p);
            Assert.PropertyChanged(entree, s, p);



        }



        [Fact]
        public void ShouldDisplayCorrectDescription()
        {
            PhillyPoacher entree = new PhillyPoacher();
            Assert.Equal("Cheesesteak sandwich made from grilled sirloin, topped with onions on a fried roll.", entree.Description);
        }
    }
}