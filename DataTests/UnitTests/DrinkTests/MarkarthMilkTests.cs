/*
 * Author: Zachery Brunner
 * Class: MarkarthMilkTests.cs
 * Purpose: Test the MarkarthMilk.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class MarkarthMilkTests
    {
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            MarkarthMilk milk = new MarkarthMilk();
            Assert.False(milk.Ice);
        }

        [Fact]
        public void ShouldBySmallByDefault()
        {
            MarkarthMilk milk = new MarkarthMilk();
            Assert.Equal(Size.Small,milk.Size) ;
        }

        [Fact]
        public void ShouldByAbleToSetIce()
        {
            MarkarthMilk milk = new MarkarthMilk();
            milk.Ice = true;
            Assert.True(milk.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MarkarthMilk milk = new MarkarthMilk();
            milk.Size = Size.Medium;
            Assert.Equal(Size.Medium, milk.Size);
        }

        [Theory]
        [InlineData(Size.Small, 1.05)]
        [InlineData(Size.Medium, 1.11)]
        [InlineData(Size.Large, 1.22)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            MarkarthMilk milk = new MarkarthMilk();

            milk.Size = size;
            Assert.Equal(price, milk.Price);

        }

        [Theory]
        [InlineData(Size.Small, 56)]
        [InlineData(Size.Medium, 72)]
        [InlineData(Size.Large, 93)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            MarkarthMilk milk = new MarkarthMilk();

            milk.Size = size;
            Assert.Equal(cal, milk.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            MarkarthMilk milk = new MarkarthMilk();
            milk.Ice = includeIce;
            if (includeIce == true) Assert.Contains("Add ice", milk.SpecialInstructions);
            else Assert.Empty(milk.SpecialInstructions);

        }

        [Theory]
        [InlineData(Size.Small, "Small Markarth Milk")]
        [InlineData(Size.Medium, "Medium Markarth Milk")]
        [InlineData(Size.Large, "Large Markarth Milk")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MarkarthMilk milk = new MarkarthMilk();
            milk.Size = size;
            Assert.Equal($"{size} Markarth Milk", name);
        }

        [Fact]
        public void ShouldBeAssignableToInterfaceClass()
        {
            MarkarthMilk milk = new MarkarthMilk();
            Assert.IsAssignableFrom<IOrderItem>(milk);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            MarkarthMilk milk = new MarkarthMilk();
            Assert.IsAssignableFrom<Drink>(milk);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        public void HoldingShouldNotifyPropertiesChange(Size s)
        {
            MarkarthMilk milk = new MarkarthMilk();
            System.Action p = () =>
            {
                milk.Ice = true;
                milk.Size = s;

            };
            Assert.PropertyChanged(milk, "SpecialInstructions", p);
            Assert.PropertyChanged(milk, "Size", p);
            Assert.PropertyChanged(milk, "Ice", p);
            Assert.PropertyChanged(milk, "Price", p);
            Assert.PropertyChanged(milk, "Calories", p);


        }



        [Fact]
        public void ShouldDisplayCorrectDescription()
        {
            MarkarthMilk drink = new MarkarthMilk();
            Assert.Equal("Hormone-free organic 2% milk.", drink.Description);
        }


    }
}