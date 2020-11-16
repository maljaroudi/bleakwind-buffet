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
using BleakwindBuffet.Data;

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

        [Fact]
        public void ShouldBeAssignableToInterfaceClass()
        {
            WarriorWater drink = new WarriorWater();
            Assert.IsAssignableFrom<IOrderItem>(drink);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            WarriorWater drink = new WarriorWater();
            Assert.IsAssignableFrom<Drink>(drink);
        }


        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        public void HoldingShouldNotifyPropertiesChange(Size s)
        {
            WarriorWater drink = new WarriorWater();
            System.Action p = () =>
            {
                drink.Ice = false;
                drink.Size = s;

            };
            Assert.PropertyChanged(drink, "SpecialInstructions", p);
            Assert.PropertyChanged(drink, "Size", p);
            Assert.PropertyChanged(drink, "Ice", p);
            Assert.PropertyChanged(drink, "Price", p);


        }


        [Fact]
        public void ShouldDisplayCorrectDescription()
        {
            WarriorWater drink = new WarriorWater();
            Assert.Equal("It’s water. Just water.", drink.Description);
        }

    }
}
