/*
 * Author: Zachery Brunner
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThalmorTripleTests
    {
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            ThalmorTriple entree = new ThalmorTriple();
            Assert.True(entree.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            ThalmorTriple entree = new ThalmorTriple();
            Assert.True(entree.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            ThalmorTriple entree = new ThalmorTriple();
            Assert.True(entree.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            ThalmorTriple entree = new ThalmorTriple();
            Assert.True(entree.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            ThalmorTriple entree = new ThalmorTriple();
            Assert.True(entree.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            ThalmorTriple entree = new ThalmorTriple();
            Assert.True(entree.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            ThalmorTriple entree = new ThalmorTriple();
            Assert.True(entree.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            ThalmorTriple entree = new ThalmorTriple();
            Assert.True(entree.Mayo);
        }

        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            ThalmorTriple entree = new ThalmorTriple();
            Assert.True(entree.Bacon);
        }

        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            ThalmorTriple entree = new ThalmorTriple();
            Assert.True(entree.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            ThalmorTriple entree = new ThalmorTriple();
            entree.Bun = false;
            Assert.False(entree.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            ThalmorTriple entree = new ThalmorTriple();
            entree.Ketchup = false;
            Assert.False(entree.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            ThalmorTriple entree = new ThalmorTriple();
            entree.Mustard = false;
            Assert.False(entree.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            ThalmorTriple entree = new ThalmorTriple();
            entree.Pickle = false;
            Assert.False(entree.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            ThalmorTriple entree = new ThalmorTriple();
            entree.Cheese = false;
            Assert.False(entree.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            ThalmorTriple entree = new ThalmorTriple();
            entree.Tomato = false;
            Assert.False(entree.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            ThalmorTriple entree = new ThalmorTriple();
            entree.Lettuce = false;
            Assert.False(entree.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            ThalmorTriple entree = new ThalmorTriple();
            entree.Mayo = false;
            Assert.False(entree.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            ThalmorTriple entree = new ThalmorTriple();
            entree.Bacon = false;
            Assert.False(entree.Bacon);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            ThalmorTriple entree = new ThalmorTriple();
            entree.Egg = false;
            Assert.False(entree.Egg);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThalmorTriple entree = new ThalmorTriple();
            Assert.Equal(8.32, entree.Price);

        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThalmorTriple entree = new ThalmorTriple();
            Assert.Equal(943.0, entree.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
            ThalmorTriple entree = new ThalmorTriple();
            entree.Bun = includeBun;
            entree.Ketchup = includeKetchup;
            entree.Mustard = includeMustard;
            entree.Pickle = includePickle;
            entree.Cheese = includeCheese;
            entree.Lettuce = includeLettuce;
            entree.Tomato = includeTomato;
            entree.Mayo = includeMayo;
            entree.Bacon = includeBacon;
            entree.Egg = includeEgg;
            if (!includeBun) Assert.Contains("Hold bun", entree.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", entree.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", entree.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", entree.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", entree.SpecialInstructions);
            if (!includeLettuce) Assert.Contains("Hold lettuce", entree.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", entree.SpecialInstructions);
            if (!includeMayo) Assert.Contains("Hold mayo", entree.SpecialInstructions);
            if (!includeBacon) Assert.Contains("Hold bacon", entree.SpecialInstructions);
            if (!includeEgg) Assert.Contains("Hold egg", entree.SpecialInstructions);
            else Assert.Empty(entree.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThalmorTriple entree = new ThalmorTriple();

            Assert.Equal("Thalmor Triple", entree.ToString());
        }


        [Fact]
        public void ShouldBeAssignableToInterfaceClass()
        {
            ThalmorTriple entree = new ThalmorTriple();
            Assert.IsAssignableFrom<IOrderItem>(entree);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            ThalmorTriple entree = new ThalmorTriple();
            Assert.IsAssignableFrom<Entree>(entree);
        }
    }
}