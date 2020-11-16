/*
 * Author: Zachery Brunner
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class DragonbornWaffleFriesTests
    {
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            DragonbornWaffleFries side = new DragonbornWaffleFries();
            Assert.Equal(Size.Small, side.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            DragonbornWaffleFries side = new DragonbornWaffleFries();
            side.Size = Size.Medium;
            Assert.Equal(Size.Medium, side.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            DragonbornWaffleFries side = new DragonbornWaffleFries();
            Assert.Empty(side.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.42)]
        [InlineData(Size.Medium, 0.76)]
        [InlineData(Size.Large, 0.96)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            DragonbornWaffleFries side = new DragonbornWaffleFries();
            side.Size = size;
            Assert.Equal(price, side.Price);
        }

        [Theory]
        [InlineData(Size.Small, 77)]
        [InlineData(Size.Medium, 89)]
        [InlineData(Size.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            DragonbornWaffleFries side = new DragonbornWaffleFries();
            side.Size = size;
            Assert.Equal(calories, side.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Dragonborn Waffle Fries")]
        [InlineData(Size.Medium, "Medium Dragonborn Waffle Fries")]
        [InlineData(Size.Large, "Large Dragonborn Waffle Fries")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            DragonbornWaffleFries side = new DragonbornWaffleFries();
            side.Size = size;
            Assert.Equal(name,$"{size} Dragonborn Waffle Fries");
        }

        [Fact]
        public void ShouldBeAssignableToInterfaceClass()
        {
            DragonbornWaffleFries side = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<IOrderItem>(side);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            DragonbornWaffleFries side = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<Side>(side);
        }


        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        public void HoldingShouldNotifyPropertiesChange(Size s)
        {
            DragonbornWaffleFries side = new DragonbornWaffleFries();
            System.Action p = () =>
            {
                side.Size = s;

            };
            Assert.PropertyChanged(side, "Size", p);
            Assert.PropertyChanged(side, "Price", p);
            Assert.PropertyChanged(side, "Calories", p);


        }


        [Fact]
        public void ShouldDisplayCorrectDescription()
        {
            DragonbornWaffleFries side = new DragonbornWaffleFries();
            Assert.Equal("Crispy fried potato waffle fries.", side.Description);
        }
    }
}