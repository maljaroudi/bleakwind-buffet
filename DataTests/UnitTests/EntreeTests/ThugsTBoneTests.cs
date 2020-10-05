/*
 * Author: Zachery Brunner
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThugsTBoneTests
    {
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThugsTBone entree = new ThugsTBone();
            Assert.Equal(6.44, entree.Price);

        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThugsTBone entree = new ThugsTBone();
            Assert.Equal(982.0, entree.Calories);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            ThugsTBone entree = new ThugsTBone();

            Assert.Empty(entree.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThugsTBone entree = new ThugsTBone();
            Assert.Equal("Thugs T-Bone", entree.ToString());
        }

        [Fact]
        public void ShouldBeAssignableToInterfaceClass()
        {
            ThugsTBone entree = new ThugsTBone();
            Assert.IsAssignableFrom<IOrderItem>(entree);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            ThugsTBone entree = new ThugsTBone();
            Assert.IsAssignableFrom<Entree>(entree);
        }

        //No Property Change test since there is no one to begin with.
    }
}