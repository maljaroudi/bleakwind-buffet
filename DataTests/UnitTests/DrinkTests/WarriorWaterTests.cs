/*
 * Author: Moheeb Aljaroudi
 * Class: WarriorWaterTests.cs
 * Purpose: Test the WarriorWater.cs class in the Data library
 */
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class WarriorWaterTests
    {
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            WarriorWater drink = new WarriorWater();
            Assert.True(drink.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            WarriorWater drink = new WarriorWater();
            Assert.Equal(Size.Small, drink.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            WarriorWater drink = new WarriorWater();
            drink.Ice = true;
            Assert.True(drink.Ice);


        }
        [Fact]
        public void ShouldBeAbleToSetLemon()
        {
            WarriorWater drink = new WarriorWater();
            drink.Lemon = true;
            Assert.True(drink.Lemon);

        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            WarriorWater drink = new WarriorWater();
            drink.Size = Size.Medium;
            Assert.Equal(Size.Medium, drink.Size);
        }

        [Fact]
        public void ShouldHaveCorrectPrice()
        {
            WarriorWater drink = new WarriorWater();
            Assert.Equal(0.0, drink.Price);

        }

        [Fact]
        public void ShouldHaveCorrectCalories()
        {
            WarriorWater drink = new WarriorWater();
            Assert.Equal(0.0, drink.Calories);
        }

        [Theory]
        [InlineData(true,true)]
        [InlineData(false,false)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            WarriorWater drink = new WarriorWater();
            drink.Ice = includeIce;
            drink.Lemon = includeLemon;
            if(!includeIce) Assert.Contains("Hold ice", drink.SpecialInstructions);
            if(includeLemon) Assert.Contains("Add lemon", drink.SpecialInstructions);
        }
    }
}
