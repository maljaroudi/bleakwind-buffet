/*
 * Author: Zachery Brunner
 * Modified by: Moheeb Aljaroudi
 * Class: AretinoAppleJuiceTests.cs
 * Purpose: Test the AretinoAppleJuice.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class AretinoAppleJuiceTests
    {
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            AretinoAppleJuice juice = new AretinoAppleJuice();
            Assert.False(juice.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            AretinoAppleJuice juice = new AretinoAppleJuice();
            Assert.Equal(Size.Small, juice.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            AretinoAppleJuice juice = new AretinoAppleJuice();
            juice.Ice = true;
            Assert.True(juice.Ice);


        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            AretinoAppleJuice juice = new AretinoAppleJuice();
            juice.Size = Size.Medium;
            Assert.Equal(Size.Medium, juice.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.62)]
        [InlineData(Size.Medium, 0.87)]
        [InlineData(Size.Large, 1.01)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            AretinoAppleJuice juice = new AretinoAppleJuice();
            juice.Size = size;
            Assert.Equal(price, juice.Price);

        }

        [Theory]
        [InlineData(Size.Small, 44)]
        [InlineData(Size.Medium, 88)]
        [InlineData(Size.Large, 132)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            {
                AretinoAppleJuice juice = new AretinoAppleJuice();
                juice.Size = size;
                Assert.Equal(cal, juice.Calories);
            }
        }
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
                AretinoAppleJuice juice = new AretinoAppleJuice();
                juice.Ice = includeIce;
                if (includeIce == true) Assert.Contains("Add ice", juice.SpecialInstructions);
                else Assert.Empty(juice.SpecialInstructions);
                


        }
            

            [Theory]
        [InlineData(Size.Small, "Small Aretino Apple Juice")]
        [InlineData(Size.Medium, "Medium Aretino Apple Juice")]
        [InlineData(Size.Large, "Large Aretino Apple Juice")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            AretinoAppleJuice juice = new AretinoAppleJuice();
            juice.Size = size;
            Assert.Equal($"{size} Aretino Apple Juice", name);
        }

        [Fact]
        public void ShouldBeAssignableToInterfaceClass()
        {
            AretinoAppleJuice juice = new AretinoAppleJuice();
            Assert.IsAssignableFrom<IOrderItem>(juice);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            AretinoAppleJuice juice = new AretinoAppleJuice();
            Assert.IsAssignableFrom<Drink>(juice);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        public void HoldingShouldNotifyPropertiesChange(Size s)
        {
            AretinoAppleJuice juice = new AretinoAppleJuice();
            System.Action p = () =>
            {
                juice.Ice = false;
                juice.Size = s;
                
            };
            Assert.PropertyChanged(juice, "SpecialInstructions", p);
            Assert.PropertyChanged(juice, "Size", p);
            Assert.PropertyChanged(juice, "Ice", p);
            Assert.PropertyChanged(juice, "Price", p);
            Assert.PropertyChanged(juice, "Calories", p);

            
        }

        [Fact]
        public void ShouldDisplayCorrectDescription()
        {
            AretinoAppleJuice drink = new AretinoAppleJuice();
            Assert.Equal("Fresh squeezed apple juice.", drink.Description);
        }


    }
}